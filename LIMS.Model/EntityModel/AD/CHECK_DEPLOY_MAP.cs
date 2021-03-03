using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CHECK_DEPLOY_MAP {
        /// <summary>
        /// 主键
        /// <summary>
        public virtual long ID { get; set; }
        /// <summary>
        /// 上层类ID
        /// <summary>
        public virtual CHECK_TOP_CLASS TOP_ID { get; set; }
        /// <summary>
        /// 底层类ID
        /// <summary>
        public virtual CHECK_BOTTOM_CLASS BOTTOM_ID { get; set; }
        /// <summary>
        /// 算子ID集合，多个用 ; 连接
        /// <summary>
        public virtual string OPERATOR_ID_GATHER { get; set; }
        /// <summary>
        /// 是否启用：0为非，1为是
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
