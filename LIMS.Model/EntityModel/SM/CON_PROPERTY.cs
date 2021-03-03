using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 容器属性
    /// </summary>
    [Serializable]
    public class CON_PROPERTY
    {
        public CON_PROPERTY() { }
        /// <summary>
        /// 序号;主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 毛重;空包重量，kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 外径;外部直径，mm
        /// <summary>
        public virtual int? EXTERNAL_DIAM { get; set; }
        /// <summary>
        /// 内径;内部直径，mm
        /// <summary>
        public virtual int? INTERNAL_DIAM { get; set; }
        /// <summary>
        /// 高度;mm
        /// <summary>
        public virtual int? HEIGHT { get; set; }
        /// <summary>
        /// 长度;mm
        /// <summary>
        public virtual int? LENGTH { get; set; }
        /// <summary>
        /// 宽度;mm
        /// <summary>
        public virtual int? WIDTH { get; set; }
        /// <summary>
        /// 额定载重;kg
        /// <summary>
        public virtual int? RATE_WEIGHT { get; set; }
        /// <summary>
        /// 最大载重;kg
        /// <summary>
        public virtual int? MAX_WEIGHT { get; set; }
        /// <summary>
        /// 是否启用;0未启用，1启用
        /// <summary>
        public virtual short? IS_ENABLE { get; set; }
        /// <summary>
        /// 预留字段1;存储容器类型，参照对象类型ID
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
        /// 显示名称
        /// <summary>
        public virtual string DISPLAYNAME { get; set; }
    }
}
