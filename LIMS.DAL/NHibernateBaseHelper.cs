using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DAL
{
    /// <summary>
    /// NHibernate 帮助类
    /// 2020-06-18 Add by duanyongming
    /// </summary>
    public class NHibernateBaseHelper
    {
        public static readonly string NHibernateConnstr = System.Configuration.ConfigurationManager.AppSettings["NHibernateConnectionString"];

        /// <summary>
        /// 生成seesion的工厂
        /// </summary>
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var config = configuration(NHibernateConnstr);
                    try
                    {
                        _sessionFactory = config.BuildSessionFactory();
                    }
                    catch (Exception ex)
                    {
                        throw new NotImplementedException($"namespace LIMS.DAL; Class HibernateHelper; GetSession 生成session工厂;错误信息{ex.Message}。");
                    }

                }
                return _sessionFactory;
            }
        }

        /// <summary>
        /// 获取当前Session
        /// </summary>
        /// <returns></returns>
        public static ISession GetSession()
        {
            try
            {
                if (CurrentSessionContext.HasBind(SessionFactory))
                {
                    var session = SessionFactory.GetCurrentSession();
                    return session;
                }
                else
                {
                    var session = SessionFactory.OpenSession();
                    CurrentSessionContext.Bind(session);
                    return session;
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException($"namespace LIMS.DAL; Class HibernateHelper; GetSession 创建对话;错误信息{ex.Message}。");
            }
        }

        /// <summary>
        /// 配置Hibernate
        /// </summary>
        /// <param name="DBConnectStr">连接字符串</param>
        /// <returns></returns>
        private static Configuration configuration(string DBConnectStr)
        {
            Configuration cfg = new Configuration();
            cfg.SetProperty("connection.driver_class", "NHibernate.Driver.OracleClientDriver");
            cfg.SetProperty("connection.connection_string", DBConnectStr);
            cfg.SetProperty("dialect", "NHibernate.Dialect.Oracle10gDialect");
            cfg.SetProperty("current_session_context_class", "thread_static");
            cfg.SetProperty("connection.release_mode", "after_transaction");
            cfg.SetProperty("show_sql", "false");
            cfg.AddAssembly("LIMS.Model");
            return cfg;
        }
    }
}
