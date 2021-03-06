using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.DataAccess.DTO
{

    [Serializable]

    public class BilletcastingRealtimeModel
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
        /// 生产班次号
        /// <summary>
        public virtual string PROD_SHIFT_NO { get; set; }
        /// <summary>
        /// 生产班组
        /// <summary>
        public virtual string PROD_SHIFT_GROUP { get; set; }
        /// <summary>
        /// 工号
        /// <summary>
        public virtual string PROD_MAKER { get; set; }
        /// <summary>
        /// 开始时刻
        /// <summary>
        public virtual string START_TIME { get; set; }
        /// <summary>
        /// 结束时刻
        /// <summary>
        public virtual string END_TIME { get; set; }
        /// <summary>
        /// 连铸处理号
        /// <summary>
        public virtual string PROD_NO { get; set; }
        /// <summary>
        /// 设备号（连铸机号）
        /// <summary>
        public virtual string DEV_CODE { get; set; }
        /// <summary>
        /// 炼钢计划号
        /// <summary>
        public virtual string SM_PLAN_NO { get; set; }
        /// <summary>
        /// 制造命令号
        /// <summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// 内部钢种
        /// <summary>
        public virtual string ST_NO { get; set; }
        /// <summary>
        /// 浇铸批号
        /// <summary>
        public virtual string CAST_LOT_NO { get; set; }
        /// <summary>
        /// CAST分割号
        /// <summary>
        public virtual string CAST_DIV_NO { get; set; }
        /// <summary>
        /// 炉号（熔炼号）
        /// <summary>
        public virtual string HEAT_NO { get; set; }
        /// <summary>
        /// 大包剩余浇注时间
        /// <summary>
        public virtual string REMAIN_TIME { get; set; }
        /// <summary>
        /// 大包剩余重量
        /// <summary>
        public virtual string REMAIN_WT_LADLE { get; set; }
        /// <summary>
        /// 中包1剩余重量
        /// <summary>
        public virtual string REMAIN_WT_TUNDISH1 { get; set; }
        /// <summary>
        /// 中包2剩余重量
        /// <summary>
        public virtual string REMAIN_WT_TUNDISH2 { get; set; }
        /// <summary>
        /// 中包1液位
        /// <summary>
        public virtual string TUNDISH1_LIQUID_LEVEL { get; set; }
        /// <summary>
        /// 中包2液位
        /// <summary>
        public virtual string TUNDISH2_LIQUID_LEVEL { get; set; }
        /// <summary>
        /// 中包1连续测温钢水温度
        /// <summary>
        public virtual string TUNDISH1_TEMP { get; set; }
        /// <summary>
        /// 中包2连续测温钢水温度
        /// <summary>
        public virtual string TUNDISH2_TEMP { get; set; }
        public virtual string NOZZLE_AR_GAS_PRESSURE { get; set; }
        public virtual string SLIDE_SURFACE_AR_PRESSURE { get; set; }
        public virtual string CAST_SPEED_1 { get; set; }
        public virtual string CAST_SPEED_2 { get; set; }
        public virtual string CAST_SPEED_3 { get; set; }
        public virtual string CAST_SPEED_4 { get; set; }
        public virtual string CAST_SPEED_5 { get; set; }
        public virtual string CAST_SPEED_6 { get; set; }
        public virtual string CAST_SPEED_7 { get; set; }
        public virtual string CAST_SPEED_8 { get; set; }
        public virtual string CAST_SPEED_9 { get; set; }
        public virtual string CAST_SPEED_10 { get; set; }
        public virtual string LADLE_CASING_DEPTH1 { get; set; }
        public virtual string LADLE_CASING_DEPTH2 { get; set; }
        public virtual string LADLE_CASING_AR { get; set; }
        public virtual string LADLE_CASING_PRESSURE { get; set; }
        public virtual string NOZZLE_AR_FLOW1 { get; set; }
        public virtual string NOZZLE_AR_GAS_PRESSURE1 { get; set; }
        public virtual string SLIDE_SURFACE_AR_FLOW1 { get; set; }
        public virtual string SLIDE_SURFACE_AR_PRESSURE1 { get; set; }
        public virtual string NOZZLE_AR_FLOW2 { get; set; }
        public virtual string NOZZLE_AR_GAS_PRESSURE2 { get; set; }
        public virtual string SLIDE_SURFACE_AR_FLOW2 { get; set; }
        public virtual string SLIDE_SURFACE_AR_PRESSURE2 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_1 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_2 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_3 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_4 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_5 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_6 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_7 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_8 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_9 { get; set; }
        public virtual string STOPPER_AR_PRESSURE_10 { get; set; }
        public virtual string STOPPER_AR_FLOW_1 { get; set; }
        public virtual string STOPPER_AR_FLOW_2 { get; set; }
        public virtual string STOPPER_AR_FLOW_3 { get; set; }
        public virtual string STOPPER_AR_FLOW_4 { get; set; }
        public virtual string STOPPER_AR_FLOW_5 { get; set; }
        public virtual string STOPPER_AR_FLOW_6 { get; set; }
        public virtual string STOPPER_AR_FLOW_7 { get; set; }
        public virtual string STOPPER_AR_FLOW_8 { get; set; }
        public virtual string STOPPER_AR_FLOW_9 { get; set; }
        public virtual string STOPPER_AR_FLOW_10 { get; set; }
        public virtual string PLUG_ROD_1 { get; set; }
        public virtual string PLUG_ROD_2 { get; set; }
        public virtual string PLUG_ROD_3 { get; set; }
        public virtual string PLUG_ROD_4 { get; set; }
        public virtual string PLUG_ROD_5 { get; set; }
        public virtual string PLUG_ROD_6 { get; set; }
        public virtual string PLUG_ROD_7 { get; set; }
        public virtual string PLUG_ROD_8 { get; set; }
        public virtual string PLUG_ROD_9 { get; set; }
        public virtual string PLUG_ROD_10 { get; set; }
        public virtual string ELM_STIRRING_CUR_S1 { get; set; }
        public virtual string ELM_STIRRING_CUR_S2 { get; set; }
        public virtual string ELM_STIRRING_CUR_S3 { get; set; }
        public virtual string ELM_STIRRING_CUR_S4 { get; set; }
        public virtual string ELM_STIRRING_CUR_S5 { get; set; }
        public virtual string ELM_STIRRING_CUR_S6 { get; set; }
        public virtual string ELM_STIRRING_CUR_S7 { get; set; }
        public virtual string ELM_STIRRING_CUR_S8 { get; set; }
        public virtual string ELM_STIRRING_CUR_S9 { get; set; }
        public virtual string ELM_STIRRING_CUR_S10 { get; set; }
        public virtual string ELM_STIRRING_FRE_S1 { get; set; }
        public virtual string ELM_STIRRING_FRE_S2 { get; set; }
        public virtual string ELM_STIRRING_FRE_S3 { get; set; }
        public virtual string ELM_STIRRING_FRE_S4 { get; set; }
        public virtual string ELM_STIRRING_FRE_S5 { get; set; }
        public virtual string ELM_STIRRING_FRE_S6 { get; set; }
        public virtual string ELM_STIRRING_FRE_S7 { get; set; }
        public virtual string ELM_STIRRING_FRE_S8 { get; set; }
        public virtual string ELM_STIRRING_FRE_S9 { get; set; }
        public virtual string ELM_STIRRING_FRE_S10 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S1 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S2 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S3 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S4 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S5 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S6 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S7 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S8 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S9 { get; set; }
        public virtual string C1_E_M_P_W_PRESS_S10 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S1 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S2 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S3 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S4 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S5 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S6 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S7 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S8 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S9 { get; set; }
        public virtual string C1_E_M_P_W_TEMP_S10 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S1 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S2 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S3 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S4 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S5 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S6 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S7 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S8 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S9 { get; set; }
        public virtual string C1_WATER_TEMP_DIFF_S10 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S1 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S2 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S3 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S4 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S5 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S6 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S7 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S8 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S9 { get; set; }
        public virtual string C1_E_M_P_W_FLOW_S10 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S1 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S2 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S3 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S4 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S5 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S6 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S7 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S8 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S9 { get; set; }
        public virtual string C2_E_M_P_W_TEMP_S10 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S1 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S2 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S3 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S4 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S5 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S6 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S7 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S8 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S9 { get; set; }
        public virtual string C2_E_M_P_W_PRESS_S10 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S1 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S2 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S3 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S4 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S5 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S6 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S7 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S8 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S9 { get; set; }
        public virtual string C2_E_M_P_W_FLOW_S10 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S1 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S2 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S3 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S4 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S5 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S6 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S7 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S8 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S9 { get; set; }
        public virtual string C2_COMPAIR_PRESSURE_S10 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S1 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S2 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S3 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S4 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S5 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S6 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S7 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S8 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S9 { get; set; }
        public virtual string C2_COMPAIR_FLOW_S10 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S11 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S12 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S13 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S21 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S22 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S23 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S3 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S4 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S5 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S6 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S7 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S8 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S9 { get; set; }
        public virtual string NOZZLE_INS_DEPTH_S10 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S1 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S2 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S3 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S4 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S5 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S6 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S7 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S8 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S9 { get; set; }
        public virtual string DOWN_GAP_DEPTH_S10 { get; set; }
    }
}

