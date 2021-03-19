using LIMS.CalculateWeight.ActionHandler;
using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight.Visitor
{
    public abstract class VisitorBase
    {
        /// <summary>
        /// 工位
        /// </summary>
        public virtual WST Wst { get; set; }

        /// <summary>
        /// 位置管理
        /// </summary>
        public PosManager PosManager { get; set; } = new PosManager();

        /// <summary>
        /// 钢包管理
        /// </summary>
        public LadleManager LadleManager { get; set; } = new LadleManager();

        /// <summary>
        /// 空包起吊
        /// </summary>
        /// <param name="record"></param>
        public abstract void EmptyHoist(ActionHandlerBase handler);

        /// <summary>
        /// 空包放吊
        /// </summary>
        /// <param name="record"></param>
        public abstract void EmptyDrop(ActionHandlerBase handler);

        /// <summary>
        /// 重包起吊
        /// </summary>
        /// <param name="record"></param>
        public abstract void FullHoist(ActionHandlerBase handler);

        /// <summary>
        /// 重包放吊
        /// </summary>
        /// <param name="record"></param>
        public abstract void FullDrop(ActionHandlerBase handler);

        /// <summary>
        /// 兑物
        /// </summary>
        /// <param name="record"></param>
        public abstract void Pour(ActionHandlerBase handler);
    }
}
