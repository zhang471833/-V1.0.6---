namespace TcpDemo
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labUser = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labDepartment = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Font = new System.Drawing.Font("宋体", 14F);
            this.labUser.Location = new System.Drawing.Point(72, 162);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(94, 24);
            this.labUser.TabIndex = 0;
            this.labUser.Text = "用户名:";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("宋体", 14F);
            this.labPassword.Location = new System.Drawing.Point(72, 222);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(94, 24);
            this.labPassword.TabIndex = 2;
            this.labPassword.Text = "密  码:";
            // 
            // labDepartment
            // 
            this.labDepartment.AutoSize = true;
            this.labDepartment.Font = new System.Drawing.Font("宋体", 14F);
            this.labDepartment.Location = new System.Drawing.Point(72, 282);
            this.labDepartment.Name = "labDepartment";
            this.labDepartment.Size = new System.Drawing.Size(94, 24);
            this.labDepartment.TabIndex = 4;
            this.labDepartment.Text = "部  门:";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 12F);
            this.btnLogin.Location = new System.Drawing.Point(195, 405);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 32);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCancel.Location = new System.Drawing.Point(315, 405);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "生产部",
            "技术部",
            "工程部",
            "管理员"});
            this.cmbDepartment.Location = new System.Drawing.Point(235, 288);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(183, 23);
            this.cmbDepartment.TabIndex = 11;
            this.cmbDepartment.Text = "工程部";
            this.cmbDepartment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputDone);
            this.cmbDepartment.Leave += new System.EventHandler(this.InputDone);
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRegister.Location = new System.Drawing.Point(72, 405);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 32);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "用户管理";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(235, 162);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(183, 23);
            this.cmbUserName.TabIndex = 23;
            this.cmbUserName.Text = "UserJohn";
            this.cmbUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputDone);
            this.cmbUserName.Leave += new System.EventHandler(this.InputDone);
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(235, 222);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '*';
            this.txbPassWord.Size = new System.Drawing.Size(183, 25);
            this.txbPassWord.TabIndex = 27;
            this.txbPassWord.Text = "922315";
            this.txbPassWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputDone);
            this.txbPassWord.Leave += new System.EventHandler(this.InputDone);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 652);
            this.Controls.Add(this.txbPassWord);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labDepartment);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labDepartment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.ComboBox cmbDepartment;
        public System.Windows.Forms.ComboBox cmbUserName;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txbPassWord;
    }
}