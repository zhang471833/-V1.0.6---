using SCADA.Drive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TcpDemo
{
    class DeviceFatory
    {
        //创建设备大的类型
        public static Device createDevice(int type, string ipaddress)
        {
            switch (type)
            {
                //干燥机设备类1；除尘机设备类2；流平机设备类3；涂布机设备类4；淋幕机设备类5；毛刷机设备类6；龙门上下料机设备类7；砂光机设备类8
                case 1:
                    return new DryDevice(ipaddress);
                case 2:
                    return new CleanDevice(ipaddress);
                case 3:
                    return new liupingDevice(ipaddress);
                case 4:
                    return new butuDevice(ipaddress);
                case 5:
                    return new LinmuDevice(ipaddress);
                case 6:
                    return new BrushDevice(ipaddress);
                //case 7:
                //    return new LoadDevice();
                case 8:
                    return new ShaDevice(ipaddress);
                //默认返回为设备
                default:
                    throw new Exception("设备类型错误");
            }
        }
    }
}
