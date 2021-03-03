using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 位置标定
    /// </summary>

    [Serializable]
    public class POSITION_COLLECT
    {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 跨ID;
        /// <summary>
        public virtual SPA SPA_ID { get; set; }
        /// <summary>
        /// 区域ID;
        /// <summary>
        public virtual AREA AREA_ID { get; set; }
        /// <summary>
        /// 对象类型;1工位2货位
        /// <summary>
        public virtual OBJECT_TYPE OBJECT_TYPE { get; set; }
        /// <summary>
        /// 货/工位ID;
        /// <summary>
        public virtual int? POSITION_ID { get; set; }
        /// <summary>
        /// 货/工位长度;
        /// <summary>
        public virtual int? POSITION_LENGTH { get; set; }
        /// <summary>
        /// 货/工位宽度;
        /// <summary>
        public virtual int? POSITION_WIDTH { get; set; }
        /// <summary>
        /// 货/工位限高; 人工测量，单位mm
        /// <summary>
        public virtual int? POSITION_LIMIT_HEIGHT { get; set; }
        /// <summary>
        /// 中心点坐标X; 人工测量，单位mm
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 中心点坐标Y; 人工测量，单位mm
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 采集时间; yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? COLLECT_TIME { get; set; }
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
