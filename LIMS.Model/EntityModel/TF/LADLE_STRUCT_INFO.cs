using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_STRUCT_INFO {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 结构层编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 结构层名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 结构层厚度;
        /// <summary>
        public virtual int? THICKNESS { get; set; }
        /// <summary>
        /// 结构层半径;
        /// <summary>
        public virtual int? RADIUS { get; set; }
        /// <summary>
        /// 结构层材料;
        /// <summary>
        public virtual string MATERIAL { get; set; }
        /// <summary>
        /// 结构方向; 0径向，1轴向
        /// <summary>
        public virtual string DIRECTION { get; set; }
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
