using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_HOTREPAIR_RECORD {
        /// <summary>
        /// 序号，主键; GUID
        /// </summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 钢包号
        /// </summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 钢包类型，1方坯用包，2板坯用包
        /// </summary>
        public virtual int LADLE_TYPE { get; set; }
        /// <summary>
        /// 冷修序号
        /// </summary>
        public virtual string COOL_REPAIR_NUM { get; set; }
        /// <summary>
        /// 热修序号
        /// </summary>
        public virtual string HOT_REPAIR_NUM { get; set; }
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
        /// 热修班组,班组表ID
        /// </summary>
        public virtual string CLASS_ID { get; set; }
        /// <summary>
        /// 热状态,对象类型状态表ID
        /// </summary>
        public virtual string THERMAL_STATUS { get; set; }
        /// <summary>
        /// 包况,对象类型状态表ID
        /// </summary>
        public virtual string LADLE_STATUS { get; set; }
        /// <summary>
        /// 连滑,对象类型状态表ID
        /// </summary>
        public virtual string CONTINUE_SLIDE { get; set; }
        /// <summary>
        /// 引流砂,对象类型状态表ID
        /// </summary>
        public virtual string STUFFING_SAND { get; set; }
        /// <summary>
        /// 内壁温度，摄氏度
        /// </summary>
        public virtual string INNER_WALL_TEMP { get; set; }
        /// <summary>
        /// 外壁温度，摄氏度
        /// </summary>
        public virtual string OUTER_WALL_TEMP { get; set; }
        /// <summary>
        /// 内底温度，摄氏度
        /// </summary>
        public virtual string INNER_BOTTOM_TEMP { get; set; }
        /// <summary>
        /// 外底温度，摄氏度
        /// </summary>
        public virtual string OUTER_BOTTOM_TEMP { get; set; }
        /// <summary>
        /// 滑动机构厂家,钢包相关厂家表ID
        /// </summary>
        public virtual string SLIDE_MECHANISM_MANU { get; set; }
        /// <summary>
        /// 水口厂家,钢包相关厂家表ID
        /// </summary>
        public virtual string NOZZLE_MANU { get; set; }
        /// <summary>
        /// 耐材砌筑厂,钢包相关厂家表ID
        /// </summary>
        public virtual string BUILDING_MANU { get; set; }
        /// <summary>
        /// 滑板制造厂,钢包相关厂家表ID
        /// </summary>
        public virtual string SLIDE_GATE_MANU { get; set; }
        /// <summary>
        /// 内衬厂家,钢包相关厂家表ID
        /// </summary>
        public virtual string INNER_LAYER_MANU { get; set; }
        /// <summary>
        /// 上水口次数
        /// </summary>
        public virtual string UP_NOZZLE_LIFE { get; set; }
        /// <summary>
        /// 下水口次数
        /// </summary>
        public virtual string DOWN_NOZZLE_LIFE { get; set; }
        /// <summary>
        /// 渣线砖次数
        /// </summary>
        public virtual string SLAG_BRICK_LIFE { get; set; }
        /// <summary>
        /// 透气砖次数
        /// </summary>
        public virtual string POROUS_BRICK_LIFE { get; set; }
        /// <summary>
        /// 水口座砖次数
        /// </summary>
        public virtual string NOZZLE_BRICK_LIFE { get; set; }
        /// <summary>
        /// 滑板次数
        /// </summary>
        public virtual string SLIDE_LIFE { get; set; }
        /// <summary>
        /// LF次数
        /// </summary>
        public virtual string LF_TIMES { get; set; }
        /// <summary>
        /// RH次数
        /// </summary>
        public virtual string RH_TIMES { get; set; }
        /// <summary>
        /// 东透气深度，mm
        /// </summary>
        public virtual string EAST_POROUS_DEPTH { get; set; }
        /// <summary>
        /// 西透气深度，mm
        /// </summary>
        public virtual string WEST_POROUS_DEPTH { get; set; }
        /// <summary>
        /// 上水口扩径，mm
        /// </summary>
        public virtual string HIGHER_NOZZLE_DIAM { get; set; }
        /// <summary>
        /// 包底残厚，mm
        /// </summary>
        public virtual string BOTTOM_THICK { get; set; }
        /// <summary>
        /// 包壁残厚，mm
        /// </summary>
        public virtual string WALL_THICK { get; set; }
        /// <summary>
        /// 渣线残厚，mm
        /// </summary>
        public virtual string SLAG_BRICK_THICK { get; set; }
        /// <summary>
        /// 机构缝隙，mm
        /// </summary>
        public virtual string SLIDE_MECHANISM_GAP { get; set; }
        /// <summary>
        /// 转炉加盖，0否，1是
        /// </summary>
        public virtual string BOF_COVER { get; set; }
        /// <summary>
        /// 精炼加盖，0否，1是
        /// </summary>
        public virtual string REFINE_COVER { get; set; }
        /// <summary>
        /// 包口结渣，0否，1是
        /// </summary>
        public virtual string LADLE_EDGE_SLAG { get; set; }
        /// <summary>
        /// 大包自开，0否，1是
        /// </summary>
        public virtual string AUTO_OPENED { get; set; }
        /// <summary>
        /// 处理透气砖，0不合格，1合格
        /// </summary>
        public virtual string DEAL_POROUS_BRICK { get; set; }
        /// <summary>
        /// 热修备注
        /// </summary>
        public virtual string HOT_REPAIR_REMARK { get; set; }
        /// <summary>
        /// 是否配炉次，0否，1是
        /// </summary>
        public virtual string IS_MACTH_HEAT { get; set; }
        /// <summary>
        /// 配包记录表ID
        /// </summary>
        public virtual string HEAT_MATCH_LADLE_ID { get; set; }
        /// <summary>
        /// 记录生成时间
        /// </summary>
        public virtual DateTime TIME_STAMP { get; set; }
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
    }
}
