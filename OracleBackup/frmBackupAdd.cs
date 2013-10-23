using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using OracleBackup.Tools;
using OracleBackup.Model;
using System.Configuration;
using OracleBackup.Tool;
using System.IO;


namespace OracleBackup
{
    public partial class frmBackupAdd : Form
    {
        public frmBackupAdd()
        {
            InitializeComponent();
        }

        private string strLogPath;
        private string strBackupPath;
        private string strEnvironmentPath;
        public List<BackupItem> backuplist;

        private void Main_Load(object sender, EventArgs e)
        {
            
            //检查数据文件data是否存在
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory+"DB\\data";
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            //检测该程序是否是后台运行
            string runType = ConfigurationManager.AppSettings["RunBackground"].ToString();
            //如果后台去执行备份
            if (runType == "True")
            {
                DataTable dt = LoadDatasorce();
                backuplist = new List<BackupItem>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BackupItem item = new BackupItem();
                    item.ServerIP = dt.Rows[i]["ServerIP"].ToString();
                    item.ServerPort = dt.Rows[i]["ServerPort"].ToString();
                    item.UserID = dt.Rows[i]["UserID"].ToString();
                    item.UserPwd = dt.Rows[i]["UserPwd"].ToString();
                    item.ServerName = dt.Rows[i]["ServerName"].ToString();
                    item.TableSpace = dt.Rows[i]["TableSpace"].ToString();
                    item.BackupPath = dt.Rows[i]["BackupPath"].ToString();
                    item.BackupDay = Convert.ToInt32(dt.Rows[i]["BackupDay"]);
                    item.Stuats = (Model.BackupFileStatus)Enum.Parse(typeof(Model.BackupFileStatus), dt.Rows[i]["Status"].ToString());

                    backuplist.Add(item);
                    
                }

                frmBackupLog frmLog = new frmBackupLog(backuplist);
                frmLog.ShowDialog();
                this.Close();
                return;
            }

            //使用GUI
            gvData.DataSource = LoadDatasorce();

            //开始清理文件
            for (int i = 0; i < gvData.Rows.Count; i++)
            {
                string strFilePath = gvData.Rows[i].Cells["BackupPath"].Value.ToString();
                int iStoreDay = Convert.ToInt32(gvData.Rows[i].Cells["BackupDay"].Value.ToString());

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
           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //检测连接字符串是否完整填写
            if (checkField() == false)
            {
                MessageBox.Show("请填写完信息！");
                return;
            }

            try
            {
                BackupItem item = new BackupItem();
                item.ServerIP = txtHost.Text.Trim();
                item.ServerPort = txtPort.Text.Trim();
                item.ServerName = txtServerName.Text.Trim();
                item.UserID = txtUserID.Text.Trim();
                item.UserPwd = txtPassword.Text.Trim();
                //选择空表，准备分配空间
                using (OracleConnection conn = new OracleConnection(SQLHelper.GetConnectString(item)))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MessageBox.Show("连接成功！");
                    }
                    else
                    {
                        MessageBox.Show("连接失败！");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("异常：" + ee.Message);
            }
        }

        /// <summary>
        /// 选择要备份的路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtTableSpace.Text)) {
            //    MessageBox.Show("请先填写【表空间】名称");
            //    return;
            //}
            if (fbdPath.ShowDialog() == DialogResult.OK)
            {
                string path = fbdPath.SelectedPath;
                if (path.LastIndexOf('\\') == path.Length-1)  
                {
                    path = path.Substring(0, path.Length - 1);
                }
                txtFilePath.Text = path;
                //txtFilePath.Text += "\\" + GetBackupFileName("dmp");
                //strBackupPath = path + "\\" + GetBackupFileName("dmp");
                //strLogPath = path + "\\" + GetBackupFileName("log");
            }

        }

