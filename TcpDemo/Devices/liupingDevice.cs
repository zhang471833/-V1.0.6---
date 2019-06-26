using SCADA.Drive;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//override是子类里面向父类重写属性值的方法，
//子类的override方法，在父类里面必须有一一对应的virtual（虚方法），方法名字必须一致，虚方法的内容可以为空；
//父类虚方法的为空，然后不同的子类里面进行实际具体操作方法；
namespace TcpDemo
{
    class liupingDevice : Device
    {
        //配方信息
        public int bianhao;
        public int ControlConveyorSpeed;
        public int ControlTemp1;
        public int ControlTemp2;
        public int ControlTemp3;
        public int ControlFans1;
        public int ControlFans2;
        public int ControlFans3;
        //实时监控信息
        // 1#加热温度监控，运行时间
        public int MonitorTemp1;
        public double MonitorHeaterRunTime1;
        // 2#加热温度监控，运行时间
        public int MonitorTemp2;
        public double MonitorHeaterRunTime2;
        // 3#加热温度监控，运行时间
        public int MonitorTemp3;
        public double MonitorHeaterRunTime3;
        //输送线，运行时间
        public int MonitorConveyorSpeed;
        public double MonitorConveyorRunTime;

        //异常状态
        public int shuSongDaiStatusCode;
        public int UV1StatusCode;
        public int UV2StatusCode;
        public int UV3StatusCode;
        public int UV4StatusCode;
        public int UV5StatusCode;
        public int UV6StatusCode;
        public int UV7StatusCode;
        public int UV8StatusCode;
        public liupingDevice(string  ipaddress) : base(ipaddress)
        {
            //定义类型
            type = 3;
        }
        /// <summary>
        /// 把通讯读取出来的数据进行分析
        /// </summary>
        public override void analyseDatasRecyle()
        {
            //配方区域参数读回
            ControlConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB0"].Short;
            ControlTemp1 = BaseProtocol.ListenReg["DB99.DBB2"].Int32;
            ControlTemp2 = BaseProtocol.ListenReg["DB99.DBB6"].Int32;
            ControlTemp3 = BaseProtocol.ListenReg["DB99.DBB10"].Int32;
            ControlFans1 = BaseProtocol.ListenReg["DB99.DBB14"].Short;
            ControlFans2 = BaseProtocol.ListenReg["DB99.DBB16"].Short;
            ControlFans3 = BaseProtocol.ListenReg["DB99.DBB18"].Short;
            bianhao = BaseProtocol.ListenReg["DB99.DBB52"].Short;
            //参数监控区域读回
            //输送带速度
            MonitorConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB66"].Short;
            MonitorConveyorRunTime = BaseProtocol.ListenReg["DB99.DBB120"].Int32;
            MonitorHeaterRunTime1 = BaseProtocol.ListenReg["DB99.DBB124"].Int32;
            MonitorHeaterRunTime2 = BaseProtocol.ListenReg["DB99.DBB128"].Int32;
            MonitorHeaterRunTime3 = BaseProtocol.ListenReg["DB99.DBB132"].Int32;
            //加热温度监控
            MonitorTemp1 = BaseProtocol.ListenReg["DB99.DBB148"].Int32;
            MonitorTemp2 = BaseProtocol.ListenReg["DB99.DBB152"].Int32;
            MonitorTemp3 = BaseProtocol.ListenReg["DB99.DBB156"].Int32;
        }
        //向数据表执行数据插入数据行
        public override void insertData()
        {
        }
        public override void showControlPanel(Control parent)
        {
            parent.Controls.Clear();
        }
    }
}
