using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {

[Serializable]
    
    public class HEAT_TEMP_COMPENSATION {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 钢包号;
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 转炉编号;
        /// <summary>
        public virtual string BOF_NUM { get; set; }
        /// <summary>
        /// 出钢温度;
        /// <summary>
        public virtual short? BOF_TAP_TEMP { get; set; }
        /// <summary>
        /// 出钢时间;
        /// <summary>
        public virtual DateTime? BOF_TAP_TIME { get; set; }
        /// <summary>
        /// 转炉出钢补偿温度;
        /// <summary>
        public virtual short? BOF_TEMP_COMPEN { get; set; }
        /// <summary>
        /// LF炉编号;
        /// <summary>
        public virtual string LF_NUM { get; set; }
        /// <summary>
        /// LF出站温度;
        /// <summary>
        public virtual short? LF_TAP_TEMP { get; set; }
        /// <summary>
        /// LF出站时间;
        /// <summary>
        public virtual DateTime? LF_TAP_TIME { get; set; }
        /// <summary>
        /// LF出站温度补偿;
        /// <summary>
        public virtual short? LF_TEMP_COMPEN { get; set; }
        /// <summary>
        /// RH炉编号;
        /// <summary>
        public virtual string RH_NUM { get; set; }
        /// <summary>
        /// RH出站温度;
        /// <summary>
        public virtual short? RH_TAP_TEMP { get; set; }
        /// <summary>
        /// RH出站时间;
        /// <summary>
        public virtual DateTime? RH_TAP_TIME { get; set; }
        /// <summary>
        /// RH出站温度补偿;
        /// <summary>
        public virtual short? RH_TEMP_COMPEN { get; set; }
        /// <summary>
        /// 记录生成时间;
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
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