        /// <summary>
        /// 添加备份信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBackup_Click(object sender, EventArgs e)
        {
            //检测连接字符串是否完整填写
            if (checkField() == false)
            {
                MessageBox.Show("请填写完信息！");
                return;
            }
            DataTable dt;
            if (gvData.DataSource == null)
            {
                dt = new DataTable();
                dt.Columns.Add("ServerIP");
                dt.Columns.Add("ServerPort");
                dt.Columns.Add("UserID");
                dt.Columns.Add("UserPwd");
                dt.Columns.Add("ServerName");
                dt.Columns.Add("TableSpace");
                dt.Columns.Add("BackupPath");
                dt.Columns.Add("BackupDay");
                dt.Columns.Add("Status");
            }
            else
            {
                dt = (DataTable)gvData.DataSource;
            }
            DataRow dr = dt.NewRow();
            dr["ServerIP"] = txtHost.Text.Trim();
            dr["ServerPort"] = txtPort.Text.Trim();
            dr["UserID"] = txtUserID.Text.Trim();
            dr["UserPwd"] =txtPassword .Text.Trim();
            dr["ServerName"] = txtServerName.Text.Trim();
            dr["TableSpace"] = txtTableSpace.Text.Trim();
            dr["BackupPath"] = txtFilePath.Text.Trim();
            dr["BackupDay"] = txtBackupDays.Text.Trim();
            dr["Status"] = OracleBackup.Model.BackupFileStatus.PreAdd.ToString();
            dt.Rows.Add(dr);
            gvData.DataSource = dt;   
        }


        /// <summary>
        /// 执行备份数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExeBackup_Click(object sender, EventArgs e)
        {
            //查看已经选择的行
            backuplist = new List<BackupItem>();
            for (int i = 0; i < gvData.Rows.Count; i++)
            {
                string _chk = gvData.Rows[i].Cells[0].EditedFormattedValue.ToString();
                if (_chk == "True")
                {
                    //如果选中的话就就执行添加
                    BackupItem item = new BackupItem();
                    item.ServerIP = gvData.Rows[i].Cells["ServerIP"].Value.ToString();
                    item.ServerPort = gvData.Rows[i].Cells["ServerPort"].Value.ToString();
                    item.UserID = gvData.Rows[i].Cells["UserID"].Value.ToString();
                    item.UserPwd = gvData.Rows[i].Cells["UserPwd"].Value.ToString();
                    item.ServerName = gvData.Rows[i].Cells["ServerName"].Value.ToString();
                    item.TableSpace = gvData.Rows[i].Cells["TableSpace"].Value.ToString();
                    item.BackupPath = gvData.Rows[i].Cells["BackupPath"].Value.ToString();
                    item.BackupDay = Convert.ToInt32(gvData.Rows[i].Cells["BackupDay"].Value);
                    item.Stuats = (Model.BackupFileStatus)Enum.Parse(typeof(Model.BackupFileStatus), gvData.Rows[i].Cells["Status"].Value.ToString());

                    backuplist.Add(item);
                }
            }
            if (backuplist.Count == 0)
            {
                MessageBox.Show("请选择要备份的数据");
            }
            else
            {
                frmBackupDetail frmDetail = new frmBackupDetail(this);
                frmDetail.Show();
            }
        }

        /// <summary>
        /// 改变表空间名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTableSpace_TextChanged(object sender, EventArgs e)
        {
            //if (txtFilePath.Text.Length > 0)
            //{
            //    string path = fbdPath.SelectedPath;
            //    if (path.LastIndexOf('\\') == path.Length - 1)
            //    {
            //        path = path.Substring(0, path.Length - 1);
            //    }
            //    txtFilePath.Text = path;
            //    txtFilePath.Text += "\\" + GetBackupFileName("dmp");
            //    strBackupPath = path + "\\" + GetBackupFileName("dmp");
            //    strLogPath = path + "\\" + GetBackupFileName("log");
            //}
        }


        /// <summary>
        /// 移除行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
            {
                DataTable dt = (DataTable)gvData.DataSource;
                dt.Rows.RemoveAt(e.RowIndex);
                gvData.DataSource = dt;
            }
        }

        /// <summary>
        /// 保存到数据文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveDataFile_Click(object sender, EventArgs e)
        {
          
            if (gvData.DataSource != null)
            {
                DataTable dt = (DataTable)gvData.DataSource;
                Tools.XuColumn saveDBFileTool = new XuColumn();
                saveDBFileTool.XiColumn("DB", "data", dt);
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("未能将模版存入到硬盘");
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

        private bool checkField()
        {
            if (string.IsNullOrEmpty(txtHost.Text)
                || string.IsNullOrEmpty(txtPort.Text)
                || string.IsNullOrEmpty(txtServerName.Text)
                || string.IsNullOrEmpty(txtUserID.Text)
                || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtTableSpace.Text)
                || string.IsNullOrEmpty(txtBackupDays.Text))
            {
                return false;
            }
            return true;
        }

       


        
        #endregion

       

        

      

     







    }
}
