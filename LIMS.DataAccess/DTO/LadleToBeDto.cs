using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 待拆钢包
    /// </summary>
    public class LadleToBeDto
    {
        /// <summary>
        /// 序号，主键，自增
        /// </summary>
        public virtual int ID { get; set; }

        /// <summary>
        /// 修包类型，参照对象状态ID
        /// </summary>
        public virtual int? MAINTAIN_TYPE { get; set; }

        /// <summary>
        /// 一级状态，1在线；2离线
        /// </summary>
        public virtual short? ISONLINE { get; set; }
        /// <summary>
        /// 冷修号
        /// </summary>
        public virtual string COOL_REPAIR_NUM { get; set; }
        /// <summary>
        /// 热修号
        /// </summary>
        public virtual string HOT_REPAIR_NUM { get; set; }
        /// <summary>
        /// 钢包类型，1方坯用包，2板坯用包
        /// </summary>
        public virtual int? LADLE_TYPE { get; set; }

        #region CON_PROPERTY

        /// <summary>
        /// 编号/包号
        /// </summary>
        public virtual string NUM { get; set; }

        /// <summary>
        /// 包号
        /// </summary>
        public virtual string DISPLAYNAME { get; set; }


        #endregion

        #region LADLE_ONOFF_RECORD

        /// <summary>
        /// 下线时刻
        /// </summary>
        public virtual DateTime? TIME_STAMP { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string REMARK { get; set; }

        #endregion

        #region 新增

        /// <summary>
        /// 钢包类型
        /// </summary>
        public virtual string LADLE_TYPE_NAME { get; set; }

        /// <summary>
        /// 下线原因
        /// </summary>
        public virtual string ONOFF_TYPE_NAME { get; set; }
        #endregion

    }
}
