using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    ///曾马建 2020-05-22
    /// <summary>
    /// 入库,出库,倒跨,倒垛,调运记录,Model
    /// </summary>
    public class SLAB_ALL_Model
    {     
        public string SLAB_NUM { get; set; }//板坯号
        public int CAR_ID { get; set; }//天车ID
        public string UP_SPA { get; set; }//起始跨区
        public string DOWN_SPA { get; set; }//结束跨区
        //public string UP_AREA_ID { get; set; }//起吊区域id
        public string UP_AREA { get; set; }//起吊区域名称
        //public int UP_POSITION_ID { get; set; }//起始货位ID
        public string UP_POSITION { get; set; }//起始货位名称
        public int UP_LAYER { get; set; }//起吊层
        public int UP_X { get; set; }//起吊位置坐标x
        public int UP_Y { get; set; }//起吊位置坐标y
        public int UP_Z { get; set; }//起吊位置坐标Z
        //public string DOWN_AREA_ID { get; set; }//放吊区域id
        public string DOWN_AREA { get; set; }//放吊区域名称
        //public int DOWN_POSITION_ID { get; set; }//放吊货位id
        public string DOWN_POSITION { get; set; }//放吊货位名称
        public int DOWN_LAYER { get; set; }//放吊层
        public int DOWN_X { get; set; }//放吊X
        public int DOWN_Y { get; set; }//放吊Y
        public int DOWN_Z { get; set; }//放吊Z
        public string GRADE { get; set; }//钢种
        public int WEIGHT { get; set; }//重量
        public string S_SIZE { get; set; }//规格
        public int THICK { get; set; }//厚度
        public int HCL_Status { get; set; }//是否已处理
        public string USER_NUM { get; set; }//修改用户num           
        public DateTime UP_TIME { get; set; }//起吊时间
        public DateTime DOWN_TIME { get; set; }//放吊时间


    }
}
