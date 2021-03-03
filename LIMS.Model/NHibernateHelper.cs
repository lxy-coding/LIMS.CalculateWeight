using System;
using NHibernate.Cfg;
using NHibernate;


namespace LIMS.Model
{

    /// <summary>
    /// 加载NHibernate配置
    /// 作者：周张智
    /// 日期：2019-09-18
    /// </summary>
    public class NHibernateHelper
    {
        private ISessionFactory sessionFactory;
        static  string DBConnectStr;
        static Configuration _configuration;
        public NHibernateHelper(string _DBConnectStr)
        {
            try
            {
                DBConnectStr = _DBConnectStr;
                _configuration = configuration(DBConnectStr);
                sessionFactory = GetSessionFactory();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
                     
        }



        /// <summary>
        /// 读取配置文件
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <returns></returns>
        private NHibernate.ISessionFactory GetSessionFactory()
        {
            try
            {
                return _configuration.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException($"namespace LIMS.Model; Class NHibernateHelper; GetSessionFactory 读取配置文件;错误信息{ex.Message}。");
            }
            finally
            {

            }         
        }

        /// <summary>
        /// 创建对话
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <returns></returns>
        public NHibernate.ISession GetSession()
        {
            try
            {
                return sessionFactory.OpenSession();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException($"namespace LIMS.Model; Class NHibernateHelper; GetSession 创建对话;错误信息{ex.Message}。");
            }           
        }

        /// <summary>
        /// 配置连接
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <param name="DBConnectStr">连接字符串</param>
        /// <returns></returns>
        private Configuration configuration(string DBConnectStr)
        {
            Configuration cfg = new Configuration();
            cfg.SetProperty("connection.driver_class", "NHibernate.Driver.OracleClientDriver");
            //cfg.SetProperty("connection.connection_string", "User ID=system;Password=123456;Data Source=192.168.2.127/LIMS;");
            cfg.SetProperty("connection.connection_string", DBConnectStr);
            cfg.SetProperty("dialect", "NHibernate.Dialect.Oracle10gDialect");
            cfg.SetProperty("current_session_context_class", "wcf_operation");
            cfg.SetProperty("connection.release_mode", "after_transaction");
            cfg.SetProperty("show_sql", "false");
            cfg.AddAssembly("LIMS.Model");
            return cfg;
        }
    }

}