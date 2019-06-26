using SCADA.Drive;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpDemo
{
    class LinmuDevice : Device
    {
        //配方信息
        public int bianhao;
        public int ControlOilBumpSpeed;
        public int ControlConveyorSpeed;
        public int ControlZhengPingSpeed;
        public int ControlConveyorHighSpeed;
        public int ControlConveyorLowSpeed;
        public int ControlOilTemp;
        public int ControlZhengPingHeight;
        //实时监控运行速度
        public int MonitorOilBumpSpeed;
        public int MonitorConveyorSpeed1;
        public int MonitorConveyorHighSpeed;
        public int MonitorConveyorLowSpeed;
        //实时统计运行时间
        public double MonitorOilBumpRunTime1;
        public double MonitorHeatingTime2;
        public double MonitorConveyorRunTime1;
        public double MonitorConveyorHighRunTime;
        public double MonitorConveyorLowRunTime;
        //运行状态
        public int MointorRunStatus;
        public LinmuDevice(string ipAddress) : base(ipAddress)
        {
            //定义类型
            type = 5;
        }
        /// <summary>
        /// 把通讯读取出来的数据进行分析
        /// </summary>
        public override void analyseDatasRecyle()
        {
            //配方参数
            ControlOilBumpSpeed = BaseProtocol.ListenReg["DB99.DBB0"].Short;
            ControlConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB2"].Short;
            ControlZhengPingSpeed = BaseProtocol.ListenReg["DB99.DBB4"].Short;
            ControlConveyorHighSpeed = BaseProtocol.ListenReg["DB99.DBB6"].Short;
            ControlConveyorLowSpeed = BaseProtocol.ListenReg["DB99.DBB8"].Short;
            ControlZhengPingHeight = BaseProtocol.ListenReg["DB99.DBB10"].Short;
            //油温
            ControlOilTemp = BaseProtocol.ListenReg["DB99.DBB32"].Short;
            //配方编号读回
            bianhao = BaseProtocol.ListenReg["DB99.DBB52"].Short;
            //输送线速度监控，滚轮参数功率监控
            MonitorOilBumpSpeed = BaseProtocol.ListenReg["DB99.DBB66"].Short;
            MonitorConveyorSpeed1 = BaseProtocol.ListenReg["DB99.DBB68"].Short;
            MonitorConveyorHighSpeed = BaseProtocol.ListenReg["DB99.DBB70"].Short;
            MonitorConveyorLowSpeed = BaseProtocol.ListenReg["DB99.DBB72"].Short;
            //输送线运行时间和轮子运行时间
            MonitorOilBumpRunTime1 = BaseProtocol.ListenReg["DB99.DBB120"].Int32;
            MonitorHeatingTime2 = BaseProtocol.ListenReg["DB99.DBB124"].Int32;
            MonitorConveyorRunTime1 = BaseProtocol.ListenReg["DB99.DBB128"].Int32;
            MonitorConveyorHighRunTime = BaseProtocol.ListenReg["DB99.DBB132"].Int32;
            MonitorConveyorLowRunTime = BaseProtocol.ListenReg["DB99.DBB136"].Int32;
        }
        //向数据表执行数据插入数据行
        public override void insertData()
        {
        }
    }
}
