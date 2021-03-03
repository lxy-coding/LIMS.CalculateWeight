using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class STEEL_STOCK {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 坯料号;
        /// <summary>
        public virtual string STEEL_NUM { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 货位ID;
        /// <summary>
        public virtual int? POSITION_ID { get; set; }
        /// <summary>
        /// 层;
        /// <summary>
        public virtual short? LAYER { get; set; }
        /// <summary>
        /// 库存状态; (0出库；1待确认出库状态； 2待核查； 3在库房)
        /// <summary>
        public virtual short? STOCK_STATE { get; set; }
        /// <summary>
        /// 中心坐标X;
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 中心坐标Y;
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 中心坐标Z;
        /// <summary>
        public virtual int? CENTRE_Z { get; set; }
        /// <summary>
        /// 单层排序号;
        /// <summary>
        public virtual short? LAYER_SORT_NO { get; set; }
        /// <summary>
        /// 旋转值;
        /// <summary>
        public virtual short? ROTATE { get; set; }
        /// <summary>
        /// 是否核准;
        /// <summary>
        public virtual short? IS_CHECK_RIGHT { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
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
        /// 外购坯号;
        /// <summary>
        public virtual string OUTSOURCING_STEEL_NUM { get; set; }
        /// <summary>
        /// 入库时间;
        /// <summary>
        public virtual DateTime? STORAGE_TIME { get; set; }
        /// <summary>
        /// 记录时间;
        /// <summary>
        public virtual DateTime? RECORD_TIME { get; set; }
    }
}
