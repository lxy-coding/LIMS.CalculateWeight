using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 车间
    /// </summary>
    [Serializable]
    public class WSP
    {
        public WSP() { }
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 车间编号; 唯一性约束
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 车间名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 跨长度; X方向CAD值，单位：毫米
        /// <summary>
        public virtual int LENGTH { get; set; }
        /// <summary>
        /// 跨宽度; Y方向CAD值，单位：毫米
        /// <summary>
        public virtual int WIDTH { get; set; }
        /// <summary>
        /// 跨高度; Z方向，单位：毫米
        /// <summary>
        public virtual int HEIGHT { get; set; }
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
