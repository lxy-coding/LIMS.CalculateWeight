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
    /// 空包起吊处理
    /// </summary>
    public class EmptyHoistHandler : ActionHandlerBase
    {
        /// <summary>
        /// 处理
        /// </summary>
        /// <param name="visitor"></param>
        public override void Handle(VisitorBase visitor)
        {
            visitor.EmptyHoist(this);
        }
    }
}
