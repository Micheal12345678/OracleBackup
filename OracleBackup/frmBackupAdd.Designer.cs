namespace OracleBackup
{
    partial class frmBackupAdd
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.staMain = new System.Windows.Forms.StatusStrip();
            this.slblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.gvData = new System.Windows.Forms.DataGridView();
            this.chkBackup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BackupLogPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnExeBackup = new System.Windows.Forms.Button();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTableSpace = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAddBackup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBackupDays = new System.Windows.Forms.TextBox();
            this.btnSaveDataFile = new System.Windows.Forms.Button();
            this.staMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(90, 9);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(318, 21);
            this.txtHost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "主机名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "服务名：";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(483, 9);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(318, 21);
            this.txtServerName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(836, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "端口：";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(899, 11);
            this.txtPort.MaxLength = 10;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 21);
            this.txtPort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "密码：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(484, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(318, 21);
            this.txtPassword.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "登录名：";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(90, 36);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(318, 21);
            this.txtUserID.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(789, 108);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 35);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "测试连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // staMain
            // 
            this.staMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblInfo});
            this.staMain.Location = new System.Drawing.Point(0, 590);
            this.staMain.Name = "staMain";
            this.staMain.Size = new System.Drawing.Size(1008, 22);
            this.staMain.TabIndex = 11;
            this.staMain.Text = "statusStrip1";
            // 
            // slblInfo
            // 
            this.slblInfo.Name = "slblInfo";
            this.slblInfo.Size = new System.Drawing.Size(32, 17);
            this.slblInfo.Text = "就绪";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "备份路径：";
            // 
            // gvData
            // 
            this.gvData.AllowUserToAddRows = false;
            this.gvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBackup,
            this.BackupLogPath,
            this.ServerIP,
            this.ServerPort,
            this.UserID,
            this.UserPwd,
            this.ServerName,
            this.TableSpace,
            this.BackupPath,
            this.BackupDay,
            this.Status,
            this.btnDelete});
            this.gvData.Location = new System.Drawing.Point(5, 149);
            this.gvData.Name = "gvData";
            this.gvData.RowTemplate.Height = 23;
            this.gvData.Size = new System.Drawing.Size(996, 372);
            this.gvData.TabIndex = 18;
            this.gvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvData_CellContentClick);
            // 
            // chkBackup
            // 
            this.chkBackup.HeaderText = "备份";
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.TrueValue = "";
            this.chkBackup.Width = 40;
            // 
            // BackupLogPath
            // 
            this.BackupLogPath.DataPropertyName = "BackupLogPath";
            this.BackupLogPath.HeaderText = "日志路径";
            this.BackupLogPath.Name = "BackupLogPath";
            this.BackupLogPath.Visible = false;
            // 
            // ServerIP
            // 
            this.ServerIP.DataPropertyName = "ServerIP";
            this.ServerIP.HeaderText = "服务器IP";
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Width = 120;
            // 
            // ServerPort
            // 
            this.ServerPort.DataPropertyName = "ServerPort";
            this.ServerPort.HeaderText = "端口";
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Width = 40;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "用户名";
            this.UserID.Name = "UserID";
            // 
            // UserPwd
            // 
            this.UserPwd.DataPropertyName = "UserPwd";
            this.UserPwd.HeaderText = "密码";
            this.UserPwd.Name = "UserPwd";
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "ServerName";
            this.ServerName.HeaderText = "实例名";
            this.ServerName.Name = "ServerName";
            // 
            // TableSpace
            // 
            this.TableSpace.DataPropertyName = "TableSpace";
            this.TableSpace.HeaderText = "表空间名";
            this.TableSpace.Name = "TableSpace";
            // 
            // BackupPath
            // 
            this.BackupPath.DataPropertyName = "BackupPath";
            this.BackupPath.HeaderText = "备份路径";
            this.BackupPath.Name = "BackupPath";
            this.BackupPath.Width = 150;
            // 
            // BackupDay
            // 
            this.BackupDay.DataPropertyName = "BackupDay";
            this.BackupDay.HeaderText = "保留";
            this.BackupDay.Name = "BackupDay";
            this.BackupDay.Width = 40;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.Width = 60;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "移除";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "移除";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(838, 65);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(148, 23);
            this.btnFilePath.TabIndex = 17;
            this.btnFilePath.Text = "选择路径";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(484, 67);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(317, 21);
            this.txtFilePath.TabIndex = 13;
            // 
            // btnExeBackup
            // 
            this.btnExeBackup.Location = new System.Drawing.Point(877, 539);
            this.btnExeBackup.Name = "btnExeBackup";
            this.btnExeBackup.Size = new System.Drawing.Size(95, 35);
            this.btnExeBackup.TabIndex = 15;
            this.btnExeBackup.Text = "执行备份";
            this.btnExeBackup.UseVisualStyleBackColor = true;
            this.btnExeBackup.Click += new System.EventHandler(this.btnExeBackup_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "表空间：";
            // 
            // txtTableSpace
            // 
            this.txtTableSpace.Location = new System.Drawing.Point(90, 67);
            this.txtTableSpace.Name = "txtTableSpace";
            this.txtTableSpace.Size = new System.Drawing.Size(318, 21);
            this.txtTableSpace.TabIndex = 13;
            this.txtTableSpace.TextChanged += new System.EventHandler(this.txtTableSpace_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(19, 131);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(41, 12);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "消息：";
            // 
            // btnAddBackup
            // 
            this.btnAddBackup.Location = new System.Drawing.Point(890, 108);
            this.btnAddBackup.Name = "btnAddBackup";
            this.btnAddBackup.Size = new System.Drawing.Size(95, 35);
            this.btnAddBackup.TabIndex = 20;
            this.btnAddBackup.Text = "添加备份";
            this.btnAddBackup.UseVisualStyleBackColor = true;
            this.btnAddBackup.Click += new System.EventHandler(this.btnAddBackup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(836, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "备份天数：";
            // 
            // txtBackupDays
            // 
            this.txtBackupDays.Location = new System.Drawing.Point(899, 36);
            this.txtBackupDays.MaxLength = 10;
            this.txtBackupDays.Name = "txtBackupDays";
            this.txtBackupDays.Size = new System.Drawing.Size(87, 21);
            this.txtBackupDays.TabIndex = 22;
            // 
            // btnSaveDataFile
            // 
            this.btnSaveDataFile.Location = new System.Drawing.Point(765, 539);
            this.btnSaveDataFile.Name = "btnSaveDataFile";
            this.btnSaveDataFile.Size = new System.Drawing.Size(106, 35);
            this.btnSaveDataFile.TabIndex = 23;
            this.btnSaveDataFile.Text = "保存数据";
            this.btnSaveDataFile.UseVisualStyleBackColor = true;
            this.btnSaveDataFile.Click += new System.EventHandler(this.btnSaveDataFile_Click);
            // 
            // frmBackupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.btnSaveDataFile);
            this.Controls.Add(this.txtBackupDays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddBackup);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExeBackup);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtTableSpace);
            this.Controls.Add(this.staMain);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHost);
            this.MaximumSize = new System.Drawing.Size(1024, 650);
            this.MinimumSize = new System.Drawing.Size(1024, 650);
            this.Name = "frmBackupAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "备份数据库";
            this.Load += new System.EventHandler(this.Main_Load);
            this.staMain.ResumeLayout(false);
            this.staMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.StatusStrip staMain;
        private System.Windows.Forms.ToolStripStatusLabel slblInfo;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnExeBackup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTableSpace;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAddBackup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBackupDays;
        private System.Windows.Forms.Button btnSaveDataFile;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBackup;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupLogPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}

