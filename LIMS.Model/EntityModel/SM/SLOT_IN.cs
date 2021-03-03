using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SLOT_IN {
        /// <summary>
        /// 主键ID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢斗编号
        /// <summary>
        public virtual string SLOT_NUM { get; set; }
        /// <summary>
        /// 单号
        /// <summary>
        public virtual string REFE_ID { get; set; }
        /// <summary>
        /// 净重
        /// <summary>
        public virtual double? NET_WEIGHT { get; set; }
        /// <summary>
        /// 汽车编号
        /// <summary>
        public virtual string CAR_NUM { get; set; }
        /// <summary>
        /// 天车编号
        /// <summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 是否落地
        /// <summary>
        public virtual short? IS_PUT { get; set; }
        /// <summary>
        /// 落地位置
        /// <summary>
        public virtual string PUT_POSITION { get; set; }
        /// <summary>
        /// 跨编号
        /// <summary>
        public virtual string SPA_NUM { get; set; }
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
    }
}
