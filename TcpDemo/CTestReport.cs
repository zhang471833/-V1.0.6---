using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace TcpDemo
{
    class CTestReport
    {
        public CTestReport()
        {
            this._StartTime = System.DateTime.Now;
        }
        private DateTime _StartTime;
        public DateTime StartTime           //开始测试时间
        {
            get
            {
                return _StartTime;
            }
        }
        private DateTime _EndTime;
        public DateTime EndTime             //测试结束时间
        {
            get { return _EndTime; }
        }
        private Boolean _ConnectionState = true;
        private Int64 _DisConnectCount = 0;
        public Int64 DisConnectCount        //断网次数
        {
            get { return _DisConnectCount; }
        }
        private Int64 _ReConnectCount = 0;
        public Int64 ReconnectionCount      //重连成功次数
        {
            get { return _ReConnectCount; }
        }
        public Boolean ConnectionState      //当前连接状态
        {
            set
            {
                if (_ConnectionState != value)
                {
                    if (!value) _DisConnectCount++;
                    if (value) _ReConnectCount++;
                    _ConnectionState = value;
                }
            }
            get
            {
                return _ConnectionState;
            }
        }

        public void Stop()
        {
            _EndTime = System.DateTime.Now;
            _ReportComments.Append("压力测试报告\t\n");
            _ReportComments.Append("开始时间:" + _StartTime.ToString() + "/结束时间:" + _EndTime.ToString() + "\t\n");
            _ReportComments.Append("连接发生中断次数:" + _DisConnectCount.ToString() + "次/自动重连次数:" + _ReConnectCount.ToString() + "次\t\n");
            _ReportComments.Append("一共收发数据包:" + (_WriteReadCount * 2).ToString() + "个,其中失败:" + (_WriteReadErrCount * 2).ToString() + "个\t\n");
            _ReportComments.Append("收发总Byte:" + (_WriteReadCount * 2 * _MaxLen).ToString() + "个\t\n");
        }

        private Int64 _WriteReadCount = 0;
        public Int64 WriteReadCount         //读写循环的总次数
        {
            get { return _WriteReadCount; }
            set { _WriteReadCount = value; }
        }

        private Int64 _WriteReadErrCount = 0;
        public Int64 WriteReadErrCount      //读写失败的总次数
        {
            get { return _WriteReadErrCount; }
            set { _WriteReadErrCount = value; }
        }

        private Int32 _MaxLen = 0;
        public Int32 MaxLen                 //每个循环写入的字的总数
        {
            set { _MaxLen = value; }
        }
        private StringBuilder _ReportComments = new StringBuilder("");
        public string ReportComments       //报告总内容
        {
            get
            {
                return _ReportComments.ToString();
            }
        }

    }
}
