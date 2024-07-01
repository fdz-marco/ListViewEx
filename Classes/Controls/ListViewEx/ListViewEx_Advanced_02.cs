using System.Runtime.InteropServices;

namespace glitcher.core.Controls
{
    /// <summary>
    /// (Class: Control) ListView with Extended Features<br/>
    /// </summary>
    /// <remarks>
    /// Author: Marco Fernandez (marcofdz.com / glitcher.dev)<br/>
    /// Last modified: 2024.06.27 - June 27, 2024
    /// </remarks>
    public partial class ListViewEx : ListView 
    {
        private const int WM_ERASEBKGND = 0x0014;

        protected override void OnNotifyMessage(Message m)
        {
            if (m.Msg != WM_ERASEBKGND)
            {
                base.OnNotifyMessage(m);
            }
        }

        private bool isInWmPaintMsg = false;

        [StructLayout(LayoutKind.Sequential)]
        public struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int code;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0F: // WM_PAINT
                    this.isInWmPaintMsg = true;
                    base.WndProc(ref m);
                    this.isInWmPaintMsg = false;
                    break;
                case 0x204E: // WM_REFLECT_NOTIFY
                    NMHDR nmhdr = (NMHDR)m.GetLParam(typeof(NMHDR));
                    if (nmhdr.code == -12)
                    { // NM_CUSTOMDRAW
                        if (this.isInWmPaintMsg)
                            base.WndProc(ref m);
                    }
                    else
                        base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
    }
}
