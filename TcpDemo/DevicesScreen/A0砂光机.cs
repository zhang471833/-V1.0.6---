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
    public partial class A0砂光机 : UserControl
    {
        //定义变量，变量类型为Device
        Device device;
        //定义公共变量，类型为winform窗体，名称：parentForm
        public A0开机画面 parentForm;
        public A0砂光机()
        {
            InitializeComponent();
        }
        //窗体load时执行的方法
        private void A0砂光机_Load(object sender, EventArgs e)
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
                case 42:
                    text = "底漆砂光机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密除尘机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //txb_Control_Pao_Height.Visible = false;
                    //txb_Control_Pao_buchang.Visible = false;
                    //labelPao.Visible = false;
                    //labelPaoMonitor.Visible = false;
                    //lab_Monitor_Pao_Speed.Visible = false;
                    //lab_Monitor_Pao_Time.Visible = false;
                    //lab_Monitor_Pao_Life.Visible = false;

                    break;
                case 43:
                    text = "上浮式砂光机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密除尘机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //txb_Control_Pao_Height.Visible = true;
                    //txb_Control_Pao_buchang.Visible = true;
                    //labelPao.Visible = true;
                    //labelPaoMonitor.Visible = true;
                    //lab_Monitor_Pao_Speed.Visible = true;
                    //lab_Monitor_Pao_Time.Visible = true;
                    //lab_Monitor_Pao_Life.Visible = true;
                    break;
            }
            //把获取到的文本内容赋值给配方区域的GroupBox的名字文本
            gbox_RecipeSetting.Text = text + device.index + " 【" + "配方设置" + "】";
        }
        //刷新配方数据，在界面打开的时候或者
        public void refreshPeifang()
        {
            //实例化流平机设备
            ShaDevice clean = (ShaDevice)device;
            //循环读取刷新所有参数
            //clean.analyseDatasRecyle();
            if (device != null && device is ShaDevice)
            {
                txb_Recipe_NO.Text = Convert.ToString(clean.bianhao);
                //把运算值以字符串的格式写入到1#涂布轮频率监视的TextBox内
                txb_Recipe_NO.Text = Convert.ToString(Convert.ToDecimal(clean.bianhao));

                //把运算值以字符串的格式写入到1#输送线频率监视的TextBox内
                txb_Control_Conveyor_Main.Text = Convert.ToString(Convert.ToDecimal(clean.ControlConveyorSpeed) / 10);

                //把运算值以字符串的格式写入到毛刷轮高度监视的TextBox内
                //txb_Control_Brush_Height.Text = Convert.ToString(Convert.ToDecimal(clean.ControlBrushHeight) / 100);

                //把运算值以字符串的格式写入到毛刷轮高度偏差监视的TextBox内
                //txb_Control_Brush_buchang.Text = Convert.ToString(Convert.ToDecimal(clean.ControlBrushHeightbuchang) / 100);
            }
        }
        //把读回的数据写进监控数据区域的labels内部
        public void Monitor_ReadBack()
        {
            //实例化砂光机设备
            ShaDevice sha = (ShaDevice)device;

            ////把运算值以字符串的格式写入到1#输送线频率监视的Label内
            //lab_Monitor_Conveyor1_Speed.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorConveyorSpeed) / 100) + " Hz";
            ////把运算值以字符串的格式写入到毛刷轮高度监视的Label内
            //lab_Monitor_Brush_Speed.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorBrushHeight) / 100) + " mm";


            ////把运算值以字符串的格式写入到毛刷轮运行时间的Label内
            //lab_Monitor_Trans_Time.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorConveyorRunTime)) + " H";

            ////把运算值以字符串的格式写入到毛刷轮运行时间的Label内
            //lab_Monitor_Brush_Time.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorBrushRunTime)) + " H";
            //////把运算值以字符串的格式写入到抛光轮运行时间的Label内
            ////lab_Monitor_Fans_Time.Text = Convert.ToString(Convert.ToDecimal(PaoRunTime)) + " H";

            ////把运算值以字符串的格式写入到抛光轮运行时间的Label内
            //lab_Monitor_Fans_Time.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorFansRunsTime)) + " H";

            ////把运算值以字符串的格式写入到毛刷轮剩余运行时间的Label内
            //lab_Monitor_Brush_Life.Text = Convert.ToString(Convert.ToDecimal(clean.MonitorBrushLeftTime)) + " H";

        }

        //判定输入完成（KeyUp或者Leave）确定按钮
        private void textleave(object sender, EventArgs e)
        {
            handleInputComplete(sender);
        }
        private void textleave(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handleInputComplete(sender);
            }
        }
        //判定离开后开始执行写入指令
        //配方参数输入，，，，，，对话框中参数输入
        public void handleInputComplete(object sender)
        {
            
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
                //case "txb_Control_Brush_Height":
                //    txb_Control_Brush_Height.SelectAll();
                //    break;
                //case "txb_Control_Brush_buchang":
                //    txb_Control_Brush_buchang.SelectAll();
                //    break;
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
                    //case "txb_Control_Brush_Height":
                    //    if (txb_Control_Brush_Height.Text.Length <= 0)
                    //        e.Handled = true;                           //小数点不能在第一位
                    //    else
                    //    {
                    //        float f;
                    //        float oldf;
                    //        bool b1 = false, b2 = false;
                    //        b1 = float.TryParse(txb_Control_Brush_Height.Text, out oldf);
                    //        b2 = float.TryParse(txb_Control_Brush_Height.Text + e.KeyChar.ToString(), out f);
                    //        if (b2 == false)
                    //        {
                    //            if (b1 == true)
                    //                e.Handled = true;
                    //            else
                    //                e.Handled = false;
                    //        }
                    //    }
                    //    break;
                    //case "txb_Control_Pao_Height":
                    //    if (txb_Control_Pao_Height.Text.Length <= 0)
                    //        e.Handled = true;                           //小数点不能在第一位
                    //    else
                    //    {
                    //        float f;
                    //        float oldf;
                    //        bool b1 = false, b2 = false;
                    //        b1 = float.TryParse(txb_Control_Pao_Height.Text, out oldf);
                    //        b2 = float.TryParse(txb_Control_Pao_Height.Text + e.KeyChar.ToString(), out f);
                    //        if (b2 == false)
                    //        {
                    //            if (b1 == true)
                    //                e.Handled = true;
                    //            else
                    //                e.Handled = false;
                    //        }
                    //    }
                    //    break;
                    //case "txb_Control_Brush_buchang":
                    //    if (txb_Control_Brush_buchang.Text.Length <= 0)
                    //        e.Handled = true;                           //小数点不能在第一位
                    //    else
                    //    {
                    //        float f;
                    //        float oldf;
                    //        bool b1 = false, b2 = false;
                    //        b1 = float.TryParse(txb_Control_Brush_buchang.Text, out oldf);
                    //        b2 = float.TryParse(txb_Control_Brush_buchang.Text + e.KeyChar.ToString(), out f);
                    //        if (b2 == false)
                    //        {
                    //            if (b1 == true)
                    //                e.Handled = true;
                    //            else
                    //                e.Handled = false;
                    //        }
                    //    }
                    //    break;
                    //case "txb_Control_Pao_buchang":
                    //    if (txb_Control_Pao_buchang.Text.Length <= 0)
                    //        e.Handled = true;                           //小数点不能在第一位
                    //    else
                    //    {
                    //        float f;
                    //        float oldf;
                    //        bool b1 = false, b2 = false;
                    //        b1 = float.TryParse(txb_Control_Pao_buchang.Text, out oldf);
                    //        b2 = float.TryParse(txb_Control_Pao_buchang.Text + e.KeyChar.ToString(), out f);
                    //        if (b2 == false)
                    //        {
                    //            if (b1 == true)
                    //                e.Handled = true;
                    //            else
                    //                e.Handled = false;
                    //        }
                    //    }
                    //    break;
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
            
        }
        //使配方读取按钮接通1S
        private void TimerCloseRead_Tick(object sender, EventArgs e)
        {
            
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
                //UInt32 ReadBack = 0;
                //CS7TCP.ReadWord(Z通讯设置.plcHandle, 0x84, device.address, 52, ref ReadBack);
                //txb_Recipe_NO.Text = Convert.ToString(ReadBack);
                //MessageBox.Show("输入无效，配方区间在1-20之间，请输入适当的配方编号");
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
        private void A0砂光机_Resize(object sender, EventArgs e)
        {
            /*
            容器1的分隔条显示距离=容器1的宽度/2
            */
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }
    }
}
