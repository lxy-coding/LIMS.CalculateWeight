using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CHECK_MAP {
        /// <summary>
        /// 主键
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 校验大类序号
        /// <summary>
        public virtual int? CHECK_BIG_SN { get; set; }
        /// <summary>
        /// 校验小类序号
        /// <summary>
        public virtual int? CHECK_LITTLE_SN { get; set; }
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
