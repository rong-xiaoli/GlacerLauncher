using System.Diagnostics;
namespace GlacierLauncher.Coding.Utils.IO
{
    public static class JavaRelated
    {
        /// <summary>
        /// Judge if Java exists. 
        /// </summary>
        /// <param name="isJavax64">Out param. False if Java is 64-Bit, true if Java is 32-Bit. </param>
        /// <returns>True if exist. </returns>
        public static bool isJavaExist(out bool isJavax64)
        {
            Process javaVerifyProcess = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    Arguments = "-version",
                    CreateNoWindow = true,
                    FileName = "java",
                    RedirectStandardError = true,
                    UseShellExecute = false,
                },
            };
            //Verify java. 
            javaVerifyProcess.Start();
            string jvReturnString = javaVerifyProcess.StandardError.ReadToEnd();
            if (!jvReturnString.Contains("64-Bit"))
            {
                isJavax64 = false;
            }
            else
            {
                isJavax64 = true;
            }
            return jvReturnString.Contains("java version");
        }
    }
}
