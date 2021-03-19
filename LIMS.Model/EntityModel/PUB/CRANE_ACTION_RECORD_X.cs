using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CRANE_ACTION_RECORD_X
    {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 天车属性_序号;
        /// <summary>
        public virtual CRANE CRA_ID { get; set; }
        /// <summary>
        /// X坐标; 传感器测量值X，单位：毫米
        /// <summary>
        public virtual int? COORD_X { get; set; }
        /// <summary>
        /// Y坐标; 传感器测量值Y，单位：毫米
        /// <summary>
        public virtual int? COORD_Y { get; set; }
        /// <summary>
        /// 副钩Y坐标; 传感器测量值Y，副勾，单位：毫米
        /// <summary>
        public virtual int? LIITLT_HOOK_Y { get; set; }
        /// <summary>
        /// Z坐标; 传感器测量值Y，副勾，单位：毫米
        /// <summary>
        public virtual int? COORD_Z { get; set; }
        /// <summary>
        /// 副勾Z坐标; 传感器测量值Z，副勾，单位：毫米
        /// <summary>
        public virtual int? LITTLE_HOOK_Z { get; set; }
        /// <summary>
        /// Z旋转角度; 传感器测量值Z，主勾，单位：度
        /// <summary>
        public virtual short? ROTATE_Z { get; set; }
        /// <summary>
        /// 副钩Z旋转角度; 传感器测量值Z，副勾，单位：度
        /// <summary>
        public virtual short? LITTLE_ROTATE_Z { get; set; }
        /// <summary>
        /// 重量;
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 校正重量; 上位机校正重量，主钩，单位：千克
        /// <summary>
        public virtual int? CALIBRATE_WEIGHT { get; set; }
        /// <summary>
        /// 副钩重量; 传感器测量重量，副勾，单位：千克
        /// <summary>
        public virtual int? LITTLE_HOOK_WEIGHT { get; set; }
        /// <summary>
        /// 动作类型; 1空包起吊， 2重包起吊， 3空包放吊， 4重包放吊 ，5兑物，6其他 ，10默认无动作，吊坯或卷1起吊，3放吊
        ///
        /// <summary>
        public virtual short ACTION_SYMBOL { get; set; }
        /// <summary>
        /// 编号;
        /// <summary>
        public virtual string POSIT { get; set; }
        /// <summary>
        /// 计划号; 天车计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 吊物编号; 当吊两块板坯时，用\隔开，第一个编号表示下层板坯，第二个编号表示上层板坯
        /// <summary>
        public virtual string HOIST_NUM { get; set; }
        /// <summary>
        /// 吊物类型;
        /// <summary>
        public virtual short? HOIST_TYPE { get; set; }
        /// <summary>
        /// 动作生成时间; PLC动作时间，格式：yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? OPERATION_TIME { get; set; }
        /// <summary>
        /// 上位机接收时间; 格式：yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? ACCEPT_TIME { get; set; }
        /// <summary>
        /// 处理时间; 上位机处理时间，格式：yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? DEAL_TIME { get; set; }
        /// <summary>
        /// 处理标志位; 1为未处理，2为已处理
        /// <summary>
        public virtual short? DEAL_SYMBOL { get; set; }
        /// <summary>
        /// 是否为临时包; 1为非临时包,2为临时包
        /// <summary>
        public virtual short IS_TEMP { get; set; }
        /// <summary>
        /// PLC缓存序号; PLC程序中动作缓存标志
        /// <summary>
        public virtual short? CACHE_NUM { get; set; }
        /// <summary>
        /// 吊物数量;
        /// <summary>
        public virtual short? HANGE_QUAN { get; set; }
        /// <summary>
        /// 超载标志; 1正常，2超载
        /// <summary>
        public virtual short OVER_LOAD { get; set; }
        /// <summary>
        /// 载重标志; 0为空载，1为空包，2为重包
        /// <summary>
        public virtual short LOAD_SYMBOL { get; set; }
        /// <summary>
        /// 临时任务标志位; 1为非临时任务，2为临时任务
        ///
        /// <summary>
        public virtual short TEMP_TASK { get; set; }
        /// <summary>
        /// 是否校验; 0为否，1为是
        /// <summary>
        public virtual short? IS_CHECKED { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual DateTime? FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 天车处理标志位; 1为未处理，2为已处理
        /// <summary>
        //public virtual short CRA_DEAL_SYMBOL { get; set; }
    }
}
