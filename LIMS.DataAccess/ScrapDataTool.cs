using LIMS.Common.LOG;
using LIMS.DAL;
using LIMS.Model.CustomModel;
using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess
{
    public sealed class ScrapDataTool
    {
        /// <summary>
        /// 日志
        /// </summary>
        static SystemLog log = new SystemLog();

        /// <summary>
        /// DataTool单例
        /// </summary>
        private static ScrapDataTool _instance;

        /// <summary>
        /// 获得静态实例
        /// </summary>
        public static ScrapDataTool GetInstance()
        {
            if (null == _instance)
            {
                _instance = new ScrapDataTool();
            }
            return _instance;
        }

        /// <summary>
        /// 查询天车动作表未处理数据(废钢)
        /// </summary>
        /// <returns></returns>
        public DataTable GetCraActionRecord()
        {
            try
            {
                const string strSql = @" select a.*, c.id obj_id, c.num obj_num, c.name obj_name
                                      from pub.CRANE_ACTION_RECORD a
                                      left join pub.CRANE b
                                        on b.id = a.cra_id
                                      left join pub.object_property c
                                        on b.obj_id = c.id
                                     where a.DEAL_SYMBOL = 1
                                      and b.spa_id in (130,131,2,3,4,5,6,7)
                                      and b.cra_type = 1
                                     order by a.OPERATION_TIME";
                return OracleDataHelper.ExecuteDataTable(strSql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, "GetCraActionRecord出错", ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 获取工位数据
        /// <returns></returns>
        public List<WST> GetWst()
        {
            try
            {
                return OracleDataHelper.QueryOver<WST>().ToList();
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, "GetWst出错", ex.Message);
                return null;
            }
        }

        public DataTable GetWstById(int wst_id)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("select a.id,a.obj_id,a.name,c.scrap_type_id,c.code from pub.wst a ");
                sb.Append("left join PUB.object_property b ");
                sb.Append("on a.obj_id = b.id ");
                sb.Append("left join scm.scrap_pool c ");
                sb.Append("on a.id = c.wst_id");
                sb.Append("where obj_type_id = 3");
                sb.Append("and id = " + wst_id);

                return OracleDataHelper.ExecuteDataTable(sb.ToString());
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, "GetObjType出错", ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 插入吊运日志
        /// </summary>
        public int InsertScrapHangLog(Scrap_Hang_Log scrapHangLog)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("insert into scm.SCRAP_HANG_LOG ");
                sb.Append("(ID,CRANE_ID,SPA_ID,POSITION_ID_UP,CENTRE_X_UP,CENTRE_Y_UP,PLC_ORDER_UP,WEIGHT,HANG_TIME_UP,DEAL_FLAG) ");
                sb.Append("values (");
                sb.AppendFormat("'{0}',", scrapHangLog.ID);
                sb.AppendFormat("{0},", scrapHangLog.CRANE_ID);
                sb.AppendFormat("{0},", scrapHangLog.SPA_ID);
                sb.AppendFormat("{0},", scrapHangLog.POSITION_ID_UP);
                sb.AppendFormat("{0},", scrapHangLog.CENTRE_X_UP);
                sb.AppendFormat("{0},", scrapHangLog.CENTRE_Y_UP);
                sb.AppendFormat("{0},", scrapHangLog.PLC_ORDER_UP);
                sb.AppendFormat("{0},", scrapHangLog.WEIGHT);
                sb.AppendFormat("to_date('{0}','yyyy-mm-dd hh24:mi:ss'),", scrapHangLog.HANG_TIME_UP);
                sb.AppendFormat("{0},",scrapHangLog.DEAL_FLAG);
                sb.AppendFormat("{0})", scrapHangLog.SCRAP_TYPE_ID);

                return OracleDataHelper.ExecuteNonQuery(sb.ToString());//执行SQL语句 

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, "InsertScrapHangLog出错", ex.Message);
                return -1;
            }
        }

        
        /// <summary>
        /// 更新吊运日志
        /// </summary>
        public int UpdateScrapHangLog(Scrap_Hang_Log scrapHangLog)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update scm.SCRAP_HANG_LOG set ");
                sb.AppendFormat("POSITION_ID_DOWN = {0},", scrapHangLog.PLC_ORDER_DOWN);
                sb.AppendFormat("CENTRE_X_DOWN = {0},", scrapHangLog.CENTRE_X_DOWN);
                sb.AppendFormat("CENTRE_Y_DOWN = {0},", scrapHangLog.CENTRE_Y_DOWN);
                sb.AppendFormat("PLC_ORDER_DOWN = {0},", scrapHangLog.PLC_ORDER_DOWN);
                sb.AppendFormat("HANG_TIME_DOWN = to_date('{0}','yyyy-mm-dd hh24:mi:ss'),", scrapHangLog.HANG_TIME_DOWN);
                sb.AppendFormat("SCRAP_TYPE_ID = {0}", scrapHangLog.SCRAP_TYPE_ID);
                sb.AppendFormat("where ID = {0},", scrapHangLog.ID);

                return OracleDataHelper.ExecuteNonQuery(sb.ToString());//执行SQL语句 

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, "InsertScrapHangLog出错", ex.Message);
                return -1;
            }
        }

        public DataTable GetScrapHangLog()
        {
            try
            {
                const string strSql = "select * from SCM.scrap_hang_log where deal_flag = 0";
                return OracleDataHelper.ExecuteDataTable(strSql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, "GetScrapHangLog出错", ex.Message);
                return null;
            }
        }

        public DataTable GetScrapHangLogUp(int craneID,int plcCache)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("select * from SCM.scrap_hang_log ");
                sb.Append("where deal_flag = 0 ");
                sb.AppendFormat("and crane_id = {0} ",craneID);
                sb.AppendFormat("and PLC_ORDER_UP = {0}",plcCache);
                
                return OracleDataHelper.ExecuteDataTable(sb.ToString());
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, "GetScrapHangLogUp出错", ex.Message);
                return null;
            }
        }

        public DataTable GetObjType()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("select a.id as position_id,c.id as type_id from pub.wst a ");
                sb.Append("left join PUB.object_property b ");
                sb.Append("on a.obj_id = b.id ");
                sb.Append("left join PUB.object_type c ");
                sb.Append("on b.obj_type_id = c.id ");

                return OracleDataHelper.ExecuteDataTable(sb.ToString());
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, "GetObjType出错", ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 判断台车位置
        /// </summary>      
        public int JudgingPosition()
        {
            try
            {
                int Changes = 0;
                //查询位于废钢区三台台车的实时位置
                string sqltext1 = String.Format($"select TRO_ID,COORD_X,COORD_Y from PUB.TRO_REAL_INFO  where TRO_ID in(22,23,24)");
                DataTable dt1 = OracleDataHelper.ExecuteDataTable(sqltext1);

                //查询对应三台台车的工位信息
                string sqltext2 = String.Format($"select POSITION_LENGTH,WIDTH,CENTRE_X,CENTRE_Y from PUB.WST where ID in(297,298,299)");
                DataTable dt2 = OracleDataHelper.ExecuteDataTable(sqltext2);

                //比对信息
                foreach (DataRow dr1 in dt1.Rows)
                {
                    int Coord_x = Convert.ToInt32(dr1["COORD_X"]);
                    int Coord_y = Convert.ToInt32(dr1["COORD_Y"]);
                    int Tro_ID = Convert.ToInt32(dr1["TRO_ID"]);
                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        int RangeLeft_x = Convert.ToInt32(dr2["CENTRE_X"]) - Convert.ToInt32(dr2["WIDTH"]) / 2;
                        int RangeRight_x = Convert.ToInt32(dr2["CENTRE_X"]) + Convert.ToInt32(dr2["WIDTH"]) / 2;
                        int RangeUp_y = Convert.ToInt32(dr2["CENTRE_Y"]) + Convert.ToInt32(dr2["POSITION_LENGTH"]) / 2;
                        int RangeDown_y = Convert.ToInt32(dr2["CENTRE_Y"]) - Convert.ToInt32(dr2["POSITION_LENGTH"]) / 2;
                        string sqltext3 = null;
                        if (Coord_x>= RangeLeft_x && Coord_x<= RangeRight_x && Coord_y<= RangeUp_y && Coord_y>= RangeDown_y)
                        {
                            //实时位置在工位上的操作
                            sqltext3 = String.Format($"Update PUB.TRO_REAL_INFO set IS_SCRAP=1 where TRO_ID={Tro_ID}");                           
                        }
                        else
                        {
                            //实时位置不在工位上的操作
                            sqltext3 = String.Format($"Update PUB.TRO_REAL_INFO set IS_SCRAP=0 where TRO_ID={Tro_ID}");
                        }
                        Changes = OracleDataHelper.ExecuteNonQuery(sqltext3);
                    }
                }

                return Changes;
               
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
