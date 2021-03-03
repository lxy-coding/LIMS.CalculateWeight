using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CRANE_ACTION_DEVICE {
        public CRANE_ACTION_DEVICE() { }
        /// <summary>
        /// 主键ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 缓存编号对应的数据点
        /// <summary>
        public virtual OPC_DATA_POINT BUFFER_NO_DATA_POINT_ID { get; set; }
        /// <summary>
        /// 已读缓存编号对应的数据点
        /// <summary>
        public virtual OPC_DATA_POINT BUFFER_READ_NO_DATA_POINT_ID { get; set; }
        /// <summary>
        /// 天车属性ID
        /// <summary>
        public virtual int? CRA_ID { get; set; }
        /// <summary>
        /// 备用字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 备用字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 备用字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 是否启用
        /// <summary>
        public virtual short? ENABLE { get; set; }
    }
}
