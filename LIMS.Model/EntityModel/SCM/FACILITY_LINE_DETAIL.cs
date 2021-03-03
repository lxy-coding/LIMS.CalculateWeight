using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class FACILITY_LINE_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 外键;
        /// <summary>
        public virtual string HEAT_PLAN_ID { get; set; }
        /// <summary>
        /// 产线名;
        /// <summary>
        public virtual string FACILITY_ID { get; set; }
        /// <summary>
        /// 计划开始时间;
        /// <summary>
        public virtual DateTime? DT_HEAT_START { get; set; }
        /// <summary>
        /// 划结束时间;
        /// <summary>
        public virtual DateTime? DT_HEAT_DEPARTURE { get; set; }
    }
}
