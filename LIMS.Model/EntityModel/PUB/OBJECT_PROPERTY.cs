using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class OBJECT_PROPERTY {
        public OBJECT_PROPERTY() { }
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象类型_序号; 自增
        /// <summary>
        public virtual OBJECT_TYPE OBJ_TYPE_ID { get; set; }
        /// <summary>
        /// 货/工位ID集合;
        /// <summary>
        public virtual string POSITION_ID_GATHER { get; set; }
        /// <summary>
        /// 对象编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 对象名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 对象方向; 1表示X轴方向，2表示Y轴方向
        /// <summary>
        public virtual short? DIRECTION { get; set; }
        /// <summary>
        /// 对象长度;固定为X轴方向的宽度，不管方向如何
        /// <summary>
        public virtual int? OBJ_LENGTH { get; set; }
        /// <summary>
        /// 对象宽度;固定为Y轴方向的宽度，不管方向如何
        /// <summary>
        public virtual int? WIDTH { get; set; }
        /// <summary>
        /// 对象中心X坐标;
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 对象中心Y坐标;
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 对象描述;
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
        /// 跨ID
        /// <summary>
        public virtual string SPA_ID { get; set; }
        /// <summary>
        /// 显示名称
        /// <summary>
        public virtual string DISPLAYNAME { get; set; }
        /// <summary>
        /// 层级
        /// <summary>
        public virtual short? HIERARCHY { get; set; }
        /// <summary>
        /// 数据排序
        /// <summary>
        public virtual short? DATASORT { get; set; }
        /// <summary>
        /// 是否启用(0不启用; 1启用)
        /// <summary>
        public virtual short? IS_ENABLE { get; set; }
    }
}
