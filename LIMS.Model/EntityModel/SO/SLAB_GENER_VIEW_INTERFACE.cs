using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class SLAB_GENER_VIEW_INTERFACE
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual short ID2 { get; set; }
        /// <summary>
        /// 辊道编号
        /// <summary>
        public virtual string ROLLER_NUM { get; set; }
        /// <summary>
        /// 铸坯编号(视觉更新)
        /// <summary>
        public virtual string SLAB_NUM { get; set; }
        /// <summary>
        /// 读写标志，坯号生成写0，视觉读取写1
        /// <summary>
        public virtual short R_FLAG { get; set; }
        /// <summary>
        /// 备用字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 备用字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 备用字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
