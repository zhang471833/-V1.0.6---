using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;
namespace SaomiaoTest2
{
    /// <summary>
    /// ��ȡ�����������USBɨ��ǹ���� ������û�н��� ӦΪʹ�õ���ȫ�ֹ���
    /// USBɨ��ǹ ��ģ����̰���
    /// ������Ҫ����ɨ��ǹ��ֵ���ֶ������ֵ��̫�ô���
    /// </summary>
   public class BardCodeHooK
    {
        public delegate void BardCodeDeletegate(BarCodes barCode);
        public event BardCodeDeletegate BarCodeEvent;

        //����ɾ�̬�����������׳������쳣
        private static HookProc hookproc;


        public struct BarCodes
        {
            public int VirtKey;//������
            public int ScanCode;//ɨ����
            public string KeyName;//����
            public uint Ascll;//Ascll
            public char Chr;//�ַ�

            public string BarCode;//������Ϣ   �������յ�����
            public bool IsValid;//�����Ƿ���Ч
            public DateTime Time;//ɨ��ʱ��,
        }

        private struct EventMsg
        {
            public int message;
            public int paramL;
            public int paramH;
            public int Time;
            public int hwnd;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);

        [DllImport("user32", EntryPoint = "GetKeyNameText")]
        private static extern int GetKeyNameText(int IParam, StringBuilder lpBuffer, int nSize);

        [DllImport("user32", EntryPoint = "GetKeyboardState")]
        private static extern int GetKeyboardState(byte[] pbKeyState);

        [DllImport("user32", EntryPoint = "ToAscii")]
        private static extern bool ToAscii(int VirtualKey, int ScanCode, byte[] lpKeySate, ref uint lpChar, int uFlags);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);


        delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        BarCodes barCode = new BarCodes();
        int hKeyboardHook = 0;
        string strBarCode = "";

        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            if (nCode == 0)
            {
                EventMsg msg = (EventMsg)Marshal.PtrToStructure(lParam, typeof(EventMsg));
                if (wParam == 0x100)//WM_KEYDOWN=0x100
                {
                    barCode.VirtKey = msg.message & 0xff;//������
                    barCode.ScanCode = msg.paramL & 0xff;//ɨ����
                    StringBuilder strKeyName = new StringBuilder(225);
                    if (GetKeyNameText(barCode.ScanCode * 65536, strKeyName, 255) > 0)
                    {
                        barCode.KeyName = strKeyName.ToString().Trim(new char[] { ' ', '\0' });
                    }
                    else
                    {
                        barCode.KeyName = "";
                    }
                    byte[] kbArray = new byte[256];
                    uint uKey = 0;
                    GetKeyboardState(kbArray);


                    if (ToAscii(barCode.VirtKey, barCode.ScanCode, kbArray, ref uKey, 0))
                    {
                        barCode.Ascll = uKey;
                        barCode.Chr = Convert.ToChar(uKey);
                    }

                    TimeSpan ts = DateTime.Now.Subtract(barCode.Time);

                    if (ts.TotalMilliseconds > 50)
                    {//ʱ���������50 �����ʾ�ֶ�����
                        strBarCode = barCode.Chr.ToString();
                    }
                    else
                    {
                        if ((msg.message & 0xff) == 13 && strBarCode.Length > 3)
                        {//�س�
                            barCode.BarCode = strBarCode;
                            barCode.IsValid = true;
                        }
                        strBarCode += barCode.Chr.ToString();
                    }
                    barCode.Time = DateTime.Now;
                    if (BarCodeEvent != null)
                        BarCodeEvent(barCode);//�����¼�
                    barCode.IsValid = false;
                }
            }
            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }

        //��װ����
        public bool Start()
        {
            if (hKeyboardHook == 0)
            {
                hookproc = new HookProc(KeyboardHookProc);


                //GetModuleHandle ���� ��� Marshal.GetHINSTANCE
                //��ֹ�� framework4.0�� ע�ṳ�Ӳ��ɹ�
                IntPtr modulePtr = GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName);

                //WH_KEYBOARD_LL=13
                //ȫ�ֹ��� WH_KEYBOARD_LL
                //  hKeyboardHook = SetWindowsHookEx(13, hookproc, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);

                hKeyboardHook = SetWindowsHookEx(13, hookproc, modulePtr, 0);
            }
            return (hKeyboardHook != 0);
        }

        //ж�ع���
        public bool Stop()
        {
            if (hKeyboardHook != 0)
            {
                return UnhookWindowsHookEx(hKeyboardHook);
            }
            return true;
        }
    }
}