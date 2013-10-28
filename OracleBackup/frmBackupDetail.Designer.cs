namespace OracleBackup
{
    partial class frmBackupDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblServerIPPort = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUserPwd = new System.Windows.Forms.Label();
            this.lblKeepDay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTableSpace = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.ttBackupPath = new System.Windows.Forms.ToolTip(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.gvTask = new System.Windows.Forms.DataGridView();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOperationLog = new System.Windows.Forms.Button();
            this.btnExeBackup = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtOperationLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "主机名：";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(71, 26);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(11, 12);
            this.lblServerName.TabIndex = 3;
            this.lblServerName.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "服务称：";
            // 
            // lblServerIPPort
            // 
            this.lblServerIPPort.AutoSize = true;
            this.lblServerIPPort.Location = new System.Drawing.Point(256, 26);
            this.lblServerIPPort.Name = "lblServerIPPort";
            this.lblServerIPPort.Size = new System.Drawing.Size(11, 12);
            this.lblServerIPPort.TabIndex = 5;
            this.lblServerIPPort.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "登录名：";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(71, 47);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(11, 12);
            this.lblUserID.TabIndex = 7;
            this.lblUserID.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "密  码：";
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.AutoSize = true;
            this.lblUserPwd.Location = new System.Drawing.Point(256, 47);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(11, 12);
            this.lblUserPwd.TabIndex = 9;
            this.lblUserPwd.Text = "*";
            // 
            // lblKeepDay
            // 
            this.lblKeepDay.AutoSize = true;
            this.lblKeepDay.Location = new System.Drawing.Point(600, 47);
            this.lblKeepDay.Name = "lblKeepDay";
            this.lblKeepDay.Size = new System.Drawing.Size(11, 12);
            this.lblKeepDay.TabIndex = 11;
            this.lblKeepDay.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "表空间：";
            // 
            // lblTableSpace
            // 
            this.lblTableSpace.AutoSize = true;
            this.lblTableSpace.Location = new System.Drawing.Point(463, 47);
            this.lblTableSpace.Name = "lblTableSpace";
            this.lblTableSpace.Size = new System.Drawing.Size(11, 12);
            this.lblTableSpace.TabIndex = 12;
            this.lblTableSpace.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "保  留：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "备份于：";
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.AutoSize = true;
            this.lblBackupPath.Location = new System.Drawing.Point(71, 72);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(11, 12);
            this.lblBackupPath.TabIndex = 16;
            this.lblBackupPath.Text = "*";
            this.ttBackupPath.SetToolTip(this.lblBackupPath, "D:\\OracleBackup");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 18;
            this.label15.Text = "消  息：";
            // 
            // gvTask
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Server,
            this.ServerPort,
            this.UserID,
            this.Status});
            this.gvTask.Location = new System.Drawing.Point(10, 345);
            this.gvTask.Name = "gvTask";
            this.gvTask.RowTemplate.Height = 23;
            this.gvTask.Size = new System.Drawing.Size(612, 226);
            this.gvTask.TabIndex = 19;
            // 
            // Server
            // 
            this.Server.DataPropertyName = "ServerIP";
            this.Server.HeaderText = "服务器";
            this.Server.Name = "Server";
            // 
            // ServerPort
            // 
            this.ServerPort.DataPropertyName = "ServerPort";
            this.ServerPort.HeaderText = "端口";
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Width = 60;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "任务名称";
            this.UserID.Name = "UserID";
            this.UserID.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Stuats";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.Width = 60;
            // 
            // btnOperationLog
            // 
            this.btnOperationLog.Location = new System.Drawing.Point(527, 82);
            this.btnOperationLog.Name = "btnOperationLog";
            this.btnOperationLog.Size = new System.Drawing.Size(100, 23);
            this.btnOperationLog.TabIndex = 20;
            this.btnOperationLog.Text = "查看操作日志";
            this.btnOperationLog.UseVisualStyleBackColor = true;
            this.btnOperationLog.Visible = false;
            // 
            // btnExeBackup
            // 
            this.btnExeBackup.Location = new System.Drawing.Point(527, 577);
            this.btnExeBackup.Name = "btnExeBackup";
            this.btnExeBackup.Size = new System.Drawing.Size(95, 23);
            this.btnExeBackup.TabIndex = 21;
            this.btnExeBackup.Text = "执行备份";
            this.btnExeBackup.UseVisualStyleBackColor = true;
            this.btnExeBackup.Click += new System.EventHandler(this.btnExeBackup_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(71, 93);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(11, 12);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "*";
            // 
            // txtOperationLog
            // 
            this.txtOperationLog.Location = new System.Drawing.Point(10, 118);
            this.txtOperationLog.Multiline = true;
            this.txtOperationLog.Name = "txtOperationLog";
            this.txtOperationLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOperationLog.Size = new System.Drawing.Size(613, 221);
            this.txtOperationLog.TabIndex = 23;
            // 
            // frmBackupDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 612);
            this.Controls.Add(this.txtOperationLog);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnExeBackup);
            this.Controls.Add(this.btnOperationLog);
            this.Controls.Add(this.gvTask);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblBackupPath);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTableSpace);
            this.Controls.Add(this.lblKeepDay);
            this.Controls.Add(this.lblUserPwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblServerIPPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(650, 650);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "frmBackupDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "执行备份";
            this.Load += new System.EventHandler(this.frmBackupDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblServerIPPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUserPwd;
        private System.Windows.Forms.Label lblKeepDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTableSpace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.ToolTip ttBackupPath;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gvTask;
        private System.Windows.Forms.Button btnOperationLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnExeBackup;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtOperationLog;
    }
}