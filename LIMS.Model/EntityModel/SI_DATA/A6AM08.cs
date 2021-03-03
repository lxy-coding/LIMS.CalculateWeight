using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM08
    {
        /// <summary>
        /// 序号
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// 消息时间
        /// <summary>
        public virtual DateTime? MSG_TIME { get; set; }
        /// <summary>
        /// 读取时间
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
        /// <summary>
        /// 消息状态
        /// <summary>
        public virtual string MSG_STATUS { get; set; }
        /// <summary>
        /// 操作类型
        /// <summary>
        public virtual string OP_DIV { get; set; }
        /// <summary>
        /// 高炉炉号
        /// <summary>
        public virtual string GL_NO { get; set; }
        /// <summary>
        /// 铁次号
        /// <summary>
        public virtual string IRON_NO { get; set; }
        /// <summary>
        /// 铁水罐号
        /// <summary>
        public virtual string IRON_LADLE_NO { get; set; }
        /// <summary>
        /// 分析时间
        /// <summary>
        public virtual string ANALYSIZE_TIME { get; set; }
        /// <summary>
        /// 铁水成分C
        /// <summary>
        public virtual string CF_C { get; set; }
        /// <summary>
        /// 铁水成分SI
        /// <summary>
        public virtual string CF_SI { get; set; }
        /// <summary>
        /// 铁水成分MN
        /// <summary>
        public virtual string CF_MN { get; set; }
        /// <summary>
        /// 铁水成分P
        /// <summary>
        public virtual string CF_P { get; set; }
        /// <summary>
        /// 铁水成分S
        /// <summary>
        public virtual string CF_S { get; set; }
        /// <summary>
        /// 铁水成分Ti
        /// <summary>
        public virtual string CF_TI { get; set; }
        /// <summary>
        /// 铁水成分As
        /// <summary>
        public virtual string CF_AS { get; set; }
        /// <summary>
        /// 炉批号
        /// <summary>
        public virtual string HEAT_BATCH_NO { get; set; }
    }
}
