using LIMS.CalculateWeight.ActionHandler;
using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight
{
    public class HandlerProvider
    {
        /// <summary>
        /// 获取动作处理者
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public ActionHandlerBase GetHandler(CRANE_ACTION_RECORD_X record)
        {
            ActionHandlerBase handler = null;
            switch (record.ACTION_SYMBOL)
            {
                case 1://1空包起吊
                    handler = new EmptyHoistHandler();
                    break;
                case 2://2重包起吊
                    handler = new FullHoistHandler();
                    break;
                case 3://3空包放吊
                    handler = new EmptyDropHandler();
                    break;
                case 4://4重包放吊
                    handler = new FullDropHandler();
                    break;
                case 5://5兑物
                    handler = new PourHandler();
                    break;
            }
            if (handler != null)
            {
                handler.Record = record;
            }
            return handler;
        }

        ///// <summary>
        ///// 获取处理者
        ///// </summary>
        ///// <param name="record"></param>
        ///// <returns></returns>
        //public BaseHandler GetHandler(CRANE_ACTION_RECORD_X record)
        //{
        //    var res = WstManager.MatchWst((int)record.COORD_X, (int)record.COORD_Y);
        //    if (res != null)
        //    {
        //        int type = res.Item1;
        //        WST wst = res.Item2;
        //        BaseHandler handler = GetHandler(type);
        //        handler.Wst = wst;
        //        return handler;
        //    }
        //    else
        //    {
        //        return new UnknowPosHandler();
        //    }
        //}

        ///// <summary>
        ///// 获取处理者
        ///// </summary>
        ///// <param name="type"></param>
        ///// <returns></returns>
        //public BaseHandler GetHandler(int type)
        //{
        //    switch (type)
        //    {
        //        case 1://1转炉装入位
        //            return new BofChargeHandler();


        //        case 10://10其他
        //            return new BofChargeHandler();
        //    }
        //    throw new ArgumentException("未知的工位类型。");
        //}

        ///// <summary>
        ///// 工位管理者
        ///// </summary>
        //public WstManager WstManager { get; set; }
    }
}
