using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TcpDemo
{
    public partial class A0参数设置 : UserControl
    {
        
        public A0参数设置()
        {
            InitializeComponent();
        }
        public A0开机画面 parentForm;                //定义公共变量，类型为winform窗体，名称：parentForm
        string typeName = null;
        //设备编号
        int type = 0;
        //增加的设备通讯地址（总控的DB块编号）
        string address = null;
        //设备的主类型例如（UV干燥机）
        //int Machine_type = 0;
        //设备的子类型例如（单灯、双灯、三灯、四灯等）
        int childType = 0;
        int num = 0;
        int maxvalue = 3;
        int countnum = 0;

        int machinetype;
        int machineParents;
        //int num= maxvalue;
        private void A0参数设置_Load(object sender, EventArgs e)
        {
            num = 0;
            timer1.Enabled = true;
            Readbackini();
            btn_Save.Enabled = false;
            lb_MachineList.Items.Remove("*");
        }
        //添加设备到列表中
        private void btn_AddMachine_Click(object sender, EventArgs e)
        {
            //定义字符串变量
            string machinenametext = Convert.ToString(cbox_Machine.Text);
            string str0 = null;

            //“添加字符”按钮事件，若字符为空和字符重复的情况下
            //都会弹出警告窗口
            if (cbox_Machine.Text == "")
            {
                string msg = String.Format("选择设备不能为空");
                MessageBox.Show(msg, "");
                return;
            }
            else
            {
                if (lb_MachineList.Items.Count > 0)
                    for (int i = 0; i < lb_MachineList.Items.Count; i++)
                        str0 = lb_MachineList.Items[i].ToString();
                        if (str0.Contains(machinenametext) == true)  
                        {
                     countnum = countnum+1;
                            maxvalue = maxvalue + 1;
                        }
                        else
                        {
                            maxvalue = 1;
                        }
            }

            lb_MachineList.Items.Add(Convert.ToString("*" + machinenametext + "@" + cbox_Communition_Num.Text + "@" + machineParents + "@" + machinetype));

            btn_Save.Enabled = true;
        }
        //更新ini文件的设备信息内容
        private void Refresh_ini()
        {
            //定义一个字流写入
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath + @"\Devices.ini");
            //遍历lb_MachinrList，向Items内部写入参数
            foreach (string item in lb_MachineList.Items)
            {
                sw.WriteLine(item);
            }
            //写入完成后关闭写入流
            sw.Close();
        }

        //点击生成方案按钮执行的动作
        private void btn_Save_Click(object sender, EventArgs e)
        {
            num = 0;
            timer1.Enabled = false;
            //保存动作时更新ini文件
            Refresh_ini();
            //执行按钮点击事件
            buttonclickevent();
            //保存按钮不可以再次点击
            btn_Save.Enabled = false;


            DialogResult result = MessageBox.Show("请点击“确认”重新启动系统", "系统信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //确定按钮的方法
                Application.Exit();
            }
            else
            { }

        }
        //定义字符串类型变量，本地保存ini文件的存储位置
        string localReadBackMachines;

        //当点击保存按钮的时候均进行设备解析
        private void buttonclickevent()
        {
            num = 0;
            // 清除groundbox里面的所有控件
            splitContainer1.Panel2.Controls.Clear();
            localX = 0;
            localY = 0;
            localX2 = 0;
            // 加载文件，获取已添加设备信息
            string thisPath = Application.StartupPath + @"\Devices.ini";    //定义变量thisPath，获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称+路径
            
            if (!System.IO.File.Exists(thisPath)) return;                   //确定指定的文件是否存在（文件的路径）；如果不存在则执行return
            try
            {
                //打开一个文本文件，读取文件的所有行，然后关闭该文件
                localReadBackMachines = System.IO.File.ReadAllText(thisPath);
                //按照*把字符串分割成数组保存在machines的String数组内
                String[] machines = localReadBackMachines.Split('*');

                //循环查找字符串内部的数组
                for (int i = 0; i < machines.Length; i++)
                {
                    //把提取出来的数组定义成String格式存储
                    String machine = machines[i];
                    //把第一次提取出来的字符串按照@号进行分割成数组arr
                    String[] arr = machine.Split('@');                
                    if (arr.Length > 1)
                    {
                        //设备类型名字
                        String typeName = arr[0];
                        //增加的设备通讯地址（总控的DB块编号）
                        address = arr[1];
                        //设备的主类型例如（UV干燥机）
                        type = int.Parse(arr[2]);
                        //设备的子类型例如（单灯、双灯、三灯、四灯等）
                        childType = int.Parse(arr[3]);
                        //执行button事件，传送参数：设备类型；设备编号；设备坐标X，设备坐标Y，设备通讯地址,设备类型
                        num = num + 1;
                        Button_Event(typeName, num, address, type, childType);
                    }
                }
            }
            catch { }
            //lb_MachineList.Items.RemoveAt(1);
        }

        int localX = 0;
        int localY = 0;
        int localX2 = 0;
        //添加button类型的图片
        public void Button_Event(string type, int bianhao, string address_Machine, int machine_type,int childtype)
        {
            Button toAddButton = new Button();
            // 计算待添加按钮的位置
            
            if (localX< (splitContainer1.Panel2.Width-150))
            {
                localX = 85 + localX;
                localY = 10;
                //设置按钮出现的位置
                toAddButton.Location = new Point(localX, localY);
            }
            else
            {
                localX2 = 85 + localX2;
                localY = 100;
                //设置按钮出现的位置
                toAddButton.Location = new Point(localX2, localY);
            }

            

            //按钮的尺寸为自动模式
            toAddButton.AutoSize = true;
            //把按钮的文本布局设置在底部居中
            toAddButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;

            // 把控件添加到窗口中
            splitContainer1.Panel2.Controls.Add(toAddButton);
            //gbox_View.Controls.Add(toAddButton);
            //设置增加的按钮的文本：设备类型+设备编号
            toAddButton.Text = type + bianhao;
            //设置增加的按钮的名字，名字定义为设备类型
            toAddButton.Name = Convert.ToString(machine_type);
            //设置增加的按钮的标签，名字定义为设备的通讯地址
            //toAddButton.Tag = Convert.ToString(add_machine);
            //根据type获取图片路径
            string[] machinenametogetimage = new string[] {
                "单灯UV干燥机", "双灯UV干燥机", "三灯UV干燥机", "四灯UV干燥机", "五灯UV干燥机","六灯UV干燥机", "七灯UV干燥机", "八灯UV干燥机","干燥机预留","干燥机预留",
                "全精密除尘机","抛光除尘机","双面除尘机","除尘机预留","除尘机预留",
                "6M红外流平机","4M红外流平机","喷射式流平机","流平机预留","流平机预留",
                "全精密单滚涂布机","全精密双滚涂布机","全精密三滚涂布机", "补土+单滚涂布机","补土+双滚涂布机","正逆滚涂布机","全精密补土机","涂布机预留2","涂布机预留3",
                "四级淋幕机","淋幕机预留1","淋幕机预留2","淋幕机预留3",
                "单滚毛刷机","双滚毛刷机","毛刷机预留1","毛刷机预留2",
                "龙门上料机","龙门下料机","龙门上下料机预留1","龙门上下料预留2",
                "底漆砂光机","素板砂光机","砂光机预留1","砂光机预留2",
                "输送机" };
            for (int i=0;i<machinenametogetimage.Length;i++)
            {
                if (type == machinenametogetimage[i])
                {
                    toAddButton.Image = imageList1.Images[i];
                    toAddButton.Font = new Font(toAddButton.Font.FontFamily, 5, toAddButton.Font.Style);
                }
            }
        }
        //从列表中移除被选中的设备
        private void btn_RemoveMachine_Click(object sender, EventArgs e)
        {              
            //删除选中的1个或多个列表项。“移除字符”按钮事件
            //在删除时会对用户进行确认是否真的要删除该字符。
            ListBox.SelectedIndexCollection indices = lb_MachineList.SelectedIndices;
            int count = indices.Count;
            string msg = String.Format("确定要删除这些设备吗？");
            DialogResult result = MessageBox.Show(msg, "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for (int i = count - 1; i >= 0; i--)
                    lb_MachineList.Items.RemoveAt(indices[i]);
            }
            btn_Save.Enabled = true;
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            //根据文本内容给对应的设备类型
            string[] machinenametogetcomobox = new string[] {
                "单灯UV干燥机", "双灯UV干燥机", "三灯UV干燥机", "四灯UV干燥机", "五灯UV干燥机","六灯UV干燥机", "七灯UV干燥机", "八灯UV干燥机","干燥机预留","干燥机预留",
                "全精密除尘机","抛光除尘机","双面除尘机","除尘机预留","除尘机预留",
                "6M红外流平机","4M红外流平机","喷射式流平机","流平机预留","流平机预留",
                "全精密单滚涂布机","全精密双滚涂布机","全精密三滚涂布机", "补土+单滚涂布机","补土+双滚涂布机","正逆滚涂布机","全精密补土机","涂布机预留2","涂布机预留3",
                "四级淋幕机","淋幕机预留1","淋幕机预留2","淋幕机预留3",
                "单滚毛刷机","双滚毛刷机","毛刷机预留1","毛刷机预留2",
                "龙门上料机","龙门下料机","龙门上下料机预留1","龙门上下料预留2",
                "底漆砂光机","素板砂光机","砂光机预留1","砂光机预留2",
                "输送机" };
            //把设备类型定义成数值后赋值
            int[] machinetypevalue = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46 };
            int[] machineParentType = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 10 };
            for (int i = 0; i < machinenametogetcomobox.Length; i++)
            {
                if (cbox_Machine.Text == machinenametogetcomobox[i])
                {
                    machinetype = machinetypevalue[i];
                    machineParents = machineParentType[i];
                }
            }
        }
        //读回本地文件到listbox显示
        private void Readbackini()
        {
            string localReadBackMachines = null;

            //加载文件，获取已添加设备信息
            string thisPath = Application.StartupPath + @"\Devices.ini";    //定义变量thisPath，获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称+路径
            if (!System.IO.File.Exists(thisPath)) return;                   //确定指定的文件是否存在（文件的路径）；如果不存在则执行return
            try
            {
                //打开一个文本文件，读取文件的所有行，然后关闭该文件
                localReadBackMachines = System.IO.File.ReadAllText(thisPath);
                //按照*把字符串分割成数组保存在machines的String数组内
                String[] machines = localReadBackMachines.Split('*');
                //循环查找字符串内部的数组
                for (int i = 0; i < machines.Length; i++)
                {
                    //把提取出来的数组定义成String格式存储
                    String machine = machines[i];
                    //把第一次提取出来的字符串按照@号进行分割成数组arr
                    lb_MachineList.Items.Add("*" + machine);
                    string[] arr = machine.Split('@');
                    if (arr.Length > 1)
                    {
                        typeName = arr[0];
                        address = arr[1];
                    }
                }
            }
            catch { }

            //方案保存按钮
            buttonclickevent();
        }
        //设备上移一个按钮
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            //可以上移1个或多个列表项。“字符上移”按钮事件
            ListBox.SelectedIndexCollection indices = lb_MachineList.SelectedIndices;
            int count = indices.Count;

            for (int i = 0; i < count; i++)
            {
                int j = indices[i];
                string m = lb_MachineList.Items[j].ToString();
                lb_MachineList.Items.RemoveAt(j);
                lb_MachineList.Items.Insert(j - 1, m);
                lb_MachineList.SetSelected(j - 1, true);
            }
            btn_Save.Enabled = true;
        }
        //设备下移一个按钮
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            //可以下移1个或多个字符。“字符下移”按钮事件
            ListBox.SelectedIndexCollection indices = lb_MachineList.SelectedIndices;
            int count = indices.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                int j = indices[i];
                string m = lb_MachineList.Items[j].ToString();
                lb_MachineList.Items.RemoveAt(j);
                lb_MachineList.Items.Insert(j + 1, m);
                lb_MachineList.SetSelected(j + 1, true);
            }
            btn_Save.Enabled = true;
        }
        //listbox被选中的时候允许被上下移动和移除
        private void lb_MachineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledPhotoButtons();
        }
        //当listbox有项目被选中时
        private void EnabledPhotoButtons()
        {
            //如果有列表项被选中，根据列表项是否可以上移或下移，
            //如果可以上移或下移就启用“字符上移”或“字符下移”按钮。
            //只要有列表项被先中，就启用“移除字符”按钮。
            int selCount = lb_MachineList.SelectedIndices.Count;
            bool someSelected = (selCount > 0);
            if (someSelected)
            {
                bool firstSelected = lb_MachineList.GetSelected(0);
                bool lastSelected = lb_MachineList.GetSelected(lb_MachineList.Items.Count - 1);
                btnMoveUp.Enabled = !firstSelected;
                btnMoveDown.Enabled = !lastSelected;
            }
            else
            {
                btnMoveUp.Enabled = false;
                btnMoveDown.Enabled = false;
            }
            btn_RemoveMachine.Enabled = someSelected;
        }
        //当界面的尺寸发生变化时重新更新一次设备排序
        private void A0参数设置_SizeChanged(object sender, EventArgs e)
        {
            //执行按钮点击事件
            buttonclickevent();
        }
    }
}
