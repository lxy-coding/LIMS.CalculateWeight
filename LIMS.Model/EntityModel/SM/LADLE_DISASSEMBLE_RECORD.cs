using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_DISASSEMBLE_RECORD {
        /// <summary>
        /// 序号，主键; GUID
        /// </summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 冷修号
        /// </summary>
        public virtual string COOL_REPAIR_NUM { get; set; }
        /// <summary>
        /// 热修号
        /// </summary>
        public virtual string HOT_REPAIR_NUM { get; set; }
        /// <summary>
        /// 钢包号
        /// </summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 钢包类型，1方坯用包，2板坯用包
        /// </summary>
        public virtual int LADLE_TYPE { get; set; }
        /// <summary>
        /// 修包类型，对象类型状态表ID
        /// </summary>
        public virtual int MAINTAIN_TYPE { get; set; }
        /// <summary>
        /// 总包龄
        /// </summary>
        public virtual short? TOTAL_LADLE_LIFE { get; set; }
        /// <summary>
        /// 本次包龄
        /// </summary>
        public virtual short? CURRENT_LADLE_LIFE { get; set; }
        /// <summary>
        /// 拆包单位，钢包厂家表ID
        /// </summary>
        public virtual string DISASSEMBLE_ENTERPRISE { get; set; }
        /// <summary>
        /// 渣线残厚，0~200mm
        /// </summary>
        public virtual short? SLAG_BRICK_RMAIN { get; set; }
        /// <summary>
        /// 包身方向，对象类型状态表ID
        /// </summary>
        public virtual int? WALL_DIRECTION { get; set; }
        /// <summary>
        /// 包身层数，1~12层
        /// </summary>
        public virtual short? WALL_LAYER_COUNT { get; set; }
        /// <summary>
        /// 包身残厚，mm
        /// </summary>
        public virtual short? WALL_BRICK_REMAIN { get; set; }
        /// <summary>
        /// 包底方向，对象类型状态表ID
        /// </summary>
        public virtual int? BOTTOM_DIRECTION { get; set; }
        /// <summary>
        /// 包底层数
        /// </summary>
        public virtual short? BOTTOM_LAYER_COUNT { get; set; }
        /// <summary>
        /// 包底残厚，0~350mm
        /// </summary>
        public virtual short? BOTTOM_BRICK_REMAIN { get; set; }
        /// <summary>
        /// 左透气残厚，0~450mm
        /// </summary>
        public virtual short? LEFT_POROUS_REMAIN { get; set; }
        /// <summary>
        /// 右透气残厚，0~450mm
        /// </summary>
        public virtual short? RIGHT_POROUS_REMAIN { get; set; }
        /// <summary>
        /// 包底区域
        /// </summary>
        public virtual short? DISASSEMBLE_SECTION { get; set; }
        /// <summary>
        /// 拆包备注
        /// </summary>
        public virtual string DISASSEMBLE_REMARK { get; set; }
        /// <summary>
        /// 数据记录操作员，人员表ID
        /// </summary>
        public virtual int USER_ID { get; set; }
        /// <summary>
        /// 拆包班组，班组表ID
        /// </summary>
        public virtual int TEAM_ID { get; set; }
        /// <summary>
        /// 拆包完成时刻
        /// </summary>
        public virtual DateTime DISASSEMBLE_TIME { get; set; }
        /// <summary>
        /// 预留字段1;
        /// </summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// </summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// </summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 渣线方向，对象类型状态表ID
        /// </summary>
        public virtual int? SLAG_BRICK_DIRECTION { get; set; }
        /// <summary>
        /// 渣线层数，1~12层
        /// </summary>
        public virtual short? SLAG_BRICK_LAYER_COUNT { get; set; }
    }
}
