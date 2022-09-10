using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Threading;

using GlacierLauncher;
using GlacierLauncher.Coding;
using GlacierLauncher.Coding.Utils;
using GlacierLauncher.Coding.GlobalVars;
using GlacierLauncher.Coding.Utils.IO;
namespace GlacierLauncher
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dispatcher GetMainWindow()
        {
            return Dispatcher;
        }
        public DynamicVars GlobalDynamicVars;
        public MainWindow()
        {
            InitializeComponent();
            
            //Initialize MainWindow dispatcher.
            DispatcherHelper.Initialize();

            //Initialize Dynamic variables. 
            GlobalDynamicVars = new DynamicVars();
            StaticVars.SV_MainWindow = this;
            //Initialize region & resources. 
            StaticVars.SV_CurrentRegion = Thread.CurrentThread.CurrentCulture.LCID;
            switch (StaticVars.SV_CurrentRegion)
            {
                case 2052:
                    GlobalDynamicVars.DV_MainWindowResourceManager = Properties.Resources_zh_CN.ResourceManager;
                    break;
                case 10250:
                default:
                    GlobalDynamicVars.DV_MainWindowResourceManager = Properties.Resources_en_US.ResourceManager;
                    break;
            }
            
            //Judge if java exists. 
            if (!JavaRelated.isJavaExist(out StaticVars.SV_IsJava64Bit))
            {
                System.Windows.Forms.MessageBox.Show(GlobalDynamicVars.DV_MainWindowResourceManager.GetString("Mbox_JavaNotInstalledText"));
                App.Current.Shutdown(1);
            }

            //Ready to read the config. 
        }
        /// <summary>
        /// Minimize button clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowMinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowForm.WindowState = WindowState.Minimized;
        }
        /// <summary>
        /// Close button clicked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowCloseButton_Click(object sender, RoutedEventArgs e)
        {
            //Todo: Finish this method. 
            //Judge if server is running. 

        }
        /// <summary>
        /// Move the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindowTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
