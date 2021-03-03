using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class POSITION {
        public POSITION() { }
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 区域ID;
        /// <summary>
        public virtual int? AREA_ID { get; set; }
        /// <summary>
        /// 货位编号;
        /// <summary>
        public virtual string POSITION_NUM { get; set; }
        /// <summary>
        /// 货位名称;
        /// <summary>
        public virtual string POSITION_NAME { get; set; }
        /// <summary>
        /// 货位长度;
        /// <summary>
        public virtual int? POSITION_LENGTH { get; set; }
        /// <summary>
        /// 货位宽度;
        /// <summary>
        public virtual int? POSITION_WIDTH { get; set; }
        /// <summary>
        /// 货位限高;
        /// <summary>
        public virtual int? POSITION_LIMIT_HEIGHT { get; set; }
        /// <summary>
        /// 中心点坐标X;
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 中心点坐标Y;
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 是否可用;（0为不可用，1为可用）
        /// <summary>
        public virtual short? IS_ENABLE { get; set; }
        /// <summary>
        /// 是否显示;（0为不显示，1为显示）
        /// <summary>
        public virtual short? IS_DISPLAY { get; set; }
        /// <summary>
        /// 行排序;
        /// <summary>
        public virtual short? ORDER_ROW { get; set; }
        /// <summary>
        /// 列排序;
        /// <summary>
        public virtual short? ORDER_COLUMN { get; set; }
        /// <summary>
        /// 层排序;
        /// <summary>
        public virtual short? ORDER_LAYER { get; set; }
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
        /// 货位内长度(计算旋转值);
        /// <summary>
        public virtual int? INNER_LENGTH { get; set; }
        /// <summary>
        /// 货位内宽度(计算旋转值);
        /// <summary>
        public virtual int? INNER_WIDTH { get; set; }
    }
}
