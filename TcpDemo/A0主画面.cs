using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;                        //用于连接Excel
//using Microsoft.Office.Interop.Excel;
using System.Collections;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using static TcpDemo.A0开机画面;
using System.Threading;
using MySql.Data.MySqlClient;
using SCADA.Drive;
using System.Windows.Forms.DataVisualization.Charting;

namespace TcpDemo
{
    public partial class A0主画面 : UserControl
    {
        belt_f beltw = new belt_f();
        public A0主画面()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //曲线显示数据刷新
            Init();
            if (Screen.AllScreens.Count() != 1)
            {

                beltw.Left = Screen.AllScreens[0].Bounds.Width;
                beltw.Top = 0;
                beltw.Size = new System.Drawing.Size(Screen.AllScreens[1].Bounds.Width, Screen.AllScreens[1].Bounds.Height);
                beltw.Show();
            }
        }

        public bool MainIsClosed { get; set; }
        public A0开机画面 parentForm;
        /// <summary>
        /// 主页面后台线程
        /// </summary>
        public void MainBackRefresh()
        {
            while (!MainIsClosed)
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                try
                {
                    refreshStatus();
                    //ColorChoose();
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
                        if (MainIsClosed) break;
                        Thread.Sleep(1 * 100);
                    }
                }
                sw.Stop();
            }
        }

        /// <summary>
        /// 主界面参数修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            switch (button.Name)
            {
                case "btnSave":
                    btnSave.Focus();
                    //btnSave.GotFocus += BtnSave_GotFocus;
                    BtnSave_GotFocus();
                    chbCheck.Enabled = false;
                    chbAutoTestHeight.Enabled = false;
                    chbAutomation.Enabled = false;
                    chbTiaomachoice.Enabled = false;
                    btnHeightBiaoDing.Enabled = false;

                    txbInputHeight.Enabled = false;
                    txbSpeedWrite.Enabled = false;
                    txbProtectTime.Enabled = false;
                    AutoHeightTest.Enabled = false;
                    txbHeightValue.Enabled = false;

                    btnSave.Enabled = false;
                    btnEditor.Enabled = true;
                    break;
                case "btnEditor":
                    chbCheck.Enabled = true;
                    chbAutoTestHeight.Enabled = true;
                    chbAutomation.Enabled = true;
                    chbTiaomachoice.Enabled = true;
                    btnHeightBiaoDing.Enabled = true;

                    txbInputHeight.Enabled = true;
                    txbSpeedWrite.Enabled = true;
                    txbProtectTime.Enabled = true;
                    AutoHeightTest.Enabled = true;
                    txbHeightValue.Enabled = true;

                    btnEditor.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("编辑完参数后请点击保存按钮");
                    break;
            }
        }
        /// <summary>
        /// 保存修改过的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_GotFocus()
        {
            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            //配方参数写入--整线速度一键写入DB99.DBW406
            var res1 = PublicValue.BaseProtocol.WriteReg("DB99.DBW408", Convert.ToInt16(Convert.ToDecimal(txbSpeedWrite.Text.ToString()) * 100));
            if (res1 == true)
            {
                parent.showLog("整线速度参数写入成功");
            }
            else
            {
                MessageBox.Show("整线速度配方参数写入失败");
                parent.showLog("整线速度参数写入失败");
            }
            //配方参数写入--整线高度一键写入DB99.DBW404
            var res2 = PublicValue.BaseProtocol.WriteReg("DB99.DBW404", Convert.ToInt16(Convert.ToDecimal(txbInputHeight.Text.ToString()) * 100));
            if (res2 == true)
            {
                parent.showLog("整线高度参数写入成功");
            }
            else
            {
                MessageBox.Show("整线高度配方参数写入失败");
                parent.showLog("整线高度参数写入失败");
            }
            //信号延时保护时间DB99.DBW400
            var res3 = PublicValue.BaseProtocol.WriteReg("DB99.DBW400", Convert.ToInt16(Convert.ToDecimal(txbProtectTime.Text.ToString()) * 1000));
            if (res3 == true)
            {
                parent.showLog("信号延时时间参数写入成功");
            }
            else
            {
                MessageBox.Show("信号延时时间参数写入失败");
                parent.showLog("信号延时时间参数写入失败");
            }
            //未启用滚轮的高度DB99.DBW398
            var res4 = PublicValue.BaseProtocol.WriteReg("DB99.DBW398", Convert.ToInt16(Convert.ToDecimal(AutoHeightTest.Text.ToString()) * 100));
            if (res4 == true)
            {
                parent.showLog("未启用滚轮的高度参数写入成功");
            }
            else
            {
                MessageBox.Show("未启用滚轮的高度参数写入失败");
                parent.showLog("未启用滚轮的高度参数写入失败");
            }

            //高度补偿显示DB99.DBW236
            var res7 = PublicValue.BaseProtocol.WriteReg("DB99.DBW236", Convert.ToInt16(Convert.ToDecimal(txbHeightValue.Text.ToString()) * 100));
            if (res7 == true)
            {
                parent.showLog("自动测厚补偿高度参数写入成功");
            }
            else
            {
                MessageBox.Show("自动测厚补偿高度参数写入失败");
                parent.showLog("自动测厚补偿高度参数写入失败");
            }
            //相机颜色选择DB99.DBW306


        }



        //“运行”、“停止”、“复位”、“待机”按钮被按下
        private void btn_Run_MouseDown(object sender, MouseEventArgs e)
        {
            btn_MouseDown(sender);
        }
        //对“运行”、“停止”、“复位”、“待机”按钮进行判断，判断哪一个按钮被按下
        public void btn_MouseDown(object sender)
        {

            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            switch (button.Name)
            {
                case "btn_Run":
                    var rsno1 = PublicValue.BaseProtocol.WriteReg("DB99.DBB0", 1);
                    //rsno = device.BaseProtocol.WriteReg("DB99.DBB63", 1);
                    if (rsno1 == true)
                    {
                        btn_Run.BackColor = Color.MediumSeaGreen;
                        btn_Run.Text = "启动";
                        parent.showLog("整线运行操作执行成功");
                    }
                    else
                    {
                        parent.showLog("整线运行操作执行失败");
                        MessageBox.Show("整线启动操作失败");
                    }
                    break;
                case "btn_Stop":
                    var rsno2 = PublicValue.BaseProtocol.WriteReg("DB99.DBB0", 2);

                    //var rsno2 = PublicValue.BaseProtocol.SetBit("DB999.DBX0.0");
                    if (rsno2 == true)
                    {
                        btn_Stop.BackColor = Color.MediumSeaGreen;
                        btn_Stop.Text = "停止";
                        parent.showLog("整线停止操作执行成功");
                    }
                    else
                    {
                        parent.showLog("整线停止操作执行失败");
                        MessageBox.Show("整线停止操作失败");
                    }
                    break;
                case "btn_Reset":
                    var rsno3 = PublicValue.BaseProtocol.WriteReg("DB99.DBB0", 4);
                    if (rsno3 == true)
                    {
                        btn_Reset.BackColor = Color.MediumSeaGreen;
                        btn_Reset.Text = "复位";
                        parent.showLog("整线复位操作执行成功");
                    }
                    else
                    {
                        parent.showLog("整线复位操作执行失败");
                        MessageBox.Show("整线复位操作失败");
                    }
                    break;
                case "btn_Ready":
                    var rsno4 = PublicValue.BaseProtocol.WriteReg("DB99.DBB0", 8);
                    if (rsno4 == true)
                    {
                        btn_Ready.BackColor = Color.MediumSeaGreen;
                        btn_Ready.Text = "待机";
                        parent.showLog("整线待机操作执行成功");
                    }
                    else
                    {
                        parent.showLog("整线待机操作执行失败");
                        MessageBox.Show("整线待机操作失败");
                    }
                    break;
            }
            TimerReadClose.Enabled = true;
        }

        //延时变换颜色
        private void TimerReadClose_Tick_1(object sender, EventArgs e)
        {
            btn_Stop.BackColor = Color.DodgerBlue;
            btn_Run.BackColor = Color.DodgerBlue;
            btn_Reset.BackColor = Color.DodgerBlue;
            btn_Ready.BackColor = Color.DodgerBlue;
            TimerReadClose.Enabled = false;
        }
        //主界面刷新设备运行状态
        private void refreshStatus()
        {
            //获取到要刷新状态的button
            foreach (Control control in splitMain.Panel2.Controls)
            {
                //获取button对应的device信息
                Object tag = control.Tag;
                if (tag != null && tag is Device && control is ButtonEx)
                {
                    Device device = (Device)tag;
                    ButtonEx button = (ButtonEx)control;

                    //获取设备状态//如果没有在DB 块的定义范围也无效
                    //单机设备的红黄绿运行状态
                    var rsno = device.BaseProtocol.ReadReg("DB99.DBB236");
                    if (rsno != null)
                    {
                        if (rsno == 4)
                        {
                            //报警
                            button.BackColor = Color.Red;
                        }
                        else if (rsno == 2)
                        {
                            //手动
                            button.BackColor = Color.Yellow;
                        }
                        else if (rsno == 1)
                        {
                            //自动
                            button.BackColor = Color.LightGreen;
                        }
                    }
                    else
                    {
                        button.BackColor = Color.Gray;
                    }
                }
            }
        }
        /// <summary>
        /// 使用测厚值或者一键设定测厚值;=0使用自动测厚值；=1使用设定值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbCheck_CheckedChanged(object sender, EventArgs e)
        {
            A0开机画面 parent = (A0开机画面)Parent.FindForm();
            System.Windows.Forms.CheckBox _name = (System.Windows.Forms.CheckBox)sender;
            switch (_name.Name)
            {
                case "chbCheck":
                    if (chbCheck.Checked == true)
                    {
                        var resno0 = PublicValue.BaseProtocol.WriteReg("DB99.DBW410", 1);
                        if (resno0 == true)
                        {
                            txbInputHeight.Visible = true;
                            chbCheck.Checked = true;
                            //chbCheck.Text = "测厚功能启用";
                            chbCheck.Text = "产品设定厚度(mm):";
                            MessageBox.Show("请设定一键厚度值");
                        }
                        else
                        {
                            chbCheck.Checked = false;
                            //MessageBox.Show("选择失败，请重新选择");
                        }
                    }
                    else
                    {
                        var resno1 = PublicValue.BaseProtocol.WriteReg("DB99.DBW410", 0);
                        if (resno1 == true)
                        {
                            txbInputHeight.Visible = false;
                            chbCheck.Checked = false;
                            chbCheck.Text = "自动测厚功能选用";
                            //MessageBox.Show("已选择自动测厚功能");
                        }
                        else
                        {
                            chbCheck.Checked = true;
                            //MessageBox.Show("选择失败，请重新选择");
                        }
                    }
                    break;
                case "chbTiaomachoice":
                    if (chbTiaomachoice.Checked == true)
                    {
                        var resno0 = PublicValue.BaseProtocol.WriteReg("DB99.DBW412", 1);
                        if (resno0 == true)
                        {
                            //打开串口
                            parent.PortOpen();
                            //开机自动打开扫码枪的com5口
                            //parent.myComPort.Open();
                            chbTiaomachoice.Text = "扫码功能启用";
                            parent.btn_Recipe_Read.Visible = false;
                            parent.btn_Recipe_OK.Visible = false;
                            parent.showLog("启用条码扫描功能成功");
                        }
                        else
                        {
                            chbTiaomachoice.Checked = false;
                            //MessageBox.Show("选择失败，请重新选择");
                        }
                    }
                    else
                    {
                        var resno1 = PublicValue.BaseProtocol.WriteReg("DB99.DBW412", 0);
                        if (resno1 == true)
                        {
                            chbTiaomachoice.Text = "扫码功能停用";
                            parent.myComPort.Close();
                            parent.btn_Recipe_Read.Visible = true;
                            parent.btn_Recipe_OK.Visible = true;
                            //关闭串口
                            parent.Portclosed();
                            parent.showLog("关闭条码扫描功能成功");
                        }
                        else
                        {
                            chbTiaomachoice.Checked = true;
                            //MessageBox.Show("选择失败，请重新选择");
                        }
                    }
                    break;
                case "chbAutoTestHeight":
                    //自动测量厚度
                    if (chbAutoTestHeight.Checked == true)
                    {
                        Console.WriteLine(chbAutoTestHeight.Checked);
                        var res5 = PublicValue.BaseProtocol.WriteReg("DB99.DBW396", 1);
                        if (res5 == true)
                        {
                            chbAutoTestHeight.Checked = true;
                            chbAutoTestHeight.Text = "测厚功能启用";
                            btnHeightBiaoDing.Visible = true;
                            chbCheck.Visible = true;
                            chbCheck.Checked = false;
                            //if (chbCheck.Checked == true)
                            //{
                            //    txbInputHeight.Visible = true;
                            //}
                            //else
                            //{
                            //    txbInputHeight.Visible = false;
                            //}
                            parent.showLog("启用自动测厚度功能成功");
                        }
                    }
                    else
                    {
                        var res5 = PublicValue.BaseProtocol.WriteReg("DB99.DBW396", 0);
                        if (res5 == true)
                        {
                            btnHeightBiaoDing.Visible = false;
                            chbAutoTestHeight.Checked = false;
                            chbAutoTestHeight.Text = "测厚功能停用";
                            chbCheck.Visible = false;
                            txbInputHeight.Visible = false;
                            parent.showLog("停用自动测厚度功能成功");
                            var resno1 = PublicValue.BaseProtocol.WriteReg("DB99.DBW410", 0);
                        }
                    }
                    break;
                case "chbAutomation":
                    //柔性功能
                    if (chbAutomation.Checked == true)
                    {
                        var res5 = PublicValue.BaseProtocol.WriteReg("DB99.DBW406", 0);
                        if (res5 == true)
                        {
                            chbAutomation.Text = "柔性功能启用";
                            chbAutomation.Checked = true;
                            parent.showLog("启用柔性功能成功");
                        }
                    }
                    else
                    {
                        var res5 = PublicValue.BaseProtocol.WriteReg("DB99.DBW406", 1);
                        if (res5 == true)
                        {
                            chbAutomation.Text = "柔性功能停用";
                            chbAutomation.Checked = false;
                            parent.showLog("关闭柔性功能成功");
                        }
                    }
                    break;
            }
        }
        A0数据库操作 database = new A0数据库操作();
        /// <summary>
        /// 运行状态插入到ProcessTable中
        /// </summary>
        /// <param name="showlog"></param>
        public void processTable(string showlog)
        {
            DateTime datetime = DateTime.Now;
            string value = "( null,'" + datetime + "','" + Convert.ToString(showlog) + "')";
            database.InsertDataToMysqlStatus("purete", "ProcessStatusTable", value);
        }
        /// <summary>
        /// 一键标定厚度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHeightBiaoDing_Click(object sender, EventArgs e)
        {
            //A0开机画面 parent = (A0开机画面)Parent.FindForm();
            var resno8 = PublicValue.BaseProtocol.WriteReg("DB99.DBB240", 1);

            if (resno8 == true)
            {
                MessageBox.Show("测厚功能标定成功");
                parentForm.showLog("测厚标定成功");
            }
            else
            {
                MessageBox.Show("测厚功能标定失败");
                parentForm.showLog("测厚标定失败");
            }
        }
        /// <summary>
        /// 当颜色选择索引值发生变化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbColorChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            QwUI.XmlUserConfig.SetUserCfg($"Recipe_{parentForm.txbRecipeNO.Value}", cmbColorChoose.SelectedIndex);

            var resno7 = PublicValue.BaseProtocol.WriteReg("DB99.DBW306", (cmbColorChoose.SelectedIndex + 1));
            //selectIndex = QwUI.XmlUserConfig.GetUserCfg($"Recipe_{productNo}", "红色");
            //Console.WriteLine(1 << cmbColorChoose.SelectedIndex);
            //MessageBox.Show("选择颜色:" + (cmbColorChoose.SelectedIndex));
            //MessageBox.Show($"选择颜色:{cmbColorChoose.Text} ,发送给PLC {cmbColorChoose.SelectedIndex+1}");
        }

        /// <summary>
        /// 曲线显示初始化程序
        /// </summary>
        private void Init()
        {
            //画图柱形图的条数决定是由数据源也就Series决定。Series是对象，动态创建即可。
            Series s1 = new Series();
            //
            chart1.Series.Add(s1);
            //是否启用3D显示
            chart1.ChartAreas[0].Area3DStyle.Enable3D = false;

            //显示类型,可以是柱形 折线等等
            chart1.Series[0].ChartType = SeriesChartType.Column;

            //是否显示数值
            chart1.Series[0].IsValueShownAsLabel = false;
            beltw.chart2.Series[0].IsValueShownAsLabel = true;
            //X轴数据显示间隔
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            //直角坐标显示,
            chart1.ChartAreas[0].Area3DStyle.IsRightAngleAxes = false;
            chart1.ChartAreas[0].AxisY.Title = "百分比";
            chart1.ChartAreas[0].AxisX.Title = "皮带横向分布";
            //是否群集在一起
            chart1.ChartAreas[0].Area3DStyle.IsClustered = false;
            //指定柱形条的颜色
            chart1.Series[0].Color = Color.Green;
            //柱状图的名字
            chart1.Series[0].Name = "皮带使用率";
            chart1.Series[0]["DrawingStyle"] = "Emboss";   //设置柱状平面形状
            chart1.Series[0]["PointWidth"] = "0.8"; //设置柱状大小
                                                    //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{yyyy-MM-dd hh:mm:ss}";
            beltw.chart2.Series.Add(s1);
            Title t = new Title("UV面漆滚涂生产线日利用率监测图");
            t.Font = new System.Drawing.Font("宋体", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            beltw.chart2.Titles.Add(t);
            
            Title t1 = new Title("UV面漆滚涂生产线日利用率监测图");
            t1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chart1.Titles.Add(t1);
            //是否启用3D显示
            beltw.chart2.ChartAreas[0].Area3DStyle.Enable3D = false;

            //显示类型,可以是柱形 折线等等
            beltw.chart2.Series[0].ChartType = SeriesChartType.Column;

            //是否显示数值
            beltw.chart2.Series[0].IsValueShownAsLabel = false;
            chart1.ChartAreas[0].AxisY.Interval = 10;
            beltw.chart2.ChartAreas[0].AxisY.Interval = 10;
            //X轴数据显示间隔
            beltw.chart2.ChartAreas[0].AxisX.Interval = 1;
            beltw.chart2.ChartAreas[0].AxisX.Title = "皮带横向分布";
            beltw.chart2.ChartAreas[0].AxisY.Title = "百分比";
            beltw.chart2.ChartAreas[0].AxisY.Maximum = 100;
            
            beltw.chart2.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            beltw.chart2.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            beltw.chart2.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            beltw.chart2.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("楷体", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            //直角坐标显示,
            beltw.chart2.ChartAreas[0].Area3DStyle.IsRightAngleAxes = false;

            //是否群集在一起
            beltw.chart2.ChartAreas[0].Area3DStyle.IsClustered = false;
            //指定柱形条的颜色
            beltw.chart2.Series[0].Color = Color.Green;
            //柱状图的名字
            beltw.chart2.Series[0].Name = "皮带使用率";
            beltw.chart2.Series[0]["DrawingStyle"] = "Emboss";   //设置柱状平面形状
            beltw.chart2.Series[0]["PointWidth"] = "0.8"; //设置柱状大小
            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{yyyy-MM-dd hh:mm:ss}";

        }

        Random random = new Random(0);
        ArrayList datalist = new ArrayList();
        /// <summary>
        /// 输送线里程
        /// </summary>
        public int BeltLenght = 28000;
        /// <summary>
        /// 开始时间
        /// </summary>
        public string TimeZoneStart = "yyyy-MM-dd 00:01:00";
        /// <summary>
        /// 截止时间
        /// </summary>
        public string TimeZoneFinish = "yyyy-MM-dd 23:59:00";

        //是否启用局部放大,FALSE--未启用
        bool flag = false;
        /// <summary>
        /// 曲线数据刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
       
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            

            try
            {if (TimeZoneStart =="yyyy-MM-dd 00:01:00")
                {
                    var dt = Env.DB.ReadDataTable($"Select Index_Int,(sum(BoardLength_Dec))/{BeltLenght} as BoardLength_Dec from app_beltoperation  where Index_Int>1 and Index_Int<29 and  CreateTime_Dt between '{DateTime.Now.ToString(TimeZoneStart)}' and '{DateTime.Now.ToString(TimeZoneFinish)}' group by Index_Int");
                    chart1.DataSource = dt;
                    beltw.chart2.DataSource = dt;
                   
                }
                chart1.Series[0].XValueMember = "Index_Int";
                chart1.Series[0].YValueMembers = "BoardLength_Dec";
                chart1.Refresh();
                if (beltw.chart2 != null)
                {

                    beltw.chart2.Series[0].XValueMember = "Index_Int";
                    beltw.chart2.Series[0].YValueMembers = "BoardLength_Dec";
                    //beltw.chart2.Series[0]. = 
                    beltw.chart2.Refresh();
                }
           }
           catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
            }

        }
        /// <summary>
        /// 区间查询，查询区间时间内的使用率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      
        private void btQueryStatus_Click(object sender, EventArgs e)
        {
            DateTime secondDate = DateTime.Parse(Convert.ToString(dTPRunStatusStop.Value));
            DateTime fistDate = DateTime.Parse(Convert.ToString(dTPRunStatusBegin.Value));
            TimeSpan ts = secondDate.Subtract(fistDate);
            int days = ts.Days;
            BeltLenght = 48000 * days;
            TimeZoneStart = Convert.ToString(dTPRunStatusBegin.Value);
            TimeZoneFinish = Convert.ToString(dTPRunStatusStop.Value);
            var dt = Env.DB.ReadDataTable($"Select Index_Int,(sum(BoardLength_Dec))/{BeltLenght} as BoardLength_Dec from app_beltoperation  where Index_Int>1 and Index_Int<29 and  CreateTime_Dt between '{DateTime.Now.ToString(TimeZoneStart)}' and '{DateTime.Now.ToString(TimeZoneFinish)}' group by Index_Int");
            chart1.DataSource = dt;
            beltw.chart2.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BeltLenght = 28000;
            TimeZoneStart = "yyyy-MM-dd 00:01:00";
            TimeZoneFinish = "yyyy-MM-dd 23:59:00";
            chart1.Titles.Clear();
            Title t1 = new Title("UV面漆滚涂生产线日利用率监测图");
            t1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chart1.Titles.Add(t1);
            beltw.chart2.Titles.Clear();
            Title t = new Title("UV面漆滚涂生产线日利用率监测图");
            t.Font = new System.Drawing.Font("宋体", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            beltw.chart2.Titles.Add(t);


        }




        
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dk = DateTime.Now;
            dk.AddDays(-30D);

            BeltLenght = 48000 * 30;
            TimeZoneStart = "dk";
            TimeZoneFinish = "yyyy-MM-dd 23:59:00";
            var dt = Env.DB.ReadDataTable($"Select Index_Int,(sum(BoardLength_Dec))/{BeltLenght} as BoardLength_Dec from app_beltoperation  where Index_Int>1 and Index_Int<30 and  CreateTime_Dt between '{DateTime.Now.ToString(TimeZoneStart)}' and '{DateTime.Now.ToString(TimeZoneFinish)}' group by Index_Int");
          
            chart1.DataSource = dt;
        
       
            beltw.chart2.DataSource = dt;
            chart1.Titles.Clear();
            Title t1 = new Title("UV面漆滚涂生产线月利用率监测图");
            t1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chart1.Titles.Add(t1);
            beltw.chart2.Titles.Clear();
            Title t = new Title("UV面漆滚涂生产线月利用率监测图");
            t.Font = new System.Drawing.Font("宋体", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            beltw.chart2.Titles.Add(t);

        }
        public decimal LineSpeed;
        public decimal PaintDosage;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int PLC_CHH;
        //int LineSpeed1;
            PLC_CHH = PublicValue.BaseProtocol.ListenReg["DB99.DBW238"].Short;
            //LineSpeed1 = PublicValue.BaseProtocol.ListenReg["DB99.DBW420"].Short;
             CH_HI.Text = Convert.ToString(Convert.ToDecimal(PLC_CHH) / 100);
            LineSpeed = Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW420"].Short) / 100;
            PaintDosage= Convert.ToDecimal(PublicValue.BaseProtocol.ListenReg["DB99.DBW244"].Short) / 100;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Count() != 1)
            {

                beltw.Left = Screen.AllScreens[0].Bounds.Width;
                beltw.Top = 0;
                beltw.Size = new System.Drawing.Size(Screen.AllScreens[1].Bounds.Width, Screen.AllScreens[1].Bounds.Height);
                beltw.Show();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
