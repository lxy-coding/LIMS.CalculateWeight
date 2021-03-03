using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_STAGE_TEMP_DROP {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 温降值名称;
        /// <summary>
        public virtual string DROP_NAM { get; set; }
        /// <summary>
        /// 温降值编号;
        /// <summary>
        public virtual string DROP_NUM { get; set; }
        /// <summary>
        /// 温降值; 带符号 单位 K/min
        /// <summary>
        public virtual double DROP_VALUE { get; set; }
        /// <summary>
        /// 所属主阶段ID;
        /// <summary>
        public virtual int MAIN_STAGE_ID { get; set; }
        /// <summary>
        /// 所属子阶段ID;
        /// <summary>
        public virtual int SUB_STAGE_ID { get; set; }
        /// <summary>
        /// 是否启用; 0未启用，1启用
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
