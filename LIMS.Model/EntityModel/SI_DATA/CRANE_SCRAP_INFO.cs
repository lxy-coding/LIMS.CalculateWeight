using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// �ϸ������ϢModel
    /// </summary>

    public class CRANE_SCRAP_INFO
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
        /// ������
        /// </summary>
        public string HEAT_NO { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string HOPPER_NO { get; set; }
        /// <summary>
        /// ԭ����������
        /// </summary>
        public short MAT_COUNT { get; set; }
        /// <summary>
        /// ��ͨ��������
        /// </summary>
        public float MATWET1 { get; set; }
        /// <summary>
        /// ��������������
        /// </summary>
        public float MATWET2 { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public float MATWET3 { get; set; }
        /// <summary>
        /// ͳ������
        /// </summary>
        public float MATWET4 { get; set; }
        /// <summary>
        /// һ��ϸ�����
        /// </summary>
        public float MATWET5 { get; set; }
        /// <summary>
        /// ����ϸ�����
        /// </summary>
        public float MATWET6 { get; set; }

        /// <summary>
        /// �ϸ�����
        /// </summary>
        public float SCRAP_WGT { get; set; }
        /// <summary>
        /// �ϸּ��뿪ʼʱ��
        /// </summary>
        public DateTime? SCRAP_LOAD_START_TIME { get; set; }
        /// <summary>
        /// �ϸּ������ʱ��
        /// </summary>
        public DateTime? SCRAP_LOAD_END_TIME { get; set; }
        /// <summary>
        /// ����ί�е���
        /// </summary>
        public string REFE_ID { get; set; }

        public float SCALE_WGT { get; set; }
    }
}
