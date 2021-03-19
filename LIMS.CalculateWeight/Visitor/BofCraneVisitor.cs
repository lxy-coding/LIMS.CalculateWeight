using LIMS.CalculateWeight.ActionHandler;
using LIMS.DataAccess;
using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight.Visitor
{
    /// <summary>
    /// 转炉吊包位
    /// </summary>
    public class BofCraneVisitor : VisitorBase
    {
        /// <summary>
        /// 空包放吊
        /// </summary>
        /// <param name="record"></param>
        public override void EmptyDrop(ActionHandlerBase handler)
        {
            PosManager.StartPos(Wst.NUM, handler.Record.CRA_ID.CRA_NUM);

            InsertBofInWeightRecord(handler.Record);
        }

        /// <summary>
        /// 空包起吊
        /// </summary>
        /// <param name="record"></param>
        public override void EmptyHoist(ActionHandlerBase handler)
        {
            PosManager.EndPos(Wst.NUM, handler.Record.CRA_ID.CRA_NUM);
        }

        /// <summary>
        /// 重包放吊
        /// </summary>
        /// <param name="record"></param>
        public override void FullDrop(ActionHandlerBase handler)
        {
            PosManager.UpdatePos(handler.Record.CRA_ID.CRA_NUM, Wst.NUM, handler.Record.CRA_ID.CRA_NUM);

            InsertBofInWeightRecord(handler.Record);
        }

        /// <summary>
        /// 重包起吊
        /// </summary>
        /// <param name="record"></param>
        public override void FullHoist(ActionHandlerBase handler)
        {
            PosManager.UpdatePos(Wst.NUM, handler.Record.CRA_ID.CRA_NUM, handler.Record.CRA_ID.CRA_NUM);

            string ladle= LadleManager.MatchLadle(Wst.NUM, handler.Record.CRA_ID.CRA_NUM);

            InsertBofOutWeightRecord(handler.Record, ladle);
        }

        /// <summary>
        /// 兑物
        /// </summary>
        /// <param name="record"></param>
        public override void Pour(ActionHandlerBase handler)
        {

        }

        /// <summary>
        /// 插入转炉入站物重记录
        /// </summary>
        /// <param name="record"></param>
        /// <param name="type"></param>
        private void InsertBofInWeightRecord(CRANE_ACTION_RECORD_X record)
        {
            WST_WEIGHT_RECORD wRecord = new WST_WEIGHT_RECORD()
            {
                CRA = record.CRA_ID.CRA_NUM,
                CREAT_TIME = DateTime.Now,
                DEVICE = Wst.OBJ_ID.NUM,
                DEVICE_TYPE = 1,
                WST = Wst.NUM,
                IO_TYPE = 2,
                GROSS_WEIGHT = record.WEIGHT,
                TARE_WEIGHT = record.WEIGHT,
                END_TIME = record.OPERATION_TIME,
                TYPE = 4,
                FLAG = 0,
            };
            wRecord.NET_WEIGHT = wRecord.GROSS_WEIGHT - wRecord.TARE_WEIGHT;
            CalculateWeightService.Instance.Insert_WST_WEIGHT_RECORD(wRecord);
        }

        /// <summary>
        /// 插入转炉出站物重记录
        /// </summary>
        /// <param name="record"></param>
        /// <param name="type"></param>
        private void InsertBofOutWeightRecord(CRANE_ACTION_RECORD_X record,string ladle)
        {
            WST_WEIGHT_RECORD wRecord = new WST_WEIGHT_RECORD()
            {
                CRA = record.CRA_ID.CRA_NUM,
                CREAT_TIME = DateTime.Now,
                DEVICE = Wst.OBJ_ID.NUM,
                DEVICE_TYPE = 1,
                WST = Wst.NUM,
                IO_TYPE = 3,
                GROSS_WEIGHT = record.WEIGHT,
                TARE_WEIGHT = record.WEIGHT,
                END_TIME = record.OPERATION_TIME,
                TYPE = 4,
                FLAG = 0,
                CON_NUM=ladle
            };
            wRecord.NET_WEIGHT = wRecord.GROSS_WEIGHT - wRecord.TARE_WEIGHT;
            CalculateWeightService.Instance.Insert_WST_WEIGHT_RECORD(wRecord);
        }
    }
}
