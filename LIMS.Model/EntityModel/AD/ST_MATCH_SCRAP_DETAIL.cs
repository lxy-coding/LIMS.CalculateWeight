using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_MATCH_SCRAP_DETAIL {
        /// <summary>
        /// 序号，GUID
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 废钢配料_序号
        /// <summary>
        public virtual ST_MATCH_SCRAP MATCH_ID { get; set; }
        /// <summary>
        /// 废钢编号
        /// <summary>
        public virtual string SCRAP_NUM { get; set; }
        /// <summary>
        /// 重量，单位KG
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 废钢装配序列号
        /// <summary>
        public virtual short? MATCH_SERIAL_NUM { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 默认为0，人工修改1，校验流程读取2，计算流程重算3
        /// <summary>
        public virtual short? MODIFY_STATUS { get; set; }
    }
}
