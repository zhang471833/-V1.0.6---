using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TcpDemo//命名空间
{
    public partial class Z通讯设置 : UserControl                                //定义公共局部类//用户控件（A通讯设置：UserControl）
    {
        public Z通讯设置()                                                       //
        {
            InitializeComponent();                                              //初始化组件
        }
        //全局变量定义，定义plcHandle初始值为0；最大值和最小值为0；定义字符串：该数据类型是... ...
        public static Int32 plcHandle = 0;
        public int iConnect = 1;
        public A0开机画面 parentForm;
        //输入IP地址后，点击连接按钮，进行通讯连接
        private void btConnect_Click(object sender, EventArgs e)
        {
            //comm_Connect();             //点击通讯连接按钮，调用通讯连接方法
            //A0开机画面 parent = (A0开机画面)Parent.FindForm();
            //parent.vhb_Tiaomachoice_Display();
        }
        //创建plc，creatPlc
        public void CreatPlc()
        {
            //plcHandle = CS7TCP.CreatePlc();                                 //创建plc连接
            //string thisPath = Application.StartupPath + @"\Default.ini";    //定义变量thisPath，获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称+路径
            //if (!System.IO.File.Exists(thisPath)) return;                   //确定指定的文件是否存在（文件的路径）；如果不存在则执行return
            //try
            //{
            //    string[] strArr;                                            //定义一个数组类型的字符串
            //    string str = System.IO.File.ReadAllText(thisPath);          //打开一个文本文件，读取文件的所有行，然后关闭该文件
            //    strArr = str.Split(Convert.ToChar("/"));                    //将字符串的第一个字符转换成Unicode字符"/"
            //    this.txtIP.Text = strArr[0];                                //获取或设置textbox中的当前文本
            //    if (strArr[3] == "1") chkReadIm.Checked = true;             //如果字符串中的第4个字符为1，chkReadIm是写入后立即读回的CheckBox
            //}
            //catch { }
        }




        //保存IP地址为默认参数
        private void btSetDefault_Click(object sender, EventArgs e)
        {
            //string thisCheckValue = "0";
            //if (chkReadIm.Checked) thisCheckValue = "1";                            //写入后立即回读选中
            //string str = this.txtIP.Text.Trim() + "/" + 0 + "/" + 1 + "/" + thisCheckValue;
            //System.IO.File.WriteAllText(Application.StartupPath + @"\Default.ini", str);
            //A0开机画面 parent = (A0开机画面)Parent.FindForm();
            //parent.showLog("保存PLC连接参数的默认值成功！");
        }
        //断开通讯连接
        public void btDisConnect_Click(object sender, EventArgs e)
        {
            //comm_DisConnect();
            //A0开机画面 parent = (A0开机画面)Parent.FindForm();
            ////parent.showLog("PLC连接断开");
            //parent.lab_Communication.Text = "False";
            //parent.lab_Communication.BackColor = Color.Red;
        }

        /// <summary>
        /// checkBox的选用功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbchoice_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}