using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 区域
    /// </summary>
    [Serializable]
    public class AREA
    {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 单跨基础_序号; 
        /// <summary>
        public virtual SPA SPA_ID { get; set; }
        /// <summary>
        /// 编号; 区域编号（唯一性约束）
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 区域属性; 1为板坯,2为方坯
        /// <summary>
        public virtual short? PROPERTY { get; set; }
        /// <summary>
        /// 跨类型; 
        /// <summary>
        public virtual short? TYPE { get; set; }
        /// <summary>
        /// 跨长度; X方向CAD值，单位：毫米
        /// <summary>
        public virtual int? LENGTH { get; set; }
        /// <summary>
        /// 跨宽度; Y方向CAD值，单位：毫米
        /// <summary>
        public virtual int? WIDTH { get; set; }
        /// <summary>
        /// 跨高度; Z方向，单位：毫米
        /// <summary>
        public virtual int? HEIGHT { get; set; }
        /// <summary>
        /// 最小X; 天车能够运行运行的最小X，单位：毫米
        /// <summary>
        public virtual int? MIN_X { get; set; }
        /// <summary>
        /// 最小Y; 天车能够运行运行的最小Y，单位：毫米
        /// <summary>
        public virtual int? MIN_Y { get; set; }
        /// <summary>
        /// 最小Z; 天车能够运行运行的最小Z，单位：毫米
        /// <summary>
        public virtual int? MIN_Z { get; set; }
        /// <summary>
        /// 方向; 1为X，2为Y
        /// <summary>
        public virtual short? DIRE { get; set; }
        /// <summary>
        /// 排序序号; 区域排序，查询时，哪个区域哪个位置，1表示最前
        /// <summary>
        public virtual short? ORDER_ID { get; set; }
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
