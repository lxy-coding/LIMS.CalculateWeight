using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM17
    {
        /// <summary>
        /// ���
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// ��Ϣʱ��
        /// <summary>
        public virtual DateTime MSG_TIME { get; set; }
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
        /// ���ƻ���
        /// <summary>
        public virtual string INPUT_PLAN { get; set; }
        /// <summary>
        /// ���Ϻţ������ţ�
        /// <summary>
        public virtual string MAT_NO { get; set; }
        /// <summary>
        /// �������
        /// <summary>
        public virtual string MAT_TYPE { get; set; }
        /// <summary>
        /// ��ⷽʽ
        /// <summary>
        public virtual string IN_TYPE { get; set; }
        /// <summary>
        /// ԭλ��
        /// <summary>
        public virtual string SOU_POS { get; set; }
        /// <summary>
        /// Ŀ��λ��
        /// <summary>
        public virtual string DES_POS { get; set; }
        /// <summary>
        /// ����
        /// <summary>
        public virtual string BACKUP { get; set; }
    }
}
