using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_HANG_LOG {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 起放吊标志;
        /// <summary>
        public virtual short? HANG_FLAG { get; set; }
        /// <summary>
        /// 天车;
        /// <summary>
        public virtual int? CRANE_ID { get; set; }
        /// <summary>
        /// 起放吊跨;
        /// <summary>
        public virtual int? SPA_ID { get; set; }
        /// <summary>
        /// 起放吊工位;
        /// <summary>
        public virtual int? POSITION_ID { get; set; }
        /// <summary>
        /// 起放吊位置X;
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 起放吊位置Y;
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 起放吊位置Z;
        /// <summary>
        public virtual int? CENTRE_Z { get; set; }
        /// <summary>
        /// PLC序列;
        /// <summary>
        public virtual int? PLC_ORDER { get; set; }
        /// <summary>
        /// 重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 起放吊时间;
        /// <summary>
        public virtual DateTime? HANG_TIME { get; set; }
        /// <summary>
        /// 废钢斗;
        /// <summary>
        public virtual int? SCRAP_BUCKET_ID { get; set; }
    }
}
