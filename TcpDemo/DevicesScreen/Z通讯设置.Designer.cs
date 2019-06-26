namespace TcpDemo
{
    partial class Z通讯设置
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
            this.btSetDefault = new System.Windows.Forms.Button();
            this.chkReadIm = new System.Windows.Forms.CheckBox();
            this.btDisConnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.gbSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSetDefault
            // 
            this.btSetDefault.Location = new System.Drawing.Point(288, 39);
            this.btSetDefault.Margin = new System.Windows.Forms.Padding(4);
            this.btSetDefault.Name = "btSetDefault";
            this.btSetDefault.Size = new System.Drawing.Size(142, 32);
            this.btSetDefault.TabIndex = 17;
            this.btSetDefault.Text = "保存为默认";
            this.btSetDefault.UseVisualStyleBackColor = true;
            this.btSetDefault.Click += new System.EventHandler(this.btSetDefault_Click);
            // 
            // chkReadIm
            // 
            this.chkReadIm.AutoSize = true;
            this.chkReadIm.Checked = true;
            this.chkReadIm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadIm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkReadIm.Location = new System.Drawing.Point(262, 0);
            this.chkReadIm.Margin = new System.Windows.Forms.Padding(4);
            this.chkReadIm.Name = "chkReadIm";
            this.chkReadIm.Size = new System.Drawing.Size(156, 22);
            this.chkReadIm.TabIndex = 16;
            this.chkReadIm.Text = "写入后立即回读";
            this.chkReadIm.UseVisualStyleBackColor = true;
            // 
            // btDisConnect
            // 
            this.btDisConnect.Enabled = false;
            this.btDisConnect.Location = new System.Drawing.Point(288, 82);
            this.btDisConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btDisConnect.Name = "btDisConnect";
            this.btDisConnect.Size = new System.Drawing.Size(142, 32);
            this.btDisConnect.TabIndex = 15;
            this.btDisConnect.Text = "断开";
            this.btDisConnect.UseVisualStyleBackColor = true;
            this.btDisConnect.Click += new System.EventHandler(this.btDisConnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(116, 81);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(142, 32);
            this.btConnect.TabIndex = 14;
            this.btConnect.Text = "连接";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(116, 40);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(160, 30);
            this.txtIP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP地址:";
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.btSetDefault);
            this.gbSetup.Controls.Add(this.chkReadIm);
            this.gbSetup.Controls.Add(this.btDisConnect);
            this.gbSetup.Controls.Add(this.btConnect);
            this.gbSetup.Controls.Add(this.txtIP);
            this.gbSetup.Controls.Add(this.label1);
            this.gbSetup.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSetup.Location = new System.Drawing.Point(4, 4);
            this.gbSetup.Margin = new System.Windows.Forms.Padding(4);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Padding = new System.Windows.Forms.Padding(4);
            this.gbSetup.Size = new System.Drawing.Size(474, 164);
            this.gbSetup.TabIndex = 16;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "通讯连接参数配置";
            // 
            // Z通讯设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.gbSetup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Z通讯设置";
            this.Size = new System.Drawing.Size(490, 304);
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btDisConnect;
        public System.Windows.Forms.Button btConnect;
        public System.Windows.Forms.TextBox txtIP;
        public System.Windows.Forms.Button btSetDefault;
        public System.Windows.Forms.CheckBox chkReadIm;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbSetup;
    }
}
