using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM19
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
        /// ������
        /// <summary>
        public virtual string VEHICLE_NO { get; set; }
        /// <summary>
        /// ����
        /// <summary>
        public virtual string HOPPER_NO { get; set; }
        /// <summary>
        /// ����ί�е���
        /// <summary>
        public virtual string REFE_ID { get; set; }
        /// <summary>
        /// ����
        /// <summary>
        public virtual string NET_WEIGHT { get; set; }
        /// <summary>
        /// Ƥ��
        /// <summary>
        public virtual string TARE { get; set; }
        /// <summary>
        /// ë��
        /// <summary>
        public virtual string GROSS_WEIGHT { get; set; }
        /// <summary>
        /// ί��״̬
        /// <summary>
        public virtual string REFE_STATUS { get; set; }
        /// <summary>
        /// Ʒ������
        /// <summary>
        public virtual string PROD_ID { get; set; }
        /// <summary>
        /// Ʒ������
        /// <summary>
        public virtual string PROD_CNAME { get; set; }
        /// <summary>
        /// ��Դ��λ����
        /// <summary>
        public virtual string SRC_DEPT_ID { get; set; }
        /// <summary>
        /// ��Դ��λ����
        /// <summary>
        public virtual string SRC_DEPT_NAME { get; set; }
        /// <summary>
        /// ��Դ��ű���
        /// <summary>
        public virtual string SRC_STOCK_ID { get; set; }
        /// <summary>
        /// ��Դ�������
        /// <summary>
        public virtual string SRC_STOCK_NAME { get; set; }
        /// <summary>
        /// ȥ��λ����
        /// <summary>
        public virtual string DEST_DEPT_ID { get; set; }
        /// <summary>
        /// ȥ��λ����
        /// <summary>
        public virtual string DEST_DEPT_NAME { get; set; }
        /// <summary>
        /// ȥ���ű���
        /// <summary>
        public virtual string DEST_STOCK_ID { get; set; }
        /// <summary>
        /// ȥ��������
        /// <summary>
        public virtual string DEST_STOCK_NAME { get; set; }
        /// <summary>
        /// ҵ������
        /// <summary>
        public virtual string BUSINESS_TYPE { get; set; }
        /// <summary>
        /// ί������
        /// <summary>
        public virtual string REFE_TYPE { get; set; }
        /// <summary>
        /// ί�д���ʱ��
        /// <summary>
        public virtual string REFE_DATE { get; set; }
        /// <summary>
        /// ί�д���������
        /// <summary>
        public virtual string REFE_CREATOR { get; set; }
        /// <summary>
        /// �����
        /// <summary>
        public virtual string BAR_CODE { get; set; }
        /// <summary>
        /// ��ͨ��������
        /// <summary>
        public virtual string MATWET1 { get; set; }
        /// <summary>
        /// ������������
        /// <summary>
        public virtual string MATWET2 { get; set; }
        /// <summary>
        /// ��������
        /// <summary>
        public virtual string MATWET3 { get; set; }
        /// <summary>
        /// ͳ������
        /// <summary>
        public virtual string MATWET4 { get; set; }
        /// <summary>
        /// һ��ϸ�����
        /// <summary>
        public virtual string MATWET5 { get; set; }
        /// <summary>
        /// ����ϸ�����
        /// <summary>
        public virtual string MATWET6 { get; set; }
        /// <summary>
        /// ����ʱ��
        /// <summary>
        public virtual string GROSS_WEIGHT_TIME { get; set; }
    }
}
