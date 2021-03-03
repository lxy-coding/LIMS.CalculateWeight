using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 接管钢包
    /// </summary>
    public class NozzleLadleDto
    {
        #region LADLE_REAL_INFO

        /// <summary>
        /// 序号，外键，容器属性表ID
        /// <summary>
        public virtual int CON_ID { get; set; }

        #endregion

        #region CON_PROPERTY

        /// <summary>
        /// 编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称;
        /// <summary>
        public virtual string NAME { get; set; }

        #endregion

        #region LADLE_DISASSEMBLE_RECORD

        /// <summary>
        /// 拆包班组，班组表ID
        /// </summary>
        public virtual int TEAM_ID_NUM { get; set; }
        /// <summary>
        /// 拆包班组名称
        /// </summary>
        public virtual int TEAM_ID_NAME { get; set; }

        #endregion

        #region LADLE_READY_RECORD

        /// <summary>
        /// 序号，主键; GUID
        /// </summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 砌筑完成时刻
        /// </summary>
        public virtual DateTime READY_TIME { get; set; }
        /// <summary>
        /// 冷修号
        /// </summary>
        public virtual string COOL_REPAIR_NUM { get; set; }
        /// <summary>
        /// 热修号
        /// </summary>
        public virtual string HOT_REPAIR_NUM { get; set; }
        /// <summary>
        /// 钢包号
        /// </summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 钢包类型，1方坯用包，2板坯用包
        /// </summary>
        public virtual int LADLE_TYPE { get; set; }
        /// <summary>
        /// 修包类型，对象类型状态表ID
        /// </summary>
        public virtual int MAINTAIN_TYPE { get; set; }
        /// <summary>
        /// 砌筑班组
        /// </summary>
        public virtual int TEAM_ID { get; set; }
        /// <summary>
        /// 机构号
        /// </summary>
        public virtual string STRUCT_NUM { get; set; }
        /// <summary>
        /// 钢包接管时刻
        /// </summary>
        public virtual DateTime LADLE_TAKEOVER_TIME { get; set; }
        /// <summary>
        /// 钢包接管人员，人员表ID
        /// </summary>
        public virtual int TAKEOVER_USER_ID { get; set; }
        #endregion
    }
}
