namespace TcpDemo
{
    partial class A0砂光机
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbox_RecipeSetting = new System.Windows.Forms.GroupBox();
            this.chb_Fans3 = new System.Windows.Forms.CheckBox();
            this.labelTemp3 = new System.Windows.Forms.Label();
            this.txb_Control_Temp3 = new System.Windows.Forms.TextBox();
            this.labelFans3 = new System.Windows.Forms.Label();
            this.chb_Fans2 = new System.Windows.Forms.CheckBox();
            this.labelTemp2 = new System.Windows.Forms.Label();
            this.txb_Control_Temp2 = new System.Windows.Forms.TextBox();
            this.labelFans2 = new System.Windows.Forms.Label();
            this.chb_Fans1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_Control_Conveyor_Main = new System.Windows.Forms.TextBox();
            this.labelTemp1 = new System.Windows.Forms.Label();
            this.txb_Control_Temp1 = new System.Windows.Forms.TextBox();
            this.labelFans1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lab_Prt_NO = new System.Windows.Forms.Label();
            this.btn_Recipe_OK = new System.Windows.Forms.Button();
            this.btn_Recipe_Read = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_Recipe_Save = new System.Windows.Forms.Button();
            this.txb_Recipe_NO = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.gxb_Alarm = new System.Windows.Forms.GroupBox();
            this.lbMsg_Dialog = new System.Windows.Forms.ListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gxb_Monitor = new System.Windows.Forms.GroupBox();
            this.lab_Monitor_Temp3_Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Temp3 = new System.Windows.Forms.Label();
            this.labelTemp3Monitor = new System.Windows.Forms.Label();
            this.lab_Monitor_Temp2_Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Temp2 = new System.Windows.Forms.Label();
            this.labelTemp2Monitor = new System.Windows.Forms.Label();
            this.labelMonitorLine1Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Conveyor1_Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Conveyor1_Speed = new System.Windows.Forms.Label();
            this.labelMonitorLine1Speed = new System.Windows.Forms.Label();
            this.lab_Monitor_Temp1_Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Temp1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelTemp1Monitor = new System.Windows.Forms.Label();
            this.gxb_Machine = new System.Windows.Forms.GroupBox();
            this.Windows_Recyle = new System.Windows.Forms.Timer(this.components);
            this.timer_Excel = new System.Windows.Forms.Timer(this.components);
            this.TimerCloseRead = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbox_RecipeSetting.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gxb_Alarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gxb_Monitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1650, 700);
            this.splitContainer1.SplitterDistance = 830;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.gbox_RecipeSetting);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.gxb_Alarm);
            this.splitContainer2.Size = new System.Drawing.Size(830, 700);
            this.splitContainer2.SplitterDistance = 350;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbox_RecipeSetting
            // 
            this.gbox_RecipeSetting.BackColor = System.Drawing.Color.White;
            this.gbox_RecipeSetting.Controls.Add(this.chb_Fans3);
            this.gbox_RecipeSetting.Controls.Add(this.labelTemp3);
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Temp3);
            this.gbox_RecipeSetting.Controls.Add(this.labelFans3);
            this.gbox_RecipeSetting.Controls.Add(this.chb_Fans2);
            this.gbox_RecipeSetting.Controls.Add(this.labelTemp2);
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Temp2);
            this.gbox_RecipeSetting.Controls.Add(this.labelFans2);
            this.gbox_RecipeSetting.Controls.Add(this.chb_Fans1);
            this.gbox_RecipeSetting.Controls.Add(this.label11);
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Conveyor_Main);
            this.gbox_RecipeSetting.Controls.Add(this.labelTemp1);
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Temp1);
            this.gbox_RecipeSetting.Controls.Add(this.labelFans1);
            this.gbox_RecipeSetting.Controls.Add(this.groupBox4);
            this.gbox_RecipeSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_RecipeSetting.Font = new System.Drawing.Font("宋体", 14F);
            this.gbox_RecipeSetting.Location = new System.Drawing.Point(0, 0);
            this.gbox_RecipeSetting.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_RecipeSetting.Name = "gbox_RecipeSetting";
            this.gbox_RecipeSetting.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_RecipeSetting.Size = new System.Drawing.Size(830, 350);
            this.gbox_RecipeSetting.TabIndex = 253;
            this.gbox_RecipeSetting.TabStop = false;
            this.gbox_RecipeSetting.Text = "配方设定";
            // 
            // chb_Fans3
            // 
            this.chb_Fans3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_Fans3.Location = new System.Drawing.Point(480, 205);
            this.chb_Fans3.Margin = new System.Windows.Forms.Padding(2);
            this.chb_Fans3.Name = "chb_Fans3";
            this.chb_Fans3.Size = new System.Drawing.Size(114, 35);
            this.chb_Fans3.TabIndex = 391;
            this.chb_Fans3.Text = "风机开关";
            this.chb_Fans3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_Fans3.UseVisualStyleBackColor = true;
            // 
            // labelTemp3
            // 
            this.labelTemp3.AutoSize = true;
            this.labelTemp3.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTemp3.Location = new System.Drawing.Point(12, 212);
            this.labelTemp3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemp3.Name = "labelTemp3";
            this.labelTemp3.Size = new System.Drawing.Size(129, 20);
            this.labelTemp3.TabIndex = 389;
            this.labelTemp3.Text = "1#温度设定℃";
            this.labelTemp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Control_Temp3
            // 
            this.txb_Control_Temp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Temp3.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Temp3.Location = new System.Drawing.Point(196, 207);
            this.txb_Control_Temp3.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Temp3.Name = "txb_Control_Temp3";
            this.txb_Control_Temp3.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Temp3.TabIndex = 388;
            this.txb_Control_Temp3.Text = "0";
            this.txb_Control_Temp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFans3
            // 
            this.labelFans3.AutoSize = true;
            this.labelFans3.Font = new System.Drawing.Font("宋体", 12F);
            this.labelFans3.Location = new System.Drawing.Point(360, 212);
            this.labelFans3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFans3.Name = "labelFans3";
            this.labelFans3.Size = new System.Drawing.Size(69, 20);
            this.labelFans3.TabIndex = 390;
            this.labelFans3.Text = "3#风机";
            this.labelFans3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chb_Fans2
            // 
            this.chb_Fans2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_Fans2.Location = new System.Drawing.Point(480, 157);
            this.chb_Fans2.Margin = new System.Windows.Forms.Padding(2);
            this.chb_Fans2.Name = "chb_Fans2";
            this.chb_Fans2.Size = new System.Drawing.Size(114, 35);
            this.chb_Fans2.TabIndex = 387;
            this.chb_Fans2.Text = "风机开关";
            this.chb_Fans2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_Fans2.UseVisualStyleBackColor = true;
            // 
            // labelTemp2
            // 
            this.labelTemp2.AutoSize = true;
            this.labelTemp2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTemp2.Location = new System.Drawing.Point(12, 164);
            this.labelTemp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemp2.Name = "labelTemp2";
            this.labelTemp2.Size = new System.Drawing.Size(129, 20);
            this.labelTemp2.TabIndex = 385;
            this.labelTemp2.Text = "2#温度设定℃";
            this.labelTemp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Control_Temp2
            // 
            this.txb_Control_Temp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Temp2.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Temp2.Location = new System.Drawing.Point(196, 159);
            this.txb_Control_Temp2.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Temp2.Name = "txb_Control_Temp2";
            this.txb_Control_Temp2.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Temp2.TabIndex = 384;
            this.txb_Control_Temp2.Text = "0";
            this.txb_Control_Temp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFans2
            // 
            this.labelFans2.AutoSize = true;
            this.labelFans2.Font = new System.Drawing.Font("宋体", 12F);
            this.labelFans2.Location = new System.Drawing.Point(360, 164);
            this.labelFans2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFans2.Name = "labelFans2";
            this.labelFans2.Size = new System.Drawing.Size(69, 20);
            this.labelFans2.TabIndex = 386;
            this.labelFans2.Text = "2#风机";
            this.labelFans2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chb_Fans1
            // 
            this.chb_Fans1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_Fans1.Location = new System.Drawing.Point(480, 109);
            this.chb_Fans1.Margin = new System.Windows.Forms.Padding(2);
            this.chb_Fans1.Name = "chb_Fans1";
            this.chb_Fans1.Size = new System.Drawing.Size(114, 35);
            this.chb_Fans1.TabIndex = 383;
            this.chb_Fans1.Text = "风机开关";
            this.chb_Fans1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chb_Fans1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(12, 260);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 20);
            this.label11.TabIndex = 359;
            this.label11.Text = "输送线速度m/min";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Control_Conveyor_Main
            // 
            this.txb_Control_Conveyor_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Conveyor_Main.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Conveyor_Main.Location = new System.Drawing.Point(196, 255);
            this.txb_Control_Conveyor_Main.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Conveyor_Main.Name = "txb_Control_Conveyor_Main";
            this.txb_Control_Conveyor_Main.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Conveyor_Main.TabIndex = 366;
            this.txb_Control_Conveyor_Main.Text = "0";
            this.txb_Control_Conveyor_Main.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTemp1
            // 
            this.labelTemp1.AutoSize = true;
            this.labelTemp1.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTemp1.Location = new System.Drawing.Point(12, 116);
            this.labelTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemp1.Name = "labelTemp1";
            this.labelTemp1.Size = new System.Drawing.Size(129, 20);
            this.labelTemp1.TabIndex = 361;
            this.labelTemp1.Text = "1#温度设定℃";
            this.labelTemp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Control_Temp1
            // 
            this.txb_Control_Temp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Temp1.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Temp1.Location = new System.Drawing.Point(196, 111);
            this.txb_Control_Temp1.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Temp1.Name = "txb_Control_Temp1";
            this.txb_Control_Temp1.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Temp1.TabIndex = 358;
            this.txb_Control_Temp1.Text = "0";
            this.txb_Control_Temp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFans1
            // 
            this.labelFans1.AutoSize = true;
            this.labelFans1.Font = new System.Drawing.Font("宋体", 12F);
            this.labelFans1.Location = new System.Drawing.Point(360, 116);
            this.labelFans1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFans1.Name = "labelFans1";
            this.labelFans1.Size = new System.Drawing.Size(69, 20);
            this.labelFans1.TabIndex = 363;
            this.labelFans1.Text = "1#风机";
            this.labelFans1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.lab_Prt_NO);
            this.groupBox4.Controls.Add(this.btn_Recipe_OK);
            this.groupBox4.Controls.Add(this.btn_Recipe_Read);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.btn_Recipe_Save);
            this.groupBox4.Controls.Add(this.txb_Recipe_NO);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(2, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(826, 58);
            this.groupBox4.TabIndex = 346;
            this.groupBox4.TabStop = false;
            // 
            // lab_Prt_NO
            // 
            this.lab_Prt_NO.AutoSize = true;
            this.lab_Prt_NO.Font = new System.Drawing.Font("宋体", 16F);
            this.lab_Prt_NO.Location = new System.Drawing.Point(595, 16);
            this.lab_Prt_NO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Prt_NO.Name = "lab_Prt_NO";
            this.lab_Prt_NO.Size = new System.Drawing.Size(152, 27);
            this.lab_Prt_NO.TabIndex = 261;
            this.lab_Prt_NO.Text = "**********";
            this.lab_Prt_NO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Recipe_OK
            // 
            this.btn_Recipe_OK.BackColor = System.Drawing.Color.Red;
            this.btn_Recipe_OK.Location = new System.Drawing.Point(382, 8);
            this.btn_Recipe_OK.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Recipe_OK.Name = "btn_Recipe_OK";
            this.btn_Recipe_OK.Size = new System.Drawing.Size(92, 44);
            this.btn_Recipe_OK.TabIndex = 278;
            this.btn_Recipe_OK.Text = "确定";
            this.btn_Recipe_OK.UseVisualStyleBackColor = false;
            this.btn_Recipe_OK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Recipe_Save_MouseDown);
            // 
            // btn_Recipe_Read
            // 
            this.btn_Recipe_Read.BackColor = System.Drawing.Color.Red;
            this.btn_Recipe_Read.Location = new System.Drawing.Point(288, 8);
            this.btn_Recipe_Read.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Recipe_Read.Name = "btn_Recipe_Read";
            this.btn_Recipe_Read.Size = new System.Drawing.Size(92, 44);
            this.btn_Recipe_Read.TabIndex = 277;
            this.btn_Recipe_Read.Text = "读取";
            this.btn_Recipe_Read.UseVisualStyleBackColor = false;
            this.btn_Recipe_Read.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Recipe_Save_MouseDown);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 14F);
            this.label26.Location = new System.Drawing.Point(19, 18);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 24);
            this.label26.TabIndex = 272;
            this.label26.Text = "配方编号";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Recipe_Save
            // 
            this.btn_Recipe_Save.BackColor = System.Drawing.Color.Red;
            this.btn_Recipe_Save.Location = new System.Drawing.Point(191, 8);
            this.btn_Recipe_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Recipe_Save.Name = "btn_Recipe_Save";
            this.btn_Recipe_Save.Size = new System.Drawing.Size(92, 44);
            this.btn_Recipe_Save.TabIndex = 276;
            this.btn_Recipe_Save.Text = "保存";
            this.btn_Recipe_Save.UseVisualStyleBackColor = false;
            this.btn_Recipe_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Recipe_Save_MouseDown);
            // 
            // txb_Recipe_NO
            // 
            this.txb_Recipe_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Recipe_NO.Font = new System.Drawing.Font("宋体", 14F);
            this.txb_Recipe_NO.Location = new System.Drawing.Point(131, 12);
            this.txb_Recipe_NO.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Recipe_NO.Name = "txb_Recipe_NO";
            this.txb_Recipe_NO.Size = new System.Drawing.Size(54, 34);
            this.txb_Recipe_NO.TabIndex = 275;
            this.txb_Recipe_NO.Text = "0";
            this.txb_Recipe_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Recipe_NO.TextChanged += new System.EventHandler(this.txb_Recipe_NO_TextChanged);
            this.txb_Recipe_NO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Recipe_NO_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 14F);
            this.label29.Location = new System.Drawing.Point(482, 18);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(106, 24);
            this.label29.TabIndex = 274;
            this.label29.Text = "物料编码";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gxb_Alarm
            // 
            this.gxb_Alarm.Controls.Add(this.lbMsg_Dialog);
            this.gxb_Alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxb_Alarm.Font = new System.Drawing.Font("宋体", 14F);
            this.gxb_Alarm.Location = new System.Drawing.Point(0, 0);
            this.gxb_Alarm.Name = "gxb_Alarm";
            this.gxb_Alarm.Size = new System.Drawing.Size(830, 346);
            this.gxb_Alarm.TabIndex = 1;
            this.gxb_Alarm.TabStop = false;
            this.gxb_Alarm.Text = "报警显示";
            // 
            // lbMsg_Dialog
            // 
            this.lbMsg_Dialog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMsg_Dialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMsg_Dialog.FormattingEnabled = true;
            this.lbMsg_Dialog.ItemHeight = 23;
            this.lbMsg_Dialog.Location = new System.Drawing.Point(3, 30);
            this.lbMsg_Dialog.Margin = new System.Windows.Forms.Padding(2);
            this.lbMsg_Dialog.Name = "lbMsg_Dialog";
            this.lbMsg_Dialog.Size = new System.Drawing.Size(824, 313);
            this.lbMsg_Dialog.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Panel1.Controls.Add(this.gxb_Monitor);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Panel2.Controls.Add(this.gxb_Machine);
            this.splitContainer3.Size = new System.Drawing.Size(816, 700);
            this.splitContainer3.SplitterDistance = 350;
            this.splitContainer3.TabIndex = 1;
            // 
            // gxb_Monitor
            // 
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Temp3_Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Temp3);
            this.gxb_Monitor.Controls.Add(this.labelTemp3Monitor);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Temp2_Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Temp2);
            this.gxb_Monitor.Controls.Add(this.labelTemp2Monitor);
            this.gxb_Monitor.Controls.Add(this.labelMonitorLine1Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Conveyor1_Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Conveyor1_Speed);
            this.gxb_Monitor.Controls.Add(this.labelMonitorLine1Speed);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Temp1_Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Temp1);
            this.gxb_Monitor.Controls.Add(this.label24);
            this.gxb_Monitor.Controls.Add(this.label23);
            this.gxb_Monitor.Controls.Add(this.labelTemp1Monitor);
            this.gxb_Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxb_Monitor.Font = new System.Drawing.Font("宋体", 14F);
            this.gxb_Monitor.Location = new System.Drawing.Point(0, 0);
            this.gxb_Monitor.Name = "gxb_Monitor";
            this.gxb_Monitor.Size = new System.Drawing.Size(816, 350);
            this.gxb_Monitor.TabIndex = 1;
            this.gxb_Monitor.TabStop = false;
            this.gxb_Monitor.Text = "参数监控";
            // 
            // lab_Monitor_Temp3_Time
            // 
            this.lab_Monitor_Temp3_Time.AutoSize = true;
            this.lab_Monitor_Temp3_Time.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Temp3_Time.Location = new System.Drawing.Point(353, 173);
            this.lab_Monitor_Temp3_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Temp3_Time.Name = "lab_Monitor_Temp3_Time";
            this.lab_Monitor_Temp3_Time.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Temp3_Time.TabIndex = 430;
            this.lab_Monitor_Temp3_Time.Text = "0000";
            this.lab_Monitor_Temp3_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Temp3
            // 
            this.lab_Monitor_Temp3.AutoSize = true;
            this.lab_Monitor_Temp3.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Temp3.Location = new System.Drawing.Point(216, 173);
            this.lab_Monitor_Temp3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Temp3.Name = "lab_Monitor_Temp3";
            this.lab_Monitor_Temp3.Size = new System.Drawing.Size(70, 24);
            this.lab_Monitor_Temp3.TabIndex = 429;
            this.lab_Monitor_Temp3.Text = "000.0";
            this.lab_Monitor_Temp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemp3Monitor
            // 
            this.labelTemp3Monitor.AutoSize = true;
            this.labelTemp3Monitor.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTemp3Monitor.Location = new System.Drawing.Point(30, 175);
            this.labelTemp3Monitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemp3Monitor.Name = "labelTemp3Monitor";
            this.labelTemp3Monitor.Size = new System.Drawing.Size(109, 20);
            this.labelTemp3Monitor.TabIndex = 428;
            this.labelTemp3Monitor.Text = "3#加温监控";
            this.labelTemp3Monitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Temp2_Time
            // 
            this.lab_Monitor_Temp2_Time.AutoSize = true;
            this.lab_Monitor_Temp2_Time.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Temp2_Time.Location = new System.Drawing.Point(353, 127);
            this.lab_Monitor_Temp2_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Temp2_Time.Name = "lab_Monitor_Temp2_Time";
            this.lab_Monitor_Temp2_Time.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Temp2_Time.TabIndex = 427;
            this.lab_Monitor_Temp2_Time.Text = "0000";
            this.lab_Monitor_Temp2_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Temp2
            // 
            this.lab_Monitor_Temp2.AutoSize = true;
            this.lab_Monitor_Temp2.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Temp2.Location = new System.Drawing.Point(216, 127);
            this.lab_Monitor_Temp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Temp2.Name = "lab_Monitor_Temp2";
            this.lab_Monitor_Temp2.Size = new System.Drawing.Size(70, 24);
            this.lab_Monitor_Temp2.TabIndex = 426;
            this.lab_Monitor_Temp2.Text = "000.0";
            this.lab_Monitor_Temp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemp2Monitor
            // 
            this.labelTemp2Monitor.AutoSize = true;
            this.labelTemp2Monitor.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTemp2Monitor.Location = new System.Drawing.Point(30, 129);
            this.labelTemp2Monitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemp2Monitor.Name = "labelTemp2Monitor";
            this.labelTemp2Monitor.Size = new System.Drawing.Size(109, 20);
            this.labelTemp2Monitor.TabIndex = 425;
            this.labelTemp2Monitor.Text = "2#加温监控";
            this.labelTemp2Monitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMonitorLine1Time
            // 
            this.labelMonitorLine1Time.AutoSize = true;
            this.labelMonitorLine1Time.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMonitorLine1Time.Location = new System.Drawing.Point(30, 267);
            this.labelMonitorLine1Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonitorLine1Time.Name = "labelMonitorLine1Time";
            this.labelMonitorLine1Time.Size = new System.Drawing.Size(149, 20);
            this.labelMonitorLine1Time.TabIndex = 424;
            this.labelMonitorLine1Time.Text = "输送线运行时间";
            this.labelMonitorLine1Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Conveyor1_Time
            // 
            this.lab_Monitor_Conveyor1_Time.AutoSize = true;
            this.lab_Monitor_Conveyor1_Time.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Conveyor1_Time.Location = new System.Drawing.Point(220, 265);
            this.lab_Monitor_Conveyor1_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Conveyor1_Time.Name = "lab_Monitor_Conveyor1_Time";
            this.lab_Monitor_Conveyor1_Time.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Conveyor1_Time.TabIndex = 423;
            this.lab_Monitor_Conveyor1_Time.Text = "0000";
            this.lab_Monitor_Conveyor1_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Conveyor1_Speed
            // 
            this.lab_Monitor_Conveyor1_Speed.AutoSize = true;
            this.lab_Monitor_Conveyor1_Speed.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Conveyor1_Speed.Location = new System.Drawing.Point(216, 219);
            this.lab_Monitor_Conveyor1_Speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Conveyor1_Speed.Name = "lab_Monitor_Conveyor1_Speed";
            this.lab_Monitor_Conveyor1_Speed.Size = new System.Drawing.Size(70, 24);
            this.lab_Monitor_Conveyor1_Speed.TabIndex = 422;
            this.lab_Monitor_Conveyor1_Speed.Text = "000.0";
            this.lab_Monitor_Conveyor1_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMonitorLine1Speed
            // 
            this.labelMonitorLine1Speed.AutoSize = true;
            this.labelMonitorLine1Speed.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMonitorLine1Speed.Location = new System.Drawing.Point(30, 221);
            this.labelMonitorLine1Speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonitorLine1Speed.Name = "labelMonitorLine1Speed";
            this.labelMonitorLine1Speed.Size = new System.Drawing.Size(109, 20);
            this.labelMonitorLine1Speed.TabIndex = 421;
            this.labelMonitorLine1Speed.Text = "输送线速度";
            this.labelMonitorLine1Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Temp1_Time
            // 
            this.lab_Monitor_Temp1_Time.AutoSize = true;
            this.lab_Monitor_Temp1_Time.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Temp1_Time.Location = new System.Drawing.Point(353, 81);
            this.lab_Monitor_Temp1_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Temp1_Time.Name = "lab_Monitor_Temp1_Time";
            this.lab_Monitor_Temp1_Time.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Temp1_Time.TabIndex = 420;
            this.lab_Monitor_Temp1_Time.Text = "0000";
            this.lab_Monitor_Temp1_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Temp1
            // 
            this.lab_Monitor_Temp1.AutoSize = true;
            this.lab_Monitor_Temp1.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Temp1.Location = new System.Drawing.Point(216, 81);
            this.lab_Monitor_Temp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Temp1.Name = "lab_Monitor_Temp1";
            this.lab_Monitor_Temp1.Size = new System.Drawing.Size(70, 24);
            this.lab_Monitor_Temp1.TabIndex = 419;
            this.lab_Monitor_Temp1.Text = "000.0";
            this.lab_Monitor_Temp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 14F);
            this.label24.Location = new System.Drawing.Point(329, 35);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 24);
            this.label24.TabIndex = 418;
            this.label24.Text = "运行时间";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 14F);
            this.label23.Location = new System.Drawing.Point(220, 35);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 24);
            this.label23.TabIndex = 417;
            this.label23.Text = "温度";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemp1Monitor
            // 
            this.labelTemp1Monitor.AutoSize = true;
            this.labelTemp1Monitor.Font = new System.Drawing.Font("宋体", 12F);
            this.labelTemp1Monitor.Location = new System.Drawing.Point(30, 83);
            this.labelTemp1Monitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemp1Monitor.Name = "labelTemp1Monitor";
            this.labelTemp1Monitor.Size = new System.Drawing.Size(109, 20);
            this.labelTemp1Monitor.TabIndex = 416;
            this.labelTemp1Monitor.Text = "1#加温监控";
            this.labelTemp1Monitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gxb_Machine
            // 
            this.gxb_Machine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxb_Machine.Font = new System.Drawing.Font("宋体", 14F);
            this.gxb_Machine.Location = new System.Drawing.Point(0, 0);
            this.gxb_Machine.Name = "gxb_Machine";
            this.gxb_Machine.Size = new System.Drawing.Size(816, 346);
            this.gxb_Machine.TabIndex = 1;
            this.gxb_Machine.TabStop = false;
            this.gxb_Machine.Text = "运行监控";
            // 
            // Windows_Recyle
            // 
            this.Windows_Recyle.Interval = 3000;
            this.Windows_Recyle.Tick += new System.EventHandler(this.Windows_Recyle_Tick);
            // 
            // timer_Excel
            // 
            this.timer_Excel.Enabled = true;
            // 
            // TimerCloseRead
            // 
            this.TimerCloseRead.Interval = 2000;
            this.TimerCloseRead.Tick += new System.EventHandler(this.TimerCloseRead_Tick);
            // 
            // A0砂光机
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Name = "A0砂光机";
            this.Size = new System.Drawing.Size(1650, 700);
            this.Load += new System.EventHandler(this.A0砂光机_Load);
            this.Resize += new System.EventHandler(this.A0砂光机_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbox_RecipeSetting.ResumeLayout(false);
            this.gbox_RecipeSetting.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gxb_Alarm.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.gxb_Monitor.ResumeLayout(false);
            this.gxb_Monitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gxb_Alarm;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gxb_Monitor;
        private System.Windows.Forms.GroupBox gxb_Machine;
        private System.Windows.Forms.GroupBox gbox_RecipeSetting;
        private System.Windows.Forms.CheckBox chb_Fans3;
        private System.Windows.Forms.Label labelTemp3;
        public System.Windows.Forms.TextBox txb_Control_Temp3;
        private System.Windows.Forms.Label labelFans3;
        private System.Windows.Forms.CheckBox chb_Fans2;
        private System.Windows.Forms.Label labelTemp2;
        public System.Windows.Forms.TextBox txb_Control_Temp2;
        private System.Windows.Forms.Label labelFans2;
        private System.Windows.Forms.CheckBox chb_Fans1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txb_Control_Conveyor_Main;
        private System.Windows.Forms.Label labelTemp1;
        public System.Windows.Forms.TextBox txb_Control_Temp1;
        private System.Windows.Forms.Label labelFans1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lab_Prt_NO;
        private System.Windows.Forms.Button btn_Recipe_OK;
        private System.Windows.Forms.Button btn_Recipe_Read;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_Recipe_Save;
        public System.Windows.Forms.TextBox txb_Recipe_NO;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lab_Monitor_Temp3_Time;
        private System.Windows.Forms.Label lab_Monitor_Temp3;
        private System.Windows.Forms.Label labelTemp3Monitor;
        private System.Windows.Forms.Label lab_Monitor_Temp2_Time;
        private System.Windows.Forms.Label lab_Monitor_Temp2;
        private System.Windows.Forms.Label labelTemp2Monitor;
        private System.Windows.Forms.Label labelMonitorLine1Time;
        private System.Windows.Forms.Label lab_Monitor_Conveyor1_Time;
        private System.Windows.Forms.Label lab_Monitor_Conveyor1_Speed;
        private System.Windows.Forms.Label labelMonitorLine1Speed;
        private System.Windows.Forms.Label lab_Monitor_Temp1_Time;
        private System.Windows.Forms.Label lab_Monitor_Temp1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelTemp1Monitor;
        private System.Windows.Forms.ListBox lbMsg_Dialog;
        public System.Windows.Forms.Timer Windows_Recyle;
        public System.Windows.Forms.Timer timer_Excel;
        private System.Windows.Forms.Timer TimerCloseRead;
    }
}
