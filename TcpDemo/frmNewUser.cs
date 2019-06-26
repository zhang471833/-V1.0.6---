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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        //窗体循环执行
        private void WindowsRecycle_Tick(object sender, EventArgs e)
        {
            //判断注册界面文本是否为空，如果均不为空则创建按钮显示可操作，如果为空则不允许操作
            if (cmbUserName.Text != "" && txbPassWord.Text != "" && cmbDepartment.Text != "")
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }

        }
        //点击取消按钮后窗体关闭
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            //关闭窗体时把登录按钮显示了
            login.btnLogin.Enabled = true;
            login.cmbUserName.Text = "";
            login.txbPassWord.Text = "";

            //窗体关闭
            this.Close();
            //退出系统
            Application.Exit();
        }



        //创建数据库，服务器名字localhost，用户名root，用户密码root1234
        private bool CreateMysqlDataBase(string dbName)
        {
            //定义Bool变量的标志位
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Charset=gbk;Password=root1234;Persist Security Info=True";
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                //实际操作任务-----------当数据库不存在时则创建数据库
                string commandString = "create database if not exists " + dbName + " character set=gbk";
                MySqlCommand setformat = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                //链接Mysql数据库
                mySqlConnection.Open();
                //执行操作
                setformat.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                flag = false;
            }
            finally
            {
                //关闭连接
                mySqlConnection.Close();
            }
            return flag;
        }
        //创建新的数据库数据表Table，创建表的时候需要有数据库名字和数据表名字；
        private bool CreateMysqlDataSet(string dbName, string dbdsName)
        {
            string dbds = dbName + "." + dbdsName;
            string commandString = @"create table if not exists " + dbds + @" (
	                                        id		INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                                            UserName		TEXT NOT NULL,
                                            PassWord		TEXT NOT NULL,
                                            Department		TEXT NOT NULL
                                        )ENGINE=MyISAM  DEFAULT CHARSET=gbk AUTO_INCREMENT=1";
            Env.DB.ExecuteNoQuery(null, commandString);
            var dt = Env.DB.createuser.GetData();
            if (dt == null) return false;
            return true;
        }
        //插入数据行到MySQL数据库，调用此方法的时候需要有数据库名字和数据库表的名字
        public bool InsertDataToMysql(string dbName, string dbdsName, string id, string username, string password, string department)
        {
            var dt = Env.DB.createuser.GetData();
            if (dt == null) return false;
            //插入新的数据行
            Env.DB.createuser.Insert(
                    new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.UserName, cmbUserName.Text),
                    new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.PassWord, txbPassWord.Text),
                    new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.Department, cmbDepartment.Text)
                    );
            return true;
        }
        //修改数据行到MySQL数据库
        private bool ModifyDB(string dbName, string dbdsName, string username, string password, string department)
        {
            bool flag = true;
            //数据库的修改行
            Env.DB.createuser.Update($"{DBNames.T_Col_Name.createuser.UserName}= '{cmbUserName.Text}'",
                new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.UserName, cmbUserName.Text),
                new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.PassWord, txbPassWord.Text),
                new QwUI.Data.DIL.UpdateItem(DBNames.T_Col_Name.createuser.Department, cmbDepartment.Text));
            return flag;
        }
        //删除数据行到MySQL数据库
        private bool DeleteRecord(string dbName, string dbdsName, string url)
        {
            bool flag = true;
            //数据库的删除行
            Env.DB.createuser.Delete($"{DBNames.T_Col_Name.createuser.UserName}='{cmbUserName.Text}'");
            return flag;
        }
        ListViewItem itemlist = new ListViewItem();
        //查询MySQL数据行方法
        public bool QueryDB(string dbName, string dbdsName, string username)
        {
            var dt = Env.DB.createuser.GetData();
            if (dt == null) return false;
            foreach (DataRow item in dt.Rows)
            {
                itemlist.Text = Convert.ToString(item[DBNames.T_Col_Name.createuser.UserName]);
                cmbUserName.Items.Add(itemlist.Text);
            }
            return true;
        }

        //数据库查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //查询数据库的时候先把集合items清空
            cmbUserName.Items.Clear();
            //执行查询功能，按照用户名进行查询
            QueryDB("purete", "createuser", cmbUserName.Text);
            if (itemlist.Text != cmbUserName.Text)
            {
                MessageBox.Show("查询用户名不存在，请输入正确的用户名");
            }
            else
            {
                MessageBox.Show("查询用户名已存在");
            }
        }
        //数据行删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //查询数据库的时候先把集合items清空
            cmbUserName.Items.Clear();
            //在执行插入数据行之前先根据用户名查询
            QueryDB("purete", "createuser", cmbUserName.Text);
            if (cmbUserName.Text == itemlist.Text)
            {
                //通过用户名来删除数据表的数据行
                DeleteRecord("purete", "createuser", cmbUserName.Text);
                //清除当前用户名
                cmbUserName.Text = "";
                //清除当前用户密码
                txbPassWord.Text = "";
                MessageBox.Show("用户名删除成功");
            }
            else
            {
                MessageBox.Show("未选中有效的用户名");
            }
        }
        //修改数据行
        private void btnModify_Click(object sender, EventArgs e)
        {
            //执行修改数据指令
            ModifyDB("purete", "createuser", cmbUserName.Text, txbPassWord.Text, cmbDepartment.Text);
            //修改完数据行后进行查询看是否修改成功
            QueryDB("purete", "createuser", cmbUserName.Text);
            if (cmbUserName.Text == itemlist.Text)
            {
                MessageBox.Show("数据行修改成功");
            }
            else
            {
                MessageBox.Show("数据行修改失败");
            }
        }
        /// <summary>
        /// 插入数据行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //插入数据行
            string username = cmbUserName.Text;
            string password = txbPassWord.Text;
            string department = cmbDepartment.Text;
            //在新建新的用户信息前先把cmbusername的内容清除掉；
            //然后在插入之前先进行查询，如果查询到数据库有信息则显示则显示当前用户名已存在
            if (cmbUserName.Items.Count != 0)
            {
                cmbUserName.Items.Clear();
                itemlist.SubItems.Clear();
            }
            else
            {
                //在执行插入数据行之前先根据用户名查询
                QueryDB("purete", "createuser", cmbUserName.Text);
                if (cmbUserName.Text == itemlist.Text)
                {
                    MessageBox.Show("当前用户名已存在，请输入新的用户名");
                }
                else
                {
                    InsertDataToMysql("purete", "createuser", null, username, password, department);
                    MessageBox.Show("新建用户名成功");
                }
            }
        }

        ArrayList userNameList = new ArrayList();
        //新建数据库和数据表
        private void frmNewUser_Load(object sender, EventArgs e)
        {
            if (CreateMysqlDataBase("purete"))
                if (CreateMysqlDataSet("purete", "createuser") == false)
                    MessageBox.Show("CreateUser数据表不存在", "提示");
            QueryDBNotes1("purete", "createuser");
        }

        //查询MySQL数据行方法
        public bool QueryDBNotes1(string dbName, string dbdsName)
        {
            var dt = Env.DB.createuser.GetData();
            if (dt == null) return false;
            foreach (DataRow item in dt.Rows)
            {
                cmbUserName.Items.Add(Convert.ToString(item[DBNames.T_Col_Name.createuser.UserName]));
            }
            return true;




        }
        /// <summary>
        /// 关闭窗体，退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            //退出应用
            //Application.Exit();
        }
    }
}
