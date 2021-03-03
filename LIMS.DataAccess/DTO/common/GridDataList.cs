using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /********************* Copyright （c）*************************
** 湖南物联千盟
********************* File info*******************************
** Create by ： 邓目云
** Create Date：2020-5-18
** Version： v1.0
** Descriptions： WEB前端返回数据通用类 **********************************/


    /// <summary>
    /// WEB前端返回数据通用类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GridDataList<T>
    {
        public int code { get; set; }
        public string msg { get; set; }
        public int count { get; set; }
        public List<T> data { get; set; }
    }
}
