using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace KeyPresser
{
    public partial class Form1 : Form
    {
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static int prevCode=0;
        private static KeyboardInterpreterObject k;
        static Form1 frm;
        public Form1()
        {
            InitializeComponent();
            k = new KeyboardInterpreterObject();
            k.LShiftDown = false;
            k.RShiftDown = false;
            frm = this;
        }
      
        private static IntPtr HookCallback( int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN&&(k.LShiftDown==false&&k.RShiftDown==false))
            {
                prevCode = Marshal.ReadInt32(lParam);
                frm.KeyPressed.Text = k.KeyboardInterpreter(prevCode);
            }
            else if(nCode >= 0 && wParam == (IntPtr)WM_KEYUP&& Marshal.ReadInt32(lParam)==prevCode)
            {
                frm.KeyPressed.Text = "";
            }
            else if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                prevCode = Marshal.ReadInt32(lParam);
                frm.KeyPressed.Text = k.KeyboardInterpreterShift(prevCode);
            }
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
            {
                if (Marshal.ReadInt32(lParam) == (int)Keys.LShiftKey)
                    k.LShiftDown = false;
                else if (Marshal.ReadInt32(lParam) == (int)Keys.RShiftKey)
                    k.RShiftDown = false;
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _hookID = SetHook(_proc);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
        }
    }
    
}

