using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 天车静态属性表
    /// </summary>
    [Serializable]
    public class CRANE
    {
        public CRANE() { }
        /// <summary>
        /// 序号
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 吊钩基础_序号; 
        /// <summary>
        public virtual HOOK HOO_ID { get; set; }
        /// <summary>
        /// 跨ID; 数值 强关系
        /// <summary>
        public virtual SPA SPA_ID { get; set; }
        /// <summary>
        /// 天车编号; 逻辑 对象表
        /// <summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 天车名称;
        /// <summary>
        public virtual string CRA_NAME { get; set; }
        /// <summary>
        /// 对象类型ID;
        /// <summary>
        public virtual OBJECT_TYPE OBJECT_TYPE_ID { get; set; }
        /// <summary>
        /// 天车X轴方向行走的最小值; X下限
        /// <summary>
        public virtual int? WALK_MIN_X { get; set; }
        /// <summary>
        /// 天车X轴方向行走的最大值; X上限
        /// <summary>
        public virtual int? WALK_MAX_X { get; set; }
        /// <summary>
        /// 天车Y轴方向行走的最小值; Y下限
        /// <summary>
        public virtual int? WALK_MIN_Y { get; set; }
        /// <summary>
        /// 天车Y轴方向行走的最大值; Y上限
        /// <summary>
        public virtual int? WALK_MAX_Y { get; set; }
        /// <summary>
        /// 天车Z轴方向行走的最小值; 主勾Z下限
        /// <summary>
        public virtual int? WALK_MIN_Z { get; set; }
        /// <summary>
        /// 天车Z轴方向行走的最大值; 主勾Z上限
        /// <summary>
        public virtual int? WALK_MAX_Z { get; set; }
        /// <summary>
        /// 副勾Z上限值; 副勾Z方向最大地址，毫米
        /// <summary>
        public virtual int? LITTLE_MAX_Z { get; set; }
        /// <summary>
        /// 副勾Z下限值; 副勾Z方向最小地址，毫米
        /// <summary>
        public virtual int? LITTLE_MIN_Z { get; set; }
        /// <summary>
        /// 天车X速度最大值; X速度最大值，单位，m/s
        /// <summary>
        public virtual float? MAX_SPEED_X { get; set; }
        /// <summary>
        /// 天车Y速度最大值; Y速度最大值，单位，m/s
        /// <summary>
        public virtual float? MAX_SPEED_Y { get; set; }
        /// <summary>
        /// 零点X
        /// <summary>
        public virtual int? ZERO_X { get; set; }
        /// <summary>
        /// 零点Y
        /// <summary>
        public virtual int? ZERO_Y { get; set; }
        /// <summary>
        /// 零点Z
        /// <summary>
        public virtual int? ZERO_Z { get; set; }
        /// <summary>
        /// 额定载重; kg
        /// <summary>
        public virtual int? SPECIFIC_WEIGHT { get; set; }
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
        /// 存储天车类型，1废钢天车，2铁水天车，3钢包天车，4铸坯天车，5精炼天车，6其他
        /// <summary>
        public virtual short? CRA_TYPE { get; set; }
        /// <summary>
        /// 对象ID
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 零点X偏移
        /// <summary>
        public virtual int? ZERO_X_OOFSET { get; set; }
        /// <summary>
        /// 零点Y偏移
        /// <summary>
        public virtual int? ZERO_Y_OOFSET { get; set; }
        /// <summary>
        /// 零点Z偏移
        /// <summary>
        public virtual int? ZERO_Z_OOFSET { get; set; }
        /// <summary>
        /// 零点X方向:1.上、2.下、3.左、4.右
        /// <summary>
        public virtual short? ZERO_X_DIRECTION { get; set; }
        /// <summary>
        /// 动画区域编码
        /// <summary>
        public virtual string ANIMATION_AREA_CONFIGURATION_NUM { get; set; }
        /// <summary>
        /// IP地址
        /// <summary>
        public virtual string IP_ADDRESS { get; set; }
        /// <summary>
        /// 零点Y方向:1.上、2.下、3.左、4.右
        /// <summary>
        public virtual short? ZERO_Y_DIRECTION { get; set; }
        /// <summary>
        /// 零点Z方向:1.上、2.下、3.左、4.右
        /// <summary>
        public virtual short? ZERO_Z_DIRECTION { get; set; }
    }
}
