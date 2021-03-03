using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CLASS_SEQUENCE_MAP {
        /// <summary>
        /// 主键，当为0时，类类型为上层类；为其他数据时，类类型为底层类
        /// <summary>
        public virtual int TOP_ID { get; set; }
        /// <summary>
        /// 类类型： 0 上层类 1 底层类
        /// <summary>
        public virtual short? CLASS_TYPE { get; set; }
        /// <summary>
        /// 类ID集合：类类型为0时为上层类集合，类类型为1时为底层类集合
        /// <summary>
        public virtual string CHECK_LITTLE_SN { get; set; }
        /// <summary>
        /// 注释
        /// <summary>
        public virtual string ANNOTATION { get; set; }
        /// <summary>
        /// 是否启用
        /// <summary>
        public virtual short? IS_ENABLE { get; set; }
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
    }
}
