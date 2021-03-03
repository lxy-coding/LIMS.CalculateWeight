using LIMS.DAL;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess
{
    /// <summary>
    /// NHibernate 工具类（为了代码简洁，这些工具类方法不使用try..catch,由调用方去使用try..catch即可。）
    /// 2020-06-18 Add by duanyongming
    /// </summary>
    public class NHibernateBaseUtil
    {
        /// <summary>
        /// 获取NHibernate Session
        /// </summary>
        /// <returns></returns>
        public static ISession GetSession()
        {
            return NHibernateBaseHelper.GetSession(); 
        }

        #region 实体操作
        /// <summary>
        /// 新增对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static object SaveEntity<T>(T entity)
        {
            if (entity == null) return null;
            ISession session = GetSession();
            object newId = session.Save(entity);
            // 刷新缓存，同步数据至数据库
            session.Flush(); 
            return newId;
        }

        /// <summary>
        /// 新增和更新对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public static void SaveOrUpdateEntity<T>(T entity)
        {
            if (entity != null)
            {
                ISession session = GetSession();
                session.SaveOrUpdate(entity);
                // 刷新缓存，同步数据至数据库
                session.Flush();
            }
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public static void UpdateEntity<T>(T entity)
        {
            if (entity != null)
            {
                ISession session = GetSession();
                session.Update(entity);
                session.Flush();
            }
           
        }

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public static void DeleteEntity<T>(T entity)
        {
            if (entity != null)
            {
                ISession session = GetSession();
                session.Delete(entity);
                session.Flush();
            }
                
        }

        #endregion

        #region HQL操作（HQL是面向对象的，需区别于SQL操作）

        /// <summary>
        /// 执行HQL语句
        /// </summary>
        /// <param name="strHql">HQL语句</param>
        /// <param name="values"></param>
        public static int ExecuteHql(string strHql, params object[] values)
        {
            ISession session = GetSession();
            var query = session.CreateQuery(strHql);
            if(values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    query.SetParameter(i, values[i]);
                }
            }
            return query.ExecuteUpdate();
        }

        /// <summary>
        /// 根据HQL获取实体list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strHql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IList<T> GetListByHql<T>(string strHql, params object[] values)
        {
            ISession session = GetSession();
            var query = session.CreateQuery(strHql);
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    query.SetParameter(i, values[i]);
                }
            }
           return query.List<T>();
        }

        #endregion

        #region SQL操作

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <param name="values"></param>
        public static int ExecuteSql(string strSql, params object[] values)
        {
            ISession session = GetSession();
            var query = session.CreateSQLQuery(strSql);
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    query.SetParameter(i, values[i]);
                }
            }
            return query.ExecuteUpdate();
        }

        /// <summary>
        /// 根据SQL获取实体list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strSql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IList<T> GetListBySql<T>(string strSql, params object[] values)
        {
            ISession session = GetSession();
            var query = session.CreateSQLQuery(strSql);
            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    query.SetParameter(i, values[i]);
                }
            }
            return query.List<T>();
        }

        #endregion

    }
}
