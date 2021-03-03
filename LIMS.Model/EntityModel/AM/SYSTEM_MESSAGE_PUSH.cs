using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 系统消息推送
    /// </summary>
    [Serializable]
    public class SYSTEM_MESSAGE_PUSH
    {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 角色信息_序号;
        /// <summary>
        public virtual ROLE_INFO ROL_ID { get; set; }
        /// <summary>
        /// 标题;
        /// <summary>
        public virtual string TITLE { get; set; }
        /// <summary>
        /// 内容;
        /// <summary>
        public virtual string CONTENT { get; set; }
        /// <summary>
        /// 推送角色;
        /// <summary>
        public virtual int? PUSHROLE { get; set; }
        /// <summary>
        /// 级别;
        /// <summary>
        public virtual short? LEVEL_NUM { get; set; }
        /// <summary>
        /// 地址;
        /// <summary>
        public virtual string URL { get; set; }
        /// <summary>
        /// 读取标识;
        /// <summary>
        public virtual short? IS_READ { get; set; }
        /// <summary>
        /// 创建时间;
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
        /// <summary>
        /// 读取时间;
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
        /// <summary>
        /// 消息类型;
        /// <summary>
        public virtual short? MESSAGE_TYPE { get; set; }
        /// <summary>
        /// 处理标志;
        /// <summary>
        public virtual short? HANDLE_FLAG { get; set; }
        /// <summary>
        /// 处理时间;
        /// <summary>
        public virtual DateTime? HANDLE_TIME { get; set; }
        /// <summary>
        /// 创建者;
        /// <summary>
        public virtual string CREATER { get; set; }
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
    }
}
