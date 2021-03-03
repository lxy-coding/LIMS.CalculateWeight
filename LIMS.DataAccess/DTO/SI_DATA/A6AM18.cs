using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// �����ͼͬ����ϢModel
    /// </summary>

    public class A6AM18
    {
        /// <summary>
        /// ���
        /// <summary>
        public long MSG_COUNTER { get; set; }
        public DateTime? MSG_TIME { get; set; }

        public DateTime? READ_TIME { get; set; }

        public string MSG_STATUS { get; set; }

        /// <summary>
        /// �������ͣ�I:Insert;U:Update;D:Delete 
        /// <summary>
        public string OP_DIV { get; set; }
        /// <summary>
        /// ������������
        /// </summary>
        public  string REQ_MAT_TYPE { get; set; }
        /// <summary>
        /// ����ͬ�����
        /// </summary>
        public  string REQ_TYPE { get; set; }
        /// <summary>
        /// ����λ��
        /// </summary>
        public  string REQ_POS { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public  string BACKUP { get; set; }
    }
}
