using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LIMS.CalculateWeight.ActionHandler;
using LIMS.CalculateWeight.Visitor;
using LIMS.Common.LOG;
using LIMS.DataAccess;
using LIMS.Model.EntityModel;

namespace LIMS.CalculateWeight
{
    /// <summary>
    /// 主逻辑处理
    /// </summary>
    public class MainHandler
    {
        /// <summary>
        /// 默认实例
        /// </summary>
        public static MainHandler Default { get; } = new MainHandler();

        SystemLog log = new SystemLog();

        CancellationTokenSource cts = null;

        public void Request()
        {
            cts = new CancellationTokenSource();
            Task.Run(() =>
            {
                while (!cts.IsCancellationRequested)
                {
                    List<CRANE_ACTION_RECORD_X> records = null;
                    try
                    {
                        records = CalculateWeightService.Instance.GetCraneActionRecords();
                    }
                    catch (Exception e)
                    {
                        log.WriteLog(E_ProcessLogType.Error, "查询动作记录异常。" + e.Message);
                        break;
                    }
                    foreach (var record in records)
                    {
                        Request(record);
                    }
                }
            }, cts.Token);
        }

        public void CancelRequest()
        {
            cts.Cancel();
        }

        /// <summary>
        /// 处理
        /// </summary>
        public void Request(CRANE_ACTION_RECORD_X record)
        {
            try
            {
                HandlerProvider handlerProvider = new HandlerProvider();
                ActionHandlerBase handler = handlerProvider.GetHandler(record);
                if (handler != null)
                {
                    VisitorProvider visitorProvider = new VisitorProvider();
                    VisitorBase visitor = visitorProvider.GetVisitor(record);
                    handler.Handle(visitor);
                }
            }
            catch (Exception e)
            {
                log.WriteLog(E_ProcessLogType.Error, "物重处理异常。" + e.Message);
            }

            try
            {
                record.DEAL_SYMBOL = 2;
                CalculateWeightService.Instance.Update_CRANE_ACTION_RECORD_X(record);
            }
            catch (Exception e)
            {
                log.WriteLog(E_ProcessLogType.Error, "更新动作记录异常。" + e.Message);
            }

        }
    }
}
