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
    /// 空包放吊处理
    /// </summary>
    public class EmptyDropHandler : ActionHandlerBase
    {
        /// <summary>
        /// 处理
        /// </summary>
        /// <param name="visitor"></param>
        public override void Handle(VisitorBase visitor)
        {
            visitor.EmptyDrop(this);
        }
    }
}
