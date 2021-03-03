using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class A6am10 : ActiveRecordValidationBase<A6am10> {
        
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
        
        [Property(Column="ST_NO", Length=50)]
        public virtual string StNo { get; set; }
        
        [Property(Column="ST_NO_DESC", Length=210)]
        public virtual string StNoDesc { get; set; }
        
        [Property(Column="VALID_FLAG", Length=12)]
        public virtual string ValidFlag { get; set; }
        
        [Property(Column="MSC_LINE_NO", Length=18)]
        public virtual string MscLineNo { get; set; }
        
        [Property(Column="DEFAULT_FLAG", Length=12)]
        public virtual string DefaultFlag { get; set; }
        
        [Property(Column="HOLD_FLAG", Length=12)]
        public virtual string HoldFlag { get; set; }
        
        [Property(Column="WHOLE_BACKLOG", Length=110)]
        public virtual string WholeBacklog { get; set; }
        
        [Property(Column="WHOLE_BACKLOG_SEQ", Length=14)]
        public virtual string WholeBacklogSeq { get; set; }
        
        [Property(Column="WHOLE_BACKLOG_CODE", Length=14)]
        public virtual string WholeBacklogCode { get; set; }
        
        [Property(Column="WHOLE_BACKLOG_NAME", Length=42)]
        public virtual string WholeBacklogName { get; set; }
        
        [Property(Column="SCRAP_WT_MIN", Length=20)]
        public virtual string ScrapWtMin { get; set; }
        
        [Property(Column="SCRAP_WT_MAX", Length=20)]
        public virtual string ScrapWtMax { get; set; }
        
        [Property(Column="TL_RATE_MIN", Length=24)]
        public virtual string TlRateMin { get; set; }
        
        [Property(Column="TL_RATE_MAX", Length=24)]
        public virtual string TlRateMax { get; set; }
        
        [Property(Column="ZG_RATE_MIN", Length=24)]
        public virtual string ZgRateMin { get; set; }
        
        [Property(Column="ZG_RATE_MAX", Length=24)]
        public virtual string ZgRateMax { get; set; }
        
        [Property(Column="PTST_RATE_MIN", Length=24)]
        public virtual string PtstRateMin { get; set; }
        
        [Property(Column="PTST_RATE_MAX", Length=24)]
        public virtual string PtstRateMax { get; set; }
        
        [Property(Column="FG1_RATE_MIN", Length=24)]
        public virtual string Fg1RateMin { get; set; }
        
        [Property(Column="FG1_RATE_MAX", Length=24)]
        public virtual string Fg1RateMax { get; set; }
        
        [Property(Column="FG2_RATE_MIN", Length=24)]
        public virtual string Fg2RateMin { get; set; }
        
        [Property(Column="FG2_RATE_MAX", Length=24)]
        public virtual string Fg2RateMax { get; set; }
        
        [Property(Column="DNST_RATE_MIN", Length=24)]
        public virtual string DnstRateMin { get; set; }
        
        [Property(Column="DNST_RATE_MAX", Length=24)]
        public virtual string DnstRateMax { get; set; }
        
        [Property(Column="BOF_IRON_WT_MIN", Length=24)]
        public virtual string BofIronWtMin { get; set; }
        
        [Property(Column="BOF_IRON_WT_MAX", Length=24)]
        public virtual string BofIronWtMax { get; set; }
        
        [Property(Column="IRON_TEMP_MIN", Length=18)]
        public virtual string IronTempMin { get; set; }
        
        [Property(Column="IRON_TEMP_MAX", Length=18)]
        public virtual string IronTempMax { get; set; }
        
        [Property(Column="SI_MIN", Length=26)]
        public virtual string SiMin { get; set; }
        
        [Property(Column="SI_MAX", Length=26)]
        public virtual string SiMax { get; set; }
        
        [Property(Column="MN_MIN", Length=26)]
        public virtual string MnMin { get; set; }
        
        [Property(Column="MN_MAX", Length=26)]
        public virtual string MnMax { get; set; }
        
        [Property(Column="P_MAX_FE", Length=26)]
        public virtual string PMaxFe { get; set; }
        
        [Property(Column="S_MAX", Length=26)]
        public virtual string SMax { get; set; }
        
        [Property(Column="AS_MAX", Length=26)]
        public virtual string AsMax { get; set; }
        
        [Property(Column="NI_MAX", Length=26)]
        public virtual string NiMax { get; set; }
        
        [Property(Column="CR_MAX", Length=26)]
        public virtual string CrMax { get; set; }
        
        [Property(Column="CU_MAX", Length=26)]
        public virtual string CuMax { get; set; }
        
        [Property(Column="MO_MAX", Length=26)]
        public virtual string MoMax { get; set; }
        
        [Property(Column="B_MAX", Length=26)]
        public virtual string BMax { get; set; }
        
        [Property(Column="TI_MAX", Length=26)]
        public virtual string TiMax { get; set; }
        
        [Property(Column="BT_BLOW_CODE", Length=14)]
        public virtual string BtBlowCode { get; set; }
        
        [Property(Column="BT_BLOW_DESC", Length=42)]
        public virtual string BtBlowDesc { get; set; }
        
        [Property(Column="BOF_DEO_ALLOY_CODE", Length=18)]
        public virtual string BofDeoAlloyCode { get; set; }
        
        [Property(Column="BOF_ALLOY_CODE", Length=18)]
        public virtual string BofAlloyCode { get; set; }
        
        [Property(Column="BOF_SLAG_MODE_CODE", Length=12)]
        public virtual string BofSlagModeCode { get; set; }
        
        [Property(Column="BOF_SLAG_MODE_DESC", Length=22)]
        public virtual string BofSlagModeDesc { get; set; }
        
        [Property(Column="BOF_SLAG_TYPE_CODE", Length=14)]
        public virtual string BofSlagTypeCode { get; set; }
        
        [Property(Column="BOF_SLAG_TYPE_DESC", Length=42)]
        public virtual string BofSlagTypeDesc { get; set; }
        
        [Property(Column="MGO_MIN", Length=24)]
        public virtual string MgoMin { get; set; }
        
        [Property(Column="MGO_MAX", Length=24)]
        public virtual string MgoMax { get; set; }
        
        [Property(Column="R_MIN", Length=24)]
        public virtual string RMin { get; set; }
        
        [Property(Column="R_MAX", Length=24)]
        public virtual string RMax { get; set; }
        
        [Property(Column="C_MIN", Length=26)]
        public virtual string CMin { get; set; }
        
        [Property(Column="C_MAX", Length=26)]
        public virtual string CMax { get; set; }
        
        [Property(Column="P_MIN", Length=26)]
        public virtual string PMin { get; set; }
        
        [Property(Column="P_MAX", Length=26)]
        public virtual string PMax { get; set; }
        
        [Property(Column="DEO_AL_MIN", Length=24)]
        public virtual string DeoAlMin { get; set; }
        
        [Property(Column="DEO_AL_MAX", Length=24)]
        public virtual string DeoAlMax { get; set; }
        
        [Property(Column="DEO_SICABA_MIN", Length=24)]
        public virtual string DeoSicabaMin { get; set; }
        
        [Property(Column="DEO_SICABA_MAX", Length=24)]
        public virtual string DeoSicabaMax { get; set; }
        
        [Property(Column="DEO_SIALCABA_MIN", Length=24)]
        public virtual string DeoSialcabaMin { get; set; }
        
        [Property(Column="DEO_SIALCABA_MAX", Length=24)]
        public virtual string DeoSialcabaMax { get; set; }
        
        [Property(Column="DEO_SIC_MIN", Length=24)]
        public virtual string DeoSicMin { get; set; }
        
        [Property(Column="DEO_SIC_MAX", Length=24)]
        public virtual string DeoSicMax { get; set; }
        
        [Property(Column="LIME_MIN", Length=24)]
        public virtual string LimeMin { get; set; }
        
        [Property(Column="LIME_MAX", Length=24)]
        public virtual string LimeMax { get; set; }
        
        [Property(Column="INT_SLAG_MIN", Length=24)]
        public virtual string IntSlagMin { get; set; }
        
        [Property(Column="INT_SLAG_MAX", Length=24)]
        public virtual string IntSlagMax { get; set; }
        
        [Property(Column="FLUORITE_MIN", Length=24)]
        public virtual string FluoriteMin { get; set; }
        
        [Property(Column="FLUORITE_MAX", Length=24)]
        public virtual string FluoriteMax { get; set; }
        
        [Property(Column="JL_SLAG_MIN", Length=24)]
        public virtual string JlSlagMin { get; set; }
        
        [Property(Column="JL_SLAG_MAX", Length=24)]
        public virtual string JlSlagMax { get; set; }
        
        [Property(Column="GZJ_MIN", Length=24)]
        public virtual string GzjMin { get; set; }
        
        [Property(Column="GZJ_MAX", Length=24)]
        public virtual string GzjMax { get; set; }
        
        [Property(Column="DGN_MIN", Length=24)]
        public virtual string DgnMin { get; set; }
        
        [Property(Column="DGN_MAX", Length=24)]
        public virtual string DgnMax { get; set; }
        
        [Property(Column="SILICON_SAND_MIN", Length=24)]
        public virtual string SiliconSandMin { get; set; }
        
        [Property(Column="SILICON_SAND_MAX", Length=24)]
        public virtual string SiliconSandMax { get; set; }
        
        [Property(Column="LD_TYPE", Length=18)]
        public virtual string LdType { get; set; }
        
        [Property(Column="LD_TYPE_DESC", Length=42)]
        public virtual string LdTypeDesc { get; set; }
        
        [Property(Column="LD_STATE", Length=18)]
        public virtual string LdState { get; set; }
        
        [Property(Column="LD_STATE_DESC", Length=42)]
        public virtual string LdStateDesc { get; set; }
        
        [Property(Column="LD_MATERIAL", Length=18)]
        public virtual string LdMaterial { get; set; }
        
        [Property(Column="LD_MATERIAL_DESC", Length=42)]
        public virtual string LdMaterialDesc { get; set; }
        
        [Property(Column="REC_CREATOR", Length=58)]
        public virtual string RecCreator { get; set; }
        
        [Property(Column="REC_CREATE_TIME", Length=38)]
        public virtual string RecCreateTime { get; set; }
        
        [Property(Column="REC_REVISOR", Length=58)]
        public virtual string RecRevisor { get; set; }
        
        [Property(Column="REC_REVISE_TIME", Length=38)]
        public virtual string RecReviseTime { get; set; }
        
        [Property(Column="BACK_CODE_1", Length=50)]
        public virtual string BackCode1 { get; set; }
        
        [Property(Column="BACK_CODE_2", Length=50)]
        public virtual string BackCode2 { get; set; }
        
        [Property(Column="BACK_CODE_3", Length=50)]
        public virtual string BackCode3 { get; set; }
        
        [Property(Column="BACK_CODE_4", Length=50)]
        public virtual string BackCode4 { get; set; }
        
        [Property(Column="BACK_CODE_5", Length=50)]
        public virtual string BackCode5 { get; set; }
        
        [Property(Column="BACK_CODE_6", Length=50)]
        public virtual string BackCode6 { get; set; }
        
        [Property(Column="BACK_CODE_7", Length=50)]
        public virtual string BackCode7 { get; set; }
        
        [Property(Column="BACK_CODE_8", Length=50)]
        public virtual string BackCode8 { get; set; }
        
        [Property(Column="BACK_CODE_9", Length=50)]
        public virtual string BackCode9 { get; set; }
        
        [Property(Column="BACK_CODE_10", Length=50)]
        public virtual string BackCode10 { get; set; }
    }
}
