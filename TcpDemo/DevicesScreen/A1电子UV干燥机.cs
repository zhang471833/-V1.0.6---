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
    public partial class A1电子UV干燥机 : UserControl
    {
        //定义变量，变量类型为Device
        Device device;
        //定义公共变量，类型为winform窗体，名称：parentForm
        public A0开机画面 parentForm;
        public A1电子UV干燥机()
        {
            InitializeComponent();
            //调用数组赋值的方法
            initData();
        }
        //窗体load时执行的方法
        private void A1三灯UV干燥机_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            //窗体加载时启动本窗体刷新程序0.5S一次
            Windows_Recyle.Enabled = true;
        }
        //窗体循环执行方法
        private void Windows_Recyle_Tick(object sender, EventArgs e)
        {
            //循环显示参数监控
            Monitor_ReadBack();
            //刷新显示输送线报警信息
            AlarmMessage();
            //刷新显示UV1-UV8报警信息
            UV_byte_Alarm_Monitor();
            labStatus.Text = "通讯状态: " + device.BaseProtocol.ConnectState +
                " 刷新周期: " + Convert.ToString(device.BaseProtocol.ScanPeriod + 500) + " ms" +
                "设备运行状态: " + device.BaseProtocol.RunState;
            labStatus.BackColor = Color.LightGreen;
        }
        //定义textbox输入框数组（用于输入参数）
        NumericUpDown[] txb_Controls;
        //定义配方标签labels数组
        Label[] peifangLabels;
        //定义显示标签labels数组
        Label[] biaoqianLabels;
        //定义运行状态标签labels
        Label[] yunxingzhuangtaiLabels;
        //定义数据显示标签Labels数组（参数监控）
        Label[][] dataLabels;
        //设备运行状态监控数组
        Label[] machineStatus;

        /// <summary>
        /// 配方设置区域和参数监视区域的label和文本框是否显示的参数初始化方法
        /// </summary>
        public void initData()
        {
            //给输入参数的文本框数组赋值
            txb_Controls = new NumericUpDown[] { txbControlUV1, txbControlUV2, txbControlUV3, txbControlUV4, txbControlUV5, txbControlUV6, txbControlUV7, txbControlUV8 };
            //给配方显示的标签数组赋值
            peifangLabels = new Label[] { label_UV1, label_UV2, label_UV3, label_UV4, label_UV5, label_UV6, label_UV7, label_UV8 };
            //参数监控区域的标签数组赋值
            biaoqianLabels = new Label[] { label_UV11, label_UV22, label_UV33, label_UV44, label_UV55, label_UV66, label_UV77, label_UV88 };
            //给参数监控区域的数值显示二维数组赋值（用于监控运行状态）
            dataLabels = new Label[][] {
            new Label[]{lab_Monitor_UV1,lab_Monitor_UV1Hour,lab_Monitor_UV1Hour1},
            new Label[]{lab_Monitor_UV2,lab_Monitor_UV2Hour,lab_Monitor_UV2Hour1},
            new Label[]{lab_Monitor_UV3,lab_Monitor_UV3Hour,lab_Monitor_UV3Hour1},
            new Label[]{lab_Monitor_UV4,lab_Monitor_UV4Hour,lab_Monitor_UV4Hour1},
            new Label[]{lab_Monitor_UV5,lab_Monitor_UV5Hour,lab_Monitor_UV5Hour1},
            new Label[]{lab_Monitor_UV6,lab_Monitor_UV6Hour,lab_Monitor_UV6Hour1},
            new Label[]{lab_Monitor_UV7,lab_Monitor_UV7Hour,lab_Monitor_UV7Hour1},
            new Label[]{lab_Monitor_UV8,lab_Monitor_UV8Hour,lab_Monitor_UV8Hour1}
            };
        }
        //设置当前设备到父类Device内
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
            //根据类型设置可见控件个数
            for (int i = 0; i < txb_Controls.Length; i++)
            {
                //如果I小于子类型（单灯、双灯、三灯、四灯、五灯、六灯、七灯、八灯）
                if (i < childType)
                {
                    //控制文本框的for循环判断是否显示
                    txb_Controls[i].Visible = true;
                    //配方标签的for循环判断是否显示
                    peifangLabels[i].Visible = true;
                    //显示标签的for循环判断是否显示
                    biaoqianLabels[i].Visible = true;
                    //运行状态的for循环判断是否显示
                    //yunxingzhuangtaiLabels[i].Visible = true;
                    //遍历运行时间、开度、剩余时间等参数标签二维数组，
                    foreach (Label label in dataLabels[i])
                    {
                        label.Visible = true;
                    }
                }
                else
                {
                    txb_Controls[i].Visible = false;
                    peifangLabels[i].Visible = false;
                    biaoqianLabels[i].Visible = false;
                    //yunxingzhuangtaiLabels[i].Visible = false;
                    foreach (Label label in dataLabels[i])
                    {
                        label.Visible = false;
                    }
                }
            }
            //定义变量子类型的名字
            String text = "智能单灯电子UV干燥机";
            switch (childType)
            {
                case 1:
                    text = "智能单灯电子UV干燥机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\单灯干燥机.png");
                    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 2:
                    text = "智能双灯电子UV干燥机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\双灯干燥机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 3:
                    text = "智能三灯电子UV干燥机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\三灯干燥机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 4:
                    text = "智能四灯电子UV干燥机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\四灯干燥机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 5:
                    text = "智能五灯电子UV干燥机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\五灯干燥机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 6:
                    text = "智能六灯电子UV干燥机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\六灯干燥机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 7:
                    text = "智能七灯电子UV干燥机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\七灯干燥机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;
                case 8:
                    text = "智能八灯电子UV干燥机";
                    gxb_Machine.BackgroundImage = new Bitmap(Application.StartupPath + @"\\八灯干燥机.png");
                    gxb_Machine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            ////循环读取刷新所有参数
            ////dryDevice.analyseDatasRecyle();
            //if (device != null && device is DryDevice)
            //{
            //实例化干燥机设备
            DryDevice dryDevice = (DryDevice)device;
            txbRecipeNO.Text = Convert.ToString(dryDevice.bianhao);
            //加载窗体时显示当前plc内部的输送线的速度
            //把运算值以字符串的格式写入到输送线速度监视的textbox内
            txbControlConveyor.Text = Convert.ToString(Convert.ToDecimal(dryDevice.ControlConveyorSpeed) / 100);
            //加载窗体时显示当前plc内部的UV1-UV8的开度
            //把运算值以字符串的格式写入到UV1功率监视的textbox内
            txbControlUV1.Text = Convert.ToString((dryDevice.UV1Percent) / 1);
            //把运算值以字符串的格式写入到UV2功率监视的textbox内
            txbControlUV2.Text = Convert.ToString((dryDevice.UV2Percent) / 1);
            //把运算值以字符串的格式写入到UV3功率监视的textbox内
            txbControlUV3.Text = Convert.ToString((dryDevice.UV3Percent) / 1);
            //把运算值以字符串的格式写入到UV4功率监视的textbox内
            txbControlUV4.Text = Convert.ToString((dryDevice.UV4Percent) / 1);
            //把运算值以字符串的格式写入到UV5功率监视的textbox内
            txbControlUV5.Text = Convert.ToString((dryDevice.UV5Percent) / 1);
            //把运算值以字符串的格式写入到UV6功率监视的textbox内
            txbControlUV6.Text = Convert.ToString((dryDevice.UV6Percent) / 1);
            //把运算值以字符串的格式写入到UV7功率监视的textbox内
            txbControlUV7.Text = Convert.ToString((dryDevice.UV7Percent) / 1);
            //把运算值以字符串的格式写入到UV8功率监视的textbox内
            txbControlUV8.Text = Convert.ToString((dryDevice.UV8Percent) / 1);
            // }
        }
        /// <summary>
        /// 集中读取BYTE用于显示状态等信息，ReadBlockAsByte
        /// </summary>
        /// 
   
        public void Monitor_ReadBack()
        {
                A0开机画面 parent = (A0开机画面)Parent.FindForm();
           
            DryDevice drydevice = (DryDevice)device;
            //把运算值以字符串的格式写入到输送线速度监视的Label内
            lab_Monitor_Conveyor_Speed.Text = Convert.ToString(Convert.ToDecimal(drydevice.shuSongDaiSpeed) / 100) + " Hz";
           // LineSpeed = Convert.ToDecimal(drydevice.shuSongDaiSpeed) /100;
            //把运算值以字符串的格式写入到UV1功率监视的Label内
            lab_Monitor_UV1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV1Power) / 10) + " Kw";
            //把运算值以字符串的格式写入到UV2功率监视的Label内
            lab_Monitor_UV2.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV2Power) / 10) + " Kw";
            //把运算值以字符串的格式写入到UV3功率监视的Label内
            lab_Monitor_UV3.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV3Power) / 10) + " Kw";
            //把运算值以字符串的格式写入到UV4功率监视的Label内
            lab_Monitor_UV4.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV4Power) / 10) + " Kw";
            //把运算值以字符串的格式写入到UV5功率监视的Label内
            lab_Monitor_UV5.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV5Power) / 10) + " Kw";
            //把运算值以字符串的格式写入到UV6功率监视的Label内
            lab_Monitor_UV6.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV6Power) / 10) + " Kw";
            //把运算值以字符串的格式写入到UV7功率监视的Label内
            lab_Monitor_UV7.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV7Power) / 10) + " Kw";
            //把运算值以字符串的格式写入到UV8功率监视的Label内
            lab_Monitor_UV8.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV8Power) / 10) + " Kw";

            //把运算值以字符串的格式写入到输送线运行时间的Label内
            lab_Monitor_Conveyor_Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.shuSongDaiRunTime)) + " H";
            //把运算值以字符串的格式写入到UV1运行时间的Label内
            lab_Monitor_UV1Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV1RunTime)) + " H";
            //把运算值以字符串的格式写入到UV2运行时间的Label内
            lab_Monitor_UV2Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV2RunTime)) + " H";
            //把运算值以字符串的格式写入到UV3运行时间的Label内
            lab_Monitor_UV3Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV3RunTime)) + " H";
            //把运算值以字符串的格式写入到UV4运行时间的Label内
            lab_Monitor_UV4Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV4RunTime)) + " H";
            //把运算值以字符串的格式写入到UV5运行时间的Label内
            lab_Monitor_UV5Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV5RunTime)) + " H";
            //把运算值以字符串的格式写入到UV6运行时间的Label内
            lab_Monitor_UV6Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV6RunTime)) + " H";
            //把运算值以字符串的格式写入到UV7运行时间的Label内
            lab_Monitor_UV7Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV7RunTime)) + " H";
            //把运算值以字符串的格式写入到UV8运行时间的Label内
            lab_Monitor_UV8Hour.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV8RunTime)) + " H";

            //把运算值以字符串的格式写入到UV1剩余运行时间的Label内
            lab_Monitor_UV1Hour1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV1LeftTime)) + " H";
            //把运算值以字符串的格式写入到UV2剩余运行时间的Label内
            lab_Monitor_UV2Hour1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV2LeftTime)) + " H";
            //把运算值以字符串的格式写入到UV3剩余运行时间的Label内
            lab_Monitor_UV3Hour1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV3LeftTime)) + " H";
            //把运算值以字符串的格式写入到UV4剩余运行时间的Label内
            lab_Monitor_UV4Hour1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV4LeftTime)) + " H";
            //把运算值以字符串的格式写入到UV5剩余运行时间的Label内
            lab_Monitor_UV5Hour1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV5LeftTime)) + " H";
            //把运算值以字符串的格式写入到UV6剩余运行时间的Label内
            lab_Monitor_UV6Hour1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV6LeftTime)) + " H";
            //把运算值以字符串的格式写入到UV7剩余运行时间的Label内
            lab_Monitor_UV7Hour1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV7LeftTime)) + " H";
            //把运算值以字符串的格式写入到UV8剩余运行时间的Label内
            lab_Monitor_UV8Hour1.Text = Convert.ToString(Convert.ToDecimal(drydevice.UV8LeftTime)) + " H";
            //判断寿命到期
            string status = device.BaseProtocol.ConnectState.ToString();
            if (status == "Connected")
            {
                if (drydevice.UV1LeftTime == 0 && device.childType == 1)
                {
                    MessageBox.Show("1#UV灯管使用寿命到期，请更换配件！");
                    parent.showLog("1#UV灯管使用寿命到期，请更换配件！");
                }
                if (drydevice.UV2LeftTime == 0 && device.childType == 1 && device.childType ==2)
                {
                    MessageBox.Show("2#UV灯管使用寿命到期，请更换配件！");
                    parent.showLog("2#UV灯管使用寿命到期，请更换配件！");
                }
                if (drydevice.UV3LeftTime == 0 && device.childType == 1 && device.childType == 2 && device.childType == 3)
                {
                    MessageBox.Show("3#UV灯管使用寿命到期，请更换配件！");
                    parent.showLog("3#UV灯管使用寿命到期，请更换配件！");
                }
                if (drydevice.UV4LeftTime == 0 && device.childType == 1 && device.childType == 2 && device.childType == 3 && device.childType == 4)
                {
                    MessageBox.Show("4#UV灯管使用寿命到期，请更换配件！");
                    parent.showLog("4#UV灯管使用寿命到期，请更换配件！");
                }
            }
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
            if (txbRecipeNO.Text.Trim() == "")
            {
                //实例化涂布机设备
                DryDevice dry = (DryDevice)device;
                txbRecipeNO.Text = Convert.ToString(dry.bianhao);
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
        /// 配方读取、配方保存和配方确认按钮   操作按钮被按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Recipe_Read_MouseDown(object sender, MouseEventArgs e)
        {
            btn_MouseDown(sender);      //调用判断方法 
        }
        /// <summary>
        /// 对3个按钮进行判断，判断哪一个按钮被按下
        /// </summary>
        /// <param name="sender"></param>
        public void btn_MouseDown(object sender)
        {
            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            var rsno = false;
            switch (button.Name)
            {
                case "btn_Recipe_Save":
                    rsno = device.BaseProtocol.WriteReg("DB99.DBB38", 1);
                    if (rsno == true)
                    {
                        btn_Recipe_Save.BackColor = Color.MediumSeaGreen;
                        parent.showLog(device.typeName + device.index + "配方保存操作执行成功");
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
                    rsno = device.BaseProtocol.WriteReg("DB99.DBB38", 2);
                    if (rsno == true)
                    {
                        btn_Recipe_Read.BackColor = Color.MediumSeaGreen;
                        parent.showLog(device.typeName + device.index + "配方读取操作执行成功");
                        btn_Recipe_Read.Focus();
                        //当读取配方按钮得到焦点后
                        Btn_Recipe_Read_GotFocus();
                    }
                    else
                    {
                        MessageBox.Show("配方读取操作执行失败");
                        parent.showLog(device.typeName + device.index + "配方读取操作执行失败");
                    }
                    break;

                case "btn_Recipe_OK":
                    rsno = device.BaseProtocol.WriteReg("DB99.DBB38", 4);
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
        /// 当配方保存按钮获取到焦点时执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Recipe_Save_GotFocus1()
        {
            //配方参数写入
            var res = device.BaseProtocol.WriteReg("DB99.DBW4",
                Convert.ToInt16(Convert.ToDecimal(txbControlConveyor.Text.ToString()) * 100),
                Convert.ToInt16(txbControlUV1.Text.ToString()),
                Convert.ToInt16(txbControlUV2.Text.ToString()),
                Convert.ToInt16(txbControlUV3.Text.ToString()),
                Convert.ToInt16(txbControlUV4.Text.ToString()),
                Convert.ToInt16(txbControlUV5.Text.ToString()),
                Convert.ToInt16(txbControlUV6.Text.ToString()),
                Convert.ToInt16(txbControlUV7.Text.ToString()),
                Convert.ToInt16(txbControlUV8.Text.ToString()));
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
        /// 配方读取按钮获取到焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Recipe_Read_GotFocus()
        {
            RecipeNO_Input();           //调用配方编号改变时的操作方法
            RecipeNOWriteIn();
        }
        /// <summary>
        /// 配方编号写入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecipeNOWriteIn()
        {
            //配方编号写入
            var res1 = device.BaseProtocol.WriteReg("DB99.DBD0", Convert.ToInt32(txbRecipeNO.Text.ToString()));
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
        //向数据库的数据表插入数据行，
        private void saveToDatabaseTable()
        {
        }
        //DB区的Word内容监控-----输送线报警监控
        string alarm_Msg1 = DateTime.Now + "     输送带变频器故障，0C1（停机时过电流）";
        string alarm_Msg2 = DateTime.Now + "     输送带变频器故障，0C2（加速时过电流）";
        string alarm_Msg3 = DateTime.Now + "     输送带变频器故障，0C0（减速时过电流）";
        string alarm_Msg4 = DateTime.Now + "     输送带变频器故障，0V1（停机时过电压）";
        string alarm_Msg5 = DateTime.Now + "     输送带变频器故障，0V2（加速时过电压）";
        string alarm_Msg6 = DateTime.Now + "     输送带变频器故障，0V3（定速时过电压）";
        string alarm_Msg7 = DateTime.Now + "     输送带变频器故障，0V0（减速时过电压）";
        string alarm_Msg8 = DateTime.Now + "     输送带变频器故障，THT（IGBT模块过热）";
        string alarm_Msg9 = DateTime.Now + "     输送带变频器故障，THN（电机过热）";
        string alarm_Msg10 = DateTime.Now + "     输送带变频器故障，NTC(模组过热)";
        string alarm_Msg11 = DateTime.Now + "     输送带变频器故障，EEP(内存异常)";
        string alarm_Msg12 = DateTime.Now + "     输送带变频器故障，PIDE（PID异常）";
        string alarm_Msg13 = DateTime.Now + "     输送带变频器故障，OLS(失速防止功能)";
        string alarm_Msg14 = DateTime.Now + "     输送带变频器故障，OL2 (过转矩异常)";
        string alarm_Msg15 = DateTime.Now + "     输送带变频器故障，OPT (通讯异常)";
        string alarm_Msg16 = DateTime.Now + "     输送带变频器故障，SCP (短路过电流)";
        string alarm_Msg17 = DateTime.Now + "     输送带变频器故障，CPU (CPU异常)";
        /// <summary>
        /// 刷新显示报警信息
        /// </summary>
        private void AlarmMessage()
        {
            DryDevice drydevice = (DryDevice)device;

            UInt32[] alarm_value = new UInt32[] { 16, 17, 19, 32, 33, 34, 35, 48, 49, 50, 64, 66, 97, 98, 160, 179, 192 };
            string[] alarm_Msg = new string[] {alarm_Msg1,alarm_Msg2,alarm_Msg3, alarm_Msg4, alarm_Msg5, alarm_Msg6, alarm_Msg7, alarm_Msg8, alarm_Msg9, alarm_Msg10,
            alarm_Msg11,alarm_Msg12,alarm_Msg13, alarm_Msg14, alarm_Msg15, alarm_Msg16, alarm_Msg17};

            for (int i = 0; i < alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.shuSongDaiStatusCode)                                               //==则表示报警
                {

                    if (!lsbAlarmMsg.Items.Contains(alarm_Msg[i]))             //判定当前没有显示，则插入一行显示
                    {
                        lsbAlarmMsg.Items.Insert(0, alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(alarm_Msg[i]);
                }
            }
        }
        //UV报警
        #region
        /// <summary>
        /// DB区的Word内容监控-----UV灯报警监控
        /// </summary>
        static String UV1alarm_Msg1 = DateTime.Now + "     UV1电源内部过热保护";
        static String UV1alarm_Msg2 = DateTime.Now + "     UV1输入24V低于21V";
        static String UV1alarm_Msg3 = DateTime.Now + "     UV1输入主电源异常";
        static String UV1alarm_Msg4 = DateTime.Now + "     UV1 对地保护异常";
        static String UV1alarm_Msg5 = DateTime.Now + "     UV1无法触发灯管";
        static String UV1alarm_Msg6 = DateTime.Now + "     UV1运行过程中灯管熄灭";
        static String UV1alarm_Msg7 = DateTime.Now + "     UV1电源初始化出错";
        static String UV1alarm_Msg8 = DateTime.Now + "     UV1通讯错误";
        static String UV1alarm_Msg9 = DateTime.Now + "     UV1风机变频器故障";
        static String UV1alarm_Msg10 = DateTime.Now + "     UV1设定时间内未完成预热";
        static String UV1alarm_Msg11 = DateTime.Now + "     UV1急停";

        static String UV2alarm_Msg1 = DateTime.Now + "     UV2电源内部过热保护";
        static String UV2alarm_Msg2 = DateTime.Now + "     UV2输入24V低于21V";
        static String UV2alarm_Msg3 = DateTime.Now + "     UV2输入主电源异常";
        static String UV2alarm_Msg4 = DateTime.Now + "     UV2对地保护异常";
        static String UV2alarm_Msg5 = DateTime.Now + "     UV2无法触发灯管";
        static String UV2alarm_Msg6 = DateTime.Now + "     UV2运行过程中灯管熄灭";
        static String UV2alarm_Msg7 = DateTime.Now + "     UV2电源初始化出错";
        static String UV2alarm_Msg8 = DateTime.Now + "     UV2通讯错误";
        static String UV2alarm_Msg9 = DateTime.Now + "     UV2风机变频器故障";
        static String UV2alarm_Msg10 = DateTime.Now + "     UV2设定时间内未完成预热";
        static String UV2alarm_Msg11 = DateTime.Now + "     UV2急停";

        static String UV3alarm_Msg1 = DateTime.Now + "     UV3电源内部过热保护";
        static String UV3alarm_Msg2 = DateTime.Now + "     UV3输入24V低于21V";
        static String UV3alarm_Msg3 = DateTime.Now + "     UV3输入主电源异常";
        static String UV3alarm_Msg4 = DateTime.Now + "     UV3对地保护异常";
        static String UV3alarm_Msg5 = DateTime.Now + "     UV3无法触发灯管";
        static String UV3alarm_Msg6 = DateTime.Now + "     UV3运行过程中灯管熄灭";
        static String UV3alarm_Msg7 = DateTime.Now + "     UV3电源初始化出错";
        static String UV3alarm_Msg8 = DateTime.Now + "     UV3通讯错误";
        static String UV3alarm_Msg9 = DateTime.Now + "     UV3风机变频器故障";
        static String UV3alarm_Msg10 = DateTime.Now + "     UV3设定时间内未完成预热";
        static String UV3alarm_Msg11 = DateTime.Now + "     UV3急停";

        static String UV4alarm_Msg1 = DateTime.Now + "     UV4电源内部过热保护";
        static String UV4alarm_Msg2 = DateTime.Now + "     UV4输入24V低于21V";
        static String UV4alarm_Msg3 = DateTime.Now + "     UV4输入主电源异常";
        static String UV4alarm_Msg4 = DateTime.Now + "     UV4对地保护异常";
        static String UV4alarm_Msg5 = DateTime.Now + "     UV4无法触发灯管";
        static String UV4alarm_Msg6 = DateTime.Now + "     UV4运行过程中灯管熄灭";
        static String UV4alarm_Msg7 = DateTime.Now + "     UV4电源初始化出错";
        static String UV4alarm_Msg8 = DateTime.Now + "     UV4通讯错误";
        static String UV4alarm_Msg9 = DateTime.Now + "     UV4风机变频器故障";
        static String UV4alarm_Msg10 = DateTime.Now + "     UV4设定时间内未完成预热";
        static String UV4alarm_Msg11 = DateTime.Now + "     UV4急停";

        static String UV5alarm_Msg1 = DateTime.Now + "     UV5电源内部过热保护";
        static String UV5alarm_Msg2 = DateTime.Now + "     UV5输入24V低于21V";
        static String UV5alarm_Msg3 = DateTime.Now + "     UV5输入主电源异常";
        static String UV5alarm_Msg4 = DateTime.Now + "     UV5对地保护异常";
        static String UV5alarm_Msg5 = DateTime.Now + "     UV5无法触发灯管";
        static String UV5alarm_Msg6 = DateTime.Now + "     UV5运行过程中灯管熄灭";
        static String UV5alarm_Msg7 = DateTime.Now + "     UV5电源初始化出错";
        static String UV5alarm_Msg8 = DateTime.Now + "     UV5通讯错误";
        static String UV5alarm_Msg9 = DateTime.Now + "     UV5风机变频器故障";
        static String UV5alarm_Msg10 = DateTime.Now + "     UV5设定时间内未完成预热";
        static String UV5alarm_Msg11 = DateTime.Now + "     UV5急停";

        static String UV6alarm_Msg1 = DateTime.Now + "     UV6电源内部过热保护";
        static String UV6alarm_Msg2 = DateTime.Now + "     UV6输入24V低于21V";
        static String UV6alarm_Msg3 = DateTime.Now + "     UV6输入主电源异常";
        static String UV6alarm_Msg4 = DateTime.Now + "     UV6对地保护异常";
        static String UV6alarm_Msg5 = DateTime.Now + "     UV6无法触发灯管";
        static String UV6alarm_Msg6 = DateTime.Now + "     UV6运行过程中灯管熄灭";
        static String UV6alarm_Msg7 = DateTime.Now + "     UV6电源初始化出错";
        static String UV6alarm_Msg8 = DateTime.Now + "     UV6通讯错误";
        static String UV6alarm_Msg9 = DateTime.Now + "     UV6风机变频器故障";
        static String UV6alarm_Msg10 = DateTime.Now + "     UV6设定时间内未完成预热";
        static String UV6alarm_Msg11 = DateTime.Now + "     UV6急停";

        static String UV7alarm_Msg1 = DateTime.Now + "     UV7电源内部过热保护";
        static String UV7alarm_Msg2 = DateTime.Now + "     UV7输入24V低于21V";
        static String UV7alarm_Msg3 = DateTime.Now + "     UV7输入主电源异常";
        static String UV7alarm_Msg4 = DateTime.Now + "     UV7对地保护异常";
        static String UV7alarm_Msg5 = DateTime.Now + "     UV7无法触发灯管";
        static String UV7alarm_Msg6 = DateTime.Now + "     UV7运行过程中灯管熄灭";
        static String UV7alarm_Msg7 = DateTime.Now + "     UV7电源初始化出错";
        static String UV7alarm_Msg8 = DateTime.Now + "     UV7通讯错误";
        static String UV7alarm_Msg9 = DateTime.Now + "     UV7风机变频器故障";
        static String UV7alarm_Msg10 = DateTime.Now + "     UV7设定时间内未完成预热";
        static String UV7alarm_Msg11 = DateTime.Now + "     UV7急停";

        static String UV8alarm_Msg1 = DateTime.Now + "     UV8电源内部过热保护";
        static String UV8alarm_Msg2 = DateTime.Now + "     UV8输入24V低于21V";
        static String UV8alarm_Msg3 = DateTime.Now + "     UV8输入主电源异常";
        static String UV8alarm_Msg4 = DateTime.Now + "     UV8对地保护异常";
        static String UV8alarm_Msg5 = DateTime.Now + "     UV8无法触发灯管";
        static String UV8alarm_Msg6 = DateTime.Now + "     UV8运行过程中灯管熄灭";
        static String UV8alarm_Msg7 = DateTime.Now + "     UV8电源初始化出错";
        static String UV8alarm_Msg8 = DateTime.Now + "     UV8通讯错误";
        static String UV8alarm_Msg9 = DateTime.Now + "     UV8风机变频器故障";
        static String UV8alarm_Msg10 = DateTime.Now + "     UV8设定时间内未完成预热";
        static String UV8alarm_Msg11 = DateTime.Now + "     UV8急停";
        /// <summary>
        /// UV报警监控
        /// </summary>
        public void UV_byte_Alarm_Monitor()
        {
            DryDevice drydevice = (DryDevice)device;

            UInt32[] alarm_value = new UInt32[] { 1, 2, 4, 5, 6, 9, 14, 15, 103, 7, 255 };
            string[] UV1alarm_Msg = new string[] { UV1alarm_Msg1, UV1alarm_Msg2, UV1alarm_Msg3, UV1alarm_Msg4, UV1alarm_Msg5, UV1alarm_Msg6, UV1alarm_Msg7, UV1alarm_Msg8, UV1alarm_Msg9, UV1alarm_Msg10, UV1alarm_Msg11 };
            string[] UV2alarm_Msg = new string[] { UV2alarm_Msg1, UV2alarm_Msg2, UV2alarm_Msg3, UV2alarm_Msg4, UV2alarm_Msg5, UV2alarm_Msg6, UV2alarm_Msg7, UV2alarm_Msg8, UV2alarm_Msg9, UV2alarm_Msg10, UV2alarm_Msg11 };
            string[] UV3alarm_Msg = new string[] { UV3alarm_Msg1, UV3alarm_Msg2, UV3alarm_Msg3, UV3alarm_Msg4, UV3alarm_Msg5, UV3alarm_Msg6, UV3alarm_Msg7, UV3alarm_Msg8, UV3alarm_Msg9, UV3alarm_Msg10, UV3alarm_Msg11 };
            string[] UV4alarm_Msg = new string[] { UV4alarm_Msg1, UV4alarm_Msg2, UV4alarm_Msg3, UV4alarm_Msg4, UV4alarm_Msg5, UV4alarm_Msg6, UV4alarm_Msg7, UV4alarm_Msg8, UV4alarm_Msg9, UV4alarm_Msg10, UV4alarm_Msg11 };
            string[] UV5alarm_Msg = new string[] { UV5alarm_Msg1, UV5alarm_Msg2, UV5alarm_Msg3, UV5alarm_Msg4, UV5alarm_Msg5, UV5alarm_Msg6, UV5alarm_Msg7, UV5alarm_Msg8, UV5alarm_Msg9, UV5alarm_Msg10, UV5alarm_Msg11 };
            string[] UV6alarm_Msg = new string[] { UV6alarm_Msg1, UV6alarm_Msg2, UV6alarm_Msg3, UV6alarm_Msg4, UV6alarm_Msg5, UV6alarm_Msg6, UV6alarm_Msg7, UV6alarm_Msg8, UV6alarm_Msg9, UV6alarm_Msg10, UV6alarm_Msg11 };
            string[] UV7alarm_Msg = new string[] { UV7alarm_Msg1, UV7alarm_Msg2, UV7alarm_Msg3, UV7alarm_Msg4, UV7alarm_Msg5, UV7alarm_Msg6, UV7alarm_Msg7, UV7alarm_Msg8, UV7alarm_Msg9, UV7alarm_Msg10, UV7alarm_Msg11 };
            string[] UV8alarm_Msg = new string[] { UV8alarm_Msg1, UV8alarm_Msg2, UV8alarm_Msg3, UV8alarm_Msg4, UV8alarm_Msg5, UV8alarm_Msg6, UV8alarm_Msg7, UV8alarm_Msg8, UV8alarm_Msg9, UV8alarm_Msg10, UV8alarm_Msg11 };
            //UV1字节报警输出
            for (int i = 0; i < UV1alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.UV1StatusCode)
                {
                    if (!this.lsbAlarmMsg.Items.Contains(UV1alarm_Msg[i]) == true)             //判定当前有没有显示
                    {
                        lsbAlarmMsg.Items.Insert(0, UV1alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(UV1alarm_Msg[i]);
                }
            }
            //UV2字节报警输出
            for (int i = 0; i < UV2alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.UV2StatusCode)
                {
                    if (!this.lsbAlarmMsg.Items.Contains(UV2alarm_Msg[i]) == true)             //判定当前有没有显示
                    {
                        lsbAlarmMsg.Items.Insert(0, UV2alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(UV2alarm_Msg[i]);
                }
            }
            //UV3字节报警输出
            for (int i = 0; i < UV3alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.UV3StatusCode)
                {
                    if (!this.lsbAlarmMsg.Items.Contains(UV3alarm_Msg[i]) == true)             //判定当前有没有显示
                    {
                        lsbAlarmMsg.Items.Insert(0, UV3alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(UV3alarm_Msg[i]);
                }
            }
            //UV4字节报警输出
            for (int i = 0; i < UV4alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.UV4StatusCode)
                {
                    if (!this.lsbAlarmMsg.Items.Contains(UV4alarm_Msg[i]) == true)             //判定当前有没有显示
                    {
                        lsbAlarmMsg.Items.Insert(0, UV4alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(UV4alarm_Msg[i]);
                }
            }
            //UV5字节报警输出
            for (int i = 0; i < UV5alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.UV5StatusCode)
                {
                    if (!this.lsbAlarmMsg.Items.Contains(UV5alarm_Msg[i]) == true)             //判定当前有没有显示
                    {
                        lsbAlarmMsg.Items.Insert(0, UV5alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(UV5alarm_Msg[i]);
                }
            }
            //UV6字节报警输出
            for (int i = 0; i < UV6alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.UV6StatusCode)
                {
                    if (!this.lsbAlarmMsg.Items.Contains(UV6alarm_Msg[i]) == true)             //判定当前有没有显示
                    {
                        lsbAlarmMsg.Items.Insert(0, UV6alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(UV6alarm_Msg[i]);
                }
            }
            //UV7字节报警输出
            for (int i = 0; i < UV7alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.UV7StatusCode)
                {
                    if (!this.lsbAlarmMsg.Items.Contains(UV7alarm_Msg[i]) == true)             //判定当前有没有显示
                    {
                        lsbAlarmMsg.Items.Insert(0, UV7alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(UV7alarm_Msg[i]);
                }
            }
            //UV8字节报警输出
            for (int i = 0; i < UV8alarm_Msg.Length; i++)
            {
                if (alarm_value[i] == drydevice.UV8StatusCode)
                {
                    if (!this.lsbAlarmMsg.Items.Contains(UV8alarm_Msg[i]) == true)             //判定当前有没有显示
                    {
                        lsbAlarmMsg.Items.Insert(0, UV8alarm_Msg[i]);                         //如果当前没有显示则插入语句
                    }
                }
                else
                {
                    lsbAlarmMsg.Items.Remove(UV8alarm_Msg[i]);
                }
            }
        }
        #endregion
        /// <summary>
        /// 界面布局显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void A1电子UV干燥机_Resize(object sender, EventArgs e)
        {
            /*
            容器1的分隔条显示距离=容器1的宽度/2
            */
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }
    }
}
