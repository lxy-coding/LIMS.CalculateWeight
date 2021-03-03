using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 烘烤工艺
    /// </summary>
    [Serializable]
    public class BAKE_CRAFT
    {
        /// <summary>
        /// 序号;主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 修包类型;对象状态ID
        /// <summary>
        public virtual int? MAINTAIN_TYPE { get; set; }
        /// <summary>
        /// 小火时长(分钟);min
        /// <summary>
        public virtual short? MINFIRE_TIME { get; set; }
        /// <summary>
        /// 中火时长(分钟);min
        /// <summary>
        public virtual short? MEDIUMFIRE_TIME { get; set; }
        /// <summary>
        /// 大火时长(分钟);min
        /// <summary>
        public virtual short? MAXFIRE_TIME { get; set; }
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
