using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 用户
    /// </summary>
    [Serializable]
    public class USER_INFO
    {
        public USER_INFO() { }
        /// <summary>
        /// 序号;自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 班组信息_序号
        /// <summary>
        public virtual TEAM_INFO TEA_ID { get; set; }
        /// <summary>
        /// 选中状态;
        /// <summary>
        public virtual string SELECTED { get; set; }
        /// <summary>
        /// 名称;
        /// <summary>
        public virtual string NAM { get; set; }
        /// <summary>
        /// 密码;密码需要用MD5算法
        /// <summary>
        public virtual string PWD { get; set; }
        /// <summary>
        /// 用户类型;1为系统超级用户，2为系统管理员用户，3为系统操作用户，4为系统查询用户
        /// <summary>
        public virtual short USER_TYPE { get; set; }
        /// <summary>
        /// 父账号;
        /// <summary>
        public virtual string P_USER_NUM { get; set; }
        /// <summary>
        /// 在职状态;1在职，0离职，默认为1
        /// <summary>
        public virtual short IN_JOB { get; set; }
        /// <summary>
        /// 是否启用;
        /// <summary>
        public virtual short? ENABLE_FLAG { get; set; }
        /// <summary>
        /// 用户首页;
        /// <summary>
        public virtual int? USER_HOME_PAGE { get; set; }
        /// <summary>
        /// 用户快捷资源;
        /// <summary>
        public virtual string USER_QUICK_RECOURCES { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 编号
        /// <summary>
        public virtual string NUM { get; set; }
    }
}
