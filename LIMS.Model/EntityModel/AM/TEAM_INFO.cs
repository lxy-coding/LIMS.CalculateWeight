using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 班组
    /// </summary>
    [Serializable]
    public class TEAM_INFO
    {
        public TEAM_INFO() { }
        /// <summary>
        /// 序号
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 班组编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 班组名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 班组负责人;
        /// <summary>
        public virtual string TEAM_LEADER { get; set; }
        /// <summary>
        /// 班组类型;4为废钢班组，5为铁水预处理班组，6为转炉班组，7为精炼班组，8为连铸班组，11为板坯班组
        /// <summary>
        public virtual short? TEAM_TYPE { get; set; }
        /// <summary>
        /// 备注;
        /// <summary>
        public virtual string REMARKS { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
