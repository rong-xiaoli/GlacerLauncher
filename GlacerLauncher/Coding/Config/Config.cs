using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

/// <summary>
/// JSON Configs. 
/// </summary>
namespace GlacierLauncher.Coding.Config
{
    /// <summary>
    /// JSON converter 
    /// </summary>
    public static class JSONConverter
    {
        /// <summary>
        /// Convert an object to JSON string. 
        /// </summary>
        /// <param name="convertClass">Converting class. </param>
        /// <returns>JSON string. </returns>
        public static string ClassToJSON(object convertClass)
        {
            return JsonConvert.SerializeObject(convertClass);
        }
    }
    /// <summary>
    /// Launcher config JSON class. 
    /// </summary>
    public class LauncherConfig
    {
        /// <summary>
        /// Java path. 
        /// </summary>
        public string JavaPath { get; set; }
    }
}
