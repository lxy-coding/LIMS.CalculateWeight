using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class Ama620 : ActiveRecordValidationBase<Ama620> {
        
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
        
        [Property(Column="PROC_NO", Length=18)]
        public virtual string ProcNo { get; set; }
        
        [Property(Column="DEV_CODE", Length=6)]
        public virtual string DevCode { get; set; }
        
        [Property(Column="SM_PLAN_NO", Length=20)]
        public virtual string SmPlanNo { get; set; }
        
        [Property(Column="PONO", Length=20)]
        public virtual string Pono { get; set; }
        
        [Property(Column="PREC_ST_NO", Length=40)]
        public virtual string PrecStNo { get; set; }
        
        [Property(Column="CAST_LOT_NO", Length=20)]
        public virtual string CastLotNo { get; set; }
        
        [Property(Column="CAST_DIV_NO", Length=6)]
        public virtual string CastDivNo { get; set; }
        
        [Property(Column="HEAT_NO", Length=18)]
        public virtual string HeatNo { get; set; }
        
        [Property(Column="STRAND_NO", Length=2)]
        public virtual string StrandNo { get; set; }
        
        [Property(Column="MAT_CUT_SEQ", Length=6)]
        public virtual string MatCutSeq { get; set; }
        
        [Property(Column="MAT_NO", Length=40)]
        public virtual string MatNo { get; set; }
        
        [Property(Column="CUST_MAT_NO", Length=40)]
        public virtual string CustMatNo { get; set; }
        
        [Property(Column="PRE_MAT_NO", Length=40)]
        public virtual string PreMatNo { get; set; }
        
        [Property(Column="ORDER_NO", Length=40)]
        public virtual string OrderNo { get; set; }
        
        [Property(Column="CUT_ST_NO", Length=40)]
        public virtual string CutStNo { get; set; }
        
        [Property(Column="MAT_THICK", Length=10)]
        public virtual string MatThick { get; set; }
        
        [Property(Column="MAT_WIDTH", Length=10)]
        public virtual string MatWidth { get; set; }
        
        [Property(Column="MAT_LEN", Length=10)]
        public virtual string MatLen { get; set; }
        
        [Property(Column="MAT_WT", Length=14)]
        public virtual string MatWt { get; set; }
        
        [Property(Column="WT_MODE", Length=2)]
        public virtual string WtMode { get; set; }
        
        [Property(Column="MAT_PLAN_DEST", Length=4)]
        public virtual string MatPlanDest { get; set; }
        
        [Property(Column="ADJUST_WIDTH_MARK", Length=2)]
        public virtual string AdjustWidthMark { get; set; }
        
        [Property(Column="MAT_HEAD_WIDTH", Length=10)]
        public virtual string MatHeadWidth { get; set; }
        
        [Property(Column="MAT_TAIL_WIDTH", Length=10)]
        public virtual string MatTailWidth { get; set; }
        
        [Property(Column="MAT_TAPPER_WIDTH_START", Length=10)]
        public virtual string MatTapperWidthStart { get; set; }
        
        [Property(Column="MAT_TAPPER_WIDTH_LEN", Length=10)]
        public virtual string MatTapperWidthLen { get; set; }
        
        [Property(Column="MAT_TYPE", Length=2)]
        public virtual string MatType { get; set; }
        
        [Property(Column="IF_TRANSFER", Length=2)]
        public virtual string IfTransfer { get; set; }
        
        [Property(Column="PONO_CONNECT", Length=10)]
        public virtual string PonoConnect { get; set; }
        
        [Property(Column="CONNECT_START_POS", Length=10)]
        public virtual string ConnectStartPos { get; set; }
        
        [Property(Column="CONNECT_END_POS", Length=10)]
        public virtual string ConnectEndPos { get; set; }
        
        [Property(Column="MAT_PLACE_CODE", Length=2)]
        public virtual string MatPlaceCode { get; set; }
        
        [Property(Column="MAT_CUT_TIME", Length=28)]
        public virtual string MatCutTime { get; set; }
        
        [Property(Column="CUT_POS", Length=4)]
        public virtual string CutPos { get; set; }
        
        [Property(Column="FACTORY_DIV", Length=6)]
        public virtual string FactoryDiv { get; set; }
        
        [Property(Column="RCF_CODE", Length=14)]
        public virtual string RcfCode { get; set; }
        
        [Property(Column="NEXT_SLAB_CUT_TIME", Length=28)]
        public virtual string NextSlabCutTime { get; set; }
        
        [Property(Column="MAT_QUAL_FLG", Length=20)]
        public virtual string MatQualFlg { get; set; }
        
        [Property(Column="HOT_CHARGE_FLAG", Length=20)]
        public virtual string HotChargeFlag { get; set; }
        
        [Property(Column="HOT_SEND_FLAG", Length=20)]
        public virtual string HotSendFlag { get; set; }
        
        [Property(Column="HOT_SEND_DECNDE", Length=2)]
        public virtual string HotSendDecnde { get; set; }
        
        [Property(Column="HOT_SEND_STOP_CAUSE", Length=20)]
        public virtual string HotSendStopCause { get; set; }
        
        [Property(Column="QUALITY_ABN_CODE", Length=40)]
        public virtual string QualityAbnCode { get; set; }
        
        [Property(Column="CUT_TOP_TAR_LEN", Length=8)]
        public virtual string CutTopTarLen { get; set; }
        
        [Property(Column="CUT_TAIL_LEN", Length=8)]
        public virtual string CutTailLen { get; set; }
        
        [Property(Column="MAT_HOT_SEND_PLAN", Length=40)]
        public virtual string MatHotSendPlan { get; set; }
        
        [Property(Column="TAR_LEN", Length=8)]
        public virtual string TarLen { get; set; }
        
        [Property(Column="MAX_LEN", Length=8)]
        public virtual string MaxLen { get; set; }
        
        [Property(Column="MIN_LEN", Length=8)]
        public virtual string MinLen { get; set; }
        
        [Property(Column="FIN_CUT_FLG", Length=2)]
        public virtual string FinCutFlg { get; set; }
        
        [Property(Column="UNIT_METER_WEIGHT", Length=14)]
        public virtual string UnitMeterWeight { get; set; }
        
        [Property(Column="CUT_BG_LENGTH", Length=22)]
        public virtual string CutBgLength { get; set; }
        
        [Property(Column="CUT_ED_LENGTH", Length=22)]
        public virtual string CutEdLength { get; set; }
        
        [Property(Column="JJQ_YMBD_1", Length=8)]
        public virtual string JjqYmbd1 { get; set; }
        
        [Property(Column="JJQ_YMBD_2", Length=8)]
        public virtual string JjqYmbd2 { get; set; }
        
        [Property(Column="JJQ_YMBD_3", Length=8)]
        public virtual string JjqYmbd3 { get; set; }
        
        [Property(Column="ZJB_YMBD_BG1", Length=22)]
        public virtual string ZjbYmbdBg1 { get; set; }
        
        [Property(Column="ZJB_YMBD_ED1", Length=22)]
        public virtual string ZjbYmbdEd1 { get; set; }
        
        [Property(Column="ZJB_YMBD_BG2", Length=22)]
        public virtual string ZjbYmbdBg2 { get; set; }
        
        [Property(Column="ZJB_YMBD_ED2", Length=22)]
        public virtual string ZjbYmbdEd2 { get; set; }
        
        [Property(Column="ZJB_YMBD_BG3", Length=22)]
        public virtual string ZjbYmbdBg3 { get; set; }
        
        [Property(Column="ZJB_YMBD_ED3", Length=22)]
        public virtual string ZjbYmbdEd3 { get; set; }
        
        [Property(Column="LSYC_BG1", Length=22)]
        public virtual string LsycBg1 { get; set; }
        
        [Property(Column="LSYC_ED1", Length=22)]
        public virtual string LsycEd1 { get; set; }
        
        [Property(Column="LSYC_BG2", Length=22)]
        public virtual string LsycBg2 { get; set; }
        
        [Property(Column="LSYC_ED2", Length=22)]
        public virtual string LsycEd2 { get; set; }
        
        [Property(Column="LSYC_BG3", Length=22)]
        public virtual string LsycBg3 { get; set; }
        
        [Property(Column="LSYC_ED3", Length=22)]
        public virtual string LsycEd3 { get; set; }
        
        [Property(Column="LSYC_CAUSE", Length=160)]
        public virtual string LsycCause { get; set; }
        
        [Property(Column="IF_AUTO", Length=20)]
        public virtual string IfAuto { get; set; }
        
        [Property(Column="SDKZ_BG", Length=22)]
        public virtual string SdkzBg { get; set; }
        
        [Property(Column="SDKZ_ED", Length=22)]
        public virtual string SdkzEd { get; set; }
        
        [Property(Column="GSN_BG1", Length=22)]
        public virtual string GsnBg1 { get; set; }
        
        [Property(Column="GSN_ED1", Length=22)]
        public virtual string GsnEd1 { get; set; }
        
        [Property(Column="GSN_BG2", Length=22)]
        public virtual string GsnBg2 { get; set; }
        
        [Property(Column="GSN_ED2", Length=22)]
        public virtual string GsnEd2 { get; set; }
        
        [Property(Column="CKJZ_REASON", Length=160)]
        public virtual string CkjzReason { get; set; }
        
        [Property(Column="DEST_FLAG", Length=2)]
        public virtual string DestFlag { get; set; }
        
        [Property(Column="PROCESS_PATH", Length=64)]
        public virtual string ProcessPath { get; set; }
    }
}
