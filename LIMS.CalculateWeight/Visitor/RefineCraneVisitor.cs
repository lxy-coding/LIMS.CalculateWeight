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
    public class RefineCraneVisitor: VisitorBase
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
            PosManager.UpdatePos(handler.Record.CRA_ID.CRA_NUM, Wst.NUM, handler.Record.CRA_ID.CRA_NUM);

            InsertRefineInWeightRecord(handler.Record);
        }

        /// <summary>
        /// 重包起吊
        /// </summary>
        /// <param name="record"></param>
        public override void FullHoist(ActionHandlerBase handler)
        {
            PosManager.UpdatePos( Wst.NUM, handler.Record.CRA_ID.CRA_NUM, handler.Record.CRA_ID.CRA_NUM);

            InsertRefineOutWeightRecord(handler.Record);
        }

        /// <summary>
        /// 兑物
        /// </summary>
        /// <param name="record"></param>
        public override void Pour(ActionHandlerBase handler)
        {

        }

        /// <summary>
        /// 插入精炼入站物重记录
        /// </summary>
        /// <param name="record"></param>
        /// <param name="type"></param>
        private void InsertRefineInWeightRecord(CRANE_ACTION_RECORD_X record)
        {
            WST_WEIGHT_RECORD wRecord = new WST_WEIGHT_RECORD()
            {
                CRA = record.CRA_ID.CRA_NUM,
                CREAT_TIME = DateTime.Now,
                DEVICE = Wst.OBJ_ID.NUM,
                DEVICE_TYPE = 2,
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
        /// 插入精炼出站物重记录
        /// </summary>
        /// <param name="record"></param>
        /// <param name="type"></param>
        private void InsertRefineOutWeightRecord(CRANE_ACTION_RECORD_X record)
        {
            WST_WEIGHT_RECORD wRecord = new WST_WEIGHT_RECORD()
            {
                CRA = record.CRA_ID.CRA_NUM,
                CREAT_TIME = DateTime.Now,
                DEVICE = Wst.OBJ_ID.NUM,
                DEVICE_TYPE = 2,
                WST = Wst.NUM,
                IO_TYPE = 3,
                GROSS_WEIGHT = record.WEIGHT,
                TARE_WEIGHT = record.WEIGHT,
                END_TIME = record.OPERATION_TIME,
                TYPE = 4,
                FLAG = 0,
            };
            wRecord.NET_WEIGHT = wRecord.GROSS_WEIGHT - wRecord.TARE_WEIGHT;
            CalculateWeightService.Instance.Insert_WST_WEIGHT_RECORD(wRecord);
        }
    }
}
