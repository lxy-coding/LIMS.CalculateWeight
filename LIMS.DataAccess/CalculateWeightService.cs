using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIMS.DAL;
using LIMS.Model.EntityModel;

namespace LIMS.DataAccess
{
    public class CalculateWeightService
    {
        /// <summary>
        /// 静态实例
        /// </summary>
        public static CalculateWeightService Instance { get; } = new CalculateWeightService();

        /// <summary>
        /// 查询转炉属性
        /// </summary>
        /// <param name="objID"></param>
        /// <returns></returns>
        public BOF_PROPERTY GetBofProperty(int objID)
        {
            return OracleDataHelper.FirstOrDefault<BOF_PROPERTY>(s=>s.OBJ_ID==objID);
        }

        #region 容器位置信息

        /// <summary>
        /// 插入容器位置信息
        /// </summary>
        /// <param name="info"></param>
        public void InsertPos(CON_POS_INFO info)
        {
            OracleDataHelper.Add(info);
        }

        /// <summary>
        /// 删除容器位置信息
        /// </summary>
        /// <param name="info"></param>
        public void DeletePos(CON_POS_INFO info)
        {
            OracleDataHelper.Delete(info);
        }

        /// <summary>
        /// 更新容器位置信息
        /// </summary>
        /// <param name="iNFO"></param>
        public void UpdatePos(CON_POS_INFO info)
        {
            OracleDataHelper.Update(info);
        }

        /// <summary>
        /// 查询容器位置信息
        /// </summary>
        /// <param name="wst"></param>
        /// <returns></returns>
        public List<CON_POS_INFO> GetPos(string wst)
        {
            return OracleDataHelper.Query<CON_POS_INFO>(s=>s.WST_NUM==wst);
        }

        /// <summary>
        /// 获取容器位置信息
        /// </summary>
        /// <returns></returns>
        public List<CON_POS_INFO> GetPos(int x, int y, string spa)
        {
            return OracleDataHelper.Query<CON_POS_INFO>(s => s.SPA_NUM == spa && s.X_COORD != null && s.Y_COORD != null && s.X_COORD < x + 2000 &&
            s.X_COORD > x - 2000 && s.Y_COORD < y + 2000 && s.Y_COORD > y - 2000).OrderByDescending(s => s.UPDATE_TIME).ToList();
        }
        #endregion

        /// <summary>
        /// 插入记录
        /// </summary>
        /// <param name="record"></param>
        public void Insert_WST_WEIGHT_RECORD(WST_WEIGHT_RECORD record)
        {
            OracleDataHelper.AddEntity(record);
        }

        /// <summary>
        /// 更新动作记录
        /// </summary>
        /// <param name="record"></param>
        public void Update_CRANE_ACTION_RECORD_X(CRANE_ACTION_RECORD_X record)
        {
            OracleDataHelper.Update(record);
        }

        /// <summary>
        /// 查询钢包实时表
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public LADLE_REAL_INFO Get_LADLE_REAL_INFO(string pos)
        {
            return OracleDataHelper.FirstOrDefault<LADLE_REAL_INFO>(s=>s.POSIT==pos);
        }

        /// <summary>
        /// 更新钢包实时表
        /// </summary>
        /// <param name="info"></param>
        public void Update_LADLE_REAL_INFO(LADLE_REAL_INFO info)
        {
            OracleDataHelper.Update(info);
        }

        /// <summary>
        /// 查询铁包实时表
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public HML_REAL_INFO Get_HML_REAL_INFO(string pos)
        {
            return OracleDataHelper.FirstOrDefault<HML_REAL_INFO>(s => s.POSIT == pos);
        }

        /// <summary>
        /// 更新铁包实时表
        /// </summary>
        /// <param name="info"></param>
        public void Update_HML_REAL_INFO(HML_REAL_INFO info)
        {
            OracleDataHelper.Update(info);
        }

        /// <summary>
        /// 获取未处理的记录
        /// </summary>
        /// <returns></returns>
        public List<CRANE_ACTION_RECORD_X> GetCraneActionRecords()
        {
            //List<int> lstID = new List<int>() { 6,7,8,9,10,11};
            //List<int> lstID = new List<int>() { 1,2,3,4};
            //List<int> lstSymbol = new List<int>() { 1,2,3,4,6};
            return OracleDataHelper.Query<CRANE_ACTION_RECORD_X>(s => s.DEAL_SYMBOL == null || s.DEAL_SYMBOL != 2).OrderBy(s => s.OPERATION_TIME).ToList();
        }
    }
}
