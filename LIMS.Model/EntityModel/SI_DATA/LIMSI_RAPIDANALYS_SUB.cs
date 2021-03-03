using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class LIMSI_RAPIDANALYS_SUB
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
        /// 检化验系统中对应的主键ID
        /// <summary>
        public virtual decimal? ID { get; set; }
        /// <summary>
        /// 主表ID值，与主表关联的唯一外键
        /// <summary>
        public virtual decimal? MID { get; set; }
        /// <summary>
        /// 委托单号（业务主键）
        /// <summary>
        public virtual string SAMPLE_ID { get; set; }
        /// <summary>
        /// 元素代码
        /// <summary>
        public virtual string ANALYSE_ITEM_CODE { get; set; }
        /// <summary>
        /// 元素名称
        /// <summary>
        public virtual string ANALYSE_ITEM_NAME { get; set; }
        /// <summary>
        /// 检测结果值
        /// <summary>
        public virtual double? YVALUE { get; set; }
        /// <summary>
        /// 结束时间
        /// <summary>
        public virtual DateTime? FINISH_DATE { get; set; }
        /// <summary>
        /// 1：物理，2：化学，3：水分，4：冶金性能
        /// <summary>
        public virtual string ITEM_TYPE { get; set; }
        /// <summary>
        /// 值类型
        /// <summary>
        public virtual short? VALUE_TYPE { get; set; }
        /// <summary>
        /// 元素上限
        /// <summary>
        public virtual double? STAND_RANGE_HV { get; set; }
        /// <summary>
        /// 元素下限
        /// <summary>
        public virtual double? STAND_RANGE_LV { get; set; }
        /// <summary>
        /// 元素上限比较方式
        /// <summary>
        public virtual string HV_COMPARE { get; set; }
        /// <summary>
        /// 元素下限比较方式
        /// <summary>
        public virtual string LV_COMPARE { get; set; }
        /// <summary>
        /// 检验方法代码
        /// <summary>
        public virtual string METHOD_CODE { get; set; }
        /// <summary>
        /// 检验方法名称
        /// <summary>
        public virtual string METHOD_NAME { get; set; }
        /// <summary>
        /// 子任务编码
        /// <summary>
        public virtual string SUB_TASK_ID { get; set; }
    }
}

