using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class OPC_DATA_POINT {
        public OPC_DATA_POINT() { }
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// OPC设备ID;
        /// <summary>
        public virtual OPC_DEVICE OPC_DEVICE_ID { get; set; }
        /// <summary>
        /// 编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 内存地址;
        /// <summary>
        public virtual string MEMORY_ADDRESS { get; set; }
        /// <summary>
        /// 是否订阅;0：不订阅；1：订阅
        ///
        /// <summary>
        public virtual short? SUBSCRIPTION { get; set; }
        /// <summary>
        /// 最大值;
        /// <summary>
        public virtual string MAX_VALUE { get; set; }
        /// <summary>
        /// 最小值;
        /// <summary>
        public virtual string MIN_VALUE { get; set; }
        /// <summary>
        /// 数据类型;
        /// <summary>
        public virtual short? DATA_TYPE { get; set; }
        /// <summary>
        /// 启用;
        /// <summary>
        public virtual short? ENABLE { get; set; }
        /// <summary>
        /// 备注;
        /// <summary>
        public virtual string REMARK { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 值;
        /// <summary>
        public virtual object VALUE { get; set; }
        /// <summary>
        /// 旧值;
        /// <summary>
        public virtual object OLE_VALUE { get; set; }
    }
}
