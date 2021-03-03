using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// ��ˮ��Դ��ϢModel
    /// </summary>
    public class CRANE_IRON_INFO
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
        /// GL_NO	��¯¯��
        /// </summary>
        public string GL_NO { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public string PROC_NO { get; set; }
        /// <summary>
        /// ���κ�
        /// </summary>
        public string IRON_NO { get; set; }
        /// <summary>
        /// ��ˮ�޺�
        /// </summary>
        public string IRON_LADLE_NO { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string HEAT_NO { get; set; }
        /// <summary>
        /// ��ˮ����
        /// </summary>
        public float NET_WT { get; set; }
        /// <summary>
        /// ��ˮ�¶�
        /// </summary>
        public short IRON_TEMP { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? ANALYSIZE_TIME { get; set; }
        /// <summary>
        /// ��ˮ�ɷ�C
        /// </summary>
        public float CF_C { get; set; }
        /// <summary>
        /// ��ˮ�ɷ�SI
        /// </summary>
        public float CF_SI { get; set; }
        /// <summary>
        /// ��ˮ�ɷ�MN
        /// </summary>
        public float CF_MN { get; set; }
        /// <summary>
        /// ��ˮ�ɷ�P
        /// </summary>
        public float CF_P { get; set; }
        /// <summary>
        /// ��ˮ�ɷ�S
        /// </summary>
        public float CF_S { get; set; }
        /// <summary>
        /// ��ˮ�ɷ�Ti
        /// </summary>
        public float CF_TI { get; set; }
        /// <summary>
        /// ��ˮ�ɷ�As
        /// </summary>
        public float CF_AS { get; set; }
        /// <summary>
        /// ��ˮ��Դ
        /// </summary>
        public string MOLTENIRON_SOURCE { get; set; }
        /// <summary>
        /// ��ˮ���뿪ʼʱ��
        /// </summary>
        public DateTime? IRON_LOAD_START_TIME { get; set; }
        /// <summary>
        /// ��ˮ�������ʱ��
        /// </summary>
        public DateTime? IRON_LOAD_END_TIME { get; set; }
        /// <summary>
        /// ¯����
        /// </summary>
        public string HEAT_BATCH_NO { get; set; }
        /// <summary>
        /// �豸�ɼ�����
        /// </summary>
        public float SCALE_WGT { get; set; }
    }
}
