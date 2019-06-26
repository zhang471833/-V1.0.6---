using SCADA.Drive;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpDemo
{
    class ShaDevice : Device
    {
        //要保存或者导入的配方信息
        public int bianhao;
        public int ControlConveyorSpeed;
        public int ControlAppSpeed1;
        public int ControlAppHeight1;
        public int ControlAppHeight11;
        public int ControlAppTemp1;
        public int ControlAppSpeed2;
        public int ControlAppHeight2;
        public int ControlAppHeight22;
        public int ControlAppTemp2;
        public int ControlAppSpeed3;
        public int ControlAppHeight3;
        public int ControlAppHeight33;
        public int ControlAppTemp3;
        public int ControlZhengpingSpeed1;
        public int ControlZhengpingHeight1;
        public int ControlZhengpingHeight11;
        public int ControlDocSpeed1;
        public int ControlDocSpeed2;
        public int ControlDocSpeed3;

        //实时监控信息
        public int MonitorConveyorSpeed1;
        public int MonitorConveyorSpeed2;
        public double MonitorConveyorRunTime1;
        public double MonitorConveyorRunTime2;
        // 涂布轮1 速度  运行时间 剩余寿命  加热温度  高度显示
        public int MonitorAppSpeed1;
        public double MonitorAppRunTime1;
        public double MonitorAppLeftTime1;
        public int MonitorAppTemp1;
        public int MonitorAppHeight1;
        public int MonitorAppHeight11;
        // 涂布轮2 速度  运行时间 剩余寿命  加热温度  高度显示
        public int MonitorAppSpeed2;
        public double MonitorAppRunTime2;
        public double MonitorAppLeftTime2;
        public int MonitorAppTemp2;
        public int MonitorAppHeight2;
        public int MonitorAppHeight22;
        // 涂布轮3 速度  运行时间 剩余寿命  加热温度  高度显示
        public int MonitorAppSpeed3;
        public double MonitorAppRunTime3;
        public double MonitorAppLeftTime3;
        public int MonitorAppTemp3;
        public int MonitorAppHeight3;
        public int MonitorAppHeight33;

        // 均布轮1 速度  运行时间
        public int MonitorDocSpeed1;
        public double MonitorDocRunTime1;
        // 均布轮2 速度  运行时间
        public int MonitorDocSpeed2;
        public double MonitorDocRunTime2;
        // 均布轮3 速度  运行时间
        public int MonitorDocSpeed3;
        public double MonitorDocRunTime3;

        // 整平轮1 速度  运行时间 高度显示
        public int MonitorZhengpingSpeed1;
        public double MonitorZhengpingRunTime1;
        public int MonitorZhengpingHeight1;

        ////各种运行状态
        ////异常状态
        //public int shuSongDaiStatusCode;
        //public int UV1StatusCode;
        //public int UV2StatusCode;
        //public int UV3StatusCode;
        //public int UV4StatusCode;
        //public int UV5StatusCode;
        //public int UV6StatusCode;
        //public int UV7StatusCode;
        //public int UV8StatusCode;
        public ShaDevice(string ipAddress) : base(ipAddress)
        {
            //定义类型
            type = 8;
        }
        /// <summary>
        /// 把通讯读取出来的数据进行分析
        /// </summary>
        public override void analyseDatasRecyle()
        {
            //获取设备内部已经有的数据
            ControlAppSpeed1 = BaseProtocol.ListenReg["DB99.DBB0"].Short;
            ControlDocSpeed1 = BaseProtocol.ListenReg["DB99.DBB2"].Short;
            ControlZhengpingSpeed1 = BaseProtocol.ListenReg["DB99.DBB4"].Short;
            ControlAppSpeed2 = BaseProtocol.ListenReg["DB99.DBB6"].Short;
            ControlDocSpeed2 = BaseProtocol.ListenReg["DB99.DBB8"].Short;
            ControlConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB10"].Short;

            ControlAppSpeed3 = BaseProtocol.ListenReg["DB99.DBB12"].Short;
            ControlDocSpeed3 = BaseProtocol.ListenReg["DB99.DBB14"].Short;

            ControlAppHeight1 = BaseProtocol.ListenReg["DB99.DBB16"].Short;
            ControlZhengpingHeight1 = BaseProtocol.ListenReg["DB99.DBB18"].Short;
            ControlAppHeight2 = BaseProtocol.ListenReg["DB99.DBB20"].Short;
            ControlAppHeight3 = BaseProtocol.ListenReg["DB99.DBB22"].Short;

            ControlAppHeight11 = BaseProtocol.ListenReg["DB99.DBB24"].Short;
            ControlZhengpingHeight11 = BaseProtocol.ListenReg["DB99.DBB26"].Short;
            ControlAppHeight22 = BaseProtocol.ListenReg["DB99.DBB28"].Short;
            ControlAppHeight33 = BaseProtocol.ListenReg["DB99.DBB30"].Short;

            ControlAppTemp1 = BaseProtocol.ListenReg["DB99.DBB32"].Short;
            ControlAppTemp2 = BaseProtocol.ListenReg["DB99.DBB34"].Short;
            ControlAppTemp3 = BaseProtocol.ListenReg["DB99.DBB36"].Short;
            //配方编号读回
            bianhao = BaseProtocol.ListenReg["DB99.DBB52"].Short;


            //输送线速度监控，滚轮参数功率监控
            MonitorAppSpeed1 = BaseProtocol.ListenReg["DB99.DBB66"].Short;
            MonitorDocSpeed1 = BaseProtocol.ListenReg["DB99.DBB68"].Short;
            MonitorZhengpingSpeed1 = BaseProtocol.ListenReg["DB99.DBB70"].Short;
            MonitorAppSpeed2 = BaseProtocol.ListenReg["DB99.DBB72"].Short;
            MonitorDocSpeed2 = BaseProtocol.ListenReg["DB99.DBB74"].Short;
            //主次输送线的速度
            MonitorConveyorSpeed1 = BaseProtocol.ListenReg["DB99.DBB76"].Short;
            MonitorConveyorSpeed2 = BaseProtocol.ListenReg["DB99.DBB78"].Short;
            //3#涂布轮和均布轮的速度
            MonitorAppSpeed3 = BaseProtocol.ListenReg["DB99.DBB80"].Short;
            MonitorDocSpeed3 = BaseProtocol.ListenReg["DB99.DBB82"].Short;
            //1#2#3#涂布轮的高度
            MonitorAppHeight1 = BaseProtocol.ListenReg["DB99.DBB84"].Short;
            MonitorZhengpingHeight1 = BaseProtocol.ListenReg["DB99.DBB86"].Short;
            MonitorAppHeight2 = BaseProtocol.ListenReg["DB99.DBB88"].Short;
            MonitorAppHeight3 = BaseProtocol.ListenReg["DB99.DBB90"].Short;
            //1#2#3#涂布轮油漆的温度
            MonitorAppTemp1 = BaseProtocol.ListenReg["DB99.DBB92"].Short;
            MonitorAppTemp2 = BaseProtocol.ListenReg["DB99.DBB94"].Short;
            MonitorAppTemp3 = BaseProtocol.ListenReg["DB99.DBB96"].Short;
            //输送线运行时间和轮子运行时间
            MonitorAppRunTime1 = BaseProtocol.ListenReg["DB99.DBB120"].Int32;
            MonitorDocRunTime1 = BaseProtocol.ListenReg["DB99.DBB124"].Int32;
            MonitorZhengpingRunTime1 = BaseProtocol.ListenReg["DB99.DBB128"].Int32;
            MonitorAppRunTime2 = BaseProtocol.ListenReg["DB99.DBB132"].Int32;
            MonitorDocRunTime2 = BaseProtocol.ListenReg["DB99.DBB136"].Int32;
            MonitorConveyorRunTime1 = BaseProtocol.ListenReg["DB99.DBB140"].Int32;
            MonitorConveyorRunTime2 = BaseProtocol.ListenReg["DB99.DBB144"].Int32;
            MonitorAppRunTime3 = BaseProtocol.ListenReg["DB99.DBB148"].Int32;
            MonitorDocRunTime3 = BaseProtocol.ListenReg["DB99.DBB152"].Int32;
            //1#2#3#涂布轮的剩余声明周期
            MonitorAppLeftTime1 = BaseProtocol.ListenReg["DB99.DBB156"].Int32;
            MonitorAppLeftTime2 = BaseProtocol.ListenReg["DB99.DBB160"].Int32;
            MonitorAppLeftTime3 = BaseProtocol.ListenReg["DB99.DBB164"].Int32;
            //变频器的故障代码
        }
        //向数据表执行数据插入数据行
        public override void insertData()
        {
        }
    }
}
