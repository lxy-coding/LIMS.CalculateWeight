using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 容器位置信息记录
    /// </summary>
    [Serializable]

    public class CON_POS_RECORD
    {
        /// <summary>
        /// 序号，主键
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual int? X_COORD { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual int? Y_COORD { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual string WST_NUM { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual string OBJ_NUM { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual int? TARE_WGT { get; set; }
        /// <summary>
        /// 工艺路径
        /// </summary>
        public virtual string ROUTE { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public virtual DateTime? UPDATE_TIME { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? CREATE_TIME { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 
        /// <summary>
        public virtual short? CON_TYPE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string ROUTE_DETAIL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string SPA_NUM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CON_NUM { get; set; }
    }
}
