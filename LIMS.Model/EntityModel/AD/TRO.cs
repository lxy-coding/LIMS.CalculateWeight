using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class TRO {
        /// <summary>
        /// 台车ID
        /// <summary>
        public virtual int TRO_ID { get; set; }
        /// <summary>
        /// 最大总重，单位，千克
        /// <summary>
        public virtual int? MAX_WEIGHT { get; set; }
        /// <summary>
        /// 最大速度，单位，毫米每分钟
        ///
        /// <summary>
        public virtual int? MAX_SPEED { get; set; }
        /// <summary>
        /// 平均速度，单位，毫米每分钟
        ///
        /// <summary>
        public virtual int? AVE_SPEED { get; set; }
        /// <summary>
        /// 台车X方向最大地址，毫米
        /// <summary>
        public virtual int? UP_LIMIT_X { get; set; }
        /// <summary>
        /// 台车X方向最小地址，毫米
        /// <summary>
        public virtual int? DOWN_LIMIT_X { get; set; }
        /// <summary>
        /// 台车Y方向最大地址，毫米
        /// <summary>
        public virtual int? UP_LIMIT_Y { get; set; }
        /// <summary>
        /// 台车Y方向最小地址，毫米
        /// <summary>
        public virtual int? DOWN_LIMIT_Y { get; set; }
        /// <summary>
        /// 台车Z方向最大地址，毫米
        /// <summary>
        public virtual int? UP_LIMIT_Z { get; set; }
        /// <summary>
        /// 台车Z方向最小地址，毫米
        /// <summary>
        public virtual int? DOWN_LIMIT_Z { get; set; }
        /// <summary>
        /// 载重包速度，毫米每分钟
        ///
        /// <summary>
        public virtual int? HEAVY_SPEED { get; set; }
        /// <summary>
        /// 载空包速度，毫米每分钟
        ///
        /// <summary>
        public virtual int? SLIGHT_SPEED { get; set; }
        /// <summary>
        /// 空载速度，毫米每分钟
        ///
        /// <summary>
        public virtual int? EMPTY_SPEED { get; set; }
        /// <summary>
        /// 台车运载基准重量
        /// <summary>
        public virtual int? BASE_WEGHTI { get; set; }
        /// <summary>
        /// 台车运行方向：1为X，2为Y
        /// <summary>
        public virtual short? DIRC { get; set; }
    }
}
