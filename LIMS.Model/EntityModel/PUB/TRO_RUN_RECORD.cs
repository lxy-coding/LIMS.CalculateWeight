using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 台车运行记录
    /// </summary>
    [Serializable]
    public class TRO_RUN_RECORD
    {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 台车属性_序号;
        /// <summary>
        public virtual TROLLEY TRO_ID { get; set; }
        /// <summary>
        /// X坐标; 传感器测量值X，单位：毫米
        /// <summary>
        public virtual int? COORD_X { get; set; }
        /// <summary>
        /// Y坐标; 传感器测量值Y，单位：毫米
        /// <summary>
        public virtual int? COORD_Y { get; set; }
        /// <summary>
        /// 副勾Y坐标; 传感器测量值Z，单位：毫米
        /// <summary>
        public virtual int? LITTLE_HOOK_Y { get; set; }
        /// <summary>
        /// 载物重量; 传感器测量总重量，单位：千克
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 载重标志; 0为空载，1为空包，2为重包
        /// <summary>
        public virtual short LOAD_SYMBOL { get; set; }
        /// <summary>
        /// 坯料号集合; 对应鞍座工位,用，隔开（AAA，，BBB）第一个坯号AA，第二位空，第三个BBB
        /// <summary>
        public virtual string STEEL_CODE_GATHER { get; set; }
        /// <summary>
        /// 炉次号; 
        /// <summary>
        public virtual string HEAT_CODE { get; set; }
        /// <summary>
        /// 作业状态;
        /// <summary>
        public virtual short? WORK_STATE { get; set; }
        /// <summary>
        /// 是否在线; 0不在线1在线
        /// <summary>
        public virtual short? IS_ONLINE { get; set; }
        /// <summary>
        /// 对象状态ID; 逻辑关联对象状态表
        /// <summary>
        public virtual short? OBJ_STATUS_ID { get; set; }
        /// <summary>
        /// 生成时间; yyyy-mm-dd hh24:mi:ss
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
