using LIMS.Common;
using LIMS.DAL;
using LIMS.Model.EntityModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess
{
    /// <summary>
    /// 板坯库房服务数据库工具类
    /// 段勇明 Add 20200525
    /// </summary>
    public sealed class SlabServiceDataTool
    {
        private static SlabServiceDataTool _instance = new SlabServiceDataTool();

        /// <summary>
        /// 获得静态实例
        /// </summary>
        /// <returns></returns>
        public static SlabServiceDataTool GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// 根据区域ID获取区域
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AREA GetArea(int? id)
        {
            try
            {
                return OracleDataHelper.Query<AREA>().Where(a => a.ID == id).ToList().First();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<POSITION> GetPositionList(int areaProperty)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("select a.* from wh.position a ");
                sb.Append("left join PUB.area b ");
                sb.Append("on a.area_id = b.id ");
                sb.AppendFormat("where b.property = {0} and b.spa_id in {21,22,23,24,25,26}", areaProperty);

                DataTable dt = OracleDataHelper.ExecuteDataTable(sb.ToString());
                return DataHelper.DataTableToList2<POSITION>(dt).ToList();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public List<POSITION> GetPositionList2(int areaProperty, int SPA_ID)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("select a.* from wh.position a ");
                sb.Append("left join PUB.area b ");
                sb.Append("on a.area_id = b.id ");
                sb.AppendFormat("where b.property = {0} and b.spa_id = {1}", areaProperty, SPA_ID);

                DataTable dt = OracleDataHelper.ExecuteDataTable(sb.ToString());
                return DataHelper.DataTableToList2<POSITION>(dt).ToList();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public DataTable GetStock(string positionID)
        {
            try
            {
                string sql = string.Format("select STEEL_NUM,layer from(select * from wh.STEEL_STOCK where POSITION_ID = '{0}' order by LAYER desc,STORAGE_TIME desc) where ROWNUM < 3", positionID);

                return OracleDataHelper.ExecuteDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// 起吊时插入吊运记录
        /// </summary>
        /// <param name="craneActionRecord"></param>
        /// <param name="craneHangLog"></param>
        /// <param name="area"></param>
        /// <param name="steelNum"></param>
        /// <returns></returns>
        public int InsertCraneLog(CRANE_ACTION_RECORD craneActionRecord, CRANE_HANG_LOG craneHangLog, AREA area, string steelNum)
        {
            ArrayList sqlList = new ArrayList();
            try
            {
                //1更新库存,需要将板柸设为起吊状态,释放货位。
                if (area != null && area.TYPE != 2)
                {
                    StringBuilder sb1 = new StringBuilder();
                    sb1.Append("update wh.STEEL_STOCK set ");
                    sb1.Append("POSITION_ID = 0, ");
                    sb1.Append("STOCK_STATE = 0, ");
                    sb1.Append("LAYER = 0, ");
                    sb1.Append("RECORD_TIME = sysdate, ");
                    sb1.AppendFormat("CENTRE_X = {0}, ", craneHangLog.UP_X);
                    sb1.AppendFormat("CENTRE_Y = {0} ", craneHangLog.UP_Y);
                    sb1.AppendFormat("where STEEL_NUM = '{0}' ", steelNum);

                    sqlList.Add(sb1.ToString());
                }

                //2回写天车动作记录表
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("update pub.CRANE_ACTION_RECORD set ");
                sb2.AppendFormat("POSIT = {0}, ", craneHangLog.UP_POSITION_ID);
                sb2.AppendFormat("HOIST_NUM = '{0}', ", craneHangLog.STEEL_NUM);
                sb2.Append("HOIST_TYPE = 5, ");
                sb2.Append("ACCEPT_TIME = sysdate, ");
                sb2.Append("DEAL_TIME = sysdate, ");
                sb2.Append("DEAL_SYMBOL = 1 ");
                sb2.AppendFormat("where id = '{0}' ", craneActionRecord.ID);

                sqlList.Add(sb2.ToString());

                //3插入天车吊运记录表
                StringBuilder sb3 = new StringBuilder();
                sb3.Append("insert into wh.CRANE_HANG_LOG ");
                sb3.Append("(ID,CRA_ID,STEEL_NUM,UP_AREA_ID,UP_POSITION_ID,UP_X,UP_Y,UP_Z,UP_LAYER,UP_TIME,STEEL_CATEGORY,DO_FLAG,UP_ORDER,STEEL_WEIGHT) ");
                sb3.Append("values (");
                sb3.AppendFormat("'{0}', ", craneHangLog.ID);
                sb3.AppendFormat("{0}, ", craneHangLog.CRA_ID);
                sb3.AppendFormat("'{0}', ", craneHangLog.STEEL_NUM);
                sb3.AppendFormat("{0}, ", craneHangLog.UP_AREA_ID);
                sb3.AppendFormat("{0}, ", craneHangLog.UP_POSITION_ID);
                sb3.AppendFormat("{0}, ", craneHangLog.UP_X);
                sb3.AppendFormat("{0}, ", craneHangLog.UP_Y);
                sb3.AppendFormat("{0}, ", craneHangLog.UP_Z);
                sb3.AppendFormat("{0}, ", craneHangLog.UP_LAYER);
                sb3.AppendFormat(string.Format("to_date('{0}','yyyy-mm-dd hh24:mi:ss'), ", craneHangLog.UP_TIME));
                sb3.AppendFormat("{0}, ", craneHangLog.STEEL_CATEGORY);
                sb3.AppendFormat("{0}, ", craneHangLog.DO_FLAG);
                sb3.AppendFormat("{0}, ", craneHangLog.UP_ORDER);
                sb3.AppendFormat("{0}) ", craneHangLog.STEEL_WEIGHT);

                sqlList.Add(sb3.ToString());

                //4更新天车实时表的板柸号和数量
                StringBuilder sb4 = new StringBuilder();
                sb4.Append("update pub.CRANE_REAL_INFO set ");
                sb4.Append("HEAT_NUM = '', ");
                sb4.AppendFormat("OBJ_NUM = '{0}', ", craneHangLog.STEEL_NUM);
                sb4.AppendFormat("OBJ_COUNT = {0} ", craneHangLog.STEEL_COUNT);
                sb4.AppendFormat("where CRA_ID = {0} ", craneHangLog.CRA_ID);

                sqlList.Add(sb4.ToString());

                //5如果是辊道起吊，维护视觉板柸辊道交互表


                return OracleDataHelper.ExecuteTransaction(sqlList);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// 放吊时更新吊运记录
        /// </summary>
        /// <param name="craneActionRecord"></param>
        /// <param name="craneHangLog"></param>
        /// <param name="area"></param>
        /// <returns></returns>
        public int UpdateCraneLog(CRANE_ACTION_RECORD craneActionRecord, CRANE_HANG_LOG craneHangLog, AREA area)
        {
            ArrayList sqlList = new ArrayList();
            try
            {
                if (craneHangLog != null)
                {
                    //1更新放吊时的库存信息。
                    if (area != null && (area.TYPE == 2 || area.TYPE == 3 || area.TYPE == 4))
                    {
                        StringBuilder sb1 = new StringBuilder();
                        sb1.Append("update wh.STEEL_STOCK set ");
                        sb1.AppendFormat("POSITION_ID = {0}, ", craneHangLog.DOWN_POSITION_ID);
                        sb1.Append("STOCK_STATE = 0, ");
                        sb1.AppendFormat("LAYER = {0}, ", craneHangLog.DOWN_LAYER);
                        sb1.Append("STORAGE_TIME = sysdate, ");
                        sb1.AppendFormat("CENTRE_X = {0}, ", craneHangLog.DOWN_X);
                        sb1.AppendFormat("CENTRE_Y = {0} ", craneHangLog.DOWN_Y);
                        sb1.AppendFormat("where STEEL_NUM = '{0}' ", craneHangLog.CRA_ID);

                        sqlList.Add(sb1.ToString());
                    }

                    if (area != null && (area.TYPE == 1 || area.TYPE == 5))
                    {
                        StringBuilder sb1 = new StringBuilder();
                        sb1.Append("update wh.STEEL_STOCK set ");
                        sb1.AppendFormat("POSITION_ID = {0}, ", craneHangLog.DOWN_POSITION_ID);
                        sb1.Append("STOCK_STATE = 3, ");
                        sb1.AppendFormat("LAYER = {0}, ", craneHangLog.DOWN_LAYER);
                        sb1.Append("STORAGE_TIME = sysdate, ");
                        sb1.AppendFormat("CENTRE_X = {0}, ", craneHangLog.DOWN_X);
                        sb1.AppendFormat("CENTRE_Y = {0} ", craneHangLog.DOWN_Y);
                        sb1.AppendFormat("where STEEL_NUM = '{0}' ", craneHangLog.CRA_ID);

                        sqlList.Add(sb1.ToString());
                    }

                    //2回写天车动作记录表
                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append("update pub.CRANE_ACTION_RECORD set ");
                    sb2.AppendFormat("POSIT = {0}, ", craneHangLog.DOWN_POSITION_ID);
                    sb2.AppendFormat("HOIST_NUM = '{0}', ", craneHangLog.STEEL_NUM);
                    sb2.Append("HOIST_TYPE = 1, ");
                    sb2.Append("ACCEPT_TIME = sysdate, ");
                    sb2.Append("DEAL_TIME = sysdate, ");
                    sb2.Append("DEAL_SYMBOL = 1 ");
                    sb2.AppendFormat("where id = '{0}' ", craneActionRecord.ID);

                    sqlList.Add(sb2.ToString());

                    //3更新天车吊运记录表
                    StringBuilder sb3 = new StringBuilder();
                    sb3.Append("update wh.CRANE_HANG_LOG set ");
                    sb3.AppendFormat("DOWN_AREA_ID = {0}, ", craneHangLog.DOWN_AREA_ID);
                    sb3.AppendFormat("DOWN_POSITION_ID = {0}, ", craneHangLog.DOWN_POSITION_ID);
                    sb3.AppendFormat("DOWN_X = {0}, ", craneHangLog.DOWN_X);
                    sb3.AppendFormat("DOWN_Y = {0}, ", craneHangLog.DOWN_Y);
                    sb3.AppendFormat("DOWN_Z = {0}, ", craneHangLog.DOWN_Z);
                    sb3.AppendFormat("DOWN_LAYER = {0}, ", craneHangLog.DOWN_LAYER);
                    sb3.AppendFormat(string.Format("DOWN_TIME = to_date('{0}','yyyy-mm-dd hh24:mi:ss'), ", craneHangLog.DOWN_TIME));
                    sb3.Append("DO_FLAG = 0, ");
                    sb3.AppendFormat("DOWN_ORDER = {0} ", craneHangLog.DOWN_ORDER);
                    sb3.AppendFormat("where id = '{0}' ", craneHangLog.ID);

                    sqlList.Add(sb3.ToString());

                    //4更新天车实时表的板柸号和数量
                    StringBuilder sb4 = new StringBuilder();
                    sb4.Append("update pub.CRANE_REAL_INFO set ");
                    sb4.Append("HEAT_NUM = '', ");
                    sb4.Append("OBJ_NUM = null, ");
                    sb4.Append("OBJ_COUNT = 0 ");
                    sb4.AppendFormat("where CRA_ID = {0} ", craneHangLog.CRA_ID);

                    sqlList.Add(sb4.ToString());

                    //5如果是辊道起吊，维护视觉板柸辊道交互表


                }
                else
                {
                    StringBuilder sb1 = new StringBuilder();
                    sb1.Append("update pub.CRANE_ACTION_RECORD set ");
                    sb1.Append("HOIST_TYPE = 5, ");
                    sb1.Append("ACCEPT_TIME = sysdate, ");
                    sb1.Append("DEAL_TIME = sysdate, ");
                    sb1.Append("DEAL_SYMBOL = 1 ");
                    sb1.AppendFormat("where id = {0} ", craneActionRecord.ID);

                    sqlList.Add(sb1.ToString());
                }

                return OracleDataHelper.ExecuteTransaction(sqlList);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public int UpdateCraneHangLog(string craneHangLogID)
        {
            try
            {
                string sql = string.Format("update WH.crane_hang_log set business_type = 9, do_flag = 2 where id = '{0}'", craneHangLogID);
                return OracleDataHelper.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
