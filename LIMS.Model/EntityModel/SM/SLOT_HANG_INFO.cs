using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SLOT_HANG_INFO {
        /// <summary>
        /// 主键ID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢斗编号
        /// <summary>
        public virtual string SLOT_NUM { get; set; }
        /// <summary>
        /// 单号
        /// <summary>
        public virtual string REFE_ID { get; set; }
        /// <summary>
        /// 1入厂，2加料，3倒跨，4出厂
        /// <summary>
        public virtual short? STATE { get; set; }
        /// <summary>
        /// 运行路径
        /// <summary>
        public virtual string PATH { get; set; }
        /// <summary>
        /// 是否去了转炉加料
        /// <summary>
        public virtual short? IS_ADD { get; set; }
        /// <summary>
        /// 是否出厂
        /// <summary>
        public virtual short? IS_OUT { get; set; }
        /// <summary>
        /// 倒跨次数
        /// <summary>
        public virtual short? CROSS_SPA_COUNT { get; set; }
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
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
