using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class MATCH_SCRAP_OUT_MES {
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
        public virtual string HEAT_ID { get; set; }
        /// <summary>
        /// 废钢斗;
        /// <summary>
        public virtual string BUCKET_ID { get; set; }
        /// <summary>
        /// 配的废钢列表数;
        /// <summary>
        public virtual string MAT_COUNT { get; set; }
    }
}
