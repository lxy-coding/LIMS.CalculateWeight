using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 对象处理类
    /// 作者: 周张智
    /// 日期: 2019/09/11
    /// </summary>
    public static class ObjectHandling
    {
        /// <summary>
        /// 对象属性值拷贝：值拷贝，对象属性名称类型必须一致
        /// </summary>
        /// <param name="obj">拷贝对象</param>
        /// <param name="Entity">实例化输出对象</param>
        /// <returns>object</returns>
        public static object ObjAttributeValueCopy(object obj, object Entity)
        {
            try
            {              
                System.Reflection.PropertyInfo[] Entityproperties = Entity.GetType().GetProperties();
                List<ObjAttribute> lstObjAttribute =getLstObjAttribute(obj);
                if (lstObjAttribute != null || lstObjAttribute.Count > 0)
                {
                    foreach (System.Reflection.PropertyInfo property in Entityproperties)//遍历对象属性
                    {
                        if (property.Name == "ID")
                            continue;
                        ObjAttribute objAttribute = lstObjAttribute.Where(a => a.AttributeNam == property.Name).FirstOrDefault(); //根据相同字段取值
                        if (objAttribute != null)
                        {
                            if (objAttribute.Value != null)//值不能为空
                            {
                                try
                                {
                                    property.SetValue(Entity, Convert.ChangeType(objAttribute.Value, objAttribute.AttributeType), null); //拷贝值
                                }
                                catch (Exception)
                                {
                                    try
                                    {
                                        property.SetValue(Entity, Convert.ChangeType(objAttribute.Value, Nullable.GetUnderlyingType(objAttribute.AttributeType)), null);//Nullable`1类型处理
                                    }
                                    catch (Exception )
                                    {
                                    }                                
                                }                              
                            }
                        }
                    }
                }             
                return Entity;
            }
            catch (Exception )
            {
                return null;
            }
        }

        /// <summary>
        /// 获取对象值
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        static List<ObjAttribute> getLstObjAttribute(object obj)
        {
            try
            {
                System.Reflection.PropertyInfo[] objproperties = obj.GetType().GetProperties();
                List<ObjAttribute> lstObjAttribute = new List<ObjAttribute>();
                foreach (System.Reflection.PropertyInfo property in objproperties)
                {
                    //属性赋值
                    ObjAttribute objAttribute = new ObjAttribute();
                    objAttribute.AttributeNam = property.Name;
                    objAttribute.Value = property.GetValue(obj);
                    objAttribute.AttributeType = property.PropertyType;
                    lstObjAttribute.Add(objAttribute);
                }
                return lstObjAttribute;
            }
            catch (Exception)
            {
                return null;
            }
           
        }

    }



    /// <summary>
    /// 对象属性
    /// </summary>
    class ObjAttribute
    {
        /// <summary>
        /// 属性名称
        /// </summary>
       public  string AttributeNam { get; set; }
        /// <summary>
        /// 属性值
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// 属性类型
        /// </summary>
        public Type AttributeType { get; set; }
    }
}
