using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class AMA620
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string PROD_SHIFT_NO { get; set; }
        public virtual string PROD_SHIFT_GROUP { get; set; }
        public virtual string PROD_MAKER { get; set; }
        public virtual string PROC_NO { get; set; }
        public virtual string DEV_CODE { get; set; }
        public virtual string SM_PLAN_NO { get; set; }
        public virtual string PONO { get; set; }
        public virtual string PREC_ST_NO { get; set; }
        public virtual string CAST_LOT_NO { get; set; }
        public virtual string CAST_DIV_NO { get; set; }
        public virtual string HEAT_NO { get; set; }
        public virtual string STRAND_NO { get; set; }
        public virtual string MAT_CUT_SEQ { get; set; }
        public virtual string MAT_NO { get; set; }
        public virtual string CUST_MAT_NO { get; set; }
        public virtual string PRE_MAT_NO { get; set; }
        public virtual string ORDER_NO { get; set; }
        public virtual string CUT_ST_NO { get; set; }
        public virtual string MAT_THICK { get; set; }
        public virtual string MAT_WIDTH { get; set; }
        public virtual string MAT_LEN { get; set; }
        public virtual string MAT_WT { get; set; }
        public virtual string WT_MODE { get; set; }
        public virtual string MAT_PLAN_DEST { get; set; }
        public virtual string ADJUST_WIDTH_MARK { get; set; }
        public virtual string MAT_HEAD_WIDTH { get; set; }
        public virtual string MAT_TAIL_WIDTH { get; set; }
        public virtual string MAT_TAPPER_WIDTH_START { get; set; }
        public virtual string MAT_TAPPER_WIDTH_LEN { get; set; }
        public virtual string MAT_TYPE { get; set; }
        public virtual string IF_TRANSFER { get; set; }
        public virtual string PONO_CONNECT { get; set; }
        public virtual string CONNECT_START_POS { get; set; }
        public virtual string CONNECT_END_POS { get; set; }
        public virtual string MAT_PLACE_CODE { get; set; }
        public virtual string MAT_CUT_TIME { get; set; }
        public virtual string CUT_POS { get; set; }
        public virtual string FACTORY_DIV { get; set; }
        public virtual string RCF_CODE { get; set; }
        public virtual string NEXT_SLAB_CUT_TIME { get; set; }
        public virtual string MAT_QUAL_FLG { get; set; }
        public virtual string HOT_CHARGE_FLAG { get; set; }
        public virtual string HOT_SEND_FLAG { get; set; }
        public virtual string HOT_SEND_DECNDE { get; set; }
        public virtual string HOT_SEND_STOP_CAUSE { get; set; }
        public virtual string QUALITY_ABN_CODE { get; set; }
        public virtual string CUT_TOP_TAR_LEN { get; set; }
        public virtual string CUT_TAIL_LEN { get; set; }
        public virtual string MAT_HOT_SEND_PLAN { get; set; }
        public virtual string TAR_LEN { get; set; }
        public virtual string MAX_LEN { get; set; }
        public virtual string MIN_LEN { get; set; }
        public virtual string FIN_CUT_FLG { get; set; }
        public virtual string UNIT_METER_WEIGHT { get; set; }
        public virtual string CUT_BG_LENGTH { get; set; }
        public virtual string CUT_ED_LENGTH { get; set; }
        public virtual string JJQ_YMBD_1 { get; set; }
        public virtual string JJQ_YMBD_2 { get; set; }
        public virtual string JJQ_YMBD_3 { get; set; }
        public virtual string ZJB_YMBD_BG1 { get; set; }
        public virtual string ZJB_YMBD_ED1 { get; set; }
        public virtual string ZJB_YMBD_BG2 { get; set; }
        public virtual string ZJB_YMBD_ED2 { get; set; }
        public virtual string ZJB_YMBD_BG3 { get; set; }
        public virtual string ZJB_YMBD_ED3 { get; set; }
        public virtual string LSYC_BG1 { get; set; }
        public virtual string LSYC_ED1 { get; set; }
        public virtual string LSYC_BG2 { get; set; }
        public virtual string LSYC_ED2 { get; set; }
        public virtual string LSYC_BG3 { get; set; }
        public virtual string LSYC_ED3 { get; set; }
        public virtual string LSYC_CAUSE { get; set; }
        public virtual string IF_AUTO { get; set; }
        public virtual string SDKZ_BG { get; set; }
        public virtual string SDKZ_ED { get; set; }
        public virtual string GSN_BG1 { get; set; }
        public virtual string GSN_ED1 { get; set; }
        public virtual string GSN_BG2 { get; set; }
        public virtual string GSN_ED2 { get; set; }
        public virtual string CKJZ_REASON { get; set; }
        public virtual string DEST_FLAG { get; set; }
        public virtual string PROCESS_PATH { get; set; }
    }
}
