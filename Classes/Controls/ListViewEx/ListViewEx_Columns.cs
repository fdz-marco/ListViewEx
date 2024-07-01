using static System.Windows.Forms.ListViewItem;

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
        #region Add Columns

        // #######################################################

        /// <summary>
        /// Add  Item (Content) at the Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddItemsAtColIndex(int columnIdx, string content = "")
        {
            foreach (ListViewItem item in this.Items)
            {
                int subItems = item.SubItems.Count;
                // Force Column Creation (Only if needed)
                while (subItems < columnIdx)
                {
                    item.SubItems.Add("");
                    subItems = item.SubItems.Count;
                }
                // Add Item
                if (columnIdx <= subItems)
                {
                    ListViewSubItem subitem = new ListViewSubItem();
                    subitem.Text = content;
                    item.SubItems.Insert(columnIdx, subitem);
                }
            }
        }

        /// <summary>
        /// Add column at the Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="title">Column Title</param>
        /// <param name="width">Column Width</param>
        /// <returns>(void)</returns>
        public void AddColumnAtColIndex(int columnIdx, string? title = null, int width = 150)
        {
            int columns = this.Columns.Count;
            // Force Column Creation (Only if needed)
            while (columns < columnIdx)
            {
                this.Columns.Add($"Column {columns}");
                columns = this.Columns.Count;
            }
            // Add Column
            if (columnIdx <= columns)
            {
                this.Columns.Insert(columnIdx, (title == null) ? $"Column {columnIdx}" : title);
                ColumnHeader header = this.Columns[columnIdx];
                header.Width = width;

            }
        }

        /// <summary>
        /// Add  Cell (Column+Item) at the Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="title">Column Title</param>
        /// <param name="width">Column Width</param>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddCellsAtColIndex(int columnIdx, string? title = null, string content = "", int width = 150)
        {
            AddItemsAtColIndex(columnIdx, content);
            AddColumnAtColIndex(columnIdx, title, width);
        }

        //-------------------------------------------------------

        /// <summary>
        /// Add Items (Content) At the Start
        /// </summary>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddItemAtColStart(string content = "")
        {
            AddItemsAtColIndex(0, content);
        }

        /// <summary>
        /// Add column At the Start
        /// </summary>
        /// <param name="title">Column Title</param>
        /// <param name="width">Column Width</param>
        /// <returns>(void)</returns>
        public void AddColumnAtColStart(string? title = null, int width = 150)
        {
            AddColumnAtColIndex(0, title, width);
        }

        /// <summary>
        /// Add Cells (Column+Item) At the Start
        /// </summary>
        /// <param name="title">Column Title</param>
        /// <param name="content">Content</param>
        /// <param name="width">Column Width</param>
        /// <returns>(void)</returns>
        public void AddCellsAtColStart(string? title = null, string content = "", int width = 150)
        {
            AddItemAtColStart(content);
            AddColumnAtColStart(title, width);
        }

        //-------------------------------------------------------

        /// <summary>
        /// Add Items (Content) At the End
        /// </summary>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddItemsAtColEnd(string content = "")
        {
            int columns = 0;
            foreach (ListViewItem item in this.Items)
            {
                columns = Math.Max(columns, item.SubItems.Count);
            }
            AddItemsAtColIndex(columns, content);
        }

        /// <summary>
        /// Add column At the End
        /// </summary>
        /// <param name="title">Column Title</param>
        /// <param name="width">Column Width</param>
        /// <returns>(void)</returns>
        public void AddColumnAtColEnd(string? title = null, int width = 150)
        {
            int columns = this.Columns.Count;
            AddColumnAtColIndex(columns, title, width);
        }

        /// <summary>
        /// Add Cells (Column+Item) At the End
        /// </summary>
        /// <param name="title">Column Title</param>
        /// <param name="content">Content</param>
        /// <param name="width">Column Width</param>
        /// <returns>(void)</returns>
        public void AddCellsAtColEnd(string? title = null, string content = "", int width = 150)
        {
            AddItemsAtColEnd(content);
            AddColumnAtColEnd(title, width);
        }

        // #######################################################

        #endregion

        #region Delete Columns

        // #######################################################

        /// <summary>
        /// Delete Items (Content) At Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void DeleteItemsAtColIndex(int columnIdx)
        {
            foreach (ListViewItem item in this.Items)
            {
                int subitems = item.SubItems.Count;
                if (columnIdx < subitems)
                {
                    item.SubItems.RemoveAt(columnIdx);
                }
                subitems = item.SubItems.Count;
                if ((subitems == 1) && (item.SubItems[0].Text == ""))
                    item.Remove();
            }
        }

        /// <summary>
        /// Delete Column From At Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void DeleteColumnAtColIndex(int columnIdx)
        {
            int columns = this.Columns.Count;
            if (columnIdx < columns)
            {
                this.Columns.RemoveAt(columnIdx);
            }
        }

        /// <summary>
        /// Delete Cells (Column+Item) At Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void DeleteCellsAtColIndex(int columnIdx)
        {
            DeleteItemsAtColIndex(columnIdx);
            DeleteColumnAtColIndex(columnIdx);
        }

        //-------------------------------------------------------

        /// <summary>
        /// Delete Items (Content) At the Start
        /// </summary>
        /// <returns>(void)</returns>
        public void DeleteItemsAtColStart()
        {
            DeleteItemsAtColIndex(0);
        }

        /// <summary>
        /// Delete column At the Start
        /// </summary>
        /// <returns>(void)</returns>
        public void DeleteColumnAtColStart()
        {
            DeleteColumnAtColIndex(0);
        }

        /// <summary>
        /// Delete Cells (Column+Item) At the Start
        /// </summary>
        /// <returns>(void)</returns>
        public void DeleteCellsAtColStart()
        {
            DeleteItemsAtColStart();
            DeleteColumnAtColStart();
        }

        //-------------------------------------------------------

        /// <summary>
        /// Delete Items (Content) At the End
        /// </summary>
        /// <returns>(void)</returns>
        public void DeleteItemsAtColEnd()
        {
            int columns = 0;
            foreach (ListViewItem item in this.Items)
            {
                columns = Math.Max(columns, item.SubItems.Count);
            }
            DeleteItemsAtColIndex(columns - 1);
        }

        /// <summary>
        /// Delete column At the End
        /// </summary>
        /// <returns>(void)</returns>
        public void DeleteColumnAtColEnd()
        {
            int columns = this.Columns.Count;
            DeleteColumnAtColIndex(columns - 1);
        }

        /// <summary>
        /// Delete Cells (Column+Item) At the End
        /// </summary>
        /// <returns>(void)</returns>
        public void DeleteCellsAtColEnd()
        {
            DeleteItemsAtColEnd();
            DeleteColumnAtColEnd();
        }

        // #######################################################

        #endregion

        #region Add Columns Batch

        // #######################################################

        /// <summary>
        /// Add items until the column index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void AddItemsUntilColIndex(int columnIdx, string content = "")
        {
            foreach (ListViewItem item in this.Items)
            {
                int subItems = item.SubItems.Count;
                // Force Column Creation (Only if needed)
                while (subItems <= columnIdx)
                {
                    item.SubItems.Add(content);
                    subItems = item.SubItems.Count;
                }
            }
        }

        /// <summary>
        /// Add columns until the column index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="title">Column Title</param>
        /// <param name="width">Column Width</param>
        /// <returns>(void)</returns>
        public void AddColumnsUntilColIndex(int columnIdx, string? title = null, int width = 150)
        {
            int columns = this.Columns.Count;
            while (columns <= columnIdx)
            {
                ColumnHeader header = this.Columns.Add((title == null) ? $"Column {columns}" : title);
                header.Width = width;
                columns = this.Columns.Count;
            }
        }

        /// <summary>
        /// Add Cells (Column+Item) until the column index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="title">Column Title</param>
        /// <param name="content">Content</param>
        /// <param name="width">Column Width</param>
        /// <returns>(void)</returns>
        public void AddCellsUntilColIndex(int columnIdx, string? title = null, string content = "", int width = 150)
        {
            AddItemsUntilColIndex(columnIdx, content);
            AddColumnsUntilColIndex(columnIdx, title, width);
        }

        //-------------------------------------------------------

        // #######################################################

        #endregion

        #region Delete Columns Batch

        // #######################################################

        /// <summary>
        /// Delete Items (Content) From Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void DeleteItemsFromColIndex(int columnIdx)
        {
            foreach (ListViewItem item in this.Items)
            {
                // Delete from Col Index 0 means delete the item
                if (columnIdx == 0)
                {
                    item.Remove();
                    continue;
                }
                // If Col Index bigger than 0 then remove items
                int subitems = item.SubItems.Count;
                if ((columnIdx < subitems) && (columnIdx > 0))
                {
                    while (subitems > columnIdx)
                    {
                        item.SubItems.RemoveAt(subitems - 1);
                        subitems = item.SubItems.Count;
                        if (subitems == 1)
                            continue;
                    }
                }

            }
        }

        /// <summary>
        /// Delete columns from the column index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void DeleteColumnsFromColIndex(int columnIdx)
        {
            int columns = this.Columns.Count;
            while (columns > columnIdx)
            {
                this.Columns.RemoveAt(columnIdx);
                columns = this.Columns.Count;
            }
        }

        /// <summary>
        /// Delete Cells (Column+Item) From Column Index
        /// </summary>
        /// <param name="columnIdx">Column Index</param>
        /// <returns>(void)</returns>
        public void DeleteCellsFromColIndex(int columnIdx)
        {
            DeleteColumnsFromColIndex(columnIdx);
            DeleteItemsFromColIndex(columnIdx);
        }

        //-------------------------------------------------------

        // #######################################################

        #endregion
    }
}
