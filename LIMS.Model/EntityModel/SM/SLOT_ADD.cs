using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SLOT_ADD {
        /// <summary>
        /// 主键
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 单号
        /// <summary>
        public virtual string REFE_ID { get; set; }
        /// <summary>
        /// 废钢斗编号
        /// <summary>
        public virtual string SLOT_NUM { get; set; }
        /// <summary>
        /// 转炉编号
        /// <summary>
        public virtual string BOF_NUM { get; set; }
        /// <summary>
        /// 天车编号
        /// <summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 加料前重量
        /// <summary>
        public virtual int? BEFORE_WEIGHT { get; set; }
        /// <summary>
        /// 加料后重量
        /// <summary>
        public virtual int? AFTER_WEIGHT { get; set; }
        /// <summary>
        /// 时间戳
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 班组
        /// <summary>
        public virtual string TEAM { get; set; }
        /// <summary>
        /// 班别
        /// <summary>
        public virtual string SHIFT { get; set; }
        /// <summary>
        /// 操作人
        /// <summary>
        public virtual string USER_NAME { get; set; }
        /// <summary>
        /// 是否完成
        /// <summary>
        public virtual short? IS_COMPLATEED { get; set; }
        /// <summary>
        /// 物重记录状态ID
        /// <summary>
        public virtual string WEIGHT_STATUS_RECORD_ID { get; set; }
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
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
        /// 净重
        /// <summary>
        public virtual int? NET_WEIGHT { get; set; }
        /// <summary>
        /// 兑前时间
        /// <summary>
        public virtual DateTime? CHARGE_START_TIME { get; set; }
        /// <summary>
        /// 兑后时间
        /// <summary>
        public virtual DateTime? CHARGE_END_TIME { get; set; }
    }
}
