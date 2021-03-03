using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class LIMSI_RAPIDANALYS_SUB
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
        /// �컯��ϵͳ�ж�Ӧ������ID
        /// <summary>
        public virtual decimal? ID { get; set; }
        /// <summary>
        /// ����IDֵ�������������Ψһ���
        /// <summary>
        public virtual decimal? MID { get; set; }
        /// <summary>
        /// ί�е��ţ�ҵ��������
        /// <summary>
        public virtual string SAMPLE_ID { get; set; }
        /// <summary>
        /// Ԫ�ش���
        /// <summary>
        public virtual string ANALYSE_ITEM_CODE { get; set; }
        /// <summary>
        /// Ԫ������
        /// <summary>
        public virtual string ANALYSE_ITEM_NAME { get; set; }
        /// <summary>
        /// �����ֵ
        /// <summary>
        public virtual double? YVALUE { get; set; }
        /// <summary>
        /// ����ʱ��
        /// <summary>
        public virtual DateTime? FINISH_DATE { get; set; }
        /// <summary>
        /// 1������2����ѧ��3��ˮ�֣�4��ұ������
        /// <summary>
        public virtual string ITEM_TYPE { get; set; }
        /// <summary>
        /// ֵ����
        /// <summary>
        public virtual short? VALUE_TYPE { get; set; }
        /// <summary>
        /// Ԫ������
        /// <summary>
        public virtual double? STAND_RANGE_HV { get; set; }
        /// <summary>
        /// Ԫ������
        /// <summary>
        public virtual double? STAND_RANGE_LV { get; set; }
        /// <summary>
        /// Ԫ�����ޱȽϷ�ʽ
        /// <summary>
        public virtual string HV_COMPARE { get; set; }
        /// <summary>
        /// Ԫ�����ޱȽϷ�ʽ
        /// <summary>
        public virtual string LV_COMPARE { get; set; }
        /// <summary>
        /// ���鷽������
        /// <summary>
        public virtual string METHOD_CODE { get; set; }
        /// <summary>
        /// ���鷽������
        /// <summary>
        public virtual string METHOD_NAME { get; set; }
        /// <summary>
        /// ���������
        /// <summary>
        public virtual string SUB_TASK_ID { get; set; }
    }
}

