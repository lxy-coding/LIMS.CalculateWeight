using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using LIMS.DAL;

/********************* Copyright （c）*************************
** 湖南物联千盟
********************* File info*******************************
** Create by ： 周张智
** Create Date： 2019-10-10
** Version： 1.0
** Descriptions： 通用数据查询
********************* File info*******************************
** Modify by ：
** Modify Date： 
** Version： 
** Descriptions： 
*************************************************************/
namespace LIMS.DataAccess
{
    /// <summary>
    /// 通用数据查询
    /// 作者：周张智
    /// 日期：2019-10-10
    /// </summary>
    public sealed class GeneralDataQuery
    {
        /// <summary>
        /// DataTool单例
        /// </summary>
        private static GeneralDataQuery _instance = new GeneralDataQuery();

        /// <summary>
        /// 获得静态实例
        /// </summary>
        /// <returns></returns>
        public static GeneralDataQuery GetInstance()
        {
            return _instance;
        }
        /// <summary>
        /// 工位比对方法
        /// 作者：周张智
        /// 日期：2019-10-10
        /// </summary>
        /// <param name="objId">天车对象ID</param>
        /// <param name="x">X地址</param>
        /// <param name="y">Y地址</param>
        /// <returns></returns>
        public DataTable WstComparison(int objId, int x, int y, int area_id)
        {
            try
            {
                OracleParameter[] parameter = {
                                             new OracleParameter("obj_id",OracleDbType.Int32),
                                             new OracleParameter("x",OracleDbType.Int32),
                                              new OracleParameter("y",OracleDbType.Int32),
                                              new OracleParameter("area_id",OracleDbType.Int32),
                                               new OracleParameter("l_result",OracleDbType.RefCursor)
                                         };
                parameter[0].Value = objId;
                parameter[1].Value = x;
                parameter[2].Value = y;
                parameter[3].Value = area_id;
                parameter[4].Direction = ParameterDirection.Output;
                return OracleDataHelper.QueryProcedure("PRO_BAC.P_GETWSTNUM", parameter);
            }
            catch (Exception)
            {
                return null;
            }
        }



        /// <summary>
        /// 杂物处理
        /// 作者：周张智
        /// 日期：2019-10-11
        /// </summary>
        /// <param name="objId">对象</param>
        /// <param name="weight">重量</param>
        /// <returns></returns>
        public int MiscellaneousDisposal(int objId, int weight)
        {
            try
            {
                OracleParameter[] parameter = {
                                             new OracleParameter("obj_id",OracleDbType.Int32),
                                             new OracleParameter("weight",OracleDbType.Int32),
                                               new OracleParameter("l_result",OracleDbType.RefCursor)
                                         };
                parameter[0].Value = objId;
                parameter[1].Value = weight;
                parameter[2].Direction = ParameterDirection.Output;
                DataTable dt = OracleDataHelper.QueryProcedure("PRO_BAC.p_miscellaneousdisposal", parameter);
                if (dt != null || dt.Rows.Count > 0)
                {
                    return int.Parse(dt.Rows[0]["count"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
