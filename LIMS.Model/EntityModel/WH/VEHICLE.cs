using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class VEHICLE
    {
        public VEHICLE() { }
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象ID; 逻辑关联对象表
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 车牌号; 
        /// <summary>
        public virtual string VEHICLE_NUM { get; set; }
        /// <summary>
        /// 车辆名称; 
        /// <summary>
        public virtual string VEHICLE_NAME { get; set; }
        /// <summary>
        /// 车辆类型; 
        /// <summary>
        public virtual short? VEHICLE_TYPE { get; set; }
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
    }
}
