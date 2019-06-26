namespace TcpDemo
{
    partial class A0主画面
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A0主画面));
            this.label1 = new System.Windows.Forms.Label();
            this.TimerReadClose = new System.Windows.Forms.Timer(this.components);
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gxbControl = new System.Windows.Forms.GroupBox();
            this.labMesg = new System.Windows.Forms.Label();
            this.btn_Ready = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labRunStatus = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gxbColor = new System.Windows.Forms.GroupBox();
            this.cmbColorChoose = new System.Windows.Forms.ComboBox();
            this.gxbQuXianDisplay = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gxbAreas = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CH_HI_Monitor = new System.Windows.Forms.Label();
            this.CH_HI = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dTPRunStatusStop = new System.Windows.Forms.DateTimePicker();
            this.dTPRunStatusBegin = new System.Windows.Forms.DateTimePicker();
            this.btQueryStatus = new System.Windows.Forms.Button();
            this.txbAreaNight = new System.Windows.Forms.Label();
            this.txbAreaMonth = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txbAreaDay = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gxbParaSetting = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.txbHeightValue = new System.Windows.Forms.NumericUpDown();
            this.AutoHeightTest = new System.Windows.Forms.NumericUpDown();
            this.txbProtectTime = new System.Windows.Forms.NumericUpDown();
            this.btnHeightBiaoDing = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labProtectTime = new System.Windows.Forms.Label();
            this.chbTiaomachoice = new System.Windows.Forms.CheckBox();
            this.chbAutoTestHeight = new System.Windows.Forms.CheckBox();
            this.chbAutomation = new System.Windows.Forms.CheckBox();
            this.chbCheck = new System.Windows.Forms.CheckBox();
            this.txbSpeedWrite = new System.Windows.Forms.NumericUpDown();
            this.lblSpeedInput = new System.Windows.Forms.Label();
            this.txbInputHeight = new System.Windows.Forms.NumericUpDown();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gxbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gxbColor.SuspendLayout();
            this.gxbQuXianDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gxbAreas.SuspendLayout();
            this.gxbParaSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbHeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoHeightTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbProtectTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSpeedWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbInputHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "主画面";
            // 
            // TimerReadClose
            // 
            this.TimerReadClose.Interval = 800;
            this.TimerReadClose.Tick += new System.EventHandler(this.TimerReadClose_Tick_1);
            // 
            // splitMain
            // 
            this.splitMain.BackColor = System.Drawing.Color.Gray;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AutoScroll = true;
            this.splitMain.Panel1.BackColor = System.Drawing.Color.White;
            this.splitMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitMain.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.AutoScroll = true;
            this.splitMain.Panel2.BackColor = System.Drawing.Color.White;
            this.splitMain.Panel2.Font = new System.Drawing.Font("宋体", 5F);
            this.splitMain.Size = new System.Drawing.Size(1626, 860);
            this.splitMain.SplitterDistance = 810;
            this.splitMain.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gxbControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("宋体", 12F);
            this.splitContainer1.Size = new System.Drawing.Size(1626, 810);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 43;
            // 
            // gxbControl
            // 
            this.gxbControl.BackColor = System.Drawing.Color.LightGray;
            this.gxbControl.Controls.Add(this.labMesg);
            this.gxbControl.Controls.Add(this.btn_Ready);
            this.gxbControl.Controls.Add(this.label5);
            this.gxbControl.Controls.Add(this.btn_Reset);
            this.gxbControl.Controls.Add(this.label4);
            this.gxbControl.Controls.Add(this.btn_Stop);
            this.gxbControl.Controls.Add(this.label3);
            this.gxbControl.Controls.Add(this.btn_Run);
            this.gxbControl.Controls.Add(this.label2);
            this.gxbControl.Controls.Add(this.labRunStatus);
            this.gxbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxbControl.Font = new System.Drawing.Font("宋体", 14F);
            this.gxbControl.Location = new System.Drawing.Point(0, 0);
            this.gxbControl.Margin = new System.Windows.Forms.Padding(2);
            this.gxbControl.Name = "gxbControl";
            this.gxbControl.Padding = new System.Windows.Forms.Padding(2);
            this.gxbControl.Size = new System.Drawing.Size(138, 810);
            this.gxbControl.TabIndex = 42;
            this.gxbControl.TabStop = false;
            this.gxbControl.Text = "总线控制";
            // 
            // labMesg
            // 
            this.labMesg.AutoSize = true;
            this.labMesg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labMesg.Font = new System.Drawing.Font("宋体", 8F);
            this.labMesg.Location = new System.Drawing.Point(2, 682);
            this.labMesg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMesg.Name = "labMesg";
            this.labMesg.Size = new System.Drawing.Size(70, 126);
            this.labMesg.TabIndex = 0;
            this.labMesg.Text = "状态指示\r\n\r\n运行:绿色\r\n\r\n停机:黄色\r\n\r\n报警:红色\r\n\r\n断线:灰色";
            this.labMesg.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btn_Ready
            // 
            this.btn_Ready.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Ready.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ready.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_Ready.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ready.Location = new System.Drawing.Point(2, 400);
            this.btn_Ready.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(134, 90);
            this.btn_Ready.TabIndex = 39;
            this.btn_Ready.Text = "待机";
            this.btn_Ready.UseVisualStyleBackColor = false;
            this.btn_Ready.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Run_MouseDown);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(2, 390);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 10);
            this.label5.TabIndex = 44;
            this.label5.Text = "     ";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Reset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Reset.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reset.Location = new System.Drawing.Point(2, 300);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(134, 90);
            this.btn_Reset.TabIndex = 38;
            this.btn_Reset.Text = "复位";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Run_MouseDown);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(2, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 10);
            this.label4.TabIndex = 43;
            this.label4.Text = "     ";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Stop.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Stop.Location = new System.Drawing.Point(2, 200);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(134, 90);
            this.btn_Stop.TabIndex = 37;
            this.btn_Stop.Text = "停止";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Run_MouseDown);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(2, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 10);
            this.label3.TabIndex = 42;
            this.label3.Text = "     ";
            // 
            // btn_Run
            // 
            this.btn_Run.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Run.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Run.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_Run.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Run.Location = new System.Drawing.Point(2, 100);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(134, 90);
            this.btn_Run.TabIndex = 36;
            this.btn_Run.Text = "启动";
            this.btn_Run.UseVisualStyleBackColor = false;
            this.btn_Run.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Run_MouseDown);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(2, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 10);
            this.label2.TabIndex = 41;
            this.label2.Text = "     ";
            // 
            // labRunStatus
            // 
            this.labRunStatus.BackColor = System.Drawing.Color.White;
            this.labRunStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.labRunStatus.Font = new System.Drawing.Font("宋体", 16F);
            this.labRunStatus.Location = new System.Drawing.Point(2, 29);
            this.labRunStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRunStatus.Name = "labRunStatus";
            this.labRunStatus.Size = new System.Drawing.Size(134, 61);
            this.labRunStatus.TabIndex = 40;
            this.labRunStatus.Text = "运行状态";
            this.labRunStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gxbColor);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("宋体", 10F);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gxbQuXianDisplay);
            this.splitContainer2.Panel2.Controls.Add(this.gxbAreas);
            this.splitContainer2.Panel2.Controls.Add(this.gxbParaSetting);
            this.splitContainer2.Size = new System.Drawing.Size(1484, 810);
            this.splitContainer2.SplitterDistance = 380;
            this.splitContainer2.TabIndex = 23;
            // 
            // gxbColor
            // 
            this.gxbColor.BackColor = System.Drawing.Color.Silver;
            this.gxbColor.Controls.Add(this.cmbColorChoose);
            this.gxbColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.gxbColor.Font = new System.Drawing.Font("宋体", 10F);
            this.gxbColor.Location = new System.Drawing.Point(0, 0);
            this.gxbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gxbColor.Name = "gxbColor";
            this.gxbColor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gxbColor.Size = new System.Drawing.Size(138, 380);
            this.gxbColor.TabIndex = 25;
            this.gxbColor.TabStop = false;
            this.gxbColor.Text = "相机颜色选择";
            // 
            // cmbColorChoose
            // 
            this.cmbColorChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbColorChoose.FormattingEnabled = true;
            this.cmbColorChoose.Items.AddRange(new object[] {
            "浅色系--白色",
            "深色系--空",
            "深色系--红色",
            "深色系--棕黄色"});
            this.cmbColorChoose.Location = new System.Drawing.Point(4, 24);
            this.cmbColorChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbColorChoose.MaxLength = 30;
            this.cmbColorChoose.Name = "cmbColorChoose";
            this.cmbColorChoose.Size = new System.Drawing.Size(130, 25);
            this.cmbColorChoose.TabIndex = 25;
            this.cmbColorChoose.Text = "请选择色系";
            this.cmbColorChoose.SelectedIndexChanged += new System.EventHandler(this.cmbColorChoose_SelectedIndexChanged);
            // 
            // gxbQuXianDisplay
            // 
            this.gxbQuXianDisplay.Controls.Add(this.chart1);
            this.gxbQuXianDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxbQuXianDisplay.Location = new System.Drawing.Point(811, 0);
            this.gxbQuXianDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.gxbQuXianDisplay.Name = "gxbQuXianDisplay";
            this.gxbQuXianDisplay.Padding = new System.Windows.Forms.Padding(2);
            this.gxbQuXianDisplay.Size = new System.Drawing.Size(673, 426);
            this.gxbQuXianDisplay.TabIndex = 23;
            this.gxbQuXianDisplay.TabStop = false;
            this.gxbQuXianDisplay.Text = "皮带使用率显示";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(8, 26);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(663, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // gxbAreas
            // 
            this.gxbAreas.Controls.Add(this.button2);
            this.gxbAreas.Controls.Add(this.CH_HI_Monitor);
            this.gxbAreas.Controls.Add(this.CH_HI);
            this.gxbAreas.Controls.Add(this.button1);
            this.gxbAreas.Controls.Add(this.dTPRunStatusStop);
            this.gxbAreas.Controls.Add(this.dTPRunStatusBegin);
            this.gxbAreas.Controls.Add(this.btQueryStatus);
            this.gxbAreas.Controls.Add(this.txbAreaNight);
            this.gxbAreas.Controls.Add(this.txbAreaMonth);
            this.gxbAreas.Controls.Add(this.label17);
            this.gxbAreas.Controls.Add(this.txbAreaDay);
            this.gxbAreas.Controls.Add(this.label18);
            this.gxbAreas.Controls.Add(this.label19);
            this.gxbAreas.Dock = System.Windows.Forms.DockStyle.Left;
            this.gxbAreas.Location = new System.Drawing.Point(350, 0);
            this.gxbAreas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gxbAreas.Name = "gxbAreas";
            this.gxbAreas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gxbAreas.Size = new System.Drawing.Size(461, 426);
            this.gxbAreas.TabIndex = 22;
            this.gxbAreas.TabStop = false;
            this.gxbAreas.Text = "面积统计";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(210, 327);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 35);
            this.button2.TabIndex = 352;
            this.button2.Text = "月使用率";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CH_HI_Monitor
            // 
            this.CH_HI_Monitor.AutoSize = true;
            this.CH_HI_Monitor.Font = new System.Drawing.Font("宋体", 12F);
            this.CH_HI_Monitor.Location = new System.Drawing.Point(126, 209);
            this.CH_HI_Monitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH_HI_Monitor.Name = "CH_HI_Monitor";
            this.CH_HI_Monitor.Size = new System.Drawing.Size(99, 20);
            this.CH_HI_Monitor.TabIndex = 350;
            this.CH_HI_Monitor.Text = "测厚高度:";
            this.CH_HI_Monitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CH_HI
            // 
            this.CH_HI.AutoSize = true;
            this.CH_HI.Font = new System.Drawing.Font("宋体", 14F);
            this.CH_HI.Location = new System.Drawing.Point(231, 205);
            this.CH_HI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CH_HI.Name = "CH_HI";
            this.CH_HI.Size = new System.Drawing.Size(70, 24);
            this.CH_HI.TabIndex = 351;
            this.CH_HI.Text = "000.0";
            this.CH_HI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(210, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "当天使用率";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dTPRunStatusStop
            // 
            this.dTPRunStatusStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dTPRunStatusStop.Font = new System.Drawing.Font("宋体", 10F);
            this.dTPRunStatusStop.Location = new System.Drawing.Point(6, 391);
            this.dTPRunStatusStop.Margin = new System.Windows.Forms.Padding(2);
            this.dTPRunStatusStop.Name = "dTPRunStatusStop";
            this.dTPRunStatusStop.Size = new System.Drawing.Size(158, 27);
            this.dTPRunStatusStop.TabIndex = 29;
            this.dTPRunStatusStop.Value = new System.DateTime(2019, 4, 29, 0, 0, 0, 0);
            // 
            // dTPRunStatusBegin
            // 
            this.dTPRunStatusBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dTPRunStatusBegin.Font = new System.Drawing.Font("宋体", 10F);
            this.dTPRunStatusBegin.Location = new System.Drawing.Point(10, 333);
            this.dTPRunStatusBegin.Margin = new System.Windows.Forms.Padding(2);
            this.dTPRunStatusBegin.Name = "dTPRunStatusBegin";
            this.dTPRunStatusBegin.Size = new System.Drawing.Size(158, 27);
            this.dTPRunStatusBegin.TabIndex = 30;
            this.dTPRunStatusBegin.Value = new System.DateTime(2019, 1, 18, 11, 46, 0, 0);
            // 
            // btQueryStatus
            // 
            this.btQueryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btQueryStatus.Font = new System.Drawing.Font("宋体", 10F);
            this.btQueryStatus.Location = new System.Drawing.Point(210, 383);
            this.btQueryStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQueryStatus.Name = "btQueryStatus";
            this.btQueryStatus.Size = new System.Drawing.Size(158, 35);
            this.btQueryStatus.TabIndex = 21;
            this.btQueryStatus.Text = "区间使用率查询";
            this.btQueryStatus.UseVisualStyleBackColor = true;
            this.btQueryStatus.Click += new System.EventHandler(this.btQueryStatus_Click);
            // 
            // txbAreaNight
            // 
            this.txbAreaNight.AutoSize = true;
            this.txbAreaNight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAreaNight.Font = new System.Drawing.Font("宋体", 16F);
            this.txbAreaNight.Location = new System.Drawing.Point(235, 99);
            this.txbAreaNight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txbAreaNight.Name = "txbAreaNight";
            this.txbAreaNight.Size = new System.Drawing.Size(112, 29);
            this.txbAreaNight.TabIndex = 20;
            this.txbAreaNight.Text = "       ";
            // 
            // txbAreaMonth
            // 
            this.txbAreaMonth.AutoSize = true;
            this.txbAreaMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAreaMonth.Font = new System.Drawing.Font("宋体", 16F);
            this.txbAreaMonth.Location = new System.Drawing.Point(235, 151);
            this.txbAreaMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txbAreaMonth.Name = "txbAreaMonth";
            this.txbAreaMonth.Size = new System.Drawing.Size(112, 29);
            this.txbAreaMonth.TabIndex = 19;
            this.txbAreaMonth.Text = "       ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F);
            this.label17.Location = new System.Drawing.Point(5, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(229, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "白班产量(00:00~17:30):";
            // 
            // txbAreaDay
            // 
            this.txbAreaDay.AutoSize = true;
            this.txbAreaDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAreaDay.Font = new System.Drawing.Font("宋体", 16F);
            this.txbAreaDay.Location = new System.Drawing.Point(235, 49);
            this.txbAreaDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txbAreaDay.Name = "txbAreaDay";
            this.txbAreaDay.Size = new System.Drawing.Size(112, 29);
            this.txbAreaDay.TabIndex = 18;
            this.txbAreaDay.Text = "       ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F);
            this.label18.Location = new System.Drawing.Point(5, 101);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(229, 20);
            this.label18.TabIndex = 8;
            this.label18.Text = "晚班产量(17:30~23:59):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F);
            this.label19.Location = new System.Drawing.Point(6, 154);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 20);
            this.label19.TabIndex = 10;
            this.label19.Text = "当月产量(01日~31日):";
            // 
            // gxbParaSetting
            // 
            this.gxbParaSetting.Controls.Add(this.btnSave);
            this.gxbParaSetting.Controls.Add(this.btnEditor);
            this.gxbParaSetting.Controls.Add(this.txbHeightValue);
            this.gxbParaSetting.Controls.Add(this.AutoHeightTest);
            this.gxbParaSetting.Controls.Add(this.txbProtectTime);
            this.gxbParaSetting.Controls.Add(this.btnHeightBiaoDing);
            this.gxbParaSetting.Controls.Add(this.label6);
            this.gxbParaSetting.Controls.Add(this.label7);
            this.gxbParaSetting.Controls.Add(this.labProtectTime);
            this.gxbParaSetting.Controls.Add(this.chbTiaomachoice);
            this.gxbParaSetting.Controls.Add(this.chbAutoTestHeight);
            this.gxbParaSetting.Controls.Add(this.chbAutomation);
            this.gxbParaSetting.Controls.Add(this.chbCheck);
            this.gxbParaSetting.Controls.Add(this.txbSpeedWrite);
            this.gxbParaSetting.Controls.Add(this.lblSpeedInput);
            this.gxbParaSetting.Controls.Add(this.txbInputHeight);
            this.gxbParaSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.gxbParaSetting.Location = new System.Drawing.Point(0, 0);
            this.gxbParaSetting.Margin = new System.Windows.Forms.Padding(2);
            this.gxbParaSetting.Name = "gxbParaSetting";
            this.gxbParaSetting.Padding = new System.Windows.Forms.Padding(2);
            this.gxbParaSetting.Size = new System.Drawing.Size(350, 426);
            this.gxbParaSetting.TabIndex = 15;
            this.gxbParaSetting.TabStop = false;
            this.gxbParaSetting.Text = "参数设置";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(226, 382);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 39);
            this.btnSave.TabIndex = 326;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(10, 382);
            this.btnEditor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(108, 39);
            this.btnEditor.TabIndex = 325;
            this.btnEditor.Text = "编辑";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbHeightValue
            // 
            this.txbHeightValue.DecimalPlaces = 1;
            this.txbHeightValue.Enabled = false;
            this.txbHeightValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txbHeightValue.Location = new System.Drawing.Point(192, 70);
            this.txbHeightValue.Margin = new System.Windows.Forms.Padding(2);
            this.txbHeightValue.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txbHeightValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.txbHeightValue.Name = "txbHeightValue";
            this.txbHeightValue.Size = new System.Drawing.Size(142, 30);
            this.txbHeightValue.TabIndex = 324;
            this.txbHeightValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AutoHeightTest
            // 
            this.AutoHeightTest.DecimalPlaces = 1;
            this.AutoHeightTest.Enabled = false;
            this.AutoHeightTest.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AutoHeightTest.Location = new System.Drawing.Point(192, 21);
            this.AutoHeightTest.Margin = new System.Windows.Forms.Padding(2);
            this.AutoHeightTest.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.AutoHeightTest.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            65536});
            this.AutoHeightTest.Name = "AutoHeightTest";
            this.AutoHeightTest.Size = new System.Drawing.Size(142, 30);
            this.AutoHeightTest.TabIndex = 323;
            this.AutoHeightTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AutoHeightTest.Value = new decimal(new int[] {
            500,
            0,
            0,
            65536});
            // 
            // txbProtectTime
            // 
            this.txbProtectTime.DecimalPlaces = 1;
            this.txbProtectTime.Enabled = false;
            this.txbProtectTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txbProtectTime.Location = new System.Drawing.Point(192, 240);
            this.txbProtectTime.Margin = new System.Windows.Forms.Padding(2);
            this.txbProtectTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.txbProtectTime.Name = "txbProtectTime";
            this.txbProtectTime.Size = new System.Drawing.Size(142, 30);
            this.txbProtectTime.TabIndex = 322;
            this.txbProtectTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbProtectTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // btnHeightBiaoDing
            // 
            this.btnHeightBiaoDing.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHeightBiaoDing.Enabled = false;
            this.btnHeightBiaoDing.Location = new System.Drawing.Point(192, 185);
            this.btnHeightBiaoDing.Margin = new System.Windows.Forms.Padding(2);
            this.btnHeightBiaoDing.Name = "btnHeightBiaoDing";
            this.btnHeightBiaoDing.Size = new System.Drawing.Size(142, 44);
            this.btnHeightBiaoDing.TabIndex = 321;
            this.btnHeightBiaoDing.Text = "测厚基面标定";
            this.btnHeightBiaoDing.UseVisualStyleBackColor = false;
            this.btnHeightBiaoDing.Click += new System.EventHandler(this.btnHeightBiaoDing_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 22);
            this.label6.TabIndex = 320;
            this.label6.Text = "未启用滚高度(mm):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 22);
            this.label7.TabIndex = 318;
            this.label7.Text = "测厚高度补偿(mm):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labProtectTime
            // 
            this.labProtectTime.Location = new System.Drawing.Point(4, 245);
            this.labProtectTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labProtectTime.Name = "labProtectTime";
            this.labProtectTime.Size = new System.Drawing.Size(161, 22);
            this.labProtectTime.TabIndex = 316;
            this.labProtectTime.Text = "信号延时(S):";
            this.labProtectTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chbTiaomachoice
            // 
            this.chbTiaomachoice.AutoSize = true;
            this.chbTiaomachoice.Enabled = false;
            this.chbTiaomachoice.Font = new System.Drawing.Font("宋体", 14F);
            this.chbTiaomachoice.Location = new System.Drawing.Point(12, 150);
            this.chbTiaomachoice.Margin = new System.Windows.Forms.Padding(2);
            this.chbTiaomachoice.Name = "chbTiaomachoice";
            this.chbTiaomachoice.Size = new System.Drawing.Size(128, 28);
            this.chbTiaomachoice.TabIndex = 313;
            this.chbTiaomachoice.Text = "扫码功能";
            this.chbTiaomachoice.UseVisualStyleBackColor = true;
            this.chbTiaomachoice.CheckedChanged += new System.EventHandler(this.chbCheck_CheckedChanged);
            // 
            // chbAutoTestHeight
            // 
            this.chbAutoTestHeight.AutoSize = true;
            this.chbAutoTestHeight.Enabled = false;
            this.chbAutoTestHeight.Font = new System.Drawing.Font("宋体", 14F);
            this.chbAutoTestHeight.Location = new System.Drawing.Point(12, 192);
            this.chbAutoTestHeight.Margin = new System.Windows.Forms.Padding(2);
            this.chbAutoTestHeight.Name = "chbAutoTestHeight";
            this.chbAutoTestHeight.Size = new System.Drawing.Size(128, 28);
            this.chbAutoTestHeight.TabIndex = 311;
            this.chbAutoTestHeight.Text = "测厚功能";
            this.chbAutoTestHeight.UseVisualStyleBackColor = true;
            this.chbAutoTestHeight.CheckedChanged += new System.EventHandler(this.chbCheck_CheckedChanged);
            // 
            // chbAutomation
            // 
            this.chbAutomation.AutoSize = true;
            this.chbAutomation.Enabled = false;
            this.chbAutomation.Font = new System.Drawing.Font("宋体", 14F);
            this.chbAutomation.Location = new System.Drawing.Point(12, 112);
            this.chbAutomation.Margin = new System.Windows.Forms.Padding(2);
            this.chbAutomation.Name = "chbAutomation";
            this.chbAutomation.Size = new System.Drawing.Size(128, 28);
            this.chbAutomation.TabIndex = 312;
            this.chbAutomation.Text = "柔性功能";
            this.chbAutomation.UseVisualStyleBackColor = true;
            this.chbAutomation.CheckedChanged += new System.EventHandler(this.chbCheck_CheckedChanged);
            // 
            // chbCheck
            // 
            this.chbCheck.AutoSize = true;
            this.chbCheck.Enabled = false;
            this.chbCheck.Font = new System.Drawing.Font("宋体", 12F);
            this.chbCheck.Location = new System.Drawing.Point(10, 341);
            this.chbCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbCheck.Name = "chbCheck";
            this.chbCheck.Size = new System.Drawing.Size(161, 24);
            this.chbCheck.TabIndex = 2;
            this.chbCheck.Text = "测厚值/输入值";
            this.chbCheck.UseVisualStyleBackColor = true;
            this.chbCheck.CheckedChanged += new System.EventHandler(this.chbCheck_CheckedChanged);
            // 
            // txbSpeedWrite
            // 
            this.txbSpeedWrite.DecimalPlaces = 1;
            this.txbSpeedWrite.Enabled = false;
            this.txbSpeedWrite.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txbSpeedWrite.Location = new System.Drawing.Point(192, 289);
            this.txbSpeedWrite.Margin = new System.Windows.Forms.Padding(2);
            this.txbSpeedWrite.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txbSpeedWrite.Name = "txbSpeedWrite";
            this.txbSpeedWrite.Size = new System.Drawing.Size(142, 30);
            this.txbSpeedWrite.TabIndex = 14;
            this.txbSpeedWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSpeedWrite.Visible = false;
            // 
            // lblSpeedInput
            // 
            this.lblSpeedInput.AutoSize = true;
            this.lblSpeedInput.Font = new System.Drawing.Font("宋体", 12F);
            this.lblSpeedInput.Location = new System.Drawing.Point(4, 295);
            this.lblSpeedInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeedInput.Name = "lblSpeedInput";
            this.lblSpeedInput.Size = new System.Drawing.Size(169, 20);
            this.lblSpeedInput.TabIndex = 11;
            this.lblSpeedInput.Text = "整线速度(m/min):";
            this.lblSpeedInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbInputHeight
            // 
            this.txbInputHeight.DecimalPlaces = 1;
            this.txbInputHeight.Enabled = false;
            this.txbInputHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txbInputHeight.Location = new System.Drawing.Point(192, 339);
            this.txbInputHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txbInputHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txbInputHeight.Name = "txbInputHeight";
            this.txbInputHeight.Size = new System.Drawing.Size(142, 30);
            this.txbInputHeight.TabIndex = 13;
            this.txbInputHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Puretelogo.png");
            this.imageList1.Images.SetKeyName(1, "单灯干燥机.png");
            this.imageList1.Images.SetKeyName(2, "双灯干燥机.png");
            this.imageList1.Images.SetKeyName(3, "三灯干燥机.png");
            this.imageList1.Images.SetKeyName(4, "四灯干燥机.png");
            this.imageList1.Images.SetKeyName(5, "五灯UV干燥机.png");
            this.imageList1.Images.SetKeyName(6, "六灯干燥机.png");
            this.imageList1.Images.SetKeyName(7, "七灯UV干燥机.png");
            this.imageList1.Images.SetKeyName(8, "八灯UV干燥机.png");
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 15000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 15000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // A0主画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "A0主画面";
            this.Size = new System.Drawing.Size(1626, 860);
            this.splitMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gxbControl.ResumeLayout(false);
            this.gxbControl.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gxbColor.ResumeLayout(false);
            this.gxbQuXianDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gxbAreas.ResumeLayout(false);
            this.gxbAreas.PerformLayout();
            this.gxbParaSetting.ResumeLayout(false);
            this.gxbParaSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbHeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoHeightTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbProtectTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbSpeedWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbInputHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerReadClose;
        public System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.GroupBox gxbControl;
        public System.Windows.Forms.Label labRunStatus;
        public System.Windows.Forms.Button btn_Ready;
        public System.Windows.Forms.Button btn_Run;
        public System.Windows.Forms.Button btn_Stop;
        public System.Windows.Forms.Button btn_Reset;
        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labMesg;
        public System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.GroupBox gxbColor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.CheckBox chbCheck;
        public System.Windows.Forms.NumericUpDown txbInputHeight;
        public System.Windows.Forms.NumericUpDown txbSpeedWrite;
        private System.Windows.Forms.GroupBox gxbParaSetting;
        public System.Windows.Forms.CheckBox chbTiaomachoice;
        public System.Windows.Forms.CheckBox chbAutoTestHeight;
        public System.Windows.Forms.CheckBox chbAutomation;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labProtectTime;
        public System.Windows.Forms.Button btnHeightBiaoDing;
        public System.Windows.Forms.NumericUpDown txbHeightValue;
        public System.Windows.Forms.NumericUpDown AutoHeightTest;
        public System.Windows.Forms.NumericUpDown txbProtectTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditor;
        public System.Windows.Forms.ComboBox cmbColorChoose;
        public System.Windows.Forms.Label txbAreaNight;
        public System.Windows.Forms.Label txbAreaMonth;
        public System.Windows.Forms.Label txbAreaDay;
        public System.Windows.Forms.Label lblSpeedInput;
        private System.Windows.Forms.GroupBox gxbAreas;
        private System.Windows.Forms.GroupBox gxbQuXianDisplay;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dTPRunStatusBegin;
        private System.Windows.Forms.DateTimePicker dTPRunStatusStop;
        private System.Windows.Forms.Button btQueryStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CH_HI;
        public System.Windows.Forms.Label CH_HI_Monitor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
