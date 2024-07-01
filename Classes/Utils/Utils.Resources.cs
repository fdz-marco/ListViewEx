using System.Reflection;

namespace glitcher.core
{
    /// <summary>
    /// (Class: Static~Global) **Utilities - Resources**<br/><br/>
    /// **Important**<br/>
    /// To add complete project folder as embedded resources, 
    /// please add the folder as embedded resource in the *.csproj definition:<br/>
    /// <code>&lt;ItemGroup&gt; &lt;EmbeddedResource Include = "Resources\*"&gt; &lt;ItemGroup&gt;</code>
    /// </summary>
    /// <remarks>
    /// Author: Marco Fernandez (marcofdz.com / glitcher.dev)<br/>
    /// Last modified: 2024.06.19 - June 19, 2024
    /// </remarks>
    public static partial class Utils
    {

        /// <summary>
        /// Get Image From Resource
        /// </summary>
        /// <param name="path">Path of Resource</param>
        /// <returns>(Image)</returns>
        public static Image GetImageResource(string path)
        {
            // Get Assembly Resources
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<string> resourceNames = new List<string>(assembly.GetManifestResourceNames());
            // Search Resource
            string _path = path.TrimStart('/').TrimEnd('/').Replace(@"//", "/");
            _path = _path.Replace(@"/", ".");
            _path = resourceNames.FirstOrDefault(r => r.Contains(_path), "");
            // Return Found Resource or Default Image
            if (!string.IsNullOrEmpty(_path))
            {
                Stream stream = assembly.GetManifestResourceStream(_path);
                return System.Drawing.Image.FromStream(stream);
            }
            return System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath).ToBitmap();
        }

        /// <summary>
        /// Get Icon From Resource
        /// </summary>
        /// <param name="path">Path of Resource</param>
        /// <returns>(Icon)</returns>
        public static Icon GetIconResource(string path)
        {
            // Get Assembly Resources
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<string> resourceNames = new List<string>(assembly.GetManifestResourceNames());
            // Search Resource
            string _path = path.TrimStart('/').TrimEnd('/').Replace(@"//", "/");
            _path = _path.Replace(@"/", ".");
            _path = resourceNames.FirstOrDefault(r => r.Contains(_path), "");
            // Return Found Resource or Default Image
            if (!string.IsNullOrEmpty(_path))
            {
                Stream stream = assembly.GetManifestResourceStream(_path);
                return Icon.FromHandle(new Bitmap(stream).GetHicon());
            }
            return System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
    }
}
