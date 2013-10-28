using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dal
{

    public class BizContext
    {
        XuColumn xu = new XuColumn();
        public List<SystemName> GetSystemName()
        {

            object _obj = xu.UnXiColumn("", "SystemName.dt");
            List<SystemName> plistSystem_Process = null;
            if (_obj != null)
            {
                plistSystem_Process = (List<SystemName>)_obj;

            } //不存在系统自我创建
            if (plistSystem_Process == null)
            {
                plistSystem_Process = new List<SystemName>();
            }

            return plistSystem_Process;
        }
        public List<System_Process> GetSystem_Process()
        {
            #region 20130515 读取本地所已导入的所选系统的流程
            object obj = xu.UnXiColumn("", "System_Process.dt");
            List<System_Process> plistSystemProcess = null;
            if (obj != null)
            {
                plistSystemProcess = (List<System_Process>)obj;
                } 
            //不存在系统自我创建
            if (plistSystemProcess == null)
            {
                plistSystemProcess = new List<System_Process>();
            }
            #endregion
            return plistSystemProcess;
        }

        /// <summary>
        /// 根据系统来找到相应传入泛型对象的本地数据库
        /// </summary>
        /// <typeparam name="T">传入实体类型</typeparam>
        /// <param name="systemName">系统名称</param>
        /// <returns>数据集合可能为null</returns>
        public object ICommonEntity<T>(string systemName) where T : class ,new()
        {
            Type typeModel = typeof(T);
            string modelName = typeModel.Name;
            object objSysProcess = xu.UnXiColumn(systemName, modelName + ".dt");
            return objSysProcess;
        }
        public List<SysProcess> GetSysProcess(string systemName)
        {
            #region 20130515 读取本地所有流程
            object objSysProcess = xu.UnXiColumn(systemName, "SysProcess.dt");
            List<SysProcess> plistSysProcess = null;
            if (objSysProcess != null)
            {
                plistSysProcess = (List<SysProcess>)objSysProcess;


            } //不存在系统自我创建
            if (plistSysProcess != null)
            {
                return plistSysProcess;
            }
            plistSysProcess = new List<SysProcess>();

            #endregion

            return plistSysProcess;
        }

    }
}
