using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM01
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string CAST_LOT_NO { get; set; }
        public virtual string SM_PLAN_NO { get; set; }
        public virtual string PONO { get; set; }
        public virtual string ST_NO { get; set; }
        public virtual string CAST_LOT_SUM { get; set; }
        public virtual string CAST_LOT_DIV_NO { get; set; }
        public virtual string CC_MACH_NO { get; set; }
        public virtual string CC_TYPE { get; set; }
        public virtual string REFINE_ROUTE_CODE { get; set; }
        public virtual string REFINE_NUM { get; set; }
        public virtual string PLAN_TAP_WT { get; set; }
        public virtual string FURNACE_NO { get; set; }
        public virtual string TD_CHG_FLG { get; set; }
        public virtual string MAKING_METHOD_CM { get; set; }
        public virtual string DP_BOF_NO_CM { get; set; }
        public virtual string DP_BOF_START_TIME { get; set; }
        public virtual string DP_BLOW_START_TIME { get; set; }
        public virtual string DP_BLOW_END_TIME { get; set; }
        public virtual string DP_TAP_START_TIME { get; set; }
        public virtual string DP_TAP_END_TIME { get; set; }
        public virtual string BOF_START_CHR_TIME { get; set; }
        public virtual string BLOW_START_TIME { get; set; }
        public virtual string BLOW_END_TIME { get; set; }
        public virtual string TAP_START_TIME { get; set; }
        public virtual string TAP_END_TIME { get; set; }
        public virtual string AR_DEV_CODE { get; set; }
        public virtual string AR_BLOW_START_TIME { get; set; }
        public virtual string AR_BLOW_END_TIME { get; set; }
        public virtual string REFINE_DEV_CODE_1 { get; set; }
        public virtual string REFINE_START_TIME_1 { get; set; }
        public virtual string REFINE_END_TIME_1 { get; set; }
        public virtual string REFINE_DEV_CODE_2 { get; set; }
        public virtual string REFINE_START_TIME_2 { get; set; }
        public virtual string REFINE_END_TIME_2 { get; set; }
        public virtual string REFINE_DEV_CODE_3 { get; set; }
        public virtual string REFINE_START_TIME_3 { get; set; }
        public virtual string REFINE_END_TIME_3 { get; set; }
        public virtual string REFINE_DEV_CODE_4 { get; set; }
        public virtual string REFINE_START_TIME_4 { get; set; }
        public virtual string REFINE_END_TIME_4 { get; set; }
        public virtual string CC_REQ_TIME { get; set; }
        public virtual string POUR_TIME_BEGIN { get; set; }
        public virtual string POUR_TIME_END { get; set; }
        public virtual string LADLE_KILL_TIME_PRE_ARR { get; set; }
        public virtual string STOP_MARK { get; set; }
        public virtual string PLAN_HEAT_NO { get; set; }
        public virtual string ST_NO_DESC { get; set; }
    }
}
