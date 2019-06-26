using SCADA.Drive;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpDemo
{
    class BrushDevice : Device
    {
        //要保存或者导入的配方信息
        public int bianhao;
        public int ControlConveyorSpeed;
        public int ControlBrushSpeed1;
        public int ControlBrushSpeed2;
        public int ControlBrushHeight1;
        public int ControlBrushHeight2;
        public int ControlBrushHeight11;
        public int ControlBrushHeight22;
        /// <summary>
        /// 设备监控参数
        /// </summary>
        public int MonitorBrushSpeed1;
        public int MonitorBrushSpeed2;
        public int MonitorConveyorSpeed;
        public int MonitorBrushHeight1;
        public int MonitorBrushHeight2;
        public double MonitorBrushRunTime1;
        public double MonitorBrushRunTime2;
        public double MonitorBrushLeftTime1;
        public double MonitorBrushLeftTime2;
        public double MonitorConveyorRunTime1;
        public double MonitorConveyorRunTime2;

        // 故障代码
        public int MonitorBrushErrorCode1;
        public int MonitorBrushErrorCode2;
        public int MonitorConveyorErrorCode;
        public BrushDevice(BaseProtocol protocol) : base(protocol)
        {
            //定义类型
            type = 6;
        }

        public BrushDevice(string ipAddress) : base(ipAddress)
        {
            //定义类型
            type = 6;
        }

        //定义数组存储的数量            //总共读取的字节长度，该长度和西门子PLC侧设置的DB块长度有关系
        Byte[] datas = new Byte[220];
        //把通讯读取出来的数据进行分析，采用字节连读的方式，把数据一次读出
        public override void analyseDatasRecyle()
        {
            //毛刷轮1毛刷轮2和输送线的速度
            ControlBrushSpeed1 = BaseProtocol.ListenReg["DB99.DBB0"].Short;
            ControlBrushSpeed2 = BaseProtocol.ListenReg["DB99.DBB2"].Short;
            ControlConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB4"].Short;
            //毛刷轮1毛刷轮2的高度
            ControlBrushHeight1 = BaseProtocol.ListenReg["DB99.DBB16"].Short;
            ControlBrushHeight2 = BaseProtocol.ListenReg["DB99.DBB18"].Short;
            //毛刷轮1毛刷轮2的补偿高度
            ControlBrushHeight11 = BaseProtocol.ListenReg["DB99.DBB24"].Short;
            ControlBrushHeight22 = BaseProtocol.ListenReg["DB99.DBB26"].Short;

            //配方编号读回
            bianhao = BaseProtocol.ListenReg["DB99.DBB52"].Short;

            //输送线速度监控，滚轮参数功率监控
            MonitorBrushSpeed1 = BaseProtocol.ListenReg["DB99.DBB66"].Short;
            MonitorBrushSpeed2 = BaseProtocol.ListenReg["DB99.DBB68"].Short;
            MonitorConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB70"].Short;
            //实际高度
            MonitorBrushHeight1 = BaseProtocol.ListenReg["DB99.DBB84"].Short;
            MonitorBrushHeight2 = BaseProtocol.ListenReg["DB99.DBB86"].Short;
            //运行时间
            MonitorBrushRunTime1 = BaseProtocol.ListenReg["DB99.DBB120"].Int32;
            MonitorBrushRunTime2 = BaseProtocol.ListenReg["DB99.DBB124"].Int32;
            MonitorConveyorRunTime1 = BaseProtocol.ListenReg["DB99.DBB128"].Int32;
            //剩余寿命
            MonitorBrushLeftTime1 = BaseProtocol.ListenReg["DB99.DBB156"].Int32;
            MonitorBrushLeftTime2 = BaseProtocol.ListenReg["DB99.DBB160"].Int32;
            //报警代码
            MonitorBrushErrorCode1 = BaseProtocol.ListenReg["DB99.DBB184"].Short;
            MonitorBrushErrorCode2 = BaseProtocol.ListenReg["DB99.DBB186"].Short;
            MonitorConveyorErrorCode = BaseProtocol.ListenReg["DB99.DBB188"].Short;
        }
        //向数据表执行数据插入数据行
        public override void insertData()
        {
        }
    }
}
