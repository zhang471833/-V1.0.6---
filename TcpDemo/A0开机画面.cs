using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using SCADA.Comm;
using SCADA.Drive;
using System.Windows.Forms.DataVisualization.Charting;
using DBNames;

namespace TcpDemo
{

    public partial class A0开机画面 : Form
    {
        //定义变量，变量类型为登录窗体
        frmLogin login;
        //定义字符串变量为空，logs：操作日志
        String logs = "";
        /// <summary>
        /// 定义一个属性，窗体关闭的属性
        /// </summary>
        public bool IsClosed { get; set; }
      
         

        A0主画面 Main = new A0主画面();
        A1电子UV干燥机 UV_Dry_3 = new A1电子UV干燥机();
        A1全精密滚涂机 butu = new A1全精密滚涂机();
        A0流平机 liuping = new A0流平机();
        A0智能除尘机 clean = new A0智能除尘机();
        A0参数设置 ParaSet = new A0参数设置();
        A0数据库操作 Databases = new A0数据库操作();
        A0日式淋幕机 linmu = new A0日式淋幕机();
        A0毛刷机 brush = new A0毛刷机();
        A0砂光机 shaguang = new A0砂光机();
        //A0龙门上下料 load = new A0龙门上下料();
        /// <summary>
        /// 主界面主要设备信息的Label显示
        /// </summary>
        public Dictionary<Device, Control> DisplayLabels { get; set; } = new Dictionary<Device, Control>();


        public List<Wheel> AllButuWheels = new List<Wheel>();  //所有butu轮
        public A0开机画面(frmLogin frm1ogin)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            login = frm1ogin;
            //实例化串口数据接收
            myComPort.DataReceived += ReceiveData;

            this.Shown += A0开机画面_Shown1;

            FormClosed += A0开机画面_FormClosed1;
        }
        /// <summary>
        /// 程序关闭时先遍历设备列表，对所有设备的通讯连接进行释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A0开机画面_FormClosed1(object sender, FormClosedEventArgs e)
        {
            //遍历设备，判断队列里面设备资源释放情况
            foreach (var item in PublicValue.devices)
            {
                item.Dispose();
            }
            PublicValue.BaseProtocol?.Dispose();
        }
        /// <summary>
        /// 加载窗体时执行的动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A开机画面_Load(object sender, EventArgs e)
        {
            //加载时用户信息显示区域变浅蓝色，Welcome按钮被选中，背景色为海绿色
            labUserMsg.Text = "用户名:" + login.userNameToWelcome + "\n" + "\n" + "部  门:" + login.userDepartmentToWelcome + "";
            chbWelcome.Checked = true;
            chbWelcome.BackColor = Color.MediumSeaGreen;
        }
        //窗体打开完成后，自动进行联机
        public void A0开机画面_Shown(object sender, EventArgs e)
        {
            //启动窗体循环计时器
            Windows_Recyle.Enabled = true;
            //窗体加载完成后先初始化设备
            initDevices();
            //根据登录人信息显示主界面的信息
            loginUser();
        }
        /// <summary>
        /// Shown后启动后台线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A0开机画面_Shown1(object sender, EventArgs e)
        {
            //开始后台刷新线程
            new Thread(BackRefresh).Start();
            //开始主页面的后台刷新线程
            new Thread(Main.MainBackRefresh).Start();
        }
        /// <summary>
        /// 关闭窗体后把IsClosed的标志位设置为true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A0开机画面_FormClosed(object sender, FormClosedEventArgs e)
        {
            //关闭扫码枪串口通讯端口
            Portclosed();
            //窗口关闭的标志位信息
            IsClosed = Main.MainIsClosed = true;


        }

        /// <summary>
        /// 子窗体自动跟随变大小,子窗体的尺寸随着主界面的显示区域进行改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void split_Code_Panel2_SizeChanged(object sender, EventArgs e)
        {
            Main.Size = this.split_Code.Panel2.Size;
            UV_Dry_3.Size = Main.splitMain.Panel1.Size;
            butu.Size = Main.splitMain.Panel1.Size;
            clean.Size = Main.splitMain.Panel1.Size;
            liuping.Size = Main.splitMain.Panel1.Size;
            ParaSet.Size = this.split_Code.Panel2.Size;
            Databases.Size = this.split_Code.Panel2.Size;
        }
        /// <summary>
        /// 物料编号输入完成后自动保存物料编码到本地文件ini
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Prt_NO_Leave_1(object sender, EventArgs e)
        {
            //调用产品编号显示方法
            productNO_ok();
        }
        /// <summary>
        /// 把物料编码和配方编号存储在本地ini文件中
        /// </summary>
        private void productNO_ok()
        {
            Int32[] value = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };
            string[] way = new string[] { @"\Default-product1.ini" , @"\Default-product2.ini" , @"\Default-product3.ini", @"\Default-product4.ini", @"\Default-product5.ini", @"\Default-product6.ini",
                                             @"\Default-product7.ini" , @"\Default-product8.ini" , @"\Default-product9.ini" , @"\Default-product10.ini",
                @"\Default-product11.ini" , @"\Default-product12.ini" , @"\Default-product13.ini", @"\Default-product14.ini", @"\Default-product15.ini", @"\Default-product16.ini",
                                             @"\Default-product17.ini" , @"\Default-product18.ini" , @"\Default-product19.ini" , @"\Default-product20.ini" };

