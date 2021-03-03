using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CRANE_ACTION_CONFIG {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 缓存数据点ID;
        /// <summary>
        public virtual OPC_DATA_POINT BUFFER_DATA_POINT_ID { get; set; }
        /// <summary>
        /// 天车动作设备ID
        /// <summary>
        public virtual CRANE_ACTION_DEVICE CRANE_ACTION_DEVICE_ID { get; set; }
        /// <summary>
        /// 字段名;
        /// <summary>
        public virtual string FIELD_NAME { get; set; }
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
        /// 字段数据类型;
        /// <summary>
        public virtual string FIELD_DATA_TYPE { get; set; }
        /// <summary>
        /// 字段数据长度
        /// <summary>
        public virtual short? FIELD_DATA_LENGTH { get; set; }
    }
}
