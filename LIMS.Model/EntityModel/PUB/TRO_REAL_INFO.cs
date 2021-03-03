using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 台车实时表
    /// </summary>
    [Serializable]
    public class TRO_REAL_INFO
    {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 台车属性_序号; 自增
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
        /// Z坐标;
        /// <summary>
        public virtual int? COORD_Z { get; set; }
        /// <summary>
        /// 重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 载重标志; 0为空载，1为空包，2为重包
        /// <summary>
        public virtual short LOAD_SYMBOL { get; set; }
        /// <summary>
        /// 坯料号集合; 对应鞍座工位,用，隔开（AAA，，BBB）第一个坯号AA，第二位空，第三个BBB
        /// <summary>
        public virtual string STEEL_NUM_GATHER { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 作业状态ID; 逻辑关联对象状态表
        /// <summary>
        public virtual int? WORK_STATE_ID { get; set; }
        /// <summary>
        /// 是否在线; 0不在线1在线
        /// <summary>
        public virtual short? IS_ONLINE { get; set; }
        /// <summary>
        /// 对象状态ID; 逻辑关联对象状态表
        /// <summary>
        public virtual int? OBJ_STATUS_ID { get; set; }
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
        /// 坐标; 传感器测量值，单位：毫米
        /// <summary>
        public virtual int? COORD { get; set; }

        /// <summary>
        /// 容器编号
        /// <summary>
        public virtual string CON_NUM { get; set; }
    }
}
