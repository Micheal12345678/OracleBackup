using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OracleBackup.Model;
using System.Data.OracleClient;
using OracleBackup.Tool;
using OracleBackup.Tools;
using System.IO;

namespace OracleBackup
{
    public partial class frmBackupLog : Form
    {
        public frmBackupLog()
        {
            InitializeComponent();
        }

        private frmBackupAdd frmParent = new frmBackupAdd();
        private List<BackupItem> backupList;
        public frmBackupLog(List<BackupItem> list)
        {
            InitializeComponent();
            this.backupList = list;
        }


        private void frmBackupLog_Shown(object sender, EventArgs e)
        {
            //首先清理过期的文件
            DataTable dtClearFile = LoadDatasorce();
            for (int i = 0; i < dtClearFile.Rows.Count; i++)
            {
                string strFilePath = dtClearFile.Rows[i]["BackupPath"].ToString();
                int iStoreDay = Convert.ToInt32(dtClearFile.Rows[i]["BackupDay"].ToString());

                //查看文件是否存在
                //如果文件存在那么就执行
                if (File.Exists(strFilePath))
                {
                    //获取文件
                    FileInfo file = new FileInfo(strFilePath);
                    DateTime limitedTime = file.CreationTime.AddDays(iStoreDay);

                    //如果到期，那么就删除
                    if (limitedTime < DateTime.Now)
                    {
                        //执行删除
                        File.Delete(strFilePath);
                    }
                }
            }


            lblState.Text = "备份已经运行...\r\n";
            if (backupList.Count > 0 && backupList != null)
            {
                string strConnectLog = "";
                List<BackupItem> backupListToOperation = new List<BackupItem>();
                //在执行备份之前，先检测是否能够连接到数据库
                strConnectLog += "检测数据库连接\r\n";
                for (int i = backupList.Count - 1; i >= 0; i--)
                {
                    //日志变量,每次循环就刷新一次
                    strConnectLog += "\r\n";
                    strConnectLog += "Server IP:" + backupList[i].ServerIP + ":" + backupList[i].ServerPort + "   UserID:" + backupList[i].UserID + "\r\n";
                    if (SQLHelper.CheckConnection(backupList[i], ref strConnectLog) == false)
                    {
                        //如果没法连接数据库那么就不执行
                        strConnectLog += "无效的数据源，请修改后再执行\r\n";
                        continue;
                    }
                    //加载到新的List去执行操作
                    backupListToOperation.Add(backupList[i]);
                    strConnectLog += "数据库连接测试通过" + "\r\n";
                }

                //经过检测后，显示要备份的实例
                string strCheckedLog = "\r\n";
                strCheckedLog += "经过检测，开始对下列数据库实例进行备份：\r\n";
                foreach (var item in backupListToOperation)
                {
                    strCheckedLog += "Server IP:" + item.ServerIP + ":" + item.ServerPort + "   UserID:" + item.UserID + "\r\n";
                }


                string strLog = "\r\n";
                strLog += "开始执行备份:\r\n";
                foreach (var item in backupListToOperation)
                {
                    DataTable dt = SQLHelper.GetSQLTable(item, ref strLog);

                    if (dt.Rows.Count > 0 && dt != null)
                    {
                        //执行SQL语句
                        if (SQLHelper.ExeSQLTable(dt, item, ref strLog) == true)
                        {
                            //如果SQL执行完成，那么就开始备份数据库
                            SQLHelper.ExeBackup(item, ref strLog);
                        }
                        else
                        {
                            strLog += "未能备份数据\r\n";
                        }
                    }
                    else
                    {
                        //如果不存在空表的话，直接执行备份
                        SQLHelper.ExeBackup(item, ref strLog);
                    }
                    lblState.Text += item.BackupPath + "\r\n";
                }

                //备份完毕之后：将日志写入到日志文件中
                //这里的日志是操作日志，所有的只要一份
                string loglsit = strConnectLog + strCheckedLog + strLog;
                string fileName = DateTime.Now.ToString("yyyy-MM-dd HH mm ss") + ".txt";
                LogHelper.saveLog(fileName, loglsit);



                //显示状态
                lblState.Text += "备份已经完成:";
                //显示当前时间
                lblState.Text += DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "\r\n";
            }
            else
            {
                lblState.Text = "没有可以备份的数据源";
            }
          
        }


        #region 私有方法

        /// <summary>
        /// 初始化备份数据
        /// </summary>
        private DataTable LoadDatasorce()
        {
            //读取DB文件夹中的数据文件
            Tools.XuColumn saveDBFileTool = new XuColumn();
            DataTable dt = (DataTable)saveDBFileTool.UnXiColumn("DB", "data");
            return dt;

        }

        #endregion

    }
}
