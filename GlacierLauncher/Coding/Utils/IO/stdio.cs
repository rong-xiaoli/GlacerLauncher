using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace GlacierLauncher.Coding.Utils.IO
{
    public class StdIO
    {
        public static class Static
        {
            public static class In
            {
                /// <summary>
                /// Read the whole file. 
                /// </summary>
                /// <param name="fileName">File name, include the absolute path. </param>
                /// <returns>Rile content. </returns>
                public static string ReadFile(string fileName)
                {
                    return File.ReadAllText(fileName);
                }
            }
            public static class Out
            {
                public static void WriteFile(object o)
                {

                }
            }
        }
        public class Dynamic
        {

        }
        
    }
}
