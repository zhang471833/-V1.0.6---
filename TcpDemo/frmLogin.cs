using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpDemo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录用户信息和部门信息，传送至Welcome界面
        /// </summary>
        public string userNameToWelcome;
        public string userDepartmentToWelcome;
        public string userPasswordToWelcome;
        /// <summary>
        /// 点击确定按钮进行软件登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //先对数据库进行查询
            //QueryDB("purete", "createuser",cmbUserName.Text, txbPassWord.Text,cmbDepartment.Text);

            //1. 获取数据
            //从TextBox中获取用户输入信息
            string userName = this.cmbUserName.Text.Trim();
            string userPassword = this.txbPassWord.Text.Trim();
            string userDepartment = this.cmbDepartment.Text.Trim();

            //2. 验证数据
            // 验证用户输入是否为空，若为空，提示用户信息
            if (userName.Equals("") || userPassword.Equals("") || userDepartment.Equals(""))
            {
                MessageBox.Show("用户名、密码或部门不能为空！");
            }
            // 若不为空，验证用户名和密码是否与数据库匹配
            else
            {
                //QueryDBFirstLoad("purete", "createuser");

                //用户名和密码验证正确，提示成功，并执行跳转界面。
                /*数据库连接*/
                //1.创建数据连接,这里注意你登录数据库的数据库名称，用户名和密码
                string strcon = @"Server=localhost;Database=purete;User Id=root;Password=root1234;";
                MySqlConnection con = new MySqlConnection(strcon);
                try
                {
                    //2. 打开数据库
                    con.Open();
                    //3. sql语句
                    string sqlSel = "select count(*) from purete.createuser where UserName = '" + userName + "' and PassWord = '" + userPassword + "'and Department='" + userDepartment + "'";
                    MySqlCommand com = new MySqlCommand(sqlSel, con);
                    //4.判断executeScalar方法返回的参数是否大于0，大于0表示查找有数据
                    if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("登录成功！");

                        //跳转主界面
                        this.DialogResult = DialogResult.OK;
                        this.Dispose();
                        this.Close();
                    }

                    //用户名和密码验证错误，提示错误。
                    else
                    {
                        MessageBox.Show("登录用户、密码或部门错误！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "打开数据库失败");
                }
            }
            //把登录用户的信息传送至Welcome界面
            userNameToWelcome = userName;
            userDepartmentToWelcome = userDepartment;
            userPasswordToWelcome = userPassword;
        }
        /// <summary>
        /// 单击关闭按钮事件，取消系统登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //退出应用程序
            Application.Exit();
        }
        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //实例化新建用户窗体
            frmNewUser createuser = new frmNewUser();
            //显示窗体
            createuser.Show();
        }
        //当窗体加载时自动查询数据库
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //执行查询功能，按照用户名进行查询
            QueryDBFirstLoad("purete", "createuser");
        }
        //查询MySQL数据行方法
        public bool QueryDBFirstLoad(string dbName, string dbdsName)
        {
            ///数据库的插入行
            //Env.DB.createuser.Insert(
            //    new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.Notes1, "123"),
            //    new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.Notes2, "234"),
            //    new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.Notes3, "345")
            //    );
            ////数据库的修改行
            //Env.DB.createuser.Update($"{DBNames.T_Col_Name.createuser.Notes1}='123'",
            //    new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.Notes1, "56789"),
            //    new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.Notes2, "67890"));
            ////数据库的删除行
            //Env.DB.createuser.Delete($"{DBNames.T_Col_Name.createuser.Notes1}='123'");

            var dt = Env.DB.createuser.GetData();
            if (dt == null) return false;
            foreach (DataRow item in dt.Rows)
            {
                cmbUserName.Items.Add(Convert.ToString(item[DBNames.T_Col_Name.createuser.UserName]));
            }
            return true;
        }
        /// <summary>
        /// 登陆界面的显示
        /// </summary>
        private void LoginScreen()
        {
            btnRegister.Enabled = false;
            btnLogin.Enabled = false;
            if (cmbUserName.Text == "root")
            {
                cmbDepartment.Text = "管理员";
                btnLogin.Enabled = false;
                if (txbPassWord.Text == "root1234")
                {
                    btnRegister.Enabled = true;
                }
                else
                {
                    btnRegister.Enabled = false;
                }
            }
            else
            {
                btnLogin.Enabled = true;
                btnRegister.Enabled = false;
            }
        }
        /// <summary>
        /// 窗体加载完成后执行的代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Shown(object sender, EventArgs e)
        {
            LoginScreen();
        }
        /// <summary>
        /// 当输入框输入完成或者选择完成后执行的代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputDone(object sender, EventArgs e)
        {
            LoginScreen();
        }
        /// <summary>
        /// 当输入框输入完成后执行的代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputDone(object sender, KeyEventArgs e)
        {
            LoginScreen();
        }
    }
}
