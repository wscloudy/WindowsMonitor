using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace WindowsMonitor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FormMain());
            //return;

            if (IsAdministrator)
            {
                Application.Run(new FormMain());
            }
            else // 用管理员用户运行 
            {
                try
                {
                    System.Diagnostics.ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = Application.ExecutablePath;
                    startInfo.Verb = "runas";
                    startInfo.WorkingDirectory = Environment.CurrentDirectory;
                    startInfo.UseShellExecute = true;
                    System.Diagnostics.Process.Start(startInfo);
                    System.Windows.Forms.Application.Exit();
                }
                catch { }
            }
        }

        public static bool IsAdministrator =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ?
            new WindowsPrincipal(WindowsIdentity.GetCurrent())
                .IsInRole(WindowsBuiltInRole.Administrator) :
            Mono.Unix.Native.Syscall.geteuid() == 0;
    }
}