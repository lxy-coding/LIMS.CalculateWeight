using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 热修表
    /// </summary>
    [Serializable]
    public class LADLE_HOT_REPAIR
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 配包记录ID
        /// <summary>
        public virtual int? HEAT_MATCH_LADLE_ID { get; set; }
        /// <summary>
        /// 滑板工ID
        /// <summary>
        public virtual int? SLIDE_OPERATOR { get; set; }
        /// <summary>
        /// 班组ID
        /// <summary>
        public virtual int? LADLE_CLASS { get; set; }
        /// <summary>
        /// 使用状态，状态表中ID（object_type_status where obj_type_id=18 and  status_type='PRO_STATUS'）
        /// <summary>
        public virtual int? USING_STATUS { get; set; }
        /// <summary>
        /// 维修状态，状态表中ID（object_type_status where obj_type_id=18 and  status_type='MAINTAIN_STATUS'）
        /// <summary>
        public virtual int? MAINTAIN_TYPE { get; set; }
        /// <summary>
        /// 热状态，状态表中ID（object_type_status where obj_type_id=18 and  status_type='THERMAL_STATUS'）
        /// <summary>
        public virtual int? THERMAL_STATUS { get; set; }
        /// <summary>
        /// 包口结渣，0未结渣，1结渣
        /// <summary>
        public virtual short? LADLE_EDGE_SLAG { get; set; }
        /// <summary>
        /// 工艺路径
        /// <summary>
        public virtual string ROUTE { get; set; }
        /// <summary>
        /// 包龄
        /// <summary>
        public virtual string LADLE_LIFE { get; set; }
        /// <summary>
        /// 滑板次数
        /// <summary>
        public virtual string SLIDE_LIFE { get; set; }
        /// <summary>
        /// 上水口次数
        /// <summary>
        public virtual short? UP_NOZZLE_LIFE { get; set; }
        /// <summary>
        /// 下水口次数
        /// <summary>
        public virtual short? DOWN_NOZZLE_LIFE { get; set; }
        /// <summary>
        /// 水口座砖次数
        /// <summary>
        public virtual string NOZZLE_BRICK_LIFE { get; set; }
        /// <summary>
        /// 渣线砖次数
        /// <summary>
        public virtual short? SLAG_BRICK_LIFE { get; set; }
        /// <summary>
        /// 透气砖次数
        /// <summary>
        public virtual short? POROUS_BRICK_LIFE { get; set; }
        /// <summary>
        /// LF次数
        /// <summary>
        public virtual string LF_LIFE { get; set; }
        /// <summary>
        /// RH次数
        /// <summary>
        public virtual string RH_LIFE { get; set; }
        /// <summary>
        /// 钢液温度，摄氏度
        /// <summary>
        public virtual string STEEL_CTEMP { get; set; }
        /// <summary>
        /// 转炉加盖，0未加，1加盖
        /// <summary>
        public virtual short? BOF_COVER { get; set; }
        /// <summary>
        /// 精炼加盖，0未加，1加盖
        /// <summary>
        public virtual short? REFINE_COVER { get; set; }
        /// <summary>
        /// 内壁温度，摄氏度
        /// <summary>
        public virtual short? WALL_IN_TEMP { get; set; }
        /// <summary>
        /// 外壁温度，摄氏度
        /// <summary>
        public virtual short? WALL_EX_TEMP { get; set; }
        /// <summary>
        /// 内底温度，摄氏度
        /// <summary>
        public virtual short? BOTTOM_IN_TEMP { get; set; }
        /// <summary>
        /// 外底温度，摄氏度
        /// <summary>
        public virtual short? BOTTOM_EX_TEMP { get; set; }
        /// <summary>
        /// 上水口扩径
        /// <summary>
        public virtual string HIGHER_NOZZLE_DIAM { get; set; }
        /// <summary>
        /// 东透气深度
        /// <summary>
        public virtual string EAST_POROUS_DEPTH { get; set; }
        /// <summary>
        /// 西透气深度
        /// <summary>
        public virtual string WEST_POROUS_DEPTH { get; set; }
        /// <summary>
        /// 大包自开，0否，1是
        /// <summary>
        public virtual short? AUTO_OPENED { get; set; }
        /// <summary>
        /// 引流砂，状态表中ID（object_type_status where obj_type_id=18 and  status_type='GARA_STATUS'）
        /// <summary>
        public virtual int? STUFFING_SAND { get; set; }
        /// <summary>
        /// 处理透气砖，0不合格，1合格
        /// <summary>
        public virtual short? DEAL_POROUS_BRICK { get; set; }
        /// <summary>
        /// 备用包上线温度1，摄氏度
        /// <summary>
        public virtual string STANDBY_LADLE_CTEMP1 { get; set; }
        /// <summary>
        /// 备用包上线温度2，摄氏度
        /// <summary>
        public virtual string STANDBY_LADLE_CTEMP2 { get; set; }
        /// <summary>
        /// 机构缝隙
        /// <summary>
        public virtual string SLIDE_MECHANISM_GAP { get; set; }
        /// <summary>
        /// 渣线残厚
        /// <summary>
        public virtual string SLAG_BRICK_THICK { get; set; }
        /// <summary>
        /// 包壁残厚
        /// <summary>
        public virtual string WALL_THICK { get; set; }
        /// <summary>
        /// 包底残厚
        /// <summary>
        public virtual string BOTTOM_THICK { get; set; }
        /// <summary>
        /// 滑动机构厂家
        /// <summary>
        public virtual string SLIDE_MECHANISM_MANU { get; set; }
        /// <summary>
        /// 水口厂家
        /// <summary>
        public virtual string NOZZLE_MANU { get; set; }
        /// <summary>
        /// 耐材砌筑厂
        /// <summary>
        public virtual string BUILDING_MANU { get; set; }
        /// <summary>
        /// 滑板制造厂
        /// <summary>
        public virtual string SLIDE_GATE_MANU { get; set; }
        /// <summary>
        /// 内衬厂家
        /// <summary>
        public virtual string INNER_LAYER_MANU { get; set; }
        /// <summary>
        /// 备注
        /// <summary>
        public virtual string REMARK { get; set; }
        /// <summary>
        /// 记录生成时间
        /// <summary>
        public virtual DateTime? TIME_TAMP { get; set; }
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
        /// <summary>
        /// 容器ID
        /// <summary>
        public virtual int? CONID { get; set; }
        /// <summary>
        /// 包况，状态表中ID（object_type_status where obj_type_id=18 and  status_type='Ladle_status'）
        /// <summary>
        public virtual int? LADLE_STATUS { get; set; }
        /// <summary>
        /// 钢种，钢种表中ID（steel_grade_info）
        /// <summary>
        public virtual int? STEEL_GRADE { get; set; }
        /// <summary>
        /// 使用时间（天车起吊时间）
        /// <summary>
        public virtual DateTime? USE_TIME { get; set; }
        /// <summary>
        /// 使用标志：0未起吊，1已起吊
        /// <summary>
        public virtual short? IS_USE { get; set; }
        /// <summary>
        /// 热修位置，工位表编码
        /// <summary>
        public virtual int? POSIT { get; set; }
    }
}
