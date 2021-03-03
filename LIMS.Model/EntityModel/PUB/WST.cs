using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class WST {
        public WST() { }
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 单跨基础_序号; 
        /// <summary>
        public virtual SPA SPA_ID { get; set; }
        /// <summary>
        /// 对象ID; 逻辑关联对象表
        /// <summary>
        // public virtual int? OBJ_ID { get; set; }
        public virtual OBJECT_PROPERTY OBJ_ID { get; set; }
        /// <summary>
        /// 工位编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 工位名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 工位长度; 人工测量，单位mm
        /// <summary>
        public virtual int? POSITION_LENGTH { get; set; }
        /// <summary>
        /// 工位宽度; 人工测量，单位mm
        /// <summary>
        public virtual int? WIDTH { get; set; }
        /// <summary>
        /// 中心点坐标X; 人工测量，单位mm
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 中心点坐标Y; 人工测量，单位mm
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
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
        /// 
        /// <summary>
        public virtual string SHORT_NAME { get; set; }

    }
}
