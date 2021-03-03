using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class CCM_ROTATION_INTERFACE
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
        /// 连铸机号
        /// <summary>
        public virtual string PLANT_NO { get; set; }
        /// <summary>
        /// A臂浇铸标志
        /// <summary>
        public virtual string ARMA_CAST { get; set; }
        /// <summary>
        /// B臂浇铸标志
        /// <summary>
        public virtual string ARMB_CAST { get; set; }
        /// <summary>
        /// 浇铸位臂号
        /// <summary>
        public virtual string CASTING_FLAG { get; set; }
        /// <summary>
        /// 数据生成时间
        /// <summary>
        public virtual string TIME_STAMP { get; set; }
        public virtual string FIELD1 { get; set; }
        public virtual string FIELD2 { get; set; }
        public virtual string FIELD3 { get; set; }
    }
}
