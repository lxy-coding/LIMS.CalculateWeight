using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM17
    {
        /// <summary>
        /// 序号
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// 消息时间
        /// <summary>
        public virtual DateTime MSG_TIME { get; set; }
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
        /// 入库计划号
        /// <summary>
        public virtual string INPUT_PLAN { get; set; }
        /// <summary>
        /// 物料号（钢坯号）
        /// <summary>
        public virtual string MAT_NO { get; set; }
        /// <summary>
        /// 物料类别
        /// <summary>
        public virtual string MAT_TYPE { get; set; }
        /// <summary>
        /// 入库方式
        /// <summary>
        public virtual string IN_TYPE { get; set; }
        /// <summary>
        /// 原位置
        /// <summary>
        public virtual string SOU_POS { get; set; }
        /// <summary>
        /// 目的位置
        /// <summary>
        public virtual string DES_POS { get; set; }
        /// <summary>
        /// 备用
        /// <summary>
        public virtual string BACKUP { get; set; }
    }
}
