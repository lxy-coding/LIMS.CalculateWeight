using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_POOL {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 废钢种类ID;
        /// <summary>
        public virtual int? SCRAP_TYPE_ID { get; set; }
        /// <summary>
        /// 废钢池名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 废钢池编号;
        /// <summary>
        public virtual string CODE { get; set; }
        /// <summary>
        /// 所在跨区;
        /// <summary>
        public virtual int? SPA_ID { get; set; }
        /// <summary>
        /// 长;
        /// <summary>
        public virtual int? LENGTH { get; set; }
        /// <summary>
        /// 宽;
        /// <summary>
        public virtual int? WIDTH { get; set; }
        /// <summary>
        /// 高;
        /// <summary>
        public virtual int? HEIGHT { get; set; }
        /// <summary>
        /// 中心坐标X;
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 中心坐标Y;
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 废钢重量下限;
        /// <summary>
        public virtual int? DOWN_WEIGHT { get; set; }
        /// <summary>
        /// 废钢重量上限;
        /// <summary>
        public virtual int? UP_WEIGHT { get; set; }
        /// <summary>
        /// 库存总量
        /// <summary>
        public virtual long? STOCK_TOTAL { get; set; }
        /// <summary>
        /// WST表ID;
        /// <summary>
        public virtual int? WST_ID { get; set; }
    }
}
