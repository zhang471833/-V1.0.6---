using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpDemo
{
    class LoadDevice:Device
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
        //public bool quanZiDongYunXingZhong;
        //public bool shouDongYunXingZhong;
        //public bool baoJingTingJiZhong;
        //public bool shuSongxianYunXingZhong;
        //public bool shangWeiJiLiangTiaoZhong;
        //public bool UV1YungXingZhong;
        //public bool UV2YungXingZhong;
        //public bool UV3YungXingZhong;
        //public bool UV4YungXingZhong;
        //public bool UV5YungXingZhong;
        //public bool UV6YungXingZhong;
        //public bool UV7YungXingZhong;
        //public bool UV8YungXingZhong;

        public bool I00;
        public bool I01;
        public bool I02;
        public bool I03;
        public bool I04;
        public bool I05;
        public bool I06;
        public bool I07;

        public bool I10;
        public bool I11;
        public bool I12;
        public bool I13;
        public bool I14;
        public bool I15;

        public bool Q00;
        public bool Q01;
        public bool Q02;
        public bool Q03;
        public bool Q04;
        public bool Q05;
        public bool Q06;
        public bool Q07;

        public bool Q10;
        public bool Q11;

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
        public LoadDevice() : base()
        {
            //定义类型
            type = 7;
        }
        //定义数组存储的数量            //总共读取的字节长度，该长度和西门子PLC侧设置的DB块长度有关系
        Byte[] datas = new Byte[220];
        //把通讯读取出来的数据进行分析，采用字节连读的方式，把数据一次读出
        public override void analyseDatasRecyle(int DBaddress)
        {
            lock (this)
            {
                //通讯读取参数
                int resno = CS7TCP.ReadBlockAsByte(Z通讯设置.plcHandle, 0x84, address, 0, 220, datas);
                //当返回值为0时表示通讯成功，
                if (resno == 0)
                {
                    ////获取设备内部已经有的数据
                    ControlAppSpeed1 = getIntFromBytes(datas, 0, 2);
                    ControlDocSpeed1 = getIntFromBytes(datas, 2, 2);
                    ControlZhengpingSpeed1 = getIntFromBytes(datas, 4, 2);
                    ControlAppSpeed2 = getIntFromBytes(datas, 6, 2);
                    ControlDocSpeed2 = getIntFromBytes(datas, 8, 2);
                    ControlConveyorSpeed = getIntFromBytes(datas, 10, 2);

                    ControlAppSpeed3 = getIntFromBytes(datas, 12, 2);
                    ControlDocSpeed3 = getIntFromBytes(datas, 14, 2);

                    ControlAppHeight1 = getIntFromBytes(datas, 16, 2);
                    ControlZhengpingHeight1 = getIntFromBytes(datas, 18, 2);
                    ControlAppHeight2 = getIntFromBytes(datas, 20, 2);
                    ControlAppHeight3 = getIntFromBytes(datas, 22, 2);

                    ControlAppHeight11 = getIntFromBytes(datas, 24, 2);
                    ControlZhengpingHeight11 = getIntFromBytes(datas, 26, 2);
                    ControlAppHeight22 = getIntFromBytes(datas, 28, 2);
                    ControlAppHeight33 = getIntFromBytes(datas, 30, 2);

                    ControlAppTemp1 = getIntFromBytes(datas, 32, 2);
                    ControlAppTemp2 = getIntFromBytes(datas, 34, 2);
                    ControlAppTemp3 = getIntFromBytes(datas, 36, 2);
                    //配方编号读回
                    bianhao = getIntFromBytes(datas, 52, 2);


                    //输送线速度监控，滚轮参数功率监控
                    MonitorAppSpeed1 = getIntFromBytes(datas, 66, 2);
                    MonitorDocSpeed1 = getIntFromBytes(datas, 68, 2);
                    MonitorZhengpingSpeed1 = getIntFromBytes(datas, 70, 2);
                    MonitorAppSpeed2 = getIntFromBytes(datas, 72, 2);
                    MonitorDocSpeed2 = getIntFromBytes(datas, 74, 2);
                    //主次输送线的速度
                    MonitorConveyorSpeed1 = getIntFromBytes(datas, 76, 2);
                    MonitorConveyorSpeed2 = getIntFromBytes(datas, 78, 2);
                    //3#涂布轮和均布轮的速度
                    MonitorAppSpeed3 = getIntFromBytes(datas, 80, 2);
                    MonitorDocSpeed3 = getIntFromBytes(datas, 82, 2);
                    //1#2#3#涂布轮的高度
                    MonitorAppHeight1 = getIntFromBytes(datas, 84, 2);
                    MonitorAppHeight2 = getIntFromBytes(datas, 86, 2);
                    MonitorAppHeight3 = getIntFromBytes(datas, 88, 2);
                    //1#2#3#涂布轮油漆的温度
                    MonitorAppTemp1 = getIntFromBytes(datas, 92, 2);
                    MonitorAppTemp2 = getIntFromBytes(datas, 94, 2);
                    MonitorAppTemp3 = getIntFromBytes(datas, 96, 2);
                    //输送线运行时间和轮子运行时间
                    MonitorAppRunTime1 = getDoubleFromBytes(datas, 120, 4);
                    MonitorDocRunTime1 = getDoubleFromBytes(datas, 124, 4);
                    MonitorZhengpingRunTime1 = getDoubleFromBytes(datas, 128, 4);
                    MonitorAppRunTime2 = getDoubleFromBytes(datas, 132, 4);
                    MonitorDocRunTime2 = getDoubleFromBytes(datas, 136, 4);
                    MonitorConveyorRunTime1 = getDoubleFromBytes(datas, 140, 4);
                    MonitorConveyorRunTime2 = getDoubleFromBytes(datas, 144, 4);
                    MonitorAppRunTime3 = getDoubleFromBytes(datas, 148, 4);
                    MonitorDocRunTime3 = getDoubleFromBytes(datas, 152, 4);
                    //1#2#3#涂布轮的剩余声明周期
                    MonitorAppLeftTime1 = getDoubleFromBytes(datas, 156, 4);
                    MonitorAppLeftTime2 = getDoubleFromBytes(datas, 160, 4);
                    MonitorAppLeftTime3 = getDoubleFromBytes(datas, 164, 4);

                    //IO数据的解析
                    BitArray array = getBitArrayFromBytes(datas, 210, 4);
                    Q00 = array[0];
                    Q01 = array[1];
                    Q02 = array[2];
                    Q03 = array[3];
                    Q04 = array[4];
                    Q05 = array[5];
                    Q06 = array[6];
                    Q07 = array[7];

                    Q10 = array[8];
                    Q11 = array[9];

                    I00 = array[10];
                    I01 = array[11];
                    I02 = array[12];
                    I03 = array[13];
                    I04 = array[14];
                    I05 = array[15];
                    I06 = array[16];
                    I07 = array[17];

                    I10 = array[18];
                    I11 = array[19];
                    I12 = array[20];
                    I13 = array[21];
                    I14 = array[22];
                    I15 = array[23];

                    //shangWeiJiLiangTiaoZhong = array[24];
                    //quanZiDongYunXingZhong = array[25];
                    //shouDongYunXingZhong = array[26];
                    //baoJingTingJiZhong = array[27];
                    //shuSongxianYunXingZhong = array[28];
                    //UV1YungXingZhong = array[29];
                    //UV2YungXingZhong = array[30];
                    //UV3YungXingZhong = array[31];

                    //shuSongDaiStatusCode = getIntFromBytes(datas, 136, 2);
                    //UV1StatusCode = getIntFromBytes(datas, 138, 1);
                    //UV2StatusCode = getIntFromBytes(datas, 139, 1);
                    //UV3StatusCode = getIntFromBytes(datas, 140, 1);
                    //UV4StatusCode = getIntFromBytes(datas, 141, 1);
                    //UV5StatusCode = getIntFromBytes(datas, 142, 1);
                    //UV6StatusCode = getIntFromBytes(datas, 143, 1);
                    //UV7StatusCode = getIntFromBytes(datas, 144, 1);
                    //UV8StatusCode = getIntFromBytes(datas, 145, 1);
                }
            }
        }
        //向数据表执行数据插入数据行
        public override void insertData()
        {
            DateTime datatime = DateTime.Now;
            A0数据库操作 database = new A0数据库操作();
            string butuvalue;
            switch (childType)
            {
                //单滚涂布机
                case 1:
                    butuvalue = "(null,'" + productCodeMain + "','" + typeName + index + "','" + datatime + "','配方编号','" + recipeNOMain
                + "','输送线速度','" + ControlConveyorSpeed / 100 + "','1#涂布轮速度','"
                + ControlAppSpeed1 + "','1#涂布轮高度','" + ControlAppHeight1 + "','1#涂布轮补偿','" + ControlAppHeight11 + "','1#涂布轮温度','"
                + ControlAppTemp1 + "','1#均布轮速度','" + ControlDocSpeed1 + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null
                + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null
                        + "','" + null + "','" + null + "','" + null + "','" + null + "','"
                        + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "')";
                    database.InsertDataToMysql(database.txbDBname.Text, database.cmbTables.Text, butuvalue);
                    break;
                //双滚涂布机
                case 2:
                    butuvalue = "(null,'" + productCodeMain + "','" + typeName + index + "','" + datatime + "','配方编号','" + recipeNOMain
                + "','输送线速度','" + ControlConveyorSpeed / 100 + "','1#涂布轮速度','"
                + ControlAppSpeed1 + "','1#涂布轮高度','" + ControlAppHeight1 + "','1#涂布轮补偿','" + ControlAppHeight11 + "','1#涂布轮温度','"
                + ControlAppTemp1 + "','1#均布轮速度','" + ControlDocSpeed1 + "','2#涂布轮速度','" + ControlAppSpeed2 + "','2#涂布轮高度','"
                + ControlAppHeight2 + "','2#涂布轮补偿','" + ControlAppHeight22 + "','2#涂布轮温度','" + ControlAppTemp2 + "','2#均布轮速度','"
                + ControlDocSpeed2 + "','" + null + "','" + null
                        + "','" + null + "','" + null + "','" + null + "','" + null + "','"
                        + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "')";
                    database.InsertDataToMysql(database.txbDBname.Text, database.cmbTables.Text, butuvalue);
                    break;
                //三滚涂布机
                case 3:
                    butuvalue = "(null,'" + productCodeMain + "','" + typeName + index + "','" + datatime + "','配方编号','" + recipeNOMain
                + "','输送线速度','" + ControlConveyorSpeed / 100 + "','1#涂布轮速度','"
                + ControlAppSpeed1 + "','1#涂布轮高度','" + ControlAppHeight1 + "','1#涂布轮补偿','1#涂布轮温度','"
                + ControlAppTemp1 + "','" + ControlAppHeight11 + "','1#均布轮速度','"
                + ControlDocSpeed1 + "','2#涂布轮速度','" + ControlAppSpeed2 + "','2#涂布轮高度','" + ControlAppHeight2 + "','2#涂布轮补偿','"
                + ControlAppHeight22 + "','2#涂布轮温度','"
                + ControlAppTemp2 + "','2#均布轮速度','" + ControlDocSpeed2 + "','3#涂布轮速度','" + ControlAppSpeed3 + "','3#涂布轮高度','"
                + ControlAppHeight3 + "','3#涂布轮补偿','" + ControlAppHeight33 + "','3#涂布轮温度','"
                + ControlAppTemp3 + "','3#均布轮速度','" + ControlDocSpeed3 + "','" + null + "','" + null + "')";
                    database.InsertDataToMysql(database.txbDBname.Text, database.cmbTables.Text, butuvalue);
                    break;
                //补土+单滚
                case 4:
                    butuvalue = "(null,'" + productCodeMain + "','" + typeName + index + "','" + datatime + "','配方编号','" + recipeNOMain
                + "','输送线速度','" + ControlConveyorSpeed / 100 + "','1#涂布轮速度','"
                + ControlAppSpeed1 + "','1#涂布轮高度','" + ControlAppHeight1 + "','1#涂布轮补偿','" + ControlAppHeight11 + "','1#涂布轮温度','"
                + ControlAppTemp1 + "','1#均布轮速度','" + ControlDocSpeed1 + "','2#涂布轮速度','" + ControlAppSpeed2 + "','2#涂布轮高度','"
                + ControlAppHeight2 + "','2#涂布轮补偿','" + ControlAppHeight22 + "','2#涂布轮温度','" + ControlAppTemp2 + "','2#均布轮速度','"
                + ControlDocSpeed2 + "','1#整平轮速度','" + ControlZhengpingSpeed1 + "','1#整平轮高度','" + ControlZhengpingHeight1 + "','1#整平轮补偿','" + ControlZhengpingHeight11 + "','"
                + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "')";
                    database.InsertDataToMysql(database.txbDBname.Text, database.cmbTables.Text, butuvalue);
                    break;
                //补土+双滚
                case 5:
                    butuvalue = "(null,'" + productCodeMain + "','" + typeName + index + "','" + datatime + "','配方编号','" + recipeNOMain
                + "','输送线速度','" + ControlConveyorSpeed / 100 + "','1#涂布轮速度','"
                + ControlAppSpeed1 + "','1#涂布轮高度','" + ControlAppHeight1 + "','1#涂布轮补偿','" + ControlAppHeight11 + "','1#涂布轮温度','"
                + ControlAppTemp1 + "','1#均布轮速度','" + ControlDocSpeed1 + "','2#涂布轮速度','" + ControlAppSpeed2 + "','2#涂布轮高度','"
                + ControlAppHeight2 + "','2#涂布轮补偿','" + ControlAppHeight22 + "','2#涂布轮温度','" + ControlAppTemp2 + "','2#均布轮速度','"
                + ControlDocSpeed2 + "','3#涂布轮速度','" + ControlAppSpeed3 + "','3#涂布轮高度','"
                + ControlAppHeight3 + "','3#涂布轮补偿','" + ControlAppHeight33 + "','3#涂布轮温度','"
                + ControlAppTemp3 + "','3#均布轮速度','" + ControlDocSpeed3 + "','1#整平轮速度','" + ControlZhengpingSpeed1 + "','1#整平轮高度','" + ControlZhengpingHeight1 + "','1#整平轮补偿','" + ControlZhengpingHeight11 + "')";
                    database.InsertDataToMysql(database.txbDBname.Text, database.cmbTables.Text, butuvalue);
                    break;
                //正逆滚
                case 6:
                    butuvalue = "(null,'" + productCodeMain + "','" + typeName + index + "','" + datatime + "','配方编号','" + recipeNOMain
                + "','输送线速度','" + ControlConveyorSpeed / 100 + "','1#涂布轮速度','"
                + ControlAppSpeed1 + "','1#涂布轮高度','" + ControlAppHeight1 + "','1#涂布轮补偿','" + ControlAppHeight11 + "','1#涂布轮温度','"
                + ControlAppTemp1 + "','1#均布轮速度','" + ControlDocSpeed1 + "','2#涂布轮速度','" + ControlAppSpeed2 + "','2#涂布轮高度','"
                + ControlAppHeight2 + "','2#涂布轮补偿','" + ControlAppHeight22 + "','2#涂布轮温度','" + ControlAppTemp2 + "','2#均布轮速度','"
                + ControlDocSpeed2 + "','1#整平轮速度','" + ControlZhengpingSpeed1 + "','1#整平轮高度','" + ControlZhengpingHeight1 + "','1#整平轮补偿','" + ControlZhengpingHeight11 + "','"
                + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "')";
                    database.InsertDataToMysql(database.txbDBname.Text, database.cmbTables.Text, butuvalue);
                    break;
            }
        }
    }
}
