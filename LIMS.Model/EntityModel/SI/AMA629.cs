using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class AMA629
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string PROD_SHIFT_NO { get; set; }
        public virtual string PROD_SHIFT_GROUP { get; set; }
        public virtual string PROD_MAKER { get; set; }
        public virtual string START_TIME { get; set; }
        public virtual string END_TIME { get; set; }
        public virtual string PROD_NO { get; set; }
        public virtual string DEV_CODE { get; set; }
        public virtual string SM_PLAN_NO { get; set; }
        public virtual string PONO { get; set; }
        public virtual string ST_NO { get; set; }
        public virtual string CAST_LOT_NO { get; set; }
        public virtual string CAST_DIV_NO { get; set; }
        public virtual string HEAT_NO { get; set; }
        public virtual string REMAIN_TIME { get; set; }
        public virtual string REMAIN_WT_LADLE { get; set; }
        public virtual string REMAIN_WT_TUNDISH { get; set; }
        public virtual string TUNDISH_LIQUID_LEVEL { get; set; }
        public virtual string TUNDISH_TEMP { get; set; }
        public virtual string NOZZLE_AR_GAS_PRESSURE { get; set; }
        public virtual string SLIDE_SURFACE_AR_PRESSURE { get; set; }
        public virtual string CAST_SPEED_1 { get; set; }
        public virtual string CAST_SPEED_2 { get; set; }
        public virtual string LADLE_CASING_DEPTH1 { get; set; }
        public virtual string LADLE_CASING_DEPTH2 { get; set; }
        public virtual string LADLE_CASING_AR { get; set; }
        public virtual string LADLE_CASING_PRESSURE { get; set; }
        public virtual string NOZZLE_AR_FLOW1 { get; set; }
        public virtual string NOZZLE_AR_GAS_PRESSURE1 { get; set; }
        public virtual string SLIDE_SURFACE_AR_FLOW1 { get; set; }
        public virtual string SLIDE_SURFACE_AR_PRESSURE1 { get; set; }
        public virtual string MOLD1_LEFT_NARROW_FLUX { get; set; }
        public virtual string MOLD1_LEFT_NARROW_TEMP { get; set; }
        public virtual string MOLD1_RIGHT_NARROW_FLUX { get; set; }
        public virtual string MOLD1_RIGHT_NARROW_TEMP { get; set; }
        public virtual string MOLD1_OUT_WIDE_FLUX { get; set; }
        public virtual string MOLD1_OUT_WIDE_TEMP { get; set; }
        public virtual string MOLD1_IN_WIDE_FLUX { get; set; }
        public virtual string MOLD1_IN_WIDE_TEMP { get; set; }
        public virtual string NOZZLE_AR_FLOW2 { get; set; }
        public virtual string NOZZLE_AR_GAS_PRESSURE2 { get; set; }
        public virtual string SLIDE_SURFACE_AR_FLOW2 { get; set; }
        public virtual string SLIDE_SURFACE_AR_PRESSURE2 { get; set; }
        public virtual string MOLD2_LEFT_NARROW_FLUX { get; set; }
        public virtual string MOLD2_LEFT_NARROW_TEMP { get; set; }
        public virtual string MOLD2_RIGHT_NARROW_FLUX { get; set; }
        public virtual string MOLD2_RIGHT_NARROW_TEMP { get; set; }
        public virtual string MOLD2_OUT_WIDE_FLUX { get; set; }
        public virtual string MOLD2_OUT_WIDE_TEMP { get; set; }
        public virtual string MOLD2_IN_WIDE_FLUX { get; set; }
        public virtual string MOLD2_IN_WIDE_TEMP { get; set; }
        public virtual string STOPPER_AR_PRESSURE_1 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_2 { get; set; }
        public virtual string STOPPER_AR_FLOW_1 { get; set; }
        public virtual string STOPPER_AR_FLOW_2 { get; set; }
        public virtual string PLUG_ROD_1 { get; set; }
        public virtual string PLUG_ROD_2 { get; set; }
        public virtual string ELM_STIRRING_CUR_S1 { get; set; }
        public virtual string ELM_STIRRING_CUR_S2 { get; set; }
        public virtual string ELM_STIRRING_FRE_S1 { get; set; }
        public virtual string ELM_STIRRING_FRE_S2 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S1 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S2 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S1 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S2 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S1 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S2 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S1 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S2 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S1 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S2 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S1 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S2 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S1 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S2 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S1 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S2 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S1 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S2 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S11 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S12 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S13 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S21 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S22 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S23 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S1 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S2 { get; set; }
    }
}
