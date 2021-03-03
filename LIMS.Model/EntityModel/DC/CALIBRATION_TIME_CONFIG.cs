using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CALIBRATION_TIME_CONFIG {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 天车时间;
        /// <summary>
        public virtual OPC_DATA_POINT CALIBRATION_TIME_DATA_POINT_ID { get; set; }
        /// <summary>
        /// 天车时间写入标志;
        /// <summary>
        public virtual OPC_DATA_POINT CALIBRATION_WRITE_SYMBOL_DATA_POINT_ID { get; set; }
        /// <summary>
        /// 是否启用;
        /// <summary>
        public virtual short? ENABLE { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 天车ID
        /// <summary>
        public virtual int? CRA_ID { get; set; }
    }
}
