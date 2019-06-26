using SCADA.Comm;
using SCADA.Drive;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TcpDemo
{

    //定义公共的设备类
    public class Device : IDisposable
    {
        public string typeName;         //设备类型名称
        public int type;                //设备类型（干燥机/涂布机/流平机/除尘机）
        public int childType;           //设备子类型（单灯干燥机/双灯干燥机/三灯干燥机......）
        public int index;               //设备编号
        public int status;              //设备状态
        public string address;             //设备通讯地址（DB99中的DB块序列号）
        public byte[] data;             //读取或者写入的字节数组，data（配方写入和监视）
        public int recipeNOMain;        //定义总的配方编号
        public string productCodeMain;  //定义总的产品编号

        public decimal Area { get; set; }
        /// <summary>
        /// 定义补土机的属性类型
        /// </summary>
        public List<Wheel> ButuWheel { get; set; }
        /// <summary>
        /// 定义整平轮的属性类型
        /// </summary>
        public List<Wheel> ZhengPingWheel { get; set; }

        /// <summary>
        /// 定义涂布轮的轮子数量
        /// </summary>
        public int ButuWheelCount { get; set; }
        /// <summary>
        /// 定义整平轮的数量
        /// </summary>
        public int ZhengPingWheelCount { get; set; }
        /// <summary>
        /// 定义UV灯的list属性类型
        /// </summary>
        public List<Lamps> UVLamps { get; set; }
        /// <summary>
        /// 定义UV灯的数量属性
        /// </summary>
        public int UVLampsCount { get; set; }
        /// <summary>
        /// 定义一个属性bool类型，判断释放状况
        /// </summary>
        protected bool IsDisposed { get; set; }
        /// <summary>
        /// 定义一个属性
        /// </summary>
        public BaseProtocol BaseProtocol { get; set; }
        /// <summary>
        /// 设置设备type类型
        /// </summary>
        /// <param name="type"></param>
        public void setType(int type)
        {
            this.type = type;
        }
        /// <summary>
        /// 设置设备子类型childtype
        /// </summary>
        /// <param name="childType"></param>
        public void setChildType(int childType)
        {
            this.childType = childType;
        }
        /// <summary>
        /// 设置类型名字
        /// </summary>
        /// <param name="typeName"></param>
        public void setTypeName(String typeName)
        {
            this.typeName = typeName;
        }
        /// <summary>
        /// 设置设备编号
        /// </summary>
        /// <param name="index"></param>
        public void setIndex(int index)
        {
            this.index = index;
        }
        /// <summary>
        /// 设置设备通讯地址
        /// </summary>
        /// <param name="address"></param>
        public void setAddress(string address)
        {
            this.address = address;
        }
        /// <summary>
        /// 定义虚方法：向数据表插入数据
        /// </summary>
        public virtual void insertData()
        {

        }
        public virtual void showControlPanel(Control parent)
        {

        }
        /// <summary>
        /// 把通讯上来的数据循环解析
        /// </summary>
        public virtual void analyseDatasRecyle()
        {
        }
        public virtual Control getControlPanel()
        {
            return null;
        }
        /// <summary>
        /// 资源释放
        /// </summary>
        public void Dispose()
        {
            IsDisposed = true;
            BaseProtocol?.Dispose();
        }

        public Device(BaseProtocol protocol)
        {
            //BaseProtocol=protocol;

        }
        /// <summary>
        /// 建立PLC的通讯，IP地址从Device.ini加载上来，端口号和机架号为102
        /// 读取的数据范围为DB99.DBB0-230
        /// </summary>
        /// <param name="ipAddress"></param>
        public Device(string ipAddress)
        {
            ButuWheel = new List<Wheel>();
            ZhengPingWheel = new List<Wheel>();
            for (int i = 0; i < 3; i++)
            {
                ButuWheel.Add(new Wheel() { Name = $"{i + 1}#" });
                ZhengPingWheel.Add(new Wheel() { Name = $"{i + 1}#整平轮" });
            }
            //实例化UV灯的List，并用for循环依次添加对象
            UVLamps = new List<Lamps>();
            for (int i = 0; i < 8; i++)
            {
                UVLamps.Add(new Lamps() { Name = $"{i + 1}#UV灯" });
            }
            //实例化一个通讯连接
            BaseProtocol = new SCADA.Drive.Siemens.S7Comm.S7_1200(new TcpComm(ipAddress, 102), 1);
            //寄存器监听范围为DBB0-230
            BaseProtocol.BeginListen($"DB99.DBB0~236", 300);
            BaseProtocol.RegValueChanged += BaseProtocol_RegValueChanged;
            BaseProtocol.ConnectStateChanged += BaseProtocol_ConnectStateChanged;
            //开启一个线程进行数据解析
            new System.Threading.Thread(() =>
            {
                while (!IsDisposed)
                {
                    try
                    {
                        //调用数据解析的方法进行数据解析
                        analyseDatasRecyle();
                    }
                    catch (Exception)
                    {
                    }
                    System.Threading.Thread.Sleep(1000);
                }
            }).Start();
        }
        /// <summary>
        /// 判断通讯连接状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseProtocol_ConnectStateChanged(object sender, SCADA.ConnectStateChangedEventArgs e)
        {
        }
        /// <summary>
        /// 判断值的编号，当值发生变化时自动更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void BaseProtocol_RegValueChanged(object sender, RegValueChangedEventArgs e)
        {
        }
    }
}
