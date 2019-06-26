using SCADA.Drive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpDemo
{
    //设备存储列表类，把设备信息保存在一个公共类里面，存储成List形式
    public class PublicValue
    {
        //定义设备列表
        public static List<Device> devices = new List<Device>();
        /// <summary>
        /// 实例化一个静态属性BaseProtocol
        /// </summary>
        public static BaseProtocol BaseProtocol { get; set; }

        /// <summary>
        /// 面积统计
        /// </summary>
        public static double TotalArea { get; set; } = 1;
    }
}
