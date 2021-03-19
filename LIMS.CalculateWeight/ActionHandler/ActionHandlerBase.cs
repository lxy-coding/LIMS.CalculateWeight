using LIMS.CalculateWeight.Visitor;
using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight.ActionHandler
{
    /// <summary>
    /// 动作处理
    /// </summary>
    public abstract class ActionHandlerBase
    {
        /// <summary>
        /// 处理
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Handle(VisitorBase visitor);

        /// <summary>
        /// 动作记录
        /// </summary>
        public CRANE_ACTION_RECORD_X Record { get; set; }
    }
}
