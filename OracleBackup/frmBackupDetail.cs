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

namespace OracleBackup
{
    public partial class frmBackupDetail : Form
    {
        public frmBackupDetail()
        {
            InitializeComponent();
        }

        private frmBackupAdd frmParent = new frmBackupAdd();
        private List<BackupItem> backupList;
        public frmBackupDetail(frmBackupAdd frmAdd)
        {
            InitializeComponent();
            this.frmParent = frmAdd;
            this.backupList = frmAdd.backuplist;
        }

        private void frmBackupDetail_Load(object sender, EventArgs e)
        {
            //绑定列表数据
            LoadBuckupItemList();
        }

    

        private void btnExeBackup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定执行备份嘛?", "确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string strConnectLog = "";
                List<BackupItem> backupListToOperation = new List<BackupItem>();
                //在执行备份之前，先检测是否能够连接到数据库
                strConnectLog += "检测数据库连接\r\n";                
                for (int i = backupList.Count - 1; i >= 0;i--)
                {
                    //日志变量,每次循环就刷新一次
                    //string temp = "";
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
                txtOperationLog.Text += strConnectLog;
                
                //经过检测后，显示要备份的实例
                string strCheckedLog = "\r\n";
                strCheckedLog += "经过检测，开始对下列数据库实例进行备份：\r\n";
                foreach (var item in backupListToOperation)
                {
                    strCheckedLog += "Server IP:" + item.ServerIP + ":" + item.ServerPort + "   UserID:" + item.UserID + "\r\n";
                }
                txtOperationLog.Text += strCheckedLog;


                string strLog = "\r\n";
                strLog += "开始执行备份:\r\n";
                foreach (var item in backupListToOperation)
                {
                    //获取具体的信息
                    GetDetailInfo(item);
                    //显示要执行的SQL语句
                    DataTable dt = SQLHelper.GetSQLTable(item, ref strLog);
                    
                    if (dt.Rows.Count > 0 && dt != null)
                    {
                        //执行SQL语句
                        if (SQLHelper.ExeSQLTable(dt, item, ref strLog) == true)
                        {
                            //如果SQL执行完成，那么就开始备份数据库
                            SQLHelper.ExeBackup(item,ref strLog);
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
                }
                //在文本框中显示
                txtOperationLog.Text += strLog;


                //备份完毕之后：将日志写入到日志文件中
                //这里的日志是操作日志，所有的只要一份
                string loglsit = strConnectLog + strCheckedLog + strLog;
                string fileName = DateTime.Now.ToString("yyyy-MM-dd HH mm ss") +".txt";
                LogHelper.saveLog(fileName, loglsit);
               

            }
        }

        #region 私有方法
        private void LoadBuckupItemList()
        {
            gvTask.AutoGenerateColumns = false;
            gvTask.DataSource = this.backupList;
        }

        private void GetDetailInfo(Model.BackupItem item)
        {
            lblServerName.Text = item.ServerName;
            lblServerIPPort.Text = item.ServerIP + ":" + item.ServerPort;
            lblUserID.Text = item.UserID;
            lblUserPwd.Text = item.UserPwd;
            lblTableSpace.Text = item.TableSpace;
            lblKeepDay.Text = item.BackupDay + "天";
            lblBackupPath.Text = item.BackupPath;
            lblInfo.Text = item.Stuats.ToString();
        }

       

        #endregion
      
    }
}
