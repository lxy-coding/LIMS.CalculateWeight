using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 天车运行记录表
    /// </summary>
    [Serializable]
    public class CRANE_RUN_RECORD
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
        /// Z坐标; 传感器测量值Y，副勾，单位：毫米
        /// <summary>
        public virtual int? COORD_Z { get; set; }
        /// <summary>
        /// 副勾Y坐标; 传感器测量值Z，单位：毫米
        /// <summary>
        public virtual int? LITTLE_HOOK_Y { get; set; }
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
        /// 载物重量; 传感器测量总重量，单位：千克
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 副钩重量; 传感器测量重量，副勾，单位：千克
        /// <summary>
        public virtual int? LITTLE_HOOK_WEIGHT { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 计划号; 天车计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 作业类型; 1空包起吊， 2重包起吊， 3空包放吊， 4重包放吊 ，5兑物，6其他 ，10默认无动作
        ///
        /// <summary>
        public virtual short WORK_TYPE { get; set; }
        /// <summary>
        /// 吊物对象编号; 当吊两块板坯时，用；隔开，第一个编号表示下层板坯，第二个编号表示上层板坯，服务程序更新
        /// <summary>
        public virtual string OBJ_NUM { get; set; }
        /// <summary>
        /// 吊物数量; 主要吊坯数量
        /// <summary>
        public virtual short? OBJ_COUNT { get; set; }
        /// <summary>
        /// 超载标志; 1正常，2超载
        /// <summary>
        public virtual short OVER_LOAD { get; set; }
        /// <summary>
        /// 吊具ID;
        /// <summary>
        public virtual int? HOOK_ID { get; set; }
        /// <summary>
        /// 载重标志; 0为空载，1为空包，2为重包
        /// <summary>
        public virtual short LOAD_SYMBOL { get; set; }
        /// <summary>
        /// 是否在线; 0不在线1在线
        /// <summary>
        public virtual short? IS_ONLINE { get; set; }
        /// <summary>
        /// 设备状态ID; 逻辑关联对象状态表
        /// <summary>
        public virtual int? OBJ_STATUS_ID { get; set; }
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
