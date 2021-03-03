using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 倒跨类
    /// </summary>
    public class PLANSPA
    {
        public string SLAB_NUM { get; set; }//板坯
        public string UserName { get;  set; }
        public string HC_ID { get; set; }//起始跨
        public string HL_ID { get; set; }//起始区域
        public string HP_ID { get; set; }//起始货位

        public string S_CARD { get; set; }//板坯
        public string HC_NAME { get; set; }
        public string HL_NAME { get; set; }//起始跨
        public string HP_NAME { get; set; }//起始区域
        public string S_KIND { get; set; }//起始货位
        public string S_WGT { get; set; }//起始货位
        public string S_SIZE { get; set; }//起始货位

        public int? LAYER { get; set; }//起始层次
        public int? STACRA { get; set; }//起始天车
        public int? ENDHC_ID { get; set; }//结束跨
        public int? ENDHL_ID { get; set; }//结束区域
        public int? ENDHP_ID { get; set; }//结束货位
        public int? ENDCRA { get; set; }//目标天车

    }
}
