using System;
using System.Threading;

using GlacierLauncher;
using GlacierLauncher.Coding.Utils;
using GlacierLauncher.Coding.GlobalVars;
namespace GlacierLauncher.Coding.UI
{
    /// <summary>
    /// Refresh method of MainWindow. 
    /// </summary>
    public class MainWindowUI
    {
        /// <summary>
        /// Refresh MainWindow language. 
        /// </summary>
        public static void RefreshLanguage()
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                StaticVars.SV_MainWindow.LauncherInfoTag.Content = StaticVars.SV_MainWindow.GlobalDynamicVars.DV_MainWindowResourceManager.GetString("LauncherInfoTag");
                StaticVars.SV_MainWindow.JavaPathLabel.Content = StaticVars.SV_MainWindow.GlobalDynamicVars.DV_MainWindowResourceManager.GetString("JavaPathLabel");
                StaticVars.SV_MainWindow.MainWindowTitle.Content = StaticVars.SV_MainWindow.GlobalDynamicVars.DV_MainWindowResourceManager.GetString("MainWindowTitle");
                StaticVars.SV_MainWindow.ServerInfoTab.Content = StaticVars.SV_MainWindow.GlobalDynamicVars.DV_MainWindowResourceManager.GetString("ServerInfoTab");
            });
        }
    }
}
