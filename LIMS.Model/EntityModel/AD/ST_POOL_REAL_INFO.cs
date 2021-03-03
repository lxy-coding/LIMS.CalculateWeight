using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_POOL_REAL_INFO {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢种类;
        /// <summary>
        public virtual int? SCRAP_TYPE_ID { get; set; }
        /// <summary>
        /// 废钢重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 所在跨ID;
        /// <summary>
        public virtual int? SPA_ID { get; set; }
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
        public virtual DateTime? UPDATE_TIME { get; set; }
    }
}
