using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.IO;

namespace OracleBackup.Tool
{
    public class SQLHelper
    {
        public static string GetConnectString(Model.BackupItem item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" DATA SOURCE=");
            sb.Append("  (DESCRIPTION =");
            sb.Append("   (ADDRESS = (PROTOCOL = TCP)(HOST = " + item.ServerIP + ")(PORT = " + item.ServerPort + "))");
            sb.Append("   (CONNECT_DATA =");
            sb.Append("      (SERVER = DEDICATED)");
            sb.Append("      (SERVICE_NAME = " + item.ServerName + ")");
            sb.Append("    )");
            sb.Append("   );PERSIST SECURITY INFO=True;USER ID=" + item.UserID + ";Password=" + item.UserPwd);
            return sb.ToString();
        }

        public static bool CheckConnection(Model.BackupItem item,ref string log)
        {
            try
            {
                OracleConnection conn = new OracleConnection(SQLHelper.GetConnectString(item));
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ee)
            {
                log += "连接数据库异常：" + ee.Message + "\r\n";
                return false;
            }
            return false;
        }

        public static DataTable GetSQLTable(Model.BackupItem item, ref string log)
        {
            DataTable SQLCollection = new DataTable();
            try
            {
                //选择空表，准备分配空间
                using (OracleConnection conn = new OracleConnection(SQLHelper.GetConnectString(item)))
                {
                    string sql = "select 'alter table '||table_name||' allocate extent'  from user_tables where num_rows=0";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    //大容量数据，可以进行修改，使用DataSet和DataAdapter
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    SQLCollection = ds.Tables[0];
                }
                return SQLCollection;
            }
            catch (Exception ee)
            {
                log += "获取SQL异常：" + ee.Message + "\r\n";  
            }
            return null;
        }


        public static bool ExeSQLTable(DataTable SQLCollection, Model.BackupItem item, ref string log)
        {
            try
            {
                string content="";
                //如果存在空表，那么就执行分配的语句
                if (SQLCollection.Rows.Count > 0 && SQLCollection != null)
                {
                    log += "\r\n";
                    log += "Server IP:" + item.ServerIP + ":" + item.ServerPort + "   UserID:" + item.UserID + "\r\n";
                    log += "开始执行对空表的内存分配\r\n";
                    foreach (DataRow dr in SQLCollection.Rows)
                    {
                        string sql = dr[0].ToString();
                        //WriteLog();
                        //开始执行
                        try
                        {
                            using (OracleConnection conn = new OracleConnection(SQLHelper.GetConnectString(item)))
                            {
                                conn.Open();

                                OracleCommand cmd = new OracleCommand(sql, conn);
                                cmd.CommandType = CommandType.Text;
                                int i = cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                            log += "成功执行：" + sql + "\r\n";
                        }
                        catch
                        {
                            //如果发生错误，就继续执行
                            log += "失败执行：" + sql + "\r\n";
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    log += "\r\n";
                    log += "【 " + item.UserID + " 】用户:不包含任何数据\r\n";
                    return false;
                }
            }
            catch (Exception ee)
            {
                log += "执行SQL异常：" + ee.Message + "\r\n";
            }
            return false;
        }


        public static void ExeBackup(Model.BackupItem backupItem, ref string log)
        {
            try
            {
                //新建当天的备份文件夹
                string folderName = DateTime.Now.ToString("yyyy-MM-dd");
                string folderPath = backupItem.BackupPath + "\\"+folderName;
                //如果不存在就不创建
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                //拼凑保存的文件名
                //处理日志文件路径
                string backupPath = folderPath + "\\" + GetBackupFileName(backupItem.TableSpace, "dmp");
                string logPath = folderPath + "\\" + GetBackupFileName(backupItem.TableSpace, "log");

                //备份数据库脚本
                StringBuilder sb = new StringBuilder();
                sb.Append(" exp " + backupItem.UserID + "/" + backupItem.UserPwd + "@" + backupItem.ServerName);
                sb.Append(" file=" + backupPath);
                sb.Append(" consistent=y direct=y ");
                sb.Append(" log=" + logPath);

                Tools.ConsoleOperation.Execute(sb.ToString(), 2000);
                log += "备份成功：" + backupItem.ServerName + "的备份文件存于" + backupItem.BackupPath + "\r\n";
            }
            catch (Exception ee)
            {
                log += "执行备份异常：" + ee.Message + "\r\n";
            }
        }


        private static string GetBackupFileName(string filename,string filetype)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            string datePart = year.ToString() + month.ToString() + day.ToString();
            string fileName = filename + "_" + datePart + "." + filetype;
            return fileName;
        }
    }
}
