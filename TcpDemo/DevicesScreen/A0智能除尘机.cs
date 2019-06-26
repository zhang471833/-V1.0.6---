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
    public partial class A0智能除尘机 : UserControl
    {
        //定义变量，变量类型为Device
        Device device;
        //定义公共变量，类型为winform窗体，名称：parentForm
        public A0开机画面 parentForm;
        public A0智能除尘机()
        {
            InitializeComponent();
        }
        //窗体load时执行的方法
        private void A0智能除尘机_Load(object sender, EventArgs e)
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
            //窗体加载时启动本窗体刷新程序1S一次
            Windows_Recyle.Enabled = true;
        }
        //窗体循环执行方法
        private void Window_Recyle_Tick(object sender, EventArgs e)
        {
            //调用连续读取字节段的方法，循环执行
            Monitor_ReadBack();
            //循环处理报警显示
            DB_Word_Alarm_Monitor();
        }
        //设置当前设备到父类Device内
        public void setDevice(Device device)
        {
            this.device = device;
            //调用初始化显示
            initView();
        }
        //初始化界面显示的方法
        public void initView()
        {
            //定义变量，设备子类型
            int childType = device.childType;
            //定义变量子类型的名字
            String text = "null";
            switch (childType)
            {
                case 11:
                    text = "全精密除尘机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密除尘机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    txb_Control_Pao_Height.Visible = false;
                    txb_Control_Pao_buchang.Visible = false;
                    chbPaoSwitch.Visible = false;
                    labelPao.Visible = false;
                    labelPaoMonitor.Visible = false;
                    lab_Monitor_Pao_Height.Visible = false;
                    lab_Monitor_Pao_Time.Visible = false;
                    lab_Monitor_Pao_Life.Visible = false;

                    break;
                case 12:
                    text = "全精密抛光除尘机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密除尘机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    txb_Control_Pao_Height.Visible = true;
                    txb_Control_Pao_buchang.Visible = true;
                    chbPaoSwitch.Visible = true;
                    labelPao.Visible = true;
                    labelPaoMonitor.Visible = true;
                    lab_Monitor_Pao_Height.Visible = true;
                    lab_Monitor_Pao_Time.Visible = true;
                    lab_Monitor_Pao_Life.Visible = true;
                    break;
            }
            //把获取到的文本内容赋值给配方区域的GroupBox的名字文本
            gbox_RecipeSetting.Text = text + device.index + " 【" + "配方设置" + "】";
        }
        //刷新配方数据，在界面打开的时候或者
        public void refreshPeifang()
        {
            if (device != null && device is CleanDevice)
            {

                //实例化流平机设备
                CleanDevice clean = (CleanDevice)device;
                ////把运算值以字符串的格式写入到1#涂布轮频率监视的TextBox内
                txb_Recipe_NO.Text = Convert.ToString(clean.bianhao);

                //把运算值以字符串的格式写入到1#输送线频率监视的TextBox内
                txb_Control_Conveyor_Main.Text = Convert.ToString(Convert.ToDecimal(clean.ControlConveyorSpeed) / 10);

                //把运算值以字符串的格式写入到毛刷轮高度监视的TextBox内
                txb_Control_Brush_Height.Text = Convert.ToString(Convert.ToDecimal(clean.ControlBrushHeight) / 100);

                //把运算值以字符串的格式写入到毛刷轮高度偏差监视的TextBox内
                txb_Control_Brush_buchang.Text = Convert.ToString(Convert.ToDecimal(clean.ControlBrushHeightbuchang) / 100);


                //把运算值以字符串的格式写入到毛刷轮高度监视的TextBox内
                txb_Control_Pao_Height.Text = Convert.ToString(Convert.ToDecimal(clean.ControlPaoHeight) / 100);

                //把运算值以字符串的格式写入到毛刷轮高度偏差监视的TextBox内
                txb_Control_Pao_buchang.Text = Convert.ToString(Convert.ToDecimal(clean.ControlPaoHeightbuchang) / 100);
                //把运算值以字符串的格式写入到风机开关的checkBox内
                if (clean.ControlFans == 1)
                {
                    Chb_Fans.Text = "启动";
                    Chb_Fans.BackColor = Color.LightGreen;
                }
                else
                {
                    Chb_Fans.Text = "停止";
                    Chb_Fans.BackColor = Color.Red;
                }
                //
                if (clean.ControlPaoSwitch == 1)
                {
                    chbPaoSwitch.Text = "打开";
                    chbPaoSwitch.BackColor = Color.LightGreen;
                }
                else
                {
                    chbPaoSwitch.Text = "关闭";
                    chbPaoSwitch.BackColor = Color.Red;
                }
                //把运算值以字符串的格式写入到毛刷开关的checkBox内
                if (clean.ControlBrushSwitch == 0)
                {
                    Chb_Brush.BackColor = Color.Red;
                    Chb_Brush_R.BackColor = Color.Red;

                }
                if (clean.ControlBrushSwitch == 1)
                {
                    Chb_Brush.Text = "正转";
                    Chb_Brush.BackColor = Color.LightGreen;
                    Chb_Brush_R.BackColor = Color.Red;
                }
                if (clean.ControlBrushSwitch == 2)
                {
                    Chb_Brush_R.Text = "反转";
                    Chb_Brush_R.BackColor = Color.LightGreen;
                    Chb_Brush.BackColor = Color.Red;
                }
            }
        }
        //把读回的数据写进监控数据区域的labels内部
        public void Monitor_ReadBack()
        {
            //实例化流平机设备
            CleanDevice clean = (CleanDevice)device;

            //把运算值以字符串的格式写入到1#输送线频率监视的Label内
            lab_Monitor_Conveyor1_Speed.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorConveyorSpeed) / 100) + " Hz";
            //把运算值以字符串的格式写入到毛刷轮高度监视的Label内
            lab_Monitor_Brush_Height.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorBrushHeight) / 100) + " cm";
            //把运算值以字符串的格式写入到抛光轮高度监视的Label内
            lab_Monitor_Pao_Height.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorPaoHeight) / 100) + " cm";

            //把运算值以字符串的格式写入到输送运行时间的Label内
            lab_Monitor_Trans_Time.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorConveyorRunTime)) + " H";

            //把运算值以字符串的格式写入到毛刷轮运行时间的Label内
            lab_Monitor_Brush_Time.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorBrushRunTime)) + " H";
            //把运算值以字符串的格式写入到抛光轮运行时间的Label内
            lab_Monitor_Pao_Time.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorPaoRunTime)) + " H";

            //把运算值以字符串的格式写入到抛光轮运行时间的Label内
            lab_Monitor_Fans_Time.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorFansRunsTime)) + " H";

            //把运算值以字符串的格式写入到毛刷轮剩余运行时间的Label内
            lab_Monitor_Brush_Life.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorBrushLeftTime)) + " H";

            //把运算值以字符串的格式写入到抛光轮剩余运行时间的Label内
            lab_Monitor_Pao_Life.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorPaoLeftTime)) + " H";

        }
        /// <summary>
        /// 点击配方保存时执行数据写入
        /// </summary>
        public void Btn_Recipe_Save_GotFocus()
        {
            //配方参数写入
            var res = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW0",
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Conveyor_Main.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Pao_Height.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Brush_Height.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Pao_buchang.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Brush_buchang.Text.ToString()) * 100));
            
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
        /// 配方内部的几个开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeSetSwitch(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox CheckBoxName = (System.Windows.Forms.CheckBox)sender;
            switch (CheckBoxName.Name)
            {
                case "Chb_Brush":
                    //毛刷轮的配方写入
                    if (Chb_Brush.Checked == true)
                    {
                        Chb_Brush_R.Checked = false;
                        Chb_Brush_R.BackColor = Color.Red;
                        Chb_Brush.BackColor = Color.LightGreen;
                        Chb_Brush.Text = "正转";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW12", 1);
                    }
                    else
                    {
                        Chb_Brush.BackColor = Color.Red;
                        Chb_Brush.Text = "正转";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW12", 0);
                    }
                    break;
                case "Chb_Brush_R":
                    //毛刷轮的配方写入
                    if (Chb_Brush_R.Checked == true)
                    {
                        Chb_Brush.Checked = false;
                        Chb_Brush.BackColor = Color.Red;
                        Chb_Brush_R.BackColor = Color.LightGreen;
                        Chb_Brush_R.Text = "反转";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW12", 2);
                    }
                    else
                    {
                        Chb_Brush_R.BackColor = Color.Red;
                        Chb_Brush_R.Text = "反转";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW12", 0);
                    }
                    break;
                case "chbPaoSwitch":
                    //抛光轮的配方写入
                    if (chbPaoSwitch.Checked == true)
                    {
                        chbPaoSwitch.BackColor = Color.LightGreen;
                        chbPaoSwitch.Text = "打开";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW14", 1);
                    }
                    else
                    {
                        chbPaoSwitch.BackColor = Color.Red;
                        chbPaoSwitch.Text = "关闭";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW14", 0);
                    }
                    break;
                case "Chb_Fans":
                    //风扇的配方写入
                    if (Chb_Fans.Checked == true)
                    {
                        Chb_Fans.BackColor = Color.LightGreen;
                        Chb_Fans.Text = "启动";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW10", 1);
                    }
                    else
                    {
                        Chb_Fans.BackColor = Color.Red;
                        Chb_Fans.Text = "停止";
                        var resno = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW10", 0);
                    }
                    break;
                }
        }
        /// <summary>
        /// 配方编号输入后自动写入到PLC内部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeInputOK(object sender, EventArgs e)
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
        //当输入光标放入输入框的时候
        private void txb_Control_App3_Temp_MouseClick(object sender, MouseEventArgs e)
        {
            Select(sender);
        }
        public void Select(object sender)
        {
            System.Windows.Forms.TextBox button_Main = (System.Windows.Forms.TextBox)sender;
            switch (button_Main.Name)
            {
                case "txb_Recipe_NO":
                    txb_Recipe_NO.SelectAll();
                    break;
                case "txb_Control_Conveyor_Main":
                    txb_Control_Conveyor_Main.SelectAll();
                    break;
                case "txb_Control_Brush_Height":
                    txb_Control_Brush_Height.SelectAll();
                    break;
                case "txb_Control_Brush_buchang":
                    txb_Control_Brush_buchang.SelectAll();
                    break;
                case "txb_Control_Pao_Height":
                    txb_Control_Brush_Height.SelectAll();
                    break;
                case "txb_Control_Pao_buchang":
                    txb_Control_Brush_buchang.SelectAll();
                    break;
            }
        }
        //判断输入框输入的是否是浮点数，其它字符不可输入
        private void txb_Control_App3_Temp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46 && (int)e.KeyChar != 45)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
                switch (textbox.Name)
                {
                    case "txb_Control_Conveyor_Main":
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
                    case "txb_Control_Brush_Height":
                        if (txb_Control_Brush_Height.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Brush_Height.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Brush_Height.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txb_Control_Pao_Height":
                        if (txb_Control_Pao_Height.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Pao_Height.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Pao_Height.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txb_Control_Brush_buchang":
                        if (txb_Control_Brush_buchang.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Brush_buchang.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Brush_buchang.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txb_Control_Pao_buchang":
                        if (txb_Control_Pao_buchang.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Pao_buchang.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Pao_buchang.Text + e.KeyChar.ToString(), out f);
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
        private void btn_Recipe_Save_MouseDown(object sender, MouseEventArgs e)
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
                CleanDevice clean = (CleanDevice)device;
                txb_Recipe_NO.Text = Convert.ToString(clean.bianhao);
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


            //输送线1报警代码

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
        private void A0智能除尘机_Resize(object sender, EventArgs e)
        {
            /*
            容器1的分隔条显示距离=容器1的宽度/2
            */
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

    }
}
