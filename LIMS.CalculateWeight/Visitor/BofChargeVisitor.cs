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
    public class BofChargeVisitor : VisitorBase
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
            if (handler.Record.WEIGHT < 40000 && handler.Record.WEIGHT > 5000)//废钢兑物
            {
                InsertScrapWeightRecord(handler.Record);
            }
            else if (handler.Record.WEIGHT < 200000 && handler.Record.WEIGHT > 40000)//铁水兑物
            {
                InsertHmlWeightRecord(handler.Record);
            }
        }

        /// <summary>
        /// 插入废钢物重记录
        /// </summary>
        /// <param name="record"></param>
        /// <param name="type"></param>
        private void InsertScrapWeightRecord(CRANE_ACTION_RECORD_X record)
        {
            WST_WEIGHT_RECORD wRecord = new WST_WEIGHT_RECORD()
            {
                CRA = record.CRA_ID.CRA_NUM,
                CREAT_TIME = DateTime.Now,
                DEVICE = Wst.OBJ_ID.NUM,
                DEVICE_TYPE = 1,
                WST = Wst.NUM,
                IO_TYPE = 1,
                GROSS_WEIGHT = record.WEIGHT,
                TARE_WEIGHT = (int)Convert.ToDouble(record.FIELD1),
                START_TIME = Convert.ToDateTime(record.FIELD2),
                END_TIME = record.OPERATION_TIME,
                TYPE = 1,
                FLAG = 0,
                CON_NUM = null,
                FIELD2 = null,
                NET_WEIGHT = record.WEIGHT - (int)Convert.ToDouble(record.FIELD1)
            };
            CalculateWeightService.Instance.Insert_WST_WEIGHT_RECORD(wRecord);
        }

        /// <summary>
        /// 插入铁水物重记录
        /// </summary>
        /// <param name="record"></param>
        /// <param name="type"></param>
        private void InsertHmlWeightRecord(CRANE_ACTION_RECORD_X record)
        {
            WST_WEIGHT_RECORD wRecord = new WST_WEIGHT_RECORD()
            {
                CRA = record.CRA_ID.CRA_NUM,
                CREAT_TIME = DateTime.Now,
                DEVICE = Wst.OBJ_ID.NUM,
                DEVICE_TYPE = 1,
                WST = Wst.NUM,
                IO_TYPE = 1,
                GROSS_WEIGHT = record.WEIGHT,
                TARE_WEIGHT = (int)Convert.ToDouble(record.FIELD1),
                START_TIME = Convert.ToDateTime(record.FIELD2),
                END_TIME = record.OPERATION_TIME,
                TYPE = 2,
                FLAG = 0,
                CON_NUM = null,
                FIELD2 = null,
                NET_WEIGHT = record.WEIGHT - (int)Convert.ToDouble(record.FIELD1)
            };
            CalculateWeightService.Instance.Insert_WST_WEIGHT_RECORD(wRecord);
        }
    }
}
