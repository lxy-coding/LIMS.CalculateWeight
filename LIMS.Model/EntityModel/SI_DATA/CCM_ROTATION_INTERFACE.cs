using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class CCM_ROTATION_INTERFACE
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
        public virtual string PLANT_NO { get; set; }
        /// <summary>
        /// A�۽�����־
        /// <summary>
        public virtual string ARMA_CAST { get; set; }
        /// <summary>
        /// B�۽�����־
        /// <summary>
        public virtual string ARMB_CAST { get; set; }
        /// <summary>
        /// ����λ�ۺ�
        /// <summary>
        public virtual string CASTING_FLAG { get; set; }
        /// <summary>
        /// ��������ʱ��
        /// <summary>
        public virtual string TIME_STAMP { get; set; }
        public virtual string FIELD1 { get; set; }
        public virtual string FIELD2 { get; set; }
        public virtual string FIELD3 { get; set; }
    }
}
