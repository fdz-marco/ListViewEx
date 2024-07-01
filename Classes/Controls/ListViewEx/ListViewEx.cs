using glitcher.core;
using System.Runtime.InteropServices;
using ListView = System.Windows.Forms.ListView;

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

        /// <summary>
        /// Creates a List View Extended
        /// </summary>
        public ListViewEx() : base()
        {
            // Activate double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;

            //Enable the OnNotifyMessage event so we get a chance to filter out 
            //Windows messages before they get to the form's WndProc
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
            this.UpdateStyles();

            // Standard Configuration
            this.OwnerDraw = true;
            this.AllowColumnReorder = false;
            this.AllowDrop = false;
            this.MultiSelect = true;
            this.FullRowSelect = true;
            this.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.HoverSelection = false;
            this.View = View.Details;
            this.Scrollable = true;
            this.Activation = ItemActivation.OneClick;
            this.LabelEdit = false;
            this.GridLines = true;

            this.showHover = true;
      
            // Initialize Context Menu
            this.InitContextMenu();
            this.InitEditors();
        }
    }
}