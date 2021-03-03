using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 钢包识别记录表
    /// </summary>
    [Serializable]
    public class LADLE_DISCERN_RECORD
    {
        /// <summary>
        /// 序号，GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 包号识别ID，包号识别表主键
        /// <summary>
        public virtual string LADLE_DISCERN_ID { get; set; }
        /// <summary>
        /// 相机编号
        /// <summary>
        public virtual string CRAMERA_NUM { get; set; }
        /// <summary>
        /// 工位信息表ID
        /// <summary>
        public virtual string WST_NUM { get; set; }
        /// <summary>
        /// 跟踪包号
        /// <summary>
        public virtual string TRACKING_NUM { get; set; }
        /// <summary>
        /// 识别包号
        /// <summary>
        public virtual string DISCERN_NUM { get; set; }
        /// <summary>
        /// 确认包号
        /// <summary>
        public virtual string CONFIRM_NUM { get; set; }
        /// <summary>
        /// 跟踪标志，默认0
        /// <summary>
        public virtual short? TRACKING_FLAG { get; set; }
        /// <summary>
        /// 识别标志，默认0
        /// <summary>
        public virtual short? DISCERN_FLAG { get; set; }
        /// <summary>
        /// 确认标志，默认0
        /// <summary>
        public virtual short? CONFIRM_FLAG { get; set; }
        /// <summary>
        /// 上下线标志，1下线，2上线，默认0
        /// <summary>
        public virtual short? DH_FLAG { get; set; }
        /// <summary>
        /// 图片路径
        /// <summary>
        public virtual string IMAGE_ADDRESS { get; set; }
        /// <summary>
        /// 相机处理时间
        /// <summary>
        public virtual DateTime RECORD_TMIE { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD4 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD5 { get; set; }
        /// <summary>
        /// 预留字段3,Xml形式字符串
        /// <summary>
        public virtual string FIELD6 { get; set; }
        /// <summary>
        /// 处理标志：0未处理、1已处理
        /// <summary>
        public virtual short? ISHANDLE { get; set; }
        /// <summary>
        /// 处理时间
        /// <summary>
        public virtual DateTime? HANDLETIME { get; set; }
        /// <summary>
        /// 用户确认时间
        /// <summary>
        public virtual DateTime? CONFIRM_TIME { get; set; }
        /// <summary>
        /// 数据等级：1 正常、2 警告、3 紧急
        /// <summary>
        public virtual short? DATALEVEL { get; set; }
        /// <summary>
        /// 确认方：0未确认、-1系统确认、>0 为用户表ID
        /// <summary>
        public virtual int? CONFIRMPARTY { get; set; }
        /// <summary>
        /// 是否警告用户：0 不警告、1 警告
        /// <summary>
        public virtual short? ISWARNING { get; set; }
        /// <summary>
        /// 接口标识：0 未处理、 1 已处理
        /// <summary>
        public virtual short? INTERFACE_FLAG { get; set; }
    }
}
