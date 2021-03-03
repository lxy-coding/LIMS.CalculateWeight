using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class WH_POSITION_REAL_INFO {
        /// <summary>
        /// 货位ID
        /// <summary>
        public virtual int POSITION_ID { get; set; }
        public virtual int? ID { get; set; }
        /// <summary>
        /// 不可用状态：1为是 0为否
        /// <summary>
        public virtual short? POSITION_NO_STUS { get; set; }
        /// <summary>
        /// 板坯序列号：描述当前垛位从下至上所有板坯编号
        /// <summary>
        public virtual string SLAB_SN_LIST { get; set; }
        /// <summary>
        /// 中心点坐标X;
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 中心点坐标Y;
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 最大长度
        /// <summary>
        public virtual int? MAX_LENGTH { get; set; }
        /// <summary>
        /// 最小长度
        /// <summary>
        public virtual int? MIN_LENGTH { get; set; }
        /// <summary>
        /// 最大宽度
        /// <summary>
        public virtual int? MAX_WIDTH { get; set; }
        /// <summary>
        /// 最小宽度
        /// <summary>
        public virtual int? MIN_WIDTH { get; set; }
        /// <summary>
        /// 最大厚度
        /// <summary>
        public virtual int? MAX_THICKNESS { get; set; }
        /// <summary>
        /// 最小厚度
        /// <summary>
        public virtual int? MIN_THICKNESS { get; set; }
        /// <summary>
        /// 当前层数
        /// <summary>
        public virtual short? LAYER { get; set; }
        /// <summary>
        /// 当前高度
        /// <summary>
        public virtual int? HEIGHT { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FILED1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FILED2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FILED3 { get; set; }
        /// <summary>
        /// 货位限高;
        /// <summary>
        public virtual int? POSITION_LIMIT_HEIGHT { get; set; }
        public virtual DateTime? UPDATE_TIME { get; set; }
    }
}
