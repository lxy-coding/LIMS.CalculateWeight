using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class LIMSI_RAPIDANALYS_MAIN
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual decimal? ID { get; set; }
        public virtual string SAMPLE_ID { get; set; }
        public virtual string SAMPLE_SPEC { get; set; }
        public virtual DateTime? SAMPLE_TAKEN_TIME { get; set; }
        public virtual string SAMPLE_MS { get; set; }
        public virtual string STEEL_CODE { get; set; }
        public virtual DateTime? ANALYSIS_END_TIME { get; set; }
        public virtual string HEAT_NO { get; set; }
        public virtual string PONO { get; set; }
        public virtual string ST_SAMPLE_DIV { get; set; }
        public virtual string IRON_NO { get; set; }
        public virtual short? REP_SAMPLE_FLAG { get; set; }
        public virtual string SAMPLE_OF_TIMES { get; set; }
        public virtual string LADLEID { get; set; }
        public virtual string ORDER_IN_CODE { get; set; }
        public virtual string ORDER_TYPE_CODE { get; set; }
        public virtual string SAMP_SITE_CODE { get; set; }
        public virtual string MAT_TYPE_CODE { get; set; }
        public virtual string MAT_CODE { get; set; }
        public virtual string SAMPLE_STATE { get; set; }
        public virtual decimal? PROCESSINSTID { get; set; }
        public virtual string COM_TYPE { get; set; }
        public virtual string COM_PERSON { get; set; }
        public virtual DateTime? ACCEPT_TIME { get; set; }
        public virtual DateTime? ENTR_TIME { get; set; }
        public virtual string ENTR_DEP_NAME { get; set; }
        public virtual string HEAT_ID { get; set; }
        public virtual string STEEL_GRADE_ID { get; set; }
        public virtual string INNER_STG_ID { get; set; }
        public virtual string SAMPLE_PLACE { get; set; }
        public virtual string SAMPLE_NUMBER { get; set; }
        public virtual DateTime? SAMPLE_START_TIME { get; set; }
        public virtual DateTime? SAMPLE_RELEASE_TIME { get; set; }
        public virtual string DESUL_TREATMENT_ID { get; set; }
        public virtual string PREP_EQU_ID { get; set; }
        public virtual string ANALYZER_ID { get; set; }
        public virtual string CLASS_ID { get; set; }
        public virtual string GROUP_ID { get; set; }
        public virtual string OPERATOR_ID { get; set; }
        public virtual string SAMPLE_TYPE { get; set; }
        public virtual DateTime? CREATE_DATE { get; set; }
        public virtual string CREATE_USER { get; set; }
        public virtual DateTime? UPDATE_DATE { get; set; }
        public virtual string UPDATE_USER { get; set; }
        public virtual string YL_TEC_ROUTE { get; set; }
        public virtual string STATE { get; set; }
        public virtual string DEVICES { get; set; }
        public virtual DateTime? REQ_DATE { get; set; }
        public virtual string INSPECTION_STANDARD { get; set; }
        public virtual string INSPECTIONG_STANDARD_NAME { get; set; }
        public virtual string TEST_RESULT { get; set; }
        public virtual string STATE_WAIT { get; set; }
        public virtual short? BAD_SAMPLE { get; set; }
        public virtual string TQ_STATE { get; set; }
        public virtual string ABOLISH_REASON { get; set; }
        public virtual string SAMPLE_HOLDER { get; set; }
        public virtual DateTime? SAMPLING_TIME { get; set; }
        public virtual string ANALYSIS_METHOD { get; set; }
        public virtual string FEEDBACK_LIMIT { get; set; }
        public virtual string TEST_METHOD { get; set; }
        public virtual string ACCEPT_PERSON { get; set; }
        public virtual string ACT_TPC_NO { get; set; }
        public virtual string TPC_NO { get; set; }
        public virtual string UP_PERSON { get; set; }
        public virtual DateTime? UP_DATE { get; set; }
        public virtual string SLAB_NO { get; set; }
        public virtual string STATE_AAA601 { get; set; }
        public virtual string STATE_AAA602 { get; set; }
        public virtual string STATE_AAA603 { get; set; }
        public virtual string STATE_AAA604 { get; set; }
        public virtual string OP_FLAG_AAA601 { get; set; }
        public virtual string OP_FLAG_AAA602 { get; set; }
        public virtual string OP_FLAG_AAA603 { get; set; }
        public virtual string OP_FLAG_AAA604 { get; set; }
        public virtual DateTime? SMALL_UP_TIME { get; set; }
        public virtual DateTime? SMALL_SAMPLE_TIME { get; set; }
        public virtual DateTime? SMALL_PREPSTART_TIME { get; set; }
        public virtual DateTime? SMALL_PREPEND_TIME { get; set; }
        public virtual string SMALL_PREP_TIME { get; set; }
        public virtual string SMALL_ANA_TIME { get; set; }
        public virtual string SMALL_STATION_ID { get; set; }
        public virtual string SMALL_AUDITOR { get; set; }
        public virtual string SMALL_ANAPROG_NAME { get; set; }
    }
}
