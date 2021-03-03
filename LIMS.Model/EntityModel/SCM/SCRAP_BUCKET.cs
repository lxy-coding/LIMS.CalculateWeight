using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_BUCKET {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 废钢斗编号;
        /// <summary>
        public virtual string CODE { get; set; }
        /// <summary>
        /// 废钢斗名称;
        /// <summary>
        public virtual string NAME { get; set; }
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
        /// 总使用次数;
        /// <summary>
        public virtual int? TOTAL_USE_COUNT { get; set; }
        /// <summary>
        /// 维修后使用次数;
        /// <summary>
        public virtual int? REPAIR_USE_COUNT { get; set; }
        /// <summary>
        /// 状态;
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 是否启用;
        /// <summary>
        public virtual short? IS_ENABLE { get; set; }
        /// <summary>
        /// 额定重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
    }
}
