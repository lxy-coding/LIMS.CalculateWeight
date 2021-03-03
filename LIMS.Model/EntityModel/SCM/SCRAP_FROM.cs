using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_FROM {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 批次;
        /// <summary>
        public virtual string BATCH { get; set; }
        /// <summary>
        /// 汽车牌照;
        /// <summary>
        public virtual int? CAR_ID { get; set; }
        /// <summary>
        /// 废钢种类;
        /// <summary>
        public virtual int? SCRAP_TYPE_ID { get; set; }
        /// <summary>
        /// 厂家;
        /// <summary>
        public virtual string PRODUCER { get; set; }
        /// <summary>
        /// 废钢池;
        /// <summary>
        public virtual int? SCRAP_POOL_ID { get; set; }
        /// <summary>
        /// 是否虚拟入库;
        /// <summary>
        public virtual short? IS_VIRTUAL { get; set; }
        /// <summary>
        /// 重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
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
        /// 废钢等级
        /// <summary>
        public virtual short? SCRAP_LEVEL { get; set; }
        /// <summary>
        /// 扣吨
        /// <summary>
        public virtual int? CUT_WEIGHT { get; set; }
        /// <summary>
        /// 车辆类型
        /// <summary>
        public virtual short? CAR_TYPE { get; set; }
        /// <summary>
        /// 入库时间;
        /// <summary>
        public virtual DateTime? IN_POOL_TIME { get; set; }
        /// <summary>
        /// 出库时间;
        /// <summary>
        public virtual DateTime? OUT_POOL_TIME { get; set; }
    }
}
