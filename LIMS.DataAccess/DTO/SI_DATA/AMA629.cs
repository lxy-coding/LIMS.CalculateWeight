using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class Ama629 : ActiveRecordValidationBase<Ama629> {
        
        [Property(Column="MSG_COUNTER", Length=22, NotNull=true)]
        public virtual long MsgCounter { get; set; }
        
        [Property(Column="MSG_TIME", Length=7)]
        public virtual System.DateTime MsgTime { get; set; }
        
        [Property(Column="READ_TIME", Length=7)]
        public virtual System.DateTime ReadTime { get; set; }
        
        [Property(Column="MSG_STATUS", Length=8)]
        public virtual string MsgStatus { get; set; }
        
        [Property(Column="OP_DIV", Length=2)]
        public virtual string OpDiv { get; set; }
        
        [Property(Column="PROD_SHIFT_NO", Length=2)]
        public virtual string ProdShiftNo { get; set; }
        
        [Property(Column="PROD_SHIFT_GROUP", Length=2)]
        public virtual string ProdShiftGroup { get; set; }
        
        [Property(Column="PROD_MAKER", Length=16)]
        public virtual string ProdMaker { get; set; }
        
        [Property(Column="START_TIME", Length=28)]
        public virtual string StartTime { get; set; }
        
        [Property(Column="END_TIME", Length=28)]
        public virtual string EndTime { get; set; }
        
        [Property(Column="PROD_NO", Length=18)]
        public virtual string ProdNo { get; set; }
        
        [Property(Column="DEV_CODE", Length=6)]
        public virtual string DevCode { get; set; }
        
        [Property(Column="SM_PLAN_NO", Length=20)]
        public virtual string SmPlanNo { get; set; }
        
        [Property(Column="PONO", Length=20)]
        public virtual string Pono { get; set; }
        
        [Property(Column="ST_NO", Length=40)]
        public virtual string StNo { get; set; }
        
        [Property(Column="CAST_LOT_NO", Length=20)]
        public virtual string CastLotNo { get; set; }
        
        [Property(Column="CAST_DIV_NO", Length=6)]
        public virtual string CastDivNo { get; set; }
        
        [Property(Column="HEAT_NO", Length=18)]
        public virtual string HeatNo { get; set; }
        
        [Property(Column="REMAIN_TIME", Length=8)]
        public virtual string RemainTime { get; set; }
        
        [Property(Column="REMAIN_WT_LADLE", Length=14)]
        public virtual string RemainWtLadle { get; set; }
        
        [Property(Column="REMAIN_WT_TUNDISH", Length=14)]
        public virtual string RemainWtTundish { get; set; }
        
        [Property(Column="TUNDISH_LIQUID_LEVEL", Length=8)]
        public virtual string TundishLiquidLevel { get; set; }
        
        [Property(Column="TUNDISH_TEMP", Length=8)]
        public virtual string TundishTemp { get; set; }
        
        [Property(Column="NOZZLE_AR_GAS_PRESSURE", Length=8)]
        public virtual string NozzleArGasPressure { get; set; }
        
        [Property(Column="SLIDE_SURFACE_AR_PRESSURE", Length=8)]
        public virtual string SlideSurfaceArPressure { get; set; }
        
        [Property(Column="CAST_SPEED_1", Length=8)]
        public virtual string CastSpeed1 { get; set; }
        
        [Property(Column="CAST_SPEED_2", Length=8)]
        public virtual string CastSpeed2 { get; set; }
        
        [Property(Column="LADLE_CASING_DEPTH1", Length=8)]
        public virtual string LadleCasingDepth1 { get; set; }
        
        [Property(Column="LADLE_CASING_DEPTH2", Length=8)]
        public virtual string LadleCasingDepth2 { get; set; }
        
        [Property(Column="LADLE_CASING_AR", Length=8)]
        public virtual string LadleCasingAr { get; set; }
        
        [Property(Column="LADLE_CASING_PRESSURE", Length=8)]
        public virtual string LadleCasingPressure { get; set; }
        
        [Property(Column="NOZZLE_AR_FLOW1", Length=20)]
        public virtual string NozzleArFlow1 { get; set; }
        
        [Property(Column="NOZZLE_AR_GAS_PRESSURE1", Length=8)]
        public virtual string NozzleArGasPressure1 { get; set; }
        
        [Property(Column="SLIDE_SURFACE_AR_FLOW1", Length=20)]
        public virtual string SlideSurfaceArFlow1 { get; set; }
        
        [Property(Column="SLIDE_SURFACE_AR_PRESSURE1", Length=14)]
        public virtual string SlideSurfaceArPressure1 { get; set; }
        
        [Property(Column="MOLD1_LEFT_NARROW_FLUX", Length=8)]
        public virtual string Mold1LeftNarrowFlux { get; set; }
        
        [Property(Column="MOLD1_LEFT_NARROW_TEMP", Length=14)]
        public virtual string Mold1LeftNarrowTemp { get; set; }
        
        [Property(Column="MOLD1_RIGHT_NARROW_FLUX", Length=8)]
        public virtual string Mold1RightNarrowFlux { get; set; }
        
        [Property(Column="MOLD1_RIGHT_NARROW_TEMP", Length=14)]
        public virtual string Mold1RightNarrowTemp { get; set; }
        
        [Property(Column="MOLD1_OUT_WIDE_FLUX", Length=8)]
        public virtual string Mold1OutWideFlux { get; set; }
        
        [Property(Column="MOLD1_OUT_WIDE_TEMP", Length=14)]
        public virtual string Mold1OutWideTemp { get; set; }
        
        [Property(Column="MOLD1_IN_WIDE_FLUX", Length=8)]
        public virtual string Mold1InWideFlux { get; set; }
        
        [Property(Column="MOLD1_IN_WIDE_TEMP", Length=14)]
        public virtual string Mold1InWideTemp { get; set; }
        
        [Property(Column="NOZZLE_AR_FLOW2", Length=20)]
        public virtual string NozzleArFlow2 { get; set; }
        
        [Property(Column="NOZZLE_AR_GAS_PRESSURE2", Length=8)]
        public virtual string NozzleArGasPressure2 { get; set; }
        
        [Property(Column="SLIDE_SURFACE_AR_FLOW2", Length=20)]
        public virtual string SlideSurfaceArFlow2 { get; set; }
        
        [Property(Column="SLIDE_SURFACE_AR_PRESSURE2", Length=14)]
        public virtual string SlideSurfaceArPressure2 { get; set; }
        
        [Property(Column="MOLD2_LEFT_NARROW_FLUX", Length=8)]
        public virtual string Mold2LeftNarrowFlux { get; set; }
        
        [Property(Column="MOLD2_LEFT_NARROW_TEMP", Length=14)]
        public virtual string Mold2LeftNarrowTemp { get; set; }
        
        [Property(Column="MOLD2_RIGHT_NARROW_FLUX", Length=8)]
        public virtual string Mold2RightNarrowFlux { get; set; }
        
        [Property(Column="MOLD2_RIGHT_NARROW_TEMP", Length=14)]
        public virtual string Mold2RightNarrowTemp { get; set; }
        
        [Property(Column="MOLD2_OUT_WIDE_FLUX", Length=8)]
        public virtual string Mold2OutWideFlux { get; set; }
        
        [Property(Column="MOLD2_OUT_WIDE_TEMP", Length=14)]
        public virtual string Mold2OutWideTemp { get; set; }
        
        [Property(Column="MOLD2_IN_WIDE_FLUX", Length=8)]
        public virtual string Mold2InWideFlux { get; set; }
        
        [Property(Column="MOLD2_IN_WIDE_TEMP", Length=14)]
        public virtual string Mold2InWideTemp { get; set; }
        
        [Property(Column="STOPPER_AR_PRESSURE_1", Length=8)]
        public virtual string StopperArPressure1 { get; set; }
        
        [Property(Column="STOPPER_AR_PRESSURE_2", Length=8)]
        public virtual string StopperArPressure2 { get; set; }
        
        [Property(Column="STOPPER_AR_FLOW_1", Length=20)]
        public virtual string StopperArFlow1 { get; set; }
        
        [Property(Column="STOPPER_AR_FLOW_2", Length=20)]
        public virtual string StopperArFlow2 { get; set; }
        
        [Property(Column="PLUG_ROD_1", Length=6)]
        public virtual string PlugRod1 { get; set; }
        
        [Property(Column="PLUG_ROD_2", Length=6)]
        public virtual string PlugRod2 { get; set; }
        
        [Property(Column="ELM_STIRRING_CUR_S1", Length=12)]
        public virtual string ElmStirringCurS1 { get; set; }
        
        [Property(Column="ELM_STIRRING_CUR_S2", Length=12)]
        public virtual string ElmStirringCurS2 { get; set; }
        
        [Property(Column="ELM_STIRRING_FRE_S1", Length=12)]
        public virtual string ElmStirringFreS1 { get; set; }
        
        [Property(Column="ELM_STIRRING_FRE_S2", Length=12)]
        public virtual string ElmStirringFreS2 { get; set; }
        
        [Property(Column="C1_E_M_P_W_PRESS_S1", Length=8)]
        public virtual string C1EMPWPressS1 { get; set; }
        
        [Property(Column="C1_E_M_P_W_PRESS_S2", Length=8)]
        public virtual string C1EMPWPressS2 { get; set; }
        
        [Property(Column="C1_E_M_P_W_TEMP_S1", Length=8)]
        public virtual string C1EMPWTempS1 { get; set; }
        
        [Property(Column="C1_E_M_P_W_TEMP_S2", Length=8)]
        public virtual string C1EMPWTempS2 { get; set; }
        
        [Property(Column="C1_WATER_TEMP_DIFF_S1", Length=8)]
        public virtual string C1WaterTempDiffS1 { get; set; }
        
        [Property(Column="C1_WATER_TEMP_DIFF_S2", Length=8)]
        public virtual string C1WaterTempDiffS2 { get; set; }
        
        [Property(Column="C1_E_M_P_W_FLOW_S1", Length=20)]
        public virtual string C1EMPWFlowS1 { get; set; }
        
        [Property(Column="C1_E_M_P_W_FLOW_S2", Length=20)]
        public virtual string C1EMPWFlowS2 { get; set; }
        
        [Property(Column="C2_E_M_P_W_TEMP_S1", Length=8)]
        public virtual string C2EMPWTempS1 { get; set; }
        
        [Property(Column="C2_E_M_P_W_TEMP_S2", Length=8)]
        public virtual string C2EMPWTempS2 { get; set; }
        
        [Property(Column="C2_E_M_P_W_PRESS_S1", Length=8)]
        public virtual string C2EMPWPressS1 { get; set; }
        
        [Property(Column="C2_E_M_P_W_PRESS_S2", Length=8)]
        public virtual string C2EMPWPressS2 { get; set; }
        
        [Property(Column="C2_E_M_P_W_FLOW_S1", Length=20)]
        public virtual string C2EMPWFlowS1 { get; set; }
        
        [Property(Column="C2_E_M_P_W_FLOW_S2", Length=20)]
        public virtual string C2EMPWFlowS2 { get; set; }
        
        [Property(Column="C2_COMPAIR_PRESSURE_S1", Length=8)]
        public virtual string C2CompairPressureS1 { get; set; }
        
        [Property(Column="C2_COMPAIR_PRESSURE_S2", Length=8)]
        public virtual string C2CompairPressureS2 { get; set; }
        
        [Property(Column="C2_COMPAIR_FLOW_S1", Length=20)]
        public virtual string C2CompairFlowS1 { get; set; }
        
        [Property(Column="C2_COMPAIR_FLOW_S2", Length=20)]
        public virtual string C2CompairFlowS2 { get; set; }
        
        [Property(Column="NOZZLE_INS_DEPTH_S11", Length=8)]
        public virtual string NozzleInsDepthS11 { get; set; }
        
        [Property(Column="NOZZLE_INS_DEPTH_S12", Length=8)]
        public virtual string NozzleInsDepthS12 { get; set; }
        
        [Property(Column="NOZZLE_INS_DEPTH_S13", Length=8)]
        public virtual string NozzleInsDepthS13 { get; set; }
        
        [Property(Column="NOZZLE_INS_DEPTH_S21", Length=8)]
        public virtual string NozzleInsDepthS21 { get; set; }
        
        [Property(Column="NOZZLE_INS_DEPTH_S22", Length=8)]
        public virtual string NozzleInsDepthS22 { get; set; }
        
        [Property(Column="NOZZLE_INS_DEPTH_S23", Length=8)]
        public virtual string NozzleInsDepthS23 { get; set; }
        
        [Property(Column="DOWN_GAP_DEPTH_S1", Length=8)]
        public virtual string DownGapDepthS1 { get; set; }
        
        [Property(Column="DOWN_GAP_DEPTH_S2", Length=8)]
        public virtual string DownGapDepthS2 { get; set; }
    }
}
