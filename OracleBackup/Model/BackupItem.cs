using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OracleBackup.Model
{
    public class BackupItem
    {
        public string ServerIP { get; set; }
        public string ServerPort { get; set; }
        public string UserID { get; set; }
        public string UserPwd { get; set; }
        public string ServerName { get; set; }
        public string TableSpace { get; set; }
        public string BackupFile { get; set; }
        public string BackupPath { get; set; }
        public string BackupLogPath { get; set; }
        public int BackupDay { get; set; }
        public BackupFileStatus Stuats { get; set; }
       
    }

    public enum BackupFileStatus 
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal,   
        /// <summary>
        /// 过期
        /// </summary>
        Expired,   
        /// <summary>
        /// 待新增
        /// </summary>
        PreAdd,
        /// <summary>
        /// 正在新增
        /// </summary>
        Adding,
        /// <summary>
        /// 新增完成
        /// </summary>
        Added,
        /// <summary>
        /// 新增失败
        /// </summary>
        AddFaild,
    }
}
