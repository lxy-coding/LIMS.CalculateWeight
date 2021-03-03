using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// �����춯��ϢModel
    /// </summary>
    public class Ama624
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
        public string PROD_SHIFT_NO { get; set; }
        /// <summary>
        /// ���������
        /// </summary>
        public string PROD_SHIFT_GROUP { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string PROD_MAKER { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public string MAT_TYPE { get; set; }
        /// <summary>
        /// �����춯���
        /// </summary>
        public string MOVE_TYPE { get; set; }
        /// <summary>
        /// ���Ϻ�
        /// </summary>
        public string MAT_NO { get; set; }
        /// <summary>
        /// ԭλ��
        /// </summary>
        public string SOU_POS { get; set; }
        /// <summary>
        /// Ŀ��λ��
        /// </summary>
        public string DES_POS { get; set; }
        /// <summary>
        /// ��/����ƻ���
        /// </summary>
        public string INOUTPUT_PLAN { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string STOCK_NO { get; set; }
        /// <summary>
        /// ��λ��
        /// </summary>
        public string STOCK_PLACE_NO { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public string LAYER_NO { get; set; }
        /// <summary>
        /// ˳���
        /// </summary>
        public string SEQ_NO { get; set; }
        /// <summary>
        /// װ��״̬
        /// </summary>
        public string CHARGED_STATUS { get; set; }
        /// <summary>
        /// �ƻ�ִ��״̬
        /// </summary>
        public string PLAN_FLAG { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string BACKUP { get; set; }
    }
}
