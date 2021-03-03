using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_PLAN_COM {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 接口ID;
        /// <summary>
        public virtual string INTERFACE_ID { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string EAT_NO { get; set; }
        /// <summary>
        /// 装载时间;
        /// <summary>
        public virtual string PLANNED_CHARGING { get; set; }
    }
}
