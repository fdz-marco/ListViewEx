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
        #region Add Rows

        // #######################################################

        /// <summary>
        /// Add Cells (Row+Item) at Row Index
        /// </summary>
        /// <param name="rowIdx">Row Index</param>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddCellsAtRowIndex(int rowIdx, string content = "")
        {
            ListViewItem item = new ListViewItem(content);
            int columns = (rowIdx > 0) ? this.Items[(rowIdx - 1)].SubItems.Count : (this.Columns.Count);
            int subItems = item.SubItems.Count;
            while (subItems < columns)
            {
                item.SubItems.Add(content);
                subItems = item.SubItems.Count;
            }
            this.Items.Insert(rowIdx, item);
        }

        /// <summary>
        /// Add Cells (Row+Item) at Row Start
        /// </summary>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddCellsAtRowStart(string content = "")
        {
            AddCellsAtRowIndex(0, content);
        }

        /// <summary>
        /// Add Cells (Row+Item) at Row End
        /// </summary>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddCellsAtRowEnd(string content = "")
        {
            AddCellsAtRowIndex(this.Items.Count, content);
        }

        //-------------------------------------------------------

        // #######################################################

        #endregion

        #region Delete Rows

        // #######################################################

        /// <summary>
        /// Delete Cells (Row+Item) at Row Index
        /// </summary>
        /// <param name="rowIdx">Row Index</param>
        /// <returns>(void)</returns>
        public void DeleteCellsAtRowIndex(int rowIdx)
        {
            if (rowIdx < this.Items.Count)
                this.Items.RemoveAt(rowIdx);
        }

        /// <summary>
        /// Delete Cells (Row+Item) at Row Start
        /// </summary>
        /// <returns>(void)</returns>
        public void DeleteCellsAtRowStart()
        {
            if (this.Items.Count > 0)
                this.Items.RemoveAt(0);
        }

        /// <summary>
        /// Delete Cells (Row+Item) at Row End
        /// </summary>
        /// <returns>(void)</returns>
        public void DeleteCellsAtRowEnd()
        {
            if (this.Items.Count > 0)
                this.Items.RemoveAt(this.Items.Count - 1);
        }

        //-------------------------------------------------------

        // #######################################################

        #endregion

        #region Add Rows Batch

        // #######################################################

        /// <summary>
        /// Add Cells (Row+Item) until Row Index
        /// </summary>
        /// <param name="rowIdx">Row Index</param>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddCellsUntilRowIndex(int rowIdx, string content = "")
        {
            int rows = this.Items.Count;
            while (rows <= rowIdx)
            {
                AddCellsAtRowEnd(content);
                rows = this.Items.Count;
            }
        }

        //-------------------------------------------------------

        // #######################################################

        #endregion

        #region Delete Rows Batch

        // #######################################################

        /// <summary>
        /// Delete Cells (Row+Item) until Row Index
        /// </summary>
        /// <param name="rowIdx">Row Index</param>
        /// <returns>(void)</returns>
        public void DeleteCellsFromRowIndex(int rowIdx)
        {
            int rows = this.Items.Count;
            while (rows > rowIdx)
            {
                DeleteCellsAtRowEnd();
                rows = this.Items.Count;
            }
        }

        //-------------------------------------------------------

        // #######################################################

        #endregion
    }
}
