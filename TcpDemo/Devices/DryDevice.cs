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
    class DryDevice : Device
    {
        //要保存或者导入的配方信息
        public double bianhao;
        public int UV1Percent;
        public int UV2Percent;
        public int UV3Percent;
        public int UV4Percent;
        public int UV5Percent;
        public int UV6Percent;
        public int UV7Percent;
        public int UV8Percent;
        public int ControlConveyorSpeed;
        // UV1 速度/功率  UV1运行时间 UV1剩余寿命
        public int UV1Power;
        public double UV1RunTime;
        public double UV1LeftTime;
        // UV2 速度/功率  UV2运行时间 UV2剩余寿命
        public int UV2Power;
        public double UV2RunTime;
        public double UV2LeftTime;
        // UV3 速度/功率  UV3运行时间 UV3剩余寿命
        public int UV3Power;
        public double UV3RunTime;
        public double UV3LeftTime;
        // UV4 速度/功率  UV4运行时间 UV4剩余寿命
        public int UV4Power;
        public double UV4RunTime;
        public double UV4LeftTime;
        // UV5 速度/功率  UV5运行时间 UV5剩余寿命
        public int UV5Power;
        public double UV5RunTime;
        public double UV5LeftTime;
        // UV6 速度/功率  UV6运行时间 UV6剩余寿命
        public int UV6Power;
        public double UV6RunTime;
        public double UV6LeftTime;
        // UV7 速度/功率  UV7运行时间 UV7剩余寿命
        public int UV7Power;
        public double UV7RunTime;
        public double UV7LeftTime;
        // UV8 速度/功率  UV8运行时间 UV8剩余寿命
        public int UV8Power;
        public double UV8RunTime;
        public double UV8LeftTime;
        //输送带速度、输送带时间
        public int shuSongDaiSpeed;
        public double shuSongDaiRunTime;
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
        public DryDevice(string ipAddress) : base(ipAddress)
        {
            type = 1;
        }
        /// <summary>
        /// 把通讯读取出来的数据进行分析
        /// </summary>
        public override void analyseDatasRecyle()
        {
            //获取设备内部已经有的数据
            bianhao = BaseProtocol.ListenReg["DB99.DBB0"].Int32;
            ControlConveyorSpeed = BaseProtocol.ListenReg["DB99.DBB4"].Short;
            UV1Percent = BaseProtocol.ListenReg["DB99.DBB6"].Short;
            UV2Percent = BaseProtocol.ListenReg["DB99.DBB8"].Short;
            UV3Percent = BaseProtocol.ListenReg["DB99.DBB10"].Short;
            UV4Percent = BaseProtocol.ListenReg["DB99.DBB12"].Short;
            UV5Percent = BaseProtocol.ListenReg["DB99.DBB14"].Short;
            UV6Percent = BaseProtocol.ListenReg["DB99.DBB16"].Short;
            UV7Percent = BaseProtocol.ListenReg["DB99.DBB18"].Short;
            UV8Percent = BaseProtocol.ListenReg["DB99.DBB20"].Short;
            //输送线速度监控，UV光源功率监控
            shuSongDaiSpeed = BaseProtocol.ListenReg["DB99.DBB40"].Short;
            UV1Power = BaseProtocol.ListenReg["DB99.DBB42"].Short;
            UV2Power = BaseProtocol.ListenReg["DB99.DBB44"].Short;
            UV3Power = BaseProtocol.ListenReg["DB99.DBB46"].Short;
            UV4Power = BaseProtocol.ListenReg["DB99.DBB48"].Short;
            UV5Power = BaseProtocol.ListenReg["DB99.DBB50"].Short;
            UV6Power = BaseProtocol.ListenReg["DB99.DBB52"].Short;
            UV7Power = BaseProtocol.ListenReg["DB99.DBB54"].Short;
            UV8Power = BaseProtocol.ListenReg["DB99.DBB56"].Short;
            //输送线运行时间和UV光源使用时间
            shuSongDaiRunTime = BaseProtocol.ListenReg["DB99.DBB68"].Int32;
            UV1RunTime = BaseProtocol.ListenReg["DB99.DBB72"].Int32;
            UV2RunTime = BaseProtocol.ListenReg["DB99.DBB76"].Int32;
            UV3RunTime = BaseProtocol.ListenReg["DB99.DBB80"].Int32;
            UV4RunTime = BaseProtocol.ListenReg["DB99.DBB84"].Int32;
            UV5RunTime = BaseProtocol.ListenReg["DB99.DBB88"].Int32;
            UV6RunTime = BaseProtocol.ListenReg["DB99.DBB92"].Int32;
            UV7RunTime = BaseProtocol.ListenReg["DB99.DBB96"].Int32;
            UV8RunTime = BaseProtocol.ListenReg["DB99.DBB100"].Int32;
            //UV光源剩余时间
            UV1LeftTime = BaseProtocol.ListenReg["DB99.DBB104"].Int32;
            UV2LeftTime = BaseProtocol.ListenReg["DB99.DBB108"].Int32;
            UV3LeftTime = BaseProtocol.ListenReg["DB99.DBB112"].Int32;
            UV4LeftTime = BaseProtocol.ListenReg["DB99.DBB116"].Int32;
            UV5LeftTime = BaseProtocol.ListenReg["DB99.DBB120"].Int32;
            UV6LeftTime = BaseProtocol.ListenReg["DB99.DBB124"].Int32;
            UV7LeftTime = BaseProtocol.ListenReg["DB99.DBB128"].Int32;
            UV8LeftTime = BaseProtocol.ListenReg["DB99.DBB132"].Int32;
            //变频器和光源的故障代码
            shuSongDaiStatusCode = BaseProtocol.ListenReg["DB99.DBB136"].Short;
            UV1StatusCode = BaseProtocol.ListenReg["DB99.DBB138"].Short;
            UV2StatusCode = BaseProtocol.ListenReg["DB99.DBB139"].Short;
            UV3StatusCode = BaseProtocol.ListenReg["DB99.DBB140"].Short;
            UV4StatusCode = BaseProtocol.ListenReg["DB99.DBB141"].Short;
            UV5StatusCode = BaseProtocol.ListenReg["DB99.DBB142"].Short;
            UV6StatusCode = BaseProtocol.ListenReg["DB99.DBB143"].Short;
            UV7StatusCode = BaseProtocol.ListenReg["DB99.DBB144"].Short;
            UV8StatusCode = BaseProtocol.ListenReg["DB99.DBB145"].Short;

            //UV灯功率
            UVLamps[0].UVPower = BaseProtocol.ListenReg["DB99.DBB42"].Short;
            UVLamps[1].UVPower = BaseProtocol.ListenReg["DB99.DBB44"].Short;
            UVLamps[2].UVPower = BaseProtocol.ListenReg["DB99.DBB46"].Short;
            UVLamps[3].UVPower = BaseProtocol.ListenReg["DB99.DBB48"].Short;
            UVLamps[4].UVPower = BaseProtocol.ListenReg["DB99.DBB50"].Short;
            UVLamps[5].UVPower = BaseProtocol.ListenReg["DB99.DBB52"].Short;
            UVLamps[6].UVPower = BaseProtocol.ListenReg["DB99.DBB54"].Short;
            UVLamps[7].UVPower = BaseProtocol.ListenReg["DB99.DBB56"].Short;
            //剩余寿命
            UVLamps[0].UVLeftTime = BaseProtocol.ListenReg["DB99.DBB104"].Int32;
            UVLamps[1].UVLeftTime = BaseProtocol.ListenReg["DB99.DBB108"].Int32;
            UVLamps[2].UVLeftTime = BaseProtocol.ListenReg["DB99.DBB112"].Int32;
            UVLamps[3].UVLeftTime = BaseProtocol.ListenReg["DB99.DBB116"].Int32;
            UVLamps[4].UVLeftTime = BaseProtocol.ListenReg["DB99.DBB120"].Int32;
            UVLamps[5].UVLeftTime = BaseProtocol.ListenReg["DB99.DBB124"].Int32;
            UVLamps[6].UVLeftTime = BaseProtocol.ListenReg["DB99.DBB128"].Int32;
            UVLamps[7].UVLeftTime = BaseProtocol.ListenReg["DB99.DBB132"].Int32;
        }
        //向数据表执行数据插入数据行
        public override void insertData()
        {
        }
    }
}