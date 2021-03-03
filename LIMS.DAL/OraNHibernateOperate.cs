using LIMS.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DAL
{
    /// <summary>
    /// Oracle NHibernate  操作类
    /// </summary>
    public class OraNHibernateOperate
    {
        // 定义一个静态变量来保存类的实例
        private static OraNHibernateOperate uniqueInstance;

        // 定义一个标识确保线程同步
        private static readonly object locker = new object();

        /// <summary>
        /// NHibernate  使用
        /// </summary>
        static readonly string NHibernateConnstr = ConfigurationManager.AppSettings["NHibernateConnectionString"];

        /// <summary>
        /// 创建NHibernat实例
        /// </summary>
        private static NHibernateHelper nhibernateHelper = new NHibernateHelper(NHibernateConnstr);

        ///// <summary>
        /////  定义私有构造函数，使外界不能创建该类实例
        ///// </summary>
        private OraNHibernateOperate()
        {

        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static OraNHibernateOperate GetInstance()
        {
            // 如果类的实例不存在则创建，否则直接返回
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new OraNHibernateOperate();
                    }
                }
            }
            return uniqueInstance;
        }

        #region NHibernate
        #region Session管理
        /// <summary>
        /// 获取Session
        ///  作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <returns></returns>
        static ISession GetSession()
        {
            return nhibernateHelper.GetSession();
        }

        /// <summary>
        /// 关闭Session
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <param name="session"></param>
        static void CloseSession(ISession session)
        {
            try
            {
                if (session != null && session.IsOpen)
                {
                    session.Close();
                }
                session = null;
            }
            catch (HibernateException ex)
            {
                throw new Exception("Fail to open session", ex);
            }
        }
        #endregion

        /// <summary>
        /// 添加
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <param name="entity">对象</param>
        /// <returns></returns>
        public  int Add(object entity)
        {
            ISession Session = null;
            try
            {
                Session = GetSession();
                if (Session != null && Session.IsOpen)
                {
                    var aa = Session.Save(entity);
                    //冲洗会话
                    Session.Flush();
                    Session.Clear();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Operation failed", ex);
            }
            finally
            {
                CloseSession(Session);
            }
        }

        /// <summary>
        /// 修改
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <param name="entity">对象</param>
        /// <returns></returns>
        public  int Update(object entity)
        {
            ISession Session = null;
            try
            {
                Session = GetSession();
                if (Session.IsOpen)
                {
                    Session.Update(entity);
                    //冲洗会话
                    Session.Flush();
                    Session.Clear();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Operation failed", ex);
            }
            finally
            {
                CloseSession(Session);
            }
        }

        /// <summary>
        /// 删除
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <param name="entity">对象</param>
        /// <returns></returns>
        public  int Delete(object entity)
        {
            ISession Session = null;
            try
            {
                Session = GetSession();
                if (Session.IsOpen)
                {
                    Session.Delete(entity);
                    //冲洗会话
                    Session.Flush();
                    Session.Clear();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Operation failed", ex);
            }
            finally
            {
                CloseSession(Session);
            }
        }

        /// <summary>
        /// 查询方法【SQL】
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <param name="str">SQL语句</param>
        /// <returns></returns>
        public  ISQLQuery CreateSQLQuery(string str)
        {
            ISession Session = null;
            try
            {
                Session = GetSession();
                if (Session.IsOpen)
                {
                    return Session.CreateSQLQuery(str);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Operation failed", ex);
            }
            finally
            { CloseSession(Session); }
        }

        /// <summary>
        /// 查询方法【实体】
        /// 作者：周张智
        /// 日期：2019-09-18
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <returns></returns>
        public  IList<T> QueryOver<T>() where T : class
        {

            ISession Session = null;
            try
            {
                Session = GetSession();
                if (Session.IsOpen)
                {
                    var res = Session.QueryOver<T>().List<T>();
                    Session.Clear();
                    return res;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Operation failed", ex);
            }
            finally
            { CloseSession(Session); }
        }
        #endregion
    }
}
