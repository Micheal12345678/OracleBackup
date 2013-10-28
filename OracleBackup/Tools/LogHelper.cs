using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OracleBackup.Tool
{
    public static class LogHelper
    {
        public static void WriteLog(string strValue,string content)
        {
            strValue += content + "\r\n";
        }


        public static void saveLog(string fileName,string content)
        {
            //设置好日志路径
            string logPath = System.AppDomain.CurrentDomain.BaseDirectory + "Log";
            string LogFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "Log\\" + fileName;
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
            System.IO.StreamWriter sw = new System.IO.StreamWriter(LogFilePath, false, System.Text.Encoding.GetEncoding("utf-8"));
            try
            {
                sw.Write(content);
                sw.Flush();
            }
            finally
            {
                if (sw != null) sw.Close();
            }

        }


        public static void readLog()
        { 
            System.IO.FileInfo fi = new FileInfo(@"c:\test.text");
            StreamReader sr = fi.OpenText();       
            string s1 = sr.ReadToEnd(); //全读出来
            //或者一行一行的读。
            string strLine = string.Empty;
            while ((strLine = sr.ReadLine()) != null)
            {
              //strLine 就是一行，
            }
        }
    }
}
