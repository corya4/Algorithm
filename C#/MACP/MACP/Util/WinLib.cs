using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MACP.Util
{
    public static class WinLib
    {

        #region FlndWindow
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern int UnregisterHotKey(int hwnd, int id);

        [DllImport("user32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKey(int wCode, int wMapType);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        #endregion

        public static KeyValuePair<Keys, int> InputKey(Message m)
        {
            Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
            int modified = (int)m.LParam & 0xFFFF;
            KeyValuePair<Keys, int> keys = new KeyValuePair<Keys, int>(key, modified);

            return keys;
        }

    }
}
