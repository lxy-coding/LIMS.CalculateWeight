using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class AMA620
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
        /// ������κ�
        /// <summary>
        public virtual string PROD_SHIFT_NO { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string PROD_SHIFT_GROUP { get; set; }
        /// <summary>
        /// ����
        /// <summary>
        public virtual string PROD_MAKER { get; set; }
        /// <summary>
        /// ���������
        /// <summary>
        public virtual string PROC_NO { get; set; }
        /// <summary>
        /// �豸��
        /// <summary>
        public virtual string DEV_CODE { get; set; }
        /// <summary>
        /// ���ּƻ���
        /// <summary>
        public virtual string SM_PLAN_NO { get; set; }
        /// <summary>
        /// ���������
        /// <summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// �ڲ�����
        /// <summary>
        public virtual string PREC_ST_NO { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string CAST_LOT_NO { get; set; }
        /// <summary>
        /// cast_lot�ָ��
        /// <summary>
        public virtual string CAST_DIV_NO { get; set; }
        /// <summary>
        /// ¯�ţ������ţ�
        /// <summary>
        public virtual string HEAT_NO { get; set; }
        /// <summary>
        /// ����
        /// <summary>
        public virtual string STRAND_NO { get; set; }
        /// <summary>
        /// ��ˮ�ţ������жϴ���ţ�
        /// <summary>
        public virtual string MAT_CUT_SEQ { get; set; }
        /// <summary>
        /// ���Ϻ�
        /// <summary>
        public virtual string MAT_NO { get; set; }
        /// <summary>
        /// ����ʵ��Ǻ� 
        /// <summary>
        public virtual string CUST_MAT_NO { get; set; }
        /// <summary>
        /// �ƻ�������
        /// <summary>
        public virtual string PRE_MAT_NO { get; set; }
        /// <summary>
        /// ��ͬ��
        /// <summary>
        public virtual string ORDER_NO { get; set; }
        /// <summary>
        /// �ж��ڲ�����
        /// <summary>
        public virtual string CUT_ST_NO { get; set; }
        /// <summary>
        /// �������
        /// <summary>
        public virtual string MAT_THICK { get; set; }
        /// <summary>
        /// �������
        /// <summary>
        public virtual string MAT_WIDTH { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string MAT_LEN { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string MAT_WT { get; set; }
        /// <summary>
        /// ���ط�ʽ
        /// <summary>
        public virtual string WT_MODE { get; set; }
        /// <summary>
        /// �����ƻ�ȥ��
        /// <summary>
        public virtual string MAT_PLAN_DEST { get; set; }
        /// <summary>
        /// ������
        /// <summary>
        public virtual string ADJUST_WIDTH_MARK { get; set; }
        /// <summary>
        /// ����ͷ�����
        /// <summary>
        public virtual string MAT_HEAD_WIDTH { get; set; }
        /// <summary>
        /// ����β�����
        /// <summary>
        public virtual string MAT_TAIL_WIDTH { get; set; }
        /// <summary>
        /// ������ȱ仯��ʼ��
        /// <summary>
        public virtual string MAT_TAPPER_WIDTH_START { get; set; }
        /// <summary>
        /// ������ȱ仯����
        /// <summary>
        public virtual string MAT_TAPPER_WIDTH_LEN { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string MAT_TYPE { get; set; }
        /// <summary>
        /// �Ƿ񽻽���(���Ӳ�����)
        /// <summary>
        public virtual string IF_TRANSFER { get; set; }
        /// <summary>
        /// ¯�ν��ӵ�
        /// <summary>
        public virtual string PONO_CONNECT { get; set; }
        /// <summary>
        /// ���Ӳ���ʼλ��
        /// <summary>
        public virtual string CONNECT_START_POS { get; set; }
        /// <summary>
        /// ���Ӳ���ֹλ��
        /// <summary>
        public virtual string CONNECT_END_POS { get; set; }
        /// <summary>
        /// ����λ�ô���
        /// <summary>
        public virtual string MAT_PLACE_CODE { get; set; }
        /// <summary>
        /// �����ж�ʱ��
        /// <summary>
        public virtual string MAT_CUT_TIME { get; set; }
        /// <summary>
        /// �ж�λ��
        /// <summary>
        public virtual string CUT_POS { get; set; }
        public virtual string FACTORY_DIV { get; set; }
        public virtual string RCF_CODE { get; set; }
        /// <summary>
        /// ��һ�����Ԥ���и����ʱ��
        /// <summary>
        public virtual string NEXT_SLAB_CUT_TIME { get; set; }
        /// <summary>
        /// ���������ж���־
        /// <summary>
        public virtual string MAT_QUAL_FLG { get; set; }
        /// <summary>
        /// HCR��־
        /// <summary>
        public virtual string HOT_CHARGE_FLAG { get; set; }
        /// <summary>
        /// ���ͱ�־
        /// <summary>
        public virtual string HOT_SEND_FLAG { get; set; }
        /// <summary>
        /// ���Ϳɷ��־
        /// <summary>
        public virtual string HOT_SEND_DECNDE { get; set; }
        /// <summary>
        /// ������ֹԭ��
        /// <summary>
        public virtual string HOT_SEND_STOP_CAUSE { get; set; }
        /// <summary>
        /// Ʒ���쳣����
        /// <summary>
        public virtual string QUALITY_ABN_CODE { get; set; }
        /// <summary>
        /// ��ͷĿ�곤��
        /// <summary>
        public virtual string CUT_TOP_TAR_LEN { get; set; }
        /// <summary>
        /// ��β����
        /// <summary>
        public virtual string CUT_TAIL_LEN { get; set; }
        /// <summary>
        /// �������ͼƻ�
        /// <summary>
        public virtual string MAT_HOT_SEND_PLAN { get; set; }
        /// <summary>
        /// Ŀ�궨��
        /// <summary>
        public virtual string TAR_LEN { get; set; }
        /// <summary>
        /// ��󶨳�
        /// <summary>
        public virtual string MAX_LEN { get; set; }
        /// <summary>
        /// ��С����
        /// <summary>
        public virtual string MIN_LEN { get; set; }
        /// <summary>
        /// �����и����־
        /// <summary>
        public virtual string FIN_CUT_FLG { get; set; }
        /// <summary>
        /// �׵���
        /// <summary>
        public virtual string UNIT_METER_WEIGHT { get; set; }
        /// <summary>
        /// ����ȥ���־
        /// <summary>
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
        /// <summary>
        /// ����ȥ���־
        /// <summary>
        public virtual string DEST_FLAG { get; set; }
        /// <summary>
        /// ȫ�̹���;������
        /// <summary>
        public virtual string PROCESS_PATH { get; set; }
    }
}
