using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class OPC_REAL_DATA {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 数据点表ID;
        /// <summary>
        public virtual int DATA_POINT_ID { get; set; }
        /// <summary>
        /// 值;
        /// <summary>
        public virtual string VALUE { get; set; }
        /// <summary>
        /// 质量;
        /// <summary>
        public virtual string QUALITY { get; set; }
        /// <summary>
        /// 时间戳;
        /// <summary>
        public virtual DateTime? STAMP { get; set; }
        /// <summary>
        /// 更新时间;
        /// <summary>
        public virtual DateTime? UPDATE_TIME { get; set; }
        /// <summary>
        /// 是否更新;0：未更新；1：已更新
        ///
        /// <summary>
        public virtual short? UPDATED { get; set; }
        /// <summary>
        /// 读取时间;
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
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
    }
}
