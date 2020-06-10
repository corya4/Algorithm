using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mem_hkj
{
    using System.Runtime.Hosting;
    using System.Runtime.InteropServices;

    /*
     * SubFormが MainForm을 乗り越えたとき
     * スクロールバーが生成することを止めるHandlerを再定義するClass
     * (Open source) - 코드해독은 아직입니다..
     * 
     */

    public class ScrollBarEx : NativeWindow
    {
        public ScrollBarEx()
        {
            


        }

        private const int WM_NCCALCSIZE = 0x0083;
        private const int SB_BOTH = 3;

        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCCALCSIZE:
                    ShowScrollBar(m.HWnd, SB_BOTH, 0);
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
