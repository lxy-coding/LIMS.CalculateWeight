using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// ��ͼͬ����ϢModel
    /// </summary>
    public class Ama625  {

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
        /// �������
        /// </summary>
        public  string MAT_TYPE { get; set; }
        /// <summary>
        /// ͬ�����
        /// </summary>
        public  string OP_TYPE { get; set; }
        /// <summary>
        /// ���Ϻ�
        /// </summary>
        public  string MAT_NO { get; set; }
        /// <summary>
        /// ����λ��
        /// </summary>
        public  string MAT_POS { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public  string STOCK_NO { get; set; }
        /// <summary>
        /// ��λ��
        /// </summary>
        public  string STOCK_PLACE_NO { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public  string LAYER_NO { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public  string BACKUP { get; set; }
    }
}
