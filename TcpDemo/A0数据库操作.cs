///数据库操作还有维修提醒数据表的数据行插入未完成，还没有想清楚展示的格式；
///维修提醒数据表的数据行插入未完成，还没有想清楚展示的格式；
///数据一键导出为Excel未完成；
/// ；
/// ；
/// ；
/// 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data.OleDb;

namespace TcpDemo
{
    public partial class A0数据库操作 : UserControl
    {
        public A0开机画面 parentForm;                //定义公共变量，类型为winform窗体，名称：parentForm
        public A0数据库操作()
        {
            InitializeComponent();
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

        //配方数据记录数据表的创建、查询、插入等
        #region
        //创建新的数据库数据表Table，创建表的时候需要有数据库名字和数据表名字；
        private bool CreateMysqlDataSet(string dbName, string dbdsName)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            //对Mysql操作命令类
            try
            {
                string dbds = dbName + "." + dbdsName;
                //实际操作任务
                string commandString = @"create table if not exists " + dbds + @" (
	                                        id		INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                                        	productNO		    VARCHAR(255) NOT NULL,
                                            machine_name		    VARCHAR(255) NOT NULL,
                                            date        	TEXT NOT NULL,
                                            Notes1		TEXT NOT NULL,
                                            link            VARCHAR(255) NOT NULL ,
                                            Notes2		TEXT NOT NULL,
                                            Notes3		TEXT NOT NULL,
                                            Notes4		TEXT NOT NULL,
                                            Notes5		TEXT NOT NULL,
                                            Notes6		TEXT NOT NULL,
                                            Notes7		TEXT NOT NULL,
                                            Notes8		TEXT NOT NULL,
                                            Notes9		TEXT NOT NULL,
                                            Notes10		TEXT NOT NULL,
                                            Notes11		TEXT NOT NULL,
                                            Notes12		TEXT NOT NULL,
                                            Notes13		TEXT NOT NULL,
                                            Notes14		TEXT NOT NULL,
                                            Notes15		TEXT NOT NULL,
                                            Notes16		TEXT NOT NULL,
                                            Notes17		TEXT NOT NULL,
                                            Notes18		TEXT NOT NULL,
                                            Notes19		TEXT NOT NULL,
                                            Notes20		TEXT NOT NULL,
                                            Notes21		TEXT NOT NULL,
                                            Notes22		TEXT NOT NULL,
                                            Notes23		TEXT NOT NULL,
                                            Notes24		TEXT NOT NULL,
                                            Notes25		TEXT NOT NULL,
                                            Notes26		TEXT NOT NULL,
                                            Notes27		TEXT NOT NULL,
                                            Notes28		TEXT NOT NULL,
                                            Notes29		TEXT NOT NULL,
                                            Notes30		TEXT NOT NULL,
                                            Notes31		TEXT NOT NULL,
                                            Notes32		TEXT NOT NULL,
                                            Notes33		TEXT NOT NULL,
                                            Notes34		TEXT NOT NULL,
                                            Notes35		TEXT NOT NULL
                                        )ENGINE=MyISAM  DEFAULT CHARSET=gbk AUTO_INCREMENT=1";
                //创建表Table
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
        //插入数据行到MySQL数据库，调用此方法的时候需要有数据库名字和数据库表的名字
        public bool InsertDataToMysql(string dbName, string dbdsName, string value)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                //定义字符串变量，dbds=数据库名字+数据库表名字；
                string dbds = dbName + "." + dbdsName;
                //定义字符串变量，value（）；
                //value = "( null,'" + txbWebSiteName.Text + "','" + txbTime.Text + "','" + txbNotes.Text + "','" + txbWebUrl.Text + "')";
                //string value = "(null,'2017013000111AAA(透明底)','2018/12/24 6:33:54','3','5','6','7','0','0','0','0','0','0','0','0','0','0','0','0')";
                //插入，需要指定数据库名字和数据库表名字；
                string commandString = @"replace INTO " + dbds + @" ( id, productNO,machine_name,date, Notes1,link,Notes2,Notes3,Notes4,Notes5,Notes6,Notes7,Notes8,Notes9,Notes10,Notes11,Notes12,Notes13,Notes14,Notes15,Notes16,Notes17,Notes18,Notes19,Notes20,Notes21,Notes22,Notes23,Notes24,Notes25,Notes26,Notes27,Notes28,Notes29,Notes30,Notes31,Notes32,Notes33,Notes34,Notes35) VALUES" + value;
                //new一个MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                //打开mysql链接
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
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

        //查询MySQL数据行
        private bool QueryDB(string dbName, string dbdsName, string url)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                string dbds = dbName + "." + dbdsName;
                string commandString = "select COLUMN_NAME from information_schema.columns where table_name='ce'";
                //MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (listView1.Columns.Count != 0)
                {
                    listView1.Columns.Clear();
                }

                while (mySqlDataReader.Read())
                {
                    listView1.Columns.Add(mySqlDataReader[0].ToString());
                }
                mySqlDataReader.Close();
                commandString = @"select * from " + dbds + " where link='" + url + "'";
                mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = mySqlDataReader["id"].ToString();
                    item.SubItems.Add(mySqlDataReader["productNO"].ToString());
                    item.SubItems.Add(mySqlDataReader["machine_name"].ToString());
                    item.SubItems.Add(mySqlDataReader["date"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes1"].ToString());
                    item.SubItems.Add(mySqlDataReader["link"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes2"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes3"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes4"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes5"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes6"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes7"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes8"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes9"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes10"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes11"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes12"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes13"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes14"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes15"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes16"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes17"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes18"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes19"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes20"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes21"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes22"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes23"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes24"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes25"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes26"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes27"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes28"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes29"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes30"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes31"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes32"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes33"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes34"].ToString());
                    item.SubItems.Add(mySqlDataReader["Notes35"].ToString());

                    listView1.Items.Add(item);
                }
                mySqlDataReader.Close();

                commandString = @"set names gbk;select * from " + dbds + " where link='" + url + "'";
                MySqlDataAdapter myadp = new MySqlDataAdapter(commandString, mySqlConnection);
                //声明数据适配器，执行数据查询  
                DataSet ds = new DataSet();//声明数据集  
                myadp.Fill(ds, "ce");//把查到的结果填充到数据集中  
                mySqlConnection.Close();//关闭连接  
                this.dataGridView1.DataSource = ds.Tables["ce"];
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





        //修改数据行到MySQL数据库
        private bool ModifyDB(string dbName, string dbdsName, string url, string title)
        {
            bool flag = true;
            //定义变量connstring；Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                string dbds = dbName + "." + dbdsName;
                string commandString = @"update " + dbds + " set title='" + title + "' where link='" + url + "'";
                //MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
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
        //删除数据行到MySQL数据库
        private bool DeleteRecord(string dbName, string dbdsName, string url)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                string dbds = dbName + "." + dbdsName;
                string commandString = @"delete from " + dbds + " where link='" + url + "'";
                //MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
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


        //新建数据库和数据表
        private void btCreateDatabases_Click(object sender, EventArgs e)
        {
            if (txbDBname.Text != "" & cmbTables.Text != "")
            {
                if (CreateMysqlDataBase(txbDBname.Text))
                    if (CreateMysqlDataSet(txbDBname.Text, cmbTables.Text))
                        MessageBox.Show("配方数据记录表创建成功", "提示");
            }
            else
                MessageBox.Show("创建失败，请正确填写数据库名称与数据表名称", "提示");
        }
        //查询数据库         按照配方号查询
        private void btQuery_Click_1(object sender, EventArgs e)
        {
            QueryDB(txbDBname.Text, cmbTables.Text, txbRecipeNo.Text);
        }
        #endregion



        //软件操作记录数据表的闯将、查询、插入等
        #region
        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (txbDBname.Text != "" & cmbTables.Text != "")
            {
                if (CreateMysqlDataBase(txbDBname.Text))
                    if (CreateMysqlDataSetOperation(txbDBname.Text, "OperationTable"))
                        MessageBox.Show("设备软件操作记录数据表创建成功", "提示");
            }
            else
                MessageBox.Show("创建失败，请正确填写数据库名称与数据表名称", "提示"); 
        }
        //创建新的数据库数据表Table，创建表的时候需要有数据库名字和数据表名字；
        private bool CreateMysqlDataSetOperation(string dbName, string dbdsName)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            //对Mysql操作命令类
            try
            {
                string dbds = dbName + "." + dbdsName;
                //实际操作任务
                string commandString = @"create table if not exists " + dbds + @" (
	                                        id		INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                                            Dates	TEXT NOT NULL,
                                            Name   TEXT NOT NULL,
                                            Department   TEXT NOT NULL,
                                            Logs   TEXT NOT NULL
                                        )ENGINE=MyISAM  DEFAULT CHARSET=gbk AUTO_INCREMENT=1";
                //创建表Table
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
        //插入数据行到MySQL数据库，调用此方法的时候需要有数据库名字和数据库表的名字
        public bool InsertDataToMysqlOperation(string dbName, string dbdsName,string value)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                //定义字符串变量，dbds=数据库名字+数据库表名字；
                string dbds = dbName + "." + dbdsName;
                //定义字符串变量，value（）；
                //value = "( null,'" + txbWebSiteName.Text + "','" + txbTime.Text + "','" + txbNotes.Text + "','" + txbWebUrl.Text + "')";
                
                //插入，需要指定数据库名字和数据库表名字；
                string commandString = @"replace INTO " + dbds + @" ( id, Dates,Name,Department, Logs) VALUES" + value;
                //new一个MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                //打开mysql链接
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
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
        //查询     软件操作记录MySQL数据行
        private bool QueryDBOperation(string dbName, string dbdsName, string username)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                string dbds = dbName + "." + dbdsName;
                string commandString = "select COLUMN_NAME from information_schema.columns where table_name='ce'";
                //MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (listView1.Columns.Count != 0)
                {
                    listView1.Columns.Clear();
                }
                while (mySqlDataReader.Read())
                {
                    listView1.Columns.Add(mySqlDataReader[0].ToString());
                }
                mySqlDataReader.Close();
                commandString = @"select * from " + dbds + " where Name='" + username + "'";
                mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = mySqlDataReader["id"].ToString();
                    item.SubItems.Add(mySqlDataReader["Dates"].ToString());
                    item.SubItems.Add(mySqlDataReader["Name"].ToString());
                    item.SubItems.Add(mySqlDataReader["Department"].ToString());
                    item.SubItems.Add(mySqlDataReader["Logs"].ToString());

                    listView1.Items.Add(item);
                }
                mySqlDataReader.Close();

                commandString = @"set names gbk;select * from " + dbds + " where Name='" + username + "'";
                MySqlDataAdapter myadp = new MySqlDataAdapter(commandString, mySqlConnection);
                //声明数据适配器，执行数据查询  
                DataSet ds = new DataSet();//声明数据集  
                myadp.Fill(ds, "ce");//把查到的结果填充到数据集中  
                mySqlConnection.Close();//关闭连接  
                this.dataGridView1.DataSource = ds.Tables["ce"];
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
        //查询       操作记录数据表      按照操作员名字进行查询
        private void btQueryOperation_Click(object sender, EventArgs e)
        {
            if (cmbUserName.Text != "")
            {
                //按照用户名进行查询
                QueryDBOperation(txbDBname.Text, "OperationTable", cmbUserName.Text);
            }
            else
            {
                MessageBox.Show("请输入正确的用户名", "提示");
            }   
        }
        //当鼠标点击输入框的时候先把已有的用户名加载进来
        private void cmbUserName_Click(object sender, EventArgs e)
        {
            //查询createuser数据表的所有用户名
            QueryDBNotes1("purete", "createuser");
        }
        ArrayList userNameList = new ArrayList();
        //查询MySQL数据行方法
        public bool QueryDBNotes1(string dbName, string dbdsName)
        {
            //查询之前先把列表清除
            userNameList.Clear();
            //查询前先把文本框清零
            cmbUserName.Items.Clear();
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                string dbds = dbName + "." + dbdsName;
                string commandusername = null;
                //查询数据列名字为“Notes1”的所有数据
                commandusername = @"select Notes1 from " + dbds;
                mySqlConnection.Open();
                //MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandusername, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    userNameList.Add(mySqlDataReader["Notes1"].ToString());
                }
                mySqlDataReader.Close();
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
            //遍历ArrayList的用户名数组，然后添加在cmbUserName的combobox的items内
            foreach (string username in userNameList)
            {
                cmbUserName.Items.Add(username);
            }
            return flag;
        }
        #endregion




        //运行状态数据表操作         监控设备运行状态，总控的启动、停止、复位、待机和各个单机报警信息      ProcessStatusTable
        #region
        //创建运行状态记录数据表
        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (txbDBname.Text != "")
            {
                if (CreateMysqlDataBase(txbDBname.Text))
                    if (CreateMysqlDataSetStatus(txbDBname.Text, "ProcessStatusTable"))
                        MessageBox.Show("设备运行状态记录表创建成功", "提示");
            }
            else
                MessageBox.Show("创建失败，请正确填写数据库名称与数据表名称", "提示");
        }
        //创建新的数据库数据表Table，创建表的时候需要有数据库名字和数据表名字；
        private bool CreateMysqlDataSetStatus(string dbName, string dbdsName)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            //对Mysql操作命令类
            try
            {
                string dbds = dbName + "." + dbdsName;
                //实际操作任务
                string commandString = @"create table if not exists " + dbds + @" (
                                            id		INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                                            Dates   TEXT NOT NULL,
                                            Logs		TEXT NOT NULL
                                        )ENGINE=MyISAM  DEFAULT CHARSET=gbk AUTO_INCREMENT=1";
                //创建表Table
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
        //插入数据行到MySQL数据库，调用此方法的时候需要有数据库名字和数据库表的名字
        public bool InsertDataToMysqlStatus(string dbName, string dbdsName, string value)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                //定义字符串变量，dbds=数据库名字+数据库表名字；
                string dbds = dbName + "." + dbdsName;
                //定义字符串变量，value（）；
                //value = "( null,'" + txbWebSiteName.Text + "','" + txbTime.Text + "','" + txbNotes.Text + "','" + txbWebUrl.Text + "')";

                //插入，需要指定数据库名字和数据库表名字；
                string commandString = @"replace INTO " + dbds + @" ( id, Dates, Logs) VALUES" + value;
                //new一个MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                //打开mysql链接
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
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

        //运行状态监控表 查询
        private void btQueryStatus_Click(object sender, EventArgs e)
        {
            //判断起始日期
            if (dTPRunStatusBegin.Value <= dTPRunStatusStop.Value)
            {
                //按照时间段进行查询
                QueryDBStatus(txbDBname.Text, "ProcessStatusTable", Convert.ToString(dTPRunStatusBegin.Value), Convert.ToString(dTPRunStatusStop.Value)); 
            }
            else
            {
                MessageBox.Show("终止日期需大于起始日期", "提示");
            }
        }

        //查询MySQL数据行方法
        public bool QueryDBStatus(string dbName, string dbdsName, string datebegin, string datefinish)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                string dbds = dbName + "." + dbdsName;
                string commandString = "select COLUMN_NAME from information_schema.columns where table_name='ce'";
                //MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (listView1.Columns.Count != 0)
                {
                    listView1.Columns.Clear();
                }

                while (mySqlDataReader.Read())
                {
                    listView1.Columns.Add(mySqlDataReader[0].ToString());
                }
                mySqlDataReader.Close();
                commandString = @"select * from " + dbds + " where Dates>='"+ datebegin+ "' and Dates<'" + datefinish + "'";
                mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = mySqlDataReader["id"].ToString();
                    item.SubItems.Add(mySqlDataReader["Dates"].ToString());
                    item.SubItems.Add(mySqlDataReader["Logs"].ToString());

                    listView1.Items.Add(item);
                }
                mySqlDataReader.Close();

