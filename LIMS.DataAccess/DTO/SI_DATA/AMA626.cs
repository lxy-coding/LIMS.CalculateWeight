using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// ��λͬ����ϢModel
    /// </summary>
    
    public class Ama626 {

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
        /// ��λ���
        /// </summary>
        public  string POS_TYPE { get; set; }
        /// <summary>
        /// ���-������
        /// </summary>
        public  string POS_YARD { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public  string POS_AREA { get; set; }
        /// <summary>
        /// �к�
        /// </summary>
        public  string POS_COLUMN { get; set; }
        /// <summary>
        /// �к�
        /// </summary>
        public  string POS_ROW { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public  string POS_LAYER { get; set; }
        /// <summary>
        /// �߼�λ��
        /// </summary>
        public  string POS_NO { get; set; }
        /// <summary>
        /// ��λ����
        /// </summary>
        public  string POS_REMARK { get; set; }
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
