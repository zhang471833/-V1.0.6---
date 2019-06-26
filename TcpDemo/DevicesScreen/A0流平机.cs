using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace TcpDemo
{
    public partial class A0流平机 : UserControl
    {
        //定义变量，变量类型为Device
        Device device;
        //定义公共变量，类型为winform窗体，名称：parentForm
        public A0开机画面 parentForm;
        public A0流平机()
        {
            InitializeComponent();
        }
        //窗体load时执行的方法
        private void A0流平机_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            //窗体加载时启动本窗体刷新程序0.5S一次
            Windows_Recyle.Enabled = true;
        }
        //窗体循环执行方法
        private void Window_Recyle_Tick(object sender, EventArgs e)
        {
            //循环显示参数监控
            Monitor_ReadBack();
        }
        //设置当前设备到父类Device内
        public void setDevice(Device device)
        {
            this.device = device;
            //调用初始化界面显示方法,加载设备图片，标签显示等信息
            initView();
        }
        //初始化界面显示的方法，用于加载设备图片，标签显示等信息
        public void initView()
        {
            //定义变量，设备子类型
            int childType = device.childType;
            //定义变量子类型的名字
            String text = "null";
            switch (childType)
            {
                case 16:
                    text = "6M红外流平机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\6米红外流平机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //配方输入框不显示
                    txb_Control_Temp2.Visible = false;
                    chb_Fans2.Visible = false;
                    txb_Control_Temp3.Visible = false;
                    chb_Fans3.Visible = false;
                    //配方区域的标签不显示
                    labelTemp2.Visible = false;
                    labelTemp3.Visible = false;
                    labelFans2.Visible = false;
                    labelFans3.Visible = false;
                    //参数显示区域的标签不显示
                    labelTemp2Monitor.Visible = false;
                    labelTemp3Monitor.Visible = false;
                    //参数显示区域的数据不显示
                    lab_Monitor_Temp2.Visible = false;
                    lab_Monitor_Temp3.Visible = false;
                    lab_Monitor_Temp2_Time.Visible = false;
                    lab_Monitor_Temp3_Time.Visible = false;
                    break;
                case 18:
                    text = "喷射式流平机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\喷射式流平机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //配方输入框不显示
                    txb_Control_Temp2.Visible = true;
                    chb_Fans2.Visible = true;
                    txb_Control_Temp3.Visible = true;
                    chb_Fans3.Visible = true;
                    //配方区域的标签不显示
                    labelTemp2.Visible = true;
                    labelTemp3.Visible = true;
                    labelFans2.Visible = true;
                    labelFans3.Visible = true;
                    //参数显示区域的标签不显示
                    labelTemp2Monitor.Visible = true;
                    labelTemp3Monitor.Visible = true;
                    //参数显示区域的数据不显示
                    lab_Monitor_Temp2.Visible = true;
                    lab_Monitor_Temp3.Visible = true;
                    lab_Monitor_Temp2_Time.Visible = true;
                    lab_Monitor_Temp3_Time.Visible = true;
                    break;
            }
            //把获取到的文本内容赋值给配方区域的GroupBox的名字文本
            gbox_RecipeSetting.Text = text + device.index + " 【" + "配方设置" + "】";
        }
        //循环刷新配方数据
        public void refreshPeifang()
        {
            //实例化流平机设备
            liupingDevice liuping = (liupingDevice)device;
            if (device != null && device is liupingDevice)
            {
                txb_Recipe_NO.Text = Convert.ToString(liuping.bianhao);
                //把运算值以字符串的格式写入到1#加热写入到TextBox内
                txb_Control_Temp1.Text = Convert.ToString(Convert.ToDecimal(liuping.ControlTemp1) / 1);
                //把运算值以字符串的格式写入到2#加热写入到TextBox内
                txb_Control_Temp2.Text = Convert.ToString(Convert.ToDecimal(liuping.ControlTemp2) / 1);
                //把运算值以字符串的格式写入到3#加热写入到TextBox内
                txb_Control_Temp3.Text = Convert.ToString(Convert.ToDecimal(liuping.ControlTemp3) / 1);

                if (liuping.ControlFans1 == 1)
                {
                    chb_Fans1.Text = "启动";
                    chb_Fans1.BackColor = Color.LightGreen;
                }
                else
                {
                    chb_Fans1.Text = "停止";
                    chb_Fans1.BackColor = Color.Red;
                }

                //把运算值以字符串的格式写入到2#风机开关写入到TextBox内
                //chb_Fans2.Text = Convert.ToString(Convert.ToDecimal(SwitchTemp2));

                if (liuping.ControlFans2 == 1)
                {
                    chb_Fans2.Text = "启动";
                    chb_Fans2.BackColor = Color.LightGreen;
                }
                else
                {
                    chb_Fans2.Text = "停止";
                    chb_Fans2.BackColor = Color.Red;
                }
                //把运算值以字符串的格式写入到3#风机开关写入到TextBox内
                //chb_Fans3.Text = Convert.ToString(Convert.ToDecimal(SwitchTemp3));

                if (liuping.ControlFans3 == 1)
                {
                    chb_Fans3.Text = "启动";
                    chb_Fans3.BackColor = Color.LightGreen;
                }
                else
                {
                    chb_Fans3.Text = "停止";
                    chb_Fans3.BackColor = Color.Red;
                }

                //把运算值以字符串的格式写入到1#输送线频率监视的TextBox内
                txb_Control_Conveyor_Main.Text = Convert.ToString(Convert.ToDecimal(liuping.ControlConveyorSpeed) / 10);


            }
        }
        //监控参数显示方法，需要循环调用一直显示
        public void Monitor_ReadBack()
        {
            liupingDevice liuping = (liupingDevice)device;
            //把运算值以字符串的格式写入到1#发热管温度监视的Label内
            lab_Monitor_Temp1.Text = Convert.ToString(Convert.ToDecimal(liuping.MonitorTemp1) / 10) + " ℃";
            //把运算值以字符串的格式写入到2#发热管温度监视的Label内
            lab_Monitor_Temp2.Text = Convert.ToString((Convert.ToDecimal(liuping.MonitorTemp2)) / 10) + " ℃";
            //把运算值以字符串的格式写入到3#发热管温度监视的Label内
            lab_Monitor_Temp3.Text = Convert.ToString(Convert.ToDecimal(liuping.MonitorTemp3) / 10) + " ℃";

            //把运算值以字符串的格式写入到输送线频率监视的Label内
            lab_Monitor_Conveyor1_Speed.Text = Convert.ToString(Convert.ToDecimal(liuping.MonitorConveyorSpeed) / 10) + " Hz";

            //把运算值以字符串的格式写入到1#发热管加热时间的Label内
            lab_Monitor_Temp1_Time.Text = Convert.ToString(Convert.ToDecimal(liuping.MonitorTemp1)) + " H";
            //把运算值以字符串的格式写入到2#发热管加热时间的Label内
            lab_Monitor_Temp2_Time.Text = Convert.ToString(Convert.ToDecimal(liuping.MonitorTemp2)) + " H";
            //把运算值以字符串的格式写入到3#发热管加热时间的Label内
            lab_Monitor_Temp3_Time.Text = Convert.ToString(Convert.ToDecimal(liuping.MonitorTemp3)) + " H";

            //把运算值以字符串的格式写入到1#输送线运行时间的Label内
            lab_Monitor_Conveyor1_Time.Text = Convert.ToString(Convert.ToDecimal(liuping.MonitorConveyorRunTime)) + " H";
        }
        //判定输入完成（KeyUp或者Leave）确定按钮     KeyUp和Leave
        private void textleave(object sender, EventArgs e)
        {
            //调用输入完成后的方法
            handleInputComplete(sender);
        }
        //判定输入完成（KeyUp或者Leave）确定按钮     KeyUp和Leave
        private void textleave(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handleInputComplete(sender);
            }
        }
        /// <summary>
        /// 点击配方保存时执行数据写入
        /// </summary>
        public void Btn_Recipe_Save_GotFocus()
        {
            //配方参数写入
            var res = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW0",
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Conveyor_Main.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Temp1.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Temp2.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Temp3.Text.ToString()) * 10));
            if (res == true)
            {
                Console.WriteLine("配方参数写入成功");
            }
            else
            {
                MessageBox.Show("配方参数写入失败");
            }

        }
        /// <summary>
        /// 风机开关选用情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeSetSwitch(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)sender;
            switch (checkbox.Name)
            {
                case "chb_Fans1":
                    //1#风机
                    if (chb_Fans1.Checked == true)
                    {
                        chb_Fans1.BackColor = Color.LightGreen;
                        chb_Fans1.Text = "启动";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW14", 1);
                    }
                    else
                    {
                        chb_Fans1.BackColor = Color.Red;
                        chb_Fans1.Text = "停止";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW14", 0);
                    }
                    break;
                case "chb_Fans2":
                    //2#风机
                    if (chb_Fans2.Checked == true)
                    {
                        chb_Fans2.BackColor = Color.LightGreen;
                        chb_Fans2.Text = "启动";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW16", 1);
                    }
                    else
                    {
                        chb_Fans2.BackColor = Color.Red;
                        chb_Fans2.Text = "停止";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW16", 0);
                    }
                    break;
                case "chb_Fans3":
                    //3#风机
                    if (chb_Fans3.Checked == true)
                    {
                        chb_Fans3.BackColor = Color.LightGreen;
                        chb_Fans3.Text = "启动";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW18", 1);
                    }
                    else
                    {
                        chb_Fans3.BackColor = Color.Red;
                        chb_Fans3.Text = "停止";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW18", 0);
                    }
                    break;
            }
        }
        /// <summary>
        /// 配方编号输入完成后自动写入到PLC
        /// </summary>
        /// <param name="sender"></param>
        public void handleInputComplete(object sender)
        {
            //配方编号写入
            var res1 = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW52", Convert.ToInt16(txb_Recipe_NO.Text.ToString()));
            if (res1 == true)
            {
                Console.WriteLine("配方编号写入成功");
            }
            else
            {
                MessageBox.Show("配方编号写入失败");
            }

        }
        //当输入光标放入输入框的时候，输入框的内容自动被选中
        private void txbClickSelect(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.TextBox button_Main = (System.Windows.Forms.TextBox)sender;
            switch (button_Main.Name)
            {
                case "txb_Recipe_NO":
                    txb_Recipe_NO.SelectAll();
                    break;
                case "txb_Control_Temp1":
                    txb_Control_Temp1.SelectAll();
                    break;
                case "txb_Control_Temp2":
                    txb_Control_Temp2.SelectAll();
                    break;
                case "txb_Control_Temp3":
                    txb_Control_Temp3.SelectAll();
                    break;
                case "txb_Control_Conveyor_Main":
                    txb_Control_Conveyor_Main.SelectAll();
                    break;
            }
        }
        //配方区域参数输入小数点数量和位置判定
        private void txbDecimalJudge(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46 && (int)e.KeyChar != 45)
                e.Handled = true;
            //小数点的处理。
            else if ((int)e.KeyChar == 46)                           //小数点
            {
                System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
                switch (textbox.Name)
                {
                    case "txb_Control_Conveyor_Main":
                        //输送线速度输入
                        if (txb_Control_Conveyor_Main.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Conveyor_Main.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Conveyor_Main.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txb_Control_Temp1":
                        //1#温度设定
                        if (txb_Control_Temp1.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Temp1.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Temp1.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txb_Control_Temp2":
                        //2#温度设定
                        if (txb_Control_Temp2.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Temp2.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Temp2.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txb_Control_Temp3":
                        //3#温度设定
                        if (txb_Control_Temp3.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Temp3.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Temp3.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                }
            }
        }
        //配方号输入判断
        private void txb_Recipe_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }
        //配方操作按钮按下
        private void btn_Recipe_OK_MouseDown(object sender, MouseEventArgs e)
        {
            btn_MouseDown(sender);//调用判断方法 
        }
        //对3个按钮进行判断，判断哪一个按钮被按下
        public void btn_MouseDown(object sender)
        {
            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            var rsno = false;
            switch (button.Name)
            {
                case "btn_Recipe_Save":
                    rsno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBB63", 1);
                    if (rsno == true)
                    {
                        btn_Recipe_Save.BackColor = Color.MediumSeaGreen;
                        parent.showLog(device.typeName + device.index + "配方保存操作执行成功");

                        Btn_Recipe_Save_GotFocus();
                        //按下按钮后自动开始计时
                        TimerCloseRead.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("配方保存操作执行失败");
                        parent.showLog(device.typeName + device.index + "配方保存操作执行失败");
                    }
                    break;

                case "btn_Recipe_Read":
                    rsno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBB63", 2);
                    if (rsno == true)
                    {
                        btn_Recipe_Read.BackColor = Color.MediumSeaGreen;
                        parent.showLog(device.typeName + device.index + "配方读取操作执行成功");
                        //按下按钮后自动开始计时
                        TimerCloseRead.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("配方读取操作执行失败");
                        parent.showLog(device.typeName + device.index + "配方读取操作执行失败");
                    }
                    break;

                case "btn_Recipe_OK":
                    rsno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBB63", 4);
                    if (rsno == true)
                    {
                        btn_Recipe_OK.BackColor = Color.MediumSeaGreen;
                        parent.showLog(device.typeName + device.index + "配方确认操作执行成功");
                    }
                    else
                    {
                        MessageBox.Show("配方确认操作执行失败");
                        parent.showLog(device.typeName + device.index + "配方确认操作执行失败");
                    }
                    break;
            }

        }
        //使配方读取按钮接通1S
        private void TimerCloseRead_Tick(object sender, EventArgs e)
        {
            btn_Recipe_Read.BackColor = Color.DodgerBlue;
            //配方读取后要刷新数据到界面
            refreshPeifang();
            btn_Recipe_Save.BackColor = Color.DodgerBlue;
            btn_Recipe_OK.BackColor = Color.DodgerBlue;

            TimerCloseRead.Enabled = false;
        }
        //向数据库的数据表插入数据行，
        private void saveToDatabaseTable()
        {
        }
        //当配方编号文本内容发生变化时
        private void txb_Recipe_NO_TextChanged(object sender, EventArgs e)
        {
            RecipeNO_Input();           //调用配方编号改变时的操作方法
        }
        //从本地ini文件读取物料编码和配方编号
        public void RecipeNO_Input()
        {
            Int32[] value = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };
            string[] way = new string[] { @"\Default-product1.ini" , @"\Default-product2.ini" , @"\Default-product3.ini", @"\Default-product4.ini", @"\Default-product5.ini", @"\Default-product6.ini",
                                             @"\Default-product7.ini" , @"\Default-product8.ini" , @"\Default-product9.ini" , @"\Default-product10.ini",
                @"\Default-product11.ini" , @"\Default-product12.ini" , @"\Default-product13.ini", @"\Default-product14.ini", @"\Default-product15.ini", @"\Default-product16.ini",
                                             @"\Default-product17.ini" , @"\Default-product18.ini" , @"\Default-product19.ini" , @"\Default-product20.ini" };

            //如果输入为空时自动返回之前的值
            if (txb_Recipe_NO.Text.Trim() == "")
            {
                //实例化涂布机设备
                liupingDevice liuping = (liupingDevice)device;
                txb_Recipe_NO.Text = Convert.ToString(liuping.bianhao);
                MessageBox.Show("输入无效，配方区间在1-20之间，请输入适当的配方编号");
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    //把中间转存的Default - code.ini内容路径找到然后读取出内容存储在txb_tiaoma.Text中
                    if (Convert.ToUInt32(txb_Recipe_NO.Text) == value[i])
                    {
                        string thispath = Application.StartupPath + way[i];                 //定义变量thisPath，获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称+路径
                        if (!System.IO.File.Exists(thispath)) return;                                       //确定指定的文件是否存在（文件的路径）；如果不存在则执行return
                        try
                        {
                            lab_Prt_NO.Text = System.IO.File.ReadAllText(thispath);                         //打开一个文本文件，读取文件的所有行，然后关闭该文件
                        }
                        catch { }
                    }
                }
            }
        }

        /*b0：運轉中;b1：正轉中;b2：反轉中;b3：頻率到達;b4：過負載;b5：參數恢復預設值結束;b6：頻率檢出;b7：異常發生;*/
        //变频器运行状态指示
        public void Inverter_Status()
        {

            string[] Conveyor1_Mes = new string[] { "输送线1运行中", "输送线1正转中", "输送线1反转中", "输送线1频率到达", "输送线1过负载", "输送线1频率检出", "输送线1异常发生" };
            UInt32[] status_value = new UInt32[] { 1, 3, 7, 15, 31, 63, 127, 255 };
            //Label[] label_Monitor = new Label[] { lab_Conveyor1, lab_Conveyor2, lab_App1, lab_Doc1,lab_ZP1, lab_App2, lab_Doc2 };
            //UInt32[] Address_NO = new UInt32[] {98,100,102,104,106,108 };
            UInt32[] Read_Back = new UInt32[7];

            //UInt32 Read_Back_App1 = 0, Read_Back_App2 = 0, Read_Back_Doc1 = 0, Read_Back_Doc2 = 0, Read_Back_ZP1 = 0, Read_Back_Conveyor1 = 0, Read_Back_Conveyor2 = 0;
            //1#涂布轮



            //int resno3 = CS7TCP.ReadWord(Z通讯设置.plcHandle, 0x84, 1, 98, ref Read_Back_App1);


            ////1#输送线
            //int resno1 = CS7TCP.ReadWord(Z通讯设置.plcHandle, 0x84, 1, 108, ref Read_Back_Conveyor1);
            //if (resno1 == 0)
            //{
            //    for (int i = 0; i < status_value.Length; i++)
            //    {
            //        if (Read_Back_Conveyor1 == status_value[i])
            //        {
            //            lab_Conveyor1.Text = Conveyor1_Mes[i];
            //            lab_Conveyor1.BackColor = Color.LightGreen;
            //        }
            //    }
            //}
        }


        //DB区的Word内容监控-----输送线报警监控-------------------------------------------------------------------------OK

        static String alarm_Conveyor1_Msg1 = "1#输送带变频器故障，0C1（停机时过电流）";
        static String alarm_Conveyor1_Msg2 = "1#输送带变频器故障，0C2（加速时过电流）";
        static String alarm_Conveyor1_Msg3 = "1#输送带变频器故障，0C0（减速时过电流）";
        static String alarm_Conveyor1_Msg4 = "1#输送带变频器故障，0V1（停机时过电压）";
        static String alarm_Conveyor1_Msg5 = "1#输送带变频器故障，0V2（加速时过电压）";
        static String alarm_Conveyor1_Msg6 = "1#输送带变频器故障，0V3（定速时过电压）";
        static String alarm_Conveyor1_Msg7 = "1#输送带变频器故障，0V0（减速时过电压）";
        static String alarm_Conveyor1_Msg8 = "1#输送带变频器故障，THT（IGBT模块过热）";
        static String alarm_Conveyor1_Msg9 = "1#输送带变频器故障，THN（电机过热）";
        static String alarm_Conveyor1_Msg10 = "1#输送带变频器故障，NTC(模组过热)";
        static String alarm_Conveyor1_Msg11 = "1#输送带变频器故障，EEP(内存异常)";
        static String alarm_Conveyor1_Msg12 = "1#输送带变频器故障，PIDE（PID异常）";
        static String alarm_Conveyor1_Msg13 = "1#输送带变频器故障，OLS(失速防止功能)";
        static String alarm_Conveyor1_Msg14 = "1#输送带变频器故障，OL2 (过转矩异常)";
        static String alarm_Conveyor1_Msg15 = "1#输送带变频器故障，OPT (通讯异常)";
        static String alarm_Conveyor1_Msg16 = "1#输送带变频器故障，SCP (短路过电流)";
        static String alarm_Conveyor1_Msg17 = "1#输送带变频器故障，CPU (CPU异常)";



        public void DB_Word_Alarm_Monitor()
        {
            /*报警代码*/
            UInt32[] alarm_value = new UInt32[] { 16, 17, 19, 32, 33, 34, 35, 48, 49, 50, 64, 66, 97, 98, 160, 179, 192 };
            //Label[] label_Monitor = new Label[] { lab_Conveyor1, lab_Conveyor2, lab_App1, lab_Doc1, lab_App2, lab_Doc2 };
            string[] Conveyor1_Msg = new string[] {alarm_Conveyor1_Msg1,alarm_Conveyor1_Msg2,alarm_Conveyor1_Msg3, alarm_Conveyor1_Msg4, alarm_Conveyor1_Msg5, alarm_Conveyor1_Msg6, alarm_Conveyor1_Msg7, alarm_Conveyor1_Msg8,
                alarm_Conveyor1_Msg9, alarm_Conveyor1_Msg10, alarm_Conveyor1_Msg11,alarm_Conveyor1_Msg12,alarm_Conveyor1_Msg13, alarm_Conveyor1_Msg14, alarm_Conveyor1_Msg15, alarm_Conveyor1_Msg16, alarm_Conveyor1_Msg17 };


            ////输送线1报警代码

            //for (int i = 0; i < alarm_value.Length; i++)
            //{
            //    if (alarm_value[i] == trans1_alarm_Read)                                               //==则表示报警
            //    {
            //        if (!lbMsg_Dialog.Items.Contains(Conveyor1_Msg[i]))             //判定当前没有显示，则插入一行显示
            //        {
            //            lbMsg_Dialog.Items.Insert(0, Conveyor1_Msg[i]);                         //如果当前没有显示则插入语句
            //        }
            //    }
            //    else
            //    {
            //        lbMsg_Dialog.Items.Remove(Conveyor1_Msg[i]);
            //    }
            //}
        }
        //界面布局显示
        private void A0流平机_Resize(object sender, EventArgs e)
        {
            /*
            容器1的分隔条显示距离=容器1的宽度/2
            */
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

    }
}
