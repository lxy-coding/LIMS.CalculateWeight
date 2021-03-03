using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 临时容器
    /// </summary>
    [Serializable]

    public class TEMP_CON
    {
        /// <summary>
        /// 主键，GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 临时包类型;;参照对象类型ID
        /// <summary>
        public virtual short? CON_TYPE { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 计划号;
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 位置;
        /// <summary>
        public virtual string POSIT { get; set; }
        /// <summary>
        /// X坐标;mm
        /// <summary>
        public virtual int? COORD_X { get; set; }
        /// <summary>
        /// Y坐标;mm
        /// <summary>
        public virtual int? COORD_Y { get; set; }
        /// <summary>
        /// Z坐标;mm
        /// <summary>
        public virtual int? COORD_Z { get; set; }
        /// <summary>
        /// 毛重;kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 创建时间;
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
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
