using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class FEEDER_RUN_RECORD {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 对象ID; 逻辑关联对象表
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 重量; 单位kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 数量;
        /// <summary>
        public virtual short? COUNT { get; set; }
        /// <summary>
        /// 作业状态ID; 逻辑关联对象状态表
        /// <summary>
        public virtual int? WORK_STATUS_ID { get; set; }
        /// <summary>
        /// 对象状态ID; 逻辑关联对象状态表
        /// <summary>
        public virtual int? OBJ_STATUS_ID { get; set; }
        /// <summary>
        /// 是否在线; 0不在线1在线
        /// <summary>
        public virtual int? IS_ONLINE { get; set; }
        /// <summary>
        /// 读取标志; 0未读1已读
        /// <summary>
        public virtual short? READ_FLAG { get; set; }
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
