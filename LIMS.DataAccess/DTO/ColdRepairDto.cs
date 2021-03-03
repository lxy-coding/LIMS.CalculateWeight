using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 冷修报表
    /// </summary>
    public class ColdRepairDto
    {
        #region LADLE_REAL_INFO

        /// <summary>
        /// 包编号
        /// </summary>
        public virtual string NUM { get; set; }

        /// <summary>
        /// 包号
        /// </summary>
        public virtual string DISPLAYNAME { get; set; }

        #endregion

        #region LADLE_DISASSEMBLE_RECORD
        /// <summary>
        /// 冷修号
        /// </summary>
        public virtual string COOL_REPAIR_NUM { get; set; }
        /// <summary>
        /// 热修号
        /// </summary>
        public virtual string HOT_REPAIR_NUM { get; set; }
        /// <summary>
        /// 钢包号
        /// </summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 钢包类型，1方坯用包，2板坯用包
        /// </summary>
        public virtual int LADLE_TYPE { get; set; }
        /// <summary>
        /// 修包类型，对象类型状态表ID
        /// </summary>
        public virtual int MAINTAIN_TYPE { get; set; }
        /// <summary>
        /// 拆包单位，钢包厂家表ID
        /// </summary>
        public virtual string DISASSEMBLE_ENTERPRISE { get; set; }
        /// <summary>
        /// 拆包班组，班组表ID
        /// </summary>
        public virtual int TEAM_ID { get; set; }
        /// <summary>
        /// 渣线残厚，0~200mm
        /// </summary>
        public virtual short? SLAG_BRICK_RMAIN { get; set; }
        /// <summary>
        /// 包身方向，对象类型状态表ID
        /// </summary>
        public virtual int? WALL_DIRECTION { get; set; }
        /// <summary>
        /// 包身层数，1~12层
        /// </summary>
        public virtual short? WALL_LAYER_COUNT { get; set; }
        /// <summary>
        /// 包身残厚，mm
        /// </summary>
        public virtual short? WALL_BRICK_REMAIN { get; set; }
        /// <summary>
        /// 包底方向，对象类型状态表ID
        /// </summary>
        public virtual int? BOTTOM_DIRECTION { get; set; }
        /// <summary>
        /// 包底层数
        /// </summary>
        public virtual short? BOTTOM_LAYER_COUNT { get; set; }
        /// <summary>
        /// 包底残厚，0~350mm
        /// </summary>
        public virtual short? BOTTOM_BRICK_REMAIN { get; set; }
        /// <summary>
        /// 左透气残厚，0~450mm
        /// </summary>
        public virtual short? LEFT_POROUS_REMAIN { get; set; }
        /// <summary>
        /// 右透气残厚，0~450mm
        /// </summary>
        public virtual short? RIGHT_POROUS_REMAIN { get; set; }
        /// <summary>
        /// 拆包区域
        /// </summary>
        public virtual short? DISASSEMBLE_SECTION { get; set; }
        /// <summary>
        /// 拆包备注
        /// </summary>
        public virtual string DISASSEMBLE_REMARK { get; set; }
        /// <summary>
        /// 拆包完成时刻
        /// </summary>
        public virtual DateTime DISASSEMBLE_TIME { get; set; }
        #endregion

        #region LADLE_ASSEMBLE_RECORD
        /// <summary>
        /// 建议包龄
        /// </summary>
        public virtual int? RECOM_LADLE_LIFE { get; set; }
        /// <summary>
        /// 建议过钢量，吨
        /// </summary>
        public virtual int? RECOM_CAPACITY { get; set; }
        /// <summary>
        /// 总包龄
        /// </summary>
        public virtual short? TOTAL_LADLE_LIFE { get; set; }
        /// <summary>
        /// 本次包龄
        /// </summary>
        public virtual short? CURRENT_LADLE_LIFE { get; set; }
        /// <summary>
        /// 总过钢量，吨
        /// </summary>
        public virtual int? TOTAL_CAPACITY { get; set; }
        /// <summary>
        /// 本次过钢量，吨
        /// </summary>
        public virtual int? CURRENT_CAPACITY { get; set; }
        /// <summary>
        /// 砌筑性质
        /// </summary>
        public virtual string ASSEMBLE_TYPE { get; set; }
        /// <summary>
        /// 砌筑材料厂家,钢包厂家表ID
        /// </summary>
        public virtual int? ASSEMBLE_MATERIAL_MANU { get; set; }
        /// <summary>
        /// 左透气砖厂家,钢包厂家表ID
        /// </summary>
        public virtual int? LEFT_POROUS_MANU { get; set; }
        /// <summary>
        /// 右透气砖厂家,钢包厂家表ID
        /// </summary>
        public virtual int? RIGHT_POROUS_MANU { get; set; }
        /// <summary>
        /// 左透气砖编号
        /// </summary>
        public virtual string LEFT_POROUS_NUM { get; set; }
        /// <summary>
        /// 右透气砖编号
        /// </summary>
        public virtual string RIGHT_POROUS_NUM { get; set; }
        /// <summary>
        /// 砌筑后包底至包口高度，mm
        /// </summary>
        public virtual int? BOTTOM_TO_TOP_HEIGHT { get; set; }
        /// <summary>
        /// 砌筑后包身上部直径，mm
        /// </summary>
        public virtual int? WALL_UPPER_DIAM { get; set; }
        /// <summary>
        /// 砌筑后包身中部直径，mm
        /// </summary>
        public virtual int? WALL_MEDIUM_DIAM { get; set; }
        /// <summary>
        /// 砌筑后包身下部直径，mm
        /// </summary>
        public virtual int? WALL_DOWN_DIAM { get; set; }
        /// <summary>
        /// 包身是否更换永久层，0否，1是
        /// </summary>
        public virtual short? WALL_PERMANENT_CHANGE { get; set; }
        /// <summary>
        /// 包底是否更换永久层，0否，1是
        /// </summary>
        public virtual short? BOTTOM_PERMANENT_CHANGE { get; set; }
        /// <summary>
        /// 包口旧砖层数
        /// </summary>
        public virtual short? EDGE_REMAIN_LAYER_COUNT { get; set; }
        /// <summary>
        /// 渣线/砌筑更换层数
        /// </summary>
        public virtual short? SLAG_CHANGE_LAYER_COUNT { get; set; }
        /// <summary>
        /// 包身/砌筑更换层数
        /// </summary>
        public virtual short? WALL_CHANGE_LAYER_COUNT { get; set; }
        /// <summary>
        /// 包底更换情况
        /// </summary>
        public virtual string BOTTOM_CHANGE_TETAILS { get; set; }
        /// <summary>
        /// 包底更换砖量，kg
        /// </summary>
        public virtual int? BOTTOM_CHANGE_BRICKS { get; set; }
        /// <summary>
        /// 包身涂抹料用量，kg
        /// </summary>
        public virtual int? WALL_COAT_COUNT { get; set; }
        /// <summary>
        /// 包底修补料用量，kg
        /// </summary>
        public virtual int? BOTTOM_REPAIR_COUNT { get; set; }
        /// <summary>
        /// 室温（包身相关），℃
        /// </summary>
        public virtual short? WALL_AMBIENT_TEMP { get; set; }
        /// <summary>
        /// 包身永久层打结厚度（包身相关），mm
        /// </summary>
        public virtual short? WALL_PERMANENT_KNOT_THICK { get; set; }
        /// <summary>
        /// 永久层打结开始时间（包身相关）
        /// </summary>
        public virtual DateTime? WALL_PERMANENT_KNOT_START { get; set; }
        /// <summary>
        /// 永久层打结结束时间（包身相关）
        /// </summary>
        public virtual DateTime? WALL_PERMANENT_KNOT_END { get; set; }
        /// <summary>
        /// 浇注料用量（包身相关），吨
        /// </summary>
        public virtual int? WALL_CAST_COUNT { get; set; }
        /// <summary>
        /// 浇注料批号（包身相关）
        /// </summary>
        public virtual string WALL_CAST_NUM { get; set; }
        /// <summary>
        /// 加水量（包身相关），kg
        /// </summary>
        public virtual int? WALL_CAST_WATER { get; set; }
        /// <summary>
        /// 松膜时间（包身相关）
        /// </summary>
        public virtual DateTime? WALL_RAP_TIME { get; set; }
        /// <summary>
        /// 脱膜时间（包身相关）
        /// </summary>
        public virtual DateTime? WALL_DEMOULD_TIME { get; set; }
        /// <summary>
        /// 永久层开始烘烤时间（包身相关）
        /// </summary>
        public virtual DateTime? WALL_PERMANENT_REHEAT_START { get; set; }
        /// <summary>
        /// 永久层结束烘烤时间（包身相关）
        /// </summary>
        public virtual DateTime? WALL_PERMANENT_REHEAT_END { get; set; }
        /// <summary>
        /// 包身永久层表面质量（包身相关），对象类型状态表ID
        /// </summary>
        public virtual int? WALL_WALL_PERM_QULITY { get; set; }
        /// <summary>
        /// 包底永久层表面裂纹（包身相关），对象类型状态表ID
        /// </summary>
        public virtual int? WALL_BOTTOM_PERM_CRACK { get; set; }
        /// <summary>
        /// 室温（包底相关）
        /// </summary>
        public virtual short? BOTTOM_AMBIENT_TEMP { get; set; }
        /// <summary>
        /// 包底永久层打结厚度（包底相关）
        /// </summary>
        public virtual short? BOTTOM_PERMANENT_KNOT_THICK { get; set; }
        /// <summary>
        /// 永久层打结开始时间（包底相关）
        /// </summary>
        public virtual DateTime? BOTTOM_PERMANENT_KNOT_START { get; set; }
        /// <summary>
        /// 永久层打结结束时间（包底相关）
        /// </summary>
        public virtual DateTime? BOTTOM_PERMANENT_KNOT_END { get; set; }
        /// <summary>
        /// 浇注料用量（包底相关），吨
        /// </summary>
        public virtual int? BOTTOM_CAST_COUNT { get; set; }
        /// <summary>
        /// 浇注料批号（包底相关）
        /// </summary>
        public virtual string BOTTOM_CAST_NUM { get; set; }
        /// <summary>
        /// 加水量（包底相关），kg
        /// </summary>
        public virtual int? BOTTOM_CAST_WATER { get; set; }
        /// <summary>
        /// 脱膜时间（包底相关）
        /// </summary>
        public virtual DateTime? BOTTOM_DEMOULD_TIME { get; set; }
        /// <summary>
        /// 永久层开始烘烤时间（包底相关）
        /// </summary>
        public virtual DateTime? BOTTOM_PERMANENT_REHEAT_START { get; set; }
        /// <summary>
        /// 永久层结束烘烤时间（包底相关）
        /// </summary>
        public virtual DateTime? BOTTOM_PERMANENT_REHEAT_END { get; set; }
        /// <summary>
        /// 包身永久层表面质量（包底相关），对象类型状态表ID
        /// </summary>
        public virtual int? BOTTOM_WALL_PERM_QULITY { get; set; }
        /// <summary>
        /// 包底永久层表面裂纹（包底相关），对象类型状态表ID
        /// </summary>
        public virtual int? BOTTOM_BOTTOM_PERM_CRACK { get; set; }
        #endregion

        #region LADLE_READY_RECORD
        /// <summary>
        /// 装包班组，班组表ID
        /// </summary>
        public virtual int TEAM_ID_Z { get; set; }
        /// <summary>
        /// 机构号
        /// </summary>
        public virtual string STRUCT_NUM { get; set; }
        /// <summary>
        /// 钢包接管时刻
        /// </summary>
        public virtual DateTime LADLE_TAKEOVER_TIME { get; set; }
        /// <summary>
        /// 钢包接管人员，人员表ID
        /// </summary>
        public virtual int TAKEOVER_USER_ID { get; set; }
        /// <summary>
        /// 钢包准备备注
        /// </summary>
        public virtual string READY_REMARK { get; set; }
        /// <summary>
        /// 装包完成时刻
        /// </summary>
        public virtual DateTime READY_TIME { get; set; }
        #endregion


    }
}
