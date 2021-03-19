using LIMS.CalculateWeight.ActionHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight.Visitor
{
    public class MMCraneVisitor:VisitorBase
    {
        /// <summary>
        /// 空包放吊
        /// </summary>
        /// <param name="record"></param>
        public override void EmptyDrop(ActionHandlerBase handler)
        {

        }

        /// <summary>
        /// 空包起吊
        /// </summary>
        /// <param name="record"></param>
        public override void EmptyHoist(ActionHandlerBase handler)
        {

        }

        /// <summary>
        /// 重包放吊
        /// </summary>
        /// <param name="record"></param>
        public override void FullDrop(ActionHandlerBase handler)
        {

        }

        /// <summary>
        /// 重包起吊
        /// </summary>
        /// <param name="record"></param>
        public override void FullHoist(ActionHandlerBase handler)
        {

        }

        /// <summary>
        /// 兑物
        /// </summary>
        /// <param name="record"></param>
        public override void Pour(ActionHandlerBase handler)
        {

        }
    }
}
