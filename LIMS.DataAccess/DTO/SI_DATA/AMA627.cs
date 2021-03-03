using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// �ϸ��볧ʵ����ϢModel
    /// </summary>
    public class AMA627
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
        /// ������κ�
        /// </summary>
        public  string PROD_SHIFT_NO { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public  string PROD_SHIFT_GROUP { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public  string PROD_MAKER { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public  string VEHICLE_NO { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public  string HOPPER_NO { get; set; }
        /// <summary>
        /// ����ί�е���
        /// </summary>
        public  string REFE_ID { get; set; }
    }
}
