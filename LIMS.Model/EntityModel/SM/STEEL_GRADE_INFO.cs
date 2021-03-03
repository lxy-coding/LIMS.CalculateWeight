using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 钢包钢种
    /// </summary>

    [Serializable]
    public class STEEL_GRADE_INFO
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 编号
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称
        /// <summary>
        public virtual string NAM { get; set; }
        /// <summary>
        /// 备注
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
    }
}
