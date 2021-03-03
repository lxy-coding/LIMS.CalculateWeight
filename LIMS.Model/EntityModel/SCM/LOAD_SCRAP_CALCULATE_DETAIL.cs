using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LOAD_SCRAP_CALCULATE_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 装废钢计量主表ID;
        /// <summary>
        public virtual string LOAD_SCRAP_CALCULATE_ID { get; set; }
        /// <summary>
        /// 计划重量;
        /// <summary>
        public virtual int? PLAN_WEIGHT { get; set; }
        /// <summary>
        /// 实际重量;
        /// <summary>
        public virtual int? REAL_WEIGHT { get; set; }
        /// <summary>
        /// 人工确认重量;
        /// <summary>
        public virtual int? CONFIRM_WEIGHT { get; set; }
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
        /// <summary>
        ///废钢种类;
        /// <summary>
        public virtual int? SCRAP_TYPE_ID { get; set; }
        /// <summary>
        /// 天车;
        /// <summary>
        public virtual int? CRANE_ID { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual short? MATERIAL_SEQ { get; set; }
    }
}
