using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 铁水信息表
    /// </summary>
    public class MoltenlronDto
    {
        /// <summary>
        /// 炉批号
        /// </summary>
        public string HEAT_BATCH_NO { get; set; }

        /// <summary>
        /// 铁包号
        /// </summary>
        public string HML_NUM { get; set; }

        /// <summary>
        /// 入厂皮重
        /// </summary>
        public string GROSS_WT { get; set; }

        /// <summary>
        /// 入厂毛重
        /// </summary>
        public string TARE_WT { get; set; }

        /// <summary>
        /// 入厂净重
        /// </summary>
        public string NET_WT { get; set; }

        /// <summary>
        /// 入厂温度
        /// </summary>
        public string IRON_TEMP { get; set; }

        /// <summary>
        /// 入厂Si
        /// </summary>
        public string CF_SI { get; set; }

        /// <summary>
        /// 入厂Mn
        /// </summary>
        public string CF_MN { get; set; }

        /// <summary>
        /// 入厂P
        /// </summary>
        public string CF_P { get; set; }

        /// <summary>
        /// 入厂S
        /// </summary>
        public string CF_S { get; set; }

        /// <summary>
        /// 入厂As
        /// </summary>
        public string CF_AS { get; set; }

        /// <summary>
        /// 重罐过磅时间
        /// </summary>
        public DateTime? PONDER_TIME { get; set; }

        /// <summary>
        /// 入库位置ID
        /// </summary>
        public int INPUT_WST { get; set; }

        /// <summary>
        /// 入库位置
        /// </summary>
        public string SHORT_NAME { get; set; }

        /// <summary>
        /// 入库操作员ID
        /// </summary>
        public int USER_ID { get; set; }

        /// <summary>
        /// 入库班组ID
        /// </summary>
        public int TEAM_ID { get; set; }


        /// <summary>
        /// 入库操作员
        /// </summary>
        public string USER_Name { get; set; }

        /// <summary>
        /// 入库班组
        /// </summary>
        public string TEAM_Name { get; set; }

        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime? INPUT_STAMP { get; set; }

        /// <summary>
        /// G样Si
        /// </summary>
        public string G_Si { get; set; }

        /// <summary>
        /// G样Mn
        /// </summary>
        public string G_Mn { get; set; }

        /// <summary>
        /// G样P
        /// </summary>
        public string G_P { get; set; }

        /// <summary>
        /// G样S
        /// </summary>
        public string G_S { get; set; }

        /// <summary>
        /// 脱硫站ID
        /// </summary>
        public int DES_ID { get; set; }

        /// <summary>
        /// 脱硫站
        /// </summary>
        public string DES_Name { get; set; }

        /// <summary>
        /// 脱硫处理号
        /// </summary>
        public string DEAL_NUM { get; set; }

        /// <summary>
        /// 脱硫后S成分
        /// </summary>
        public string DES_S { get; set; }

        /// <summary>
        /// 脱硫后温度
        /// </summary>
        public DateTime? HML_CTEMP { get; set; }

        /// <summary>
        /// 脱硫完成时间
        /// </summary>
        public DateTime? TIME_STAMP { get; set; }

        /// <summary>
        /// 装入转炉
        /// </summary>
        public string DEVICE { get; set; }

        /// <summary>
        /// 炉次号
        /// </summary>
        public string HEAT_NUM { get; set; }

        /// <summary>
        /// 装入前重量
        /// </summary>
        public string ENTER_WEIGHT { get; set; }

        /// <summary>
        /// 装入后重量
        /// </summary>
        public string EXTI_WEIGHT { get; set; }

        /// <summary>
        /// 装入净重
        /// </summary>
        public string NET_WEIGHT { get; set; }

        /// <summary>
        /// 装入天车
        /// </summary>
        public string ENTER_CRA { get; set; }

        /// <summary>
        /// 装入时间
        /// </summary>
        public DateTime? ENTER_TIME { get; set; }

        /// <summary>
        /// 分流操作员ID
        /// </summary>
        public int ShuntUserID { get; set; }

        /// <summary>
        /// 分流班组ID
        /// </summary>
        public int ShuntGrID { get; set; }

        /// <summary>
        /// 分流操作员
        /// </summary>
        public string ShuntUserName { get; set; }

        /// <summary>
        /// 分流班组
        /// </summary>
        public string ShuntGrName { get; set; }

        /// <summary>
        /// 分流时间
        /// </summary>
        public DateTime? DISPATCH_TIME { get; set; }



    }
}
