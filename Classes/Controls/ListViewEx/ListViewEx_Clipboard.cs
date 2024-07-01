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
        #region Clipboard Tasks

        public bool ConfirmAfterCopied { get; set; } = true;

        // #######################################################

        /// <summary>
        /// Copy To Clipboard
        /// </summary>
        /// <param name="includeHeaders">Include Headers</param>
        /// <returns>(void)</returns>
        public void CopyToClipboard(bool includeHeaders = true)
        {
            int totalColumns = this.Columns.Count;
            string clipboardText = "";

            if (includeHeaders)
            {
                for (int i = 0; i < totalColumns; i++)
                {
                    clipboardText += $"{this.Columns[i].Text.Trim()}\t";
                }
                clipboardText += "\n";
            }

            foreach (ListViewItem item in this.Items)
            {
                clipboardText += $"{item.Text}\t";
                for (int i = 1; i < totalColumns; i++)
                {
                    if (i < item.SubItems.Count)
                        clipboardText += $"{item.SubItems[i].Text.Trim()}\t";
                }
                clipboardText += "\n";
            }

            Clipboard.SetText(clipboardText);
            //MessageBox.Show("Table content copied to clipboard. You can paste it (Ctrl+V) somewhere else.");
            if (ConfirmAfterCopied)
                MessageBox.Show("Table content copied to clipboard. You can paste it (Ctrl+V) somewhere else. ", "Content Copied", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
        }

        /// <summary>
        /// Copy To Clipboard (Alias)
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        private void CopyToClipboardAll(object sender, EventArgs e)
        {
            CopyToClipboard(true);
        }

        /// <summary>
        /// Copy Cell To Clipboard
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        private void CopyToClipboard_Cell(object sender, EventArgs e)
        {
            if (this.SelectedItems.Count > 0)
            {
                ListViewItem item = this.SelectedItems[0];
                if ((this._ColumnIdxSelected >= 0) && (this._ColumnIdxSelected < item.SubItems.Count))
                {
                    string clipboardText = $"{item.SubItems[_ColumnIdxSelected].Text}";
                    Clipboard.SetText(clipboardText.Trim());
                    //MessageBox.Show("Cell content copied to clipboard. You can paste it (Ctrl+V) somewhere else.");
                    if (ConfirmAfterCopied)
                        MessageBox.Show("Cell content copied to clipboard. You can paste it (Ctrl+V) somewhere else. ", "Content Copied", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                }
            }
            this.ContextMenuStrip = null;
        }

        /// <summary>
        /// Copy Row To Clipboard
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        private void CopyToClipboard_Row(object sender, EventArgs e)
        {
            if (this.SelectedItems.Count > 0)
            {
                ListViewItem item = this.SelectedItems[0];
                string clipboardText = $"";
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    if (i < item.SubItems.Count)
                        clipboardText += $"{item.SubItems[i].Text.Trim()}\t";
                }
                Clipboard.SetText(clipboardText.Trim());
                //MessageBox.Show("Row content copied to clipboard. You can paste it (Ctrl+V) somewhere else.");
                if (ConfirmAfterCopied)
                    MessageBox.Show("Row content copied to clipboard. You can paste it (Ctrl+V) somewhere else. ", "Content Copied", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
            }
            this.ContextMenuStrip = null;
        }

        /// <summary>
        /// Copy Rows To Clipboard
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        private void CopyToClipboard_Rows(object sender, EventArgs e)
        {
            if (this.SelectedItems.Count > 0)
            {
                string clipboardText = $"";
                foreach (ListViewItem item in this.SelectedItems)
                {
                    for (int i = 0; i < this.Columns.Count; i++)
                    {
                        if (i < item.SubItems.Count)
                            clipboardText += $"{item.SubItems[i].Text.Trim()}\t";
                    }
                    clipboardText += $"{System.Environment.NewLine}";
                }
                Clipboard.SetText(clipboardText.Trim());
                //MessageBox.Show("Rows content copied to clipboard. You can paste it (Ctrl+V) somewhere else.");
                if (ConfirmAfterCopied)
                    MessageBox.Show("Rows content copied to clipboard. You can paste it (Ctrl+V) somewhere else. ", "Content Copied", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
            }
            this.ContextMenuStrip = null;
        }

        /// <summary>
        /// Copy Column To Clipboard
        /// </summary>
        /// <param name="sender">Sender/param>
        /// <param name="e">Event Arguments</param>
        /// <returns>(void)</returns>
        private void CopyToClipboard_Column(object sender, EventArgs e)
        {
            if (this.SelectedItems.Count > 0)
            {
                if (this._ColumnIdxSelected >= 0)
                {
                    string clipboardText = $"";
                    for (int i = 0; i < this.Items.Count; i++)
                    {
                        if (_ColumnIdxSelected < this.Items[i].SubItems.Count)
                            clipboardText += $"{this.Items[i].SubItems[_ColumnIdxSelected].Text.Trim()}{System.Environment.NewLine}";
                    }
                    Clipboard.SetText(clipboardText.Trim());
                    //MessageBox.Show("Column content copied to clipboard. You can paste it (Ctrl+V) somewhere else.");
                    if (ConfirmAfterCopied)
                        MessageBox.Show("Column content copied to clipboard. You can paste it (Ctrl+V) somewhere else. ", "Content Copied", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                }
            }
            this.ContextMenuStrip = null;
        }

        // #######################################################

        #endregion
    }
}
