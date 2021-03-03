using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class MATCH_SCRAP_OUT_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 接收场外配废钢实绩;
        /// <summary>
        public virtual string MATCH_SCRAP_OUT_ID { get; set; }
        /// <summary>
        /// 批次号;
        /// <summary>
        public virtual string BATCH_NUMBER { get; set; }
        /// <summary>
        /// 废钢种类;
        /// <summary>
        public virtual int? SCRAP_TYPE_ID { get; set; }
        /// <summary>
        /// 物料源库;
        /// <summary>
        public virtual string LOCATION { get; set; }
        /// <summary>
        /// 装载时间;
        /// <summary>
        public virtual DateTime? LOAD_TIME { get; set; }
        /// <summary>
        /// 装载重量;
        /// <summary>
        public virtual int? PLAN_WEIGHT { get; set; }
    }
}
