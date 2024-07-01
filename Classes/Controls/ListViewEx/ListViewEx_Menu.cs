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

        #region Menu

        // #######################################################

        private System.Windows.Forms.ContextMenuStrip _menu { get; set; } = null;
        public bool menuEditEnable { get; set; } = false;

        /// <summary>
        /// Initalize Context Menu
        /// </summary>
        /// <returns>(void)</returns>
        private void InitContextMenu()
        {
            this._menu = new System.Windows.Forms.ContextMenuStrip();
            this._menu.Items.Add("Copy cell content", Utils.GetImageResource("/Resources/ListView_CopyCellContent.png"), CopyToClipboard_Cell);
            this._menu.Items.Add("Copy current row", Utils.GetImageResource("/Resources/ListView_CopyCurrentRow.png"), CopyToClipboard_Row);
            this._menu.Items.Add("Copy all selected rows", Utils.GetImageResource("/Resources/ListView_AllSelectedRows.png"), CopyToClipboard_Rows);
            this._menu.Items.Add("Copy column", Utils.GetImageResource("/Resources/ListView_CopyColumn.png"), CopyToClipboard_Column);
            this._menu.Items.Add("Copy All (with headers)", Utils.GetImageResource("/Resources/ListView_CopyAll.png"), CopyToClipboardAll);

            if (menuEditEnable)
            {
                this._menu.Items.Add("-");
                this._menu.Items.Add("Add Column Before", Utils.GetImageResource("/Resources/ListView_ColumnAddBefore.png"), menuAddColumnBefore);
                this._menu.Items.Add("Add Column After", Utils.GetImageResource("/Resources/ListView_ColumnAfter.png"), menuAddColumnAfter);
                this._menu.Items.Add("Delete Column", Utils.GetImageResource("/Resources/ListView_ColumnDelete.png"), menuDeleteColumn);
                this._menu.Items.Add("-");

                this._menu.Items.Add("Add Row Before", Utils.GetImageResource("/Resources/ListView_RowAddBefore.png"), menuAddRowBefore);
                this._menu.Items.Add("Add Row After", Utils.GetImageResource("/Resources/ListView_RowAddAfter.png"), menuAddRowAfter);
                this._menu.Items.Add("Delete Row", Utils.GetImageResource("/Resources/ListView_RowDelete.png"), menuDeleteRow);
                this._menu.Items.Add("-");
            }

            // this.ContextMenuStrip = this._menu;
            this.MouseDown += Action_MouseDownOnTable;
        }

        /// <summary>
        /// Update Context Menu
        /// </summary>
        /// <returns>(void)</returns>
        private void UpdateContextMenu()
        {
            ListViewItem item = this.FocusedItem;
            if ((_ColumnIdxSelected >= 0) && (_ColumnIdxSelected < item.SubItems.Count))
            {
                string cellContent = item.SubItems[_ColumnIdxSelected].Text;
                cellContent = (cellContent.Length > 30) ? cellContent.Substring(0, 30) + "..." : cellContent;

                int totalRowSelected = this.SelectedItems.Count;

                string columnHeader = (_ColumnIdxSelected < this.Columns.Count) ? this.Columns[_ColumnIdxSelected].Text : "";
                this._menu.Items[0].Text = $"Copy cell content ({cellContent})";
                this._menu.Items[2].Text = $"Copy all selected rows ({totalRowSelected})";
                this._menu.Items[3].Text = $"Copy column ({columnHeader})";

               /* if (menuEditEnable)
                {
                    int rowSelected = this._RowIdxSelected;
                    int rowSelectedBefore = (rowSelected <= 0) ? 0 : (this._RowIdxSelected - 1);
                    int rowSelectedAfter = rowSelected + 1;

                    int columnSelected = this._ColumnIdxSelected;
                    int columnBefore = (columnSelected <= 0) ? 0 : (this._ColumnIdxSelected - 1);
                    int columnAfter = columnSelected + 1;

                    this._menu.Items[6].Text = $"Add Column Before ({columnBefore})";
                    this._menu.Items[7].Text = $"Add Column After ({columnAfter})";

                    this._menu.Items[10].Text = $"Add Row Before ({rowSelectedBefore})";
                    this._menu.Items[11].Text = $"Add Row After ({rowSelectedAfter})";
                }
               */
            }
        }

        //-------------------------------------------------------

        /// <summary>
        /// Action Menu: Mouse Down On Table
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        private void Action_MouseDownOnTable(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((this._ItemSelected != null) && (this._SubItemSelected != null))
                {
                    this.FocusedItem = this._ItemSelected;
                    this.FocusedItem.Selected = true;
                    this.UpdateContextMenu();
                    this.ContextMenuStrip = this._menu;
                }
                else
                {
                    this.ContextMenuStrip = null;
                }
            }
            else
            {
                this.ContextMenuStrip = null;
            }
        }

        //-------------------------------------------------------

        /// <summary>
        /// Action Menu: Add Column Before
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        public void menuAddColumnBefore(object sender, EventArgs e)
        {
            if (this._ColumnIdxSelected < 0)
                return;
            int column = this._ColumnIdxSelected;
            if (column < 0) column = 0;

            this.AddCellsAtColIndex(column);
            this.UpdateWidthAtColIndex(column);
        }

        /// <summary>
        /// Action Menu: Add Column After
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        public void menuAddColumnAfter(object sender, EventArgs e)
        {
            if (this._ColumnIdxSelected < 0)
                return;
            int column = this._ColumnIdxSelected;
            this.AddCellsAtColIndex(column + 1);
        }

        /// <summary>
        /// Action Menu: Delete Column
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        public void menuDeleteColumn(object sender, EventArgs e)
        {
            if (this._ColumnIdxSelected < 0)
                return;
            int column = this._ColumnIdxSelected;
            this.DeleteCellsAtColIndex(column);
        }

        //-------------------------------------------------------

        /// <summary>
        /// Action Menu: Add Row Before
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        public void menuAddRowBefore(object sender, EventArgs e)
        {
            if (this._RowIdxSelected < 0)
                return;
            int row = this._RowIdxSelected;
            if (row > 0)
                this.AddCellsAtRowIndex(row);
            else
                this.AddCellsAtRowStart();
        }

        /// <summary>
        /// Action Menu: Add Row After
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        public void menuAddRowAfter(object sender, EventArgs e)
        {
            if (this._RowIdxSelected < 0)
                return;
            int row = this._RowIdxSelected;
            this.AddCellsAtRowIndex(row + 1);
        }

        /// <summary>
        /// Action Menu: Delete Row
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        public void menuDeleteRow(object sender, EventArgs e)
        {
            if (this._RowIdxSelected < 0)
                return;
            int row = this._RowIdxSelected;
            this.DeleteCellsAtRowIndex(row);
        }

        // #######################################################

        #endregion
    }
}
