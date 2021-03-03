using LIMS.Common.LOG;
using LIMS.DAL;
using LIMS.Model.EntityModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************* File info*******************************
** Create by ： 周张智
** Create Date： 2019-10-10
** Version： 1.0
** Descriptions： 数据工具类
********************* File info*******************************
** Modify by ：段勇明
** Modify Date： 2020-04-28
** Version： 
** Descriptions： 数据工具类
*************************************************************/
namespace LIMS.DataAccess
{
    /// <summary>
    /// 数据工具类
    /// </summary>
    public sealed class DataTool
    {
        /// <summary>
        /// 日志
        /// </summary>
        static SystemLog log = new SystemLog();

        /// <summary>
        /// DataTool单例
        /// </summary>
        private static DataTool _instance = new DataTool();

        /// <summary>
        /// 获得静态实例
        /// </summary>
        /// <returns></returns>
        public static DataTool GetInstance()
        {
            return _instance;
        }


        /// <summary>
        /// 获取天车动作记录
        /// </summary>
        /// <returns></returns>
        public List<CRANE_ACTION_RECORD> getCraActionRecord()
        {
            try
            {
                return OracleDataHelper.QueryOver<CRANE_ACTION_RECORD>().Where(a => a.DEAL_SYMBOL == 0).OrderBy(a => a.ACCEPT_TIME).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 查询天车动作表未处理数据（钢包和铁包）
        /// </summary>
        /// <returns></returns>
        public DataTable GetCraActionRecordData()
        {
            try
            {
                // 待优化 不应该使用 select * from,而且最好使用list<DTO>来接受数据，而不是使用Datatable。
                string strSql = @" select a.*, c.id obj_id, c.num obj_num, c.name obj_name
                                  from pub.CRANE_ACTION_RECORD a
                                  left join pub.CRANE b
                                    on b.id = a.cra_id
                                  left join pub.object_property c
                                    on b.obj_id = c.id
                                 where a.DEAL_SYMBOL = 1
                                  and b.spa_id in (2,3,4,5,6,7)
                                  and b.cra_type in (2,3)
                                 order by a.OPERATION_TIME";
                return OracleDataHelper.ExecuteDataTable(strSql);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 查询天车动作表未处理数据(废钢)
        /// </summary>
        /// <returns></returns>
        public DataTable GetCraActionRecordDataForSlot()
        {
            try
            {
                // 待优化 不应该使用 select * from,而且最好使用list<DTO>来接受数据，而不是使用Datatable。
                string strSql = @" select a.*, c.id obj_id, c.num obj_num, c.name obj_name
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
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取DataTable数据
        /// </summary>
        /// <returns></returns>
        public DataTable getDataTable(string Sql)
        {
            try
            {
                return OracleDataHelper.ExecuteDataTable(Sql);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 动作数据处理
        /// </summary>
        /// <param name="sql">执行SQL</param>
        /// <returns></returns>
        public int DataProcessing(string sql)
        {
            try
            {
                return OracleDataHelper.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// 获取天车动作工位放吊时间
        /// </summary>
        /// <returns></returns>
        public DateTime? getCraActionWstTime(string wstnum)
        {
            try
            {
                string strdate = OracleDataHelper.ExecuteDataTable($"select d.accept_time from pro_bac.t_cra_action_record d where d.posit='{wstnum}' and d.action_symbol in (3,4) and rownum=1 order by d.accept_time desc").Rows[0]["accept_time"].ToString();
                return DateTime.Parse(strdate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 修改天车动作记录包
        /// </summary>
        /// <param name="planNum">计划号</param>
        /// <param name="heatNum">炉次号</param>
        /// <param name="connum">包号</param>
        /// <param name="lastconnum">计划</param>
        /// <returns></returns>
        public int updateCraActionRecordConNum(string planNum, string heatNum, string connum, string lastconnum = null)
        {
            try
            {
                ArrayList aList = new ArrayList();
                //替换包
                aList.Add($"update pro_bac.t_cra_action_record d set d.hoist_num='{connum}' where d.plan_num='{planNum}' and d.heat_num='{heatNum}'");
                //清理错误包计划号炉次号
                if (lastconnum != null)
                    aList.Add($@"update pro_con.t_steel_con n set n.plan_num=null,n.heat_num=null where n.con_num='{lastconnum}' ");
                return OracleDataHelper.ExecuteTransaction(aList);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 获取天车动作起吊重量
        /// </summary>
        /// <returns></returns>
        public int BeforeliftingWEIGHT(int objid, int cachenum)
        {
            try
            {
                return int.Parse(OracleDataHelper.ExecuteDataTable($@"select d.weight from pro_bac.t_cra_action_record d where d.t_object_info_id={objid} and d.cache_num={cachenum}").Rows[0]["weight"].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 删除临时包信息
        /// </summary>
        /// <param name="obj">临时包信息</param>
        /// <param name="connum">正常包号</param>
        ///  <param name="posit">位置</param>
        public int deleteTempcon(string posit)
        {
            //ArrayList aList = new ArrayList();
            //////修改动作表
            ////aList.Add($@"update pro_bac.t_cra_action_record set FIELD1='临时包替换为正式包' , FIELD2='{connum}' where  hoist_num='{obj.LAD_NUM}'");
            ////删除临时包
            //aList.Add();
            return OracleDataHelper.ExecuteNonQuery($@"delete from pro_con.T_TEMP_LAD_INFO  where  posit='{posit}'");
        }
        /// <summary>
        /// 插入临时容器
        /// </summary>
        /// <param name="ladnum">容器编号</param>
        /// <param name="posit">位置</param>
        /// <param name="real_x">X地址</param>
        /// <param name="real_y">Y地址</param>
        /// <param name="gen_xcoord">创建X地址</param>
        /// <param name="gen_ycoord">创建Y地址</param>
        /// <param name="field1">负载标志</param>
        /// <param name="field2">吊运天车</param>
        /// <returns></returns>
        public int insertTempcon(string ladnum, string posit, int real_x, int real_y, int gen_xcoord, int gen_ycoord, int field1, int field2)
        {
            try
            {
                string sql = @"insert into pro_con.t_Temp_Lad_Info(id,lad_num,lad_nam,posit,real_x,real_y,gen_xcoord,gen_ycoord,gen_time,field1,field2)";
                sql += $@"select sys_guid() id, {ladnum} lad_num, '临时包' lad_nam, '{posit}' posit, {real_x} real_x, {real_y} real_y, {gen_xcoord} gen_xcoord, {gen_ycoord} gen_ycoord, sysdate gen_time, '{field1}' field1, '{field2}' field2 from dual";
                return OracleDataHelper.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新转炉放吊动作炉次号和转炉放吊前其他动作炉次号
        /// </summary>
        /// <param name="heatnum">炉次号</param>
        /// <param name="wstnum">工位</param>
        /// <returns></returns>
        public string updateTilterHeatNum(string heatnum, string wstnum)
        {
            string ExecuteSql = null;
            try
            {
                string sql = $@"update pro_bac.t_cra_action_record d set d.heat_num='{heatnum}' where d.id=(select id from(select d.id, d.heat_num from  (select * from pro_bac.t_cra_action_record d where d.posit = '{wstnum}' and d.action_symbol in (3, 4) order by d.accept_time desc)d where rownum = 1) where heat_num is null)";
                ExecuteSql += $"转炉放吊炉次号赋值，执行结果{OracleDataHelper.ExecuteNonQuery(sql)}，SQL：{sql}";
                sql = $@"update pro_bac.t_cra_action_record d set d.heat_num='{heatnum}' where d.id=(select id from (select * from (select d.id,d.heat_num,d.accept_time from pro_bac.t_cra_action_record d join (select d.t_object_info_id,d.accept_time from (select * from pro_bac.t_cra_action_record d  where d.posit='{wstnum}' and d.action_symbol in (3,4)  order by d.accept_time desc)d where rownum=1) t on d.t_object_info_id=t.t_object_info_id  where d.action_symbol=6 and to_char(d.accept_time,'yyyy-MM-dd hh24:mi:ss')<=to_char(t.accept_time,'yyyy-MM-dd hh24:mi:ss')  order by d.accept_time desc) d where rownum=1) where heat_num is null)";
                ExecuteSql += $"转炉放吊前一个其他动作炉次号赋值，执行结果{OracleDataHelper.ExecuteNonQuery(sql)}，SQL：{sql}";
                sql = $@"update pro_bac.t_cra_action_record d set d.heat_num='{heatnum}' where d.id=(select id from (select * from (select d.id,d.heat_num,d.accept_time from pro_bac.t_cra_action_record d join (select d.t_object_info_id,d.accept_time from (select * from pro_bac.t_cra_action_record d  where d.posit='{wstnum}' and d.action_symbol in (3,4)  order by d.accept_time desc)d where rownum=1) t on d.t_object_info_id=t.t_object_info_id  where d.action_symbol in (1,2) and to_char(d.accept_time,'yyyy-MM-dd hh24:mi:ss')<=to_char(t.accept_time,'yyyy-MM-dd hh24:mi:ss')  order by d.accept_time desc) d where rownum=1) where heat_num is null)";
                ExecuteSql += $"转炉放吊前一个起吊动作炉次号赋值，执行结果{OracleDataHelper.ExecuteNonQuery(sql)}，SQL：{sql}";
                return ExecuteSql;
            }
            catch (Exception ex)
            {
                return ExecuteSql += ex.Message;
            }

        }

        /// <summary>
        /// 替换容器
        /// </summary>
        /// <param name="posit">位置</param>
        /// <returns></returns>
        public void Replacecon(string posit)
        {
            try
            {
                string sql = null;
                DataTable dt = null;
                string guid = Guid.NewGuid().ToString("N");
                if (!string.IsNullOrEmpty(posit))
                    if (posit.Contains("'CRA"))
                    {
                        sql = $@"select d.* from pro_bac.t_Cra_Action_Record d join pub.t_object_info o on d.t_object_info_id=o.id where o.obj_num='{posit}' and rownum=1 order by d.accept_time desc";
                        dt = OracleDataHelper.ExecuteDataTable(sql);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                insertTempcon(guid, posit, 0, 0, 0, 0, 1, int.Parse(dt.Rows[0]["t_object_info_id"].ToString()));
                                sql = $@"update pro_bac.t_Cra_Action_Record d set d.hoist_num='{guid}', field1='正式容器换成临时容器-BOF处理逻辑产生' where d.id='{dt.Rows[0]["id"].ToString()}'";
                                OracleDataHelper.ExecuteNonQuery(sql);
                            }
                        }
                    }
                    else
                    {
                        sql = $@"select d.* from pro_bac.t_Cra_Action_Record d join pub.t_object_info o on d.t_object_info_id=o.id where o.obj_num='{posit}' and rownum=1 order by d.accept_time desc";
                        dt = OracleDataHelper.ExecuteDataTable(sql);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                insertTempcon(guid, posit, 0, 0, 0, 0, 1, int.Parse(dt.Rows[0]["t_object_info_id"].ToString()));
                                sql = $@"update pro_bac.t_Cra_Action_Record d set d.hoist_num='{guid}', field1='正式容器换成临时容器-BOF处理逻辑产生' where d.id='{dt.Rows[0]["id"].ToString()}'";
                                OracleDataHelper.ExecuteNonQuery(sql);
                                sql = $@"select d.* from pro_bac.t_Cra_Action_Record d where d.t_object_info_id={dt.Rows[0]["t_object_info_id"].ToString()} and d.cache_num={dt.Rows[0]["cache_num"].ToString()}-1";
                                dt = OracleDataHelper.ExecuteDataTable(sql);
                                if (dt != null)
                                {
                                    if (dt.Rows.Count > 0)
                                    {
                                        sql = $@"update pro_bac.t_Cra_Action_Record d set d.hoist_num='{guid}', field1='正式容器换成临时容器-BOF处理逻辑产生' where d.id='{dt.Rows[0]["id"].ToString()}'";
                                        OracleDataHelper.ExecuteNonQuery(sql);
                                    }
                                }
                            }
                        }
                    }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 连铸机空容器处理
        /// </summary>
        /// <param name="wstnum">工位编号</param>
        /// <param name="craaction">天车动作</param>
        /// <param name="connum">容器编号</param>
        /// <returns>处理结果</returns>
        public string CcmEmptyConDispose(string wstnum, int craaction, string tempconnum)
        {
            ArrayList aList = new ArrayList();
            string replacewstnum = null;
            if (string.IsNullOrEmpty(wstnum))
                return "工位为空";
            replacewstnum = wstnum.Substring(3, 3);//替换工位
            switch (replacewstnum)
            {
                case "1_L":
                    replacewstnum = "CCM1_C";
                    break;
                case "2_L":
                    replacewstnum = "CCM2_C";
                    break;
                case "3_L":
                    replacewstnum = "CCM3_C";
                    break;
                case "4_L":
                    replacewstnum = "CCM4_C";
                    break;
            }
            string sql = "";
            int iret = 0;
            try
            {
                if (!string.IsNullOrEmpty(tempconnum))
                {
                    sql = $@"update pro_con.t_temp_lad_info con set con.posit='{wstnum}' where con.id in (select id from pro_con.t_temp_lad_info con1 where con1.posit='{replacewstnum}')";
                    //修改临时容器表
                    iret = OracleDataHelper.ExecuteNonQuery(sql);
                    sql = $@"update pro_con.t_temp_lad_info con set con.posit='{replacewstnum}' where con.posit='{wstnum}' and con.lad_num='{tempconnum}' ";
                    //修改临时容器表
                    iret = OracleDataHelper.ExecuteNonQuery(sql);
                    sql = $@"update pro_con.t_steel_con con set con.posit='{wstnum}' where con.id in (select id from pro_con.t_steel_con con1 where con1.posit='{replacewstnum}')";
                    //修改容器表
                    OracleDataHelper.ExecuteNonQuery(sql);
                }
                return "1";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}:SQL:{sql}";
            }
        }

        /// <summary>
        /// 连铸机容器处理
        /// </summary>
        /// <param name="wstnum">工位编号</param>
        /// <param name="craaction">天车动作</param>
        /// <param name="conid">容器id</param>
        /// <param name="tempconid">临时容器id</param>
        /// <returns>处理结果</returns>
        public string CcmConDispose(string wstnum, int craaction, string conid, string tempconid)
        {
            ArrayList aList = new ArrayList();
            string replacewstnum = null;
            if (string.IsNullOrEmpty(wstnum))
                return "工位为空";
            replacewstnum = wstnum.Substring(3, 3);//替换工位
            switch (replacewstnum)
            {
                case "1_L":
                    replacewstnum = "CCM1_C";
                    break;
                case "2_L":
                    replacewstnum = "CCM2_C";
                    break;
                case "3_L":
                    replacewstnum = "CCM3_C";
                    break;
                case "4_L":
                    replacewstnum = "CCM4_C";
                    break;
            }

            string sql = "";
            int iret = 0;
            try
            {

                if (!string.IsNullOrEmpty(conid))
                {
                    sql = $@"update pro_con.t_steel_con con set con.posit='{wstnum}' where con.id in (select id from pro_con.t_steel_con con1 where con1.posit='{replacewstnum}')";
                    //修改容器表
                    iret = OracleDataHelper.ExecuteNonQuery(sql);
                    sql = $@"update pro_con.t_steel_con con set con.posit='{replacewstnum}' where con.posit='{wstnum}' and con.id={conid}";
                    //修改容器表
                    iret = OracleDataHelper.ExecuteNonQuery(sql);
                    sql = $@"update pro_con.t_temp_lad_info con set con.posit='{wstnum}' where con.id in (select id from pro_con.t_temp_lad_info con1 where con1.posit='{replacewstnum}')";
                    //修改临时容器表
                    iret = OracleDataHelper.ExecuteNonQuery(sql);
                }
                if (!string.IsNullOrEmpty(tempconid))
                {
                    sql = $@"update pro_con.t_temp_lad_info con set con.posit='{wstnum}' where con.id in (select id from pro_con.t_temp_lad_info con1 where con1.posit='{replacewstnum}')";
                    //修改临时容器表
                    iret = OracleDataHelper.ExecuteNonQuery(sql);
                    sql = $@"update pro_con.t_temp_lad_info con set con.posit='{replacewstnum}' where con.posit='{wstnum}' and con.id='{tempconid}' ";
                    //修改临时容器表
                    iret = OracleDataHelper.ExecuteNonQuery(sql);
                    sql = $@"update pro_con.t_steel_con con set con.posit='{wstnum}' where con.id in (select id from pro_con.t_steel_con con1 where con1.posit='{replacewstnum}')";
                    //修改容器表
                    OracleDataHelper.ExecuteNonQuery(sql);
                }
                return "1";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}:SQL:{sql}";
            }
        }

        /// <summary>
        /// 获取炼钢容器（钢包）
        /// <returns></returns>
        public List<LADLE_REAL_INFO> getSteelConLadle()
        {
            try
            {
                return OracleDataHelper.QueryOver<LADLE_REAL_INFO>().OrderBy(t => t.ID).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 获取炼钢容器（铁包）
        /// <returns></returns>
        public List<HML_REAL_INFO> getSteelConHml()
        {
            try
            {
                return OracleDataHelper.QueryOver<HML_REAL_INFO>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 获取炼钢容器（废钢斗）
        /// <returns></returns>
        public List<SLOT_REAL_INFO> getSteelConSlot()
        {
            try
            {
                return OracleDataHelper.QueryOver<SLOT_REAL_INFO>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int UpdateEntity<T>(T entity)
        {
            try
            {
                return OracleDataHelper.Update(entity);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int DeleteEntity<T>(T entity)
        {
            try
            {
                return OracleDataHelper.Delete(entity);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int AddEntity<T>(T entity)
        {
            try
            {
                return OracleDataHelper.Add(entity);
            }
            catch (Exception)
            {
                return 0;
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
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// 获取临时容器
        /// <returns></returns>
        public List<TEMP_CON> getTempCon()
        {
            try
            {
                return OracleDataHelper.QueryOver<TEMP_CON>().Where(a => a.TIME_STAMP >= DateTime.Now.AddDays(-2)).OrderByDescending(t => t.TIME_STAMP).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 台车实时信息
        /// <returns></returns>
        public List<TRO_REAL_INFO> GetTroRealInfoList()
        {
            try
            {
                return OracleDataHelper.QueryOver<TRO_REAL_INFO>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 根据工位id获取台车实时表数据
        /// </summary>
        /// <param name="wstId"></param>
        /// <returns></returns>
        public TRO_REAL_INFO GetTroRealInfo(int wstId)
        {
            var lstTroRealInfo = GetTroRealInfoList();
            foreach (var item in lstTroRealInfo)
            {
                if (item.TRO_ID.POSITION_ID_GATHER != null && item.TRO_ID.POSITION_ID_GATHER.Contains(wstId.ToString() + ","))
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// 起吊清空台车数据
        /// </summary>
        /// <param name="troReal"></param>
        /// <param name="conNum"></param>
        /// <param name="loadSymbol"></param>
        /// <param name="wstId"></param>
        /// <returns></returns>
        public string UpdateTroRealInfoSql(TRO_REAL_INFO troReal, int? iTroLoad_symbol)
        {
            if (troReal != null)
            {
                var strSql = $@"UPDATE PUB.TRO_REAL_INFO SET CON_NUM = '', LOAD_SYMBOL={iTroLoad_symbol}  WHERE ID = {troReal.ID}";
                return strSql;
            }
            return null;
        }

        /// <summary>
        /// 放吊更新台车数据
        /// </summary>
        /// <param name="troReal"></param>
        /// <param name="conNum"></param>
        /// <param name="loadSymbol"></param>
        /// <param name="wstId"></param>
        /// <returns></returns>
        public string UpdateTroRealInfoSql(TRO_REAL_INFO troReal, string conNum, int? iTroLoad_symbol)
        {
            if (troReal != null && conNum != null)
            {
                var strSql = $@"update pub.TRO_REAL_INFO set CON_NUM = '{conNum}', LOAD_SYMBOL={iTroLoad_symbol}  where id = {troReal.ID}";
                return strSql;
            }
            else
            {
                var strSql = $@"update pub.TRO_REAL_INFO set CON_NUM = '', LOAD_SYMBOL={iTroLoad_symbol}  where id = {troReal.ID}";
                return strSql;
            }
            return null;
        }

        /// <summary>
        /// 实时显示每台相机当前的识别信息
        /// <returns></returns>
        public List<LADLE_DISCERN> getLadleDiscern()
        {
            try
            {
                return OracleDataHelper.QueryOver<LADLE_DISCERN>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 实时显示每台相机当前的识别信息记录
        /// <returns></returns>
        //public List<LADLE_DISCERN_RECORD> getLadleDiscernRecord(string WstNum)
        //{
        //    try
        //    {
        //        return OracleDataHelper.QueryOver<LADLE_DISCERN_RECORD>().Where(a => a.T_WST_OBJ_ID.T_OBJECT_INFO_ID.OBJ_NUM == WstNum && a.FIELD1 == "0").ToList();
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        /// <summary>
        /// 实时显示每台相机当前的识别信息记录
        /// <returns></returns>
        public List<LADLE_DISCERN_RECORD> getLadleDiscernRecord()
        {
            try
            {
                return OracleDataHelper.QueryOver<LADLE_DISCERN_RECORD>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取设备实时信息(脱硫站)
        /// </summary>
        /// <param name="objid">对象ID</param>
        /// <returns></returns>
        public DES_HEAT_STATUS getdesDvcRealStatus(int objId)
        {
            try
            {
                var desProperty = OracleDataHelper.QueryOver<DES_PROPERTY>().Where(t => t.OBJ_ID == objId).FirstOrDefault();
                return OracleDataHelper.QueryOver<DES_HEAT_STATUS>().Where(t => t.DES_ID == desProperty.ID).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // 获取设备实时信息 (todo :除了脱硫站其他还有四种设备)

        /// <summary>
        /// 获取天车实时信息
        /// </summary>
        /// <param name="objid">对象ID</param>
        /// <returns></returns>
        public CRANE_REAL_INFO getCraRealInfo(int? objid)
        {
            try
            {
                return OracleDataHelper.QueryOver<CRANE_REAL_INFO>().Where(a => a.OBJ_STATUS_ID == objid).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取天车属性信息
        /// </summary>
        /// <param name="craId">天车属_序号</param>
        /// <returns></returns>
        public CRANE GetCrane(int craId)
        {
            try
            {
                return OracleDataHelper.QueryOver<CRANE>().Where(a => a.ID == craId).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 根据主键获取跨
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SPA GetSPA(int id)
        {
            try
            {
                return OracleDataHelper.QueryOver<SPA>().Where(a => a.ID == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取天车实时信息
        /// </summary>
        /// <param name="objid">对象ID</param>
        /// <returns></returns>
        public List<CRANE_REAL_INFO> GetCraRealInfo()
        {
            try
            {
                return OracleDataHelper.QueryOver<CRANE_REAL_INFO>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 插入天车运行数据
        /// 作者：周张智
        /// 日期：2019-10-10
        /// </summary>
        /// <param name="objId">天车对象ID</param>
        /// <returns></returns>
        public string InsertRunDate(string ProcedureName, int objId)
        {
            return null;
            //try
            //{
            //    OracleParameter[] parameter = {
            //                                 new OracleParameter("obj_id",OracleDbType.Int32)
            //                             };
            //    parameter[0].Value = objId;
            //    return OracleDataHelper.ExecuteProcedure(ProcedureName, parameter).ToString();
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message;
            //}
        }

        #region 铁水天车起吊
        public string getTrolleyInfo(int wstId)
        {
            string str = string.Empty;

            try
            {
                string strsql = $@"SELECT POSITION_ID_GATHER FROM PUB.TROLLEY WHERE POSITION_ID_GATHER LIKE '%{wstId}%'";

                string strgather = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));

                if (!string.IsNullOrEmpty(strgather))
                {
                    strgather = strgather.Substring(0, strgather.Length - 1);

                    string strsqlinfo = $@"SELECT id FROM sm.HML_REAL_INFO WHERE POSIT IN (SELECT NUM FROM PUB.WST WHERE ID IN({strgather}))";

                    str = Convert.ToString(OracleDataHelper.ExecuteScalar(strsqlinfo));
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁水天车兑物", ex.Message);
            }
            return str;
        }

        public string getTrolleyTemp(int wstId)
        {
            string str = string.Empty;

            try
            {
                string strsql = $@"SELECT POSITION_ID_GATHER FROM PUB.TROLLEY WHERE POSITION_ID_GATHER LIKE '%{wstId}%'";

                string strgather = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));

                if (!string.IsNullOrEmpty(strgather))
                {
                    strgather = strgather.Substring(0, strgather.Length - 1);

                    string strsqltemp = $@"SELECT id FROM sm.TEMP_CON WHERE POSIT IN (SELECT NUM FROM PUB.WST WHERE ID IN({strgather})) ORDER BY TIME_STAMP DESC";

                    str = Convert.ToString(OracleDataHelper.ExecuteScalar(strsqltemp));
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁水天车兑物", ex.Message);
            }
            return str;
        }
        #endregion

        #region 铁水天车兑物
        public string getCraActionRecordHoistid(int craId, string operationtime)
        {
            string str = string.Empty;

            try
            {
                string strsql = $@"SELECT ID FROM (SELECT ID FROM PUB.crane_action_record WHERE ACTION_SYMBOL IN (1,2) AND CRA_ID={craId} AND OPERATION_TIME<TO_DATE('{operationtime}','YYYY-MM-DD HH24:MI:SS') ORDER BY OPERATION_TIME DESC) T WHERE ROWNUM=1";

                str = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁水天车兑物", ex.Message);
            }
            return str;
        }

        public DataTable getCraActionRecordDropData(int craId, string operationtime)
        {
            DataTable dt = new DataTable();

            try
            {
                string strsql = $@"SELECT ACTION_SYMBOL,HEAT_NUM FROM(SELECT ACTION_SYMBOL,HEAT_NUM FROM PUB.crane_action_record WHERE ACTION_SYMBOL != 6 AND CRA_ID = {craId} AND OPERATION_TIME<TO_DATE('{operationtime}','YYYY-MM-DD HH24:MI:SS') ORDER BY OPERATION_TIME DESC) T WHERE ROWNUM=1";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁水天车兑物", ex.Message);
            }
            return dt;
        }
        #endregion

        #region 钢水天车起吊
        public string getLadleTrolleyInfo(int wstId)
        {
            string str = string.Empty;

            try
            {
                string strsql = $@"SELECT POSITION_ID_GATHER FROM PUB.TROLLEY WHERE POSITION_ID_GATHER LIKE '%{wstId}%'";

                string strgather = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));

                if (!string.IsNullOrEmpty(strgather))
                {
                    strgather = strgather.Substring(0, strgather.Length - 1);

                    string strsqlinfo = $@"SELECT id FROM sm.LADLE_REAL_INFO WHERE POSIT IN (SELECT NUM FROM PUB.WST WHERE ID IN({strgather}))";

                    str = Convert.ToString(OracleDataHelper.ExecuteScalar(strsqlinfo));
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "钢水天车起吊", ex.Message);
            }
            return str;
        }

        public string getLadleTrolleyTemp(int wstId)
        {
            string str = string.Empty;

            try
            {
                string strsql = $@"SELECT POSITION_ID_GATHER FROM PUB.TROLLEY WHERE POSITION_ID_GATHER LIKE '%{wstId}%'";

                string strgather = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));

                if (!string.IsNullOrEmpty(strgather))
                {
                    strgather = strgather.Substring(0, strgather.Length - 1);

                    string strsqltemp = $@"SELECT id FROM sm.TEMP_CON WHERE POSIT IN (SELECT NUM FROM PUB.WST WHERE ID IN({strgather}))";

                    str = Convert.ToString(OracleDataHelper.ExecuteScalar(strsqltemp));
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁水天车兑物", ex.Message);
            }
            return str;
        }

        public string getLadleHeatNum(int intcraid,string strdatetime)
        {
            string str = string.Empty;

            try
            {
                string strsql = $@" SELECT ID FROM(SELECT ID FROM PUB.CRANE_ACTION_RECORD WHERE CRA_ID= {intcraid} AND ACTION_SYMBOL IN(1,2) AND OPERATION_TIME<TO_DATE('{strdatetime}','YYYY-MM-DD HH24:MI:SS') ORDER BY OPERATION_TIME DESC) WHERE ROWNUM<=1";

                str = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));
 
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁水天车兑物", ex.Message);
            }
            return str;
        }


        #endregion

        #region 钢包识别触发信号
        /// <summary>
        /// 查询天车与相机交互数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CAMERA_CRANE_EXCHANGE_Data()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.ID,A.FIELD1,A.WST_NUM,A.DISCERN_TYPE,B.NUM,B.POSITION_LENGTH, B.WIDTH, B.CENTRE_X,B.CENTRE_Y,C.CRA_NUM,C.CRA_TYPE,C.WEIGHT_DOWN_LIMIT,C.WEIGHT_UP_LIMIT,C.WEIGHT_IN_RANGE,C.ON_POSIT_FLAG FROM LD.CAMERA_CRANE_EXCHANGE A LEFT JOIN PUB.WST B ON A.WST_NUM=B.ID LEFT JOIN LD.CRANE_TRIGGER C ON A.ID=C.ID WHERE IS_ENABLE=1 ORDER BY ID";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }

            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "查询天车与相机交互数据异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询天车实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CraRealInfo_Data()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.CRA_ID, A.COORD_X, A.COORD_Y, A.WEIGHT,B.CRA_NUM FROM PUB.CRANE_REAL_INFO A LEFT JOIN PUB.CRANE B ON A.CRA_ID=B.ID WHERE CRA_ID IN(3,4,8,9,10,11,12,13,14,15,16,17,18) ORDER BY CRA_ID";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询天车跟踪包号
        /// </summary>
        /// <returns></returns>
        public string  Get_Ladle_Info_Data(string strcranum)
        {
            string strconid=string.Empty;
            try
            {
                string strsql = @"SELECT CON_ID FROM SM.LADLE_REAL_INFO WHERE POSIT='"+ strcranum + "'";

                strconid = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return strconid;
        }

        public int Set_T_LADLE_DISCERN_Data(string strnum)
        {
            int iArgs = 0;

            try
            {

                string strsqlInsert = "UPDATE PRO_CON.T_LADLE_DISCERN SET TRACKING_FLAG=1 WHERE CRAMERA_NUM='" + strnum + "'";


                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "钢包识别触发业务", strsqlInsert);


                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句 

                if (iArgs == 1)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "钢包识别触发业务", "钢包识别触发信号更新成功！");
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "钢包识别触发业务", "钢包识别触发信号更新失败！");
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "钢包识别触发业务", ex.Message);
            }

            return iArgs;
        }
        #endregion

        #region 连铸机旋转更新
        /// <summary>
        /// 查询连铸机旋转数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetCCMRotationData()
        {
            DataTable dt = new DataTable();
            try
            {
                string strSql = @" SELECT MSG_COUNTER, PLANT_NO FROM SI_DATA.CCM_ROTATION_INTERFACE WHERE MSG_STATUS='0' ORDER BY MSG_TIME";

                dt = OracleDataHelper.ExecuteDataTable(strSql);

            }
            catch (Exception)
            {
                return dt;
            }
            return dt;
        }

        /// <summary>
        /// 连铸机旋转更新钢包位置
        /// </summary>
        /// <param name="intno">连铸机编号</param>
        /// <returns></returns>
        public int SetLadleWstdata(int intmsg, int intno)
        {
            int iargs = 0;
            string strsql = string.Empty;
            DataTable dt = new DataTable();
            switch (intno)
            {
                case 1:
                    strsql = @"SELECT ID,POSIT FROM SM.LADLE_REAL_INFO WHERE POSIT IN(SELECT NUM FROM PUB.WST WHERE NAME LIKE '1#方坯%')";
                    break;
                case 2:
                    strsql = @"SELECT ID,POSIT FROM SM.LADLE_REAL_INFO WHERE POSIT IN(SELECT NUM FROM PUB.WST WHERE NAME LIKE '2#方坯%')";
                    break;
                case 3:
                    strsql = @"SELECT ID,POSIT FROM SM.LADLE_REAL_INFO WHERE POSIT IN(SELECT NUM FROM PUB.WST WHERE NAME LIKE '3#方坯%')";
                    break;
                case 4:                    
                    break;
                case 5:
                    break;
                default:
                    break;

            }

            dt = OracleDataHelper.ExecuteDataTable(strsql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    int intid = Convert.ToInt16(dr["ID"]);

                    string strposit = Convert.ToString(dr["POSIT"]);

                    if (strposit.Contains("CAST"))
                    {
                        strposit = strposit.Replace("CAST", "HOIST");
                    }
                    else
                    {
                        strposit = strposit.Replace("HOIST", "CAST");
                    }

                    string strupdatesql = "UPDATE SM.LADLE_REAL_INFO SET POSIT='" + strposit + "' WHERE ID=" + intid + "";

                    iargs = OracleDataHelper.ExecuteNonQuery(strupdatesql);

                    if (iargs > 0)
                    {
                        log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸机旋转更新成功", strupdatesql);
                    }
                    else
                    {
                        log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸机旋转更新失败", strupdatesql);
                    }
                }
            }

            string strupdate = "UPDATE SI_DATA.CCM_ROTATION_INTERFACE SET MSG_STATUS='1' WHERE MSG_COUNTER=" + intmsg + "";

            iargs = OracleDataHelper.ExecuteNonQuery(strupdate);

            if (iargs > 0)
            {
                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸机旋转更新成功", strupdate);
            }
            else
            {
                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸机旋转更新失败", strupdate);
            }

            return iargs;
        }
        #endregion

        #region 故障诊断
        /// <summary>
        /// 查询所有故障诊断天车
        /// </summary>
        /// <returns></returns>
        public DataTable getCraneData()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ''AS DATETIME,ID,SPA_ID,CRA_NUM,CRA_NAME,FIELD2,''AS HOIST_TIME,''AS DROP_TIME,'' AS X_COORD,'' AS Y_COORD FROM PUB.CRANE WHERE FIELD2=1";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "动作数据诊断", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询天车实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable getCraneRealData()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.CRA_ID, A.COORD_X, A.COORD_Y, A.WEIGHT,B.CRA_TYPE,B.CRA_NAME,B.SPA_ID FROM PUB.CRANE_REAL_INFO A LEFT JOIN PUB.CRANE B ON A.CRA_ID=B.ID WHERE B.FIELD2=1";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "动作数据诊断", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询天车动作数据
        /// </summary>
        /// <param name="strobjid"></param>
        /// <param name="strdatetime"></param>
        /// <returns></returns>
        public DataTable getCraneActionData(string strobjid, string strdatetime)
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT CRA_ID,ACTION_SYMBOL,ACCEPT_TIME FROM PUB.CRANE_ACTION_RECORD WHERE CRA_ID=" + strobjid + " AND ACTION_SYMBOL IN(1,2,3,4) AND ACCEPT_TIME > TO_DATE('" + strdatetime + "','YYYY-MM-DD HH24:MI:SS') ORDER BY CACHE_NUM";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "动作数据诊断", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询天车动作数据
        /// </summary>
        /// <param name="intobjid"></param>
        /// <param name="start_time"></param>
        /// <param name="end_time"></param>
        /// <returns></returns>
        public DataTable Get_CraAction_Data_Monitor(int intobjid, string start_time, string end_time)
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID  FROM PUB.CRANE_ACTION_RECORD WHERE CRA_ID=" + intobjid + " AND ACCEPT_TIME BETWEEN TO_DATE('" + start_time + "','YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + end_time + "','YYYY-MM-DD HH24:MI:SS')";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "动作数据故障诊断", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询跨信息
        /// </summary>
        /// <param name="intspa"></param>
        /// <returns></returns>
        public SPA Get_Spa_Info(int intspa)
        {
            try
            {
                return OracleDataHelper.QueryOver<SPA>().Where(a => a.ID == intspa).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 铁包智能调度
        /// <summary>
        /// 更新转炉设备状态
        /// </summary>
        public void setBofHeatStatus()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID, HEAT_NUM, PLAN_NUM, HEAT_STATUS, TIME_STAMP FROM SM.BOF_HEAT_STATUS WHERE HEAT_STATUS=31";

                dt = OracleDataHelper.ExecuteDataTable(strsql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string strsqlupd = @"UPDATE SM.BOF_HEAT_STATUS SET FIELD1='0' WHERE ID=" + dr["ID"] + "";

                        int iargs = OracleDataHelper.ExecuteNonQuery(strsqlupd);

                        if (iargs > 0)
                        {
                            log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "铁包智能调度", "炉次设备更新成功：" + strsqlupd);
                        }
                        else
                        {
                            log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "铁包智能调度", "炉次设备更新失败：" + strsqlupd);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁包智能调度", ex.Message);
            }
        }

        /// <summary>
        /// 更新转炉设备状态
        /// </summary>
        /// <param name="intid"></param>
        public void setBofHeatStatus(int intid)
        {
            DataTable dt = new DataTable();
            try
            {
                string strsqlupd = @"UPDATE SM.BOF_HEAT_STATUS SET FIELD1='1' WHERE ID=" + intid + "";

                int iargs = OracleDataHelper.ExecuteNonQuery(strsqlupd);

                if (iargs > 0)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "铁包智能调度", "炉次设备更新成功：" + strsqlupd);
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "铁包智能调度", "炉次设备更新失败：" + strsqlupd);
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁包智能调度", ex.Message);
            }
        }

        /// <summary>
        /// 查询转炉实时状态
        /// </summary>
        /// <returns></returns>
        public DataTable getBofHeatStatus()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID, HEAT_NUM, PLAN_NUM, HEAT_STATUS, TIME_STAMP FROM SM.BOF_HEAT_STATUS WHERE HEAT_STATUS=32 AND FIELD1='0'";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁包智能调度", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询容器调度计划信息
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int getDISPATCH_RESULT(string str)
        {
            int intcount=0;
            try
            {
                string strsql = @"SELECT ID FROM AD.D_CON_DISPATCH_RESULT WHERE HEAT_NUM='"+ str + "'";

                intcount = OracleDataHelper.ExecuteCount(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁包智能调度", ex.Message);
            }
            return intcount;
        }

        /// <summary>
        /// 查询下一炉炉次计划
        /// </summary>
        /// <param name="strbofid"></param>
        /// <returns></returns>
        public DataTable getAM01(string strbofid, string strheatnum)
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @" SELECT MSG_COUNTER, MSG_TIME, PONO,PLAN_HEAT_NO,ST_NO,BLOW_START_TIME, REFINE_ROUTE_CODE, PLAN_TAP_WT FROM(SELECT MSG_COUNTER, MSG_TIME, PONO,PLAN_HEAT_NO,ST_NO,BLOW_START_TIME, REFINE_ROUTE_CODE, PLAN_TAP_WT FROM SI_DATA.A6AM01 A WHERE OP_DIV IN('I', 'U') AND FURNACE_NO = '" + strbofid + "' AND TO_DATE(BLOW_START_TIME ,'YYYYMMDDHH24MISS')>(SELECT TO_DATE(BLOW_START_TIME,'YYYYMMDDHH24MISS') FROM SI_DATA.A6AM01 WHERE PLAN_HEAT_NO='"+ strheatnum + "' AND ROWNUM<=1) ORDER BY TO_NUMBER(A.BLOW_START_TIME) DESC) WHERE ROWNUM<= 1";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁包智能调度", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询下一炉制造标准
        /// </summary>
        /// <param name="strbofid"></param>
        /// <returns></returns>
        public DataTable getAM10(string strstno, string strbacklog)
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT SI_MAX, P_MAX_FE, S_MAX,BOF_IRON_WT_MIN,BOF_IRON_WT_MAX,WHOLE_BACKLOG FROM (SELECT SI_MAX, P_MAX_FE, S_MAX,BOF_IRON_WT_MIN,BOF_IRON_WT_MAX,WHOLE_BACKLOG FROM SI_DATA.A6AM10 A WHERE VALID_FLAG=1 AND OP_DIV IN('I','U') AND ST_NO='" + strstno + "' AND WHOLE_BACKLOG='B"+ strbacklog + "C' ORDER BY MSG_TIME DESC) WHERE ROWNUM<=1";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁包智能调度", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询未分流铁包信息
        /// </summary>
        /// <param name="strbofid"></param>
        /// <returns></returns>
        public DataTable getHM_INPUT_RECORD()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.HEAT_BATCH_NO,A.HML_NUM,A.INPUT_WST,A.IS_DISPATCH,B.NET_WT,B.IRON_TEMP,B.IRON_TEMP_TIME,C.CF_SI, C.CF_P, C.CF_S FROM SM.HM_INPUT_RECORD A LEFT JOIN SI_DATA.A6AM07 B ON A.HEAT_BATCH_NO=B.HEAT_BATCH_NO  LEFT JOIN SI_DATA.A6AM08 C ON A.HEAT_BATCH_NO=C.HEAT_BATCH_NO WHERE A.IS_DISPATCH=0 AND B.OP_DIV IN('I', 'U') AND C.OP_DIV IN('I', 'U') ORDER BY TO_DATE(B.IRON_TEMP_TIME,'YYYY-MM-DD HH24:MI:SS') DESC";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁包智能调度", ex.Message);
            }
            return dt;
        }

        public int getAM01PlanNum(int intno, string strno)
        {
            int iargs = 0;
            string strintno = string.Empty;
            
            try
            {
                switch (intno)
                {
                    case 1:
                    case 2:
                        strintno = "1,2";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        strintno = "3,4,5";
                        break;
                    default:
                        break;
                            
                }
                string strsql = @"SELECT ID, HEAT_NUM, PLAN_NUM, HEAT_STATUS, TIME_STAMP FROM SM.BOF_HEAT_STATUS IN("+ strintno + ")";

                DataTable dt = OracleDataHelper.ExecuteDataTable(strsql);

                if (dt != null && dt.Rows.Count>0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string strheatnum = Convert.ToString(dr["HEAT_NUM"]);

                        string strsqlnum = @"SELECT MSG_COUNTER FROM SI_DATA.A6AM01 A WHERE OP_DIV IN('I', 'U') AND FURNACE_NO = '"+ strno + "' AND TO_DATE(BLOW_START_TIME ,'YYYYMMDDHH24MISS')>(SELECT TO_DATE(BLOW_START_TIME,'YYYYMMDDHH24MISS') FROM SI_DATA.A6AM01 WHEREPLAN_HEAT_NO='"+ strheatnum + "' AND ROWNUM<=1)";

                        int icount = OracleDataHelper.ExecuteCount(strsqlnum);

                        iargs = iargs + icount;
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "铁包智能调度", ex.Message);
            }
            return iargs;
        }
        #endregion

        #region 物重校准
        /// <summary>
        /// 查询钢水跨所有天车
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CraRealInfo_Spa4_Data()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.ID, A.T_OBJECT_INFO_ID, A.X_COORD, A.Y_COORD, A.WEIGHT,B.OBJ_NUM,B.OBJ_NAM FROM PRO_BAC.T_CRA_REAL_INFO A LEFT JOIN PUB.T_OBJECT_INFO B ON A.T_OBJECT_INFO_ID=B.ID LEFT JOIN PUB.T_REL_SPA_SREA_OBJECT C ON A.T_OBJECT_INFO_ID=C.T_OBJECT_INFO_ID WHERE C.T_SPA_ID=4 ";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询钢水跨精炼重叠工位（2精炼2号工位、3精炼1号工位）
        /// </summary>
        /// <returns></returns>
        public DataTable Get_TroRealInfo_Spa4_Data()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.T_OBJECT_INFO_ID,A.X_COORD,A.Y_COORD,B.OBJ_NUM,B.OBJ_NAM FROM PRO_BAC.T_TRO_REAL_INFO A LEFT JOIN PUB.T_OBJECT_INFO B ON A.T_OBJECT_INFO_ID=B.ID WHERE A.T_OBJECT_INFO_ID IN (62,63)";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询转炉吊包位工位
        /// </summary>
        /// <returns></returns>
        public DataTable Get_WstInfo_Lift_BOF_Data()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.ID,A.T_OBJECT_INFO_ID,A.LENGTH, A.WIDTH, A.X_COORD, A.Y_COORD,B.OBJ_NUM,B.OBJ_NAM FROM PUB.T_WST_SENOR_INFO A LEFT JOIN PUB.T_OBJECT_INFO B ON A.T_OBJECT_INFO_ID=B.ID WHERE B.ENABLE=2 AND B.OBJ_NUM LIKE 'BOF%L' ORDER BY A.ID";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }

            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询精炼吊包位工位
        /// </summary>
        /// <returns></returns>
        public DataTable Get_WstInfo_Lift_LF_RH_Data()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.ID,A.T_OBJECT_INFO_ID,A.LENGTH, A.WIDTH, A.X_COORD, A.Y_COORD,B.OBJ_NUM,B.OBJ_NAM FROM PUB.T_WST_SENOR_INFO A LEFT JOIN PUB.T_OBJECT_INFO B ON A.T_OBJECT_INFO_ID=B.ID WHERE B.ENABLE=2 AND B.OBJ_NUM LIKE 'LF%L%' OR B.OBJ_NUM LIKE 'RH%L%' ORDER BY A.ID";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }

            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询连铸吊包位工位
        /// </summary>
        /// <returns></returns>
        public DataTable Get_WstInfo_Lift_CCM_Data()
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.ID,A.T_OBJECT_INFO_ID,A.LENGTH, A.WIDTH, A.X_COORD, A.Y_COORD,B.OBJ_NUM,B.OBJ_NAM FROM PUB.T_WST_SENOR_INFO A LEFT JOIN PUB.T_OBJECT_INFO B ON A.T_OBJECT_INFO_ID=B.ID WHERE B.ENABLE=2 AND B.OBJ_NUM LIKE 'CC%L' ORDER BY A.ID";

                dt = OracleDataHelper.ExecuteDataTable(strsql);
            }

            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 运行状态信息更新
        /// </summary>
        /// <param name="itype">类型</param>
        /// <param name="iobjid">对象ID</param>
        /// <param name="strcranum">天车编号</param>
        /// <returns></returns>
        public int Set_WstWeightStatus_BOF_LF_RH_Update(int itype, string strid, string strcranum)
        {
            int iArgs = 0;
            string strsql = string.Empty;
            try
            {
                switch (itype)
                {
                    case 1:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,DROP_CRA_NUM='" + strcranum + "' WHERE ID='" + strid + "'";
                        break;
                    case 2:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,DROP_STATUS=1,DROP_TIME=SYSDATE WHERE ID='" + strid + "'";
                        break;
                    case 3:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,DROP_CRA_NUM='' WHERE ID='" + strid + "'";
                        break;
                    case 4:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,POUR_CRA_NUM='" + strcranum + "',POUR_ARRIVE_TIME=SYSDATE WHERE ID='" + strid + "'";
                        break;
                    case 5:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,POUR_LEAVE_TIME=SYSDATE WHERE ID='" + strid + "'";
                        break;
                    case 6:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,POUR_STATUS=1 WHERE ID='" + strid + "'";
                        break;
                    case 7:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,POUR_CRA_ID=0  WHERE ID='" + strid + "'";
                        break;
                    case 8:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,HOIST_CRA_NUM='" + strcranum + "' WHERE ID='" + strid + "'";
                        break;
                    case 9:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,HOIST_STATUS=1,HOIST_TIME=SYSDATE WHERE ID='" + strid + "'";
                        break;
                    case 10:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CREATE_TIME=SYSDATE,HOIST_CRA_NUM='' WHERE ID='" + strid + "'";
                        break;
                    default:
                        break;
                }

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsql);


                iArgs = OracleDataHelper.ExecuteNonQuery(strsql);//执行SQL语句 

                if (iArgs == 1)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息更新成功！");
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息更新失败！");
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 记录天车动作状态
        /// </summary>
        /// <param name="drid">ID</param>
        /// <returns></returns>
        public int Set_WstWeightStatusRecord_Insert(string drid)
        {
            int iArgs = 0;
            try
            {
                string strsqlInsert = "INSERT INTO PRO_BAC.T_WST_WEIGHT_STATUS_RECORD SELECT  SYS_GUID() ID,ID AS T_WST_WEIGHT_STATUS_ID, T_OBJECT_INFO_ID, POSIT, DROP_STATUS, DROP_CRA_NUM, DROP_TIME, DROP_WEIGHT, HOIST_STATUS, HOIST_CRA_NUM, HOIST_TIME, HOIST_WEIGHT, POUR_STATUS, POUR_CRA_NUM, POUR_ARRIVE_TIME, BEFORE_POUR_WEIGHT, POUR_LEAVE_TIME, AFTER_POUR_WEIGHT, DISLODGE_SLAG_WEIGHT, MAX_WEIGHT, MIN_WEIGHT, IS_SEND, FLAG, CASTING_STATUS, CASTING_CRA_NUM, CASTING_DROP_TIME, TEMP_CRA_NUM, TEMP_WEIGHT, HEAT_NUM, CONT_NUM, FIELD1, FIELD2, XML_DATA, CREATE_TIME FROM PRO_BAC.T_WST_WEIGHT_STATUS WHERE ID = '" + drid + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsqlInsert);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句 

                if (iArgs == 1)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息新增成功！");
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息新增失败！");
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 记录天车运行状态
        /// </summary>
        /// <param name="drid">ID</param>
        /// /// <returns></returns>
        public int Set_WstWeightStatusRecord_All_Insert(string drid)
        {
            int iArgs = 0;
            try
            {
                //新增状态记录
                string strsqlInsert = "INSERT INTO PRO_BAC.T_WST_WEIGHT_STATUS_RECORD SELECT  SYS_GUID() ID,ID AS T_WST_WEIGHT_STATUS_ID, T_OBJECT_INFO_ID, POSIT, DROP_STATUS, DROP_CRA_NUM, DROP_TIME, DROP_WEIGHT, HOIST_STATUS, HOIST_CRA_NUM, HOIST_TIME, HOIST_WEIGHT, POUR_STATUS, POUR_CRA_NUM, POUR_ARRIVE_TIME, BEFORE_POUR_WEIGHT, POUR_LEAVE_TIME, AFTER_POUR_WEIGHT, DISLODGE_SLAG_WEIGHT, MAX_WEIGHT, MIN_WEIGHT, IS_SEND, FLAG, CASTING_STATUS, CASTING_CRA_NUM, CASTING_DROP_TIME, TEMP_CRA_NUM, TEMP_WEIGHT, HEAT_NUM, CONT_NUM, FIELD1, FIELD2, XML_DATA, CREATE_TIME FROM PRO_BAC.T_WST_WEIGHT_STATUS WHERE ID = '" + drid + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsqlInsert);

                //更新状态记录
                string strsqlUpdate = $@"UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET DROP_STATUS=0,DROP_CRA_NUM= '',HOIST_STATUS=0,HOIST_CRA_NUM='' WHERE ID = '" + drid + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsqlUpdate);

                ArrayList arrlist = new ArrayList();
                arrlist.Add(strsqlInsert);
                arrlist.Add(strsqlUpdate);

                iArgs = OracleDataHelper.ExecuteTransaction(arrlist);//执行SQL语句

                if (iArgs > 1)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息新增成功！");
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息新增失败！");
                }

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 统计天车运行数据
        /// </summary>
        /// <param name="craid">天车ID</param>
        /// <param name="emptyweight">最小重量</param>
        /// <param name="strdates">开始时间</param>
        /// <param name="strdatee">结束时间</param>
        /// <returns></returns>
        public DataTable Get_CraRunRecord_Weight_Data(int craid, int emptyweight, string strdates, string strdatee)
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT WEIGHT,COUNT(*) FROM PRO.CRA_RUN_RECORD WHERE T_OBJECT_INFO_ID =" + craid + " AND WEIGHT > " + emptyweight + " AND TIME_STAMP > TO_DATE('" + strdates + "','YYYY-MM-DD HH24:MI:SS') AND TIME_STAMP < TO_DATE('" + strdatee + "','YYYY-MM-DD HH24:MI:SS') GROUP BY WEIGHT ORDER BY COUNT(*) DESC";//运行数据


                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsql);

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 统计天车运行数据
        /// </summary>
        /// <param name="craid">天车ID</param>
        /// <param name="fullweight">最大重量</param>
        /// <param name="emptyweight">最小重量</param>
        /// <param name="strdates">开始时间</param>
        /// <param name="strdatee">结束时间</param>
        /// <returns></returns>
        public DataTable Get_CraRunRecord_Cra_Data(string strcranum, int emptyweight, string strdates, string strdatee)
        {
            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT A.WEIGHT,COUNT(*) FROM PRO_BAC.T_CRA_RUN_RECORD A LEFT JOIN PUB.T_OBJECT_INFO B ON A.T_OBJECT_INFO_ID = B.ID WHERE B.OBJ_NUM ='" + strcranum + "' AND WEIGHT > " + emptyweight + " AND A.TIME_STAMP > TO_DATE('" + strdates + "','YYYY-MM-DD HH24:MI:SS') AND A.TIME_STAMP < TO_DATE('" + strdatee + "','YYYY-MM-DD HH24:MI:SS') GROUP BY A.WEIGHT ORDER BY COUNT(*) DESC";//运行数据                

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsql);

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 更新物重信息
        /// </summary>
        /// <param name="drid"></param>
        /// <returns></returns>
        public int Set_WstWeightStatusRecord_Weight_Update(string strid, int objid, int idropweight, int ihoistweight, DateTime date)
        {
            int iArgs = 0;
            try
            {
                string strsqlUpdate1 = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS_RECORD SET CREATE_TIME=SYSDATE,FLAG=1,DROP_WEIGHT=" + idropweight + ",HOIST_WEIGHT=" + ihoistweight + " WHERE ID = '" + strid + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsqlUpdate1);

                string strdates = date.AddMinutes(-1).ToString();
                string strdatee = date.AddMinutes(1).ToString();
                int weight = 0;
                if (ihoistweight > 0)
                {
                    weight = ihoistweight;
                }
                else
                {
                    weight = idropweight;
                }
                string strsqlUpdate2 = "UPDATE PRO_BAC.T_CRA_ACTION_RECORD SET IS_CHECKED=1,CALIBRATE_WEIGHT=" + weight + " WHERE IS_CHECKED=0 AND T_OBJECT_INFO_ID = '" + objid + "' AND OPERATION_TIME BETWEEN TO_DATE('" + strdates + "','YYYY-MM-DD HH24:MI:SS') AND TO_DATE('" + strdatee + "','YYYY-MM-DD HH24:MI:SS') ";

                ArrayList list = new ArrayList();
                list.Add(strsqlUpdate1);
                list.Add(strsqlUpdate2);

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsqlUpdate2);

                iArgs = OracleDataHelper.ExecuteTransaction(list);//执行SQL语句 

                if (iArgs == 1)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息新增成功！");
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息新增失败！");
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 运行状态信息更新
        /// </summary>
        /// <param name="itype">类型</param>
        /// <param name="strid">对象ID</param>
        /// <param name="strcranum">天车编号</param>
        /// <returns></returns>
        public int Set_WstWeightStatus_CCM_Update(int itype, string strid, string strcranum)
        {
            int iArgs = 0;
            string strsql = string.Empty;
            try
            {
                switch (itype)
                {
                    case 1:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET TEMP_CRA_NUM='" + strcranum + "' WHERE ID='" + strid + "'";
                        break;
                    case 2:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET HOIST_CRA_NUM='" + strcranum + "' WHERE ID='" + strid + "'";
                        break;
                    case 3:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET HOIST_STATUS=1,HOIST_TIME=SYSDATE WHERE ID='" + strid + "'";
                        break;
                    case 4:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET TEMP_CRA_NUM='' WHERE ID='" + strid + "'";
                        break;
                    case 5:
                        strsql = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET HOIST_CRA_NUM='' WHERE ID='" + strid + "'";
                        break;
                    default:
                        break;
                }

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsql);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsql);//执行SQL语句 

                if (iArgs == 1)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息更新成功！");
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息更新失败！");
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 更新连铸钢包放吊状态
        /// </summary>
        /// <param name="drid">连铸设备ID</param>
        /// <param name="dropcranum">临时天车ID</param>
        /// <param name="dropstu">放吊标志</param>
        /// <param name="castcranum">放吊天车</param>
        /// <param name="_droptime">放吊时间</param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int Set_WstWeightStatus_Drop_Update(string drid, int dropstu, string dropcranum, string castcranum, string _droptime)
        {
            int iArgs = 0;
            string strsqlUpdate = string.Empty;
            try
            {
                if (dropstu == 1)
                {
                    strsqlUpdate = $@"UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET DROP_STATUS=1,DROP_CRA_NUM= '" + dropcranum + "',DROP_TIME=SYSDATE,CASTING_STATUS=1,CASTING_CRA_NUM='" + castcranum + "',CASTING_DROP_TIME = TO_DATE('" + _droptime + "','YYYY-MM-DD HH24:MI:SS') WHERE ID = '" + drid + "'";
                }
                else
                {
                    strsqlUpdate = $@"UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET DROP_STATUS=1,DROP_CRA_NUM= '" + dropcranum + "',DROP_TIME=SYSDATE WHERE ID = '" + drid + "'";
                }


                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsqlUpdate);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlUpdate);//执行SQL语句

                if (iArgs == 1)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息更新成功！");
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息更新失败！");
                }

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 记录天车运行状态
        /// </summary>
        /// <param name="drid">ID</param>
        /// /// <returns></returns>
        public int Set_WstWeightStatusRecord_All_Insert(string drid, int icastingstu)
        {
            int iArgs = 0;
            try
            {
                //新增状态记录
                string strsqlInsert = "INSERT INTO PRO_BAC.T_WST_WEIGHT_STATUS_RECORD SELECT  SYS_GUID() ID,ID AS T_WST_WEIGHT_STATUS_ID, T_OBJECT_INFO_ID, POSIT, DROP_STATUS, DROP_CRA_NUM, DROP_TIME, DROP_WEIGHT, HOIST_STATUS, HOIST_CRA_NUM, HOIST_TIME, HOIST_WEIGHT, POUR_STATUS, POUR_CRA_NUM, POUR_ARRIVE_TIME, BEFORE_POUR_WEIGHT, POUR_LEAVE_TIME, AFTER_POUR_WEIGHT, DISLODGE_SLAG_WEIGHT, MAX_WEIGHT, MIN_WEIGHT, IS_SEND, FLAG, CASTING_STATUS, CASTING_CRA_NUM, CASTING_DROP_TIME, TEMP_CRA_NUM, TEMP_WEIGHT, HEAT_NUM, CONT_NUM, FIELD1, FIELD2, XML_DATA, CREATE_TIME FROM PRO_BAC.T_WST_WEIGHT_STATUS WHERE ID = '" + drid + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsqlInsert);

                //更新状态记录
                string strsqlUpdate = string.Empty;
                //更新状态记录
                if (icastingstu == 1)
                {
                    strsqlUpdate = $@"UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET CASTING_STATUS=0,CASTING_CRA_NUM= '',HOIST_STATUS=0,HOIST_CRA_NUM='' WHERE ID = '" + drid + "'";
                }
                else
                {
                    strsqlUpdate = $@"UPDATE PRO_BAC.T_WST_WEIGHT_STATUS SET DROP_STATUS=0,DROP_CRA_NUM= '',HOIST_STATUS=0,HOIST_CRA_NUM='' WHERE ID = '" + drid + "'";
                }

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", strsqlUpdate);

                ArrayList arrlist = new ArrayList();
                arrlist.Add(strsqlInsert);
                arrlist.Add(strsqlUpdate);

                iArgs = OracleDataHelper.ExecuteTransaction(arrlist);//执行SQL语句

                if (iArgs > 1)
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息新增成功！");
                }
                else
                {
                    log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "物重校准数据交互业务", "运行状态信息新增失败！");
                }

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "物重校准数据交互异常", ex.Message);
            }

            return iArgs;
        }
        #endregion

        #region MES接口
        #region GetBofJobMgtService
        /// <summary>
        /// 转炉实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_BofJobMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT T.HEATPROCESSNO,T.TAPPINGSTARTTIME FROM (SELECT HEATPROCESSNO,TAPPINGSTARTTIME FROM INT_MES.GETBOFJOBMGT ORDER BY HEATPROCESSNO DESC) T WHERE ROWNUM<13";//转炉实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 转炉实时数据记录
        /// </summary>
        /// <returns></returns>
        public int Get_BofJobMgt_Count_Data(string strprocessno, string strtappingtime)
        {
            int iargs = 0;

            try
            {
                string strsql = @"SELECT HEATPROCESSNO FROM INT_MES.GETBOFJOBMGT WHERE HEATPROCESSNO='" + strprocessno + "' AND TAPPINGSTARTTIME='" + strtappingtime + "'";//转炉实时数据记录

                iargs = OracleDataHelper.ExecuteCount(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return iargs;
        }

        /// <summary>
        /// 新增转炉实时数据
        /// </summary>
        /// <param name="mgt"></param>
        /// <returns></returns>
        //public int Set_BofJobMgt_Data(GETBOFJOBMGT mgt)
        //{
        //    int iArgs = 0;
        //    try
        //    {
        //        string strvalue = string.Empty;

        //        strvalue += ",'" + mgt.HEATNO + "'";
        //        strvalue += ",'" + mgt.STATIONCODE + "'";
        //        strvalue += ",'" + mgt.HEATPROCESSNO + "'";
        //        strvalue += ",'" + mgt.UPDATETIME + "'";
        //        strvalue += ",'" + mgt.DISPOSALTIME + "'";
        //        strvalue += ",'" + mgt.CHANGESTARTTIME + "'";
        //        strvalue += ",'" + mgt.CHANGEENDTIME + "'";
        //        strvalue += ",'" + mgt.B1STARTTIME + "'";
        //        strvalue += ",'" + mgt.B1ENDTIME + "'";
        //        strvalue += ",'" + mgt.B1TIME + "'";
        //        strvalue += ",'" + mgt.B1TEMPERATURE + "'";
        //        strvalue += ",'" + mgt.B2STARTTIME + "'";
        //        strvalue += ",'" + mgt.B2ENDTIME + "'";
        //        strvalue += ",'" + mgt.B2TIME + "'";
        //        strvalue += ",'" + mgt.B2TEMPERATURE + "'";
        //        strvalue += ",'" + mgt.B3STARTTIME + "'";
        //        strvalue += ",'" + mgt.B3ENDTIME + "'";
        //        strvalue += ",'" + mgt.B3TIME + "'";
        //        strvalue += ",'" + mgt.B3TEMPERATURE + "'";
        //        strvalue += ",'" + mgt.B4STARTTIME + "'";
        //        strvalue += ",'" + mgt.B4ENDTIME + "'";
        //        strvalue += ",'" + mgt.B4TIME + "'";
        //        strvalue += ",'" + mgt.B4TEMPERATURE + "'";
        //        strvalue += ",'" + mgt.B5STARTTIME + "'";
        //        strvalue += ",'" + mgt.B5ENDTIME + "'";
        //        strvalue += ",'" + mgt.B5TIME + "'";
        //        strvalue += ",'" + mgt.B5TEMPERATURE + "'";
        //        strvalue += ",'" + mgt.TERMINUSTEPT + "'";
        //        strvalue += ",'" + mgt.TAPPINGSTARTTIME + "'";
        //        strvalue += ",'" + mgt.TAPPINGENDTIME + "'";
        //        strvalue += ",'" + mgt.IRONTEMPERATURE + "'";
        //        strvalue += ",'" + mgt.POTNO + "'";
        //        strvalue += ",'" + mgt.TAPPINGWGT + "'";
        //        strvalue = strvalue.Substring(1);
        //        strvalue = strvalue.Replace("'null'", "''");
        //        //新增状态记录
        //        string strsqlInsert = "INSERT INTO INT_MES.GETBOFJOBMGT (HEATNO, STATIONCODE, HEATPROCESSNO , UPDATETIME, DISPOSALTIME, CHANGESTARTTIME, CHANGEENDTIME, B1STARTTIME, B1ENDTIME, B1TIME, B1TEMPERATURE, B2STARTTIME, B2ENDTIME, B2TIME, B2TEMPERATURE, B3STARTTIME, B3ENDTIME, B3TIME, B3TEMPERATURE, B4STARTTIME, B4ENDTIME, B4TIME, B4TEMPERATURE, B5STARTTIME, B5ENDTIME, B5TIME, B5TEMPERATURE, TERMINUSTEPT, TAPPINGSTARTTIME, TAPPINGENDTIME, IRONTEMPERATURE, POTNO, TAPPINGWGT) VALUES (" + strvalue + ")";

        //        log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", strsqlInsert);

        //        iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句
        //    }
        //    catch (Exception ex)
        //    {
        //        log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
        //    }

        //    return iArgs;
        //}
        #endregion

        #region GetBofJobMgtNewService
        /// <summary>
        /// 转炉实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_BofJobMgtNew_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT T.* FROM (SELECT * FROM INT_MES.GETBOFJOBMGT_NEW ORDER BY HEATPROCESSNO DESC) T WHERE ROWNUM<13";//转炉实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 转炉实时数据记录
        /// </summary>
        /// <returns></returns>
        public DataTable Get_BofJobMgtNew_Count_Data(string strprocessno)
        {
            DataTable dt = new DataTable();

            try
            {
                string strsql = @"SELECT * FROM INT_MES.GETBOFJOBMGT_NEW WHERE HEATPROCESSNO='" + strprocessno + "'";//转炉实时数据记录

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 新增转炉实时数据
        /// </summary>
        /// <param name="mgt"></param>
        /// <returns></returns>
        public int Set_BofJobMgtNew_AddData(string strcolumn, string strvalue)
        {
            int iArgs = 0;
            try
            {
                strvalue = strvalue.Replace("'null'", "''");
                //新增状态记录
                string strsqlInsert = "INSERT INTO INT_MES.GETBOFJOBMGT_NEW (" + strcolumn + ") VALUES (" + strvalue + ")";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", strsqlInsert);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 修改转炉实时数据
        /// </summary>
        /// <param name="mgt"></param>
        /// <returns></returns>
        public int Set_BofJobMgtNew_UpdData(string strvalue, string strprocessno)
        {
            int iArgs = 0;
            try
            {
                //新增状态记录
                string strsqlInsert = "UPDATE INT_MES.GETBOFJOBMGT_NEW SET " + strvalue + " WHERE HEATPROCESSNO='" + strprocessno + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", strsqlInsert);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }

            return iArgs;
        }
        #endregion

        #region GetLfJobMgtService
        /// <summary>
        /// LF精炼实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_LfJobMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT T.* FROM (SELECT * FROM INT_MES.GETLFSJOBMGT ORDER BY HEATPROCESSNO DESC) T WHERE ROWNUM < 13";//LF精炼实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// LF精炼实时数据记录
        /// </summary>
        /// <returns></returns>
        public DataTable Get_LfJobMgt_Data(string strprocessno)
        {
            DataTable dt = new DataTable();

            try
            {
                string strsql = @"SELECT * FROM INT_MES.GETLFSJOBMGT WHERE HEATPROCESSNO='" + strprocessno + "'";//LF精炼实时数据记录

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 新增LF精炼实时数据
        /// </summary>
        /// <param name="strcolumn"></param>
        /// <param name="strvalues"></param>
        /// <returns></returns>
        public int Set_LfJobMgt_AddData(string strcolumn, string strvalues)
        {
            int iArgs = 0;
            try
            {
                strvalues = strvalues.Replace("'null'", "''");
                //新增状态记录
                string strsqlInsert = "INSERT INTO INT_MES.GETLFSJOBMGT (" + strcolumn + ") VALUES (" + strvalues + ")";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "LF精炼接口业务", strsqlInsert);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 更新LF精炼实时数据
        /// </summary>
        /// <param name="strvalue"></param>
        /// <param name="strprocessno"></param>
        /// <returns></returns>
        public int Set_LfJobMgt_UpdData(string strvalue, string strprocessno)
        {
            int iArgs = 0;
            try
            {

                //更新状态记录
                string strsqlUpdate = "UPDATE INT_MES.GETLFSJOBMGT SET " + strvalue + " WHERE HEATPROCESSNO='" + strprocessno + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "LF精炼接口业务", strsqlUpdate);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlUpdate);//执行SQL语句

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }

            return iArgs;
        }
        #endregion

        #region GetRhJobMgtService
        /// <summary>
        /// RH精炼实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_RhJobMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT T.* FROM (SELECT * FROM INT_MES.GETRHJOBMGT ORDER BY HEATPROCESSNO DESC) T WHERE ROWNUM < 13";//LF精炼实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "RH精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// RH精炼实时数据记录
        /// </summary>
        /// <returns></returns>
        public DataTable Get_RhJobMgt_Data(string strprocessno)
        {
            DataTable dt = new DataTable();

            try
            {
                string strsql = @"SELECT * FROM INT_MES.GETRHJOBMGT WHERE HEATPROCESSNO='" + strprocessno + "'";//LF精炼实时数据记录

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "RH精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 新增RH精炼实时数据
        /// </summary>
        /// <param name="strcolumn"></param>
        /// <param name="strvalues"></param>
        /// <returns></returns>
        public int Set_RhJobMgt_AddData(string strcolumn, string strvalues)
        {
            int iArgs = 0;
            try
            {
                strvalues = strvalues.Replace("'null'", "''");
                //新增状态记录
                string strsqlInsert = "INSERT INTO INT_MES.GETRHJOBMGT (" + strcolumn + ") VALUES (" + strvalues + ")";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "RH精炼接口业务", strsqlInsert);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "RH精炼接口业务", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 更新RH精炼实时数据
        /// </summary>
        /// <param name="strvalue"></param>
        /// <param name="strprocessno"></param>
        /// <returns></returns>
        public int Set_RhJobMgt_UpdData(string strvalue, string strprocessno)
        {
            int iArgs = 0;
            try
            {

                //更新状态记录
                string strsqlUpdate = "UPDATE INT_MES.GETRHJOBMGT SET " + strvalue + " WHERE HEATPROCESSNO='" + strprocessno + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "RH精炼接口业务", strsqlUpdate);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlUpdate);//执行SQL语句
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "RH精炼接口业务", ex.Message);
            }

            return iArgs;
        }
        #endregion

        #region GetCcmJobMgtService
        /// CCM连铸实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CCMJobMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT T.* FROM (SELECT * FROM INT_MES.GETCCMJOBMGT ORDER BY HEATPROCESSNO DESC) T WHERE ROWNUM < 13";//LF精炼实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// CCM连铸实时数据记录
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CCMJobMgt_Data(string strprocessno)
        {
            DataTable dt = new DataTable();

            try
            {
                string strsql = @"SELECT * FROM INT_MES.GETCCMJOBMGT WHERE HEATPROCESSNO='" + strprocessno + "'";//连铸实时数据记录

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 新增CCM连铸实时数据
        /// </summary>
        /// <param name="strcolumn"></param>
        /// <param name="strvalues"></param>
        /// <returns></returns>
        public int Set_CCMJobMgt_AddData(string strcolumn, string strvalues)
        {
            int iArgs = 0;
            try
            {
                strvalues = strvalues.Replace("'null'", "''");
                //新增状态记录
                string strsqlInsert = "INSERT INTO INT_MES.GETCCMJOBMGT (" + strcolumn + ") VALUES (" + strvalues + ")";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸接口业务", strsqlInsert);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 更新CCM连铸实时数据
        /// </summary>
        /// <param name="strvalue"></param>
        /// <param name="strprocessno"></param>
        /// <returns></returns>
        public int Set_CCMJobMgt_UpdData(string strvalue, string strprocessno)
        {
            int iArgs = 0;
            try
            {

                //更新状态记录
                string strsqlUpdate = "UPDATE INT_MES.GETCCMJOBMGT SET " + strvalue + " WHERE HEATPROCESSNO='" + strprocessno + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸接口业务", strsqlUpdate);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlUpdate);//执行SQL语句

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }

            return iArgs;
        }
        #endregion

        #region GetChemJobMgtService
        /// 成分数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CHEMJobMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT * FROM INT_MES.GETCHEMJOBMGT WHERE STATUS='0' ORDER BY CREATTIME DESC";//有效成分数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "成分接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 新增CHEM成分数据
        /// </summary>
        /// <param name="strcolumn"></param>
        /// <param name="strvalues"></param>
        /// <returns></returns>
        public int Set_CHEMJobMgt_AddData(string strcolumn, string strvalues)
        {
            int iArgs = 0;
            try
            {
                strvalues = strvalues.Replace("'null'", "''");
                //新增成分记录
                string strsqlInsert = "INSERT INTO INT_MES.GETCHEMJOBMGT (" + strcolumn + ") VALUES (" + strvalues + ")";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸接口业务", strsqlInsert);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 新增CHEM成分数据
        /// </summary>
        /// <param name="strcolumn"></param>
        /// <param name="strvalues"></param>
        /// <returns></returns>
        public int Set_CHEMJobMgt_AddData(string strcolumn, string strvalues, string strheatno)
        {
            int iArgs = 0;
            try
            {
                string strsqlUpdate = "UPDATE INT_MES.GETCHEMJOBMGT SET STATUS='1' WHERE HEATNO='" + strheatno + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "成分接口业务", strsqlUpdate);

                strvalues = strvalues.Replace("'null'", "''");
                //新增成分记录
                string strsqlInsert = "INSERT INTO INT_MES.GETCHEMJOBMGT (" + strcolumn + ") VALUES (" + strvalues + ")";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "成分接口业务", strsqlInsert);

                ArrayList arrlist = new ArrayList();

                arrlist.Add(strsqlUpdate);

                arrlist.Add(strsqlInsert);

                iArgs = OracleDataHelper.ExecuteTransaction(arrlist);//执行SQL语句             

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "成分接口业务", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 更新CHEM成分数据
        /// </summary>
        /// <param name="strheatno"></param>
        /// <returns></returns>
        public int Set_CHEMJobMgt_UpdData(string strheatno)
        {
            int iArgs = 0;
            try
            {
                //新增状态记录
                string strsqlInsert = "UPDATE INT_MES.GETCHEMJOBMGT SET STATUS=1 WHERE HEATNO='" + strheatno + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸接口业务", strsqlInsert);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }

            return iArgs;
        }
        #endregion

        #region GetCutPlanInfoService

        /// <summary>
        /// 坯料切割计划数据记录
        /// </summary>
        /// <returns></returns>
        public int Get_CutPlanInfo_Count_Data(string strheatno)
        {
            int iargs = 0;

            try
            {
                string strsql = @"SELECT HEATNO FROM INT_MES.GETCUTPLANINFO WHERE HEATNO='" + strheatno + "'";//成分数据记录

                iargs = OracleDataHelper.ExecuteCount(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "切割计划业务", ex.Message);
            }
            return iargs;
        }

        /// <summary>
        /// 新增坯料切割计划数据
        /// </summary>
        /// <param name="mgt"></param>
        /// <returns></returns>
        //public int Set_CutPlanInfo_Data(GETCUTPLANINFO mgt)
        //{
        //    int iArgs = 0;
        //    try
        //    {
        //        string strvalue = string.Empty;
        //        strvalue += ",'" + Guid.NewGuid().ToString("N") + "'";
        //        strvalue += ",'" + mgt.HEATNO + "'";
        //        strvalue += ",'" + mgt.LSTEELCODE + "'";
        //        strvalue += ",'" + mgt.PLANMAKETIME + "'";
        //        strvalue += ",'" + mgt.SLABHEIGHT + "'";
        //        strvalue += ",'" + mgt.SLABWIDTH + "'";
        //        strvalue += ",'" + mgt.SLABLENGTH + "'";
        //        strvalue += ",'" + mgt.THEROYWEIGHT + "'";
        //        strvalue += ",'" + mgt.BILLET_XN + "'";
        //        strvalue += ",'" + mgt.CUTTASKCODE + "'";
        //        strvalue += ",'" + mgt.FURNACENO + "'";
        //        strvalue += ",'" + mgt.SEQUENCENO + "'";

        //        strvalue = strvalue.Substring(1);
        //        strvalue = strvalue.Replace("'null'", "''");
        //        //新增状态记录
        //        string strsqlInsert = "INSERT INTO INT_MES.GETCUTPLANINFO (ID, HEATNO, LSTEELCODE, PLANMAKETIME, SLABHEIGHT, SLABWIDTH, SLABLENGTH, THEROYWEIGHT, BILLET_XN, CUTTASKCODE, FURNACENO, SEQUENCENO) VALUES (" + strvalue + ")";

        //        log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "切割计划业务", strsqlInsert);

        //        iArgs = OracleDataHelper.ExecuteNonQuery(strsqlInsert);//执行SQL语句

        //    }
        //    catch (Exception ex)
        //    {
        //        log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "切割计划业务", ex.Message);
        //    }

        //    return iArgs;
        //}
        #endregion

        #region SetBofSteelMgtService
        /// <summary>
        /// 钢水物重数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_BofSteelMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                //string strsql = @"SELECT * FROM PRO_BAC.T_WST_WEIGHT_STATUS_RECORD WHERE DROP_WEIGHT > 45000 AND DROP_WEIGHT< 60000 AND HOIST_WEIGHT >140000 AND HOIST_STATUS = 1 AND IS_SEND = 0 AND POSIT LIKE 'BOF%' ORDER BY  HOIST_TIME DESC";//转炉实时数据数据

                string strsql = @"SELECT * FROM PRO_BAC.T_WST_WEIGHT_STATUS_RECORD WHERE DROP_WEIGHT > 45000 AND DROP_WEIGHT< 60000 AND IS_SEND = 0 AND POSIT LIKE 'BOF%' ORDER BY  HOIST_TIME DESC";//转炉实时数据数据

                //log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "MES接口数据标准类", strsql);

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 炉次号数据
        /// </summary>
        /// <returns></returns>
        public string Get_BofJobMgt_HEATNO_Data(string strstation)
        {

            string strheatno = string.Empty;

            try
            {
                string strsql = @" SELECT HEATNO FROM INT_MES.GETBOFJOBMGT WHERE TAPPINGSTARTTIME = (SELECT MAX(TAPPINGSTARTTIME) FROM INT_MES.GETBOFJOBMGT WHERE STATIONCODE='" + strstation + "')";//转炉实时数据数据

                strheatno = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));//获取查询数据
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return strheatno;
        }

        /// <summary>
        /// 炉次号数据
        /// </summary>
        /// <returns></returns>
        public string Get_BofJobMgt_HEATNO_NEW_Data(string strstation)
        {

            string strheatno = string.Empty;

            try
            {
                string strsql = @" SELECT HEATNO FROM (SELECT HEATNO FROM INT_MES.GETBOFJOBMGT_NEW WHERE STATIONCODE='" + strstation + "' ORDER BY CREATTIME DESC) WHERE ROWNUM=1";//转炉实时数据                

                strheatno = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));//获取查询数据

                //log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", "查询最新炉次信息（炉号："+ strheatno + "）：" + strsql + "");

                string strsqlrecord = @" SELECT * FROM PRO_BAC.T_WST_WEIGHT_STATUS_RECORD WHERE HOIST_STATUS=1 AND HEAT_NUM = '" + strheatno + "'";//转炉记录数据

                int iargs = OracleDataHelper.ExecuteCount(strsqlrecord);//获取查询数据

                //log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", "查询炉次记录信息（记录：" + iargs + "）：" + strsqlrecord + "");

                if (iargs > 0)
                {
                    strheatno = string.Empty;
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return strheatno;
        }

        /// <summary>
        /// 更新钢水物重记录数据发送状态
        /// </summary>
        /// <param name="drid"></param>
        /// <returns></returns>
        public int Set_BofSteelWgt_ISSEND_Update(string drid, string strheatnum)
        {
            int iArgs = 0;
            try
            {
                string strsqlUpdate = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS_RECORD SET IS_SEND=1,HEAT_NUM='" + strheatnum + "' WHERE ID = '" + drid + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉精炼接口业务", strsqlUpdate);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlUpdate);//执行SQL语句 

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉精炼接口业务", ex.Message);
            }

            return iArgs;
        }

        /// <summary>
        /// 更新钢水物重记录异常数据
        /// </summary>
        /// <param name="drid"></param>
        /// <returns></returns>
        public int Set_BofSteelWgt_ISSEND_Error_Update(string drid, string strheatnum)
        {
            int iArgs = 0;
            try
            {
                string strsqlUpdate = "UPDATE PRO_BAC.T_WST_WEIGHT_STATUS_RECORD SET IS_SEND=2,HEAT_NUM='" + strheatnum + "' WHERE ID = '" + drid + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉精炼接口业务", strsqlUpdate);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsqlUpdate);//执行SQL语句 
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉精炼接口业务", ex.Message);
            }

            return iArgs;
        }
        #endregion

        #region SetTimeForLFService
        /// <summary>
        /// 获取精炼实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_TimeForLF_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID,HEAT_NUM,T_OBJECT_INFO_ID, POSIT, DROP_STATUS, DROP_CRA_NUM, DROP_TIME, DROP_WEIGHT,HOIST_STATUS, HOIST_CRA_NUM, HOIST_TIME, HOIST_WEIGHT, CREATE_TIME FROM PRO_BAC.T_WST_WEIGHT_STATUS_RECORD WHERE CREATE_TIME > TO_DATE('2019/11/13 14:18:01','YYYY-MM-DD HH24:MI:SS') AND DROP_WEIGHT >140000 AND IS_SEND = 0 AND ( POSIT LIKE 'LF%' OR POSIT LIKE 'RH%') ORDER BY  CREATE_TIME DESC";//精炼实时数据数据


                //log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "MES接口数据标准类", strsql);

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 炉次号数据
        /// </summary>
        /// <returns></returns>
        public string Get_TimeForLF_HEATNO_Data(string strcranum, string strdroptime, bool booldrop = true)
        {

            string strheatno = string.Empty;

            try
            {
                string strsql = string.Empty;
                if (booldrop)
                {
                    strsql = @" SELECT HEAT_NUM,T_OBJECT_INFO_ID, POSIT, HOIST_STATUS, HOIST_CRA_NUM, HOIST_TIME, HOIST_WEIGHT, CREATE_TIME FROM PRO_BAC.T_WST_WEIGHT_STATUS_RECORD WHERE HOIST_CRA_NUM='" + strcranum + "' AND HOIST_TIME > TO_DATE('" + strdroptime + "','YYYY-MM-DD HH24:MI:SS')-10/24/60 AND POSIT LIKE 'BOF%' AND HEAT_NUM IS NOT NULL ORDER BY  HOIST_TIME DESC";//精炼记录数据

                }
                else
                {
                    strsql = @" SELECT HEAT_NUM,T_OBJECT_INFO_ID, POSIT, DROP_STATUS, DROP_CRA_NUM, DROP_TIME, DROP_WEIGHT, CREATE_TIME FROM PRO_BAC.T_WST_WEIGHT_STATUS_RECORD WHERE DROP_CRA_NUM='" + strcranum + "' AND DROP_TIME = TO_DATE('" + strdroptime + "','YYYY-MM-DD HH24:MI:SS') AND POSIT LIKE 'LF%' AND HEAT_NUM IS NOT NULL";//精炼记录数据

                }

                strheatno = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));//获取查询数据
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }
            return strheatno;
        }
        #endregion

        #region SetIronPotConfirmService
        /// <summary>
        /// 查询转炉包号识别记录
        /// </summary>
        /// <returns></returns>
        public DataTable Get_Discern_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID, CRAMERA_NUM, DISCERN_NUM,TRACKING_NUM, CONFIRM_NUM, RECORD_TIME FROM PRO_CON.T_LADLE_DISCERN_RECORD WHERE FIELD2=0 AND CRAMERA_NUM IN ('1','2','3') AND (DISCERN_NUM LIKE 'CON%' OR CONFIRM_NUM LIKE 'CON%') ORDER BY RECORD_TIME DESC";//识别记录数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "包号发送接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 转炉设备实时状态数据
        /// </summary>
        /// <param name="strobjid"></param>
        /// <returns></returns>
        public string Get_DvcRealStatus_Data(string strobjid)
        {

            string str = string.Empty;
            try
            {
                string strsql = @"SELECT HEAT_STATUS FROM PRO_BAC.T_DVC_REAL_STATUS WHERE T_OBJECT_INFO_ID = " + strobjid + "";//转炉设备实时状态数据

                str = Convert.ToString(OracleDataHelper.ExecuteScalar(strsql));//获取查询数据
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "包号发送接口业务", ex.Message);
            }
            return str;
        }

        /// <summary>
        /// 更新包号识别发送标识
        /// </summary>
        /// <returns></returns>
        public int Set_Discern_Data(string strid, int ifield2)
        {

            int iArgs = 0;
            try
            {
                string strsql = @"UPDATE PRO_CON.T_LADLE_DISCERN_RECORD SET FIELD2=" + ifield2 + " WHERE ID='" + strid + "'";//识别记录数据

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "包号发送接口业务", "更新包号识别记录数据标识：" + strsql);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "包号发送接口业务", ex.Message);
            }
            return iArgs;
        }
        #endregion

        #region ProcessBofJobMgtService
        /// <summary>
        /// 转炉最新实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_ProcessBofJobMgtNew_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT * FROM (SELECT * FROM INT_MES.GETBOFJOBMGT_NEW WHERE STATIONCODE='01' ORDER BY CREATTIME DESC) WHERE ROWNUM<2 UNION ALL SELECT * FROM (SELECT * FROM INT_MES.GETBOFJOBMGT_NEW WHERE STATIONCODE='02' ORDER BY CREATTIME DESC) WHERE ROWNUM<2 UNION ALL SELECT * FROM (SELECT * FROM INT_MES.GETBOFJOBMGT_NEW WHERE STATIONCODE='03' ORDER BY CREATTIME DESC) WHERE ROWNUM<2";//转炉实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 转炉最新实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_DvcStatus_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID, T_OBJECT_INFO_ID, HEAT_NUM, DEAL_NUM, HEAT_STATUS, TAP_CTEMP, LADLE_NUM, TIME_STAMP FROM PRO_BAC.T_DVC_REAL_STATUS WHERE T_OBJECT_INFO_ID IN (1,2,3)";//转炉设备状态数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 转炉设备状态更新
        /// </summary>
        /// <returns></returns>
        public int Set_DvcStatus_Data(int strid, string strvalues)
        {

            int iArgs = 0;
            try
            {
                string strsql = @"UPDATE PRO_BAC.T_DVC_REAL_STATUS SET " + strvalues + " WHERE T_OBJECT_INFO_ID=" + strid + "";//转炉设备状态数据更新

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", strsql);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据    
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return iArgs;
        }

        /// <summary>
        /// 更新转炉出钢包号
        /// </summary>
        /// <returns></returns>
        public int Set_LadleNum_Data(int strid, string strladlenum)
        {

            int iArgs = 0;
            try
            {
                string strwst = string.Empty;

                switch (strid)
                {
                    case 1:
                        strwst = "BOF1_L";
                        break;
                    case 2:
                        strwst = "BOF2_L";
                        break;
                    case 3:
                        strwst = "BOF3_L";
                        break;
                    default:
                        break;
                }

                string strsqlposit = @"SELECT POSIT,CON_NUM FROM PRO_CON.T_STEEL_CON WHERE POSIT='" + strwst + "'";

                DataTable dt = OracleDataHelper.ExecuteDataTable(strsqlposit);//获取查询数据   

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string strcon_num = Convert.ToString(dr["CON_NUM"]);

                        if (!strladlenum.Equals(strcon_num))
                        {
                            log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "MES接口数据标准类", "出钢位置：" + strwst + "   出钢钢包：" + strladlenum + "   跟踪包号：" + strcon_num + "");

                            string strsqlladleUpd = @"UPDATE PRO_CON.T_STEEL_CON SET POSIT='' WHERE CON_NUM='" + strcon_num + "'";//转炉设备状态数据更新

                            log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", strsqlladleUpd);

                            int iArgsupd = OracleDataHelper.ExecuteNonQuery(strsqlladleUpd);//更新数据

                            if (iArgsupd > 0)
                            {
                                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", "跟踪钢包位置更新成功！");
                            }
                            else
                            {
                                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", "跟踪钢包位置更新失败！");
                            }
                        }
                    }
                }

                string strsqlladle = @"SELECT POSIT,CON_NUM FROM PRO_CON.T_STEEL_CON WHERE CON_NUM='" + strladlenum + "'";

                DataTable dtladle = OracleDataHelper.ExecuteDataTable(strsqlladle);//获取查询数据
                if (dtladle != null && dtladle.Rows.Count > 0)
                {
                    string strposit = Convert.ToString(dtladle.Rows[0]["POSIT"]);

                    if (!strposit.Equals(strwst))
                    {
                        string strsqlUpdate = @"UPDATE PRO_CON.T_STEEL_CON SET LOAD_SYMBOL=2,POSIT='" + strwst + "' WHERE CON_NUM='" + strladlenum + "'";//转炉设备状态数据更新

                        log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "转炉接口业务", strsqlUpdate);

                        iArgs = OracleDataHelper.ExecuteNonQuery(strsqlUpdate);//更新数据                        
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "转炉接口业务", ex.Message);
            }
            return iArgs;
        }
        #endregion

        #region ProcessLFJobMgtService
        /// <summary>
        /// 精炼实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_ProcessLFJobMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT * FROM (SELECT * FROM INT_MES.GETLFSJOBMGT WHERE STATIONCODE='01' ORDER BY CREATTIME DESC) WHERE ROWNUM<2 UNION ALL SELECT * FROM (SELECT * FROM INT_MES.GETLFSJOBMGT WHERE STATIONCODE='02' ORDER BY CREATTIME DESC) WHERE ROWNUM<2 UNION ALL SELECT * FROM (SELECT * FROM INT_MES.GETLFSJOBMGT WHERE STATIONCODE='03' ORDER BY CREATTIME DESC) WHERE ROWNUM<2";//精炼实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 精炼设备状态数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_LFDvcStatus_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID, T_OBJECT_INFO_ID, HEAT_NUM, DEAL_NUM, HEAT_STATUS, PRE_REFINE_CTEMP, TIME_STAMP FROM PRO_BAC.T_DVC_REAL_STATUS WHERE ID IN (1,2,3)";//精炼设备状态数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 精炼设备状态更新
        /// </summary>
        /// <returns></returns>
        public int Set_LFDvcStatus_Data(int strid, string strvalues)
        {

            int iArgs = 0;
            try
            {
                string strsql = @"UPDATE PRO_BAC.T_DVC_REAL_STATUS SET " + strvalues + " WHERE ID =" + strid + "";//精炼设备状态数据更新

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "LF精炼接口业务", strsql);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据    

            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "LF精炼接口业务", ex.Message);
            }
            return iArgs;
        }
        #endregion

        #region ProcessRHJobMgtService
        /// <summary>
        /// RH实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_ProcessRHJobMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT * FROM (SELECT * FROM INT_MES.GETRHJOBMGT WHERE STATIONCODE='01' ORDER BY CREATTIME DESC) WHERE ROWNUM<2 UNION ALL SELECT * FROM (SELECT * FROM INT_MES.GETRHJOBMGT WHERE STATIONCODE='02' ORDER BY CREATTIME DESC) WHERE ROWNUM<2";//RH实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "RH精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// RH设备状态数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_RHDvcStatus_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID, T_OBJECT_INFO_ID, HEAT_NUM, DEAL_NUM, HEAT_STATUS, PRE_REFINE_CTEMP, TIME_STAMP FROM PRO_BAC.T_DVC_REAL_STATUS WHERE ID IN (4)";//RH设备状态数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "RH精炼接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// RH设备状态更新
        /// </summary>
        /// <returns></returns>
        public int Set_RHDvcStatus_Data(int strid, string strvalues)
        {

            int iArgs = 0;
            try
            {
                string strsql = @"UPDATE PRO_BAC.T_DVC_REAL_STATUS SET " + strvalues + " WHERE ID =" + strid + "";//RH设备状态数据更新

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "RH精炼接口业务", strsql);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据    
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "RH精炼接口业务", ex.Message);
            }
            return iArgs;
        }
        #endregion

        #region ProcessCCMJobMgtService
        /// <summary>
        /// 连铸实时数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_ProcessCCMJobMgt_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT * FROM (SELECT * FROM INT_MES.GETCCMJOBMGT WHERE STATIONCODE='01' ORDER BY CREATTIME DESC) WHERE ROWNUM<2 UNION ALL SELECT * FROM (SELECT * FROM INT_MES.GETCCMJOBMGT WHERE STATIONCODE='02' ORDER BY CREATTIME DESC) WHERE ROWNUM<2 UNION ALL SELECT * FROM (SELECT * FROM INT_MES.GETCCMJOBMGT WHERE STATIONCODE='03' ORDER BY CREATTIME DESC) WHERE ROWNUM<2 UNION ALL SELECT * FROM (SELECT * FROM INT_MES.GETCCMJOBMGT WHERE STATIONCODE='04' ORDER BY CREATTIME DESC) WHERE ROWNUM<2";//连铸实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 连铸设备状态数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CCMDvcStatus_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT (CASE ID WHEN 12 THEN 1 WHEN 13 THEN 2 WHEN 14 THEN 3 ELSE 4 END) AS ID, T_OBJECT_INFO_ID, HEAT_NUM, DEAL_NUM, HEAT_STATUS, PRE_REFINE_CTEMP, TIME_STAMP FROM PRO_BAC.T_DVC_REAL_STATUS WHERE ID IN (12,13,14,15)";//连铸设备状态数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 连铸设备状态更新
        /// </summary>
        /// <returns></returns>
        public int Set_CCMDvcStatus_Data(int strid, string strvalues)
        {

            int iArgs = 0;
            try
            {
                int dvcid = 0;

                switch (strid)
                {
                    case 1:
                        dvcid = 12;
                        break;
                    case 2:
                        dvcid = 13;
                        break;
                    case 3:
                        dvcid = 14;
                        break;
                    case 4:
                        dvcid = 15;
                        break;
                    default:
                        break;
                }

                string strsql = @"UPDATE PRO_BAC.T_DVC_REAL_STATUS SET " + strvalues + " WHERE ID =" + dvcid + "";//连铸设备状态数据更新

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸接口业务", strsql);

                iArgs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据    
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸接口业务", ex.Message);
            }
            return iArgs;
        }
        #endregion

        #region RtdCCMInfoService
        /// <summary>
        /// 查询连铸旋转信号数据
        /// </summary>
        /// <param name="strccmno"></param>
        /// <returns></returns>
        public DataTable Get_RtdCCMInfo_Data(string strccmno)
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT * FROM PRO_BAC.T_CCM_ROTATION_SIGNAL WHERE CCM_NO='" + strccmno + "'";//连铸旋转信号数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸旋转信号业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 更新连铸旋转信号数据
        /// </summary>
        /// <param name="strccmno"></param>
        /// <returns></returns>
        public int Set_RtdCCMInfo_Data(string strccmno, string strAarm, string strBarm)
        {

            int iArgs = 0;
            try
            {
                string strsql = @"UPDATE PRO_BAC.T_CCM_ROTATION_SIGNAL SET UPDATE_TIME=SYSDATE,ARMACASTPOS='" + strAarm + "',ARMBCASTPOS='" + strBarm + "' WHERE CCM_NO='" + strccmno + "'";//连铸旋转信号数据

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "连铸旋转信号业务", "连铸旋转信号修改记录：" + strsql);//记录更新日志

                iArgs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "连铸旋转信号业务", ex.Message);
            }
            return iArgs;
        }
        #endregion
        #endregion

        #region 统计报表
        /// <summary>
        /// 炉次数据统计
        /// </summary>
        /// <returns></returns>
        public DataTable Get_HeatInfo_Data(string strheatnum)
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT T_OBJECT_INFO_ID, X_COORD, Y_COORD, WEIGHT, ACTION_SYMBOL, POSIT, HEAT_NUM,HOIST_NUM, OPERATION_TIME, ACCEPT_TIME, DEAL_TIME, CACHE_NUM FROM PRO_BAC.T_CRA_ACTION_RECORD WHERE HEAT_NUM='" + strheatnum + "' ORDER BY OPERATION_TIME";//天车动作数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "炉次数据统计业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 获取未统计的炉次号
        /// </summary>
        /// <returns></returns>
        public DataTable Get_BOFJOBMGT_HEATNUM_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT HEATNO, CREATTIME, FLAG, STATIONCODE FROM INT_MES.GETBOFJOBMGT WHERE FLAG ='0' ORDER BY  CREATTIME";//获取未统计的炉次号

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "炉次数据统计业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 获取转炉物重计算数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_BOF_WEIGHT_Data(string strheatnum)
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT DROP_CRA_NUM, DROP_TIME, DROP_WEIGHT, HOIST_CRA_NUM, HOIST_TIME, HOIST_WEIGHT,HEAT_NUM FROM PRO_BAC.T_WST_WEIGHT_STATUS_RECORD WHERE HOIST_STATUS=1 AND HEAT_NUM='" + strheatnum + "'";//获取炉次物重计算数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "炉次数据统计业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 获取热修放吊数据
        /// </summary>
        /// <param name="strposit"></param>
        /// <param name="strtime"></param>
        /// <returns></returns>
        public DataTable Get_HEATINFO_POSIT_Data(string strposit, string strtime)
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @" SELECT T_OBJECT_INFO_ID, POSIT, OPERATION_TIME FROM PRO_BAC.T_CRA_ACTION_RECORD WHERE POSIT = '" + strposit + "' AND OPERATION_TIME<TO_DATE('" + strtime + "','YYYY-MM-DD HH24:MI:SS') ORDER BY OPERATION_TIME DESC";//获取热修放吊数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "炉次数据统计业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 更新炉次标识
        /// </summary>
        /// <param name="strheatnum"></param>
        /// <returns></returns>
        public int Set_BOFJOBMGT_HEATNUM_Data(string strheatnum, string strflag)
        {
            int iargs = 0;
            try
            {
                string strsql = @"UPDATE INT_MES.GETBOFJOBMGT SET FLAG='" + strflag + "' WHERE HEATNO ='" + strheatnum + "'";//获取未统计的炉次号

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "炉次数据统计业务", "炉次数据统计：" + strsql);

                iargs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据                  
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "炉次数据统计业务", ex.Message);
            }
            return iargs;
        }

        /// <summary>
        /// 获取炉次统计数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CRA_RUN_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @" SELECT * FROM PRO_REPORTFORM.T_CRA_RUN_REPORT WHERE FLAG='0' ORDER BY CREATE_TIME DESC";//获取热修放吊数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "行车吊运时长统计业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 查询行车动作数据
        /// </summary>
        /// <param name="strheatnum"></param>
        /// <returns></returns>
        public DataTable Get_CRA_Action_Data(string strheatnum)
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @" SELECT ACTION_SYMBOL,POSIT, HEAT_NUM, OPERATION_TIME FROM PRO_BAC.V_T_CRA_ACTION_RECORD WHERE HEAT_NUM='" + strheatnum + "' ORDER BY OPERATION_TIME";//获取行车动作数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "行车吊运时长统计业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 更新炉次统计数据状态
        /// </summary>
        /// <param name="strid"></param>
        /// <returns></returns>
        public int Set_CRA_RUN_Data(string strid, string strflag)
        {
            int iargs = 0;
            try
            {
                string strsql = @"UPDATE PRO_REPORTFORM.T_CRA_RUN_REPORT SET FLAG='" + strflag + "' WHERE ID ='" + strid + "'";

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "行车吊运时长统计业务", "炉次数据统计状态更新：" + strsql);

                iargs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据                  
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "行车吊运时长统计业务", ex.Message);
            }
            return iargs;
        }
        #endregion

        #region 钢包上下线识别
        /// <summary>
        /// 台车实时数据
        /// </summary>
        /// <param name="strheatnum"></param>
        /// <returns></returns>
        public DataTable Get_Tro_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT ID, T_OBJECT_INFO_ID, X_COORD, Y_COORD FROM PRO_BAC.T_TRO_REAL_INFO WHERE ID=36";//台车实时数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "钢包上下线识别业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 识别状态数据
        /// </summary>
        /// <returns></returns>
        public DataTable Get_Discern_Flag_Data()
        {

            DataTable dt = new DataTable();
            try
            {
                string strsql = @"SELECT CRAMERA_NUM, TRACKING_FLAG FROM PRO_CON.T_LADLE_DISCERN WHERE CRAMERA_NUM='4'";//识别状态数据

                dt = OracleDataHelper.ExecuteDataTable(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "钢包上下线识别业务", ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// 更新识别状态数据
        /// </summary>
        /// <returns></returns>
        public int Set_Discern_Flag_Data()
        {

            int iargs = 0;
            try
            {
                string strsql = @"UPDATE PRO_CON.T_LADLE_DISCERN SET TRACKING_FLAG=1 WHERE CRAMERA_NUM='4'";//更新识别状态数据

                log.WriteLog(E_ProcessLogType.Info, E_LogType.Server, "钢包上下线识别业务", "更新识别状态：" + strsql);

                iargs = OracleDataHelper.ExecuteNonQuery(strsql);//获取查询数据                
            }
            catch (Exception ex)
            {
                log.WriteLog(E_ProcessLogType.Error, E_LogType.Server, "钢包上下线识别业务", ex.Message);
            }
            return iargs;
        }
        #endregion
    }
}
