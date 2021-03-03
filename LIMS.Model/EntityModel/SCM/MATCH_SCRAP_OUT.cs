using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class MATCH_SCRAP_OUT {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 炉次计划号;
        /// <summary>
        public virtual string HEAT_PLAN_ID { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUMBER { get; set; }
        /// <summary>
        /// 废钢斗;
        /// <summary>
        public virtual int? SCRAP_BUCKET_ID { get; set; }
        /// <summary>
        /// 天车;
        /// <summary>
        public virtual int? CRANE_ID { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string BILLCODE { get; set; }
     
    }
}
