using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace ShutdownCountDown
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        /// <summary>
        /// Ture=Restart,False=Shutdown
        /// </summary>
        /// <param name="RestartOrShutdown"></param>
        public static void Shutdown(bool RestartOrShutdown)
        {
            if (RestartOrShutdown == false)
            {
                Process p = new Process();//实例化一个独立进程
                p.StartInfo.FileName = "cmd.exe";//进程打开的文件为Cmd
                p.StartInfo.UseShellExecute = false;//是否启动系统外壳选否
                p.StartInfo.RedirectStandardInput = true;//这是是否从StandardInput输入
                p.StartInfo.CreateNoWindow = true;//这里是启动程序是否显示窗体
                p.Start();//启动
                p.StandardInput.WriteLine("shutdown -s -t 0");//运行关机命令shutdown (-s)是关机 (-t)是延迟的时间 这里用秒计算 10就是10秒后关机
                p.StandardInput.WriteLine("exit");//退出cmd 此非原创，来源于网络，希望您满意，谢谢！
            }
            else
            {
                Process p = new Process();//实例化一个独立进程
                p.StartInfo.FileName = "cmd.exe";//进程打开的文件为Cmd
                p.StartInfo.UseShellExecute = false;//是否启动系统外壳选否
                p.StartInfo.RedirectStandardInput = true;//这是是否从StandardInput输入
                p.StartInfo.CreateNoWindow = true;//这里是启动程序是否显示窗体
                p.Start();//启动
                p.StandardInput.WriteLine("shutdown -r -t 0");//运行关机命令shutdown (-s)是关机 (-t)是延迟的时间 这里用秒计算 10就是10秒后关机
                p.StandardInput.WriteLine("exit");//退出cmd 此非原创，来源于网络，希望您满意，谢谢！
            }
        }
    }
}
