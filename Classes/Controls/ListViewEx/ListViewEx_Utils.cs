using System.Diagnostics;

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
        #region Column

        // #######################################################

        /// <summary>
        /// Update Width At Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void UpdateWidthAtColIndex(int columnIdx)
        {
            if (columnIdx >= this.Columns.Count)
                return;
            int maxLengthContent = 0;

            try
            {
                // Create Graphics to Measure
                Graphics graphics = this.CreateGraphics();
                // Measure Header Size
                SizeF columnTextSize = graphics.MeasureString(this.Columns[columnIdx].Text, this.Font);
                int columnTextLength = (int)columnTextSize.Width + 10; // Padding: 10px
                maxLengthContent = Math.Max(maxLengthContent, columnTextLength);
                // Analize subitems content
                foreach (ListViewItem item in this.Items)
                {
                    if (columnIdx >= item.SubItems.Count)
                        continue;
                    // Measure Text Length
                    SizeF cellTextSize = graphics.MeasureString(item.SubItems[columnIdx].Text, this.Font);
                    int cellTextLength = (int)cellTextSize.Width + 10; // Padding: 10px
                    // Add More padding if is Link (For Image)
                    if (IsSubItemLink(item.SubItems[columnIdx]))
                        cellTextLength += 12;
                    maxLengthContent = Math.Max(maxLengthContent, cellTextLength); 
                }
                graphics.Dispose();
                this.Columns[columnIdx].Width = maxLengthContent;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Update Width At All Columns
        /// </summary>
        /// <returns>(void)</returns>
        public void UpdateWidthAll()
        {
            int columns = this.Columns.Count;
            for (int i = 0; i < columns; i++)
            {
                UpdateWidthAtColIndex(i);
            }
        }

        /// <summary>
        /// Set A Column Title At Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="title">Column Title</param>
        /// <returns>(void)</returns>
        public void SetColumnTitleAtColIndex(int columnIdx, string title)
        {
            int columns = this.Columns.Count;
            if (columnIdx < columns)
            {
                this.Columns[columnIdx].Text = title;
            }
        }

        // #######################################################

        #endregion

        #region Colors

        // #######################################################

        /// <summary>
        /// Set a Background Color to a Cell
        /// </summary>
        /// <param name="rowIdx">Row Index</param>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="color">Color</param>
        /// <returns>(void)</returns>
        public void SetCellBackgroundColor(int rowIdx, int columnIdx, Color color)
        {
            int items = this.Items.Count;
            if (rowIdx < items)
            {
                if (columnIdx < this.Items[rowIdx].SubItems.Count)
                {
                    this.Items[rowIdx].SubItems[columnIdx].BackColor = color;
                }
            }
        }

        /// <summary>
        /// Set a Font Color to a Cell
        /// </summary>
        /// <param name="rowIdx">Row Index</param>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="color">Color</param>
        /// <returns>(void)</returns>
        public void SetCellFontColor(int rowIdx, int columnIdx, Color color)
        {
            int items = this.Items.Count;
            if (rowIdx < items)
            {
                if (columnIdx < this.Items[rowIdx].SubItems.Count)
                {
                    this.Items[rowIdx].SubItems[columnIdx].ForeColor = color;
                }
            }
        }

        // #######################################################

        #endregion

        #region Columns To Editable Type

        // #######################################################

        /// <summary>
        /// Set a Column Index to a Link Field
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void SetColumnIndexToLinks(int columnIdx)
        {
            foreach (ListViewItem item in this.Items) {
                item.SubItems[columnIdx].Tag = new ListViewExSubItemSettings(ListViewExDataType.Link);
            }
        }

        /// <summary>
        /// Set a Column Index to a Editable Field of Text Type
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void SetColumnIndexToEditableText(int columnIdx)
        {
            foreach (ListViewItem item in this.Items)
            {
                item.SubItems[columnIdx].Tag = new ListViewExSubItemSettings(ListViewExDataType.Text);
            }
        }

        /// <summary>
        /// Set a Column Index to a Editable Field of Combo Box Type
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="options">Array of String for the options</param>
        /// <returns>(void)</returns>
        public void SetColumnIndexToEditableList(int columnIdx, string[] options)
        {
            foreach (ListViewItem item in this.Items)
            {
                ListViewExSubItemSettings settings = new ListViewExSubItemSettings(ListViewExDataType.List);
                settings.options = options;
                item.SubItems[columnIdx].Tag = settings;
            }
        }

        /// <summary>
        /// Set a Column Index to a Editable Field of Number Type
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void SetColumnIndexToEditableNumber(int columnIdx)
        {
            foreach (ListViewItem item in this.Items)
            {
                item.SubItems[columnIdx].Tag = new ListViewExSubItemSettings(ListViewExDataType.Number);
            }
        }

        // #######################################################

        #endregion
    }
}
