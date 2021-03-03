using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_MAIN_STAGE {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 阶段名称;
        /// <summary>
        public virtual string STAGE_NAM { get; set; }
        /// <summary>
        /// 阶段编号;
        /// <summary>
        public virtual string STAGE_NUM { get; set; }
        /// <summary>
        /// 是否启用;0未启用，1启用
        /// <summary>
        public virtual short IS_ENABLE { get; set; }
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
