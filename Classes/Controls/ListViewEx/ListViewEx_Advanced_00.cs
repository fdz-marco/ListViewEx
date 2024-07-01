using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace glitcher.core.Controls
{
    /*
    /// <summary>
    /// (Class: Control) ListView with Extended Features<br/>
    /// </summary>
    /// <remarks>
    /// Extra features based on: 
    /// https://stackoverflow.com/questions/6563863/c-sharp-change-listview-items-rows-height
    /// https://www.codeproject.com/script/Articles/ViewDownloads.aspx?aid=6646
    /// https://stackoverflow.com/questions/18283781/changing-listview-header-and-grid-lines-colors
    /// https://stackoverflow.com/questions/471859/c-how-do-you-edit-items-and-subitems-in-a-listview
    /// https://www.codeproject.com/Questions/226753/Csharp-Listview-With-Link-Labels
    /// https://stackoverflow.com/questions/938896/flickering-in-listview-with-ownerdraw-and-virtualmode?noredirect=1&lq=1
    /// </remarks>
    public partial class ListViewEx2 : ListView 
    {
        // #######################################################

        #region Editors

        private System.Windows.Forms.DateTimePicker _editor_DatePicker = new System.Windows.Forms.DateTimePicker();
        private System.Windows.Forms.ComboBox _editor_ComboBox = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.TextBox _editor_TextInput = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.TextBox _editor_Password = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.NumericUpDown _editor_NumericUpDown = new System.Windows.Forms.NumericUpDown();

        public void initEditors()
        {
            this._editor_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._editor_DatePicker.Location = new System.Drawing.Point(0, 0);
            this._editor_DatePicker.Size = new System.Drawing.Size(80, 20);
            this._editor_DatePicker.Visible = false;

            this._editor_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editor_ComboBox.IntegralHeight = false;
            this._editor_ComboBox.ItemHeight = _RowHeight;
            this._editor_ComboBox.Location = new System.Drawing.Point(0, 0);
            this._editor_ComboBox.Size = new System.Drawing.Size(80, 21);
            this._editor_ComboBox.Visible = false;

            this._editor_TextInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._editor_TextInput.Location = new System.Drawing.Point(0, 0);
            this._editor_TextInput.Multiline = true;
            this._editor_TextInput.Size = new System.Drawing.Size(80, 16);
            this._editor_TextInput.Text = "";
            this._editor_TextInput.Visible = false;
            this._editor_TextInput.BorderStyle = BorderStyle.None;
            this._editor_TextInput.BackColor = Color.PaleTurquoise;

            this._editor_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._editor_NumericUpDown.Location = new System.Drawing.Point(0, 0);
            this._editor_NumericUpDown.Size = new System.Drawing.Size(80, 20);
            this._editor_NumericUpDown.Value = 0;
            this._editor_NumericUpDown.Visible = false;

            this.Controls.Add(this._editor_DatePicker);
            this.Controls.Add(this._editor_ComboBox);
            this.Controls.Add(this._editor_TextInput);
            this.Controls.Add(this._editor_NumericUpDown);
        }

        #endregion

        // #######################################################

        #region Variables

        private bool _isItemMeasured = false;
        private int _RowHeight = 16;
        private int _HScrollPos = 0;
        private int _VScrollPos = 0;
        private int _ColumnIdxSelected = -1;
        private int _RowIdxSelected = -1;
        private ListViewItem? _ItemSelected = null;
        private ListViewItem.ListViewSubItem? _SubItemSelected = null;
        private int _ListViewWidth { get =>  this.ClientSize.Width; }
        private int _ListViewHeight { get => this.ClientSize.Height; }

        #endregion

        // #######################################################

        #region Constants

        // Window Notifications
        // https://learn.microsoft.com/en-us/windows/win32/winmsg/window-notifications
        private const int WM_SHOWWINDOW = 0x0018;

        // Control Notifications
        // https://learn.microsoft.com/en-us/windows/win32/controls/wm-drawitem
        // WM_MEASUREITEM: Sent to the owner window of a combo box, list box, list-view control,
        // or menu item when the control or menu is created.
        // WM_DRAWITEM: Sent to the parent window of an owner-drawn button, combo box,
        // list box, or menu when a visual aspect of the button, combo box, list box, or menu has changed.
        private const int WM_DRAWITEM = 0x002B;
        private const int WM_MEASUREITEM = 0x002C;
        private const int WM_REFLECT = 0x2000;

        // Control Messages
        // https://learn.microsoft.com/en-us/windows/win32/controls/wm-notify
        // WM_NOTIFY: Sent by a common control to its parent window when an event has occurred
        // or the control requires some information.
        private const int WM_NOTIFY = 0x004E;

        // List-View Messages
        // LVM_GETCOLUMNORDERARRAY: Gets the current left-to-right order of columns in a list-view control.
        private const int LVM_FIRST = 0x1000;
        private const int LVM_GETCOLUMNORDERARRAY = (LVM_FIRST + 59);

        // List-View Window Styles
        // https://learn.microsoft.com/en-us/windows/win32/controls/list-view-window-styles
        // LVS_OWNERDRAWFIXED: The owner window can paint items in report view.
        // The list-view control sends a WM_DRAWITEM message to paint each item;
        // it does not send separate messages for each subitem. The iItemData member
        // of the DRAWITEMSTRUCT structure contains the item data for the specified list-view item.
        private const int LVS_OWNERDRAWFIXED = 0x0400;

        // Scroll Bar Notifications
        // https://learn.microsoft.com/en-us/windows/win32/controls/wm-hscroll
        private const int WM_HSCROLL = 0x0114;
        private const int WM_VSCROLL = 0x0115;

        // Mouse Input Notifications
        // https://learn.microsoft.com/en-us/windows/win32/inputdev/mouse-input-notifications
        private const int WM_MOUSEWHEEL = 0x020A;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_LBUTTONDBLCLK = 0x0203;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_RBUTTONUP = 0x0205;
        private const int WM_MOUSEHOVER = 0x02A1;

        // Scroll bar types
        // https://learn.microsoft.com/en-us/windows/win32/controls/scroll-bar-control-styles
        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getscrollpos
        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;
        private const int SB_CTCL = 2;

        #endregion

        // #######################################################

        #region Structures

        /// <summary>
        /// Structure for drawing an item
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        struct DRAWITEMSTRUCT
        {
            public int ctlType;
            public int ctlID;
            public int itemID;
            public int itemAction;
            public int itemState;
            public IntPtr hWndItem;
            public IntPtr hDC;
            public int rcLeft;
            public int rcTop;
            public int rcRight;
            public int rcBottom;
            public IntPtr itemData;
        }

        /// <summary>
        /// Structure for detailed scroll information
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct SCROLLINFO
        {
            public int cbSize;
            public int fMask;
            public int nMin;
            public int nMax;
            public int nPage;
            public int nPos;
            public int nTrackPos;
        }

        /// <summary>
        /// Structure for MessageHeader for WM_NOTIFY
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct NMHDR
        {
            public IntPtr hwndFrom;
            public Int32 idFrom;
            public Int32 code;
        }

        /// <summary>
        /// Structure for Measure Item 
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MEASUREITEMSTRUCT
        {
            public int CtlType;     // Offset = 0
            public int CtlID;       // Offset = 1
            public int itemID;      // Offset = 2
            public int itemWidth;   // Offset = 3
            public int itemHeight;  // Offset = 4
            public IntPtr itemData;
        }

        #endregion

        // #######################################################

        #region Add Parameters and Custom Appearance

        /// <summary>
        /// Sets the row height in Details view
        /// This property appears in the Visual Studio Form Designer
        /// </summary>
        [Category("Appearance")]
        [Description("Sets the height of the ListView rows in Details view in pixels.")]
        public int RowHeight
        {
            get { return _RowHeight; }
            set
            {
                if (!DesignMode) Debug.Assert(_isItemMeasured == false, "RowHeight must be set before ListViewEx is created.");
                _RowHeight = value;
            }
        }

        /// <summary>
        /// CreateParams can be used to pass information about the initial state and appearance of a control.
        /// </summary>
        /// <remarks>
        /// https://learn.microsoft.com/es-es/dotnet/api/system.windows.forms.createparams?view=windowsdesktop-9.0
        /// </remarks>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams _params = base.CreateParams;
                _params.Style |= LVS_OWNERDRAWFIXED;
                return _params;
            }
        }

        #endregion

        // #######################################################

        #region Imported Methods

        // Import GetScrollPos from user32.dll to get the current Scroll Position
        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getscrollpos
        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);

        // Sends the specified message to a window or windows.
        // The SendMessage function calls the window procedure for the specified
        // window and does not return until the window procedure has processed the message.
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wPar, IntPtr lPar);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int len, ref int[] order);

        #endregion

        // #######################################################

        #region Support Methods

        public bool GetItemSubitemFromPoint(int x, int y)
        {
            ListViewHitTestInfo info = this.HitTest(x, y);
            if (info.Item != null && info.SubItem != null)
            {
                this._ColumnIdxSelected = info.Item.SubItems.IndexOf(info.SubItem);
                this._RowIdxSelected = this.Items.IndexOf(info.Item);
                this._ItemSelected = info.Item;
                this._SubItemSelected = info.SubItem;
                return true;
            }
            this._ColumnIdxSelected = -1;
            this._RowIdxSelected = -1;
            this._ItemSelected = null;
            this._SubItemSelected = null;
            return false;
        }


        public void OpenEditorOrAction(int x, int y)
        {
            if (this.GetItemSubitemFromPoint(x, y))
            {
                ListViewExSubItemSettings? SubItemSettings = (ListViewExSubItemSettings)this._SubItemSelected.Tag;
                if (SubItemSettings == null)
                    return;

                switch (SubItemSettings.dataType)
                {
                    // Link Text
                    case ListViewExDataType.Link:
                        string url = $"{this._SubItemSelected.Text}";
                        if (!url.Trim().Contains("://"))
                            url = "https://" + url;
                        try
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = url,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                        break;
                    // Text Editor
                    case ListViewExDataType.Text:
                        Rectangle _boundsSubItem = (_ColumnIdxSelected > 0) ? _SubItemSelected.Bounds : _ItemSelected.GetBounds(ItemBoundsPortion.Label);
                        this._editor_TextInput.Bounds = _boundsSubItem;
                        this._editor_TextInput.Text = _SubItemSelected.Text;
                        this._editor_TextInput.SelectionStart = this._editor_TextInput.Text.Length;
                        this._editor_TextInput.SelectionLength = 0;
                        this._editor_TextInput.Visible = true;
                        this._editor_TextInput.BringToFront();
                        this._editor_TextInput.Focus();
                        break;
                }
            }
        }

   
        public void GetScrollPosition(Message msg)
        {
            bool isHorizontal = msg.Msg == WM_HSCROLL || msg.Msg == WM_MOUSEWHEEL;
            int thumbPos = ((int)msg.WParam >> 16) & 0xFFFF;    //HIWORD: HIWORD specifies the current position of the scroll box
            int scrollCode = ((int)msg.WParam) & 0xFFFF;        //LOWORD: if the LOWORD is SB_THUMBPOSITION or SB_THUMBTRACK; otherwise, this word is not used.
            int scrollPos = GetScrollPos(msg.HWnd, isHorizontal ? SB_HORZ : SB_VERT);
            if (isHorizontal)
                this._HScrollPos = scrollPos;
            else
                this._VScrollPos = scrollPos * RowHeight;
        }

        public void DrawSubItem(Graphics graphics, ListViewItem item, int rowIdx)
        {
            if (graphics == null)
                return;
            if (item == null)
                return;


            // SubItems
            for (int subItemIdx = 0; subItemIdx < Math.Min(item.SubItems.Count, Columns.Count); subItemIdx++)
            {
                // SubItem: Get
                ListViewItem.ListViewSubItem subItem = item.SubItems[subItemIdx];

                // SubItem: Get advanced features
                ListViewExSubItemSettings subItemSettings = (ListViewExSubItemSettings)subItem.Tag;

                // SubItem: Get Bounds
                // i_Item.SubItems[0].Bounds contains the entire row, rather than the first column only.
                Rectangle boundsSubItem = (subItemIdx > 0) ? subItem.Bounds : item.GetBounds(ItemBoundsPortion.Label);

                // SubItem: Background Color , Font Color
                Color bgColorSubItem = subItem.BackColor;
                Color fontColorSubItem = subItem.ForeColor;
                if (this._RowIdxSelected >= 0 && this._ColumnIdxSelected >= 0)
                {
                    if (item.Selected && subItemIdx == this._ColumnIdxSelected)
                    {
                        bgColorSubItem = SystemColors.Highlight;
                        fontColorSubItem = SystemColors.HighlightText;
                    }
                }
                if (!Enabled)
                {
                    bgColorSubItem = SystemColors.Control;
                    fontColorSubItem = SystemColors.ControlText;
                }
                if (subItemSettings != null)
                {
                    if (subItemSettings.dataType == ListViewExDataType.Link)
                    {
                        fontColorSubItem = Color.Blue;
                        subItem.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Underline);                   
                    }
                }

                // SubItem: Image
                Image? image = null;
                Rectangle imageRect = Rectangle.Empty;
                if (subItemSettings != null)
                {
                    if (subItemSettings.dataType == ListViewExDataType.Link)
                    {
                        image = Utils.GetImageResource("Resources/link.png");
                        int imageSize = boundsSubItem.Height - 2;
                        imageRect = new Rectangle(boundsSubItem.Left + 2, boundsSubItem.Top + 1, imageSize, imageSize);
                    }
                }

                // SubItem: Text Format
                TextFormatFlags e_Flags = TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
                switch (Columns[subItemIdx].TextAlign)
                {
                    case HorizontalAlignment.Center:
                        e_Flags |= TextFormatFlags.HorizontalCenter;
                        break;
                    case HorizontalAlignment.Right:
                        e_Flags |= TextFormatFlags.Right;
                        break;
                };

                // SubItem: Draw Background
                SolidBrush bgBrushSubItem = new SolidBrush(bgColorSubItem);
                graphics.FillRectangle(bgBrushSubItem, boundsSubItem);

                // SubItem: Draw Image
                if (image != null)
                    graphics.DrawImage(image, imageRect);

                /*
               // ToDo: Draw Row Index
                if (subItemIdx == 0)
                    graphics.DrawString((rowIdx + 1).ToString(), subItem.Font, Brushes.Black, subItem.Bounds);
                *

                // SubItem: Draw Text
                if (image == null)
                    TextRenderer.DrawText(graphics, subItem.Text, subItem.Font, boundsSubItem, fontColorSubItem, e_Flags);
                else
                {
                    Rectangle textRect = new Rectangle(boundsSubItem.Left + imageRect.Width + 4, boundsSubItem.Top, boundsSubItem.Width - imageRect.Width - 6, boundsSubItem.Height);
                    TextRenderer.DrawText(graphics, subItem.Text, subItem.Font, textRect, fontColorSubItem, e_Flags);
                }
            }
        }

        #endregion

        // #######################################################

        #region WNDPROC callback function
        // Processes Windows messages.
        // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.wndproc?view=windowsdesktop-8.0

        /// <summary>
        /// The messages WM_MEASUREITEM and WM_DRAWITEM are sent to the parent control rather than to the ListView itself.
        /// They come here as WM_REFLECT + WM_MEASUREITEM and WM_REFLECT + WM_DRAWITEM
        /// They are sent from Control.WmOwnerDraw() --> Control.ReflectMessageInternal()
        /// </summary>
        protected override void WndProc(ref Message msg)
        {
            base.WndProc(ref msg); // Call Parent Method
            //MessageBox.Show(msg.Msg.ToString());
            switch (msg.Msg)
            {
                // --------------------------------------------------------
                // Called when the ListView becomes visible
                case WM_SHOWWINDOW:
                    Debug.Assert(View == View.Details, "ListViewEx supports only Details view");
                    Debug.Assert(OwnerDraw == false, "In ListViewEx do not set OwnerDraw = true");
                    break;
                // --------------------------------------------------------
                // Called once when the ListView is created, but only in Details view
                case WM_REFLECT + WM_MEASUREITEM:
                    _isItemMeasured = true;
                    // Overwrite itemHeight, which is the fifth integer in MEASUREITEMSTRUCT 
                    Marshal.WriteInt32(msg.LParam + 4 * sizeof(int), _RowHeight);
                    msg.Result = (IntPtr)1;
                    break;
                // --------------------------------------------------------
                // Called for each ListViewItem to be drawn
                case WM_REFLECT + WM_DRAWITEM:
                    DRAWITEMSTRUCT _paramsDraw = (DRAWITEMSTRUCT)msg.GetLParam(typeof(DRAWITEMSTRUCT));
                    using (Graphics graphics = Graphics.FromHdc(_paramsDraw.hDC))
                    {
                        // Get Item
                        ListViewItem item = Items[_paramsDraw.itemID];

                        /*
                        // Item: Background Color
                        Color bgColorItem = item.BackColor;
                        if (item.Selected) bgColorItem = SystemColors.Highlight;
                        if (!Enabled) bgColorItem = SystemColors.Control;

                        // Item: Set Background Color (Entire Row)
                        SolidBrush bgBrushItem = new SolidBrush(bgColorItem);
                        graphics.FillRectangle(bgBrushItem, item.Bounds);
                        *

                        // SubItems
                        DrawSubItem(graphics, item, _paramsDraw.itemID);
                    }
                    break;
                // --------------------------------------------------------
                // Called once Vertical/Horizontal or Mouse Wheel Scrolling
                case WM_VSCROLL:
                case WM_HSCROLL:
                case WM_MOUSEWHEEL:
                    GetScrollPosition(msg);
                    break;
                // --------------------------------------------------------
                // Called on Mouse Left/Right Click 
                case WM_LBUTTONDOWN:
                case WM_RBUTTONDOWN:
                case WM_LBUTTONUP:
                case WM_RBUTTONUP:
                case WM_MOUSEHOVER:
                    int x = ((int)msg.LParam) & 0xFFFF; //LOWORD
                    int y = ((int)msg.LParam >> 16) & 0xFFFF; //HIWORD
                    this.GetItemSubitemFromPoint(x, y);
                    /*if (this.GetItemSubitemFromPoint(x, y))
                        this.RedrawItems(this._RowIdxSelected, this._RowIdxSelected, false);*
                    break;
                // --------------------------------------------------------
                // Callend on Double Left Click
                case WM_LBUTTONDBLCLK:
                    x = ((int)msg.LParam) & 0xFFFF; //LOWORD
                    y = ((int)msg.LParam >> 16) & 0xFFFF; //HIWORD
                    //this.GetItemSubitemFromPoint(x, y);
                    /*if (this.GetItemSubitemFromPoint(x, y))
                        this.RedrawItems(this._RowIdxSelected, this._RowIdxSelected, false);*
                    this.OpenEditorOrAction(x, y);
                    break;
                // Call default
                default:
                    break;
            }
        }

        #endregion

        // #######################################################

    }
*/
}
