using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_BUCKET_LOG_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 外键;
        /// <summary>
        public virtual string SCRAP_BUCKET_LOG_ID { get; set; }
        /// <summary>
        /// 废钢种类;
        /// <summary>
        public virtual int? SCRAP_TYPE_ID { get; set; }
        /// <summary>
        /// 重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
    }
}
