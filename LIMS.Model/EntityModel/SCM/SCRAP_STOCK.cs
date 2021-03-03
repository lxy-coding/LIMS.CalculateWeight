using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_STOCK {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢池;
        /// <summary>
        public virtual int? SCRAP_POOL_ID { get; set; }
        /// <summary>
        /// 废钢种类;
        /// <summary>
        public virtual int? SCRAP_TYPE_ID { get; set; }
        /// <summary>
        /// 废钢等级;
        /// <summary>
        public virtual short? SCRAP_LEVEL { get; set; }
        /// <summary>
        /// 废钢重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
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
    }
}
