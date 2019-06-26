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
    //继承Device的基类
    class CleanDevice : Device
    {
        //要保存或者导入的配方信息
        public int bianhao;
        public int ControlConveyorSpeed;
        public int ControlBrushHeight;
        public int ControlBrushHeightbuchang;
        public int ControlPaoHeight;
        public int ControlPaoHeightbuchang;
        public int ControlFans;
        public int ControlBrushSwitch;
        public int ControlPaoSwitch;
        // 涂布轮1 速度  运行时间 剩余寿命  加热温度  高度显示
        public int MonitorBrushHeight;
        public int MonitorPaoHeight;
        public double MonitorBrushRunTime;
        public double MonitorBrushLeftTime;
        public double MonitorPaoRunTime;
        public double MonitorPaoLeftTime;
        public double MonitorFansRunsTime;
        public int MonitorConveyorSpeed;
        public double MonitorConveyorRunTime;
        public CleanDevice(BaseProtocol protocol) : base(protocol)
        {
            //定义类型
            type = 2;
        }
        public CleanDevice(string ipaddress) : base(ipaddress)
        {
            //定义类型
            type = 2;
        }
        //把通讯读取出来的数据进行分析，采用字节连读的方式，把数据一次读出
        public override void analyseDatasRecyle()
        {
            
            //配方区域参数读回，输送线速度，抛光轮高度，毛刷轮高度，抛光轮补偿，毛刷轮补偿，风扇，毛刷轮开关，抛光轮开关
            ControlConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB0"].Short;
            ControlPaoHeight = BaseProtocol.ListenReg["DB99.DBB2"].Short;
            ControlBrushHeight = BaseProtocol.ListenReg["DB99.DBB4"].Short;
            ControlPaoHeightbuchang = BaseProtocol.ListenReg["DB99.DBB6"].Short;
            ControlBrushHeightbuchang = BaseProtocol.ListenReg["DB99.DBB8"].Short;
            ControlFans = BaseProtocol.ListenReg["DB99.DBB10"].Short;
            ControlBrushSwitch = BaseProtocol.ListenReg["DB99.DBB12"].Short;
            ControlPaoSwitch = BaseProtocol.ListenReg["DB99.DBB14"].Short;
            //配方编号
            bianhao = BaseProtocol.ListenReg["DB99.DBB52"].Short;
            //参数监控区域读回
            //输送带速度
            MonitorConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB66"].Short;
            //抛光轮和毛刷轮的高度
            MonitorPaoHeight = BaseProtocol.ListenReg["DB99.DBB84"].Short;
            MonitorBrushHeight = BaseProtocol.ListenReg["DB99.DBB86"].Short;
            //运行时间：输送线、毛刷轮、抛光轮和风扇
            MonitorConveyorRunTime = BaseProtocol.ListenReg["DB99.DBB120"].Int32;
            MonitorBrushRunTime = BaseProtocol.ListenReg["DB99.DBB124"].Int32;
            MonitorPaoRunTime = BaseProtocol.ListenReg["DB99.DBB128"].Int32;
            MonitorFansRunsTime = BaseProtocol.ListenReg["DB99.DBB132"].Int32;
            //毛刷轮和抛光轮剩余时间
            MonitorBrushLeftTime = BaseProtocol.ListenReg["DB99.DBB156"].Int32;
            MonitorPaoLeftTime = BaseProtocol.ListenReg["DB99.DBB160"].Int32;
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
