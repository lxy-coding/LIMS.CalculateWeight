using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.IO;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using LIMS.Common.LOG;
using System.Data.SqlClient;
//using System.Data.OracleClient;
namespace LIMS.DAL
{
    /// <summary>
    /// 数据库访问通用类
    /// </summary>
    public class SQLHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static readonly string connString = ConfigurationManager.ConnectionStrings["SQLConnStr"].ToString();
        /// <summary>
        /// 日志对象
        /// </summary>
        private static SystemLog _log = new SystemLog();
        /// <summary>
        /// 执行非查询操作
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _log.WriteLog( E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"执行{sql}出现异常。"+ ex.Message, "ExecuteNonQuery");
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procedureName"></param>
        /// <returns></returns>
        public static int ExecuteNonQueryByProcedure(string procedureName,params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(procedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if(parameters!=null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"执行{procedureName}出现异常。" + ex.Message, "ExecuteNonQueryByProcedure");
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procedureName"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTableByProcedure(string procedureName, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(procedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                conn.Open();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"执行{procedureName}出现异常。" + ex.Message, "ExecuteDataTableByProcedure");
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行非查询操作(不基于事务)
        /// </summary>
        /// <param name="arrSql"></param>
        public static void ExecuteNonQuery(string[] arrSql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand( );
            cmd.Connection = conn;
            try
            {
                conn.Open();
                for (int i = 0; i < arrSql.Length; i++)
                {
                    cmd.CommandText = arrSql[i];
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"执行{arrSql[i]}出现异常。" + ex.Message, "ExecuteNonQuery");
                    }
                }               
            }
            catch (Exception ex)
            {
                _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"打开连接出现异常。" + ex.Message, "ExecuteNonQuery");
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行单个查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回查询结果</returns>
        public static object ExecuteScalar(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"执行{sql}出现异常。" + ex.Message, "ExecuteScalar");
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回DataReader</returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"执行{sql}出现异常。" + ex.Message, "ExecuteReader");
                throw ex;
            }
        }
        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"执行{sql}出现异常。" + ex.Message, "ExecuteDataSet");
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行非查询操作
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">参数</param>
        /// <returns>返回受影响行数</returns>
        public static int ExecuteNonQuery(string sql, OracleParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", $"执行{sql}出现异常。" + ex.Message, "ExecuteNonQuery");
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行非查询操作（基于事务）
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns></returns>
        public static bool ExecuteNonQueryByTran(string[] sqlList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();
                foreach (string sql in sqlList)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null) cmd.Transaction.Rollback();
                _log.WriteLog(E_ProcessLogType.Error, E_LogType.Default, "SQLHelper", ex.Message, "ExecuteNonQueryByTran");

                throw ex;
            }
            finally
            {
                if (cmd.Transaction != null) cmd.Transaction = null;
                conn.Close();
            }
        }
    }
}
