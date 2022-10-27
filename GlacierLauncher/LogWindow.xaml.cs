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
using System.Windows.Shapes;

using System.Diagnostics;
using System.Threading;
using System.Windows.Threading;

namespace GlacierLauncher
{
    /// <summary>
    /// LogWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LogWindow : Window
    {
        public Process ServerProcess;
        public string JavaPath;
        public LogWindow(string javaPath)
        {
            InitializeComponent();
            JavaPath = javaPath;
            ServerProcess = new Process()
            {
                StartInfo = new ProcessStartInfo(JavaPath),
            };
        }
    }
}