                commandString = @"select * from " + dbds + " where Dates>='" + datebegin + "' and Dates<'" + datefinish + "'";
                MySqlDataAdapter myadp = new MySqlDataAdapter(commandString, mySqlConnection);
                //声明数据适配器，执行数据查询  
                DataSet ds = new DataSet();//声明数据集  
                myadp.Fill(ds, "ce");//把查到的结果填充到数据集中  
                mySqlConnection.Close();//关闭连接  
                this.dataGridView1.DataSource = ds.Tables["ce"];
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
        #endregion






        //设备耗材管理数据表
        #region
        //创建      设备耗材管理数据表
        private void btnMaterials_Click(object sender, EventArgs e)
        {
            if (txbDBname.Text != "")
            {
                if (CreateMysqlDataBase(txbDBname.Text))
                    if (CreateMysqlDataSetMaterials(txbDBname.Text, "MaterialsTable"))
                        MessageBox.Show("设备耗材管理表创建成功", "提示");
            }
            else
                MessageBox.Show("创建失败，请正确填写数据库名称与数据表名称", "提示");
        }
        //创建新的数据库数据表Table，创建表的时候需要有数据库名字和数据表名字；
        private bool CreateMysqlDataSetMaterials(string dbName, string dbdsName)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            //对Mysql操作命令类
            try
            {
                string dbds = dbName + "." + dbdsName;
                //实际操作任务
                string commandString = @"create table if not exists " + dbds + @" (
                                            id		INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                                            Dates   TEXT NOT NULL,
                                            NOtes1		TEXT NOT NULL,
                                            NOtes2		TEXT NOT NULL,
                                            NOtes3		TEXT NOT NULL,
                                            NOtes4		TEXT NOT NULL,
                                            NOtes5		TEXT NOT NULL,
                                            NOtes6		TEXT NOT NULL,
                                            NOtes7		TEXT NOT NULL,
                                            NOtes8		TEXT NOT NULL,
                                            NOtes9		TEXT NOT NULL,
                                            NOtes10		TEXT NOT NULL,
                                            NOtes11		TEXT NOT NULL,
                                            NOtes12		TEXT NOT NULL,
                                            NOtes13		TEXT NOT NULL,
                                            NOtes14		TEXT NOT NULL,
                                            NOtes15		TEXT NOT NULL,
                                            NOtes16		TEXT NOT NULL,
                                            NOtes17		TEXT NOT NULL,
                                            NOtes18		TEXT NOT NULL,
                                            NOtes19		TEXT NOT NULL,
                                            NOtes20		TEXT NOT NULL
                                        )ENGINE=MyISAM  DEFAULT CHARSET=gbk AUTO_INCREMENT=1";
                //创建表Table
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
        //插入数据行到MySQL数据库，调用此方法的时候需要有数据库名字和数据库表的名字
        public bool InsertDataToMysqlMaterials(string dbName, string dbdsName, string value)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                //定义字符串变量，dbds=数据库名字+数据库表名字；
                string dbds = dbName + "." + dbdsName;
                //插入，需要指定数据库名字和数据库表名字；
                string commandString = @"replace INTO " + dbds + @" ( id, Dates, NOtes1,NOtes2,NOtes3,NOtes4,NOtes5,NOtes6,NOtes7,NOtes8,NOtes9,NOtes10,NOtes11,NOtes12,NOtes13,NOtes14,NOtes15,NOtes16,NOtes17,NOtes18,NOtes19,NOtes20) VALUES" + value;
                //new一个MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                //打开mysql链接
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
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
        //查询      耗材管理数据表 查询
        private void btQueryMaterial_Click(object sender, EventArgs e)
        {
            //判断起始日期
            if (dTPMaterialsBegin.Value <= dTPMaterialsStop.Value)
            {
                //按照时间段进行查询
                QueryDBMaterials(txbDBname.Text, "MaterialsTable", Convert.ToString(dTPMaterialsBegin.Value), Convert.ToString(dTPMaterialsStop.Value));
            }
            else
            {
                MessageBox.Show("终止日期需大于起始日期", "提示");
            }
        }
        //查询MySQL数据行方法
        public bool QueryDBMaterials(string dbName, string dbdsName, string datebegin, string datefinish)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                string dbds = dbName + "." + dbdsName;
                string commandString = "select COLUMN_NAME from information_schema.columns where table_name='ce'";
                //MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (listView1.Columns.Count != 0)
                {
                    listView1.Columns.Clear();
                }
                while (mySqlDataReader.Read())
                {
                    listView1.Columns.Add(mySqlDataReader[0].ToString());
                }
                mySqlDataReader.Close();
                commandString = @"select * from " + dbds + " where Dates>='" + datebegin + "' and Dates<'" + datefinish + "'";
                mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = mySqlDataReader["id"].ToString();
                    item.SubItems.Add(mySqlDataReader["Dates"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes1"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes2"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes3"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes4"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes5"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes6"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes7"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes8"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes9"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes10"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes11"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes12"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes13"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes14"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes15"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes16"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes17"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes18"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes19"].ToString());
                    item.SubItems.Add(mySqlDataReader["NOtes20"].ToString());

                    listView1.Items.Add(item);
                }
                mySqlDataReader.Close();

                commandString = @"select * from " + dbds + " where Dates>='" + datebegin + "' and Dates<'" + datefinish + "'";
                MySqlDataAdapter myadp = new MySqlDataAdapter(commandString, mySqlConnection);
                //声明数据适配器，执行数据查询  
                DataSet ds = new DataSet();//声明数据集  
                myadp.Fill(ds, "ce");//把查到的结果填充到数据集中  
                mySqlConnection.Close();//关闭连接  
                this.dataGridView1.DataSource = ds.Tables["ce"];
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
        #endregion






        //设备维护数据表操作
        #region
        //设备维护提醒数据表
        private void btnRepairs_Click(object sender, EventArgs e)
        {
            if (txbDBname.Text != "")
            {
                if (CreateMysqlDataBase(txbDBname.Text))
                    if (CreateMysqlDataSetRepairs(txbDBname.Text, "RepairsTable"))
                        MessageBox.Show("设备维护提醒数据表创建成功", "提示");
            }
            else
                MessageBox.Show("创建失败，请正确填写数据库名称与数据表名称", "提示");
        }
        
        //创建新的数据库数据表Table，创建表的时候需要有数据库名字和数据表名字；
        private bool CreateMysqlDataSetRepairs(string dbName, string dbdsName)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            //对Mysql操作命令类
            try
            {
                string dbds = dbName + "." + dbdsName;
                //实际操作任务
                string commandString = @"create table if not exists " + dbds + @" (
                                            id		INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                                            Dates   TEXT NOT NULL,
                                            NOtes1		TEXT NOT NULL,
                                            NOtes2		TEXT NOT NULL,
                                            NOtes3		TEXT NOT NULL,
                                            NOtes4		TEXT NOT NULL,
                                            NOtes5		TEXT NOT NULL,
                                            NOtes6		TEXT NOT NULL,
                                            NOtes7		TEXT NOT NULL,
                                            NOtes8		TEXT NOT NULL,
                                            NOtes9		TEXT NOT NULL,
                                            NOtes10		TEXT NOT NULL,
                                            NOtes11		TEXT NOT NULL,
                                            NOtes12		TEXT NOT NULL,
                                            NOtes13		TEXT NOT NULL,
                                            NOtes14		TEXT NOT NULL,
                                            NOtes15		TEXT NOT NULL,
                                            NOtes16		TEXT NOT NULL,
                                            NOtes17		TEXT NOT NULL,
                                            NOtes18		TEXT NOT NULL,
                                            NOtes19		TEXT NOT NULL,
                                            NOtes20		TEXT NOT NULL
                                        )ENGINE=MyISAM  DEFAULT CHARSET=gbk AUTO_INCREMENT=1";
                //创建表Table
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
        //插入数据行到MySQL数据库，调用此方法的时候需要有数据库名字和数据库表的名字
        public bool InsertDataToMysqlRepairs(string dbName, string dbdsName, string value)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                //定义字符串变量，dbds=数据库名字+数据库表名字；
                string dbds = dbName + "." + dbdsName;
                //插入，需要指定数据库名字和数据库表名字；
                string commandString = @"replace INTO " + dbds + @" ( id, Dates, NOtes1,NOtes2,NOtes3,NOtes4,NOtes5,NOtes6,NOtes7,NOtes8,NOtes9,NOtes10,NOtes11,NOtes12,NOtes13,NOtes14,NOtes15,NOtes16,NOtes17,NOtes18,NOtes19,NOtes20) VALUES" + value;
                //new一个MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                //打开mysql链接
                mySqlConnection.Open();
                mySqlCommand.ExecuteNonQuery();
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
        //查询        维护提醒数据表  查询
        private void btQueryRepair_Click(object sender, EventArgs e)
        {
            //判断起始日期
            if (dTPRepairsBegin.Value <= dTPRepairsStop.Value)
            {   
                //按照时间段进行查询
                QueryDBMaterials(txbDBname.Text, "RepairsTable", Convert.ToString(dTPRepairsBegin.Value), Convert.ToString(dTPRepairsStop.Value));
            }
            else
            {
                MessageBox.Show("终止日期需大于起始日期", "提示");
            }
        }
        //查询            查询MySQL数据行方法        查询维修提醒信息            按照时间范围进行查询
        public bool QueryDBRepair(string dbName, string dbdsName, string datebegin, string datefinish)
        {
            bool flag = true;
            //Mysql连接字符串
            string connString = @"Server=localhost;User Id=root;Password=root1234;Charset=gbk;Persist Security Info=True;Database=" + dbName;
            //实例化Mysql连接对象
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            try
            {
                string dbds = dbName + "." + dbdsName;
                string commandString = "select COLUMN_NAME from information_schema.columns where table_name='ce'";
                //MySql将要执行的命令
                MySqlCommand mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (listView1.Columns.Count != 0)
                {
                    listView1.Columns.Clear();
                }
                while (mySqlDataReader.Read())
                {
                    listView1.Columns.Add(mySqlDataReader[0].ToString());
                }
                mySqlDataReader.Close();
                commandString = @"select * from " + dbds + " where Dates>='" + datebegin + "' and Dates<'" + datefinish + "'";
                mySqlCommand = new MySqlCommand("set names gbk;" + commandString, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = mySqlDataReader["id"].ToString();
                    item.SubItems.Add(mySqlDataReader["Dates"].ToString());
                    item.SubItems.Add(mySqlDataReader["Logs"].ToString());

                    listView1.Items.Add(item);
                }
                mySqlDataReader.Close();

                commandString = @"select * from " + dbds + " where Dates>='" + datebegin + "' and Dates<'" + datefinish + "'";
                MySqlDataAdapter myadp = new MySqlDataAdapter(commandString, mySqlConnection);
                //声明数据适配器，执行数据查询  
                DataSet ds = new DataSet();//声明数据集  
                myadp.Fill(ds, "ce");//把查到的结果填充到数据集中  
                mySqlConnection.Close();//关闭连接  
                this.dataGridView1.DataSource = ds.Tables["ce"];
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
        #endregion

        private void btnExport_Click(object sender, EventArgs e)
        {
            //select* from purete.uvdry into outfile'C:/ProgramData/MySQL/MySQL Server 5.7/Uploads/abc.xls';
            string filePath = "C:\\Users\\shenyang\\Desktop\\数据表存储";
            string OleDbConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = .\\Data\\Student.accdb;Jet OLEDB:Database Password = 123456";
            OleDbConnection cnn = new OleDbConnection(OleDbConnectionString);
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand("select count(*) from [Books]", cnn);
            int num = (int)(cmd.ExecuteScalar());
            //如果数据项的个数大于一个sheet表的最大行数，则拆分保存在多个sheet表中
            if (num <= 65535)
            {
                // [Excel 8.0;database= excel名].[sheet名] 如果是新建sheet表不能加$，如果向sheet里插入数据要加$
                // Excel 2003的sheet表最大行数65536，最大列数256。因为列头要占据一行，所以最多存储65535条数据
                cmd = new OleDbCommand("select top 65535 ISBN as ISBN, Title as 书名, Author as 作者, RegisterTime as 登记时间 into [Excel 8.0;database=" + filePath + "].[书籍表] from Books order by RegisterTime desc", cnn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                int num2 = num, i = 1;
                while (num2 > 0)
                {
                    cmd = new OleDbCommand("select top 65535 * into [Excel 8.0;database=" + filePath + "].[书籍表" + i + "] from (select top " + num2 + " ISBN as ISBN, Title as 书名, Author as 作者, RegisterTime as 登记时间 from Books order by RegisterTime)  order by 登记时间 desc", cnn);
                    cmd.ExecuteNonQuery();
                    num2 -= 65535;
                    i++;
                }
            }
            cmd.Dispose();
            cnn.Close();
            cnn.Dispose();

        }
    }
}
