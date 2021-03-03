using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_BUCKET_LOG {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢斗;
        /// <summary>
        public virtual int? SCRAP_BUCKET_ID { get; set; }
        /// <summary>
        /// 废钢余量;
        /// <summary>
        public virtual int? REMAIN_WEIGHT { get; set; }
        /// <summary>
        /// 废钢种类比例;
        /// <summary>
        public virtual string RATIO_OF_SCRAP { get; set; }
        /// <summary>
        /// 中心坐标X;
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 中心坐标Y;
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 总重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
    }
}
