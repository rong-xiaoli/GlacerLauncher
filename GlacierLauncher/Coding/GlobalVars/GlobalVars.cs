using System;
using System.Resources;

using GlacierLauncher.Coding.Utils;

namespace GlacierLauncher.Coding.GlobalVars
{
    /// <summary>
    /// Dynamic variables. 
    /// </summary>
    public class DynamicVars
    {
        private ResourceManager mainWindowResourceManager;
        
        public ResourceManager DV_MainWindowResourceManager
        {
            get
            {
                if (mainWindowResourceManager == null)
                {
                    throw new NullReferenceException("DV_MainWindowResourceManager is not initialized. ");
                }
                return mainWindowResourceManager;
            }
            set
            {
                mainWindowResourceManager = value;
            }
        }
    }
    /// <summary>
    /// Static variables. 
    /// </summary>
    public static class StaticVars
    {
        public static int SV_CurrentRegion = 2052;
        public static bool SV_IsJava64Bit = false;
        public static MainWindow SV_MainWindow;
    }
    /// <summary>
    /// Enum class. 
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// Launcher language. 
        /// </summary>
        public enum Language
        {
            en_US = 10250,
            zh_CN = 2052,
        }
    }
}
