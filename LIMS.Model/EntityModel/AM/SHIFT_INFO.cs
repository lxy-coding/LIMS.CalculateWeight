using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 班次表
    /// </summary>
    [Serializable]
    public class SHIFT_INFO
    {
        /// <summary>
        /// id
        /// <summary>
        public virtual decimal ID { get; set; }
        /// <summary>
        /// 编码
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 开始时间，保存格式：HH:MI
        /// <summary>
        public virtual string START_TIME { get; set; }
        /// <summary>
        /// 结束时间，保存格式：HH:MI
        /// <summary>
        public virtual string END_TIME { get; set; }
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
