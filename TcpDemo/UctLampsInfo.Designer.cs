namespace TcpDemo
{
    partial class UctLampsInfo
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
            this.Lbl_Life = new System.Windows.Forms.Label();
            this.Lbl_Power = new System.Windows.Forms.Label();
            this.Lbl_LampsNo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Life
            // 
            this.Lbl_Life.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Life.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Life.Location = new System.Drawing.Point(0, 72);
            this.Lbl_Life.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Life.Name = "Lbl_Life";
            this.Lbl_Life.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Lbl_Life.Size = new System.Drawing.Size(145, 24);
            this.Lbl_Life.TabIndex = 7;
            this.Lbl_Life.Text = "life";
            this.Lbl_Life.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Power
            // 
            this.Lbl_Power.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Power.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Power.Location = new System.Drawing.Point(0, 48);
            this.Lbl_Power.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Power.Name = "Lbl_Power";
            this.Lbl_Power.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Lbl_Power.Size = new System.Drawing.Size(145, 24);
            this.Lbl_Power.TabIndex = 6;
            this.Lbl_Power.Text = "Power";
            this.Lbl_Power.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_LampsNo
            // 
            this.Lbl_LampsNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_LampsNo.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_LampsNo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_LampsNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_LampsNo.Name = "Lbl_LampsNo";
            this.Lbl_LampsNo.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Lbl_LampsNo.Size = new System.Drawing.Size(145, 24);
            this.Lbl_LampsNo.TabIndex = 4;
            this.Lbl_LampsNo.Text = "Lbl_LampsNo";
            this.Lbl_LampsNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // labStatus
            // 
            this.labStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.labStatus.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStatus.Location = new System.Drawing.Point(0, 24);
            this.labStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.labStatus.Size = new System.Drawing.Size(145, 24);
            this.labStatus.TabIndex = 8;
            this.labStatus.Text = "lblStatus";
            this.labStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UctLampsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Lbl_Life);
            this.Controls.Add(this.Lbl_Power);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.Lbl_LampsNo);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "UctLampsInfo";
            this.Size = new System.Drawing.Size(145, 95);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Life;
        private System.Windows.Forms.Label Lbl_Power;
        private System.Windows.Forms.Label Lbl_LampsNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labStatus;
    }
}
