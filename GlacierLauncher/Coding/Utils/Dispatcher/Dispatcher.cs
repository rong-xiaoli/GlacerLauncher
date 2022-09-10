using System;

using System.Windows.Threading;

namespace GlacierLauncher.Coding.Utils
{
    /// <summary>
    /// Dispatcher. 
    /// </summary>
    public static class DispatcherHelper
    {
        public static Dispatcher dispatcher
        {
            get;
            private set;
        }
        public static void CheckBeginInvokeOnUI(Action action)
        {
            if (dispatcher.CheckAccess())
            {
                action();
            }
            else
            {
                dispatcher.Invoke(action);
            }
        }
        public static void Initialize()
        {
            if (dispatcher != null)
            {
                return;
            }

#if SILVERLIGHT
			dispatcher = Deployment.Current.Dispatcher;
#else
            dispatcher = Dispatcher.CurrentDispatcher;
#endif
        }
    }
}
