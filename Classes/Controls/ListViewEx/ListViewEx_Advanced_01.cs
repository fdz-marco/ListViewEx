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

        // #######################################################

        #region Variables

        // ----------------------------------------------------
        // Colors + Fonts

        private Color CLR_BG_STANDARD           = Color.White;
        private Color CLR_BG_HOVER              = Color.FromArgb(225, 237, 234);
        private Color CLR_BG_SELECTED           = Color.FromArgb(106, 173, 153);
        private Color CLR_BG_SELECTED_ROW       = Color.FromArgb(171, 219, 205);
        private Color CLR_BG_SELECTED_COLUMN    = Color.FromArgb(171, 219, 205);
        private Color CLR_BG_DISABLED           = Color.Gainsboro;

        private Color CLR_FC_STANDARD           = Color.Black;
        private Color CLR_FC_HOVER              = Color.Black;
        private Color CLR_FC_SELECTED           = Color.White;
        private Color CLR_FC_SELECTED_ROW       = Color.Black;
        private Color CLR_FC_SELECTED_COLUMN    = Color.Black;
        private Color CLR_FC_DISABLED           = Color.DarkGray;

        private Color CLR_FC_LINK               = Color.Blue;
        private Font FNT_LINK                   = new Font("Microsoft Sans Serif", 8, FontStyle.Underline);

        // ----------------------------------------------------
        // Item/SubItem: Selection / Hover
        private int _ColumnIdxSelected = -1;
        private int _RowIdxSelected = -1;
        private ListViewItem? _ItemSelected = null;
        private ListViewItem.ListViewSubItem? _SubItemSelected = null;
        private int _ColumnIdxHover = -1;
        private int _RowIdxHover = -1;

        // ----------------------------------------------------
        // Configurations
        public bool showHover { get; set; } = false;

        // ----------------------------------------------------
        // Editors

        private System.Windows.Forms.DateTimePicker _editor_DatePicker = new System.Windows.Forms.DateTimePicker();
        private System.Windows.Forms.ComboBox _editor_ComboBox = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.TextBox _editor_TextInput = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.TextBox _editor_Password = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.NumericUpDown _editor_NumericUpDown = new System.Windows.Forms.NumericUpDown();

        #endregion

        // #######################################################

        #region Editors

        /// <summary>
        /// Initialize the editors
        /// </summary>
        /// <returns>(void)</returns>
        private void InitEditors()
        {
            this._editor_TextInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._editor_TextInput.Location = new System.Drawing.Point(0, 0);
            this._editor_TextInput.Multiline = true;
            this._editor_TextInput.Size = new System.Drawing.Size(80, 16);
            this._editor_TextInput.Text = "";
            this._editor_TextInput.Visible = false;
            this._editor_TextInput.BackColor = Color.WhiteSmoke;


            this._editor_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._editor_DatePicker.Location = new System.Drawing.Point(0, 0);
            this._editor_DatePicker.Size = new System.Drawing.Size(80, 20);
            this._editor_DatePicker.Visible = false;

            this._editor_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editor_ComboBox.IntegralHeight = false;
            this._editor_ComboBox.ItemHeight = (this.Items.Count>0) ? this.Items[0].Bounds.Height : 16;
            this._editor_ComboBox.Location = new System.Drawing.Point(0, 0);
            this._editor_ComboBox.Size = new System.Drawing.Size(80, 21);
            this._editor_ComboBox.Visible = false;

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

        /// <summary>
        /// Open a Link on Default Browser
        /// </summary>
        /// <param name="url">URL Address</param>
        /// <returns>(bool) Return TRUE if corrected executed</returns>
        private bool OpenLink(string url)
        {
            if (!url.Trim().Contains("://"))
                url = "https://" + url;
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Try to execute an action of subItem
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="subItem">SubItem</param>
        /// <returns>(bool) Return TRUE if corrected executed</returns>
        public bool ExecSubItemAction(ListViewItem item, ListViewItem.ListViewSubItem subItem)
        {
            if ((item == null) || (subItem == null)) { return false; }

            // SubItem: Get advanced features
            ListViewExSubItemSettings subItemSettings = (ListViewExSubItemSettings)subItem.Tag;
            if (subItemSettings == null) { return false; }

            // Chose Action
            switch (subItemSettings.dataType)
            {
                // Link Text
                case ListViewExDataType.Link:
                    return OpenLink(subItem.Text);
                   //break;
                // Text Editor
                case ListViewExDataType.Text:
                    return OpenEditor(item, subItem, this._editor_TextInput);
                    //break;
                // List Editor
                case ListViewExDataType.List:
                    return OpenEditor(item, subItem, this._editor_ComboBox, subItemSettings.options);
                    //break;
            }
            return false;
        }

        /// <summary>
        /// Open Editor
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="subItem">SubItem</param>
        /// <param name="ctrl">Control Item</param>
        /// <param name="options">List of options (if apply)</param>
        /// <returns>(bool) Return TRUE if corrected executed</returns>
        public bool OpenEditor(ListViewItem item, ListViewItem.ListViewSubItem subItem, Control ctrl, string[] options = null)
        {
            // SubItem: Get Bounds
            Rectangle boundsSubItem = GetBoundsSubItem(item, subItem);
            ctrl.Bounds = boundsSubItem;

            switch (ctrl)
            {
                case TextBox tb:
                    tb.Text = subItem.Text;
                    break;
                case ComboBox cb:
                    cb.Text = subItem.Text;
                    cb.Items.Clear();
                    cb.Items.AddRange(options);
                    break;
                default:
                    break;
            }
            //ctrl.SelectionStart = ctrl.Text.Length;
            //ctrl.SelectionLength = 0;
            ctrl.Visible = true;
            ctrl.BringToFront();
            ctrl.Focus();
            this.Invalidate(ctrl.Bounds);
            return true;
        }

        #endregion

        // #######################################################

        #region Mouse Events Helpers

        /// <summary>
        /// Get the Item and SubItem from a X,Y Point on the Table
        /// </summary>
        /// <param name="x">Position X</param>
        /// <param name="y">Position Y</param>
        /// <param name="isClicked">Is Clicked / (Or Only Hover)</param>
        /// <returns>(bool) True if is inside or a Item/SubItem, False if not</returns>
        public bool GetItemSubitemFromPoint(int x, int y, bool isClicked = false)
        {
            ListViewHitTestInfo info = this.HitTest(x, y);
            if (info.Item != null && info.SubItem != null)
            {
                this._ColumnIdxHover = info.Item.SubItems.IndexOf(info.SubItem);
                this._RowIdxHover = this.Items.IndexOf(info.Item);
                if (isClicked)
                {
                    this._ColumnIdxSelected = info.Item.SubItems.IndexOf(info.SubItem);
                    this._RowIdxSelected = this.Items.IndexOf(info.Item);
                    this._ItemSelected = info.Item;
                    this._SubItemSelected = info.SubItem;
                }
                return true;
            }
            //this._ColumnIdxSelected = -1; // Commented to remember the last element clicked
            //this._RowIdxSelected = -1; // Commented to remember the last element clicked
            //this._ItemSelected = null; // Commented to remember the last element clicked
            //this._SubItemSelected = null; // Commented to remember the last element clicked
            this._ColumnIdxHover = -1;
            this._RowIdxHover = -1;
            return false;
        }

        /// <summary>
        /// Check if Item is selected
        /// </summary>
        /// <param name="item">Item to check</param>
        /// <returns>(bool) True if is selected</returns>
        public bool IsItemSelected(ListViewItem item)
        {
            if ((item == null)) { return false; }
            if (this._ItemSelected == null) { return false; }
            return (this._ItemSelected == item);
        }

        /// <summary>
        /// Check if SubItem is selected
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="subItem">SubItem</param>
        /// <returns>(bool) True if is selected</returns>
        public bool IsSubItemSelected(ListViewItem item, ListViewItem.ListViewSubItem subItem)
        {
            if ((item == null) || (subItem == null)) { return false; }
            if ((this._ItemSelected == null) || (this._SubItemSelected == null)){ return false; }
            return ((this._ItemSelected == item) && (this._SubItemSelected == subItem));
        }

        /// <summary>
        /// Check if the Mouse is Hover the Column
        /// </summary>
        /// <param name="subItemIdx">Index of SubItem (aka column)</param>
        /// <returns>(bool) True if is Hover</returns>
        public bool IsMouseHoverColumn(int subItemIdx)
        {
            if ((subItemIdx <0)) { return false; }
            if (this._ColumnIdxHover < 0) { return false; }
            return (this._ColumnIdxHover == subItemIdx);
        }

        /// <summary>
        /// Check if the Mouse is Hover the Row
        /// </summary>
        /// <param name="itemIdx">Index of Item (aka Row)</param>
        /// <returns>(bool) True if is Hover</returns>
        public bool IsMouseHoverRow(int itemIdx)
        {
            if ((itemIdx < 0)) { return false; }
            if (this._RowIdxHover < 0) { return false; }
            return (this._RowIdxHover == itemIdx);
        }

        #endregion

        // #######################################################

        #region Get Bounds

        /// <summary>
        /// Get Bounds of a Sub Item
        /// </summary>
        /// <param name="item">Item</param>
        /// <param name="subItem">SubItem</param>
        /// <returns>(Rectangle) Bounds</returns>
        public Rectangle GetBoundsSubItem(ListViewItem item, ListViewItem.ListViewSubItem subItem)
        {
            if ((item == null) || (subItem == null)) 
                return Rectangle.Empty;
            int subItemIdx = item.SubItems.IndexOf(subItem);
            if (subItemIdx < 0)
                return Rectangle.Empty;
            // Item.SubItems[0].Bounds contains the entire row, not only the first column,
            // So only for the first column is needed to take the label bounds
            Rectangle boundsSubItem = (subItemIdx > 0) ? subItem.Bounds : item.GetBounds(ItemBoundsPortion.Label); 
            return boundsSubItem;
        }

        /// <summary>
        /// Get Bounds of a Columns
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(Rectangle) Bounds</returns>
        public Rectangle GetBoundsColumn(int columnIdx)
        {
            if (columnIdx < 0 || columnIdx >= this.Columns.Count)
                return Rectangle.Empty;

            Rectangle bounds = this.Bounds;
            int x = bounds.Left;
            for (int i = 0; i < columnIdx; i++)
            {
                x += this.Columns[i].Width;
            }
            return new Rectangle(x, bounds.Top, this.Columns[columnIdx].Width, bounds.Height);
        }

        #endregion

        // #######################################################

        #region Draw Methods

        /// <summary>
        /// Get Standard Text Flags
        /// </summary>
        /// <param name="ColumnAlign">Column Align</param>
        /// <returns>(TextFormatFlags) Flags</returns>
        public TextFormatFlags GetStandardTextFlags(HorizontalAlignment ColumnAlign)
        {

            TextFormatFlags flags = TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;

            switch (ColumnAlign)
            {
                case HorizontalAlignment.Center:
                    flags |= TextFormatFlags.HorizontalCenter;
                    break;
                case HorizontalAlignment.Right:
                    flags |= TextFormatFlags.Right;
                    break;
            };

            return flags;
        }

        /// <summary>
        /// Check if SubItem is a Link from Tag Settings
        /// </summary>
        /// <param name="subItem">SubItem</param>
        /// <returns>(bool) TRUE is a Link Type</returns>
        public bool IsSubItemLink(ListViewItem.ListViewSubItem subItem)
        {
            // SubItem: Get advanced features
            ListViewExSubItemSettings subItemSettings = (ListViewExSubItemSettings)subItem.Tag;
            // SubItem: Check If Is Link
            if (subItemSettings != null)
                if (subItemSettings.dataType == ListViewExDataType.Link)
                    return true;
            return false;
        }

        /// <summary>
        /// Draw a Item
        /// </summary>
        /// <param name="graphics">Graphics</param>
        /// <param name="item">Item</param>
        /// <param name="itemIdx">Item Index</param>
        /// <returns>(void)</returns>
        public void DrawItem(Graphics graphics, ListViewItem item, int itemIdx)
        {
            if ((graphics == null) || (item == null) || (itemIdx < 0))
                return;

          //  this.BeginUpdate();

            // Item: Set Background Color (Entire Row) (SystemColors.Highlight | SystemColors.Control)
            Color bgColorItem =  (!Enabled) ? CLR_BG_DISABLED : CLR_BG_STANDARD;
            SolidBrush bgBrushItem = new SolidBrush(bgColorItem);
            graphics.FillRectangle(bgBrushItem, item.Bounds); // Entire Row

          ///  this.EndUpdate();

            // Clean
            bgBrushItem.Dispose();
            graphics.Dispose();
        }

        /// <summary>
        /// Draw a SubItem
        /// </summary>
        /// <param name="graphics">Graphics</param>
        /// <param name="item">Item</param>
        /// <param name="subItem">SubItem</param>
        /// <param name="itemIdx">Item Index</param>
        /// <param name="subItemIdx">SubItem Index</param>
        /// <returns>(void)</returns>
        public void DrawSubItem(Graphics graphics, ListViewItem item, ListViewItem.ListViewSubItem subItem, int itemIdx, int subItemIdx)
        {
            if ((graphics == null) || (item == null) || (subItem == null) || (itemIdx < 0) || (subItemIdx < 0))
                return;

            //this.BeginUpdate();

            // SubItem: Get Bounds
            Rectangle boundsSubItem = GetBoundsSubItem(item, subItem);

            // SubItem: Set Background Color
            Color bgColorSubItem =
                IsSubItemSelected(item, subItem) ? CLR_BG_SELECTED :
                IsItemSelected(item) ? CLR_BG_SELECTED_ROW :
                ((IsMouseHoverRow(itemIdx) || IsMouseHoverColumn(subItemIdx)) && this.showHover) ? CLR_BG_HOVER :
                (!Enabled) ? CLR_BG_DISABLED : 
                Color.Transparent;
            SolidBrush bgBrushSubItem = new SolidBrush(bgColorSubItem);
            graphics.FillRectangle(bgBrushSubItem, boundsSubItem);

            // SubItem: Image
            if (IsSubItemLink(subItem))
            {
                Image? image = Utils.GetImageResource("Resources/link.png");
                int imageSize = boundsSubItem.Height - 2;
                Rectangle imageRect = new Rectangle(boundsSubItem.Left + 2, boundsSubItem.Top + 1, imageSize, imageSize);
                graphics.DrawImage(image, imageRect);
                // Adjust Bounds Sub Item
                boundsSubItem = new Rectangle(boundsSubItem.Left + imageRect.Width + 4, boundsSubItem.Top, boundsSubItem.Width - imageRect.Width - 6, boundsSubItem.Height);
            }

            // SubItem: Set Font Color, Font Style
            Color fontColorSubItem =
                IsSubItemSelected(item, subItem) ? CLR_FC_SELECTED :
                IsItemSelected(item) ? CLR_FC_SELECTED_ROW :
                ((IsMouseHoverRow(itemIdx) || IsMouseHoverColumn(subItemIdx)) && this.showHover) ? CLR_FC_HOVER :
                (!Enabled) ? CLR_FC_DISABLED :
                CLR_FC_STANDARD;
            fontColorSubItem = (IsSubItemLink(subItem)) ? CLR_FC_LINK : fontColorSubItem;
            TextFormatFlags flags = GetStandardTextFlags(Columns[subItemIdx].TextAlign);
            subItem.Font = (IsSubItemLink(subItem)) ? FNT_LINK : subItem.Font;
            TextRenderer.DrawText(graphics, subItem.Text, subItem.Font, boundsSubItem, fontColorSubItem, flags);

           // this.EndUpdate();


            // Clean
            bgBrushSubItem.Dispose();
            graphics.Dispose();
        }

        #endregion

        // #######################################################

        #region Override Methods (Custom ListView Behaviour)

        /// <summary>
        /// Override OnDrawColumnHeader Event, trigger on Draw a Column Header
        /// </summary>
        /// <returns>(void)</returns>
        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        /// <summary>
        /// Override OnDrawItem Event, trigger on Draw a Item
        /// </summary>
        /// <returns>(void)</returns>
        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            DrawItem(e.Graphics, e.Item, e.ItemIndex);
            //e.DrawDefault = true;
        }

        /// <summary>
        /// Override OnDrawSubItem Event, trigger on Draw a SubItem
        /// </summary>
        /// <returns>(void)</returns>
        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            DrawSubItem(e.Graphics, e.Item, e.SubItem, e.ItemIndex, e.ColumnIndex);
            //e.DrawDefault = true;
        }

        /// <summary>
        /// Override OnColumnWidthChanged Event, trigger on Column Width Change
        /// </summary>
        /// <returns>(void)</returns>
        protected override void OnColumnWidthChanged(ColumnWidthChangedEventArgs e)
        {
            base.OnColumnWidthChanged(e);
        }

        /// <summary>
        /// Override OnInvalidated Event, trigger on ReDraw
        /// </summary>
        /// <returns>(void)</returns>
        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
        }

        /// <summary>
        /// Override OnMouseMove Event, trigger on mouse move
        /// </summary>
        /// <returns>(void)</returns>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            this.GetItemSubitemFromPoint(e.X, e.Y, false);
            if (this.showHover)
                this.Invalidate(this.Bounds);
            //this.Invalidate(this.Bounds);
            //if (this._ItemSelected!=null) this.Invalidate(this._ItemSelected.Bounds);
            //if (this._SubItemSelected != null) this.Invalidate(this._SubItemSelected.Bounds);
            //this.Invalidate(this.GetBoundsColumn(this._ColumnIdxSelected));
        }

        /// <summary>
        /// Override OnMouseDown Event, trigger on Click (Start)
        /// </summary>
        /// <returns>(void)</returns>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.GetItemSubitemFromPoint(e.X, e.Y, true);
            //this.Invalidate(this.Bounds);
        }

        /// <summary>
        /// Override OnMouseUp Event, trigger on Click (End)
        /// </summary>
        /// <returns>(void)</returns>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.GetItemSubitemFromPoint(e.X, e.Y, true);
            //this.Invalidate(this.Bounds);
        }

        /// <summary>
        /// Override OnMouseDoubleClick Event, trigger on Double Click
        /// </summary>
        /// <remarks>
        /// If FullRowSelect is set to False, only works with the first element of row (aka Item)
        /// </remarks>
        /// <returns>(void)</returns>
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            this.GetItemSubitemFromPoint(e.X, e.Y, true);
            ExecSubItemAction(this._ItemSelected, this._SubItemSelected);
            //this.Invalidate(this.Bounds);
        }

        #endregion

        // #######################################################

    }
}
