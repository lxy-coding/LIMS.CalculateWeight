using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 核库查询输出DTO
    /// 段勇明 Add 20200521
    /// </summary>
    [Serializable]
    public class CheckRecordDto
    {
        /// <summary>
        /// 坯料号;
        /// </summary>
        public string STEEL_NUM { get; set; }

        /// <summary>
        /// 炉次号;
        /// </summary>
        public string HEAT_NUM { get; set; }

        /// <summary>
        /// 钢种;
        /// </summary>
        public string GRADE { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string S_SIZE { get; set; }

        /// <summary>
        /// 重量;
        /// </summary>
        public int WEIGTH { get; set; }
        /// <summary>
        /// 货位名称
        /// </summary>
        public string POSITION_NAME { get; set; }

        /// <summary>
        /// 层
        /// </summary>
        public int LAYER { get; set; }
        /// <summary>
        /// 核库类型; （1增加；2修改；3删除；4出库确认；5删除计划；6倒跺）
        /// </summary>
        public int CHECK_TYPE { get; set; }

        /// <summary>
        /// 核库时间
        /// </summary>
        public DateTime? CHECK_TIME { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string USER_NUM { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string DESCRIPTION { get; set; }
    }
}
