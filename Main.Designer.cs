namespace ListViewExt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lv_Test = new glitcher.core.Controls.ListViewEx();
            btn_AddColumnsUntilColIndex = new Button();
            btn_DeleteColumnsFromColIndex = new Button();
            btn_addContent = new Button();
            btn_AddColumnAtColEnd = new Button();
            btn_DeleteColumnAtColEnd = new Button();
            btn_SetColumnTitleAtColIndex = new Button();
            btn_AddColumnAtColStart = new Button();
            btn_DeleteColumnAtColStart = new Button();
            btn_UpdateAddCellAtIndexRowAtIndexCol = new Button();
            btn_DeleteItemsFromColIndex = new Button();
            btn_DeleteItemsAtColIndex = new Button();
            btn_UpdateCellAtRowIndexAtColIndex = new Button();
            btn_UpdateWidthAtColIndex = new Button();
            btn_UpdateWidthAll = new Button();
            btn_CustomBackgroundAtIndexRowAtIndexCol = new Button();
            btn_CustomFontAtIndexRowAtIndexCol = new Button();
            btn_AddItemsAtColIndex = new Button();
            btn_AddItemsAtColStart = new Button();
            btn_AddItemsAtColEnd = new Button();
            btn_DeleteCellsFromColIndex = new Button();
            txt_ColIndex = new TextBox();
            btn_DeleteItemsAtColStart = new Button();
            btn_DeleteItemsAtColEnd = new Button();
            btn_DeleteColumnAtColIndex = new Button();
            btn_DeleteCellsAtColIndex = new Button();
            btn_DeleteCellsAtColStart = new Button();
            btn_DeleteCellsAtColEnd = new Button();
            btn_AddCellsAtColEnd = new Button();
            btn_AddCellsAtColStart = new Button();
            btn_AddCellsAtColIndex = new Button();
            btn_AddColumnAtColIndex = new Button();
            group_AddColumns = new GroupBox();
            group_DeleteColumns = new GroupBox();
            group_DeleteColumnsBatch = new GroupBox();
            group_TestControls = new GroupBox();
            lbl_RowIndex = new Label();
            lbl_ColIndex = new Label();
            txt_RowIndex = new TextBox();
            group_Basic = new GroupBox();
            groupColors = new GroupBox();
            btn_AddItemsUntilColIndex = new Button();
            btn_AddCellsUntilColIndex = new Button();
            group_AddColumnsBatch = new GroupBox();
            btn_AddCellsAtRowIndex = new Button();
            btn_AddCellsAtRowEnd = new Button();
            btn_AddCellsAtRowStart = new Button();
            btn_DeleteCellsAtRowEnd = new Button();
            btn_DeleteCellsAtRowStart = new Button();
            btn_DeleteCellsAtRowIndex = new Button();
            groupDeleteRows = new GroupBox();
            groupAddRows = new GroupBox();
            btn_DeleteCellsFromRowIndex = new Button();
            btn_AddCellsUntilRowIndex = new Button();
            addRowsBatch = new GroupBox();
            groupDeleteRowsBatch = new GroupBox();
            groupCells = new GroupBox();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            group_AddColumns.SuspendLayout();
            group_DeleteColumns.SuspendLayout();
            group_DeleteColumnsBatch.SuspendLayout();
            group_TestControls.SuspendLayout();
            group_Basic.SuspendLayout();
            groupColors.SuspendLayout();
            group_AddColumnsBatch.SuspendLayout();
            groupDeleteRows.SuspendLayout();
            groupAddRows.SuspendLayout();
            addRowsBatch.SuspendLayout();
            groupDeleteRowsBatch.SuspendLayout();
            groupCells.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lv_Test
            // 
            lv_Test.Activation = ItemActivation.OneClick;
            lv_Test.ConfirmAfterCopied = true;
            lv_Test.Dock = DockStyle.Fill;
            lv_Test.FullRowSelect = true;
            lv_Test.GridLines = true;
            lv_Test.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv_Test.LabelEdit = true;
            lv_Test.Location = new Point(0, 0);
            lv_Test.menuEditEnable = false;
            lv_Test.Name = "lv_Test";
            lv_Test.OwnerDraw = true;
            lv_Test.Size = new Size(1593, 493);
            lv_Test.TabIndex = 0;
            lv_Test.UseCompatibleStateImageBehavior = false;
            lv_Test.View = View.Details;
            // 
            // btn_AddColumnsUntilColIndex
            // 
            btn_AddColumnsUntilColIndex.Location = new Point(211, 22);
            btn_AddColumnsUntilColIndex.Name = "btn_AddColumnsUntilColIndex";
            btn_AddColumnsUntilColIndex.Size = new Size(199, 23);
            btn_AddColumnsUntilColIndex.TabIndex = 1;
            btn_AddColumnsUntilColIndex.Text = "AddColumnsUntilColIndex";
            btn_AddColumnsUntilColIndex.UseVisualStyleBackColor = true;
            btn_AddColumnsUntilColIndex.Click += btn_AddColumnsUntilColIndex_Click;
            // 
            // btn_DeleteColumnsFromColIndex
            // 
            btn_DeleteColumnsFromColIndex.Location = new Point(211, 22);
            btn_DeleteColumnsFromColIndex.Name = "btn_DeleteColumnsFromColIndex";
            btn_DeleteColumnsFromColIndex.Size = new Size(199, 23);
            btn_DeleteColumnsFromColIndex.TabIndex = 2;
            btn_DeleteColumnsFromColIndex.Text = "DeleteColumnsFromColIndex";
            btn_DeleteColumnsFromColIndex.UseVisualStyleBackColor = true;
            btn_DeleteColumnsFromColIndex.Click += btn_DeleteColumnsFromColIndex_Click;
            // 
            // btn_addContent
            // 
            btn_addContent.Location = new Point(8, 81);
            btn_addContent.Name = "btn_addContent";
            btn_addContent.Size = new Size(199, 23);
            btn_addContent.TabIndex = 3;
            btn_addContent.Text = "AddContent";
            btn_addContent.UseVisualStyleBackColor = true;
            btn_addContent.Click += btn_addContent_Click;
            // 
            // btn_AddColumnAtColEnd
            // 
            btn_AddColumnAtColEnd.Location = new Point(211, 80);
            btn_AddColumnAtColEnd.Name = "btn_AddColumnAtColEnd";
            btn_AddColumnAtColEnd.Size = new Size(199, 23);
            btn_AddColumnAtColEnd.TabIndex = 4;
            btn_AddColumnAtColEnd.Text = "AddColumnAtColEnd";
            btn_AddColumnAtColEnd.UseVisualStyleBackColor = true;
            btn_AddColumnAtColEnd.Click += btn_AddColumnAtColEnd_Click;
            // 
            // btn_DeleteColumnAtColEnd
            // 
            btn_DeleteColumnAtColEnd.Location = new Point(211, 80);
            btn_DeleteColumnAtColEnd.Name = "btn_DeleteColumnAtColEnd";
            btn_DeleteColumnAtColEnd.Size = new Size(199, 23);
            btn_DeleteColumnAtColEnd.TabIndex = 5;
            btn_DeleteColumnAtColEnd.Text = "DeleteColumnAtColEnd";
            btn_DeleteColumnAtColEnd.UseVisualStyleBackColor = true;
            btn_DeleteColumnAtColEnd.Click += btn_DeleteColumnAtColEnd_Click;
            // 
            // btn_SetColumnTitleAtColIndex
            // 
            btn_SetColumnTitleAtColIndex.Location = new Point(8, 80);
            btn_SetColumnTitleAtColIndex.Name = "btn_SetColumnTitleAtColIndex";
            btn_SetColumnTitleAtColIndex.Size = new Size(199, 23);
            btn_SetColumnTitleAtColIndex.TabIndex = 6;
            btn_SetColumnTitleAtColIndex.Text = "SetColumnTitleAtColIndex";
            btn_SetColumnTitleAtColIndex.UseVisualStyleBackColor = true;
            btn_SetColumnTitleAtColIndex.Click += btn_SetColumnTitleAtColIndex_Click;
            // 
            // btn_AddColumnAtColStart
            // 
            btn_AddColumnAtColStart.Location = new Point(211, 51);
            btn_AddColumnAtColStart.Name = "btn_AddColumnAtColStart";
            btn_AddColumnAtColStart.Size = new Size(199, 23);
            btn_AddColumnAtColStart.TabIndex = 7;
            btn_AddColumnAtColStart.Text = "AddColumnAtColStart";
            btn_AddColumnAtColStart.UseVisualStyleBackColor = true;
            btn_AddColumnAtColStart.Click += btn_AddColumnAtColStart_Click;
            // 
            // btn_DeleteColumnAtColStart
            // 
            btn_DeleteColumnAtColStart.Location = new Point(211, 51);
            btn_DeleteColumnAtColStart.Name = "btn_DeleteColumnAtColStart";
            btn_DeleteColumnAtColStart.Size = new Size(199, 23);
            btn_DeleteColumnAtColStart.TabIndex = 8;
            btn_DeleteColumnAtColStart.Text = "DeleteColumnAtColStart";
            btn_DeleteColumnAtColStart.UseVisualStyleBackColor = true;
            btn_DeleteColumnAtColStart.Click += btn_DeleteColumnAtColStart_Click;
            // 
            // btn_UpdateAddCellAtIndexRowAtIndexCol
            // 
            btn_UpdateAddCellAtIndexRowAtIndexCol.ForeColor = Color.IndianRed;
            btn_UpdateAddCellAtIndexRowAtIndexCol.Location = new Point(6, 57);
            btn_UpdateAddCellAtIndexRowAtIndexCol.Name = "btn_UpdateAddCellAtIndexRowAtIndexCol";
            btn_UpdateAddCellAtIndexRowAtIndexCol.Size = new Size(199, 23);
            btn_UpdateAddCellAtIndexRowAtIndexCol.TabIndex = 9;
            btn_UpdateAddCellAtIndexRowAtIndexCol.Text = "UpdateAddCellAtIndexRowAtIndexCol";
            btn_UpdateAddCellAtIndexRowAtIndexCol.UseVisualStyleBackColor = true;
            btn_UpdateAddCellAtIndexRowAtIndexCol.Click += btn_UpdateAddCellAtIndexRowAtIndexCol_Click;
            // 
            // btn_DeleteItemsFromColIndex
            // 
            btn_DeleteItemsFromColIndex.Location = new Point(6, 21);
            btn_DeleteItemsFromColIndex.Name = "btn_DeleteItemsFromColIndex";
            btn_DeleteItemsFromColIndex.Size = new Size(199, 23);
            btn_DeleteItemsFromColIndex.TabIndex = 10;
            btn_DeleteItemsFromColIndex.Text = "DeleteItemsFromColIndex";
            btn_DeleteItemsFromColIndex.UseVisualStyleBackColor = true;
            btn_DeleteItemsFromColIndex.Click += btn_DeleteItemsFromColIndex_Click;
            // 
            // btn_DeleteItemsAtColIndex
            // 
            btn_DeleteItemsAtColIndex.Location = new Point(6, 22);
            btn_DeleteItemsAtColIndex.Name = "btn_DeleteItemsAtColIndex";
            btn_DeleteItemsAtColIndex.Size = new Size(199, 23);
            btn_DeleteItemsAtColIndex.TabIndex = 11;
            btn_DeleteItemsAtColIndex.Text = "DeleteItemsAtColIndex";
            btn_DeleteItemsAtColIndex.UseVisualStyleBackColor = true;
            btn_DeleteItemsAtColIndex.Click += btn_DeleteItemsAtColIndex_Click;
            // 
            // btn_UpdateCellAtRowIndexAtColIndex
            // 
            btn_UpdateCellAtRowIndexAtColIndex.Location = new Point(6, 28);
            btn_UpdateCellAtRowIndexAtColIndex.Name = "btn_UpdateCellAtRowIndexAtColIndex";
            btn_UpdateCellAtRowIndexAtColIndex.Size = new Size(199, 23);
            btn_UpdateCellAtRowIndexAtColIndex.TabIndex = 15;
            btn_UpdateCellAtRowIndexAtColIndex.Text = "UpdateCellAtRowIndexAtColIndex";
            btn_UpdateCellAtRowIndexAtColIndex.UseVisualStyleBackColor = true;
            btn_UpdateCellAtRowIndexAtColIndex.Click += btn_UpdateCellAtRowIndexAtColIndex_Click;
            // 
            // btn_UpdateWidthAtColIndex
            // 
            btn_UpdateWidthAtColIndex.Location = new Point(8, 51);
            btn_UpdateWidthAtColIndex.Name = "btn_UpdateWidthAtColIndex";
            btn_UpdateWidthAtColIndex.Size = new Size(199, 23);
            btn_UpdateWidthAtColIndex.TabIndex = 16;
            btn_UpdateWidthAtColIndex.Text = "UpdateWidthAtColIndex";
            btn_UpdateWidthAtColIndex.UseVisualStyleBackColor = true;
            btn_UpdateWidthAtColIndex.Click += btn_UpdateWidthAtColIndex_Click;
            // 
            // btn_UpdateWidthAll
            // 
            btn_UpdateWidthAll.Location = new Point(8, 22);
            btn_UpdateWidthAll.Name = "btn_UpdateWidthAll";
            btn_UpdateWidthAll.Size = new Size(199, 23);
            btn_UpdateWidthAll.TabIndex = 17;
            btn_UpdateWidthAll.Text = "UpdateWidthAll";
            btn_UpdateWidthAll.UseVisualStyleBackColor = true;
            btn_UpdateWidthAll.Click += btn_UpdateWidthAll_Click;
            // 
            // btn_CustomBackgroundAtIndexRowAtIndexCol
            // 
            btn_CustomBackgroundAtIndexRowAtIndexCol.Location = new Point(6, 59);
            btn_CustomBackgroundAtIndexRowAtIndexCol.Name = "btn_CustomBackgroundAtIndexRowAtIndexCol";
            btn_CustomBackgroundAtIndexRowAtIndexCol.Size = new Size(199, 23);
            btn_CustomBackgroundAtIndexRowAtIndexCol.TabIndex = 18;
            btn_CustomBackgroundAtIndexRowAtIndexCol.Text = "CustomBackgroundAtIndexRowAtIndexCol";
            btn_CustomBackgroundAtIndexRowAtIndexCol.UseVisualStyleBackColor = true;
            btn_CustomBackgroundAtIndexRowAtIndexCol.Click += btn_CustomBackgroundAtIndexRowAtIndexCol_Click;
            // 
            // btn_CustomFontAtIndexRowAtIndexCol
            // 
            btn_CustomFontAtIndexRowAtIndexCol.Location = new Point(6, 30);
            btn_CustomFontAtIndexRowAtIndexCol.Name = "btn_CustomFontAtIndexRowAtIndexCol";
            btn_CustomFontAtIndexRowAtIndexCol.Size = new Size(199, 23);
            btn_CustomFontAtIndexRowAtIndexCol.TabIndex = 19;
            btn_CustomFontAtIndexRowAtIndexCol.Text = "CustomFontAtIndexRowAtIndexCol";
            btn_CustomFontAtIndexRowAtIndexCol.UseVisualStyleBackColor = true;
            btn_CustomFontAtIndexRowAtIndexCol.Click += btn_CustomFontAtIndexRowAtIndexCol_Click;
            // 
            // btn_AddItemsAtColIndex
            // 
            btn_AddItemsAtColIndex.Location = new Point(6, 22);
            btn_AddItemsAtColIndex.Name = "btn_AddItemsAtColIndex";
            btn_AddItemsAtColIndex.Size = new Size(199, 23);
            btn_AddItemsAtColIndex.TabIndex = 20;
            btn_AddItemsAtColIndex.Text = "AddItemsAtColIndex";
            btn_AddItemsAtColIndex.UseVisualStyleBackColor = true;
            btn_AddItemsAtColIndex.Click += btn_AddItemsAtColIndex_Click;
            // 
            // btn_AddItemsAtColStart
            // 
            btn_AddItemsAtColStart.Location = new Point(6, 51);
            btn_AddItemsAtColStart.Name = "btn_AddItemsAtColStart";
            btn_AddItemsAtColStart.Size = new Size(199, 23);
            btn_AddItemsAtColStart.TabIndex = 21;
            btn_AddItemsAtColStart.Text = "AddItemsAtColStart";
            btn_AddItemsAtColStart.UseVisualStyleBackColor = true;
            btn_AddItemsAtColStart.Click += btn_AddItemAtColStart_Click;
            // 
            // btn_AddItemsAtColEnd
            // 
            btn_AddItemsAtColEnd.Location = new Point(6, 80);
            btn_AddItemsAtColEnd.Name = "btn_AddItemsAtColEnd";
            btn_AddItemsAtColEnd.Size = new Size(199, 23);
            btn_AddItemsAtColEnd.TabIndex = 22;
            btn_AddItemsAtColEnd.Text = "AddItemsAtColEnd";
            btn_AddItemsAtColEnd.UseVisualStyleBackColor = true;
            btn_AddItemsAtColEnd.Click += btn_AddItemsAtColEnd_Click;
            // 
            // btn_DeleteCellsFromColIndex
            // 
            btn_DeleteCellsFromColIndex.ForeColor = Color.ForestGreen;
            btn_DeleteCellsFromColIndex.Location = new Point(416, 22);
            btn_DeleteCellsFromColIndex.Name = "btn_DeleteCellsFromColIndex";
            btn_DeleteCellsFromColIndex.Size = new Size(199, 23);
            btn_DeleteCellsFromColIndex.TabIndex = 23;
            btn_DeleteCellsFromColIndex.Text = "DeleteCellsFromColIndex";
            btn_DeleteCellsFromColIndex.UseVisualStyleBackColor = true;
            btn_DeleteCellsFromColIndex.Click += btn_DeleteCellsFromColIndex_Click;
            // 
            // txt_ColIndex
            // 
            txt_ColIndex.Location = new Point(93, 22);
            txt_ColIndex.Name = "txt_ColIndex";
            txt_ColIndex.Size = new Size(112, 23);
            txt_ColIndex.TabIndex = 24;
            txt_ColIndex.Text = "0";
            // 
            // btn_DeleteItemsAtColStart
            // 
            btn_DeleteItemsAtColStart.Location = new Point(6, 51);
            btn_DeleteItemsAtColStart.Name = "btn_DeleteItemsAtColStart";
            btn_DeleteItemsAtColStart.Size = new Size(199, 23);
            btn_DeleteItemsAtColStart.TabIndex = 25;
            btn_DeleteItemsAtColStart.Text = "DeleteItemsAtColStart";
            btn_DeleteItemsAtColStart.UseVisualStyleBackColor = true;
            btn_DeleteItemsAtColStart.Click += btn_DeleteItemsAtColStart_Click;
            // 
            // btn_DeleteItemsAtColEnd
            // 
            btn_DeleteItemsAtColEnd.Location = new Point(6, 80);
            btn_DeleteItemsAtColEnd.Name = "btn_DeleteItemsAtColEnd";
            btn_DeleteItemsAtColEnd.Size = new Size(199, 23);
            btn_DeleteItemsAtColEnd.TabIndex = 26;
            btn_DeleteItemsAtColEnd.Text = "DeleteItemsAtColEnd";
            btn_DeleteItemsAtColEnd.UseVisualStyleBackColor = true;
            btn_DeleteItemsAtColEnd.Click += btn_DeleteItemsAtColEnd_Click;
            // 
            // btn_DeleteColumnAtColIndex
            // 
            btn_DeleteColumnAtColIndex.Location = new Point(211, 22);
            btn_DeleteColumnAtColIndex.Name = "btn_DeleteColumnAtColIndex";
            btn_DeleteColumnAtColIndex.Size = new Size(199, 23);
            btn_DeleteColumnAtColIndex.TabIndex = 27;
            btn_DeleteColumnAtColIndex.Text = "DeleteColumnAtColIndex";
            btn_DeleteColumnAtColIndex.UseVisualStyleBackColor = true;
            btn_DeleteColumnAtColIndex.Click += btn_DeleteColumnAtColIndex_Click;
            // 
            // btn_DeleteCellsAtColIndex
            // 
            btn_DeleteCellsAtColIndex.ForeColor = Color.ForestGreen;
            btn_DeleteCellsAtColIndex.Location = new Point(416, 22);
            btn_DeleteCellsAtColIndex.Name = "btn_DeleteCellsAtColIndex";
            btn_DeleteCellsAtColIndex.Size = new Size(199, 23);
            btn_DeleteCellsAtColIndex.TabIndex = 28;
            btn_DeleteCellsAtColIndex.Text = "DeleteCellsAtColIndex";
            btn_DeleteCellsAtColIndex.UseVisualStyleBackColor = true;
            btn_DeleteCellsAtColIndex.Click += btn_DeleteCellsAtColIndex_Click;
            // 
            // btn_DeleteCellsAtColStart
            // 
            btn_DeleteCellsAtColStart.ForeColor = Color.ForestGreen;
            btn_DeleteCellsAtColStart.Location = new Point(416, 51);
            btn_DeleteCellsAtColStart.Name = "btn_DeleteCellsAtColStart";
            btn_DeleteCellsAtColStart.Size = new Size(199, 23);
            btn_DeleteCellsAtColStart.TabIndex = 29;
            btn_DeleteCellsAtColStart.Text = "DeleteCellsAtColStart";
            btn_DeleteCellsAtColStart.UseVisualStyleBackColor = true;
            btn_DeleteCellsAtColStart.Click += btn_DeleteCellsAtColStart_Click;
            // 
            // btn_DeleteCellsAtColEnd
            // 
            btn_DeleteCellsAtColEnd.ForeColor = Color.ForestGreen;
            btn_DeleteCellsAtColEnd.Location = new Point(416, 80);
            btn_DeleteCellsAtColEnd.Name = "btn_DeleteCellsAtColEnd";
            btn_DeleteCellsAtColEnd.Size = new Size(199, 23);
            btn_DeleteCellsAtColEnd.TabIndex = 30;
            btn_DeleteCellsAtColEnd.Text = "DeleteCellsAtColEnd";
            btn_DeleteCellsAtColEnd.UseVisualStyleBackColor = true;
            btn_DeleteCellsAtColEnd.Click += btn_DeleteCellsAtColEnd_Click;
            // 
            // btn_AddCellsAtColEnd
            // 
            btn_AddCellsAtColEnd.ForeColor = Color.ForestGreen;
            btn_AddCellsAtColEnd.Location = new Point(416, 80);
            btn_AddCellsAtColEnd.Name = "btn_AddCellsAtColEnd";
            btn_AddCellsAtColEnd.Size = new Size(199, 23);
            btn_AddCellsAtColEnd.TabIndex = 33;
            btn_AddCellsAtColEnd.Text = "AddCellsAtColEnd";
            btn_AddCellsAtColEnd.UseVisualStyleBackColor = true;
            btn_AddCellsAtColEnd.Click += btn_AddCellsAtColEnd_Click;
            // 
            // btn_AddCellsAtColStart
            // 
            btn_AddCellsAtColStart.ForeColor = Color.ForestGreen;
            btn_AddCellsAtColStart.Location = new Point(416, 51);
            btn_AddCellsAtColStart.Name = "btn_AddCellsAtColStart";
            btn_AddCellsAtColStart.Size = new Size(199, 23);
            btn_AddCellsAtColStart.TabIndex = 32;
            btn_AddCellsAtColStart.Text = "AddCellsAtColStart";
            btn_AddCellsAtColStart.UseVisualStyleBackColor = true;
            btn_AddCellsAtColStart.Click += btn_AddCellsAtColStart_Click;
            // 
            // btn_AddCellsAtColIndex
            // 
            btn_AddCellsAtColIndex.ForeColor = Color.ForestGreen;
            btn_AddCellsAtColIndex.Location = new Point(416, 22);
            btn_AddCellsAtColIndex.Name = "btn_AddCellsAtColIndex";
            btn_AddCellsAtColIndex.Size = new Size(199, 23);
            btn_AddCellsAtColIndex.TabIndex = 31;
            btn_AddCellsAtColIndex.Text = "AddCellsAtColIndex";
            btn_AddCellsAtColIndex.UseVisualStyleBackColor = true;
            btn_AddCellsAtColIndex.Click += btn_AddCellsAtColIndex_Click;
            // 
            // btn_AddColumnAtColIndex
            // 
            btn_AddColumnAtColIndex.Location = new Point(211, 22);
            btn_AddColumnAtColIndex.Name = "btn_AddColumnAtColIndex";
            btn_AddColumnAtColIndex.Size = new Size(199, 23);
            btn_AddColumnAtColIndex.TabIndex = 34;
            btn_AddColumnAtColIndex.Text = "AddColumnAtColIndex";
            btn_AddColumnAtColIndex.UseVisualStyleBackColor = true;
            btn_AddColumnAtColIndex.Click += btn_AddColumnAtColIndex_Click;
            // 
            // group_AddColumns
            // 
            group_AddColumns.Controls.Add(btn_AddItemsAtColIndex);
            group_AddColumns.Controls.Add(btn_AddColumnAtColEnd);
            group_AddColumns.Controls.Add(btn_AddColumnAtColStart);
            group_AddColumns.Controls.Add(btn_AddColumnAtColIndex);
            group_AddColumns.Controls.Add(btn_AddItemsAtColStart);
            group_AddColumns.Controls.Add(btn_AddCellsAtColEnd);
            group_AddColumns.Controls.Add(btn_AddItemsAtColEnd);
            group_AddColumns.Controls.Add(btn_AddCellsAtColStart);
            group_AddColumns.Controls.Add(btn_AddCellsAtColIndex);
            group_AddColumns.Location = new Point(222, 3);
            group_AddColumns.Name = "group_AddColumns";
            group_AddColumns.Size = new Size(626, 116);
            group_AddColumns.TabIndex = 35;
            group_AddColumns.TabStop = false;
            group_AddColumns.Text = "Add Columns";
            // 
            // group_DeleteColumns
            // 
            group_DeleteColumns.Controls.Add(btn_DeleteItemsAtColIndex);
            group_DeleteColumns.Controls.Add(btn_DeleteColumnAtColEnd);
            group_DeleteColumns.Controls.Add(btn_DeleteColumnAtColStart);
            group_DeleteColumns.Controls.Add(btn_DeleteCellsAtColEnd);
            group_DeleteColumns.Controls.Add(btn_DeleteItemsAtColStart);
            group_DeleteColumns.Controls.Add(btn_DeleteCellsAtColStart);
            group_DeleteColumns.Controls.Add(btn_DeleteItemsAtColEnd);
            group_DeleteColumns.Controls.Add(btn_DeleteCellsAtColIndex);
            group_DeleteColumns.Controls.Add(btn_DeleteColumnAtColIndex);
            group_DeleteColumns.Location = new Point(222, 125);
            group_DeleteColumns.Name = "group_DeleteColumns";
            group_DeleteColumns.Size = new Size(626, 114);
            group_DeleteColumns.TabIndex = 36;
            group_DeleteColumns.TabStop = false;
            group_DeleteColumns.Text = "Delete Columns";
            // 
            // group_DeleteColumnsBatch
            // 
            group_DeleteColumnsBatch.Controls.Add(btn_DeleteCellsFromColIndex);
            group_DeleteColumnsBatch.Controls.Add(btn_DeleteColumnsFromColIndex);
            group_DeleteColumnsBatch.Controls.Add(btn_DeleteItemsFromColIndex);
            group_DeleteColumnsBatch.Location = new Point(222, 307);
            group_DeleteColumnsBatch.Name = "group_DeleteColumnsBatch";
            group_DeleteColumnsBatch.Size = new Size(626, 56);
            group_DeleteColumnsBatch.TabIndex = 37;
            group_DeleteColumnsBatch.TabStop = false;
            group_DeleteColumnsBatch.Text = "Delete Columns Batch";
            // 
            // group_TestControls
            // 
            group_TestControls.Controls.Add(lbl_RowIndex);
            group_TestControls.Controls.Add(lbl_ColIndex);
            group_TestControls.Controls.Add(txt_RowIndex);
            group_TestControls.Controls.Add(txt_ColIndex);
            group_TestControls.Controls.Add(btn_addContent);
            group_TestControls.Location = new Point(3, 3);
            group_TestControls.Name = "group_TestControls";
            group_TestControls.Size = new Size(213, 129);
            group_TestControls.TabIndex = 38;
            group_TestControls.TabStop = false;
            group_TestControls.Text = "Test Controls";
            // 
            // lbl_RowIndex
            // 
            lbl_RowIndex.AutoSize = true;
            lbl_RowIndex.Location = new Point(25, 55);
            lbl_RowIndex.Name = "lbl_RowIndex";
            lbl_RowIndex.Size = new Size(62, 15);
            lbl_RowIndex.TabIndex = 41;
            lbl_RowIndex.Text = "Row Index";
            // 
            // lbl_ColIndex
            // 
            lbl_ColIndex.AutoSize = true;
            lbl_ColIndex.Location = new Point(5, 26);
            lbl_ColIndex.Name = "lbl_ColIndex";
            lbl_ColIndex.Size = new Size(82, 15);
            lbl_ColIndex.TabIndex = 39;
            lbl_ColIndex.Text = "Column Index";
            // 
            // txt_RowIndex
            // 
            txt_RowIndex.Location = new Point(93, 52);
            txt_RowIndex.Name = "txt_RowIndex";
            txt_RowIndex.Size = new Size(112, 23);
            txt_RowIndex.TabIndex = 40;
            txt_RowIndex.Text = "0";
            // 
            // group_Basic
            // 
            group_Basic.Controls.Add(btn_UpdateWidthAll);
            group_Basic.Controls.Add(btn_SetColumnTitleAtColIndex);
            group_Basic.Controls.Add(btn_UpdateWidthAtColIndex);
            group_Basic.Location = new Point(3, 138);
            group_Basic.Name = "group_Basic";
            group_Basic.Size = new Size(213, 122);
            group_Basic.TabIndex = 39;
            group_Basic.TabStop = false;
            group_Basic.Text = "Basic Tasks";
            // 
            // groupColors
            // 
            groupColors.Controls.Add(btn_CustomBackgroundAtIndexRowAtIndexCol);
            groupColors.Controls.Add(btn_CustomFontAtIndexRowAtIndexCol);
            groupColors.Location = new Point(3, 267);
            groupColors.Name = "groupColors";
            groupColors.Size = new Size(213, 97);
            groupColors.TabIndex = 40;
            groupColors.TabStop = false;
            groupColors.Text = "Colors";
            // 
            // btn_AddItemsUntilColIndex
            // 
            btn_AddItemsUntilColIndex.Location = new Point(6, 22);
            btn_AddItemsUntilColIndex.Name = "btn_AddItemsUntilColIndex";
            btn_AddItemsUntilColIndex.Size = new Size(199, 23);
            btn_AddItemsUntilColIndex.TabIndex = 41;
            btn_AddItemsUntilColIndex.Text = "AddItemsUntilColIndex";
            btn_AddItemsUntilColIndex.UseVisualStyleBackColor = true;
            btn_AddItemsUntilColIndex.Click += btn_AddItemsUntilColIndex_Click;
            // 
            // btn_AddCellsUntilColIndex
            // 
            btn_AddCellsUntilColIndex.ForeColor = Color.ForestGreen;
            btn_AddCellsUntilColIndex.Location = new Point(416, 22);
            btn_AddCellsUntilColIndex.Name = "btn_AddCellsUntilColIndex";
            btn_AddCellsUntilColIndex.Size = new Size(199, 23);
            btn_AddCellsUntilColIndex.TabIndex = 42;
            btn_AddCellsUntilColIndex.Text = "AddCellsUntilColIndex";
            btn_AddCellsUntilColIndex.UseVisualStyleBackColor = true;
            btn_AddCellsUntilColIndex.Click += btn_AddCellsUntilColIndex_Click;
            // 
            // group_AddColumnsBatch
            // 
            group_AddColumnsBatch.Controls.Add(btn_AddItemsUntilColIndex);
            group_AddColumnsBatch.Controls.Add(btn_AddCellsUntilColIndex);
            group_AddColumnsBatch.Controls.Add(btn_AddColumnsUntilColIndex);
            group_AddColumnsBatch.Location = new Point(222, 245);
            group_AddColumnsBatch.Name = "group_AddColumnsBatch";
            group_AddColumnsBatch.Size = new Size(626, 56);
            group_AddColumnsBatch.TabIndex = 43;
            group_AddColumnsBatch.TabStop = false;
            group_AddColumnsBatch.Text = "Add Columns Batch";
            // 
            // btn_AddCellsAtRowIndex
            // 
            btn_AddCellsAtRowIndex.ForeColor = Color.DarkCyan;
            btn_AddCellsAtRowIndex.Location = new Point(6, 22);
            btn_AddCellsAtRowIndex.Name = "btn_AddCellsAtRowIndex";
            btn_AddCellsAtRowIndex.Size = new Size(199, 23);
            btn_AddCellsAtRowIndex.TabIndex = 44;
            btn_AddCellsAtRowIndex.Text = "AddCellsAtRowIndex";
            btn_AddCellsAtRowIndex.UseVisualStyleBackColor = true;
            btn_AddCellsAtRowIndex.Click += btn_AddCellsAtRowIndex_Click;
            // 
            // btn_AddCellsAtRowEnd
            // 
            btn_AddCellsAtRowEnd.ForeColor = Color.DarkCyan;
            btn_AddCellsAtRowEnd.Location = new Point(6, 80);
            btn_AddCellsAtRowEnd.Name = "btn_AddCellsAtRowEnd";
            btn_AddCellsAtRowEnd.Size = new Size(199, 23);
            btn_AddCellsAtRowEnd.TabIndex = 50;
            btn_AddCellsAtRowEnd.Text = "AddCellsAtRowEnd";
            btn_AddCellsAtRowEnd.UseVisualStyleBackColor = true;
            btn_AddCellsAtRowEnd.Click += btn_AddCellsAtRowEnd_Click;
            // 
            // btn_AddCellsAtRowStart
            // 
            btn_AddCellsAtRowStart.ForeColor = Color.DarkCyan;
            btn_AddCellsAtRowStart.Location = new Point(6, 51);
            btn_AddCellsAtRowStart.Name = "btn_AddCellsAtRowStart";
            btn_AddCellsAtRowStart.Size = new Size(199, 23);
            btn_AddCellsAtRowStart.TabIndex = 49;
            btn_AddCellsAtRowStart.Text = "AddCellsAtRowStart";
            btn_AddCellsAtRowStart.UseVisualStyleBackColor = true;
            btn_AddCellsAtRowStart.Click += btn_AddCellsAtRowStart_Click;
            // 
            // btn_DeleteCellsAtRowEnd
            // 
            btn_DeleteCellsAtRowEnd.ForeColor = Color.DarkCyan;
            btn_DeleteCellsAtRowEnd.Location = new Point(6, 80);
            btn_DeleteCellsAtRowEnd.Name = "btn_DeleteCellsAtRowEnd";
            btn_DeleteCellsAtRowEnd.Size = new Size(199, 23);
            btn_DeleteCellsAtRowEnd.TabIndex = 54;
            btn_DeleteCellsAtRowEnd.Text = "DeleteCellsAtRowEnd";
            btn_DeleteCellsAtRowEnd.UseVisualStyleBackColor = true;
            btn_DeleteCellsAtRowEnd.Click += btn_DeleteCellsAtRowEnd_Click;
            // 
            // btn_DeleteCellsAtRowStart
            // 
            btn_DeleteCellsAtRowStart.ForeColor = Color.DarkCyan;
            btn_DeleteCellsAtRowStart.Location = new Point(6, 51);
            btn_DeleteCellsAtRowStart.Name = "btn_DeleteCellsAtRowStart";
            btn_DeleteCellsAtRowStart.Size = new Size(199, 23);
            btn_DeleteCellsAtRowStart.TabIndex = 53;
            btn_DeleteCellsAtRowStart.Text = "DeleteCellsAtRowStart";
            btn_DeleteCellsAtRowStart.UseVisualStyleBackColor = true;
            btn_DeleteCellsAtRowStart.Click += btn_DeleteCellsAtRowStart_Click;
            // 
            // btn_DeleteCellsAtRowIndex
            // 
            btn_DeleteCellsAtRowIndex.ForeColor = Color.DarkCyan;
            btn_DeleteCellsAtRowIndex.Location = new Point(6, 22);
            btn_DeleteCellsAtRowIndex.Name = "btn_DeleteCellsAtRowIndex";
            btn_DeleteCellsAtRowIndex.Size = new Size(199, 23);
            btn_DeleteCellsAtRowIndex.TabIndex = 52;
            btn_DeleteCellsAtRowIndex.Text = "DeleteCellsAtRowIndex";
            btn_DeleteCellsAtRowIndex.UseVisualStyleBackColor = true;
            btn_DeleteCellsAtRowIndex.Click += btn_DeleteCellsAtRowIndex_Click;
            // 
            // groupDeleteRows
            // 
            groupDeleteRows.Controls.Add(btn_DeleteCellsAtRowIndex);
            groupDeleteRows.Controls.Add(btn_DeleteCellsAtRowEnd);
            groupDeleteRows.Controls.Add(btn_DeleteCellsAtRowStart);
            groupDeleteRows.Location = new Point(854, 125);
            groupDeleteRows.Name = "groupDeleteRows";
            groupDeleteRows.Size = new Size(223, 114);
            groupDeleteRows.TabIndex = 55;
            groupDeleteRows.TabStop = false;
            groupDeleteRows.Text = "Delete Rows";
            // 
            // groupAddRows
            // 
            groupAddRows.Controls.Add(btn_AddCellsAtRowIndex);
            groupAddRows.Controls.Add(btn_AddCellsAtRowStart);
            groupAddRows.Controls.Add(btn_AddCellsAtRowEnd);
            groupAddRows.Location = new Point(854, 3);
            groupAddRows.Name = "groupAddRows";
            groupAddRows.Size = new Size(223, 116);
            groupAddRows.TabIndex = 56;
            groupAddRows.TabStop = false;
            groupAddRows.Text = "Add Rows";
            // 
            // btn_DeleteCellsFromRowIndex
            // 
            btn_DeleteCellsFromRowIndex.ForeColor = Color.DarkCyan;
            btn_DeleteCellsFromRowIndex.Location = new Point(6, 21);
            btn_DeleteCellsFromRowIndex.Name = "btn_DeleteCellsFromRowIndex";
            btn_DeleteCellsFromRowIndex.Size = new Size(199, 23);
            btn_DeleteCellsFromRowIndex.TabIndex = 58;
            btn_DeleteCellsFromRowIndex.Text = "DeleteCellsFromRowIndex";
            btn_DeleteCellsFromRowIndex.UseVisualStyleBackColor = true;
            btn_DeleteCellsFromRowIndex.Click += btn_DeleteCellsFromRowIndex_Click;
            // 
            // btn_AddCellsUntilRowIndex
            // 
            btn_AddCellsUntilRowIndex.ForeColor = Color.DarkCyan;
            btn_AddCellsUntilRowIndex.Location = new Point(6, 22);
            btn_AddCellsUntilRowIndex.Name = "btn_AddCellsUntilRowIndex";
            btn_AddCellsUntilRowIndex.Size = new Size(199, 23);
            btn_AddCellsUntilRowIndex.TabIndex = 57;
            btn_AddCellsUntilRowIndex.Text = "AddCellsUntilRowIndex";
            btn_AddCellsUntilRowIndex.UseVisualStyleBackColor = true;
            btn_AddCellsUntilRowIndex.Click += btn_AddCellsUntilRowIndex_Click;
            // 
            // addRowsBatch
            // 
            addRowsBatch.Controls.Add(btn_AddCellsUntilRowIndex);
            addRowsBatch.Location = new Point(854, 245);
            addRowsBatch.Name = "addRowsBatch";
            addRowsBatch.Size = new Size(223, 56);
            addRowsBatch.TabIndex = 59;
            addRowsBatch.TabStop = false;
            addRowsBatch.Text = "Add Rows Batch";
            // 
            // groupDeleteRowsBatch
            // 
            groupDeleteRowsBatch.Controls.Add(btn_DeleteCellsFromRowIndex);
            groupDeleteRowsBatch.Location = new Point(854, 307);
            groupDeleteRowsBatch.Name = "groupDeleteRowsBatch";
            groupDeleteRowsBatch.Size = new Size(223, 57);
            groupDeleteRowsBatch.TabIndex = 60;
            groupDeleteRowsBatch.TabStop = false;
            groupDeleteRowsBatch.Text = "Delete Rows Batch";
            // 
            // groupCells
            // 
            groupCells.Controls.Add(btn_UpdateAddCellAtIndexRowAtIndexCol);
            groupCells.Controls.Add(btn_UpdateCellAtRowIndexAtColIndex);
            groupCells.Location = new Point(3, 370);
            groupCells.Name = "groupCells";
            groupCells.Size = new Size(213, 95);
            groupCells.TabIndex = 61;
            groupCells.TabStop = false;
            groupCells.Text = "Cells";
            // 
            // panel1
            // 
            panel1.Controls.Add(group_TestControls);
            panel1.Controls.Add(groupCells);
            panel1.Controls.Add(group_AddColumns);
            panel1.Controls.Add(groupDeleteRowsBatch);
            panel1.Controls.Add(group_DeleteColumns);
            panel1.Controls.Add(addRowsBatch);
            panel1.Controls.Add(group_DeleteColumnsBatch);
            panel1.Controls.Add(groupAddRows);
            panel1.Controls.Add(group_Basic);
            panel1.Controls.Add(groupDeleteRows);
            panel1.Controls.Add(groupColors);
            panel1.Controls.Add(group_AddColumnsBatch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1593, 489);
            panel1.TabIndex = 62;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lv_Test);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1593, 986);
            splitContainer1.SplitterDistance = 493;
            splitContainer1.TabIndex = 63;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1593, 986);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "List View Extended Demo";
            group_AddColumns.ResumeLayout(false);
            group_DeleteColumns.ResumeLayout(false);
            group_DeleteColumnsBatch.ResumeLayout(false);
            group_TestControls.ResumeLayout(false);
            group_TestControls.PerformLayout();
            group_Basic.ResumeLayout(false);
            groupColors.ResumeLayout(false);
            group_AddColumnsBatch.ResumeLayout(false);
            groupDeleteRows.ResumeLayout(false);
            groupAddRows.ResumeLayout(false);
            addRowsBatch.ResumeLayout(false);
            groupDeleteRowsBatch.ResumeLayout(false);
            groupCells.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private glitcher.core.Controls.ListViewEx lv_Test;
        private Button btn_AddColumnsUntilColIndex;
        private Button btn_DeleteColumnsFromColIndex;
        private Button btn_addContent;
        private Button btn_SetColumnTitleAtColIndex;
        private Button btn_AddColumnAtColStart;
        private Button btn_DeleteColumnAtColStart;
        private Button btn_UpdateAddCellAtIndexRowAtIndexCol;
        private Button btn_AddColumnAtColEnd;
        private Button btn_DeleteColumnAtColEnd;
        private Button btn_DeleteItemsFromColIndex;
        private Button btn_DeleteItemsAtColIndex;
        private Button btn_UpdateCellAtRowIndexAtColIndex;
        private Button btn_UpdateWidthAtColIndex;
        private Button btn_UpdateWidthAll;
        private Button btn_DeleteCellsFromColIndex;
        private Button btn_AddColumnAtColIndex;
        private Button btn_CustomBackgroundAtIndexRowAtIndexCol;
        private Button btn_CustomFontAtIndexRowAtIndexCol;
        private Button btn_AddItemsAtColIndex;
        private Button btn_AddItemsAtColStart;
        private Button btn_AddItemsAtColEnd;
        private TextBox txt_ColIndex;
        private Button btn_DeleteItemsAtColStart;
        private Button btn_DeleteItemsAtColEnd;
        private Button btn_DeleteColumnAtColIndex;
        private Button btn_DeleteCellsAtColIndex;
        private Button btn_DeleteCellsAtColStart;
        private Button btn_DeleteCellsAtColEnd;
        private Button btn_AddCellsAtColEnd;
        private Button btn_AddCellsAtColStart;
        private Button btn_AddCellsAtColIndex;
        private GroupBox group_AddColumns;
        private GroupBox group_DeleteColumns;
        private GroupBox group_DeleteColumnsBatch;
        private GroupBox group_TestControls;
        private Label lbl_RowIndex;
        private Label lbl_ColIndex;
        private TextBox txt_RowIndex;
        private GroupBox group_Basic;
        private GroupBox groupColors;
        private Button btn_AddItemsUntilColIndex;
        private Button btn_AddCellsUntilColIndex;
        private GroupBox group_AddColumnsBatch;
        private Button btn_AddCellsAtRowIndex;
        private Button btn_AddCellsAtRowEnd;
        private Button btn_AddCellsAtRowStart;
        private Button btn_DeleteCellsAtRowEnd;
        private Button btn_DeleteCellsAtRowStart;
        private Button btn_DeleteCellsAtRowIndex;
        private GroupBox groupDeleteRows;
        private GroupBox groupAddRows;
        private Button btn_DeleteCellsFromRowIndex;
        private Button btn_AddCellsUntilRowIndex;
        private GroupBox addRowsBatch;
        private GroupBox groupDeleteRowsBatch;
        private GroupBox groupCells;
        private Panel panel1;
        private SplitContainer splitContainer1;
    }
}