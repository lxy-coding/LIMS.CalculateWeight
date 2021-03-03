using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class PREPARE_SCRAP_CALCULATE_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 预配废钢计量主表ID;
        /// <summary>
        public virtual string PREPARE_SCRAP_CALCULATE_ID { get; set; }
        /// <summary>
        /// 计划重量;
        /// <summary>
        public virtual int? PLAN_WEIGHT { get; set; }
        /// <summary>
        /// 系统重量;
        /// <summary>
        public virtual int? REAL_WEIGHT { get; set; }
        /// <summary>
        /// 人工确认重量;
        /// <summary>
        public virtual int? CONFIRM_WEIGHT { get; set; }
        /// <summary>
        /// 天车;
        /// <summary>
        public virtual int? CRANE_ID { get; set; }
        /// <summary>
        /// 创建人;
        /// <summary>
        public virtual string FIRST_USER { get; set; }
        /// <summary>
        /// 创建时间;
        /// <summary>
        public virtual DateTime? FIRST_TIME { get; set; }
        /// <summary>
        /// 修改人;
        /// <summary>
        public virtual string LAST_USER { get; set; }
        /// <summary>
        /// 修改时间;
        /// <summary>
        public virtual DateTime? LAST_TIME { get; set; }
    }
}
