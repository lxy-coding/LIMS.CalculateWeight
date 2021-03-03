using System.Collections.Generic;
using System.Text;
using System;

namespace LIMS.DataAccess.DTO
{

    [Serializable]

    public class BilletCoolingBedModel
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
        /// ���������
        /// <summary>
        public virtual string PLANT_NO { get; set; }
        /// <summary>
        /// �䴲λ��
        /// <summary>
        public virtual string POSIT { get; set; }
        /// <summary>
        /// ����1֧������
        /// <summary>
        public virtual string EXTERNAL1_BILLET_NO { get; set; }
        /// <summary>
        /// ����1֧¯�κ�
        /// <summary>
        public virtual string EXTERNAL1_HEAT_NO { get; set; }
        /// <summary>
        /// ����1֧����
        /// <summary>
        public virtual short? EXTERNAL1_STRAND_NO { get; set; }
        /// <summary>
        /// ����2֧������
        /// <summary>
        public virtual string EXTERNAL2_BILLET_NO { get; set; }
        /// <summary>
        /// ����2֧¯�κ�
        /// <summary>
        public virtual string EXTERNAL2_HEAT_NO { get; set; }
        /// <summary>
        /// ����2֧����
        /// <summary>
        public virtual short? EXTERNAL2_STRAND_NO { get; set; }
        /// <summary>
        /// ����3֧������
        /// <summary>
        public virtual string EXTERNAL3_BILLET_NO { get; set; }
        /// <summary>
        /// ����3֧¯�κ�
        /// <summary>
        public virtual string EXTERNAL3_HEAT_NO { get; set; }
        /// <summary>
        /// ����3֧����
        /// <summary>
        public virtual short? EXTERNAL3_STRAND_NO { get; set; }
        /// <summary>
        /// ����4֧������
        /// <summary>
        public virtual string EXTERNAL4_BILLET_NO { get; set; }
        /// <summary>
        /// ����4֧¯�κ�
        /// <summary>
        public virtual string EXTERNAL4_HEAT_NO { get; set; }
        /// <summary>
        /// ����4֧����
        /// <summary>
        public virtual short? EXTERNAL4_STRAND_NO { get; set; }
        /// <summary>
        /// ����5֧������
        /// <summary>
        public virtual string EXTERNAL5_BILLET_NO { get; set; }
        /// <summary>
        /// ����5֧¯�κ�
        /// <summary>
        public virtual string EXTERNAL5_HEAT_NO { get; set; }
        /// <summary>
        /// ����5֧����
        /// <summary>
        public virtual short? EXTERNAL5_STRAND_NO { get; set; }
        /// <summary>
        /// ����6֧������
        /// <summary>
        public virtual string EXTERNAL6_BILLET_NO { get; set; }
        /// <summary>
        /// ����6֧¯�κ�
        /// <summary>
        public virtual string EXTERNAL6_HEAT_NO { get; set; }
        /// <summary>
        /// ����6֧����
        /// <summary>
        public virtual short? EXTERNAL6_STRAND_NO { get; set; }
        /// <summary>
        /// ����7֧������
        /// <summary>
        public virtual string EXTERNAL7_BILLET_NO { get; set; }
        /// <summary>
        /// ����7֧¯�κ�
        /// <summary>
        public virtual string EXTERNAL7_HEAT_NO { get; set; }
        /// <summary>
        /// ����7֧����
        /// <summary>
        public virtual short? EXTERNAL7_STRAND_NO { get; set; }
        /// <summary>
        /// ���ݲ���ʱ��
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
    }
}
