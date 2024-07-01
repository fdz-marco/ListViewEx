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
        #region Cells Actions

        // #######################################################

        /// <summary>
        /// Update Cell Content (Row+Item) at Row Index and Column Index
        /// </summary>
        /// <param name="rowIdx">Row Index</param>
        /// <param name="columnIdx">Column Index</param>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void UpdateCellAtRowIndexAtColIndex(int rowIdx, int columnIdx, string content)
        {
            int items = this.Items.Count;
            if (rowIdx < items)
            {
                if (columnIdx < this.Items[rowIdx].SubItems.Count)
                {
                    this.Items[rowIdx].SubItems[columnIdx].Text = content;
                }
            }
        }

        /// <summary>
        /// Update (and add if neccesary) Cell Content (Row+Item) at Row Index and Column Index
        /// </summary>
        /// <param name="indexRow">Row Index</param>
        /// <param name="indexCol">Column Index</param>
        /// <param name="content">Content</param>
        /// <returns>(void)</returns>
        public void UpdateAddCellAtIndexRowAtIndexCol(int rowIdx, int columnIdx, string content = "")
        {
            AddCellsUntilColIndex(columnIdx);
            AddCellsUntilRowIndex(rowIdx);
            UpdateCellAtRowIndexAtColIndex(rowIdx, columnIdx, content);
        }

        // #######################################################

        #endregion

    }
}
