using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.DataAccess.DTO
{

    [Serializable]

    public class LimsRapidanalysMainModel
    {
        /// <summary>
        /// ���
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// ��Ϣʱ��
        /// <summary>
        public virtual DateTime? MSG_TIME { get; set; }
        /// <summary>
        /// ��ȡʱ��
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
        /// <summary>
        /// ��Ϣ״̬
        /// <summary>
        public virtual string MSG_STATUS { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string OP_DIV { get; set; }
        /// <summary>
        /// ����ID
        /// <summary>
        public virtual decimal? ID { get; set; }
        /// <summary>
        /// ί�е���
        /// <summary>
        public virtual string SAMPLE_ID { get; set; }
        /// <summary>
        /// ȡ������
        /// <summary>
        public virtual string SAMPLE_SPEC { get; set; }
        /// <summary>
        /// ȡ��ʱ��
        /// <summary>
        public virtual DateTime? SAMPLE_TAKEN_TIME { get; set; }
        /// <summary>
        /// ȡ��λ������
        /// <summary>
        public virtual string SAMPLE_MS { get; set; }
        /// <summary>
        /// ���ֱ���
        /// <summary>
        public virtual string STEEL_CODE { get; set; }
        /// <summary>
        /// �������ʱ��
        /// <summary>
        public virtual DateTime? ANALYSIS_END_TIME { get; set; }
        /// <summary>
        /// ������
        /// <summary>
        public virtual string HEAT_NO { get; set; }
        /// <summary>
        /// ���������
        /// <summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// ����������������
        /// <summary>
        public virtual string ST_SAMPLE_DIV { get; set; }
        /// <summary>
        /// ���κ�
        /// <summary>
        public virtual string IRON_NO { get; set; }
        /// <summary>
        /// ����ɷ�������ʶ
        /// <summary>
        public virtual short? REP_SAMPLE_FLAG { get; set; }
        /// <summary>
        /// ȡ������
        /// <summary>
        public virtual string SAMPLE_OF_TIMES { get; set; }
        /// <summary>
        /// ����
        /// <summary>
        public virtual string LADLEID { get; set; }
        /// <summary>
        /// �ڲ�ί�е���
        /// <summary>
        public virtual string ORDER_IN_CODE { get; set; }
        /// <summary>
        /// ί�����
        /// <summary>
        public virtual string ORDER_TYPE_CODE { get; set; }
        /// <summary>
        /// ȡ��������
        /// <summary>
        public virtual string SAMP_SITE_CODE { get; set; }
        /// <summary>
        /// Ʒ��������
        /// <summary>
        public virtual string MAT_TYPE_CODE { get; set; }
        /// <summary>
        /// Ʒ������
        /// <summary>
        public virtual string MAT_CODE { get; set; }
        /// <summary>
        /// ����״̬
        /// <summary>
        public virtual string SAMPLE_STATE { get; set; }
        /// <summary>
        /// ����ʵ��ID
        /// <summary>
        public virtual decimal? PROCESSINSTID { get; set; }
        /// <summary>
        /// ί������
        /// <summary>
        public virtual string COM_TYPE { get; set; }
        /// <summary>
        /// ί����
        /// <summary>
        public virtual string COM_PERSON { get; set; }
        /// <summary>
        /// ����ʱ��
        /// <summary>
        public virtual DateTime? ACCEPT_TIME { get; set; }
        /// <summary>
        /// ί��ʱ��
        /// <summary>
        public virtual DateTime? ENTR_TIME { get; set; }
        /// <summary>
        /// ί�е�λ����
        /// <summary>
        public virtual string ENTR_DEP_NAME { get; set; }
        /// <summary>
        /// ¯�κ�(��¯��)
        /// <summary>
        public virtual string HEAT_ID { get; set; }
        /// <summary>
        /// �ƺ�/�ⲿ�ƺ�
        /// <summary>
        public virtual string STEEL_GRADE_ID { get; set; }
        /// <summary>
        /// �ڲ��ƺ�
        /// <summary>
        public virtual string INNER_STG_ID { get; set; }
        /// <summary>
        /// ȡ��λ�ñ���
        /// <summary>
        public virtual string SAMPLE_PLACE { get; set; }
        /// <summary>
        /// ȡ��˳���
        /// <summary>
        public virtual string SAMPLE_NUMBER { get; set; }
        /// <summary>
        /// ��⿪ʼʱ��
        /// <summary>
        public virtual DateTime? SAMPLE_START_TIME { get; set; }
        /// <summary>
        /// ������ʱ��
        /// <summary>
        public virtual DateTime? SAMPLE_RELEASE_TIME { get; set; }
        /// <summary>
        /// �������
        /// <summary>
        public virtual string DESUL_TREATMENT_ID { get; set; }
        /// <summary>
        /// �����豸���
        /// <summary>
        public virtual string PREP_EQU_ID { get; set; }
        /// <summary>
        /// �����豸���
        /// <summary>
        public virtual string ANALYZER_ID { get; set; }
        /// <summary>
        /// 1=night shift��ҹ�ࣩ2=day shift���װࣩ
        /// <summary>
        public virtual string CLASS_ID { get; set; }
        /// <summary>
        /// ����ID
        /// <summary>
        public virtual string GROUP_ID { get; set; }
        public virtual string OPERATOR_ID { get; set; }
        /// <summary>
        /// ��Ʒ����
        /// <summary>
        public virtual string SAMPLE_TYPE { get; set; }
        /// <summary>
        /// ����ʱ��
        /// <summary>
        public virtual DateTime? CREATE_DATE { get; set; }
        /// <summary>
        /// ������
        /// <summary>
        public virtual string CREATE_USER { get; set; }
        /// <summary>
        /// ����ʱ��
        /// <summary>
        public virtual DateTime? UPDATE_DATE { get; set; }
        /// <summary>
        /// ������
        /// <summary>
        public virtual string UPDATE_USER { get; set; }
        /// <summary>
        /// ����
        /// <summary>
        public virtual string YL_TEC_ROUTE { get; set; }
        /// <summary>
        /// ״̬
        /// <summary>
        public virtual string STATE { get; set; }
        /// <summary>
        /// �豸��
        /// <summary>
        public virtual string DEVICES { get; set; }
        /// <summary>
        /// Ҫ�����ʱ��(��������)
        /// <summary>
        public virtual DateTime? REQ_DATE { get; set; }
        /// <summary>
        /// �����׼
        /// <summary>
        public virtual string INSPECTION_STANDARD { get; set; }
        /// <summary>
        /// �����׼����
        /// <summary>
        public virtual string INSPECTIONG_STANDARD_NAME { get; set; }
        /// <summary>
        /// ������
        /// <summary>
        public virtual string TEST_RESULT { get; set; }
        /// <summary>
        /// ����״̬
        /// <summary>
        public virtual string STATE_WAIT { get; set; }
        /// <summary>
        /// �������
        /// <summary>
        public virtual short? BAD_SAMPLE { get; set; }
        /// <summary>
        /// ����״̬���������쳣��С���ϵͳ
        /// <summary>
        public virtual string TQ_STATE { get; set; }
        /// <summary>
        /// �÷�ԭ��
        /// <summary>
        public virtual string ABOLISH_REASON { get; set; }
        /// <summary>
        /// ������
        /// <summary>
        public virtual string SAMPLE_HOLDER { get; set; }
        /// <summary>
        /// ����ʱ��
        /// <summary>
        public virtual DateTime? SAMPLING_TIME { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string ANALYSIS_METHOD { get; set; }
        /// <summary>
        /// ����ʱ��
        /// <summary>
        public virtual string FEEDBACK_LIMIT { get; set; }
        /// <summary>
        /// ʵ�鷽��
        /// <summary>
        public virtual string TEST_METHOD { get; set; }
        /// <summary>
        /// ί�н�����
        /// <summary>
        public virtual string ACCEPT_PERSON { get; set; }
        /// <summary>
        /// ¯����
        /// <summary>
        public virtual string ACT_TPC_NO { get; set; }
        /// <summary>
        /// ��ˮ�޺�
        /// <summary>
        public virtual string TPC_NO { get; set; }
        /// <summary>
        /// �ϴ���
        /// <summary>
        public virtual string UP_PERSON { get; set; }
        /// <summary>
        /// �ϴ�ʱ��
        /// <summary>
        public virtual DateTime? UP_DATE { get; set; }
        /// <summary>
        /// ������
        /// <summary>
        public virtual string SLAB_NO { get; set; }
        /// <summary>
        /// ��ˮ������״̬
        /// <summary>
        public virtual string STATE_AAA601 { get; set; }
        /// <summary>
        /// ����������״̬
        /// <summary>
        public virtual string STATE_AAA602 { get; set; }
        /// <summary>
        /// ��ˮ������״̬
        /// <summary>
        public virtual string STATE_AAA603 { get; set; }
        /// <summary>
        /// �����������������״̬
        /// <summary>
        public virtual string STATE_AAA604 { get; set; }
        /// <summary>
        /// ��ˮ������������ʶ
        /// <summary>
        public virtual string OP_FLAG_AAA601 { get; set; }
        /// <summary>
        /// ����������������ʶ
        /// <summary>
        public virtual string OP_FLAG_AAA602 { get; set; }
        /// <summary>
        /// ��ˮ������������ʶ
        /// <summary>
        public virtual string OP_FLAG_AAA603 { get; set; }
        /// <summary>
        /// �����������������������ʶ
        /// <summary>
        public virtual string OP_FLAG_AAA604 { get; set; }
        /// <summary>
        /// С��������ϴ�ʱ��
        /// <summary>
        public virtual DateTime? SMALL_UP_TIME { get; set; }
        /// <summary>
        /// С���ϵͳ����ʱ��
        /// <summary>
        public virtual DateTime? SMALL_SAMPLE_TIME { get; set; }
        /// <summary>
        /// С�������
        /// <summary>
        public virtual DateTime? SMALL_PREPSTART_TIME { get; set; }
        /// <summary>
        /// ��ʼʱ��
        /// <summary>
        public virtual DateTime? SMALL_PREPEND_TIME { get; set; }
        /// <summary>
        /// С�����������ʱ��
        /// <summary>
        public virtual string SMALL_PREP_TIME { get; set; }
        /// <summary>
        /// С�������ʱ��
        /// <summary>
        public virtual string SMALL_ANA_TIME { get; set; }
        /// <summary>
        /// ��վ
        /// <summary>
        public virtual string SMALL_STATION_ID { get; set; }
        /// <summary>
        /// �����
        /// <summary>
        public virtual string SMALL_AUDITOR { get; set; }
        /// <summary>
        /// ����
        /// <summary>
        public virtual string SMALL_ANAPROG_NAME { get; set; }
    }
}
