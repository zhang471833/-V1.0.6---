namespace TcpDemo
{
    partial class A0参数设置
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A0参数设置));
            this.cbox_Machine = new System.Windows.Forms.ComboBox();
            this.gbox_Setting = new System.Windows.Forms.GroupBox();
            this.lb_MachineList = new System.Windows.Forms.ListBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.cbox_Communition_Num = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_RemoveMachine = new System.Windows.Forms.Button();
            this.btn_AddMachine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbox_Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_Machine
            // 
            this.cbox_Machine.FormattingEnabled = true;
            this.cbox_Machine.Items.AddRange(new object[] {
            "单灯UV干燥机",
            "双灯UV干燥机",
            "三灯UV干燥机",
            "四灯UV干燥机",
            "五灯UV干燥机",
            "六灯UV干燥机",
            "七灯UV干燥机",
            "八灯UV干燥机",
            "全精密除尘机",
            "抛光除尘机",
            "双面除尘机",
            "6M红外流平机",
            "4M红外流平机",
            "喷射式流平机",
            "全精密补土机",
            "全精密单滚涂布机",
            "全精密双滚涂布机",
            "全精密三滚涂布机",
            "补土+单滚涂布机",
            "补土+双滚涂布机",
            "正逆滚涂布机",
            "四级淋幕机",
            "单滚毛刷机",
            "双滚毛刷机",
            "龙门上料机",
            "龙门下料机",
            "底漆砂光机",
            "上浮式砂光机",
            "输送机"});
            this.cbox_Machine.Location = new System.Drawing.Point(6, 75);
            this.cbox_Machine.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_Machine.Name = "cbox_Machine";
            this.cbox_Machine.Size = new System.Drawing.Size(210, 31);
            this.cbox_Machine.TabIndex = 3;
            // 
            // gbox_Setting
            // 
            this.gbox_Setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbox_Setting.Controls.Add(this.lb_MachineList);
            this.gbox_Setting.Controls.Add(this.btnMoveDown);
            this.gbox_Setting.Controls.Add(this.btnMoveUp);
            this.gbox_Setting.Controls.Add(this.cbox_Communition_Num);
            this.gbox_Setting.Controls.Add(this.btn_Save);
            this.gbox_Setting.Controls.Add(this.btn_RemoveMachine);
            this.gbox_Setting.Controls.Add(this.btn_AddMachine);
            this.gbox_Setting.Controls.Add(this.label5);
            this.gbox_Setting.Controls.Add(this.label1);
            this.gbox_Setting.Controls.Add(this.cbox_Machine);
            this.gbox_Setting.Controls.Add(this.groupBox2);
            this.gbox_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_Setting.Font = new System.Drawing.Font("宋体", 14F);
            this.gbox_Setting.Location = new System.Drawing.Point(0, 0);
            this.gbox_Setting.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_Setting.Name = "gbox_Setting";
            this.gbox_Setting.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_Setting.Size = new System.Drawing.Size(1650, 650);
            this.gbox_Setting.TabIndex = 4;
            this.gbox_Setting.TabStop = false;
            this.gbox_Setting.Text = "方案配置";
            // 
            // lb_MachineList
            // 
            this.lb_MachineList.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_MachineList.Font = new System.Drawing.Font("宋体", 14F);
            this.lb_MachineList.FormattingEnabled = true;
            this.lb_MachineList.ItemHeight = 23;
            this.lb_MachineList.Location = new System.Drawing.Point(615, 29);
            this.lb_MachineList.Margin = new System.Windows.Forms.Padding(2);
            this.lb_MachineList.Name = "lb_MachineList";
            this.lb_MachineList.Size = new System.Drawing.Size(1033, 619);
            this.lb_MachineList.TabIndex = 5;
            this.lb_MachineList.SelectedIndexChanged += new System.EventHandler(this.lb_MachineList_SelectedIndexChanged);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Font = new System.Drawing.Font("宋体", 16F);
            this.btnMoveDown.Location = new System.Drawing.Point(399, 265);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(171, 44);
            this.btnMoveDown.TabIndex = 21;
            this.btnMoveDown.Text = "设备下移↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Font = new System.Drawing.Font("宋体", 16F);
            this.btnMoveUp.Location = new System.Drawing.Point(399, 192);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(171, 44);
            this.btnMoveUp.TabIndex = 22;
            this.btnMoveUp.Text = "设备上移↑";
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // cbox_Communition_Num
            // 
            this.cbox_Communition_Num.FormattingEnabled = true;
            this.cbox_Communition_Num.Items.AddRange(new object[] {
            "192.168.0.1",
            "192.168.0.2",
            "192.168.0.3",
            "192.168.0.4",
            "192.168.0.5",
            "192.168.0.6",
            "192.168.0.7",
            "192.168.0.8",
            "192.168.0.9",
            "192.168.0.10",
            "192.168.0.11",
            "192.168.0.12",
            "192.168.0.13",
            "192.168.0.14",
            "192.168.0.15",
            "192.168.0.16",
            "192.168.0.17",
            "192.168.0.18",
            "192.168.0.19",
            "192.168.0.20",
            "192.168.0.21",
            "192.168.0.22",
            "192.168.0.23",
            "192.168.0.24",
            "192.168.0.25",
            "192.168.0.26",
            "192.168.0.27",
            "192.168.0.28",
            "192.168.0.29",
            "192.168.0.30",
            "192.168.0.31",
            "192.168.0.32",
            "192.168.0.33",
            "192.168.0.34",
            "192.168.0.35",
            "192.168.0.36",
            "192.168.0.37",
            "192.168.0.38",
            "192.168.0.39",
            "192.168.0.40",
            "192.168.0.41",
            "192.168.0.42",
            "192.168.0.43",
            "192.168.0.44",
            "192.168.0.45",
            "192.168.0.46",
            "192.168.0.47",
            "192.168.0.48",
            "192.168.0.49",
            "192.168.0.50",
            "192.168.0.51",
            "192.168.0.52",
            "192.168.0.53",
            "192.168.0.54",
            "192.168.0.55",
            "192.168.0.56",
            "192.168.0.57",
            "192.168.0.58",
            "192.168.0.59",
            "192.168.0.60",
            "192.168.0.61",
            "192.168.0.62",
            "192.168.0.63",
            "192.168.0.64",
            "192.168.0.65",
            "192.168.0.66",
            "192.168.0.67",
            "192.168.0.68",
            "192.168.0.69",
            "192.168.0.70",
            "192.168.0.71",
            "192.168.0.72",
            "192.168.0.73",
            "192.168.0.74",
            "192.168.0.75",
            "192.168.0.76",
            "192.168.0.77",
            "192.168.0.78",
            "192.168.0.79",
            "192.168.0.80",
            "192.168.0.81",
            "192.168.0.82",
            "192.168.0.83",
            "192.168.0.84",
            "192.168.0.85",
            "192.168.0.86",
            "192.168.0.87",
            "192.168.0.88",
            "192.168.0.89",
            "192.168.0.90",
            "192.168.0.91",
            "192.168.0.92",
            "192.168.0.93",
            "192.168.0.94",
            "192.168.0.95",
            "192.168.0.96",
            "192.168.0.97",
            "192.168.0.98",
            "192.168.0.99",
            "192.168.0.100"});
            this.cbox_Communition_Num.Location = new System.Drawing.Point(6, 143);
            this.cbox_Communition_Num.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_Communition_Num.Name = "cbox_Communition_Num";
            this.cbox_Communition_Num.Size = new System.Drawing.Size(210, 31);
            this.cbox_Communition_Num.TabIndex = 15;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_Save.Location = new System.Drawing.Point(399, 338);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(171, 44);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "生成方案";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_RemoveMachine
            // 
            this.btn_RemoveMachine.Enabled = false;
            this.btn_RemoveMachine.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_RemoveMachine.Location = new System.Drawing.Point(399, 119);
            this.btn_RemoveMachine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RemoveMachine.Name = "btn_RemoveMachine";
            this.btn_RemoveMachine.Size = new System.Drawing.Size(171, 44);
            this.btn_RemoveMachine.TabIndex = 17;
            this.btn_RemoveMachine.Text = "移除设备←";
            this.btn_RemoveMachine.UseVisualStyleBackColor = true;
            this.btn_RemoveMachine.Click += new System.EventHandler(this.btn_RemoveMachine_Click);
            // 
            // btn_AddMachine
            // 
            this.btn_AddMachine.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_AddMachine.Location = new System.Drawing.Point(399, 46);
            this.btn_AddMachine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddMachine.Name = "btn_AddMachine";
            this.btn_AddMachine.Size = new System.Drawing.Size(171, 44);
            this.btn_AddMachine.TabIndex = 16;
            this.btn_AddMachine.Text = "添加设备→";
            this.btn_AddMachine.UseVisualStyleBackColor = true;
            this.btn_AddMachine.Click += new System.EventHandler(this.btn_AddMachine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "通讯站号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "设备规格选择";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(2, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(370, 619);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbox_Setting);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("宋体", 5F);
            this.splitContainer1.Size = new System.Drawing.Size(1650, 860);
            this.splitContainer1.SplitterDistance = 650;
            this.splitContainer1.TabIndex = 17;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "单灯干燥机.png");
            this.imageList1.Images.SetKeyName(1, "双灯干燥机.png");
            this.imageList1.Images.SetKeyName(2, "三灯干燥机.png");
            this.imageList1.Images.SetKeyName(3, "四灯干燥机.png");
            this.imageList1.Images.SetKeyName(4, "五灯UV干燥机.png");
            this.imageList1.Images.SetKeyName(5, "六灯干燥机.png");
            this.imageList1.Images.SetKeyName(6, "七灯UV干燥机.png");
            this.imageList1.Images.SetKeyName(7, "八灯UV干燥机.png");
            this.imageList1.Images.SetKeyName(8, "welcome.png");
            this.imageList1.Images.SetKeyName(9, "welcome.png");
            this.imageList1.Images.SetKeyName(10, "PRT-D1313粉尘清除机.png");
            this.imageList1.Images.SetKeyName(11, "PRT-D1313粉尘清除机.jpg");
            this.imageList1.Images.SetKeyName(12, "PRT-D1313粉尘清除机.jpg");
            this.imageList1.Images.SetKeyName(13, "PRT-D1313粉尘清除机.jpg");
            this.imageList1.Images.SetKeyName(14, "PRT-D1313粉尘清除机.jpg");
            this.imageList1.Images.SetKeyName(15, "6米红外流平机.png");
            this.imageList1.Images.SetKeyName(16, "6米红外流平机.png");
            this.imageList1.Images.SetKeyName(17, "6米红外流平机.png");
            this.imageList1.Images.SetKeyName(18, "6米红外流平机.png");
            this.imageList1.Images.SetKeyName(19, "PRT-I1613 6米红外线流平机.png");
            this.imageList1.Images.SetKeyName(20, "全精密单滚涂布机.png");
            this.imageList1.Images.SetKeyName(21, "全精密双滚涂布机.png");
            this.imageList1.Images.SetKeyName(22, "全精密三滚涂布机.png");
            this.imageList1.Images.SetKeyName(23, "全精密补土+单滚涂布机.png");
            this.imageList1.Images.SetKeyName(24, "全精密补土+双滚涂布机.png");
            this.imageList1.Images.SetKeyName(25, "全精密补土+单滚涂布机.png");
            this.imageList1.Images.SetKeyName(26, "全精密补土机.jpg");
            this.imageList1.Images.SetKeyName(27, "welcome.png");
            this.imageList1.Images.SetKeyName(28, "welcome.png");
            this.imageList1.Images.SetKeyName(29, "welcome.png");
            this.imageList1.Images.SetKeyName(30, "welcome.png");
            this.imageList1.Images.SetKeyName(31, "welcome.png");
            this.imageList1.Images.SetKeyName(32, "welcome.png");
            this.imageList1.Images.SetKeyName(33, "welcome.png");
            this.imageList1.Images.SetKeyName(34, "welcome.png");
            this.imageList1.Images.SetKeyName(35, "welcome.png");
            this.imageList1.Images.SetKeyName(36, "welcome.png");
            this.imageList1.Images.SetKeyName(37, "welcome.png");
            this.imageList1.Images.SetKeyName(38, "welcome.png");
            this.imageList1.Images.SetKeyName(39, "welcome.png");
            this.imageList1.Images.SetKeyName(40, "welcome.png");
            this.imageList1.Images.SetKeyName(41, "砂光机.jpg");
            this.imageList1.Images.SetKeyName(42, "砂光机.jpg");
            this.imageList1.Images.SetKeyName(43, "砂光机.jpg");
            this.imageList1.Images.SetKeyName(44, "砂光机.png");
            this.imageList1.Images.SetKeyName(45, "输送机.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // A0参数设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(45, 24, 45, 24);
            this.Name = "A0参数设置";
            this.Size = new System.Drawing.Size(1650, 860);
            this.Load += new System.EventHandler(this.A0参数设置_Load);
            this.SizeChanged += new System.EventHandler(this.A0参数设置_SizeChanged);
            this.gbox_Setting.ResumeLayout(false);
            this.gbox_Setting.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_Machine;
        private System.Windows.Forms.GroupBox gbox_Setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_Communition_Num;
        private System.Windows.Forms.Button btn_AddMachine;
        private System.Windows.Forms.Button btn_RemoveMachine;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListBox lb_MachineList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
    }
}
