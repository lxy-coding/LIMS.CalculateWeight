using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.DataAccess.DTO
{
    public class RunSignalModel  {
        
        /// <summary>
        /// 序号
        /// <summary>
        public long MSG_COUNTER { get; set; }
        
        /// <summary>
        /// 消息时间
        /// <summary>
        public DateTime? MSG_TIME { get; set; }
        
        /// <summary>
        /// 读取时间
        /// <summary>
        public DateTime? READ_TIME { get; set; }
        
        /// <summary>
        /// 消息状态
        /// <summary>
        public string MSG_STATUS { get; set; }
        
        /// <summary>
        /// 操作类型
        /// <summary>
        public string OP_DIV { get; set; }
        
        /// <summary>
        /// 处理号
        /// <summary>
        public string PROC_NO { get; set; }
        
        /// <summary>
        /// 设备代码
        /// <summary>
        public string DEV_CODE { get; set; }
        
        /// <summary>
        /// 炼钢计划号
        /// <summary>
        public string SM_PLAN_NO { get; set; }
        
        /// <summary>
        /// 制造命令号
        /// <summary>
        public string PONO { get; set; }
        
        /// <summary>
        /// 炉号（熔炼号）
        /// <summary>
        public string HEAT_NO { get; set; }
        
        /// <summary>
        /// 运转信号
        /// <summary>
        public string RUN_SIGNAL { get; set; }
        
        /// <summary>
        /// 事件发生时刻
        /// <summary>
        public string START_TIME_EVENT { get; set; }
        
        /// <summary>
        /// 钢包（铁水罐）号
        /// <summary>
        public string LADLE_NO { get; set; }
        
        /// <summary>
        /// 创建时间
        /// <summary>
        public DateTime? CREATE_TIME { get; set; }
    }
}
