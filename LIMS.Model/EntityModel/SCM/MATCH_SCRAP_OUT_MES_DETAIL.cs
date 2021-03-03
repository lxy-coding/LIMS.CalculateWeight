using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class MATCH_SCRAP_OUT_MES_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 接收场外配废钢实绩;
        /// <summary>
        public virtual string MATCH_SCRAP_OUT_MES_ID { get; set; }
        /// <summary>
        /// 物料编号;
        /// <summary>
        public virtual string MAT_ID { get; set; }
        /// <summary>
        /// 批次号;
        /// <summary>
        public virtual string BATCH_NO { get; set; }
        /// <summary>
        /// 物料名称;
        /// <summary>
        public virtual string PRODUCT_CODE { get; set; }
        /// <summary>
        /// 物料源库位;
        /// <summary>
        public virtual string LOCATION { get; set; }
        /// <summary>
        /// 装载时间;
        /// <summary>
        public virtual string DT_LOAD { get; set; }
        /// <summary>
        /// 配料量;
        /// <summary>
        public virtual string WEIGHT_ORDERED { get; set; }
    }
}
