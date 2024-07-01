namespace ListViewExt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btn_addContent_Click(null, null);
            lv_Test.AddColumnsUntilColIndex(9);
            this.btn_UpdateWidthAll_Click(null, null);
            lv_Test.menuEditEnable = true;
            lv_Test.SetColumnIndexToLinks(2);
            lv_Test.SetColumnIndexToEditableText(1);
            lv_Test.SetColumnIndexToEditableList(3, new string[] { "Volvo", "BMW", "Ford", "Mazda" });
            lv_Test.UpdateAddCellAtIndexRowAtIndexCol(0, 2, "google.com");
            lv_Test.UpdateAddCellAtIndexRowAtIndexCol(1, 2, "amazon.com");
            lv_Test.UpdateAddCellAtIndexRowAtIndexCol(2, 2, "bing.com");
            lv_Test.UpdateAddCellAtIndexRowAtIndexCol(3, 2, "tesla.com");
        }

        private void btn_addContent_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 10; j++)
                {
                    if (j == 0)
                    {
                        item.Text = $"Cell ({i},{j})";
                        continue;
                    }
                    item.SubItems.Add($"Cell ({i},{j})");
                }
                lv_Test.Items.Add(item);
            }
        }

        /* ############################################################## */

        #region Buttons actions to test functionality

        private void btn_UpdateWidthAll_Click(object sender, EventArgs e)
        {
            lv_Test.UpdateWidthAll();
        }

        private void btn_UpdateWidthAtColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.UpdateWidthAtColIndex(colIndex);
        }

        private void btn_SetColumnTitleAtColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.SetColumnTitleAtColIndex(colIndex, "Custom Title");
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_DeleteItemsFromColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.DeleteItemsFromColIndex(colIndex);
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteColumnsFromColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.DeleteColumnsFromColIndex(colIndex);
            lv_Test.UpdateWidthAll();
        }


        private void btn_DeleteCellsFromColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.DeleteCellsFromColIndex(colIndex);
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_DeleteItemsAtColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.DeleteItemsAtColIndex(colIndex);
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteColumnAtColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.DeleteColumnAtColIndex(colIndex);
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteCellsAtColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.DeleteCellsAtColIndex(colIndex);
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_DeleteItemsAtColStart_Click(object sender, EventArgs e)
        {
            lv_Test.DeleteItemsAtColStart();
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteColumnAtColStart_Click(object sender, EventArgs e)
        {
            lv_Test.DeleteColumnAtColStart();
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteCellsAtColStart_Click(object sender, EventArgs e)
        {
            lv_Test.DeleteCellsAtColStart();
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_DeleteItemsAtColEnd_Click(object sender, EventArgs e)
        {
            lv_Test.DeleteItemsAtColEnd();
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteColumnAtColEnd_Click(object sender, EventArgs e)
        {
            lv_Test.DeleteColumnAtColEnd();
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteCellsAtColEnd_Click(object sender, EventArgs e)
        {
            lv_Test.DeleteCellsAtColEnd();
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_AddItemsAtColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.AddItemsAtColIndex(colIndex, "Col Index");
            lv_Test.UpdateWidthAll();
        }

        private void btn_AddColumnAtColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.AddColumnAtColIndex(colIndex, "Col Index");
            lv_Test.UpdateWidthAll();
        }

        private void btn_AddCellsAtColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.AddCellsAtColIndex(colIndex, "Col Index*", "Col Index*");
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_AddItemAtColStart_Click(object sender, EventArgs e)
        {
            lv_Test.AddItemAtColStart("Col Start");
            lv_Test.UpdateWidthAll();
        }


        private void btn_AddColumnAtColStart_Click(object sender, EventArgs e)
        {
            lv_Test.AddColumnAtColStart("Col Start");
            lv_Test.UpdateWidthAll();
        }


        private void btn_AddCellsAtColStart_Click(object sender, EventArgs e)
        {
            lv_Test.AddCellsAtColStart("Col Start*", "Col Start*");
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_AddItemsAtColEnd_Click(object sender, EventArgs e)
        {
            lv_Test.AddItemsAtColEnd("Col End");
            lv_Test.UpdateWidthAll();
        }


        private void btn_AddColumnAtColEnd_Click(object sender, EventArgs e)
        {
            lv_Test.AddColumnAtColEnd("Col End");
            lv_Test.UpdateWidthAll();
        }

        private void btn_AddCellsAtColEnd_Click(object sender, EventArgs e)
        {
            lv_Test.AddCellsAtColEnd("Col End*", "Col End*");
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_AddItemsUntilColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.AddItemsUntilColIndex(colIndex);
            lv_Test.UpdateWidthAll();
        }

        private void btn_AddColumnsUntilColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.AddColumnsUntilColIndex(colIndex);
            lv_Test.UpdateWidthAll();
        }

        private void btn_AddCellsUntilColIndex_Click(object sender, EventArgs e)
        {
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.AddCellsUntilColIndex(colIndex, null, "Added Content");
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/


        private void btn_AddCellsAtRowIndex_Click(object sender, EventArgs e)
        {
            int rowIndex = Int16.Parse(txt_RowIndex.Text);
            lv_Test.AddCellsAtRowIndex(rowIndex, "Row Index");
            lv_Test.UpdateWidthAll();
        }

        private void btn_AddCellsAtRowStart_Click(object sender, EventArgs e)
        {
            lv_Test.AddCellsAtRowStart("Row Start");
            lv_Test.UpdateWidthAll();
        }

        private void btn_AddCellsAtRowEnd_Click(object sender, EventArgs e)
        {
            lv_Test.AddCellsAtRowEnd("Row End");
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_DeleteCellsAtRowIndex_Click(object sender, EventArgs e)
        {
            int rowIndex = Int16.Parse(txt_RowIndex.Text);
            lv_Test.DeleteCellsAtRowIndex(rowIndex);
        }

        private void btn_DeleteCellsAtRowStart_Click(object sender, EventArgs e)
        {
            lv_Test.DeleteCellsAtRowStart();
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteCellsAtRowEnd_Click(object sender, EventArgs e)
        {
            lv_Test.DeleteCellsAtRowEnd();
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_AddCellsUntilRowIndex_Click(object sender, EventArgs e)
        {
            int rowIndex = Int16.Parse(txt_RowIndex.Text);
            lv_Test.AddCellsUntilRowIndex(rowIndex, "Added Content");
            lv_Test.UpdateWidthAll();
        }

        private void btn_DeleteCellsFromRowIndex_Click(object sender, EventArgs e)
        {
            int rowIndex = Int16.Parse(txt_RowIndex.Text);
            lv_Test.DeleteCellsFromRowIndex(rowIndex);
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_UpdateCellAtRowIndexAtColIndex_Click(object sender, EventArgs e)
        {
            int rowIndex = Int16.Parse(txt_RowIndex.Text);
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.UpdateCellAtRowIndexAtColIndex(rowIndex, colIndex, $"Updated Cell ({rowIndex},{colIndex})");
            lv_Test.UpdateWidthAll();
        }

        private void btn_UpdateAddCellAtIndexRowAtIndexCol_Click(object sender, EventArgs e)
        {
            int rowIndex = Int16.Parse(txt_RowIndex.Text);
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.UpdateAddCellAtIndexRowAtIndexCol(rowIndex, colIndex, $"Updated+Added Cell ({rowIndex},{colIndex})");
            lv_Test.UpdateWidthAll();
        }

        /*----------------------------------------------*/

        private void btn_CustomBackgroundAtIndexRowAtIndexCol_Click(object sender, EventArgs e)
        {
            int rowIndex = Int16.Parse(txt_RowIndex.Text);
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.SetCellBackgroundColor(rowIndex, colIndex, Color.Gray);
        }

        private void btn_CustomFontAtIndexRowAtIndexCol_Click(object sender, EventArgs e)
        {
            int rowIndex = Int16.Parse(txt_RowIndex.Text);
            int colIndex = Int16.Parse(txt_ColIndex.Text);
            lv_Test.SetCellFontColor(rowIndex, colIndex, Color.BlueViolet);
        }

        #endregion

        /* ############################################################## */

    }
}