using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//调用控制台
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace OracleBackup.Tools
{
    public class ConsoleOperation
    {
        /// <summary>
        /// 启动控制台
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        /// <summary>
        /// 释放控制台
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();


        /// <summary>
        /// 打开控制台，执行DOS命令
        /// </summary>
        /// <param name="command">DOS命令</param>
        /// <param name="waitSecond"> 关闭时间</param>
        /// <returns></returns>
        public static string Execute(string command, int waitSecond)
        {
            //输出字符串
            string output = "";
            //如果DOS命令不为空
            if (!string.IsNullOrEmpty(command))
            {
                //创建一个进程
                Process process = new Process();
                //启动进程的一些信息
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //设定需要执行的命令  
                startInfo.FileName = "cmd.exe";
                //“/C”表示执行完命令后马上退出 
                startInfo.Arguments = "/C " + command; 
                //使用系统外壳程序启动  
                startInfo.UseShellExecute = false;
                //不重定向输入  
                startInfo.RedirectStandardInput = true;
                //重定向输出  
                startInfo.RedirectStandardOutput = true;
                //startInfo.RedirectStandardError = true;
                //不创建窗口  
                startInfo.CreateNoWindow = true;
                process.StartInfo = startInfo;


                try
                {
                    //开始进程  
                    if (process.Start())
                    {
                        if (waitSecond == 0)
                        {
                            //这里无限等待进程结束  
                            process.WaitForExit();
                        }
                        else
                        {
                            //等待进程结束，等待时间为指定的毫秒  
                            process.WaitForExit(waitSecond); 
                        }
                        //读取进程的输出  
                        output = process.StandardOutput.ReadToEnd();
                        
                    }

                }
                catch
                {
                 
                }
                finally 
                {
                    if (process != null)
                        process.Close();
                }
            }

            return output;
        }
    }
}
