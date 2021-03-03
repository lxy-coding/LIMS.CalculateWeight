using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 跨
    /// </summary>
    [Serializable]
    public class SPA
    {
        public SPA() { }
        /// <summary>
        /// 序号; ，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 车间基础_序号; ，自增
        /// <summary>
        public virtual WSP WSP_ID { get; set; }
        /// <summary>
        /// 跨编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 一跨线ID; 逻辑关联对象ID
        /// <summary>
        public virtual int? SPA_LINE1_ID { get; set; }
        /// <summary>
        /// 二跨线ID; 逻辑关联对象ID
        /// <summary>
        public virtual int? SPA_LINE2_ID { get; set; }
        /// <summary>
        /// 跨名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 对象类型ID; 逻辑关联对象ID
        /// <summary>
        public virtual int OBJ_TYPE_ID { get; set; }
        /// <summary>
        /// 长; 
        /// <summary>
        public virtual int? SPA_LENGTH { get; set; }
        /// <summary>
        /// 宽;
        /// <summary>
        public virtual int? WIDTH { get; set; }
        /// <summary>
        /// 高;
        /// <summary>
        public virtual int? HEIGHT { get; set; }
        /// <summary>
        /// 最大X; 天车能够运行运行的最大X，单位：毫米
        /// <summary>
        public virtual int? MAX_X { get; set; }
        /// <summary>
        /// 最大Y; 天车能够运行运行的最大Y，单位：毫米
        /// <summary>
        public virtual int? MAX_Y { get; set; }
        /// <summary>
        /// 最大Z; 天车能够运行运行的最大Z，单位：毫米
        /// <summary>
        public virtual int? MAX_Z { get; set; }
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
