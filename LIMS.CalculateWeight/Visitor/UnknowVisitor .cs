using LIMS.CalculateWeight.ActionHandler;
using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight.Visitor
{
    public class UnknowVisitor: VisitorBase
    {
        /// <summary>
        /// 工位
        /// </summary>
        public override WST Wst { get { throw new InvalidOperationException("当前处于未知位置，没有工位"); } set { throw new InvalidOperationException("当前处于未知位置，没有工位"); } }

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
            PosManager.UpdatePos(handler.Record.CRA_ID.CRA_NUM, handler.Record.CRA_ID.SPA_ID.NUM, (int)handler.Record.COORD_X, 
                (int)handler.Record.COORD_Y, handler.Record.CRA_ID.CRA_NUM);
        }

        /// <summary>
        /// 重包起吊
        /// </summary>
        /// <param name="record"></param>
        public override void FullHoist(ActionHandlerBase handler)
        {
            PosManager.UpdatePos( handler.Record.CRA_ID.SPA_ID.NUM, (int)handler.Record.COORD_X,
               (int)handler.Record.COORD_Y, handler.Record.CRA_ID.CRA_NUM, handler.Record.CRA_ID.CRA_NUM);
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
