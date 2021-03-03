using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CHECK_RECORD {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 坯料号;
        /// <summary>
        public virtual string STEEL_NUM { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 货位ID;
        /// <summary>
        public virtual int? POSITION_ID { get; set; }
        /// <summary>
        /// 层;
        /// <summary>
        public virtual short? LAYER { get; set; }
        /// <summary>
        /// 核库时间; yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? CHECK_TIME { get; set; }
        /// <summary>
        /// 核库类型; （1增加；2修改；3删除；4出库确认；5删除计划；6倒跺）
        /// <summary>
        public virtual short? CHECK_TYPE { get; set; }
        /// <summary>
        /// 用户编号;
        /// <summary>
        public virtual string USER_NUM { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
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
