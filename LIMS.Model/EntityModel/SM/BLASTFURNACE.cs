using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 高炉铁水
    /// </summary>
    [Serializable]
    public class BLASTFURNACE
    {
        /// <summary>
        /// ID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 铁次号
        /// <summary>
        public virtual string IRONTIMESNUM { get; set; }
        /// <summary>
        /// 铁包号
        /// <summary>
        public virtual string IRONCONNUM { get; set; }
        /// <summary>
        /// 铁水温度（单位℃）
        /// <summary>
        public virtual short? IRONTEMP { get; set; }
        /// <summary>
        /// 铁水重量（单位kg）
        /// <summary>
        public virtual int? IRONWEIGHT { get; set; }
        /// <summary>
        /// 铁水成分
        /// <summary>
        public virtual string IRONCOMPOSITION { get; set; }
        /// <summary>
        /// 过磅时间
        /// <summary>
        public virtual DateTime? WEIGHINGTIME { get; set; }
        /// <summary>
        /// 插入时间
        /// <summary>
        public virtual DateTime? RECORDINGTIME { get; set; }
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
        /// <summary>
        /// 状态
        /// <summary>
        public virtual short? STATE { get; set; }
    }
}
