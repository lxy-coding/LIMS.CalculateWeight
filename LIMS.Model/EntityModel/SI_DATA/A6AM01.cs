using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM01
    {
        /// <summary>
        /// 序号
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// 消息时间
        /// <summary>
        public virtual DateTime? MSG_TIME { get; set; }
        /// <summary>
        /// 读取时间
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
        /// <summary>
        /// 消息状态
        /// <summary>
        public virtual string MSG_STATUS { get; set; }
        /// <summary>
        /// 操作类型
        /// <summary>
        public virtual string OP_DIV { get; set; }
        /// <summary>
        /// 浇铸批号
        /// <summary>
        public virtual string CAST_LOT_NO { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string SM_PLAN_NO { get; set; }
        /// <summary>
        /// 制造命令号
        /// <summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// 内部钢种（出钢记号）
        /// <summary>
        public virtual string ST_NO { get; set; }
        /// <summary>
        /// 浇次内炉数
        /// <summary>
        public virtual string CAST_LOT_SUM { get; set; }
        /// <summary>
        /// 浇次内分隔号
        /// <summary>
        public virtual string CAST_LOT_DIV_NO { get; set; }
        /// <summary>
        /// 连铸机号
        /// <summary>
        public virtual string CC_MACH_NO { get; set; }
        /// <summary>
        /// 连铸机类型
        /// <summary>
        public virtual string CC_TYPE { get; set; }
        /// <summary>
        /// 精炼路径（精炼区分）
        /// <summary>
        public virtual string REFINE_ROUTE_CODE { get; set; }
        /// <summary>
        /// 精炼重数
        /// <summary>
        public virtual string REFINE_NUM { get; set; }
        /// <summary>
        /// 计划出钢量
        /// <summary>
        public virtual string PLAN_TAP_WT { get; set; }
        /// <summary>
        /// 炉座号
        /// <summary>
        public virtual string FURNACE_NO { get; set; }
        /// <summary>
        /// 换中间包标志
        /// <summary>
        public virtual string TD_CHG_FLG { get; set; }
        /// <summary>
        /// 冶炼方式
        /// <summary>
        public virtual string MAKING_METHOD_CM { get; set; }
        /// <summary>
        /// 脱磷转炉号
        /// <summary>
        public virtual string DP_BOF_NO_CM { get; set; }
        /// <summary>
        /// 脱磷转炉主原料装入始时刻
        /// <summary>
        public virtual string DP_BOF_START_TIME { get; set; }
        /// <summary>
        /// 脱磷吹炼开始时刻
        /// <summary>
        public virtual string DP_BLOW_START_TIME { get; set; }
        /// <summary>
        /// 脱磷吹炼结束时刻
        /// <summary>
        public virtual string DP_BLOW_END_TIME { get; set; }
        /// <summary>
        /// 脱磷炉出钢开始时刻
        /// <summary>
        public virtual string DP_TAP_START_TIME { get; set; }
        /// <summary>
        /// 脱磷炉出钢结束时刻
        /// <summary>
        public virtual string DP_TAP_END_TIME { get; set; }
        /// <summary>
        /// （脱碳转炉）主原料装入始时刻
        /// <summary>
        public virtual string BOF_START_CHR_TIME { get; set; }
        /// <summary>
        /// 开吹时刻(脱碳吹炼开始时刻)
        /// <summary>
        public virtual string BLOW_START_TIME { get; set; }
        /// <summary>
        /// 吹炼结束时刻(脱碳吹炼结束时刻)
        /// <summary>
        public virtual string BLOW_END_TIME { get; set; }
        /// <summary>
        /// 出钢开始时刻
        /// <summary>
        public virtual string TAP_START_TIME { get; set; }
        /// <summary>
        /// 出钢终止时刻
        /// <summary>
        public virtual string TAP_END_TIME { get; set; }
        /// <summary>
        /// 氩站工位号
        /// <summary>
        public virtual string AR_DEV_CODE { get; set; }
        /// <summary>
        /// 氩站处理开始时刻
        /// <summary>
        public virtual string AR_BLOW_START_TIME { get; set; }
        /// <summary>
        /// 氩站处理结束时刻
        /// <summary>
        public virtual string AR_BLOW_END_TIME { get; set; }
        /// <summary>
        /// 精炼1工位号
        /// <summary>
        public virtual string REFINE_DEV_CODE_1 { get; set; }
        /// <summary>
        /// 精炼1开始时刻
        /// <summary>
        public virtual string REFINE_START_TIME_1 { get; set; }
        /// <summary>
        /// 精炼1结束时刻
        /// <summary>
        public virtual string REFINE_END_TIME_1 { get; set; }
        /// <summary>
        /// 精炼2工位号
        /// <summary>
        public virtual string REFINE_DEV_CODE_2 { get; set; }
        /// <summary>
        /// 精炼2开始时刻
        /// <summary>
        public virtual string REFINE_START_TIME_2 { get; set; }
        /// <summary>
        /// 精炼2结束时刻
        /// <summary>
        public virtual string REFINE_END_TIME_2 { get; set; }
        /// <summary>
        /// 精炼3工位号
        /// <summary>
        public virtual string REFINE_DEV_CODE_3 { get; set; }
        /// <summary>
        /// 精炼3开始时刻
        /// <summary>
        public virtual string REFINE_START_TIME_3 { get; set; }
        /// <summary>
        /// 精炼3结束时刻
        /// <summary>
        public virtual string REFINE_END_TIME_3 { get; set; }
        /// <summary>
        /// 精炼4工位号
        /// <summary>
        public virtual string REFINE_DEV_CODE_4 { get; set; }
        /// <summary>
        /// 精炼4开始时刻
        /// <summary>
        public virtual string REFINE_START_TIME_4 { get; set; }
        /// <summary>
        /// 精炼4结束时刻
        /// <summary>
        public virtual string REFINE_END_TIME_4 { get; set; }
        /// <summary>
        /// MMS计划开始浇注时刻
        /// <summary>
        public virtual string CC_REQ_TIME { get; set; }
        /// <summary>
        /// 浇注开始时刻
        /// <summary>
        public virtual string POUR_TIME_BEGIN { get; set; }
        /// <summary>
        /// 浇注结束时刻
        /// <summary>
        public virtual string POUR_TIME_END { get; set; }
        /// <summary>
        /// 钢包镇静（早到）时间
        /// <summary>
        public virtual string LADLE_KILL_TIME_PRE_ARR { get; set; }
        /// <summary>
        /// 炉次指示
        /// <summary>
        public virtual string STOP_MARK { get; set; }
        /// <summary>
        /// 计划熔炼号
        /// <summary>
        public virtual string PLAN_HEAT_NO { get; set; }
        /// <summary>
        /// 内部钢种描述
        /// <summary>
        public virtual string ST_NO_DESC { get; set; }
    }
}
