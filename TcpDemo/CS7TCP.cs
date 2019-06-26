using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace TcpDemo
{
    public class CS7TCP
    {
        [DllImport("ButterflyS7.dll", EntryPoint = "CreatePlc", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 CreatePlc();

        //[DllImport("ButterflyS7.dll", EntryPoint = "GetError", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //public static extern void GetErrorText(ref Int32 PlcHandle);

        [DllImport("ButterflyS7.dll", EntryPoint = "DestoryPlc", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void DestoryPlc(ref Int32 PlcHandle);


        [DllImport("ButterflyS7.dll", EntryPoint = "ConnectPlc", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 ConnectPlc(Int32 uiPlcHandle, byte[] pcIP, int iRack, int iSlot, bool bIsS7_200, Int16 usLocalTSAP, Int16 usRemoteTSAP);


        [DllImport("ButterflyS7.dll", EntryPoint = "DisconnectPlc", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 DisconnectPlc(Int32 PlcHandle);


        [DllImport("ButterflyS7.dll", EntryPoint = "GetPlcConnected", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 GetPlcConnected(Int32 PlcHandle, ref Int32 iResult);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadBool", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadBool(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, UInt32 iBitNum, ref UInt32 bValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "WriteBool", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteBool(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, UInt32 iBitNum, UInt32 bValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadByte", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadByte(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, ref UInt32 ucValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "WriteByte", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteByte(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, UInt32 ucValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadWord", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadWord(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, ref UInt32 uiValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "WriteWord", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteWord(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, UInt32 usValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadInt", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadInt(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, ref Int16 sValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "WriteInt", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteInt(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, Int32 sValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadDWord", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadDWord(Int32 Index, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, ref UInt32 uiValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "WriteDWord", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteDWord(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, UInt32 usValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadDInt", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadDInt(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, ref Int32 iValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "WriteDInt", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteDInt(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, Int32 iValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadFloat", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadFloat(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, ref float bValue);

        [DllImport("ButterflyS7.dll", EntryPoint = "WriteFloat", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteFloat(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, float fValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadString", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadString(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, Int16 iLength, byte[] pcValue);

        [DllImport("ButterflyS7.dll", EntryPoint = "WriteString", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteString(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, Int16 iLength, byte[] pcValue);


        [DllImport("ButterflyS7.dll", EntryPoint = "ReadBlockAsByte", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadBlockAsByte(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, int iLength, byte[] pucValue);

        [DllImport("ButterflyS7.dll", EntryPoint = "WriteBlockAsByte", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteBlockAsByte(Int32 uiPlcHandle, int iAreaType, UInt32 iDBNum, UInt32 iByteNum, int iLength, byte[] pucValue);

    }
}
