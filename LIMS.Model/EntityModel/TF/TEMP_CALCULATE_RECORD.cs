using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class TEMP_CALCULATE_RECORD {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 钢包号;
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 接钢内壁温度;
        /// <summary>
        public virtual short? TAP_INNER_TEMP { get; set; }
        /// <summary>
        /// 接钢外壁温度;
        /// <summary>
        public virtual short? TAP_OUTER_TEMP { get; set; }
        /// <summary>
        /// 转炉编号;
        /// <summary>
        public virtual string BOF_NUM { get; set; }
        /// <summary>
        /// 到达LF钢液温度;
        /// <summary>
        public virtual short? ARRIVE_LF_TEMP { get; set; }
        /// <summary>
        /// LF炉编号;
        /// <summary>
        public virtual string LF_NUM { get; set; }
        /// <summary>
        /// 到达RH钢液温度;
        /// <summary>
        public virtual short? ARRIVE_RH_TEMP { get; set; }
        /// <summary>
        /// RH炉编号;
        /// <summary>
        public virtual string RH_NUM { get; set; }
        /// <summary>
        /// 到达连铸钢液温度;
        /// <summary>
        public virtual short? ARRIVE_CCM_TEMP { get; set; }
        /// <summary>
        /// 连铸机编号;
        /// <summary>
        public virtual string CCM_NUM { get; set; }
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