            for (int i = 0; i < value.Length; i++)
            {
                //把中间变量的内容存储在指定的位置
                if (Convert.ToUInt32(txbRecipeNO.Text) == value[i])
                {
                    System.IO.File.WriteAllText(Application.StartupPath + way[i], txb_Prt_NO.Text);
                }
            }
        }
        /// <summary>
        /// 从本地ini文件读取物料编码和配方编号
        /// </summary>
        /// 
        public string product_name;
        private void RecipeNO_Input()
        {
            Int32[] value = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };
            string[] way = new string[] { @"\Default-product1.ini" , @"\Default-product2.ini" , @"\Default-product3.ini", @"\Default-product4.ini", @"\Default-product5.ini", @"\Default-product6.ini",
                                             @"\Default-product7.ini" , @"\Default-product8.ini" , @"\Default-product9.ini" , @"\Default-product10.ini",
                @"\Default-product11.ini" , @"\Default-product12.ini" , @"\Default-product13.ini", @"\Default-product14.ini", @"\Default-product15.ini", @"\Default-product16.ini",
                                             @"\Default-product17.ini" , @"\Default-product18.ini" , @"\Default-product19.ini" , @"\Default-product20.ini" };
            //如果输入为空时自动返回之前的值
            if (txbRecipeNO.Text.Trim() == "")
            {
                //MessageBox.Show("输入无效，配方区间在1-20之间，请输入适当的配方编号");
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    //把中间转存的Default - code.ini内容路径找到然后读取出内容存储在txb_tiaoma.Text中
                    if (Convert.ToUInt32(txbRecipeNO.Text) == value[i])
                    {
                        string thispath = Application.StartupPath + way[i];                 //定义变量thisPath，获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称+路径
                        if (!System.IO.File.Exists(thispath)) return;                                       //确定指定的文件是否存在（文件的路径）；如果不存在则执行return
                        try
                        {
                            txb_Prt_NO.Text = System.IO.File.ReadAllText(thispath);
                            //打开一个文本文件，读取文件的所有行，然后关闭该文件
                            //product_name = System.IO.File.ReadAllText(thispath);
                        }
                        catch { }
                    }
                }
            }
        }
        /// <summary>
        /// 当输入光标放入输入框的时候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_Recipe_NO_MouseClick(object sender, MouseEventArgs e)
        {
            txb_Prt_NO.SelectAll();
        }
        //初始化设备，把配置文件读回并按照*和@进行分割
        string localReadBackMachines;
        string typeName = null;
        //增加的设备通讯地址（总控的DB块编号）
        string IpAddress = null;
        //设备编号
        int index = 0;
        //设备的主类型例如（UV干燥机、涂布机、除尘机、砂光机、，）
        int Machine_type = 0;
        //设备的子类型例如（单灯、双灯、三灯、四灯等）
        int childType = 0;

        int localX = 0;
        int localY = 0;
        int localX2 = 0;
        int localX3 = 0;
        int localXX = 0;
        int localYY = 0;
        int localXX2 = 0;
        int localXX3 = 0;
        public void initDevices()
        {
            index = 0;
            localX = 0;
            localY = 0;
            localX2 = 0;
            localX3 = 0;
            localXX = 0;
            localYY = 0;
            localXX2 = 0;
            localXX3 = 0;
            Main.splitMain.Panel2.Controls.Clear();
            //加载文件，获取已添加设备信息
            string thisPath = Application.StartupPath + @"\Devices.ini";    //定义变量thisPath，获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称+路径
            if (!System.IO.File.Exists(thisPath)) return;                   //确定指定的文件是否存在（文件的路径）；如果不存在则执行return
            try
            {
                //打开一个文本文件，读取文件的所有行，然后关闭该文件
                localReadBackMachines = System.IO.File.ReadAllText(thisPath);
                //按照*把字符串分割成数组保存在machines的String数组内
                String[] machines = localReadBackMachines.Split('*');
                //先清除PublicValue里面的所有设备
                PublicValue.devices.Clear();
                //单独增加总控plc到设备的列表内部
                PublicValue.BaseProtocol = new SCADA.Drive.Siemens.S7Comm.S7_1200(new TcpComm("192.168.0.99", 102), 1);
                PublicValue.BaseProtocol.BeginListen($"DB99.DBW0~476", 500);
                PublicValue.BaseProtocol.ConnectStateChanged += BaseProtocol_ConnectStateChanged;
             

                //循环查找字符串内部的数组
                for (int i = 0; i < machines.Length; i++)
                {
                    //把提取出来的数组定义成String格式存储
                    string machine = machines[i];
                    //把第一次提取出来的字符串按照@号进行分割成数组arr
                    string[] arr = machine.Split('@');
                    if (arr.Length > 1)
                    {
                        //把提取出来的数组转换成String格式
                        //设备类型名字
                        typeName = arr[0];
                        //增加的设备通讯地址（总控的DB块编号）
                        IpAddress = arr[1];
                        //设备的主类型例如（UV干燥机）
                        Machine_type = int.Parse(arr[2]);
                        //设备的子类型例如（单灯、双灯、三灯、四灯等）
                        childType = int.Parse(arr[3]);

                        //实例化设备，创建设备为device     //把设备主类型作为方法的值来进行区分
                        Device device = DeviceFatory.createDevice(Machine_type, IpAddress);
                        //调用方法进行设置设备名字
                        device.setTypeName(typeName);
                        //调用方法进行设置通讯地址
                        device.setAddress(IpAddress);
                        //调用方法进行设置设备主类型
                        device.setType(Machine_type);
                        //调用方法进行设置设备子类型
                        device.setChildType(childType);
                        if (childType == 1)
                        {
                            device.UVLampsCount = 1;
                        }
                        else if (childType == 2)
                        {
                            device.UVLampsCount = 2;
                        }
                        else if (childType == 3)
                        {
                            device.UVLampsCount = 3;
                        }
                        else if (childType == 4)
                        {
                            device.UVLampsCount = 4;
                        }
                        else if (childType == 5)
                        {
                            device.UVLampsCount = 5;
                        }
                        else if (childType == 6)
                        {
                            device.UVLampsCount = 6;
                        }
                        else if (childType == 7)
                        {
                            device.UVLampsCount = 7;
                        }
                        else if (childType == 8)
                        {
                            device.UVLampsCount = 8;
                        }
                        else if (childType == 21)
                        {
                            device.ButuWheelCount = 1;
                            device.ZhengPingWheelCount = 0;
                        }
                        else if (childType == 22)
                        {
                            device.ButuWheelCount = 2;
                            device.ZhengPingWheelCount = 0;
                        }
                        else if (childType == 23)
                        {
                            device.ButuWheelCount = 3;
                            device.ZhengPingWheelCount = 0;
                        }
                        else if (childType == 24)
                        {
                            device.ButuWheelCount = 2;
                            device.ZhengPingWheelCount = 1;
                        }
                        else if (childType == 25)
                        {
                            device.ButuWheelCount = 3;
                            device.ZhengPingWheelCount = 1;
                        }
                        else if (childType == 26)
                        {
                            device.ButuWheelCount = 2;
                            device.ZhengPingWheelCount = 1;
                        }
                        else if (childType == 27)
                        {
                            device.ButuWheelCount = 1;
                            device.ZhengPingWheelCount = 1;
                        }
                        //整线的编号，自动根据设备数量进行自加，在解析Device.ini文件的时候
                        index = index + 1;
                        //调用设备类的设置编号的方法，Device类中的设置编号方法
                        device.setIndex(index);
                        //butto
                        Button_Event(device);
                        //向设备列表内部添加设备
                        PublicValue.devices.Add(device);
                       // int eer =device.ButuWheelCount;

                    }
                }


            }
            catch { }
        }
        /// <summary>
        /// 总控PLC的通讯状态监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseProtocol_ConnectStateChanged(object sender, SCADA.ConnectStateChangedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                if (e.ConnectState == SCADA.Comm.ConnectStates.Connected)
                {
                    lab_Communication.Text = "相机通讯状态: " + "True";
                    lab_Communication.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    lab_Communication.Text = "相机通讯状态: " + "False";
                    lab_Communication.BackColor = Color.Red;
                }
            }));
        }
        /// <summary>
        /// 按钮执行事件，每点击一次就根据设备类型自动添加对应的设备          Main.splitMain.Panel2.Width
        ///（设备类型（设备类型的文本内容）；设备编号（Count计数作为设备编号），设备位置（实际位置是按照totalcount数据来存储的））
        /// </summary>
        /// <param name="device"></param>
        public void Button_Event(Device device)
        {
            string type = device.typeName;
            string address_Machine = device.address;
            int machine_type = device.type;

            ButtonEx toAddButton = new ButtonEx();
            //Label DisplayLabel = new Label();

            // 计算待添加按钮的位置  
            if (localX < (Main.splitMain.Panel2.Width - 100))
            {
                localX = 100 + localX;
                localY = 0;

                //设置按钮出现的位置
                toAddButton.Location = new Point(localX, localY);
            }
            else
            {
                if (localX2 < (Main.splitMain.Panel2.Width - 100))
                {
                    localX2 = 100 + localX2;
                    localY = 80;
                    //设置按钮出现的位置
                    toAddButton.Location = new Point(localX2, localY);
                }
                else
                {
                    localX3 = 100 + localX3;
                    localY = 160;
                    //设置按钮出现的位置
                    toAddButton.Location = new Point(localX3, localY);
                }

            }
            //按钮的尺寸为自动模式
            toAddButton.AutoSize = true;
            //把按钮的文本布局设置在底部居中
            toAddButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //鼠标双击事件
            toAddButton.DoubleClick += new System.EventHandler(this.toAddButton_DoubleClick);
            // 把控件添加到窗口中
            Main.splitMain.Panel2.Controls.Add(toAddButton);


            //设置显示的button编号自加一
            machinenum = machinenum + 1;
            //设置增加的按钮的文本：设备类型+设备编号
            toAddButton.Text = type + machinenum;
            //设置增加的按钮的名字，名字定义为设备类型
            toAddButton.Name = Convert.ToString(machine_type);
            //设置增加的按钮的标签，名字定义为设备的通讯地址
            toAddButton.Tag = device;
            //根据type获取图片路径
            string[] machinenametogetimage = new string[] {
               "单灯UV干燥机", "双灯UV干燥机", "三灯UV干燥机", "四灯UV干燥机", "五灯UV干燥机","六灯UV干燥机", "七灯UV干燥机", "八灯UV干燥机","干燥机预留","干燥机预留",
                "全精密除尘机","抛光除尘机","双面除尘机","除尘机预留","除尘机预留",
                "6M红外流平机","4M红外流平机","喷射式流平机","流平机预留","流平机预留",
                "全精密单滚涂布机","全精密双滚涂布机","全精密三滚涂布机", "补土+单滚涂布机","补土+双滚涂布机","正逆滚涂布机","全精密补土机","涂布机预留2","涂布机预留3",
                "四级淋幕机","淋幕机预留1","淋幕机预留2","淋幕机预留3",
                "单滚毛刷机","双滚毛刷机","毛刷机预留1","毛刷机预留2",
                "龙门上料机","龙门下料机","龙门上下料机预留1","龙门上下料预留2",
                "底漆砂光机","素板砂光机","砂光机预留1","砂光机预留2",
                "输送机" };
            for (int i = 0; i < machinenametogetimage.Length; i++)
            {
                if (type == machinenametogetimage[i])
                {
                    toAddButton.Image = imageList2.Images[i];
                    //设置显示的button的背景图片的尺寸，设置尺寸为比button长宽各小20
                    toAddButton.Image = new Bitmap(toAddButton.Image, toAddButton.Width - 20, toAddButton.Height - 20);
                    toAddButton.Font = new Font(toAddButton.Font.FontFamily, 5, toAddButton.Font.Style);
                }
            }
            //增加label监控个台机的参数
            //设备内部的轮子数量和UV灯的数量只要有一个不为0
            if (device.ButuWheelCount > 0 || device.ZhengPingWheelCount > 0 || device.UVLampsCount > 0)
            {
                Control DisplayLabel = null;
                if (device.ButuWheelCount > 0 || device.ZhengPingWheelCount > 0 || device.UVLampsCount > 0)
                {
                    var flowPanel = new FlowLayoutPanel() { FlowDirection = FlowDirection.TopDown };

                    flowPanel.Controls.Add(new Label() { Text = device.typeName + device.index });
                    for (int i = 0; i < device.ButuWheelCount; i++)
                    {
                        device.ButuWheel[i].Number = AllButuWheels.Count + 1;
                        AllButuWheels.Add(device.ButuWheel[i]);
                        flowPanel.Controls.Add(new UctWheelInfo(device.ButuWheel[i]) { });
                    }
                    for (int i = 0; i < device.ZhengPingWheelCount; i++)
                    {
                        flowPanel.Controls.Add(new UctWheelInfo(device.ZhengPingWheel[i]));
                    }
                    for (int i = 0; i < device.UVLampsCount; i++)
                    {
                        flowPanel.Controls.Add(new UctLampsInfo(device.UVLamps[i]));
                    }
                    DisplayLabel = flowPanel;
                }
                else
                {
                    DisplayLabel = new Label();
                    DisplayLabels.Add(device, DisplayLabel);
                }


                Main.splitContainer2.Panel1.Controls.Add(DisplayLabel);
                DisplayLabel.BackColor = Color.LightGray;
                DisplayLabel.Width = 120;
                DisplayLabel.Height = Main.splitContainer2.Panel1.Height;
                DisplayLabel.AutoSize = false;
                //DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                //设置增加的按钮的文本：设备类型+设备编号
                //DisplayLabel.Text = type + machinenum;
                DisplayLabel.Name = type;
                DisplayLabel.TabIndex = machinenum;
                DisplayLabel.Tag = IpAddress;
                //计算待添加按钮的位置
                if (localXX < (Main.splitContainer2.Panel1.Width - 130))
                {
                    localXX = 130 + localXX;
                    localYY = 10;
                    //设置按钮出现的位置
                    DisplayLabel.Location = new Point(localXX, localYY);
                }
                else
                {
                    if (localXX2 < (Main.splitContainer2.Panel1.Width - 130))
                    {
                        localXX2 = 130 + localXX2;
                        localYY = 250;
                        //设置按钮出现的位置
                        DisplayLabel.Location = new Point(localXX2, localYY);
                    }
                    else
                    {
                        localXX3 = 130 + localXX3;
                        localYY = 250;
                        //设置按钮出现的位置
                        DisplayLabel.Location = new Point(localXX3, localYY);
                    }
                }
            }
        }
        //处理图片点击（双击）事件，点击对应的图片进入对应的参数设置界面
        //定义变量==按钮的文本名称
        public string button_text = null;
        //定义变量==设备名称
        public string machinename = null;
        //定义变量==设备编号
        public int machinenum = 0;
        //定义变量==设备地址
        public string machineaddress = null;
        //定义变量==设备类型
        public int machinetype = 0;
        /// <summary>
        /// 双击设备图片按钮进入操作界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toAddButton_DoubleClick(object sender, System.EventArgs e)
        {
            index = 0;
            Button currentButton = (Button)sender;
            //定义button的标签变量作为地址
            String textString = Convert.ToString(currentButton.Tag);
            Object tag = currentButton.Tag;
            //machinenum = machinenum + 1;
            //把tag赋值给Device设备
            Device device = (Device)tag;
            if (tag != null && tag is Device)
            {
                //设备名称是设备类型名字
                machinename = device.typeName;
                //设备编号==设备的index
                machinenum = device.index;
                //设备地址==设备的address
                machineaddress = device.address;
                //设备类型==设备的大类型（子类型）
                machinetype = device.childType;
                //按钮的文本名称（设备名字+编号）
                button_text = machinename + machinenum;
            }
            //判定点击的按钮Text文本内容进入对应的干燥机界面
            if (button_text == "单灯UV干燥机" + machinenum || button_text == "双灯UV干燥机" + machinenum || button_text == "三灯UV干燥机" + machinenum
                || button_text == "四灯UV干燥机" + machinenum || button_text == "五灯UV干燥机" + machinenum || button_text == "六灯UV干燥机" + machinenum
                || button_text == "七灯UV干燥机" + machinenum || button_text == "八灯UV干燥机" + machinenum)
            {
                if (login.userDepartmentToWelcome != "生产部")
                {
                    DryDevice dry = (DryDevice)device;
                    Main.splitMain.Panel1.Controls.Clear();
                    UV_Dry_3.setDevice(device);
                    Main.splitMain.Panel1.Controls.Add(UV_Dry_3);
                    UV_Dry_3.Parent = Main.splitMain.Panel1;
                    //UV_Dry_3.txb_Recipe_NO.Text = txbRecipeNO.Text;

                    clean.Windows_Recyle.Enabled = false;
                    //IsClosed = true;

                    //进入时调用一次配方刷新
                    UV_Dry_3.refreshPeifang();
                    showLog("进入" + button_text + "操作页面");

                    UV_Dry_3.Windows_Recyle.Enabled = true;
                    butu.Windows_Recyle.Enabled = false;
                    shaguang.Windows_Recyle.Enabled = false;
                }
            }
            //判定点击的按钮Text文本内容进入对应的涂布机界面
            if (button_text == "全精密单滚涂布机" + machinenum || button_text == "全精密双滚涂布机" + machinenum || button_text == "全精密三滚涂布机" + machinenum
                || button_text == "补土+单滚涂布机" + machinenum || button_text == "补土+双滚涂布机" + machinenum || button_text == "正逆滚涂布机" + machinenum
                || button_text == "全精密补土机" + machinenum)
            {
                if (login.userDepartmentToWelcome != "生产部")
                {
                    butuDevice butudevice = (butuDevice)device;
                    Main.splitMain.Panel1.Controls.Clear();
                    butu.setDevice(device);
                    Main.splitMain.Panel1.Controls.Add(butu);
                    butu.Parent = Main.splitMain.Panel1;
                    //butu.txbRecipeNO.Text = txb_Recipe_NO.Text;
                    //进入时调用一次配方刷新
                    butu.refreshPeifang();
                    butu.Windows_Recyle.Enabled = true;
                    shaguang.Windows_Recyle.Enabled = false;
                    UV_Dry_3.Windows_Recyle.Enabled = false;

                    clean.Windows_Recyle.Enabled = false;

                    showLog("进入" + button_text + "操作页面");
                }
            }
            //判定点击的按钮Text文本内容进入对应的除尘机界面
            if (button_text == "全精密除尘机" + machinenum || button_text == "抛光除尘机" + machinenum)
            {
                if (login.userDepartmentToWelcome != "生产部")
                {
                    CleanDevice cleandevice = (CleanDevice)device;
                    Main.splitMain.Panel1.Controls.Clear();
                    clean.setDevice(device);
                    Main.splitMain.Panel1.Controls.Add(clean);
                    clean.Parent = Main.splitMain.Panel1;
                    //clean.txb_Recipe_NO.Text = txbRecipeNO.Text;
                    //进入时调用一次配方刷新
                    clean.refreshPeifang();
                    showLog("进入" + button_text + "操作页面");
                    clean.Windows_Recyle.Enabled = true;
                    butu.Windows_Recyle.Enabled = false;
                    shaguang.Windows_Recyle.Enabled = false;
                    UV_Dry_3.Windows_Recyle.Enabled = false;
                }
            }
            //判定点击的按钮Text文本内容进入对应的流平机界面
            //","","","全精密砂光机
            if (button_text == "6M红外流平机" + machinenum || button_text == "4M红外流平机" + machinenum || button_text == "喷射式流平机" + machinenum)
            {
                if (login.userDepartmentToWelcome != "生产部")
                {
                    liupingDevice liupingdevice = (liupingDevice)device;
                    Main.splitMain.Panel1.Controls.Clear();
                    liuping.setDevice(device);
                    Main.splitMain.Panel1.Controls.Add(liuping);
                    liuping.Parent = Main.splitMain.Panel1;
                    //进入时调用一次配方刷新
                    liuping.refreshPeifang();
                    showLog("进入" + button_text + "操作页面");

                    liuping.Windows_Recyle.Enabled = true;
                }
            }
            //判定点击的按钮Text文本内容进入对应的淋幕机界面
            if (button_text == "四级淋幕机" + machinenum)
            {
                if (login.userDepartmentToWelcome != "生产部")
                {
                    LinmuDevice linmudevice = (LinmuDevice)device;
                    Main.splitMain.Panel1.Controls.Clear();
                    linmu.setDevice(device);
                    Main.splitMain.Panel1.Controls.Add(linmu);
                    linmu.Parent = Main.splitMain.Panel1;
                    //进入时调用一次配方刷新
                    linmu.refreshPeifang();

                    showLog("进入" + button_text + "操作页面");

                    linmu.Windows_Recyle.Enabled = true;
                }
            }
            //判定点击的按钮Text文本内容进入对应的毛刷机界面
            if (button_text == "双滚毛刷机" + machinenum || button_text == "单滚毛刷机" + machinenum)
            {
                if (login.userDepartmentToWelcome != "生产部")
                {
                    BrushDevice brushdevice = (BrushDevice)device;
                    Main.splitMain.Panel1.Controls.Clear();
                    brush.setDevice(device);
                    Main.splitMain.Panel1.Controls.Add(brush);
                    brush.Parent = Main.splitMain.Panel1;
                    //进入时调用一次配方刷新
                    brush.refreshPeifang();
                    showLog("进入" + button_text + "操作页面");

                    brush.Windows_Recyle.Enabled = true;
                }
            }
            //判定点击的按钮Text文本内容进入对应的砂光机界面
            if (button_text == "底漆砂光机" + machinenum || button_text == "上浮式砂光机" + machinenum)
            {
                if (login.userDepartmentToWelcome != "生产部")
                {
                    //ShaDevice shadevice = (ShaDevice)device;
                    //Main.splitMain.Panel1.Controls.Clear();
                    //shaguang.setDevice(device);
                    //Main.splitMain.Panel1.Controls.Add(shaguang);
                    //shaguang.Parent = Main.splitMain.Panel1;
                    //Main.Windows_Recyle.Enabled = false;
                    ////进入时调用一次配方刷新
                    //shaguang.refreshPeifang();
                    //showLog("     进入" + button_text + "操作页面");
                    //IsClosed = true;
                    //if (lab_Communication.Enabled == true)
                    //{
                    //    UV_Dry_3.Windows_Recyle.Enabled = false ;
                    //    butu.Windows_Recyle.Enabled = false;
                    //    shaguang.Windows_Recyle.Enabled = true;
                    //}
                }
            }
        }
        /// <summary>
        /// 首先创建ButtonEx继承Button，重载Click事件：用于button的双击事件
        /// </summary>
        public class ButtonEx : Button
        {
            public new event EventHandler DoubleClick;
            DateTime clickTime;
            bool isClicked = false;
            protected override void OnClick(EventArgs e)
            {
                base.OnClick(e);
                if (isClicked)
                {
                    TimeSpan span = DateTime.Now - clickTime;
                    if (span.Milliseconds < SystemInformation.DoubleClickTime)
                    {
                        DoubleClick(this, e);
                        isClicked = false;
                    }
                    else
                    {
                        isClicked = true;
                        clickTime = DateTime.Now;
                    }
                }
                else
                {
                    isClicked = true;
                    clickTime = DateTime.Now;
                }
            }
        }
        /// <summary>
        /// 配方读取按钮（通过总控plc进行读取，因为单机的地址不一样，还要做区分，因此还从主plc读取和写入）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Recipe_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            switch (button.Name)
            {
                case "btn_Recipe_Read":
                    var rsno1 = PublicValue.BaseProtocol.WriteReg("DB99.DBB0", 32);
                    if (rsno1 == true)
                    {
                        btn_Recipe_Read.BackColor = Color.MediumSeaGreen;
                        btn_Recipe_Read.Focus();
                        //总控配方读取，当read按钮获取到焦点的时候执行
                        Btn_Recipe_Read_GotFocus();
                        //把本地保存的颜色配置显示出来
                        ColorChooseDisplay();
                        showLog("总控配方读取操作执行成功");
                    }
                    else
                    {
                        showLog("总控配方读取操作执行失败");
                        MessageBox.Show("总控配方读取操作执行失败");
                    }
                    break;
                case "btn_Recipe_OK":
                    var rsno2 = PublicValue.BaseProtocol.WriteReg("DB99.DBB0", 64);
                    if (rsno2 == true)
                    {
                        btn_Recipe_OK.BackColor = Color.MediumSeaGreen;
                        showLog("总控配方确认操作执行成功");
                    }
                    else
                    {
                        showLog("总控配方读取操作执行失败");
                        MessageBox.Show("总控配方读取操作执行失败");
                    }
                    break;
            }
            TimerCloseRead.Enabled = true;
        }
        /// <summary>
        /// 把本地保存的颜色配置显示出来
        /// </summary>
        public void ColorChooseDisplay()
        {
            //int productNo = 2;
            var selectIndex = QwUI.XmlUserConfig.GetUserCfg($"Recipe_{txbRecipeNO.Value}", Main.cmbColorChoose.SelectedIndex);
            Main.cmbColorChoose.Text = Main.cmbColorChoose.Items[selectIndex].ToString();
            //for (int i = 0; i < 16; i++)
            //{
            //    Console.WriteLine($"{i}:{1 << i}");
            //}
        }
        /// <summary>
        /// 总控配方读取按钮获取焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Recipe_Read_GotFocus()
        {
            var rsno1 = PublicValue.BaseProtocol.WriteReg("DB99.DBW2", Convert.ToInt16(txbRecipeNO.Text.ToString()));
            if (rsno1 == true)
            {
                showLog("配方编号" + txbRecipeNO.Text + "操作执行成功");
            }
            else
            {
                showLog("配方编号" + txbRecipeNO.Text + "操作执行失败");
                MessageBox.Show("配方编号" + txbRecipeNO.Text + "操作执行失败");
            }
            //把保存在本地的文件读回到物料编码输入框
            RecipeNO_Input();
        }
        /// <summary>
        /// 配方读取和配方确认按钮延时1S从1→0；绿色→红色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCloseRead_Tick(object sender, EventArgs e)
        {
            //配方读取
            btn_Recipe_Read.BackColor = Color.DodgerBlue;
            btn_Recipe_OK.BackColor = Color.DodgerBlue;
            TimerCloseRead.Enabled = false;
        }
        /// <summary>
        /// 当窗体尺寸发生变化时改变指示灯的位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A0开机画面_SizeChanged(object sender, EventArgs e)
        {
            splitContainer4.SplitterDistance = 900;
            splitContainer5.SplitterDistance = 300;
            //系统菜单button
            btnShown.Font = new Font("楷体_GB2312", 10);
        }
        /// <summary>
        /// 首页日期自动刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Windows_Recyle_Tick(object sender, EventArgs e)
        {
            //首页计时器刷新显示
            labTimer.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// 日志输出
        /// </summary>
        /// <param name="newLog"></param>
        public void showLog(string newLog)
        {
            DateTime datetime = DateTime.Now;
            logs = logs + newLog + "\n";
            LbMsg.Items.Insert(0, DateTime.Now + newLog);
            //定义字符串变量value，赋值为listbox的插入内容
            string value = "( null,'" + datetime + "','" + Convert.ToString(login.userNameToWelcome) + "','" + Convert.ToString(login.userDepartmentToWelcome) + "','" + Convert.ToString(newLog) + "')"; ;
            Databases.InsertDataToMysqlOperation("purete", "OperationTable", value);
            //Env.DB.
            //Env.DB.ExecuteNonQuery(null, "");
            //for (int i = 0; i < 10; i++)
            //{
            //    Env.DB.operationtable.Insert(
            //    new QwUI.Data.DIL.UpdateItem(T_Col_Name.operationtable.id, null),
            //    new QwUI.Data.DIL.UpdateItem(T_Col_Name.operationtable.Dates, DateTime.Now),
            //    new QwUI.Data.DIL.UpdateItem(T_Col_Name.operationtable.Name, login.userNameToWelcome),
            //    new QwUI.Data.DIL.UpdateItem(T_Col_Name.operationtable.Department, login.userDepartmentToWelcome),
            //    new QwUI.Data.DIL.UpdateItem(T_Col_Name.operationtable.Logs, newLog));
            //}

        }
        #region
        /////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 设置端口为com5，波特率为9600，奇偶校验，无
        /// </summary>
        public SerialPort myComPort = new SerialPort("COM5", 9600, Parity.None);
        /// <summary>
        /// 数据接收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            txb_tiaoma.Clear();
            txb_tiaoma.SelectAll();
            int n = myComPort.BytesToRead;
            byte[] buf = new byte[n];
            myComPort.Read(buf, 0, n);
            lab_Code.Invoke
                (
                new EventHandler(
                    delegate
                    {
                        //把获取到的字符串转换成ASCII码存储在label内部
                        lab_Code.Text = Encoding.ASCII.GetString(buf);
                        product_name=Encoding.ASCII.GetString(buf);
                        //条码分割处理
                        tiaomachuli();
                    }
                    )
                );
        }
        //当label里面的字符串发生变化时
        private void lab_Code_TextChanged(object sender, EventArgs e)
        {

        }
        //打开通讯，com5端口
        public void PortOpen()
        {
            //点击通讯窗口的时候打开串口
            if (myComPort.IsOpen)
            {
                showLog("扫码枪端口已经打开（COM5）");
                MessageBox.Show("扫码枪端口已经打开 （COM5）!");
            }
            else
            {
                showLog("请检查扫码枪是否连接");
                MessageBox.Show("请检查扫码枪是否连接");
                myComPort.Open();
            }
        }
        //关闭通讯，com5端口
        public void Portclosed()
        {
            if (myComPort.IsOpen)
            {
                showLog("扫码枪端口关闭");
                myComPort.Close();
            }
        }

        /// <summary>
        /// 对扫描到的条码进行分割处理
        /// </summary>
        private void tiaomachuli()
        {
            string tiaoma = lab_Code.Text;


            if (lab_Code.Text.Length >= 8)
            {
                if (tiaoma == "*SUN001*\r\n")
                    txbRecipeNO.Text = "1";
                if (tiaoma == "*SUN002*\r\n")
                    txbRecipeNO.Text = "2";
                if (tiaoma == "*SUN003*\r\n")
                    txbRecipeNO.Text = "3";
                if (tiaoma == "*SUN004*\r\n")
                    txbRecipeNO.Text = "4";
                if (tiaoma == "*SUN005*\r\n")
                    txbRecipeNO.Text = "5";
                if (tiaoma == "*SUN006*\r\n")
                    txbRecipeNO.Text = "6";
                if (tiaoma == "*SUN007*\r\n")
                    txbRecipeNO.Text = "7";
                if (tiaoma == "*SUN008*\r\n")
                    txbRecipeNO.Text = "8";
                if (tiaoma == "*SUN009*\r\n")
                    txbRecipeNO.Text = "9";
                if (tiaoma == "*SUN010*\r\n")
                    txbRecipeNO.Text = "10";

                Btn_Recipe_Read_GotFocus();
                ColorChooseDisplay();
            }
            else
            {
                MessageBox.Show("扫码操作失败！");
            }
            timer_Read.Enabled = true;            //延时触发扫码内容传递给PLC
        }
        //扫码完成后延时1S把长宽高数据传送到PLC内部进行处理
        private void timer_Read_Tick(object sender, EventArgs e)
        {
            ////把中间变量的内容存储在
            //System.IO.File.WriteAllText(Application.StartupPath + @"\Default - code.ini", txb_tiaoma.Text);
            var rsno1 = PublicValue.BaseProtocol.WriteReg("DB99.DBB0", 32);
            if (rsno1 == true)
            {
                //btn_Recipe_Read.BackColor = Color.MediumSeaGreen;
                btn_Recipe_Read.Focus();
                //总控配方读取，当read按钮获取到焦点的时候执行
                Btn_Recipe_Read_GotFocus();
                showLog("总控配方读取操作执行成功");
            }
            else
            {
                showLog("总控配方读取操作执行失败");
                MessageBox.Show("总控配方读取操作执行失败");
            }
            timer_Read.Enabled = false;
            timer_Makesure.Enabled = true;

        }
        /// <summary>
        /// 扫码后延时执行刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Makesure_Tick(object sender, EventArgs e)
        {
            var rsno2 = PublicValue.BaseProtocol.WriteReg("DB99.DBB0", 64);
            if (rsno2 == true)
            {
                //btn_Recipe_OK.BackColor = Color.MediumSeaGreen;
                showLog("总控配方确认操作执行成功");
            }
            else
            {
                showLog("总控配方读取操作执行失败");
                MessageBox.Show("总控配方读取操作执行失败");
            }
            timer_Makesure.Enabled = false;
        }
        #endregion
        /// <summary>
        /// 定义按钮状态变量，折叠菜单的按钮折叠功能
        /// </summary>
        private bool m_btnState = true;
        /// <summary>
        /// 根据按钮状态的值进行对Panel的折叠和隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShown_Click(object sender, EventArgs e)
        {
            //按下状态标识
            if (m_btnState)
            {
                this.btnShown.FlatStyle = FlatStyle.Popup;
                m_btnState = false;
            }
            else
            {
                this.btnShown.FlatStyle = FlatStyle.System;
                m_btnState = true;
            }
            if (splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
            }
        }
        /// <summary>
        /// 根据登录人员的部门信息显示不同的界面
        /// </summary>
        private void loginUser()
        {
            switch (login.userDepartmentToWelcome)
            {
                case "生产部":
                    chbWelcome.Visible = true;
                    chbMain.Visible = true;
                    chbLayout.Visible = false;
                    chbDatabase.Visible = false;
                    chbParameters.Visible = false;
                    chbQuitSystem.Visible = true;
                    Main.txbProtectTime.Visible = false;
                    Main.labProtectTime.Visible = false;
                    Main.txbSpeedWrite.Visible = false;
                    Main.lblSpeedInput.Visible = false;
                    txb_Prt_NO.ReadOnly = true;
                    break;
                case "技术部":
                    chbWelcome.Visible = true;
                    chbMain.Visible = true;
                    chbLayout.Visible = true;
                    chbDatabase.Visible = true;
                    chbParameters.Visible = false;
                    chbQuitSystem.Visible = true;
                    Main.txbProtectTime.Visible = true;
                    Main.labProtectTime.Visible = true;
                    Main.txbSpeedWrite.Visible = false;
                    Main.lblSpeedInput.Visible = false;
                    txb_Prt_NO.ReadOnly = false;
                    break;
                case "工程部":
                    chbWelcome.Visible = true;
                    chbMain.Visible = true;
                    chbLayout.Visible = true;
                    chbDatabase.Visible = true;
                    chbParameters.Visible = false;
                    chbQuitSystem.Visible = true;
                    Main.txbProtectTime.Visible = true;
                    Main.labProtectTime.Visible = true;
                    Main.txbSpeedWrite.Visible = false;
                    Main.lblSpeedInput.Visible = false;
                    txb_Prt_NO.ReadOnly = false;
                    break;
                case "管理员":
                    chbWelcome.Visible = true;
                    chbMain.Visible = true;
                    chbLayout.Visible = true;
                    chbDatabase.Visible = true;
                    chbParameters.Visible = true;
                    chbQuitSystem.Visible = true;
                    Main.txbProtectTime.Visible = true;
                    Main.labProtectTime.Visible = true;
                    Main.txbSpeedWrite.Visible = true;
                    Main.lblSpeedInput.Visible = true;
                    txb_Prt_NO.ReadOnly = false;
                    break;
            }
        }
        /// <summary>
        /// 开机画面的几个主键的动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClick(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkboxName = (System.Windows.Forms.CheckBox)sender;

            switch (checkboxName.Name)
            {
                case "chbWelcome":
                    split_Code.Panel2.Controls.Clear();
                    showLog("进入开机操作页面");

                    chbWelcome.BackColor = Color.MediumSeaGreen;
                    chbMain.BackColor = Color.DodgerBlue;
                    chbDatabase.BackColor = Color.DodgerBlue;
                    chbLayout.BackColor = Color.DodgerBlue;
                    chbParameters.BackColor = Color.DodgerBlue;
                    chbQuitSystem.BackColor = Color.DodgerBlue;
                    labScreening.Text = "Welcome";

                    butu.Windows_Recyle.Enabled = false;
                    UV_Dry_3.Windows_Recyle.Enabled = false;
                    break;
                case "chbMain":
                    index = 0;
                    //清除开机界面区域的所有控件
                    split_Code.Panel2.Controls.Clear();
                    //清除主界面的panel1的所有控件
                    Main.splitMain.Panel1.Controls.Clear();

                    //当前界面为父窗体
                    Main.parentForm = this;
                    IsClosed = false;
                    Main.Parent = split_Code.Panel2;
                    split_Code.Panel2.Controls.Add(Main);
                    Main.splitMain.Panel1.Controls.Add(Main.splitContainer1);
                    Main.splitContainer1.Panel1.Controls.Add(Main.gxbControl);

                    //显示颜色
                    ColorChooseDisplay();
                    showLog("进入主页面操作页面");

                    //读回扫码枪开关状态
                    ParameterInit();

                    chbWelcome.BackColor = Color.DodgerBlue;
                    chbMain.BackColor = Color.MediumSeaGreen;
                    chbDatabase.BackColor = Color.DodgerBlue;
                    chbLayout.BackColor = Color.DodgerBlue;
                    chbParameters.BackColor = Color.DodgerBlue;
                    chbQuitSystem.BackColor = Color.DodgerBlue;

                    butu.Windows_Recyle.Enabled = false;
                    UV_Dry_3.Windows_Recyle.Enabled = false;

                    labScreening.Text = "主页面";

                    break;
                case "chbDatabase":
                    split_Code.Panel2.Controls.Clear();
                    if (Databases == null || Databases.IsDisposed)
                    {
                        Databases = new A0数据库操作();
                    }
                    //当前界面为父窗体
                    Databases.parentForm = this;

                    Databases.Parent = split_Code.Panel2;
                    split_Code.Panel2.Controls.Add(Databases);
                    showLog("进入数据库操作页面");

                    chbWelcome.BackColor = Color.DodgerBlue;
                    chbMain.BackColor = Color.DodgerBlue;
                    chbDatabase.BackColor = Color.MediumSeaGreen;
                    chbLayout.BackColor = Color.DodgerBlue;
                    chbParameters.BackColor = Color.DodgerBlue;
                    chbQuitSystem.BackColor = Color.DodgerBlue;
                    labScreening.Text = "数据库操作页面";



                    butu.Windows_Recyle.Enabled = false;
                    UV_Dry_3.Windows_Recyle.Enabled = false;
                    break;
                case "chbLayout":
                    split_Code.Panel2.Controls.Clear();
                    if (ParaSet == null || ParaSet.IsDisposed)
                    {
                        ParaSet = new A0参数设置();
                    }
                    //当前界面为父窗体
                    ParaSet.parentForm = this;

                    ParaSet.Parent = split_Code.Panel2;
                    split_Code.Panel2.Controls.Add(ParaSet);
                    showLog("进入整线布局配置操作页面");

                    chbWelcome.BackColor = Color.DodgerBlue;
                    chbMain.BackColor = Color.DodgerBlue;
                    chbDatabase.BackColor = Color.DodgerBlue;
                    chbLayout.BackColor = Color.MediumSeaGreen;
                    chbParameters.BackColor = Color.DodgerBlue;
                    chbQuitSystem.BackColor = Color.DodgerBlue;
                    labScreening.Text = "设备布局页面";



                    butu.Windows_Recyle.Enabled = false;
                    UV_Dry_3.Windows_Recyle.Enabled = false;
                    break;
                case "chbParameters":
                    chbWelcome.BackColor = Color.DodgerBlue;
                    chbMain.BackColor = Color.DodgerBlue;
                    chbDatabase.BackColor = Color.DodgerBlue;
                    chbLayout.BackColor = Color.DodgerBlue;
                    chbParameters.BackColor = Color.MediumSeaGreen;
                    chbQuitSystem.BackColor = Color.DodgerBlue;
                    break;
                case "chbQuitSystem":
                    chbWelcome.BackColor = Color.DodgerBlue;
                    chbMain.BackColor = Color.DodgerBlue;
                    chbDatabase.BackColor = Color.DodgerBlue;
                    chbLayout.BackColor = Color.DodgerBlue;
                    chbParameters.BackColor = Color.DodgerBlue;
                    chbQuitSystem.BackColor = Color.MediumSeaGreen;
                    labScreening.Text = "退出系统";


                    DialogResult result = MessageBox.Show("是否退出系统", "系统信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        //确定按钮的方法
                        Application.Exit();
                    }
                    else
                    { }

                    showLog("退出操作系统");
                    break;
            }
        }
        /// <summary>
        /// 显示条码功能关闭的按钮的状态
        /// </summary>
        public void ParameterInit()
        {
            //扫码功能
            if (PublicValue.BaseProtocol.ListenReg["DB99.DBW412"].Value == 1)
            {
                //如果chbTiaomachoice==true，扫码端口打开
                Main.chbTiaomachoice.Checked = true;
                //打开串口
                PortOpen();
                Main.chbTiaomachoice.Text = "扫码功能启用";
                btn_Recipe_Read.Visible = false;
                btn_Recipe_OK.Visible = false;
                //开机自动打开扫码枪的com5口
                //myComPort.Open();
            }
            else
            {
                Main.chbTiaomachoice.Checked = false;
                btn_Recipe_Read.Visible = true;
                btn_Recipe_OK.Visible = true;
                Main.chbTiaomachoice.Text = "扫码功能停用";
                myComPort.Close();
                //关闭串口
                Portclosed();
            }
            //自动测厚功能
            if (PublicValue.BaseProtocol.ListenReg["DB99.DBW396"].Value == 1)
            {
                Main.chbAutoTestHeight.Checked = true;
                Main.chbAutoTestHeight.Text = "自动测厚启用";
            }
            else
            {
                Main.chbAutoTestHeight.Checked = false;
                Main.chbAutoTestHeight.Text = "自动测厚停用";
                Main.chbCheck.Visible = false;
                Main.txbInputHeight.Visible = false;
            }
            //柔性功能
            if (PublicValue.BaseProtocol.ListenReg["DB99.DBW406"].Value == 1)
            {
                Main.chbAutomation.Checked = false;
                Main.chbAutomation.Text = "柔性功能停用";
            }
            else
            {
                Main.chbAutomation.Checked = true;
                Main.chbAutomation.Text = "柔性功能启用";
            }

            //高度确认情况
            if (PublicValue.BaseProtocol.ListenReg["DB99.DBW410"].Value == 1)
            {
                Main.chbCheck.Checked = true;
                //Main.chbCheck.Text = "输入设定高度";
                if (Main.chbCheck.Checked == true)
                {
                    Main.txbInputHeight.Visible = true;
                }
                else
                {
                    Main.txbInputHeight.Visible = false;
                }
            }
            else
            {
                Main.chbCheck.Checked = false;
                Main.txbInputHeight.Visible = false;
            }

            //测厚高度补偿显示
            if (PublicValue.BaseProtocol.ListenReg["DB99.DBW236"].Value!=null)
            {


                Main.txbHeightValue.Text = (Convert.ToDecimal(BitConverter.ToInt16(BitConverter.GetBytes(PublicValue.BaseProtocol.ListenReg["DB99.DBW236"].Value.Value), 0)) / 100).ToString();
            }
            
            //不启用滚的高度设定显示
            Main.AutoHeightTest.Text = (Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW398"].Value) / 100).ToString();
            //信号延时保护时间显示
            Main.txbProtectTime.Text = (Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW400"].Value) / 1000).ToString();
            //高度设定情况
            Main.txbInputHeight.Text = (Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW404"].Value) / 100).ToString();
            //速度设定情况
            Main.txbSpeedWrite.Text = (Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW408"].Value) / 100).ToString();
        }
        /// <summary>
        /// 主页面后台线程
        /// </summary>
        private void BackRefresh()
        {
            while (!IsClosed)
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                try
                {
                    //刷新按钮的状态，休眠100ms后再休眠3S
                    AreaSum();
                    Thread.Sleep(1000);
                }
                catch (Exception)
                {
                }
                finally
                {
                    //每执行一次休眠10S，把10s分为10次执行，当判断窗体关闭时可以在1S内进行break
                    for (int j = 0; j < 30; j++)
                    {
                        if (IsClosed) break;
                        Thread.Sleep(1 * 100);
                    }
                }
                sw.Stop();
            }
        }
        public decimal DayArea;
        public decimal NightArea;


        /// <summary>
        /// 统计面积方法：
        /// </summary>
        public void AreaSum()
        {

            try
            {
                //统计面积
                var totalArea1 = Env.DB.app_pureteboard.GetGroupValue(DBNames.T_Col_Name.app_pureteboard.Area_Dec, QwUI.Data.DIL.GroupByType.SUM,
                                $"{DBNames.T_Col_Name.app_pureteboard.CreateTime_Dt} between '{DateTime.Now.ToString("yyyy-MM-dd 00:01:00")}' and '{DateTime.Now.ToString("yyyy-MM-dd 17:30:00")}'");
                Console.WriteLine("7:30~17:30 总面积     " + Convert.ToDecimal(totalArea1) / 10000);
                Main.txbAreaDay.Text = Convert.ToString(Convert.ToDecimal(totalArea1) / 10000) + " ㎡";


             DayArea = Convert.ToDecimal(totalArea1) / 10000;

      
                var totalArea2 = Env.DB.app_pureteboard.GetGroupValue(DBNames.T_Col_Name.app_pureteboard.Area_Dec, QwUI.Data.DIL.GroupByType.SUM,
                                $"{DBNames.T_Col_Name.app_pureteboard.CreateTime_Dt} between '{DateTime.Now.ToString("yyyy-MM-dd 17:30:00")}' and '{DateTime.Now.ToString("yyyy-MM-dd 23:59:59")}'");
                //Console.WriteLine("17:30 总面积totalArea     " + Convert.ToDecimal(totalArea2) / 10000);
                Main.txbAreaNight.Text = Convert.ToString(Convert.ToDecimal(totalArea2) / 10000) + " ㎡";
                NightArea = Convert.ToDecimal(totalArea2) / 10000;

                var totalArea3 = Env.DB.app_pureteboard.GetGroupValue(DBNames.T_Col_Name.app_pureteboard.Area_Dec, QwUI.Data.DIL.GroupByType.SUM,
                                $"{DBNames.T_Col_Name.app_pureteboard.CreateTime_Dt} between '{DateTime.Now.ToString("yyyy-MM-01 00:00:00")}' and '{DateTime.Now.ToString("yyyy-MM-31 23:59:59")}'");
                //Console.WriteLine("17:30 总面积totalArea     " + Convert.ToDecimal(totalArea2) / 10000);
                Main.txbAreaMonth.Text = Convert.ToString(Convert.ToDecimal(totalArea3) / 10000) + " ㎡";
            }
            catch (Exception e)
            {
                Console.WriteLine("paochuyichang"+e.Message);
            }
           
            

           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            MySqlConnection con;
            //butuDevice b1 = new butuDevice("192.168.0.1");
          // butuDevice ffr  = (butuDevice)PublicValue.devices[0];
      //    int eer = PublicValue.devices[0].childType;
            //decimal a = Convert.ToDecimal(ffr.ControlZhengpingHeight1);

            try
            {
               decimal Uv2Power = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW422"].Short) / 10;
                decimal Uv2Life1 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW424"].Short) / 1;
                decimal Uv2Life2 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW426"].Short) / 1;
                decimal Uv2Time1 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW428"].Short) / 1;
                decimal Uv2Time2 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW430"].Short) / 1;
                decimal Uv4Power = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW432"].Short) / 10;
                decimal Uv4Life1 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW434"].Short) / 1;
                decimal Uv4Life2 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW436"].Short) / 1;
                decimal Uv4Life3 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW438"].Short) / 1;
                decimal Uv4Life4 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW440"].Short) / 1;
                decimal Uv4Time1 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW442"].Short) / 1;
                decimal Uv4Time2 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW444"].Short) / 1;
                decimal Uv4Time3 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW446"].Short) / 1;
                decimal Uv4Time4 = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW448"].Short) / 1;
                decimal W1_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW450"].Short) / 1;
                decimal W2_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW452"].Short) / 1;
                decimal W3_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW454"].Short) / 1;
                decimal W4_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW456"].Short) / 1;
                decimal W5_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW458"].Short) / 1;
                decimal W6_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW460"].Short) / 1;
                decimal W7_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW462"].Short) / 1;
                decimal W8_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW464"].Short) / 1;
                decimal W9_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW466"].Short) / 1;
                decimal W10_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW468"].Short) / 1;
                decimal W11_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW470"].Short) / 1;
                decimal W12_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW472"].Short) / 1;
                decimal W13_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW474"].Short) / 1;
                decimal W14_time = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW476"].Short) / 1;

                // UV_Dry_3.Monitor_ReadBack();
                string constr = @"Server=192.168.3.31;Database=sunon_data;User Id=workdata;Password=workdata123321;";
                con = new MySql.Data.MySqlClient.MySqlConnection(constr);
                // string par = "xiaoxiao1";
                con.Open();
                string sql = " insert into line_data(day_area, night_area, line_speed, paint_dosage, product_name)values('" + DayArea + "', '" + NightArea + "', '" + Main.LineSpeed + "', '" + Main.PaintDosage + "', '" + product_name + "');"+
                    "insert into machine_uv_data (Uv2Power ,Uv2Life1 ,Uv2Life2,Uv2Time1,Uv2Time2,Uv4Power ,Uv4Life1 ,Uv4Life2,Uv4Life3 ,Uv4Life4,Uv4Time1,Uv4Time2,Uv4Time3,Uv4Time4)values"+
                   " ('" + Uv2Power + "','" + Uv2Life1 + "','" + Uv2Life2 + "','" + Uv2Time1 + "','" + Uv2Time2 + "','" + Uv4Power + "','" + Uv4Life1 + "','" + Uv4Life2 + "','" + Uv4Life3 + "','" + Uv4Life4 + "','" + Uv4Time1 + "','" + Uv4Time2 + "','" + Uv4Time3 + "','" + Uv4Time4 + "'); "+
                   " insert into machine_tubu_data(W1_time, W2_time, W3_time,W4_time, W5_time, W6_time, W7_time, W8_time, W9_time, W10_time,W11_time, W12_time,W13_time, W14_time)values" +
                   " ('" + W1_time + "','" + W2_time + "','" + W3_time + "','" + W4_time + "','" + W5_time + "','" + W6_time + "','" + W7_time + "','" + W8_time + "','" + W9_time + "','" + W10_time + "','" + W11_time + "','" + W12_time + "','" + W13_time + "','" + W14_time + "') " ;


                //string sql = "insert into line_data(day_area, night_area, line_speed, paint_dosage, product_name)values('" + DayArea + "', '" + NightArea + "', '" + Main.LineSpeed + "', '" + Main.PaintDosage + "', '" + product_name + "')  insert into machine_data (Uv2Power ,Uv2Life1 ,Uv2Life2,Uv2Time1,Uv2Time2.Uv4Power ,Uv4Life1 ,Uv4Life2,,Uv4Life3 ,Uv4Life4,Uv4Time1,Uv4Time2,Uv4Time3,Uv4Time4)values('" + Uv2Power + "','" + Uv2Life1 + "','" + Uv2Life2 + "','" + Uv2Time1 + "','" + Uv2Time2 + "','" + Uv4Power + "','" + Uv4Life1 + "','" + Uv4Life2 + "','" + Uv4Life3 + "','" + Uv4Life4 + "','" + Uv4Time1 + "','" + Uv4Time2 + "','" + Uv4Time3 + "','" + Uv4Time4 + "')";
                //   string sql = "insert into line_data (day_area ,night_area ,belt_eff)values('2','3','4')";
                //string sql = "insert into machine (idmachine)values(66.0)";
                //insert into line_data(day_area, night_area, line_speed, paint_dosage, product_name)values('" + DayArea + "', '" + NightArea + "', '" + Main.LineSpeed + "', '" + Main.PaintDosage + "', '" + product_name + "');
                MySqlCommand mycmd1 = new MySqlCommand(sql, con);
                mycmd1.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("连接数据库失败");

               System.Diagnostics.Debug.Print(ex.Message);
            }
        }
    }
}


