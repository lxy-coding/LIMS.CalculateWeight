using LIMS.DataAccess;
using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight
{
    /// <summary>
    /// 位置管理类
    /// </summary>
    public class PosManager
    {
        /// <summary>
        /// 开始位置
        /// </summary>
        /// <param name="wst"></param>
        /// <param name="cra"></param>
        public CON_POS_INFO StartPos(string wst, string cra)
        {
            ValidateEndPos(wst);
            CON_POS_INFO info = new CON_POS_INFO()
            {
                WST_NUM = wst,
                UPDATE_TIME = DateTime.Now,
                ROUTE = wst,
                ROUTE_DETAIL = $"({wst},{cra},{DateTime.Now})",
                CREATE_TIME = DateTime.Now
            };
            CalculateWeightService.Instance.InsertPos(info);
            return info;
        }

        /// <summary>
        /// 结束位置
        /// </summary>
        /// <param name="wst"></param>
        public void EndPos(string wst, string cra)
        {
            ValidateEndPos(wst);
        }

        /// <summary>
        /// 更新位置
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="cra"></param>
        public CON_POS_INFO UpdatePos(string start, string end, string cra)
        {
            CON_POS_INFO info = ValidateStartPos(start);
            ValidateEndPos(end);
            if (info != null)
            {
                info.WST_NUM = end;
                info.ROUTE += $"-->{end}";
                info.ROUTE_DETAIL = $"-->({end},{cra},{DateTime.Now})";
                info.UPDATE_TIME = DateTime.Now;
                CalculateWeightService.Instance.UpdatePos(info);
            }
            else
            {
                info = new CON_POS_INFO()
                {
                    WST_NUM = end,
                    UPDATE_TIME = DateTime.Now,
                    ROUTE = end,
                    ROUTE_DETAIL = $"({end},{cra},{DateTime.Now})",
                    CREATE_TIME = DateTime.Now
                };
                CalculateWeightService.Instance.InsertPos(info);
            }
            return info;
        }

        /// <summary>
        /// 更新位置
        /// </summary>
        /// <param name="start"></param>
        /// <param name="spa"></param>
        /// <param name="xEnd"></param>
        /// <param name="yEnd"></param>
        /// <param name="cra"></param>
        /// <returns></returns>
        public CON_POS_INFO UpdatePos(string start, string spa, int xEnd, int yEnd, string cra)
        {
            CON_POS_INFO info = ValidateStartPos(start);
            ValidateEndPos(spa, xEnd, yEnd);
            if (info != null)
            {
                info.WST_NUM = null;
                info.X_COORD = xEnd;
                info.Y_COORD = yEnd;
                info.SPA_NUM = spa;
                info.ROUTE += $"-->({xEnd},{yEnd})";
                info.ROUTE_DETAIL = $"-->(({xEnd},{yEnd}),{cra},{DateTime.Now})";
                info.UPDATE_TIME = DateTime.Now;
                CalculateWeightService.Instance.UpdatePos(info);
            }
            else
            {
                info = new CON_POS_INFO()
                {
                    WST_NUM = null,
                    X_COORD = xEnd,
                    Y_COORD = yEnd,
                    SPA_NUM = spa,
                    UPDATE_TIME = DateTime.Now,
                    ROUTE = $"({xEnd},{yEnd})",
                    ROUTE_DETAIL = $"(({xEnd},{yEnd}),{cra},{DateTime.Now})",
                    CREATE_TIME = DateTime.Now
                };
                CalculateWeightService.Instance.InsertPos(info);
            }
            return info;
        }

        /// <summary>
        /// 更新位置
        /// </summary>
        /// <param name="spa"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="end"></param>
        /// <param name="cra"></param>
        /// <returns></returns>
        public CON_POS_INFO UpdatePos(string spa, int xStart, int yStart,string end, string cra)
        {
            CON_POS_INFO info = ValidateStartPos(spa, xStart, yStart);
            ValidateEndPos(end);
            if (info != null)
            {
                info.WST_NUM = end;
                info.X_COORD = null;
                info.Y_COORD = null;
                info.SPA_NUM = null;
                info.ROUTE += $"-->{end}";
                info.ROUTE_DETAIL = $"-->({end},{cra},{DateTime.Now})";
                info.UPDATE_TIME = DateTime.Now;
                CalculateWeightService.Instance.UpdatePos(info);
            }
            else
            {
                info = new CON_POS_INFO()
                {
                    WST_NUM = end,
                    X_COORD = null,
                    Y_COORD = null,
                    SPA_NUM = null,
                    UPDATE_TIME = DateTime.Now,
                    ROUTE = end,
                    ROUTE_DETAIL = $"({end},{cra},{DateTime.Now})",
                    CREATE_TIME = DateTime.Now
                };
                CalculateWeightService.Instance.InsertPos(info);
            }
            return info;
        }

        /// <summary>
        /// 更新连铸位置
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="cra"></param>
        public CON_POS_INFO UpdatePos_CCM_Drop(string start, string end, string cra)
        {
            CON_POS_INFO info = ValidateStartPos(start);
            ValidatePos(end, 1);
            if (info != null)
            {
                info.WST_NUM = end;
                info.ROUTE += $"-->{end}";
                info.ROUTE_DETAIL = $"-->({end},{cra},{DateTime.Now})";
                info.UPDATE_TIME = DateTime.Now;
                CalculateWeightService.Instance.UpdatePos(info);
            }
            else
            {
                info = new CON_POS_INFO()
                {
                    WST_NUM = end,
                    UPDATE_TIME = DateTime.Now,
                    ROUTE = end,
                    ROUTE_DETAIL = $"({end},{cra},{DateTime.Now})",
                    CREATE_TIME = DateTime.Now
                };
                CalculateWeightService.Instance.InsertPos(info);
            }
            return info;
        }

        /// <summary>
        /// 更新连铸位置
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="cra"></param>
        public CON_POS_INFO UpdatePos_CCM_Hoist(string start, string end, string cra)
        {
            CON_POS_INFO info = ValidatePos(start, 2).FirstOrDefault();
            ValidateEndPos(end);
            if (info != null)
            {
                info.WST_NUM = end;
                info.ROUTE += $"-->{end}";
                info.ROUTE_DETAIL = $"-->({end},{cra},{DateTime.Now})";
                info.UPDATE_TIME = DateTime.Now;
                CalculateWeightService.Instance.UpdatePos(info);
            }
            else
            {
                info = new CON_POS_INFO()
                {
                    WST_NUM = end,
                    UPDATE_TIME = DateTime.Now,
                    ROUTE = end,
                    ROUTE_DETAIL = $"({end},{cra},{DateTime.Now})",
                    CREATE_TIME = DateTime.Now
                };
                CalculateWeightService.Instance.InsertPos(info);
            }
            return info;
        }

        /// <summary>
        /// 删除位置
        /// </summary>
        /// <param name="info"></param>
        public void DeletePos(CON_POS_INFO info)
        {
            CalculateWeightService.Instance.DeletePos(info);
        }

        /// <summary>
        /// 校验位置
        /// </summary>
        /// <param name="wst"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<CON_POS_INFO> ValidatePos(string wst, int count)
        {
            List<CON_POS_INFO> infos = CalculateWeightService.Instance.GetPos(wst).OrderBy(s => s.UPDATE_TIME).ToList();
            if (infos.Count > count)
            {
                for (int i = 0; i < infos.Count - count; i++)
                {
                    DeletePos(infos[i]);
                }
                return infos.Skip(infos.Count - count).ToList();
            }
            return infos;
        }

        /// <summary>
        /// 校验位置
        /// </summary>
        /// <param name="spa"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<CON_POS_INFO> ValidatePos(string spa, int x, int y, int count)
        {
            List<CON_POS_INFO> infos = CalculateWeightService.Instance.GetPos(x, y, spa).OrderBy(s => s.UPDATE_TIME).ToList();
            if (infos.Count > count)
            {
                for (int i = 0; i < infos.Count - count; i++)
                {
                    DeletePos(infos[i]);
                }
                return infos.Skip(infos.Count - count).ToList();
            }
            return infos;
        }

        /// <summary>
        /// 校验起始位置
        /// </summary>
        /// <param name="startWst"></param>
        /// <returns></returns>
        public CON_POS_INFO ValidateStartPos(string startWst)
        {
            return ValidatePos(startWst, 1).FirstOrDefault();
        }

        /// <summary>
        /// 校验结束位置
        /// </summary>
        /// <param name="endWst"></param>
        public void ValidateEndPos(string endWst)
        {
            ValidatePos(endWst, 0);
        }

        /// <summary>
        /// 校验起始位置
        /// </summary>
        /// <param name="spa"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <returns></returns>
        public CON_POS_INFO ValidateStartPos(string spa, int xStart, int yStart)
        {
            return ValidatePos(spa, xStart, yStart, 1).FirstOrDefault();
        }

        /// <summary>
        /// 校验结束位置
        /// </summary>
        /// <param name="spa"></param>
        /// <param name="xEnd"></param>
        /// <param name="yEnd"></param>
        public void ValidateEndPos(string spa, int xEnd, int yEnd)
        {
            ValidatePos(spa, xEnd, yEnd, 0);
        }
    }
}
