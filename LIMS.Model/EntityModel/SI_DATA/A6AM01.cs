using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM01
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
        /// ��������
        /// <summary>
        public virtual string CAST_LOT_NO { get; set; }
        /// <summary>
        /// �ƻ���
        /// <summary>
        public virtual string SM_PLAN_NO { get; set; }
        /// <summary>
        /// ���������
        /// <summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// �ڲ����֣����ּǺţ�
        /// <summary>
        public virtual string ST_NO { get; set; }
        /// <summary>
        /// ������¯��
        /// <summary>
        public virtual string CAST_LOT_SUM { get; set; }
        /// <summary>
        /// �����ڷָ���
        /// <summary>
        public virtual string CAST_LOT_DIV_NO { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string CC_MACH_NO { get; set; }
        /// <summary>
        /// ����������
        /// <summary>
        public virtual string CC_TYPE { get; set; }
        /// <summary>
        /// ����·�����������֣�
        /// <summary>
        public virtual string REFINE_ROUTE_CODE { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string REFINE_NUM { get; set; }
        /// <summary>
        /// �ƻ�������
        /// <summary>
        public virtual string PLAN_TAP_WT { get; set; }
        /// <summary>
        /// ¯����
        /// <summary>
        public virtual string FURNACE_NO { get; set; }
        /// <summary>
        /// ���м����־
        /// <summary>
        public virtual string TD_CHG_FLG { get; set; }
        /// <summary>
        /// ұ����ʽ
        /// <summary>
        public virtual string MAKING_METHOD_CM { get; set; }
        /// <summary>
        /// ����ת¯��
        /// <summary>
        public virtual string DP_BOF_NO_CM { get; set; }
        /// <summary>
        /// ����ת¯��ԭ��װ��ʼʱ��
        /// <summary>
        public virtual string DP_BOF_START_TIME { get; set; }
        /// <summary>
        /// ���״�����ʼʱ��
        /// <summary>
        public virtual string DP_BLOW_START_TIME { get; set; }
        /// <summary>
        /// ���״�������ʱ��
        /// <summary>
        public virtual string DP_BLOW_END_TIME { get; set; }
        /// <summary>
        /// ����¯���ֿ�ʼʱ��
        /// <summary>
        public virtual string DP_TAP_START_TIME { get; set; }
        /// <summary>
        /// ����¯���ֽ���ʱ��
        /// <summary>
        public virtual string DP_TAP_END_TIME { get; set; }
        /// <summary>
        /// ����̼ת¯����ԭ��װ��ʼʱ��
        /// <summary>
        public virtual string BOF_START_CHR_TIME { get; set; }
        /// <summary>
        /// ����ʱ��(��̼������ʼʱ��)
        /// <summary>
        public virtual string BLOW_START_TIME { get; set; }
        /// <summary>
        /// ��������ʱ��(��̼��������ʱ��)
        /// <summary>
        public virtual string BLOW_END_TIME { get; set; }
        /// <summary>
        /// ���ֿ�ʼʱ��
        /// <summary>
        public virtual string TAP_START_TIME { get; set; }
        /// <summary>
        /// ������ֹʱ��
        /// <summary>
        public virtual string TAP_END_TIME { get; set; }
        /// <summary>
        /// �վ��λ��
        /// <summary>
        public virtual string AR_DEV_CODE { get; set; }
        /// <summary>
        /// �վ����ʼʱ��
        /// <summary>
        public virtual string AR_BLOW_START_TIME { get; set; }
        /// <summary>
        /// �վ�������ʱ��
        /// <summary>
        public virtual string AR_BLOW_END_TIME { get; set; }
        /// <summary>
        /// ����1��λ��
        /// <summary>
        public virtual string REFINE_DEV_CODE_1 { get; set; }
        /// <summary>
        /// ����1��ʼʱ��
        /// <summary>
        public virtual string REFINE_START_TIME_1 { get; set; }
        /// <summary>
        /// ����1����ʱ��
        /// <summary>
        public virtual string REFINE_END_TIME_1 { get; set; }
        /// <summary>
        /// ����2��λ��
        /// <summary>
        public virtual string REFINE_DEV_CODE_2 { get; set; }
        /// <summary>
        /// ����2��ʼʱ��
        /// <summary>
        public virtual string REFINE_START_TIME_2 { get; set; }
        /// <summary>
        /// ����2����ʱ��
        /// <summary>
        public virtual string REFINE_END_TIME_2 { get; set; }
        /// <summary>
        /// ����3��λ��
        /// <summary>
        public virtual string REFINE_DEV_CODE_3 { get; set; }
        /// <summary>
        /// ����3��ʼʱ��
        /// <summary>
        public virtual string REFINE_START_TIME_3 { get; set; }
        /// <summary>
        /// ����3����ʱ��
        /// <summary>
        public virtual string REFINE_END_TIME_3 { get; set; }
        /// <summary>
        /// ����4��λ��
        /// <summary>
        public virtual string REFINE_DEV_CODE_4 { get; set; }
        /// <summary>
        /// ����4��ʼʱ��
        /// <summary>
        public virtual string REFINE_START_TIME_4 { get; set; }
        /// <summary>
        /// ����4����ʱ��
        /// <summary>
        public virtual string REFINE_END_TIME_4 { get; set; }
        /// <summary>
        /// MMS�ƻ���ʼ��עʱ��
        /// <summary>
        public virtual string CC_REQ_TIME { get; set; }
        /// <summary>
        /// ��ע��ʼʱ��
        /// <summary>
        public virtual string POUR_TIME_BEGIN { get; set; }
        /// <summary>
        /// ��ע����ʱ��
        /// <summary>
        public virtual string POUR_TIME_END { get; set; }
        /// <summary>
        /// �ְ��򾲣��絽��ʱ��
        /// <summary>
        public virtual string LADLE_KILL_TIME_PRE_ARR { get; set; }
        /// <summary>
        /// ¯��ָʾ
        /// <summary>
        public virtual string STOP_MARK { get; set; }
        /// <summary>
        /// �ƻ�������
        /// <summary>
        public virtual string PLAN_HEAT_NO { get; set; }
        /// <summary>
        /// �ڲ���������
        /// <summary>
        public virtual string ST_NO_DESC { get; set; }
    }
}
