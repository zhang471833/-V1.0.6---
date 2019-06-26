namespace TcpDemo
{
    partial class A0龙门上下料
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
            this.btn_Recipe_OK = new System.Windows.Forms.Button();
            this.txb_Control_Pao_buchang = new System.Windows.Forms.TextBox();
            this.txb_Control_Pao_Height = new System.Windows.Forms.TextBox();
            this.labelPao = new System.Windows.Forms.Label();
            this.Chb_Brush_R = new System.Windows.Forms.CheckBox();
            this.Chb_Brush = new System.Windows.Forms.CheckBox();
            this.Chb_Fans = new System.Windows.Forms.CheckBox();
            this.lab_SwitchBrush = new System.Windows.Forms.Label();
            this.btn_Recipe_Read = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_Recipe_Save = new System.Windows.Forms.Button();
            this.txb_Recipe_NO = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.gxb_Alarm = new System.Windows.Forms.GroupBox();
            this.lbMsg_Dialog = new System.Windows.Forms.ListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gxb_Monitor = new System.Windows.Forms.GroupBox();
            this.lab_Monitor_Pao_Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Pao_Life = new System.Windows.Forms.Label();
            this.lab_Monitor_Pao_Speed = new System.Windows.Forms.Label();
            this.labelPaoMonitor = new System.Windows.Forms.Label();
            this.lab_Monitor_Trans_Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Conveyor1_Speed = new System.Windows.Forms.Label();
            this.labelLine1Monitor = new System.Windows.Forms.Label();
            this.lab_Monitor_Brush_Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Fans_Time = new System.Windows.Forms.Label();
            this.lab_Monitor_Brush_Life = new System.Windows.Forms.Label();
            this.lab_Monitor_Brush_Speed = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelBrushMonitor = new System.Windows.Forms.Label();
            this.labelDoc1Monitor = new System.Windows.Forms.Label();
            this.gxb_Machine = new System.Windows.Forms.GroupBox();
            this.Windows_Recyle = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbox_RecipeSetting = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lab_Prt_NO = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TransSpeed = new System.Windows.Forms.Label();
            this.txb_Control_Brush_buchang = new System.Windows.Forms.TextBox();
            this.txb_Control_Brush_Height = new System.Windows.Forms.TextBox();
            this.txb_Control_Conveyor_Main = new System.Windows.Forms.TextBox();
            this.labelBrush = new System.Windows.Forms.Label();
            this.lab_SwitchFans = new System.Windows.Forms.Label();
            this.timer_Excel = new System.Windows.Forms.Timer(this.components);
            this.TimerCloseRead = new System.Windows.Forms.Timer(this.components);
            this.gxb_Alarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gxb_Monitor.SuspendLayout();
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
            this.SuspendLayout();
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
            // txb_Control_Pao_buchang
            // 
            this.txb_Control_Pao_buchang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Pao_buchang.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Pao_buchang.Location = new System.Drawing.Point(370, 173);
            this.txb_Control_Pao_buchang.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Pao_buchang.Name = "txb_Control_Pao_buchang";
            this.txb_Control_Pao_buchang.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Pao_buchang.TabIndex = 356;
            this.txb_Control_Pao_buchang.Text = "0";
            this.txb_Control_Pao_buchang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Control_Pao_buchang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChoiced);
            // 
            // txb_Control_Pao_Height
            // 
            this.txb_Control_Pao_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Pao_Height.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Pao_Height.Location = new System.Drawing.Point(202, 173);
            this.txb_Control_Pao_Height.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Pao_Height.Name = "txb_Control_Pao_Height";
            this.txb_Control_Pao_Height.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Pao_Height.TabIndex = 355;
            this.txb_Control_Pao_Height.Text = "0";
            this.txb_Control_Pao_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Control_Pao_Height.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChoiced);
            // 
            // labelPao
            // 
            this.labelPao.AutoSize = true;
            this.labelPao.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPao.Location = new System.Drawing.Point(2, 178);
            this.labelPao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPao.Name = "labelPao";
            this.labelPao.Size = new System.Drawing.Size(69, 20);
            this.labelPao.TabIndex = 354;
            this.labelPao.Text = "抛光轮";
            this.labelPao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chb_Brush_R
            // 
            this.Chb_Brush_R.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chb_Brush_R.BackColor = System.Drawing.Color.Red;
            this.Chb_Brush_R.Location = new System.Drawing.Point(291, 313);
            this.Chb_Brush_R.Margin = new System.Windows.Forms.Padding(2);
            this.Chb_Brush_R.Name = "Chb_Brush_R";
            this.Chb_Brush_R.Size = new System.Drawing.Size(84, 32);
            this.Chb_Brush_R.TabIndex = 353;
            this.Chb_Brush_R.Text = "反转";
            this.Chb_Brush_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chb_Brush_R.UseVisualStyleBackColor = false;
            // 
            // Chb_Brush
            // 
            this.Chb_Brush.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chb_Brush.BackColor = System.Drawing.Color.Red;
            this.Chb_Brush.Location = new System.Drawing.Point(202, 313);
            this.Chb_Brush.Margin = new System.Windows.Forms.Padding(2);
            this.Chb_Brush.Name = "Chb_Brush";
            this.Chb_Brush.Size = new System.Drawing.Size(84, 32);
            this.Chb_Brush.TabIndex = 352;
            this.Chb_Brush.Text = "正转";
            this.Chb_Brush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chb_Brush.UseVisualStyleBackColor = false;
            // 
            // Chb_Fans
            // 
            this.Chb_Fans.Appearance = System.Windows.Forms.Appearance.Button;
            this.Chb_Fans.Location = new System.Drawing.Point(202, 266);
            this.Chb_Fans.Margin = new System.Windows.Forms.Padding(2);
            this.Chb_Fans.Name = "Chb_Fans";
            this.Chb_Fans.Size = new System.Drawing.Size(129, 32);
            this.Chb_Fans.TabIndex = 351;
            this.Chb_Fans.Text = "风机开关";
            this.Chb_Fans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chb_Fans.UseVisualStyleBackColor = true;
            // 
            // lab_SwitchBrush
            // 
            this.lab_SwitchBrush.AutoSize = true;
            this.lab_SwitchBrush.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_SwitchBrush.Location = new System.Drawing.Point(1, 319);
            this.lab_SwitchBrush.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_SwitchBrush.Name = "lab_SwitchBrush";
            this.lab_SwitchBrush.Size = new System.Drawing.Size(109, 20);
            this.lab_SwitchBrush.TabIndex = 347;
            this.lab_SwitchBrush.Text = "毛刷轮开关";
            this.lab_SwitchBrush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txb_Recipe_NO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChoiced);
            this.txb_Recipe_NO.TextChanged += new System.EventHandler(this.txb_Recipe_NO_TextChanged);
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
            this.gxb_Alarm.BackColor = System.Drawing.Color.White;
            this.gxb_Alarm.Controls.Add(this.lbMsg_Dialog);
            this.gxb_Alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxb_Alarm.Font = new System.Drawing.Font("宋体", 14F);
            this.gxb_Alarm.Location = new System.Drawing.Point(0, 0);
            this.gxb_Alarm.Name = "gxb_Alarm";
            this.gxb_Alarm.Size = new System.Drawing.Size(842, 346);
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
            this.lbMsg_Dialog.Size = new System.Drawing.Size(836, 313);
            this.lbMsg_Dialog.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gxb_Monitor);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gxb_Machine);
            this.splitContainer3.Size = new System.Drawing.Size(807, 700);
            this.splitContainer3.SplitterDistance = 350;
            this.splitContainer3.TabIndex = 151;
            // 
            // gxb_Monitor
            // 
            this.gxb_Monitor.BackColor = System.Drawing.Color.White;
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Pao_Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Pao_Life);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Pao_Speed);
            this.gxb_Monitor.Controls.Add(this.labelPaoMonitor);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Trans_Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Conveyor1_Speed);
            this.gxb_Monitor.Controls.Add(this.labelLine1Monitor);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Brush_Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Fans_Time);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Brush_Life);
            this.gxb_Monitor.Controls.Add(this.lab_Monitor_Brush_Speed);
            this.gxb_Monitor.Controls.Add(this.label25);
            this.gxb_Monitor.Controls.Add(this.label24);
            this.gxb_Monitor.Controls.Add(this.label23);
            this.gxb_Monitor.Controls.Add(this.labelBrushMonitor);
            this.gxb_Monitor.Controls.Add(this.labelDoc1Monitor);
            this.gxb_Monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxb_Monitor.Font = new System.Drawing.Font("宋体", 14F);
            this.gxb_Monitor.Location = new System.Drawing.Point(0, 0);
            this.gxb_Monitor.Margin = new System.Windows.Forms.Padding(2);
            this.gxb_Monitor.Name = "gxb_Monitor";
            this.gxb_Monitor.Padding = new System.Windows.Forms.Padding(2);
            this.gxb_Monitor.Size = new System.Drawing.Size(807, 350);
            this.gxb_Monitor.TabIndex = 253;
            this.gxb_Monitor.TabStop = false;
            this.gxb_Monitor.Text = "参数监控";
            // 
            // lab_Monitor_Pao_Time
            // 
            this.lab_Monitor_Pao_Time.AutoSize = true;
            this.lab_Monitor_Pao_Time.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Pao_Time.Location = new System.Drawing.Point(282, 108);
            this.lab_Monitor_Pao_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Pao_Time.Name = "lab_Monitor_Pao_Time";
            this.lab_Monitor_Pao_Time.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Pao_Time.TabIndex = 359;
            this.lab_Monitor_Pao_Time.Text = "0000";
            this.lab_Monitor_Pao_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Pao_Life
            // 
            this.lab_Monitor_Pao_Life.AutoSize = true;
            this.lab_Monitor_Pao_Life.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Pao_Life.Location = new System.Drawing.Point(404, 108);
            this.lab_Monitor_Pao_Life.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Pao_Life.Name = "lab_Monitor_Pao_Life";
            this.lab_Monitor_Pao_Life.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Pao_Life.TabIndex = 358;
            this.lab_Monitor_Pao_Life.Text = "0000";
            this.lab_Monitor_Pao_Life.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Pao_Speed
            // 
            this.lab_Monitor_Pao_Speed.AutoSize = true;
            this.lab_Monitor_Pao_Speed.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Pao_Speed.Location = new System.Drawing.Point(146, 108);
            this.lab_Monitor_Pao_Speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Pao_Speed.Name = "lab_Monitor_Pao_Speed";
            this.lab_Monitor_Pao_Speed.Size = new System.Drawing.Size(70, 24);
            this.lab_Monitor_Pao_Speed.TabIndex = 357;
            this.lab_Monitor_Pao_Speed.Text = "000.0";
            this.lab_Monitor_Pao_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPaoMonitor
            // 
            this.labelPaoMonitor.AutoSize = true;
            this.labelPaoMonitor.Font = new System.Drawing.Font("宋体", 12F);
            this.labelPaoMonitor.Location = new System.Drawing.Point(8, 110);
            this.labelPaoMonitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPaoMonitor.Name = "labelPaoMonitor";
            this.labelPaoMonitor.Size = new System.Drawing.Size(69, 20);
            this.labelPaoMonitor.TabIndex = 356;
            this.labelPaoMonitor.Text = "抛光轮";
            this.labelPaoMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Trans_Time
            // 
            this.lab_Monitor_Trans_Time.AutoSize = true;
            this.lab_Monitor_Trans_Time.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Trans_Time.Location = new System.Drawing.Point(276, 204);
            this.lab_Monitor_Trans_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Trans_Time.Name = "lab_Monitor_Trans_Time";
            this.lab_Monitor_Trans_Time.Size = new System.Drawing.Size(70, 24);
            this.lab_Monitor_Trans_Time.TabIndex = 355;
            this.lab_Monitor_Trans_Time.Text = "000.0";
            this.lab_Monitor_Trans_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Conveyor1_Speed
            // 
            this.lab_Monitor_Conveyor1_Speed.AutoSize = true;
            this.lab_Monitor_Conveyor1_Speed.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Conveyor1_Speed.Location = new System.Drawing.Point(146, 204);
            this.lab_Monitor_Conveyor1_Speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Conveyor1_Speed.Name = "lab_Monitor_Conveyor1_Speed";
            this.lab_Monitor_Conveyor1_Speed.Size = new System.Drawing.Size(70, 24);
            this.lab_Monitor_Conveyor1_Speed.TabIndex = 354;
            this.lab_Monitor_Conveyor1_Speed.Text = "000.0";
            this.lab_Monitor_Conveyor1_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLine1Monitor
            // 
            this.labelLine1Monitor.AutoSize = true;
            this.labelLine1Monitor.Font = new System.Drawing.Font("宋体", 12F);
            this.labelLine1Monitor.Location = new System.Drawing.Point(8, 206);
            this.labelLine1Monitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLine1Monitor.Name = "labelLine1Monitor";
            this.labelLine1Monitor.Size = new System.Drawing.Size(109, 20);
            this.labelLine1Monitor.TabIndex = 353;
            this.labelLine1Monitor.Text = "输送线速度";
            this.labelLine1Monitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Brush_Time
            // 
            this.lab_Monitor_Brush_Time.AutoSize = true;
            this.lab_Monitor_Brush_Time.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Brush_Time.Location = new System.Drawing.Point(282, 60);
            this.lab_Monitor_Brush_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Brush_Time.Name = "lab_Monitor_Brush_Time";
            this.lab_Monitor_Brush_Time.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Brush_Time.TabIndex = 336;
            this.lab_Monitor_Brush_Time.Text = "0000";
            this.lab_Monitor_Brush_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Fans_Time
            // 
            this.lab_Monitor_Fans_Time.AutoSize = true;
            this.lab_Monitor_Fans_Time.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Fans_Time.Location = new System.Drawing.Point(282, 156);
            this.lab_Monitor_Fans_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Fans_Time.Name = "lab_Monitor_Fans_Time";
            this.lab_Monitor_Fans_Time.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Fans_Time.TabIndex = 335;
            this.lab_Monitor_Fans_Time.Text = "0000";
            this.lab_Monitor_Fans_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Brush_Life
            // 
            this.lab_Monitor_Brush_Life.AutoSize = true;
            this.lab_Monitor_Brush_Life.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Brush_Life.Location = new System.Drawing.Point(404, 60);
            this.lab_Monitor_Brush_Life.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Brush_Life.Name = "lab_Monitor_Brush_Life";
            this.lab_Monitor_Brush_Life.Size = new System.Drawing.Size(58, 24);
            this.lab_Monitor_Brush_Life.TabIndex = 333;
            this.lab_Monitor_Brush_Life.Text = "0000";
            this.lab_Monitor_Brush_Life.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Monitor_Brush_Speed
            // 
            this.lab_Monitor_Brush_Speed.AutoSize = true;
            this.lab_Monitor_Brush_Speed.Font = new System.Drawing.Font("宋体", 14F);
            this.lab_Monitor_Brush_Speed.Location = new System.Drawing.Point(146, 60);
            this.lab_Monitor_Brush_Speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Monitor_Brush_Speed.Name = "lab_Monitor_Brush_Speed";
            this.lab_Monitor_Brush_Speed.Size = new System.Drawing.Size(70, 24);
            this.lab_Monitor_Brush_Speed.TabIndex = 332;
            this.lab_Monitor_Brush_Speed.Text = "000.0";
            this.lab_Monitor_Brush_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 14F);
            this.label25.Location = new System.Drawing.Point(380, 28);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 24);
            this.label25.TabIndex = 331;
            this.label25.Text = "剩余寿命";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 14F);
            this.label24.Location = new System.Drawing.Point(258, 28);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 24);
            this.label24.TabIndex = 330;
            this.label24.Text = "运行时间";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 14F);
            this.label23.Location = new System.Drawing.Point(152, 28);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 24);
            this.label23.TabIndex = 329;
            this.label23.Text = "高度";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBrushMonitor
            // 
            this.labelBrushMonitor.AutoSize = true;
            this.labelBrushMonitor.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBrushMonitor.Location = new System.Drawing.Point(8, 62);
            this.labelBrushMonitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrushMonitor.Name = "labelBrushMonitor";
            this.labelBrushMonitor.Size = new System.Drawing.Size(69, 20);
            this.labelBrushMonitor.TabIndex = 322;
            this.labelBrushMonitor.Text = "毛刷轮";
            this.labelBrushMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDoc1Monitor
            // 
            this.labelDoc1Monitor.AutoSize = true;
            this.labelDoc1Monitor.Font = new System.Drawing.Font("宋体", 12F);
            this.labelDoc1Monitor.Location = new System.Drawing.Point(8, 158);
            this.labelDoc1Monitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDoc1Monitor.Name = "labelDoc1Monitor";
            this.labelDoc1Monitor.Size = new System.Drawing.Size(49, 20);
            this.labelDoc1Monitor.TabIndex = 323;
            this.labelDoc1Monitor.Text = "风机";
            this.labelDoc1Monitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gxb_Machine
            // 
            this.gxb_Machine.BackColor = System.Drawing.Color.White;
            this.gxb_Machine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gxb_Machine.Font = new System.Drawing.Font("宋体", 14F);
            this.gxb_Machine.Location = new System.Drawing.Point(0, 0);
            this.gxb_Machine.Name = "gxb_Machine";
            this.gxb_Machine.Size = new System.Drawing.Size(807, 346);
            this.gxb_Machine.TabIndex = 0;
            this.gxb_Machine.TabStop = false;
            this.gxb_Machine.Text = "运行监控";
            // 
            // Windows_Recyle
            // 
            this.Windows_Recyle.Interval = 800;
            this.Windows_Recyle.Tick += new System.EventHandler(this.Windows_Recyle_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer1.SplitterDistance = 842;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 92;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbox_RecipeSetting);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gxb_Alarm);
            this.splitContainer2.Size = new System.Drawing.Size(842, 700);
            this.splitContainer2.SplitterDistance = 350;
            this.splitContainer2.TabIndex = 149;
            // 
            // gbox_RecipeSetting
            // 
            this.gbox_RecipeSetting.BackColor = System.Drawing.Color.White;
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Pao_buchang);
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Pao_Height);
            this.gbox_RecipeSetting.Controls.Add(this.labelPao);
            this.gbox_RecipeSetting.Controls.Add(this.Chb_Brush_R);
            this.gbox_RecipeSetting.Controls.Add(this.Chb_Brush);
            this.gbox_RecipeSetting.Controls.Add(this.Chb_Fans);
            this.gbox_RecipeSetting.Controls.Add(this.lab_SwitchBrush);
            this.gbox_RecipeSetting.Controls.Add(this.groupBox4);
            this.gbox_RecipeSetting.Controls.Add(this.label8);
            this.gbox_RecipeSetting.Controls.Add(this.label9);
            this.gbox_RecipeSetting.Controls.Add(this.TransSpeed);
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Brush_buchang);
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Brush_Height);
            this.gbox_RecipeSetting.Controls.Add(this.txb_Control_Conveyor_Main);
            this.gbox_RecipeSetting.Controls.Add(this.labelBrush);
            this.gbox_RecipeSetting.Controls.Add(this.lab_SwitchFans);
            this.gbox_RecipeSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_RecipeSetting.Font = new System.Drawing.Font("宋体", 14F);
            this.gbox_RecipeSetting.Location = new System.Drawing.Point(0, 0);
            this.gbox_RecipeSetting.Margin = new System.Windows.Forms.Padding(2);
            this.gbox_RecipeSetting.Name = "gbox_RecipeSetting";
            this.gbox_RecipeSetting.Padding = new System.Windows.Forms.Padding(2);
            this.gbox_RecipeSetting.Size = new System.Drawing.Size(842, 350);
            this.gbox_RecipeSetting.TabIndex = 252;
            this.gbox_RecipeSetting.TabStop = false;
            this.gbox_RecipeSetting.Text = "配方设定";
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
            this.groupBox4.Size = new System.Drawing.Size(838, 58);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(380, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 337;
            this.label8.Text = "工件误差mm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(202, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 336;
            this.label9.Text = "设置高度mm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransSpeed
            // 
            this.TransSpeed.AutoSize = true;
            this.TransSpeed.Font = new System.Drawing.Font("宋体", 12F);
            this.TransSpeed.Location = new System.Drawing.Point(1, 225);
            this.TransSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TransSpeed.Name = "TransSpeed";
            this.TransSpeed.Size = new System.Drawing.Size(159, 20);
            this.TransSpeed.TabIndex = 325;
            this.TransSpeed.Text = "输送线速度m/min";
            this.TransSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Control_Brush_buchang
            // 
            this.txb_Control_Brush_buchang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Brush_buchang.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Brush_buchang.Location = new System.Drawing.Point(370, 126);
            this.txb_Control_Brush_buchang.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Brush_buchang.Name = "txb_Control_Brush_buchang";
            this.txb_Control_Brush_buchang.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Brush_buchang.TabIndex = 339;
            this.txb_Control_Brush_buchang.Text = "0";
            this.txb_Control_Brush_buchang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Control_Brush_buchang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChoiced);
            // 
            // txb_Control_Brush_Height
            // 
            this.txb_Control_Brush_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Brush_Height.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Brush_Height.Location = new System.Drawing.Point(202, 126);
            this.txb_Control_Brush_Height.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Brush_Height.Name = "txb_Control_Brush_Height";
            this.txb_Control_Brush_Height.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Brush_Height.TabIndex = 334;
            this.txb_Control_Brush_Height.Text = "0";
            this.txb_Control_Brush_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Control_Brush_Height.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChoiced);
            // 
            // txb_Control_Conveyor_Main
            // 
            this.txb_Control_Conveyor_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Control_Conveyor_Main.Font = new System.Drawing.Font("宋体", 12F);
            this.txb_Control_Conveyor_Main.Location = new System.Drawing.Point(202, 220);
            this.txb_Control_Conveyor_Main.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Control_Conveyor_Main.Name = "txb_Control_Conveyor_Main";
            this.txb_Control_Conveyor_Main.Size = new System.Drawing.Size(130, 30);
            this.txb_Control_Conveyor_Main.TabIndex = 332;
            this.txb_Control_Conveyor_Main.Text = "0";
            this.txb_Control_Conveyor_Main.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Control_Conveyor_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChoiced);
            // 
            // labelBrush
            // 
            this.labelBrush.AutoSize = true;
            this.labelBrush.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBrush.Location = new System.Drawing.Point(1, 131);
            this.labelBrush.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrush.Name = "labelBrush";
            this.labelBrush.Size = new System.Drawing.Size(69, 20);
            this.labelBrush.TabIndex = 327;
            this.labelBrush.Text = "毛刷轮";
            this.labelBrush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_SwitchFans
            // 
            this.lab_SwitchFans.AutoSize = true;
            this.lab_SwitchFans.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_SwitchFans.Location = new System.Drawing.Point(1, 272);
            this.lab_SwitchFans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_SwitchFans.Name = "lab_SwitchFans";
            this.lab_SwitchFans.Size = new System.Drawing.Size(89, 20);
            this.lab_SwitchFans.TabIndex = 328;
            this.lab_SwitchFans.Text = "风机开关";
            this.lab_SwitchFans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Excel
            // 
            this.timer_Excel.Enabled = true;
            // 
            // TimerCloseRead
            // 
            this.TimerCloseRead.Interval = 1000;
            this.TimerCloseRead.Tick += new System.EventHandler(this.TimerCloseRead_Tick);
            // 
            // A0龙门上下料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "A0龙门上下料";
            this.Size = new System.Drawing.Size(1650, 700);
            this.Load += new System.EventHandler(this.A0龙门上下料_Load);
            this.Resize += new System.EventHandler(this.A0龙门上下料_Resize);
            this.gxb_Alarm.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.gxb_Monitor.ResumeLayout(false);
            this.gxb_Monitor.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Recipe_OK;
        public System.Windows.Forms.TextBox txb_Control_Pao_buchang;
        public System.Windows.Forms.TextBox txb_Control_Pao_Height;
        private System.Windows.Forms.Label labelPao;
        private System.Windows.Forms.CheckBox Chb_Brush_R;
        private System.Windows.Forms.CheckBox Chb_Brush;
        private System.Windows.Forms.CheckBox Chb_Fans;
        private System.Windows.Forms.Label lab_SwitchBrush;
        private System.Windows.Forms.Button btn_Recipe_Read;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_Recipe_Save;
        public System.Windows.Forms.TextBox txb_Recipe_NO;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox gxb_Alarm;
        private System.Windows.Forms.ListBox lbMsg_Dialog;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gxb_Monitor;
        private System.Windows.Forms.Label lab_Monitor_Pao_Time;
        private System.Windows.Forms.Label lab_Monitor_Pao_Life;
        private System.Windows.Forms.Label lab_Monitor_Pao_Speed;
        private System.Windows.Forms.Label labelPaoMonitor;
        private System.Windows.Forms.Label lab_Monitor_Trans_Time;
        private System.Windows.Forms.Label lab_Monitor_Conveyor1_Speed;
        private System.Windows.Forms.Label labelLine1Monitor;
        private System.Windows.Forms.Label lab_Monitor_Brush_Time;
        private System.Windows.Forms.Label lab_Monitor_Fans_Time;
        private System.Windows.Forms.Label lab_Monitor_Brush_Life;
        private System.Windows.Forms.Label lab_Monitor_Brush_Speed;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelBrushMonitor;
        private System.Windows.Forms.Label labelDoc1Monitor;
        private System.Windows.Forms.GroupBox gxb_Machine;
        public System.Windows.Forms.Timer Windows_Recyle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbox_RecipeSetting;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lab_Prt_NO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TransSpeed;
        public System.Windows.Forms.TextBox txb_Control_Brush_buchang;
        public System.Windows.Forms.TextBox txb_Control_Brush_Height;
        public System.Windows.Forms.TextBox txb_Control_Conveyor_Main;
        private System.Windows.Forms.Label labelBrush;
        private System.Windows.Forms.Label lab_SwitchFans;
        public System.Windows.Forms.Timer timer_Excel;
        private System.Windows.Forms.Timer TimerCloseRead;
    }
}
