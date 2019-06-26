namespace TcpDemo
{
    partial class frmNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            this.WindowsRecycle = new System.Windows.Forms.Timer(this.components);
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labDepartment = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WindowsRecycle
            // 
            this.WindowsRecycle.Enabled = true;
            this.WindowsRecycle.Interval = 200;
            this.WindowsRecycle.Tick += new System.EventHandler(this.WindowsRecycle_Tick);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "生产部",
            "技术部",
            "工程部"});
            this.cmbDepartment.Location = new System.Drawing.Point(234, 287);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(182, 23);
            this.cmbDepartment.TabIndex = 20;
            this.cmbDepartment.Text = "生产部";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCancel.Location = new System.Drawing.Point(314, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.Font = new System.Drawing.Font("宋体", 10F);
            this.btnCreate.Location = new System.Drawing.Point(195, 344);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 32);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "新建";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labDepartment
            // 
            this.labDepartment.AutoSize = true;
            this.labDepartment.Font = new System.Drawing.Font("宋体", 14F);
            this.labDepartment.Location = new System.Drawing.Point(72, 282);
            this.labDepartment.Name = "labDepartment";
            this.labDepartment.Size = new System.Drawing.Size(94, 24);
            this.labDepartment.TabIndex = 17;
            this.labDepartment.Text = "部  门:";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("宋体", 14F);
            this.labPassword.Location = new System.Drawing.Point(72, 222);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(94, 24);
            this.labPassword.TabIndex = 15;
            this.labPassword.Text = "密  码:";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Font = new System.Drawing.Font("宋体", 14F);
            this.labUser.Location = new System.Drawing.Point(72, 162);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(94, 24);
            this.labUser.TabIndex = 13;
            this.labUser.Text = "用户名:";
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(234, 162);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(182, 23);
            this.cmbUserName.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("宋体", 12F);
            this.btnDelete.Location = new System.Drawing.Point(314, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 32);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.AutoSize = true;
            this.btnQuery.Font = new System.Drawing.Font("宋体", 12F);
            this.btnQuery.Location = new System.Drawing.Point(195, 404);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(102, 32);
            this.btnQuery.TabIndex = 23;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnModify
            // 
            this.btnModify.AutoSize = true;
            this.btnModify.Font = new System.Drawing.Font("宋体", 12F);
            this.btnModify.Location = new System.Drawing.Point(72, 404);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(102, 32);
            this.btnModify.TabIndex = 25;
            this.btnModify.Text = "用户修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(234, 222);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '*';
            this.txbPassWord.Size = new System.Drawing.Size(182, 25);
            this.txbPassWord.TabIndex = 28;
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.txbPassWord);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labDepartment);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNewUser_FormClosed);
            this.Load += new System.EventHandler(this.frmNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer WindowsRecycle;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labDepartment;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnModify;
        public System.Windows.Forms.TextBox txbPassWord;
    }
}