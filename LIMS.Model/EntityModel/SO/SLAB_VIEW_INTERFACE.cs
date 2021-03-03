using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class SLAB_VIEW_INTERFACE
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual short ID { get; set; }
        /// <summary>
        /// 辊道编号
        /// <summary>
        public virtual string ROLLER_NUM { get; set; }
        /// <summary>
        /// 辊道上辊段编号(对应货位编号)
        /// <summary>
        public virtual string ROLLER_SEG_NUM { get; set; }
        /// <summary>
        /// 铸坯编号(视觉更新)
        /// <summary>
        public virtual string SLAB_NUM { get; set; }
        /// <summary>
        /// 铸坯编号是否正常，0坯号异常，1坯号正常；
        /// <summary>
        public virtual short IS_NUM_NORMAL { get; set; }
        /// <summary>
        /// 视觉与坯库数据交互类型，默认0，1吊出，2吊入；
        /// <summary>
        public virtual short ACTION_SYMBOL { get; set; }
        /// <summary>
        /// 天车编号
        /// <summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 天车吊入辊道的铸坯编号
        /// <summary>
        public virtual string SLAB_IN_NUM { get; set; }
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
