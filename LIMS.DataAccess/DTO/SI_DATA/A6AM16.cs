using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// ����������ϢModel
    /// </summary>
    
    public class A6AM16
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
        /// ����ƻ���
        /// </summary>
        public  string OUTPUT_PLAN { get; set; }
        /// <summary>
        /// ���Ϻ�
        /// </summary>
        public  string MAT_NO { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public  string MAT_TYPE { get; set; }
        /// <summary>
        /// ���ⷽʽ
        /// </summary>
        public  string OUT_TYPE { get; set; }
        /// <summary>
        /// ԭλ��
        /// </summary>
        public  string SOU_POS { get; set; }
        /// <summary>
        /// Ŀ��λ��
        /// </summary>
        public  string DES_POS { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public  string STOCK_NO { get; set; }
        /// <summary>
        /// ��λ��
        /// </summary>
        public  string STOCK_PLACE_NO { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public  string BACKUP { get; set; }
    }
}
