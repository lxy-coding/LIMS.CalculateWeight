using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class ROLLER_BED_RUN_RECORD
    {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 对象ID;
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 重量; 单位kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 对象状态ID; 逻辑关联对象状态表
        /// <summary>
        public virtual int? DEVICE_STATUS_ID { get; set; }
        /// <summary>
        /// 是否在线; 0不在线1在线
        /// <summary>
        public virtual short? IS_ONLINE { get; set; }
        /// <summary>
        /// 读取标志; 0未读1已读
        /// <summary>
        public virtual short? READ_FLAG { get; set; }
        /// <summary>
        /// 承载坯号;
        /// <summary>
        public virtual string STEEL { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 创建时间; yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
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
