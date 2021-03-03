using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class A6am01 : ActiveRecordValidationBase<A6am01> {
        
        [Property(Column="MSG_COUNTER", Length=22, NotNull=true)]
        public virtual long MsgCounter { get; set; }
        
        [Property(Column="MSG_TIME", Length=7)]
        public virtual System.DateTime MsgTime { get; set; }
        
        [Property(Column="READ_TIME", Length=7)]
        public virtual System.DateTime ReadTime { get; set; }
        
        [Property(Column="MSG_STATUS", Length=8)]
        public virtual string MsgStatus { get; set; }
        
        [Property(Column="OP_DIV", Length=12)]
        public virtual string OpDiv { get; set; }
        
        [Property(Column="CAST_LOT_NO", Length=30)]
        public virtual string CastLotNo { get; set; }
        
        [Property(Column="SM_PLAN_NO", Length=30)]
        public virtual string SmPlanNo { get; set; }
        
        [Property(Column="PONO", Length=30)]
        public virtual string Pono { get; set; }
        
        [Property(Column="ST_NO", Length=50)]
        public virtual string StNo { get; set; }
        
        [Property(Column="CAST_LOT_SUM", Length=16)]
        public virtual string CastLotSum { get; set; }
        
        [Property(Column="CAST_LOT_DIV_NO", Length=16)]
        public virtual string CastLotDivNo { get; set; }
        
        [Property(Column="CC_MACH_NO", Length=14)]
        public virtual string CcMachNo { get; set; }
        
        [Property(Column="CC_TYPE", Length=12)]
        public virtual string CcType { get; set; }
        
        [Property(Column="REFINE_ROUTE_CODE", Length=26)]
        public virtual string RefineRouteCode { get; set; }
        
        [Property(Column="REFINE_NUM", Length=12)]
        public virtual string RefineNum { get; set; }
        
        [Property(Column="PLAN_TAP_WT", Length=24)]
        public virtual string PlanTapWt { get; set; }
        
        [Property(Column="FURNACE_NO", Length=14)]
        public virtual string FurnaceNo { get; set; }
        
        [Property(Column="TD_CHG_FLG", Length=12)]
        public virtual string TdChgFlg { get; set; }
        
        [Property(Column="MAKING_METHOD_CM", Length=12)]
        public virtual string MakingMethodCm { get; set; }
        
        [Property(Column="DP_BOF_NO_CM", Length=14)]
        public virtual string DpBofNoCm { get; set; }
        
        [Property(Column="DP_BOF_START_TIME", Length=38)]
        public virtual string DpBofStartTime { get; set; }
        
        [Property(Column="DP_BLOW_START_TIME", Length=38)]
        public virtual string DpBlowStartTime { get; set; }
        
        [Property(Column="DP_BLOW_END_TIME", Length=38)]
        public virtual string DpBlowEndTime { get; set; }
        
        [Property(Column="DP_TAP_START_TIME", Length=38)]
        public virtual string DpTapStartTime { get; set; }
        
        [Property(Column="DP_TAP_END_TIME", Length=38)]
        public virtual string DpTapEndTime { get; set; }
        
        [Property(Column="BOF_START_CHR_TIME", Length=38)]
        public virtual string BofStartChrTime { get; set; }
        
        [Property(Column="BLOW_START_TIME", Length=38)]
        public virtual string BlowStartTime { get; set; }
        
        [Property(Column="BLOW_END_TIME", Length=38)]
        public virtual string BlowEndTime { get; set; }
        
        [Property(Column="TAP_START_TIME", Length=38)]
        public virtual string TapStartTime { get; set; }
        
        [Property(Column="TAP_END_TIME", Length=38)]
        public virtual string TapEndTime { get; set; }
        
        [Property(Column="AR_DEV_CODE", Length=14)]
        public virtual string ArDevCode { get; set; }
        
        [Property(Column="AR_BLOW_START_TIME", Length=38)]
        public virtual string ArBlowStartTime { get; set; }
        
        [Property(Column="AR_BLOW_END_TIME", Length=38)]
        public virtual string ArBlowEndTime { get; set; }
        
        [Property(Column="REFINE_DEV_CODE_1", Length=16)]
        public virtual string RefineDevCode1 { get; set; }
        
        [Property(Column="REFINE_START_TIME_1", Length=38)]
        public virtual string RefineStartTime1 { get; set; }
        
        [Property(Column="REFINE_END_TIME_1", Length=38)]
        public virtual string RefineEndTime1 { get; set; }
        
        [Property(Column="REFINE_DEV_CODE_2", Length=16)]
        public virtual string RefineDevCode2 { get; set; }
        
        [Property(Column="REFINE_START_TIME_2", Length=38)]
        public virtual string RefineStartTime2 { get; set; }
        
        [Property(Column="REFINE_END_TIME_2", Length=38)]
        public virtual string RefineEndTime2 { get; set; }
        
        [Property(Column="REFINE_DEV_CODE_3", Length=16)]
        public virtual string RefineDevCode3 { get; set; }
        
        [Property(Column="REFINE_START_TIME_3", Length=38)]
        public virtual string RefineStartTime3 { get; set; }
        
        [Property(Column="REFINE_END_TIME_3", Length=38)]
        public virtual string RefineEndTime3 { get; set; }
        
        [Property(Column="REFINE_DEV_CODE_4", Length=16)]
        public virtual string RefineDevCode4 { get; set; }
        
        [Property(Column="REFINE_START_TIME_4", Length=38)]
        public virtual string RefineStartTime4 { get; set; }
        
        [Property(Column="REFINE_END_TIME_4", Length=38)]
        public virtual string RefineEndTime4 { get; set; }
        
        [Property(Column="CC_REQ_TIME", Length=38)]
        public virtual string CcReqTime { get; set; }
        
        [Property(Column="POUR_TIME_BEGIN", Length=38)]
        public virtual string PourTimeBegin { get; set; }
        
        [Property(Column="POUR_TIME_END", Length=38)]
        public virtual string PourTimeEnd { get; set; }
        
        [Property(Column="LADLE_KILL_TIME_PRE_ARR", Length=18)]
        public virtual string LadleKillTimePreArr { get; set; }
        
        [Property(Column="STOP_MARK", Length=12)]
        public virtual string StopMark { get; set; }
        
        [Property(Column="PLAN_HEAT_NO", Length=50)]
        public virtual string PlanHeatNo { get; set; }
        
        [Property(Column="ST_NO_DESC", Length=210)]
        public virtual string StNoDesc { get; set; }
    }
}
