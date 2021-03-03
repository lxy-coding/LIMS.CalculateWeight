using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 连铸回转记录
    /// </summary>
    [Serializable]

    public class CCM_TURRET_RECORD
    {
        /// <summary>
        /// 序号，主键，GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 序号，外键，铸机属性表ID
        /// <summary>
        public virtual int? CCM_ID { get; set; }
        /// <summary>
        /// A臂浇铸
        /// <summary>
        public virtual short? ARMACASTPOS { get; set; }
        /// <summary>
        /// B臂浇铸
        /// <summary>
        public virtual short? ARMBCASTPOS { get; set; }
        /// <summary>
        /// 正在浇铸
        /// <summary>
        public virtual string CASTING_FALG { get; set; }
        /// <summary>
        /// 记录生成时间
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
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
