namespace glitcher.core.Controls
{
    /// <summary>
    /// (Class: Control) ListView Extended - SubItem Settings<br/>
    /// </summary>
    /// <remarks>
    /// Author: Marco Fernandez (marcofdz.com / glitcher.dev)<br/>
    /// Last modified: 2024.06.26 - June 26, 2024
    /// </remarks>
    public class ListViewExSubItemSettings
    {
        public ListViewExDataType dataType { get; set;}

        public string[] options { get; set;}

        public ListViewExSubItemSettings(ListViewExDataType dataType)
        { 
            this.dataType = dataType;
        }
    }
}
