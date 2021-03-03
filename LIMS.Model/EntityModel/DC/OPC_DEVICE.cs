using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class OPC_DEVICE {
        public OPC_DEVICE() { }
        /// <summary>
        /// 主键ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 编号
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// IP地址
        /// <summary>
        public virtual string IP_ADDRESS { get; set; }
        /// <summary>
        /// MAC地址
        /// <summary>
        public virtual string MAC_ADDRESS { get; set; }
        /// <summary>
        /// 启用
        /// <summary>
        public virtual short? ENABLE { get; set; }
        /// <summary>
        /// 备注
        /// <summary>
        public virtual string REMARK { get; set; }
        /// <summary>
        /// 备用1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 备用2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 备用3
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 通道
        /// <summary>
        public virtual string CHANNEL { get; set; }
        /// <summary>
        /// 连接
        /// <summary>
        public virtual string S7CONNECTION { get; set; }
    }
}
