using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 铁水包管理信息
    /// </summary>
    [Serializable]
    public class HML_MANAGEMENT_INFO
    {
        /// <summary>
        /// 序号，GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 车辆编号
        /// <summary>
        public virtual string VEHICLE_NUM { get; set; }
        /// <summary>
        /// 铁包编号
        /// <summary>
        public virtual string HML_NUM { get; set; }
        /// <summary>
        /// 轨道编号
        /// <summary>
        public virtual string TRACK_NUM { get; set; }
        /// <summary>
        /// 操作类型，1入库，2出库
        /// <summary>
        public virtual short? OPERATION_TYPE { get; set; }
        /// <summary>
        /// 是否自动入库，0否，1是
        /// <summary>
        public virtual short? IS_AUTO_IN { get; set; }
        /// <summary>
        /// 人员ID
        /// <summary>
        public virtual int? OPERATOR { get; set; }
        /// <summary>
        /// 记录生成时间
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
