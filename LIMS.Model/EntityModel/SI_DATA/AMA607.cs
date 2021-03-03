using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel
{


    [Serializable]
    public class AMA607
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
        /// �����
        /// <summary>
        public virtual string PROC_NO { get; set; }
        /// <summary>
        /// �豸����
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
        /// ¯�ţ������ţ�
        /// <summary>
        public virtual string HEAT_NO { get; set; }
        /// <summary>
        /// �¶�ֵ
        /// <summary>
        public virtual string TEMP_VAL { get; set; }
        /// <summary>
        /// ����ʱ��
        /// <summary>
        public virtual string MEASURE_TIME { get; set; }

    }
}
