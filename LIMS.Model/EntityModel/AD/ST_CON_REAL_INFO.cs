using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_CON_REAL_INFO {
        public virtual int ID { get; set; }
        /// <summary>
        /// 1、钢包2、铁包3、废钢斗
        /// <summary>
        public virtual short? CON_TYPE { get; set; }
        public virtual int? POSITION_ID { get; set; }
        public virtual int? COORD_X { get; set; }
        public virtual int? COORD_Y { get; set; }
        /// <summary>
        /// 负载标志;1空包，2重包
        /// <summary>
        public virtual short? LOAD_FLAG { get; set; }
        /// <summary>
        /// 0不可用，1可用
        /// <summary>
        public virtual short? AVL_FLAG { get; set; }
        /// <summary>
        /// 0未占用，1占用
        /// <summary>
        public virtual short? USE_FLAG { get; set; }
        public virtual double? TEMP { get; set; }
        public virtual string THERMAL_STATUS { get; set; }
        public virtual DateTime? UPDATE_TIME { get; set; }
    }
}
