using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace TcpDemo
{

    public partial class A1全精密滚涂机 : UserControl
    {
        Device device;
        public A1全精密滚涂机()
        {
            InitializeComponent();
        }
        public A0开机画面 parentForm;                //定义公共变量，类型为winform窗体，名称：parentForm
        //全精密补土机窗体加载
        private void A1全精密补土机_Load(object sender, EventArgs e)
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
            Windows_Recyle.Enabled = true;                       //窗体加载时启动本窗体刷新程序0.5S一次
        }
        //全精密补土机循环调用程序
        private void Window_Recyle_Tick(object sender, EventArgs e)
        {
            //调用连续读取字节段的方法，循环执行
            Monitor_ReadBack();
            //循环处理报警显示
            DB_Word_Alarm_Monitor();

            labStatus.Text = "通讯状态: " + device.BaseProtocol.ConnectState +
                " 刷新周期: " + Convert.ToString(device.BaseProtocol.ScanPeriod + 500) + " ms" +
                "设备运行状态: " + device.BaseProtocol.RunState;
            labStatus.BackColor = Color.LightGreen;
        }
        public void setDevice(Device device)
        {
            this.device = device;
            //调用初始化显示
            initView();
        }
        /// <summary>
        /// 初始化界面显示的方法
        /// </summary>
        public void initView()
        {
            int childType = device.childType;

            //定义变量子类型的名字
            String text = "null";
            switch (childType)
            {
                case 21:
                    text = "全精密单滚涂布机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密单滚涂布机.png");
                    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //滚子启用屏蔽checkBox按钮
                    chbApp1Choose.Visible = true;
                    chbApp2Choose.Visible = false;
                    chbApp3Choose.Visible = false;
                    //配方输入框被隐藏
                    txbControlZP1.Visible = false;
                    txbControlZP1Height.Visible = false;
                    txbControlZP2buchang.Visible = false;

                    txbControlApp2Speed.Visible = false;
                    txbControlApp2Height.Visible = false;
                    txbControlApp2buchang.Visible = false;
                    txbControlApp2Temp.Visible = false;
                    txbControlDoc2.Visible = false;

                    txbControlApp3Speed.Visible = false;
                    txbControlApp3Height.Visible = false;
                    txbControlApp3buchang.Visible = false;
                    txbControlApp3Temp.Visible = false;
                    txbControlDoc3.Visible = false;
                    //配方区域的标签不显示
                    labelZp1.Visible = false;
                    labelApp2.Visible = false;
                    labelDoc2.Visible = false;
                    labelApp3.Visible = false;
                    labelDoc3.Visible = false;
                    //参数显示区域的标签不显示
                    labelZp1Monitor.Visible = false;

                    labelApp2Monitor.Visible = false;
                    labelDoc2Monitor.Visible = false;

                    labelApp3Monitor.Visible = false;
                    labelDoc3Monitor.Visible = false;

                    labelHeating2Monitor.Visible = false;
                    labelHeating3Monitor.Visible = false;

                    labelHeight2Monitor.Visible = false;
                    labelHeight3Monitor.Visible = false;
                    labelHeight4Monitor.Visible = false;
                    //参数显示区域的数据不显示
                    lab_Monitor_ZP1_Speed.Visible = false;
                    lab_Monitor_ZP1_Time.Visible = false;

                    lab_Monitor_APP2_Speed.Visible = false;
                    lab_Monitor_APP2_Time.Visible = false;
                    lab_Monitor_APP2_Life.Visible = false;
                    lab_Monitor_DOC2_Speed.Visible = false;
                    lab_Monitor_DOC2_Time.Visible = false;

                    lab_Monitor_APP3_Speed.Visible = false;
                    lab_Monitor_APP3_Time.Visible = false;
                    lab_Monitor_APP3_Life.Visible = false;
                    lab_Monitor_DOC3_Speed.Visible = false;
                    lab_Monitor_DOC3_Time.Visible = false;

                    lab_Monitor_Heating2.Visible = false;
                    lab_Monitor_Heating3.Visible = false;

                    lab_Monitor_Height2.Visible = false;
                    lab_Monitor_Height3.Visible = false;
                    lab_Monitor_Height4.Visible = false;

                    break;
                case 22:
                    text = "全精密双滚涂布机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密双滚涂布机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //滚子启用屏蔽checkBox按钮
                    chbApp1Choose.Visible = true;
                    chbApp2Choose.Visible = true;
                    chbApp3Choose.Visible = false;
                    //配方输入框被隐藏
                    txbControlZP1.Visible = false;
                    txbControlZP1Height.Visible = false;
                    txbControlZP2buchang.Visible = false;

                    txbControlApp2Speed.Visible = true;
                    txbControlApp2Height.Visible = true;
                    txbControlApp2buchang.Visible = true;
                    txbControlApp2Temp.Visible = true;
                    txbControlDoc2.Visible = true;

                    txbControlApp3Speed.Visible = false;
                    txbControlApp3Height.Visible = false;
                    txbControlApp3buchang.Visible = false;
                    txbControlApp3Temp.Visible = false;
                    txbControlDoc3.Visible = false;
                    //配方区域的标签不显示
                    labelZp1.Visible = false;
                    labelApp2.Visible = true;
                    labelDoc2.Visible = true;
                    labelApp3.Visible = false;
                    labelDoc3.Visible = false;
                    //参数显示区域的标签不显示
                    labelZp1Monitor.Visible = false;

                    labelApp2Monitor.Visible = true;
                    labelDoc2Monitor.Visible = true;

                    labelApp3Monitor.Visible = false;
                    labelDoc3Monitor.Visible = false;

                    labelHeating2Monitor.Visible = true;
                    labelHeating3Monitor.Visible = false;

                    labelHeight2Monitor.Visible = false;
                    labelHeight3Monitor.Visible = true;
                    labelHeight4Monitor.Visible = false;
                    //参数显示区域的数据不显示
                    lab_Monitor_ZP1_Speed.Visible = false;
                    lab_Monitor_ZP1_Time.Visible = false;

                    lab_Monitor_APP2_Speed.Visible = true;
                    lab_Monitor_APP2_Time.Visible = true;
                    lab_Monitor_APP2_Life.Visible = true;
                    lab_Monitor_DOC2_Speed.Visible = true;
                    lab_Monitor_DOC2_Time.Visible = true;

                    lab_Monitor_APP3_Speed.Visible = false;
                    lab_Monitor_APP3_Time.Visible = false;
                    lab_Monitor_APP3_Life.Visible = false;
                    lab_Monitor_DOC3_Speed.Visible = false;
                    lab_Monitor_DOC3_Time.Visible = false;

                    lab_Monitor_Heating2.Visible = true;
                    lab_Monitor_Heating3.Visible = false;

                    lab_Monitor_Height2.Visible = false;
                    lab_Monitor_Height3.Visible = true;
                    lab_Monitor_Height4.Visible = false;
                    break;
                case 23:
                    text = "全精密三滚涂布机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密三滚涂布机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //滚子启用屏蔽checkBox按钮
                    chbApp1Choose.Visible = true;
                    chbApp2Choose.Visible = true;
                    chbApp3Choose.Visible = true;
                    //配方输入框被隐藏
                    txbControlZP1.Visible = false;
                    txbControlZP1Height.Visible = false;
                    txbControlZP2buchang.Visible = false;

                    txbControlApp2Speed.Visible = true;
                    txbControlApp2Height.Visible = true;
                    txbControlApp2buchang.Visible = true;
                    txbControlApp2Temp.Visible = true;
                    txbControlDoc2.Visible = true;

                    txbControlApp3Speed.Visible = true;
                    txbControlApp3Height.Visible = true;
                    txbControlApp3buchang.Visible = true;
                    txbControlApp3Temp.Visible = true;
                    txbControlDoc3.Visible = true;
                    //配方区域的标签不显示
                    labelZp1.Visible = false;
                    labelApp2.Visible = true;
                    labelDoc2.Visible = true;
                    labelApp3.Visible = true;
                    labelDoc3.Visible = true;
                    //参数显示区域的标签不显示
                    labelZp1Monitor.Visible = false;

                    labelApp2Monitor.Visible = true;
                    labelDoc2Monitor.Visible = true;

                    labelApp3Monitor.Visible = true;
                    labelDoc3Monitor.Visible = true;

                    labelHeating2Monitor.Visible = true;
                    labelHeating3Monitor.Visible = true;

                    labelHeight2Monitor.Visible = false;
                    labelHeight3Monitor.Visible = true;
                    labelHeight4Monitor.Visible = true;
                    //参数显示区域的数据不显示
                    lab_Monitor_ZP1_Speed.Visible = false;
                    lab_Monitor_ZP1_Time.Visible = false;

                    lab_Monitor_APP2_Speed.Visible = true;
                    lab_Monitor_APP2_Time.Visible = true;
                    lab_Monitor_APP2_Life.Visible = true;
                    lab_Monitor_DOC2_Speed.Visible = true;
                    lab_Monitor_DOC2_Time.Visible = true;

                    lab_Monitor_APP3_Speed.Visible = true;
                    lab_Monitor_APP3_Time.Visible = true;
                    lab_Monitor_APP3_Life.Visible = true;
                    lab_Monitor_DOC3_Speed.Visible = true;
                    lab_Monitor_DOC3_Time.Visible = true;

                    lab_Monitor_Heating2.Visible = true;
                    lab_Monitor_Heating3.Visible = true;

                    lab_Monitor_Height2.Visible = false;
                    lab_Monitor_Height3.Visible = true;
                    lab_Monitor_Height4.Visible = true;
                    break;
                case 24:
                    text = "补土+单滚涂布机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密补土+单滚涂布机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //滚子启用屏蔽checkBox按钮
                    chbApp1Choose.Visible = true;
                    chbApp2Choose.Visible = true;
                    chbApp3Choose.Visible = false;
                    //配方输入框被隐藏
                    txbControlZP1.Visible = true;
                    txbControlZP1Height.Visible = true;
                    txbControlZP2buchang.Visible = true;

                    txbControlApp2Speed.Visible = true;
                    txbControlApp2Height.Visible = true;
                    txbControlApp2buchang.Visible = true;
                    txbControlApp2Temp.Visible = true;
                    txbControlDoc2.Visible = true;

                    txbControlApp3Speed.Visible = false;
                    txbControlApp3Height.Visible = false;
                    txbControlApp3buchang.Visible = false;
                    txbControlApp3Temp.Visible = false;
                    txbControlDoc3.Visible = false;
                    //配方区域的标签不显示
                    labelZp1.Visible = true;
                    labelZp1.Text = "1#整平轮";
                    labelApp2.Visible = true;
                    labelDoc2.Visible = true;
                    labelApp3.Visible = false;
                    labelDoc3.Visible = false;
                    //参数显示区域的标签不显示
                    labelZp1Monitor.Visible = true;
                    labelZp1Monitor.Text = "1#整平轮";

                    labelApp2Monitor.Visible = true;
                    labelDoc2Monitor.Visible = true;

                    labelApp3Monitor.Visible = false;
                    labelDoc3Monitor.Visible = false;

                    labelHeating2Monitor.Visible = true;
                    labelHeating3Monitor.Visible = false;

                    labelHeight2Monitor.Visible = true;
                    labelHeight3Monitor.Visible = true;
                    labelHeight4Monitor.Visible = false;
                    //参数显示区域的数据不显示
                    lab_Monitor_ZP1_Speed.Visible = true;
                    lab_Monitor_ZP1_Time.Visible = true;

                    lab_Monitor_APP2_Speed.Visible = true;
                    lab_Monitor_APP2_Time.Visible = true;
                    lab_Monitor_APP2_Life.Visible = true;
                    lab_Monitor_DOC2_Speed.Visible = true;
                    lab_Monitor_DOC2_Time.Visible = true;

                    lab_Monitor_APP3_Speed.Visible = false;
                    lab_Monitor_APP3_Time.Visible = false;
                    lab_Monitor_APP3_Life.Visible = false;
                    lab_Monitor_DOC3_Speed.Visible = false;
                    lab_Monitor_DOC3_Time.Visible = false;

                    lab_Monitor_Heating2.Visible = true;
                    lab_Monitor_Heating3.Visible = false;

                    lab_Monitor_Height2.Visible = true;
                    lab_Monitor_Height3.Visible = true;
                    lab_Monitor_Height4.Visible = false;
                    break;
                case 25:
                    text = "补土+双滚涂布机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密补土+双滚涂布机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //滚子启用屏蔽checkBox按钮
                    chbApp1Choose.Visible = true;
                    chbApp2Choose.Visible = true;
                    chbApp3Choose.Visible = true;
                    //配方输入框被隐藏
                    txbControlZP1.Visible = true;
                    txbControlZP1Height.Visible = true;
                    txbControlZP2buchang.Visible = true;

                    txbControlApp2Speed.Visible = true;
                    txbControlApp2Height.Visible = true;
                    txbControlApp2buchang.Visible = true;
                    txbControlApp2Temp.Visible = true;
                    txbControlDoc2.Visible = true;

                    txbControlApp3Speed.Visible = true;
                    txbControlApp3Height.Visible = true;
                    txbControlApp3buchang.Visible = true;
                    txbControlApp3Temp.Visible = true;
                    txbControlDoc3.Visible = true;
                    //配方区域的标签不显示
                    labelZp1.Visible = true;
                    labelZp1.Text = "1#整平轮";
                    labelApp2.Visible = true;
                    labelDoc2.Visible = true;
                    labelApp3.Visible = true;
                    labelDoc3.Visible = true;
                    //参数显示区域的标签不显示
                    labelZp1Monitor.Visible = true;
                    labelZp1Monitor.Text = "1#整平轮";

                    labelApp2Monitor.Visible = true;
                    labelDoc2Monitor.Visible = true;

                    labelApp3Monitor.Visible = true;
                    labelDoc3Monitor.Visible = true;

                    labelHeating2Monitor.Visible = true;
                    labelHeating3Monitor.Visible = true;

                    labelHeight2Monitor.Visible = true;
                    labelHeight3Monitor.Visible = true;
                    labelHeight4Monitor.Visible = true;
                    //参数显示区域的数据不显示
                    lab_Monitor_ZP1_Speed.Visible = true;
                    lab_Monitor_ZP1_Time.Visible = true;

                    lab_Monitor_APP2_Speed.Visible = true;
                    lab_Monitor_APP2_Time.Visible = true;
                    lab_Monitor_APP2_Life.Visible = true;
                    lab_Monitor_DOC2_Speed.Visible = true;
                    lab_Monitor_DOC2_Time.Visible = true;

                    lab_Monitor_APP3_Speed.Visible = true;
                    lab_Monitor_APP3_Time.Visible = true;
                    lab_Monitor_APP3_Life.Visible = true;
                    lab_Monitor_DOC3_Speed.Visible = true;
                    lab_Monitor_DOC3_Time.Visible = true;

                    lab_Monitor_Heating2.Visible = true;
                    lab_Monitor_Heating3.Visible = true;

                    lab_Monitor_Height2.Visible = true;
                    lab_Monitor_Height3.Visible = true;
                    lab_Monitor_Height4.Visible = true;
                    break;
                case 26:
                    text = "正逆滚涂布机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密补土+双滚涂布机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //滚子启用屏蔽checkBox按钮
                    chbApp1Choose.Visible = true;
                    chbApp2Choose.Visible = true;
                    chbApp3Choose.Visible = false;
                    //配方输入框被隐藏
                    txbControlZP1.Visible = true;

                    txbControlZP1Height.Visible = false;
                    txbControlZP2buchang.Visible = false;

                    txbControlApp2Speed.Visible = true;
                    txbControlApp2Height.Visible = true;
                    txbControlApp2buchang.Visible = true;
                    txbControlApp2Temp.Visible = true;
                    txbControlDoc2.Visible = true;

                    txbControlApp3Speed.Visible = false;
                    txbControlApp3Height.Visible = false;
                    txbControlApp3buchang.Visible = false;
                    txbControlApp3Temp.Visible = false;
                    txbControlDoc3.Visible = false;
                    //配方区域的标签不显示
                    labelZp1.Visible = true;
                    labelZp1.Text = "逆滚轮";
                    labelApp2.Visible = true;
                    labelDoc2.Visible = true;
                    labelApp3.Visible = false;
                    labelDoc3.Visible = false;
                    //参数显示区域的标签不显示
                    labelZp1Monitor.Visible = true;
                    labelZp1Monitor.Text = "逆滚轮";

                    labelApp2Monitor.Visible = true;
                    labelDoc2Monitor.Visible = true;

                    labelApp3Monitor.Visible = false;
                    labelDoc3Monitor.Visible = false;

                    labelHeating2Monitor.Visible = true;
                    labelHeating3Monitor.Visible = false;

                    labelHeight2Monitor.Visible = true;
                    labelHeight3Monitor.Visible = true;
                    labelHeight4Monitor.Visible = false;
                    //参数显示区域的数据不显示
                    lab_Monitor_ZP1_Speed.Visible = true;
                    lab_Monitor_ZP1_Time.Visible = true;


                    lab_Monitor_APP2_Speed.Visible = true;
                    lab_Monitor_APP2_Time.Visible = true;
                    lab_Monitor_APP2_Life.Visible = true;
                    lab_Monitor_DOC2_Speed.Visible = true;
                    lab_Monitor_DOC2_Time.Visible = true;

                    lab_Monitor_APP3_Speed.Visible = false;
                    lab_Monitor_APP3_Time.Visible = false;
                    lab_Monitor_APP3_Life.Visible = false;
                    lab_Monitor_DOC3_Speed.Visible = false;
                    lab_Monitor_DOC3_Time.Visible = false;

                    lab_Monitor_Heating2.Visible = true;
                    lab_Monitor_Heating3.Visible = false;

                    lab_Monitor_Height2.Visible = true;
                    lab_Monitor_Height3.Visible = true;
                    lab_Monitor_Height4.Visible = false;
                    break;
                case 27:
                    text = "全精密补土机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\全精密补土机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    //滚子启用屏蔽checkBox按钮
                    chbApp1Choose.Visible = true;
                    chbApp2Choose.Visible = false;
                    chbApp3Choose.Visible = false;
                    //配方输入框被隐藏
                    txbControlZP1.Visible = true;
                    txbControlZP1Height.Visible = true;
                    txbControlZP2buchang.Visible = true;

                    txbControlApp2Speed.Visible = false;
                    txbControlApp2Height.Visible = false;
                    txbControlApp2buchang.Visible = false;
                    txbControlApp2Temp.Visible = false;
                    txbControlDoc2.Visible = false;

                    txbControlApp3Speed.Visible = false;
                    txbControlApp3Height.Visible = false;
                    txbControlApp3buchang.Visible = false;
                    txbControlApp3Temp.Visible = false;
                    txbControlDoc3.Visible = false;
                    //配方区域的标签不显示
                    labelZp1.Visible = true;
                    labelZp1.Text = "1#整平轮";
                    labelApp2.Visible = false;
                    labelDoc2.Visible = false;
                    labelApp3.Visible = false;
                    labelDoc3.Visible = false;
                    //参数显示区域的标签不显示
                    labelZp1Monitor.Visible = true;
                    labelZp1Monitor.Text = "1#整平轮";

                    labelApp2Monitor.Visible = false;
                    labelDoc2Monitor.Visible = false;

                    labelApp3Monitor.Visible = false;
                    labelDoc3Monitor.Visible = false;

                    labelHeating2Monitor.Visible = false;
                    labelHeating3Monitor.Visible = false;

                    labelHeight2Monitor.Visible = true;
                    labelHeight3Monitor.Visible = false;
                    labelHeight4Monitor.Visible = false;
                    //参数显示区域的数据不显示
                    lab_Monitor_ZP1_Speed.Visible = true;
                    lab_Monitor_ZP1_Time.Visible = true;

                    lab_Monitor_APP2_Speed.Visible = false;
                    lab_Monitor_APP2_Time.Visible = false;
                    lab_Monitor_APP2_Life.Visible = false;
                    lab_Monitor_DOC2_Speed.Visible = false;
                    lab_Monitor_DOC2_Time.Visible = false;

                    lab_Monitor_APP3_Speed.Visible = false;
                    lab_Monitor_APP3_Time.Visible = false;
                    lab_Monitor_APP3_Life.Visible = false;
                    lab_Monitor_DOC3_Speed.Visible = false;
                    lab_Monitor_DOC3_Time.Visible = false;

                    lab_Monitor_Heating2.Visible = false;
                    lab_Monitor_Heating3.Visible = false;

                    lab_Monitor_Height2.Visible = true;
                    lab_Monitor_Height3.Visible = false;
                    lab_Monitor_Height4.Visible = false;
                    break;
            }
            //把获取到的文本内容赋值给配方区域的GroupBox的名字文本
            gbox_RecipeSetting.Text = text + device.index + " 【" + "配方设置" + "】";
        }
        /// <summary>
        /// 刷新配方数据
        /// </summary>
        public void refreshPeifang()
        {
            //实例化涂布机设备
            butuDevice butu = (butuDevice)device;
            //三组滚涂选用状况
            if (butu.App1Checked == 0)
            {
                chbApp1Choose.Checked = true;
                chbApp1Choose.BackColor = Color.MediumSeaGreen;
                chbApp1Choose.Text = "1组滚轮启用";
            }
            else
            {
                chbApp1Choose.BackColor = Color.DodgerBlue;
                chbApp1Choose.Text = "1组滚轮停用";
            }
            //2组
            if (butu.App2Checked == 0)
            {
                chbApp2Choose.Checked = true;
                chbApp2Choose.BackColor = Color.MediumSeaGreen;
                chbApp2Choose.Text = "2组滚轮启用";
            }
            else
            {
                chbApp2Choose.BackColor = Color.DodgerBlue;
                chbApp2Choose.Text = "2组滚轮停用";
            }
            //3组
            if (butu.App3Checked == 0)
            {
                chbApp3Choose.Checked = true;
                chbApp3Choose.BackColor = Color.MediumSeaGreen;
                chbApp3Choose.Text = "3组滚轮启用";
            }
            else
            {
                chbApp3Choose.BackColor = Color.DodgerBlue;
                chbApp3Choose.Text = "3组滚轮停用";
            }


            //刷新配方编号到显示界面
            txbRecipeNO.Text = Convert.ToString(butu.bianhao);

            //把运算值以字符串的格式写入到1#涂布轮频率监视的TextBox内
            txbControlApp1Speed.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppSpeed1) / 10);

            //把运算值以字符串的格式写入到1#均布轮频率监视的TextBox内
            txbControlDoc1.Text = Convert.ToString(Convert.ToDecimal(butu.ControlDocSpeed1) / 10);
            //把运算值以字符串的格式写入到1#整平轮频率监视的TextBox内
            txbControlZP1.Text = Convert.ToString(Convert.ToDecimal(butu.ControlZhengpingSpeed1) / 10);
            //把运算值以字符串的格式写入到2#涂布轮频率监视的TextBox内
            txbControlApp2Speed.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppSpeed2) / 10);
            //把运算值以字符串的格式写入到2#均布轮频率监视的TextBox内
            txbControlDoc2.Text = Convert.ToString(Convert.ToDecimal(butu.ControlDocSpeed2) / 10);



            //把运算值以字符串的格式写入到3#涂布轮频率监视的TextBox内
            txbControlApp3Speed.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppSpeed3) / 10);
            //把运算值以字符串的格式写入到3#均布轮频率监视的TextBox内
            txbControlDoc3.Text = Convert.ToString(Convert.ToDecimal(butu.ControlDocSpeed3) / 10);
            //把运算值以字符串的格式写入到1#输送线频率监视的TextBox内
            txbControlConveyorMain.Text = Convert.ToString(Convert.ToDecimal(butu.ControlConveyorSpeed) / 10);

            //把运算值以字符串的格式写入到1#涂布轮高度监视的TextBox内
            txbControlApp1Height.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppHeight1) / 100);
            //把运算值以字符串的格式写入到2#涂布轮高度监视的TextBox内
            txbControlZP1Height.Text = Convert.ToString(Convert.ToDecimal(butu.ControlZhengpingHeight1) / 100);
            //把运算值以字符串的格式写入到2#涂布轮高度监视的TextBox内
            txbControlApp2Height.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppHeight2) / 100);
            //把运算值以字符串的格式写入到2#涂布轮高度监视的TextBox内
            txbControlApp3Height.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppHeight3) / 100);

            //把运算值以字符串的格式写入到1#涂布轮高度偏差监视的TextBox内
            txbControlApp1buchang.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppHeight11) / 100);
            //把运算值以字符串的格式写入到2#涂布轮高度偏差监视的TextBox内
            txbControlZP2buchang.Text = Convert.ToString(Convert.ToDecimal(butu.ControlZhengpingHeight11) / 100);
            //把运算值以字符串的格式写入到2#涂布轮高度偏差监视的TextBox内
            txbControlApp2buchang.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppHeight22) / 100);
            //把运算值以字符串的格式写入到2#涂布轮高度偏差监视的TextBox内
            txbControlApp3buchang.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppHeight33) / 100);


            //把运算值以字符串的格式写入到1#涂布轮温度监视的TextBox内
            txbControlApp1Temp.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppTemp1) / 10);
            txbControlApp2Temp.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppTemp2) / 10);
            txbControlApp3Temp.Text = Convert.ToString(Convert.ToDecimal(butu.ControlAppTemp3) / 10);

        }
        /// <summary>
        /// 数据监控
        /// </summary>
        public void Monitor_ReadBack()
        {
            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            butuDevice butu = (butuDevice)device;
            //把运算值以字符串的格式写入到1#涂布轮频率监视的Label内
            lab_Monitor_APP1_Speed.Text = Convert.ToDecimal(butu.MonitorAppSpeed1) / 10 + " Hz";
            lab_Monitor_DOC1_Speed.Text = Convert.ToDecimal(butu.MonitorDocSpeed1) / 10 + " Hz";
            lab_Monitor_ZP1_Speed.Text = Convert.ToDecimal(butu.MonitorZhengpingSpeed1) / 10 + " Hz";
            lab_Monitor_APP2_Speed.Text = Convert.ToDecimal(butu.MonitorAppSpeed2) / 10 + " Hz";
            lab_Monitor_DOC2_Speed.Text = Convert.ToDecimal(butu.MonitorDocSpeed2) / 10 + " Hz";
            lab_Monitor_APP3_Speed.Text = Convert.ToDecimal(butu.MonitorAppSpeed3) / 10 + " Hz";
            lab_Monitor_DOC3_Speed.Text = Convert.ToDecimal(butu.MonitorDocSpeed3) / 10 + " Hz";

            //把运算值以字符串的格式写入到1#输送线频率监视的Label内
            lab_Monitor_Conveyor1_Speed.Text = Convert.ToDecimal(butu.MonitorConveyorSpeed1) / 10 + " Hz";
            lab_Monitor_Conveyor2_Speed.Text = Convert.ToDecimal(butu.MonitorConveyorSpeed2) / 10 + " Hz";

            //把运算值以字符串的格式写入到涂布轮高度监视的Label内
            lab_Monitor_Height1.Text = Convert.ToDecimal(butu.MonitorAppHeight1) / 100 + " mm";
          
            lab_Monitor_Height2.Text = Convert.ToDecimal(butu.MonitorZhengpingHeight1) / 100 + " mm";
            lab_Monitor_Height3.Text = Convert.ToDecimal(butu.MonitorAppHeight2) / 100 + " mm";
            lab_Monitor_Height4.Text = Convert.ToDecimal(butu.MonitorAppHeight3) / 100 + " mm";
            //把运算值以字符串的格式写入到1#涂布轮温度监视的Label内
            lab_Monitor_Heating1.Text = Convert.ToDecimal(butu.MonitorAppTemp1) / 10 + " ℃";
            lab_Monitor_Heating2.Text = Convert.ToDecimal(butu.MonitorAppTemp2) / 10 + " ℃";
            lab_Monitor_Heating3.Text = Convert.ToDecimal(butu.MonitorAppTemp3) / 10 + " ℃";

            //把运算值以字符串的格式写入到1#涂布轮运行时间的Label内
            lab_Monitor_APP1_Time.Text = Convert.ToDecimal(butu.MonitorAppRunTime1) + " H";
            lab_Monitor_DOC1_Time.Text = Convert.ToDecimal(butu.MonitorDocRunTime1) + " H";
            lab_Monitor_ZP1_Time.Text = Convert.ToDecimal(butu.MonitorZhengpingRunTime1) + " H";
            lab_Monitor_APP2_Time.Text = Convert.ToDecimal(butu.MonitorAppRunTime2) + " H";
            lab_Monitor_DOC2_Time.Text = Convert.ToDecimal(butu.MonitorDocRunTime2) + " H";
            lab_Monitor_APP3_Time.Text = Convert.ToDecimal(butu.MonitorAppRunTime3) + " H";
            lab_Monitor_DOC3_Time.Text = Convert.ToDecimal(butu.MonitorDocRunTime3) + " H";

            //把运算值以字符串的格式写入到1#输送线运行时间的Label内
            lab_Monitor_Conveyor1_Time.Text = Convert.ToDecimal(butu.MonitorConveyorRunTime1) + " H";
            lab_Monitor_Conveyor2_Time.Text = Convert.ToDecimal(butu.MonitorConveyorRunTime2) + " H";

            //把运算值以字符串的格式写入到1#涂布轮剩余运行时间的Label内
            lab_Monitor_APP1_Life.Text = Convert.ToDecimal(butu.MonitorAppLeftTime1) + " H";
            lab_Monitor_APP2_Life.Text = Convert.ToDecimal(butu.MonitorAppLeftTime2) + " H";
            lab_Monitor_APP3_Life.Text = Convert.ToDecimal(butu.MonitorAppLeftTime3) + " H";
            //判断寿命到期
            string status = device.BaseProtocol.ConnectState.ToString();
            if (status == "Connected")
            {
                if (butu.MonitorAppLeftTime1 == 0)
                {
                    MessageBox.Show("1#涂布轮使用寿命到期，请研磨或更换配件！");
                    parent.showLog("1#涂布轮使用寿命到期，请研磨或更换配件！");
                }
                if (butu.MonitorAppLeftTime2 == 0)
                {
                    MessageBox.Show("2#涂布轮使用寿命到期，请研磨或更换配件！");
                    parent.showLog("2#涂布轮使用寿命到期，请研磨或更换配件！");
                }

                //if (butu.MonitorAppLeftTime3 == 0)
                //{
                //    MessageBox.Show("3#涂布轮使用寿命到期，请研磨或更换配件！");
                //    parent.showLog("3#涂布轮使用寿命到期，请研磨或更换配件！");
                //}
            }
        }
        #region
        //DB区的Word内容监控-----输送线报警监控-------------------------------------------------------------------------OK
        static String alarm_App1_Msg1 = "1#涂布轮变频器故障，0C1（停机时过电流）";
        static String alarm_App1_Msg2 = "1#涂布轮变频器故障，0C2（加速时过电流）";
        static String alarm_App1_Msg3 = "1#涂布轮变频器故障，0C0（减速时过电流）";
        static String alarm_App1_Msg4 = "1#涂布轮变频器故障，0V1（停机时过电压）";
        static String alarm_App1_Msg5 = "1#涂布轮变频器故障，0V2（加速时过电压）";
        static String alarm_App1_Msg6 = "1#涂布轮变频器故障，0V3（定速时过电压）";
        static String alarm_App1_Msg7 = "1#涂布轮变频器故障，0V0（减速时过电压）";
        static String alarm_App1_Msg8 = "1#涂布轮变频器故障，THT（IGBT模块过热）";
        static String alarm_App1_Msg9 = "1#涂布轮变频器故障，THN（电机过热）";
        static String alarm_App1_Msg10 = "1#涂布轮变频器故障，NTC(模组过热)";
        static String alarm_App1_Msg11 = "1#涂布轮变频器故障，EEP(内存异常)";
        static String alarm_App1_Msg12 = "1#涂布轮变频器故障，PIDE（PID异常）";
        static String alarm_App1_Msg13 = "1#涂布轮变频器故障，OLS(失速防止功能)";
        static String alarm_App1_Msg14 = "1#涂布轮变频器故障，OL2 (过转矩异常)";
        static String alarm_App1_Msg15 = "1#涂布轮变频器故障，OPT (通讯异常)";
        static String alarm_App1_Msg16 = "1#涂布轮变频器故障，SCP (短路过电流)";
        static String alarm_App1_Msg17 = "1#涂布轮变频器故障，CPU (CPU异常)";


        static String alarm_Doc1_Msg1 = "1#均布轮变频器故障，0C1（停机时过电流）";
        static String alarm_Doc1_Msg2 = "1#均布轮变频器故障，0C2（加速时过电流）";
        static String alarm_Doc1_Msg3 = "1#均布轮变频器故障，0C0（减速时过电流）";
        static String alarm_Doc1_Msg4 = "1#均布轮变频器故障，0V1（停机时过电压）";
        static String alarm_Doc1_Msg5 = "1#均布轮变频器故障，0V2（加速时过电压）";
        static String alarm_Doc1_Msg6 = "1#均布轮变频器故障，0V3（定速时过电压）";
        static String alarm_Doc1_Msg7 = "1#均涂布轮变频器故障，0V0（减速时过电压）";
        static String alarm_Doc1_Msg8 = "1#均布轮变频器故障，THT（IGBT模块过热）";
        static String alarm_Doc1_Msg9 = "1#均布轮变频器故障，THN（电机过热）";
        static String alarm_Doc1_Msg10 = "1#均布轮变频器故障，NTC(模组过热)";
        static String alarm_Doc1_Msg11 = "1#均布轮变频器故障，EEP(内存异常)";
        static String alarm_Doc1_Msg12 = "1#均布轮变频器故障，PIDE（PID异常）";
        static String alarm_Doc1_Msg13 = "1#均布轮变频器故障，OLS(失速防止功能)";
        static String alarm_Doc1_Msg14 = "1#均涂布轮变频器故障，OL2 (过转矩异常)";
        static String alarm_Doc1_Msg15 = "1#均布轮变频器故障，OPT (通讯异常)";
        static String alarm_Doc1_Msg16 = "1#均布轮变频器故障，SCP (短路过电流)";
        static String alarm_Doc1_Msg17 = "1#均布轮变频器故障，CPU (CPU异常)";



        static String alarm_App2_Msg1 = "2#涂布轮变频器故障，0C1（停机时过电流）";
        static String alarm_App2_Msg2 = "2#涂布轮变频器故障，0C2（加速时过电流）";
        static String alarm_App2_Msg3 = "2#涂布轮变频器故障，0C0（减速时过电流）";
        static String alarm_App2_Msg4 = "2#涂布轮变频器故障，0V1（停机时过电压）";
        static String alarm_App2_Msg5 = "2#涂布轮变频器故障，0V2（加速时过电压）";
        static String alarm_App2_Msg6 = "2#涂布轮变频器故障，0V3（定速时过电压）";
        static String alarm_App2_Msg7 = "2#涂布轮变频器故障，0V0（减速时过电压）";
        static String alarm_App2_Msg8 = "2#涂布轮变频器故障，THT（IGBT模块过热）";
        static String alarm_App2_Msg9 = "2#涂布轮变频器故障，THN（电机过热）";
        static String alarm_App2_Msg10 = "2#涂布轮变频器故障，NTC(模组过热)";
        static String alarm_App2_Msg11 = "2#涂布轮变频器故障，EEP(内存异常)";
        static String alarm_App2_Msg12 = "2#涂布轮变频器故障，PIDE（PID异常）";
        static String alarm_App2_Msg13 = "2#涂布轮变频器故障，OLS(失速防止功能)";
        static String alarm_App2_Msg14 = "2#涂布轮变频器故障，OL2 (过转矩异常)";
        static String alarm_App2_Msg15 = "2#涂布轮变频器故障，OPT (通讯异常)";
        static String alarm_App2_Msg16 = "2#涂布轮变频器故障，SCP (短路过电流)";
        static String alarm_App2_Msg17 = "2#涂布轮变频器故障，CPU (CPU异常)";


        static String alarm_ZP1_Msg1 = "2#涂布轮变频器故障，0C1（停机时过电流）";
        static String alarm_ZP1_Msg2 = "2#涂布轮变频器故障，0C2（加速时过电流）";
        static String alarm_ZP1_Msg3 = "2#涂布轮变频器故障，0C0（减速时过电流）";
        static String alarm_ZP1_Msg4 = "2#涂布轮变频器故障，0V1（停机时过电压）";
        static String alarm_ZP1_Msg5 = "2#涂布轮变频器故障，0V2（加速时过电压）";
        static String alarm_ZP1_Msg6 = "2#涂布轮变频器故障，0V3（定速时过电压）";
        static String alarm_ZP1_Msg7 = "2#涂布轮变频器故障，0V0（减速时过电压）";
        static String alarm_ZP1_Msg8 = "2#涂布轮变频器故障，THT（IGBT模块过热）";
        static String alarm_ZP1_Msg9 = "2#涂布轮变频器故障，THN（电机过热）";
        static String alarm_ZP1_Msg10 = "2#涂布轮变频器故障，NTC(模组过热)";
        static String alarm_ZP1_Msg11 = "2#涂布轮变频器故障，EEP(内存异常)";
        static String alarm_ZP1_Msg12 = "2#涂布轮变频器故障，PIDE（PID异常）";
        static String alarm_ZP1_Msg13 = "2#涂布轮变频器故障，OLS(失速防止功能)";
        static String alarm_ZP1_Msg14 = "2#涂布轮变频器故障，OL2 (过转矩异常)";
        static String alarm_ZP1_Msg15 = "2#涂布轮变频器故障，OPT (通讯异常)";
        static String alarm_ZP1_Msg16 = "2#涂布轮变频器故障，SCP (短路过电流)";
        static String alarm_ZP1_Msg17 = "2#涂布轮变频器故障，CPU (CPU异常)";


        static String alarm_Doc2_Msg1 = "2#均布轮变频器故障，0C1（停机时过电流）";
        static String alarm_Doc2_Msg2 = "2#均布轮变频器故障，0C2（加速时过电流）";
        static String alarm_Doc2_Msg3 = "2#均布轮变频器故障，0C0（减速时过电流）";
        static String alarm_Doc2_Msg4 = "2#均布轮变频器故障，0V1（停机时过电压）";
        static String alarm_Doc2_Msg5 = "2#均布轮变频器故障，0V2（加速时过电压）";
        static String alarm_Doc2_Msg6 = "2#均布轮变频器故障，0V3（定速时过电压）";
        static String alarm_Doc2_Msg7 = "2#均涂布轮变频器故障，0V0（减速时过电压）";
        static String alarm_Doc2_Msg8 = "2#均布轮变频器故障，THT（IGBT模块过热）";
        static String alarm_Doc2_Msg9 = "2#均布轮变频器故障，THN（电机过热）";
        static String alarm_Doc2_Msg10 = "2#均布轮变频器故障，NTC(模组过热)";
        static String alarm_Doc2_Msg11 = "2#均布轮变频器故障，EEP(内存异常)";
        static String alarm_Doc2_Msg12 = "2#均布轮变频器故障，PIDE（PID异常）";
        static String alarm_Doc2_Msg13 = "2#均布轮变频器故障，OLS(失速防止功能)";
        static String alarm_Doc2_Msg14 = "2#均涂布轮变频器故障，OL2 (过转矩异常)";
        static String alarm_Doc2_Msg15 = "2#均布轮变频器故障，OPT (通讯异常)";
        static String alarm_Doc2_Msg16 = "2#均布轮变频器故障，SCP (短路过电流)";
        static String alarm_Doc2_Msg17 = "2#均布轮变频器故障，CPU (CPU异常)";


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

        static String alarm_Conveyor2_Msg1 = "#输送带变频器故障，0C1（停机时过电流）";
        static String alarm_Conveyor2_Msg2 = "2#输送带变频器故障，0C2（加速时过电流）";
        static String alarm_Conveyor2_Msg3 = "2#输送带变频器故障，0C0（减速时过电流）";
        static String alarm_Conveyor2_Msg4 = "2#输送带变频器故障，0V1（停机时过电压）";
        static String alarm_Conveyor2_Msg5 = "2#输送带变频器故障，0V2（加速时过电压）";
        static String alarm_Conveyor2_Msg6 = "2#输送带变频器故障，0V3（定速时过电压）";
        static String alarm_Conveyor2_Msg7 = "2#输送带变频器故障，0V0（减速时过电压）";
        static String alarm_Conveyor2_Msg8 = "2#输送带变频器故障，THT（IGBT模块过热）";
        static String alarm_Conveyor2_Msg9 = "2#输送带变频器故障，THN（电机过热）";
        static String alarm_Conveyor2_Msg10 = "2#输送带变频器故障，NTC(模组过热)";
        static String alarm_Conveyor2_Msg11 = "2#输送带变频器故障，EEP(内存异常)";
        static String alarm_Conveyor2_Msg12 = "2#输送带变频器故障，PIDE（PID异常）";
        static String alarm_Conveyor2_Msg13 = "2#输送带变频器故障，OLS(失速防止功能)";
        static String alarm_Conveyor2_Msg14 = "2#输送带变频器故障，OL2 (过转矩异常)";
        static String alarm_Conveyor2_Msg15 = "2#输送带变频器故障，OPT (通讯异常)";
        static String alarm_Conveyor2_Msg16 = "2#输送带变频器故障，SCP (短路过电流)";
        static String alarm_Conveyor2_Msg17 = "2#输送带变频器故障，CPU (CPU异常)";
        #endregion
        /// <summary>
        /// 变频器报警监控
        /// </summary>
        public void DB_Word_Alarm_Monitor()
        {
            butuDevice butu = (butuDevice)device;
            /*报警代码*/
            UInt32[] alarm_value = new UInt32[] { 16, 17, 19, 32, 33, 34, 35, 48, 49, 50, 64, 66, 97, 98, 160, 179, 192 };
            //Label[] label_Monitor = new Label[] { lab_Conveyor1, lab_Conveyor2, lab_App1, lab_Doc1, lab_App2, lab_Doc2 };

            string[] App1_Msg = new string[] {alarm_App1_Msg1,alarm_App1_Msg2,alarm_App1_Msg3, alarm_App1_Msg4, alarm_App1_Msg5, alarm_App1_Msg6, alarm_App1_Msg7, alarm_App1_Msg8,
                alarm_App1_Msg9, alarm_App1_Msg10, alarm_App1_Msg11,alarm_App1_Msg12,alarm_App1_Msg13, alarm_App1_Msg14, alarm_App1_Msg15, alarm_App1_Msg16, alarm_App1_Msg17 };

            string[] Doc1_Msg = new string[] {alarm_Doc1_Msg1,alarm_Doc1_Msg2,alarm_Doc1_Msg3, alarm_Doc1_Msg4, alarm_Doc1_Msg5, alarm_Doc1_Msg6, alarm_Doc1_Msg7, alarm_Doc1_Msg8,
                alarm_Doc1_Msg9, alarm_Doc1_Msg10, alarm_Doc1_Msg11,alarm_Doc1_Msg12,alarm_Doc1_Msg13, alarm_Doc1_Msg14, alarm_Doc1_Msg15, alarm_Doc1_Msg16, alarm_Doc1_Msg17 };

            string[] ZP1_Msg = new string[] {alarm_ZP1_Msg1,alarm_ZP1_Msg2,alarm_ZP1_Msg3, alarm_ZP1_Msg4, alarm_ZP1_Msg5, alarm_ZP1_Msg6, alarm_ZP1_Msg7, alarm_ZP1_Msg8,
                alarm_ZP1_Msg9, alarm_ZP1_Msg10, alarm_ZP1_Msg11,alarm_ZP1_Msg12,alarm_ZP1_Msg13, alarm_ZP1_Msg14, alarm_ZP1_Msg15, alarm_ZP1_Msg16, alarm_ZP1_Msg17 };

            string[] App2_Msg = new string[] {alarm_App2_Msg1,alarm_App2_Msg2,alarm_App2_Msg3, alarm_App2_Msg4, alarm_App2_Msg5, alarm_App2_Msg6, alarm_App2_Msg7, alarm_App2_Msg8,
                alarm_App2_Msg9, alarm_App2_Msg10, alarm_App2_Msg11,alarm_App2_Msg12,alarm_App2_Msg13, alarm_App2_Msg14, alarm_App2_Msg15, alarm_App2_Msg16, alarm_App2_Msg17 };

            string[] Doc2_Msg = new string[] { alarm_Doc2_Msg1,alarm_Doc2_Msg2,alarm_Doc2_Msg3, alarm_Doc2_Msg4, alarm_Doc2_Msg5, alarm_Doc2_Msg6, alarm_Doc2_Msg7, alarm_Doc2_Msg8,
                alarm_Doc2_Msg9, alarm_Doc2_Msg10, alarm_Doc2_Msg11,alarm_Doc2_Msg12,alarm_Doc2_Msg13, alarm_Doc2_Msg14, alarm_Doc2_Msg15, alarm_Doc2_Msg16, alarm_Doc2_Msg17 };

            string[] Conveyor1_Msg = new string[] {alarm_Conveyor1_Msg1,alarm_Conveyor1_Msg2,alarm_Conveyor1_Msg3, alarm_Conveyor1_Msg4, alarm_Conveyor1_Msg5, alarm_Conveyor1_Msg6, alarm_Conveyor1_Msg7, alarm_Conveyor1_Msg8,
                alarm_Conveyor1_Msg9, alarm_Conveyor1_Msg10, alarm_Conveyor1_Msg11,alarm_Conveyor1_Msg12,alarm_Conveyor1_Msg13, alarm_Conveyor1_Msg14, alarm_Conveyor1_Msg15, alarm_Conveyor1_Msg16, alarm_Conveyor1_Msg17 };

            string[] Conveyor2_Msg = new string[] {alarm_Conveyor2_Msg1,alarm_Conveyor2_Msg2,alarm_Conveyor2_Msg3, alarm_Conveyor2_Msg4, alarm_Conveyor2_Msg5, alarm_Conveyor2_Msg6, alarm_Conveyor2_Msg7, alarm_Conveyor2_Msg8,
                alarm_Conveyor2_Msg9, alarm_Conveyor2_Msg10, alarm_Conveyor2_Msg11,alarm_Conveyor2_Msg12,alarm_Conveyor2_Msg13, alarm_Conveyor2_Msg14, alarm_Conveyor2_Msg15, alarm_Conveyor2_Msg16, alarm_Conveyor2_Msg17};

            //涂布轮1报警代码
            for (int i = 0; i < alarm_value.Length; i++)
            {
                //Console.WriteLine("涂布轮1");
                if (alarm_value[i] == butu.App1AlarmCode)                                               //==则表示报警
                {
                    if (!lbMsg_Dialog.Items.Contains(App1_Msg[i]))             //判定当前没有显示，则插入一行显示
                    {
                        lbMsg_Dialog.Items.Insert(0, App1_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lbMsg_Dialog.Items.Remove(App1_Msg[i]);
                }
            }
            //均布轮1报警代码

            for (int i = 0; i < alarm_value.Length; i++)
            {
                //Console.WriteLine("均布轮1");
                if (alarm_value[i] == butu.Doc1AlarmCode)                                               //==则表示报警
                {
                    if (!lbMsg_Dialog.Items.Contains(Doc1_Msg[i]))             //判定当前没有显示，则插入一行显示
                    {
                        lbMsg_Dialog.Items.Insert(0, Doc1_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lbMsg_Dialog.Items.Remove(Doc1_Msg[i]);
                }
            }

            //整平轮1报警代码

            for (int i = 0; i < alarm_value.Length; i++)
            {
                if (alarm_value[i] == butu.ZhengpingAlarmCode)                                               //==则表示报警
                {
                    if (!lbMsg_Dialog.Items.Contains(ZP1_Msg[i]))             //判定当前没有显示，则插入一行显示
                    {
                        lbMsg_Dialog.Items.Insert(0, ZP1_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lbMsg_Dialog.Items.Remove(ZP1_Msg[i]);
                }
            }
            //涂布轮2报警代码

            for (int i = 0; i < alarm_value.Length; i++)
            {
                if (alarm_value[i] == butu.App2AlarmCode)                                               //==则表示报警
                {
                    if (!lbMsg_Dialog.Items.Contains(App2_Msg[i]))             //判定当前没有显示，则插入一行显示
                    {
                        lbMsg_Dialog.Items.Insert(0, App2_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lbMsg_Dialog.Items.Remove(App2_Msg[i]);
                }
            }
            //均布轮2报警代码

            for (int i = 0; i < alarm_value.Length; i++)
            {
                if (alarm_value[i] == butu.Doc2AlarmCode)                                               //==则表示报警
                {
                    if (!lbMsg_Dialog.Items.Contains(Doc2_Msg[i]))             //判定当前没有显示，则插入一行显示
                    {
                        lbMsg_Dialog.Items.Insert(0, Doc2_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lbMsg_Dialog.Items.Remove(Doc2_Msg[i]);
                }
            }
            //输送线1报警代码

            for (int i = 0; i < alarm_value.Length; i++)
            {
                if (alarm_value[i] == butu.Conveyor1AlarmCode)                                               //==则表示报警
                {
                    if (!lbMsg_Dialog.Items.Contains(Conveyor1_Msg[i]))             //判定当前没有显示，则插入一行显示
                    {
                        lbMsg_Dialog.Items.Insert(0, Conveyor1_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lbMsg_Dialog.Items.Remove(Conveyor1_Msg[i]);
                }
            }
            //输送线2报警代码

            for (int i = 0; i < alarm_value.Length; i++)
            {
                if (alarm_value[i] == butu.Conveyor2AlarmCode)                                               //==则表示报警
                {
                    if (!lbMsg_Dialog.Items.Contains(Conveyor2_Msg[i]))             //判定当前没有显示，则插入一行显示
                    {
                        lbMsg_Dialog.Items.Insert(0, Conveyor2_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lbMsg_Dialog.Items.Remove(Conveyor2_Msg[i]);
                }
            }
        }
        /// <summary>
        /// 配方操作按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Recipe_Read_MouseDown(object sender, MouseEventArgs e)
        {
            btnMouseDown(sender);//调用判断方法 
        }
        /// <summary>
        /// 对3个按钮进行判断，判断哪一个按钮被按下
        /// </summary>
        /// <param name="sender"></param>
        public void btnMouseDown(object sender)
        {
            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            var rsno = false;
            switch (button.Name)
            {
                case "btn_Recipe_Save":
                    rsno = device.BaseProtocol.WriteReg("DB99.DBB63", 1);
                    if (rsno == true)
                    {
                        btn_Recipe_Save.BackColor = Color.MediumSeaGreen;
                        parent.showLog(device.typeName + device.index + "配方保存操作执行成功");
                        //点击配方保存时执行的方法
                        btn_Recipe_Save.Focus();
                        Btn_Recipe_Save_GotFocus1();
                    }
                    else
                    {
                        MessageBox.Show("配方保存操作执行失败");
                        parent.showLog(device.typeName + device.index + "配方保存操作执行失败");
                    }
                    break;

                case "btn_Recipe_Read":
                    rsno = device.BaseProtocol.WriteReg("DB99.DBB63", 2);
                    if (rsno == true)
                    {
                        btn_Recipe_Read.Focus();
                        Btn_Recipe_Read_GotFocus();
                        btn_Recipe_Read.BackColor = Color.MediumSeaGreen;
                        parent.showLog(device.typeName + device.index + "配方读取操作执行成功");
                    }
                    else
                    {
                        MessageBox.Show("配方读取操作执行失败");
                        parent.showLog(device.typeName + device.index + "配方读取操作执行失败");
                    }
                    break;

                case "btn_Recipe_OK":
                    rsno = device.BaseProtocol.WriteReg("DB99.DBB63", 4);
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
            //按下按钮后自动开始计时
            TimerCloseRead.Enabled = true;
        }
        /// <summary>
        /// 点击配方保存获取到焦点时执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Recipe_Save_GotFocus1()
        {
            //配方参数写入
            var res = device.BaseProtocol.WriteReg("DB99.DBW0",
                Convert.ToInt16(Convert.ToDecimal(txbControlApp1Speed.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlDoc1.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlZP1.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp2Speed.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlDoc2.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlConveyorMain.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp3Speed.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlDoc3.Text.ToString()) * 10),

                Convert.ToInt16(Convert.ToDecimal(txbControlApp1Height.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txbControlZP1Height.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp2Height.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp3Height.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp1buchang.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txbControlZP2buchang.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp2buchang.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp3buchang.Text.ToString()) * 100),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp1Temp.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp2Temp.Text.ToString()) * 10),
                Convert.ToInt16(Convert.ToDecimal(txbControlApp3Temp.Text.ToString()) * 10));

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
        /// 按钮按下后延时断开，延时时间1秒
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCloseRead_Tick(object sender, EventArgs e)
        {
            btn_Recipe_Read.BackColor = Color.DodgerBlue;
            btn_Recipe_Save.BackColor = Color.DodgerBlue;
            btn_Recipe_OK.BackColor = Color.DodgerBlue;
            //配方读取后要刷新数据到界面
            refreshPeifang();
            TimerCloseRead.Enabled = false;
        }
        /// <summary>
        /// 当读取配方按钮获取到焦点的时候执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Recipe_Read_GotFocus()
        {
            //当输入框值发生变化时自动执行配方编号写入
            RecipeNOWriteIn();
            //调用配方编号改变时的操作方法
            RecipeNO_Input();
        }
        /// <summary>
        /// 配方编号写入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeNOWriteIn()
        {
            //配方编号写入
            var res1 = device.BaseProtocol.WriteReg("DB99.DBW52", Convert.ToInt16(txbRecipeNO.Text.ToString()));
            if (res1 == true)
            {
                Console.WriteLine("配方编号写入成功");
            }
            else
            {
                MessageBox.Show("配方编号写入失败");
            }
        }
        /// <summary>
        /// 从本地ini文件读取物料编码和配方编号
        /// </summary>
        public void RecipeNO_Input()
        {
            Int32[] value = new Int32[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };
            string[] way = new string[] { @"\Default-product1.ini" , @"\Default-product2.ini" , @"\Default-product3.ini", @"\Default-product4.ini", @"\Default-product5.ini", @"\Default-product6.ini",
                                             @"\Default-product7.ini" , @"\Default-product8.ini" , @"\Default-product9.ini" , @"\Default-product10.ini",
                @"\Default-product11.ini" , @"\Default-product12.ini" , @"\Default-product13.ini", @"\Default-product14.ini", @"\Default-product15.ini", @"\Default-product16.ini",
                                             @"\Default-product17.ini" , @"\Default-product18.ini" , @"\Default-product19.ini" , @"\Default-product20.ini" };

            //如果输入为空时自动返回之前的值
            if (txbRecipeNO.Text.Trim() == "")
            {
                //实例化涂布机设备
                butuDevice butu = (butuDevice)device;
                txbRecipeNO.Text = Convert.ToString(butu.bianhao);
                MessageBox.Show("输入无效，配方区间在1-20之间，请输入适当的配方编号");
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
                            lab_Prt_NO.Text = System.IO.File.ReadAllText(thispath);                         //打开一个文本文件，读取文件的所有行，然后关闭该文件
                        }
                        catch { }
                    }
                }
            }
        }
        /// <summary>
        /// 界面布局显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A1全精密滚涂机_Resize(object sender, EventArgs e)
        {
            /*
             容器1的分隔条显示距离=容器1的宽度/2
             */
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

        /// <summary>
        /// 三组滚轮选用状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppChooseStatus(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)sender;

            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            switch (checkbox.Name)
            {
                case "chbApp1Choose":
                    if (chbApp1Choose.Checked == true)
                    {
                        var rsno = device.BaseProtocol.WriteReg("DB99.DBW38", 0);
                        if (rsno == true)
                        {
                            chbApp1Choose.BackColor = Color.MediumSeaGreen;
                            chbApp1Choose.Text = "1组滚轮启用";
                            parent.showLog(device.typeName + device.index + "1#滚轮功能启用成功");
                        }
                        else
                        {
                            MessageBox.Show("1#滚轮功能启用执行失败");
                            parent.showLog(device.typeName + device.index + "1#滚轮功能启用失败");
                        }
                    }
                    else
                    {
                        var rsno = device.BaseProtocol.WriteReg("DB99.DBW38", 1);
                        if (rsno == true)
                        {
                            chbApp1Choose.BackColor = Color.DodgerBlue;
                            chbApp1Choose.Text = "1组滚轮停用";
                            parent.showLog(device.typeName + device.index + "1#滚轮功能停用成功");
                        }
                        else
                        {
                            MessageBox.Show("1#滚轮功能停用执行失败");
                            parent.showLog(device.typeName + device.index + "1#滚轮功能停用失败");
                        }
                    }
                    break;
                case "chbApp2Choose":
                    if (chbApp2Choose.Checked == true)
                    {
                        var rsno = device.BaseProtocol.WriteReg("DB99.DBW40", 0);
                        if (rsno == true)
                        {
                            chbApp2Choose.BackColor = Color.MediumSeaGreen;
                            chbApp2Choose.Text = "2组滚轮启用";
                            parent.showLog(device.typeName + device.index + "2#滚轮功能启用成功");
                        }
                        else
                        {
                            MessageBox.Show("2#滚轮功能启用执行失败");
                            parent.showLog(device.typeName + device.index + "2#滚轮功能启用失败");
                        }
                    }
                    else
                    {
                        var rsno = device.BaseProtocol.WriteReg("DB99.DBW40", 1);
                        if (rsno == true)
                        {
                            chbApp2Choose.BackColor = Color.DodgerBlue;
                            chbApp2Choose.Text = "2组滚轮停用";
                            parent.showLog(device.typeName + device.index + "2#滚轮功能停用成功");
                        }
                        else
                        {
                            MessageBox.Show("2#滚轮功能停用执行失败");
                            parent.showLog(device.typeName + device.index + "2#滚轮功能停用失败");
                        }
                    }
                    break;
                case "chbApp3Choose":
                    if (chbApp3Choose.Checked == true)
                    {
                        var rsno = device.BaseProtocol.WriteReg("DB99.DBW42", 0);
                        if (rsno == true)
                        {
                            chbApp3Choose.BackColor = Color.MediumSeaGreen;
                            chbApp3Choose.Text = "3组滚轮启用";
                            parent.showLog(device.typeName + device.index + "3#滚轮功能启用成功");
                        }
                        else
                        {
                            MessageBox.Show("3#滚轮功能启用执行失败");
                            parent.showLog(device.typeName + device.index + "3#滚轮功能启用失败");
                        }
                    }
                    else
                    {
                        var rsno = device.BaseProtocol.WriteReg("DB99.DBW42", 1);
                        if (rsno == true)
                        {
                            chbApp3Choose.BackColor = Color.DodgerBlue;
                            chbApp3Choose.Text = "3组滚轮停用";
                            parent.showLog(device.typeName + device.index + "3#滚轮功能停用成功");
                        }
                        else
                        {
                            MessageBox.Show("3#滚轮功能停用执行失败");
                            parent.showLog(device.typeName + device.index + "3#滚轮功能停用失败");
                        }
                    }
                    break;
            }
        }
    }
}

