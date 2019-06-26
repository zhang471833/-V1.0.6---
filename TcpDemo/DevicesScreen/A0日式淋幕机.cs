using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpDemo
{
    public partial class A0日式淋幕机 : UserControl
    {
        //定义变量，变量类型为Device
        Device device;
        //定义公共变量，类型为winform窗体，名称：parentForm
        public A0开机画面 parentForm;
        public A0日式淋幕机()
        {
            InitializeComponent();
        }
        //窗体load时执行的方法
        private void A0日式淋幕机_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            //窗体加载时启动本窗体刷新程序1S一次
            Windows_Recyle.Enabled = true;
        }
        //窗体循环执行方法
        private void Windows_Recyle_Tick(object sender, EventArgs e)
        {
            //调用连续读取字节段的方法，循环执行
            Monitor_ReadBack();
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
                case 30:
                    text = "四级淋幕机";
                    ////gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密除尘机.png");
                    //gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //txbControlOilTemp.Visible = false;
                    //txb_Control_Pao_buchang.Visible = false;
                    //labOilTemp.Visible = false;
                    //labelPaoMonitor.Visible = false;
                    //lab_Monitor_Conveyor_Speed.Visible = false;
                    //lab_Monitor_Conveyor_Time.Visible = false;
                    //lab_Monitor_Pao_Life.Visible = false;

                    break;
                case 31:
                    text = "四级淋幕机";
                    ////gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密除尘机.png");
                    //gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //txbControlOilTemp.Visible = true;
                    //txb_Control_Pao_buchang.Visible = true;
                    //labOilTemp.Visible = true;
                    //labelPaoMonitor.Visible = true;
                    //lab_Monitor_Conveyor_Speed.Visible = true;
                    //lab_Monitor_Conveyor_Time.Visible = true;
                    //lab_Monitor_Pao_Life.Visible = true;
                    break;
            }
            //把获取到的文本内容赋值给配方区域的GroupBox的名字文本
            gbox_RecipeSetting.Text = text + device.index + " 【" + "配方设置" + "】"+device.address;
        }
        //刷新配方数据，在界面打开的时候或者
       
        public void refreshPeifang()
        {
            //实例化流平机设备
            LinmuDevice LinMu = (LinmuDevice)device;
            if (device != null && device is CleanDevice)
            {
                txb_Recipe_NO.Text = Convert.ToString(LinMu.bianhao);
                //把运算值以字符串的格式写入到1#输送线频率监视的TextBox内
                txb_Control_Conveyor_Main.Text = Convert.ToString(Convert.ToDecimal(LinMu.ControlConveyorSpeed) / 10);

                //把运算值以字符串的格式写入到毛刷轮高度监视的TextBox内
                txbControlBumpSpeed.Text = Convert.ToString(Convert.ToDecimal(LinMu.ControlOilBumpSpeed) / 10);

                txb_Control_Conveyor_High.Text = Convert.ToString(Convert.ToDecimal(LinMu.ControlConveyorHighSpeed) / 10);
                txb_Control_Conveyor_Low.Text = Convert.ToString(Convert.ToDecimal(LinMu.ControlConveyorLowSpeed) / 10);
                TxbControlZhengPingSpeed.Text = Convert.ToString(Convert.ToDecimal(LinMu.ControlZhengPingSpeed) / 10);
                txbControlOilTemp.Text = Convert.ToString(Convert.ToDecimal(LinMu.ControlOilTemp) / 10);
            }
        }
        //把读回的数据写进监控数据区域的labels内部
        public void Monitor_ReadBack()
        {
            //实例化流平机设备
            LinmuDevice LinMu = (LinmuDevice)device;

            //把运算值以字符串的格式写入到1#输送线频率监视的Label内
            lab_Monitor_Conveyor_Speed.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorConveyorSpeed1) / 10) + " Hz";
           
            lab_Monitor_Low_Speed.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorConveyorLowSpeed) / 10) + " Hz";
            lab_Monitor_High_Speed.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorConveyorHighSpeed) / 10) + " Hz";
            //把运算值以字符串的格式写入到毛刷轮高度监视的Label内
            lab_Monitor_Bump_Speed.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorOilBumpSpeed) / 10) + " Hz";


            //把运算值以字符串的格式写入到毛刷轮运行时间的Label内
            lab_Monitor_Bump_Time.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorOilBumpRunTime1)) + " H";
            //把运算值以字符串的格式写入到抛光轮运行时间的Label内
            lab_Monitor_High_Time.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorConveyorHighRunTime)) + " H";
            lab_Monitor_Low_Time.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorConveyorLowRunTime)) + " H";
            lab_Monitor_Conveyor_Time.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorConveyorRunTime1)) + " H";
            //把运算值以字符串的格式写入到毛刷轮剩余运行时间的Label内
            lab_Monitor_Heating_Time.Text = Convert.ToString(Convert.ToDecimal(LinMu.MonitorHeatingTime2)) + " H";

        }
        /// <summary>
        /// 点击配方保存时执行数据写入
        /// </summary>
        public void Btn_Recipe_Save_GotFocus()
        {
            //配方参数写入
            var res = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW0",
                Convert.ToInt16(Convert.ToDecimal(txbControlBumpSpeed.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Conveyor_Main.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(TxbControlZhengPingSpeed.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Conveyor_High.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txb_Control_Conveyor_Low.Text.ToString()) * 10));

            if (res == true)
            {
                Console.WriteLine("配方参数写入成功");
            }
            else
            {
                MessageBox.Show("配方参数写入失败");
            }
            //配方参数写入
            var res1 = device.BaseProtocol.WriteReg("DB" + device.address + ".DBW32",
                Convert.ToInt16(Convert.ToDecimal(txbControlOilTemp.Text.ToString()) * 10));

            if (res1 == true)
            {
                Console.WriteLine("油温配方参数写入成功");
            }
            else
            {
                MessageBox.Show("油温配方参数写入失败");
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
        private void btnChoiced(object sender, MouseEventArgs e)
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
                case "txbControlBumpSpeed":
                    txbControlBumpSpeed.SelectAll();
                    break;
                case "txb_Control_Conveyor_High":
                    txb_Control_Conveyor_High.SelectAll();
                    break;
                case "txb_Control_Conveyor_Low":
                    txb_Control_Conveyor_Low.SelectAll();
                    break;
                case "TxbControlZhengPingSpeed":
                    TxbControlZhengPingSpeed.SelectAll();
                    break;
                case "txbControlOilTemp":
                    txbControlOilTemp.SelectAll();
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
                    case "txbControlBumpSpeed":
                        if (txbControlBumpSpeed.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txbControlBumpSpeed.Text, out oldf);
                            b2 = float.TryParse(txbControlBumpSpeed.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txb_Control_Conveyor_High":
                        if (txb_Control_Conveyor_High.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Conveyor_High.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Conveyor_High.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txb_Control_Conveyor_Low":
                        if (txb_Control_Conveyor_Low.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txb_Control_Conveyor_Low.Text, out oldf);
                            b2 = float.TryParse(txb_Control_Conveyor_Low.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "TxbControlZhengPingSpeed":
                        if (TxbControlZhengPingSpeed.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(TxbControlZhengPingSpeed.Text, out oldf);
                            b2 = float.TryParse(TxbControlZhengPingSpeed.Text + e.KeyChar.ToString(), out f);
                            if (b2 == false)
                            {
                                if (b1 == true)
                                    e.Handled = true;
                                else
                                    e.Handled = false;
                            }
                        }
                        break;
                    case "txbControlOilTemp":
                        if (txbControlOilTemp.Text.Length <= 0)
                            e.Handled = true;                           //小数点不能在第一位
                        else
                        {
                            float f;
                            float oldf;
                            bool b1 = false, b2 = false;
                            b1 = float.TryParse(txbControlOilTemp.Text, out oldf);
                            b2 = float.TryParse(txbControlOilTemp.Text + e.KeyChar.ToString(), out f);
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
                //实例化淋幕机设备
                LinmuDevice LinMu = (LinmuDevice)device;
                txb_Recipe_NO.Text = Convert.ToString(LinMu.bianhao);
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
        //界面布局显示
        private void A0日式淋幕机_Resize(object sender, EventArgs e)
        {
            /*
            容器1的分隔条显示距离=容器1的宽度/2
            */
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }
    }
}
