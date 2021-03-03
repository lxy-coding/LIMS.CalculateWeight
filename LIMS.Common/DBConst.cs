using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common
{
    public class DBConst
    {
        /// <summary> 
        /// 区域表
        /// </summary>
        public sealed class T_HouseLayout
        {
            /// <summary>
            /// 未知位置
            /// </summary>
            public sealed class POSITION
            {
                public const int NO = 0;
            }
            /// <summary>
            /// 区域类型
            /// </summary>
            public sealed class HL_Type
            {
                /// <summary>
                /// 跨区
                /// </summary>
                public const int Cross = 0;
                /// <summary>
                /// 板坯存储区
                /// </summary>
                public const int Storage1 = 1;
                /// <summary>
                /// 板坯下线区
                /// </summary>
                public const int Offline1 = 2;
                /// <summary>
                /// 板坯过跨区
                /// </summary>
                public const int CrossTrain1 = 3;
                /// <summary>
                /// 板坯汽车区
                /// </summary>
                public const int Car1 = 4;
                /// <summary>
                /// 板坯切割区
                /// </summary>
                public const int Cut1 = 5;
                /// <summary>
                /// 方坯存储区
                /// </summary>
                public const int Storage2 = 6;
                /// <summary>
                /// 方坯下线区
                /// </summary>
                public const int Offline2 = 7;
                /// <summary>
                /// 方坯过跨区
                /// </summary>
                public const int CrossTrain2 = 8;
                /// <summary>
                /// 方坯汽车区
                /// </summary>
                public const int Car2 = 9;
                /// <summary>
                /// 方坯切割区
                /// </summary>
                public const int Cut2 = 10;

            }
            /// <summary>
            /// 区域交通方向
            /// </summary>
            public sealed class HL_Direction
            {
                /// <summary>
                /// X方向 1
                /// </summary>
                public const int XDirectoin = 1;
                /// <summary>
                /// Y方向 2
                /// </summary>
                public const int YDirection = 2;
            }
        }
        public sealed class T_HousePoint
        {
            /// <summary>
            /// 是否启用
            /// </summary>
            public sealed class ENABLE
            {
                public const int YES = 1;
                public const int NO = 0;
            }
            /// <summary>
            /// 未知位置
            /// </summary>
            public sealed class POSITION
            {
                public const int NO = 0;
            }
            /// <summary>
            /// 层数为0
            /// </summary>
            public sealed class LAYER
            {
                public const int NO = 0;
            }
            /// <summary>
            /// 是否显示
            /// </summary>
            public sealed class IS_DISPLAY
            {
                public const int YES = 1;
                public const int NO = 0;
            }
        }
                /// <summary>
                /// 模块表
                /// </summary>
                public sealed class T_Module
        {
            /// <summary>
            /// 是否可见
            /// </summary>
            public sealed class VISIBLE
            {
                /// <summary>
                /// 不可见 0
                /// </summary>
                public const int Invisible = 0;
                /// <summary>
                /// 可见 1
                /// </summary>
                public const int Visible = 1;
            }
        }
        /// <summary>
        ///用户表
        /// </summary>
        public sealed class T_Operator
        {
            /// <summary>
            /// 标志位
            /// </summary>
            public sealed class Flag
            {
                /// <summary>
                /// 禁用 0
                /// </summary>
                public const int Disable = 0;
                /// <summary>
                /// 启用 1
                /// </summary>
                public const int Enable = 1;
            }
            /// <summary>
            /// 工作状态
            /// </summary>
            public sealed class Job
            {
                /// <summary>
                /// 离职 0
                /// </summary>
                public const int Disable = 0;
                /// <summary>
                /// 在职 1
                /// </summary>
                public const int Enable = 1;
            }

            /// <summary>
            /// 用户帐号
            /// </summary>
            public sealed class UserNUM
            {
                /// <summary>
                /// 板柸服务的用户编号
                /// </summary>
                public const string SlabService = "Slab_Service";
            }
        }
        /// <summary>
        ///系统操作日志
        /// </summary>
        public sealed class T_SysLog
        {
            /// <summary>
            /// 操作端
            /// </summary>
            public sealed class SL_Client
            {
                /// <summary>
                /// WEB端 1
                /// </summary>
                public const int Web = 1;
                /// <summary>
                /// PDA端 2
                /// </summary>
                public const int Pda = 2;
            }
        }
        /// <summary>
        ///天车表
        /// </summary>
        public sealed class T_HouseCrane
        {
            /// <summary>
            /// 状态
            /// </summary>
            public sealed class HCR_Status
            {
                /// <summary>
                /// 启用 1
                /// </summary>
                public const int Enable = 1;
                /// <summary>
                /// 不启用 2
                /// </summary>
                public const int Disable = 0;
            }
            /// <summary>
            /// 天车是否在线
            /// </summary>
            public sealed class HCR_IsLine
            {
                /// <summary>
                /// 在线 1
                /// </summary>
                public const int Online = 1;
                /// <summary>
                /// 不在线 0
                /// </summary>
                public const int Offline = 0;
            }
        }
        /// <summary>
        ///坯料表
        /// </summary>
        public sealed class T_Steel
        {
            /// <summary>
            /// 坯料类型
            /// </summary>
            public sealed class S_Type
            {
                /// <summary>
                /// 未知 0
                /// </summary>
                public const int Unknown = 0;
                /// <summary>
                /// 已知 1
                /// </summary>
                public const int Known = 1;
            }
            /// <summary>
            /// 坯料状态
            /// </summary>
            public sealed class S_Status
            {
                /// <summary>
                /// 出库 0
                /// </summary>
                public const int Outbound = 0;
                /// <summary>
                /// 待确认出库状态 1
                /// </summary>
                public const int PendingConfirmOut = 1;
                /// <summary>
                /// 待核查 2
                /// </summary>
                public const int PendingConfirm = 2;
                /// <summary>
                /// 在库房 3
                /// </summary>
                public const int InWarehouse = 3;
            }

            /// <summary>
            /// 坯料所在层
            /// </summary>
            public sealed class S_Layer
            {
                /// <summary>
                /// 第一层 1
                /// </summary>
                public const int One = 1;
                /// <summary>
                /// 第二层 2
                /// </summary>
                public const int Two = 2;
            }
            /// <summary>
            /// 第几部分
            /// </summary>
            public sealed class S_Part
            {
                /// <summary>
                /// 左边 1
                /// </summary>
                public const int Left = 1;
                /// <summary>
                /// 中间 2
                /// </summary>
                public const int Center = 2;
                /// <summary>
                /// 右边 3
                /// </summary>
                public const int Right = 3;
            }
        }
        /// <summary>
        ///入库计划表
        /// </summary>
        public sealed class T_InStorage
        {
            /// <summary>
            /// 入库类型
            /// </summary>
            public sealed class IS_Type
            {
                /// <summary>
                /// 生产下线 1
                /// </summary>
                public const int ProductionLine = 1;
                /// <summary>
                /// 车辆入库 2
                /// </summary>
                public const int VehicleStorage = 2;
                /// <summary>
                /// 直接入库 3
                /// </summary>
                public const int DirectStorage = 3;
                /// <summary>
                /// 过跨入库 4
                /// </summary>
                public const int CrossingStorage = 4;
            }

            /// <summary>
            /// 计划状态
            /// </summary>
            public sealed class IS_Status
            {
                /// <summary>
                /// 计划未发布 0
                /// </summary>
                public const int NotReleased = 0;
                /// <summary>
                /// 计划未执行 1
                /// </summary>
                public const int Unexecuted = 1;
                /// <summary>
                /// 计划已执行 2
                /// </summary>
                public const int Executed = 2;
                /// <summary>
                /// 确认，核查后变更 3
                /// </summary>
                public const int HasConfirmed = 3;
                /// <summary>
                /// 计划执行中 9
                /// </summary>
                public const int Executing = 9;
            }
        }
        /// <summary>
        ///出库计划表
        /// </summary>
        public sealed class T_Outbound
        {
            /// <summary>
            /// 出库类型
            /// </summary>
            public sealed class O_Type
            {
                /// <summary>
                /// 上线出库 1
                /// </summary>
                public const int GoOnline = 1;
                /// <summary>
                /// 车辆出库 2
                /// </summary>
                public const int Vehicle = 2;
                /// <summary>
                /// 直接出库 3
                /// </summary>
                public const int DirectlyOut = 3;
                /// <summary>
                /// 过跨出库 4
                /// </summary>
                public const int CrossingOut = 4;
            }

            /// <summary>
            /// 计划状态
            /// </summary>
            public sealed class O_OutStatus
            {
                /// <summary>
                /// 计划未发布 0
                /// </summary>
                public const int NotReleased = 0;
                /// <summary>
                /// 计划未执行 1
                /// </summary>
                public const int Unexecuted = 1;
                /// <summary>
                /// 计划执行中 9
                /// </summary>
                public const int ImplementationIn = 9;
                /// <summary>
                /// 计划已执行 2
                /// </summary>
                public const int Executed = 2;
                /// <summary>
                /// 第三方确认 3
                /// </summary>
                public const int HasConfirmed = 3;
            }
        }
        /// <summary>
        ///核库记录表
        /// </summary>
        public sealed class T_CheckSteel
        {
            /// <summary>
            /// 操作端
            /// </summary>
            public sealed class CS_Type
            {
                /// <summary>
                /// 增加 1
                /// </summary>
                public const int Increase = 1;
                /// <summary>
                /// 修改 2
                /// </summary>
                public const int Modify = 2;
                /// <summary>
                /// 删除 3
                /// </summary>
                public const int Delete = 3;
                /// <summary>
                /// 出库确认 4
                /// </summary>
                public const int Confirm = 4;
                /// <summary>
                /// 删除计划 5
                /// </summary>
                public const int DeletePlan = 5;
                /// <summary>
                /// 倒跺 6
                /// </summary>
                public const int InvertedStamp = 6;
            }
            
            }
        /// <summary>
        ///倒垛计划表
        /// </summary>
        public sealed class T_MoveSteel
        {
            /// <summary>
            /// 计划状态
            /// </summary>
            public sealed class MS_Status
            {
                /// <summary>
                /// 计划未发布 0
                /// </summary>
                public const int NotReleased = 0;
                /// <summary>
                /// 计划未执行 1
                /// </summary>
                public const int Unexecuted = 1;
                /// <summary>
                /// 计划已执行 2
                /// </summary>
                public const int Executed = 2;
            }
        }
        /// <summary>
        ///倒跨计划表
        /// </summary>
        public sealed class T_ChangeCross
        {
            /// <summary>
            /// 计划状态
            /// </summary>
            public sealed class CC_Status
            {
                /// <summary>
                /// 计划未发布 0
                /// </summary>
                public const int NotReleased = 0;
                /// <summary>
                /// 计划未执行 1
                /// </summary>
                public const int Unexecuted = 1;
                /// <summary>
                /// 计划执行中 9
                /// </summary>
                public const int Executeding = 9;
                /// <summary>
                /// 计划已执行 2
                /// </summary>
                public const int Executed = 2;
            }
        }
        /// <summary>
        ///吊运记录表
        /// </summary>
        public sealed class T_HouseCraneLog
        {
            /// <summary>
            /// 是否已处理
            /// </summary>
            public sealed class HCL_Status
            {
                /// <summary>
                /// 未处理 0
                /// </summary>
                public const int UnConfirm = 0;
                /// <summary>
                /// 已处理 1
                /// </summary>
                public const int Confirmed = 1;
            }
            /// <summary>
            /// 类型
            /// </summary>
            public sealed class HCL_Type
            {
                /// <summary>
                /// 入库 1
                /// </summary>
                public const int Storage = 1;
                /// <summary>
                /// 出库 2
                /// </summary>
                public const int Outbound = 2;
                /// <summary>
                /// 倒垛 4
                /// </summary>
                public const int InvertedStamp = 4;
                /// <summary>
                /// 倒跨 3
                /// </summary>
                public const int MoveToCross = 3;
                /// <summary>
                /// 未知 0
                /// </summary>
                public const int UnKnown = 0;
            }
        }

        /// <summary>
        ///作业计划表
        /// </summary>
        public sealed class T_Plan
        {
            /// <summary>
            /// 计划类型
            /// </summary>
            public sealed class P_Type
            {
                /// <summary>
                /// 入库 1
                /// </summary>
                public const int Storage = 1;
                /// <summary>
                /// 出库 2
                /// </summary>
                public const int Outbound = 2;
                /// <summary>
                /// 倒垛 4
                /// </summary>
                public const int InvertedStamp = 4;
                /// <summary>
                /// 倒跨 3
                /// </summary>
                public const int MoveToCross = 3;
            }
            /// <summary>
            /// 计划来源
            /// </summary>
            public sealed class P_Source
            {
                /// <summary>
                /// 接口 1
                /// </summary>
                public const int Interface = 1;
                /// <summary>
                /// WEB端 2
                /// </summary>
                public const int WEB = 2;
                /// <summary>
                /// PDA端 3
                /// </summary>
                public const int PDA = 3;
                /// <summary>
                /// 其他 4
                /// </summary>
                public const int Other = 4;
            }
            /// <summary>
            /// 读取标志
            /// </summary>

            public sealed class ACCESSFLAG
            {
                /// <summary>
                /// 已读
                /// </summary>
                public const int Read = 1;
                /// <summary>
                /// 未读
                /// </summary>
                public const int UnRead = 0;
            }
        }
        /// <summary>
        ///入库反馈表
        /// </summary>
        public sealed class TX_In
        {
            /// <summary>
            /// 操作类型
            /// </summary>
            public sealed class DoType
            {
                /// <summary>
                /// 车辆入库 1
                /// </summary>
                public const int VehicleStorage = 1;
                /// <summary>
                /// 生产下线 2
                /// </summary>
                public const int ProductionLine = 2;
                /// <summary>
                /// 直接入库 3
                /// </summary>
                public const int DirectStorage = 3;
                /// <summary>
                /// 过跨入库 3
                /// </summary>
                public const int CrossStorage = 4;
            }
            /// <summary>
            /// 读取标志
            /// </summary>

            public sealed class ACCESSFLAG
            {
                /// <summary>
                /// 已读
                /// </summary>
                public const int Read = 1;
                /// <summary>
                /// 未读
                /// </summary>
                public const int UnRead = 0;
            }
        }
        /// <summary>
        ///出库反馈表
        /// </summary>
        public sealed class TX_Out
        {
            /// <summary>
            /// 操作类型
            /// </summary>
            public sealed class DoType
            {
                /// <summary>
                /// 车辆出库 1
                /// </summary>
                public const int Vehicle = 1;
                /// <summary>
                /// 生产上线 2
                /// </summary>
                public const int GoOnline = 2;
                /// <summary>
                /// 直接出库 3
                /// </summary>
                public const int DirectlyOut = 3;
            }
            /// <summary>
            /// 读取标志
            /// </summary>
            public sealed class ACCESSFLAG
            {
                /// <summary>
                /// 已读
                /// </summary>
                public const int Read = 1;
                /// <summary>
                /// 未读
                /// </summary>
                public const int UnRead = 0;
            }
        }
        /// <summary>
        /// 倒垛反馈表
        /// </summary>
        public sealed class TX_Move
        {
            /// <summary>
            /// 读取标志
            /// </summary>
            public sealed class ACCESSFLAG
            {
                /// <summary>
                /// 已读
                /// </summary>
                public const int Read = 1;
                /// <summary>
                /// 未读
                /// </summary>
                public const int UnRead = 0;
            }
        }
        /// <summary>
        /// 倒跨反馈表
        /// </summary>
        public sealed class TX_Change
        {
            /// <summary>
            /// 读取标志
            /// </summary>
            public sealed class ACCESSFLAG
            {
                /// <summary>
                /// 已读
                /// </summary>
                public const int Read = 1;
                /// <summary>
                /// 未读
                /// </summary>
                public const int UnRead = 0;
            }
        }

        /// <summary>
        /// 吊钩类型
        /// </summary>
        public sealed class T_Hook
        {
            /// <summary>
            /// 门型钩
            /// </summary>
            public const int hkMengXingGou = 30;
            /// <summary>
            /// C型钩
            /// </summary>
            public const int hkCXingGou = 31;
            /// <summary>
            /// 钢丝绳
            /// </summary>
            public const int hkGangSiSheng = 32;
            /// <summary>
            /// 其它
            /// </summary>
            public const int hkOther = 33;
        }
        /// <summary>
        /// 车辆状态
        /// </summary>
        public sealed class T_Car
        {
            public sealed class CAR_STUS
            {
                /// <summary>
                /// 已出库
                /// </summary>
                public const int OUT = 0;
                /// <summary>
                /// 在库
                /// </summary>
                public const int IN = 1;
            }
            /// <summary>
            /// 车辆状态
            /// </summary>
            public sealed class VEH_STATUS
            {
                /// <summary>
                /// 出库
                /// </summary>
                public const int OUT = 2;
                /// <summary>
                /// 入库
                /// </summary>
                public const int IN = 1;
            }
            /// <summary>
            /// 载物类型
            /// </summary>
            public sealed class LOAD_TYPE
            {
                /// <summary>
                /// 板坯
                /// </summary>
                public const int SLAB = 1;
                /// <summary>
                /// 方坯
                /// </summary>
                public const int Billet = 2;
                /// <summary>
                /// 钢卷
                /// </summary>
                public const int Steel = 3;
                /// <summary>
                /// 线卷
                /// </summary>
                public const int Coil = 4;
                /// <summary>
                /// 棒材
                /// </summary>
                public const int Bar = 5;
                /// <summary>
                /// 其他
                /// </summary>
                public const int OTHER = 9;
            }
        }

        /// <summary>
        /// 工作状态
        /// </summary>
        public sealed class HCR_WorkStatus
        {
            /// <summary>
            /// 启用
            /// </summary>
            public const int InUse = 10;
            /// <summary>
            /// 停用
            /// </summary>
            public const int Stop = 11;
            /// <summary>
            /// 临时工作
            /// </summary>
            public const int Temporary = 12;
        }
        /// <summary>
        /// 天车Z轴方向
        /// </summary>
        public sealed class HCR_Direction
        {
            /// <summary>
            /// 左右
            /// </summary>
            public const int about = 1;
            /// <summary>
            /// 前后
            /// </summary>
            public const int after = 2;

        }
        /// <summary>
        /// 天车起放吊模式
        /// </summary>
        public sealed class HCR_LiftType
        {
            /// <summary>
            /// 自动
            /// </summary>
            public const int Auto = 20;
            /// <summary>
            /// 手动
            /// </summary>
            public const int Manual = 21;
        }
        /// <summary>
        /// 手动起放吊信号
        /// </summary>
        public sealed class ManualSignal
        {
            /// <summary>
            /// 手动起吊
            /// </summary>
            public const int Up = 210;
            /// <summary>
            /// 手动放吊
            /// </summary>
            public const int Down = 211;
        }

        /// <summary>
        /// 板坯方坯种类定义
        /// </summary>
        public enum Steel
        {
            /// <summary>
            /// 所有坯料
            /// </summary>
            All,
            /// <summary>
            /// 正常坯料
            /// </summary>
            Legal,
            /// <summary>
            /// 待核查坯料
            /// </summary>
            PendingConfirm,
            /// <summary>
            /// 异常坯料
            /// </summary>
            Abnormal,
            /// <summary>
            /// 虚拟坯料
            /// </summary>
            Virtual,
            /// <summary>
            /// 出库待确认坯
            /// </summary>
            OutPendingConfirm
        }
        /// <summary>
        /// 公用参数
        /// </summary>
        public sealed class PUB
        {
            public sealed class Cross
            {
                public const int Billing = 11;
            }
            public sealed class Workshop
            {
                public const int Billet = 2;
               // 炼钢车间
                public const int SteelShop = 1;
            }

            

            public sealed class Crane
            {
                /// <summary>
                /// 废钢天车
                /// </summary>
                public const int ScrapCrane = 1;
                /// <summary>
                /// 铁水天车
                /// </summary>
                public const int MoltenIronCrane = 2;
                /// <summary>
                /// 钢包天车
                /// </summary>
                public const int LadleCrane = 3;
                /// <summary>
                /// 坯库天车
                /// </summary>
                public const int BilletCrane = 4;
            }
            /// <summary>
            /// 是否启用
            /// </summary>
            public sealed class ENABLE
            {
                public const int NO = 0;
                public const int YES = 1;
            }
            /// <summary>
            /// 是否显示
            /// </summary>
            public sealed class IS_DISPLAY
            {
                public const int NO = 0;
                public const int YES = 1;
            }
            public sealed class OBJECTTYPE
            {
                /// <summary>
                /// 天车
                /// </summary>
                public const int CRANE = 1;
                /// <summary>
                /// 过跨台车
                /// </summary>
                public const int TRO = 2;
                /// <summary>
                /// 货位
                /// </summary>
                public const int CARGO_LOACTION = 28;
                /// <summary>
                /// 辊道
                /// </summary>
                public const int ROLLER = 29;
                /// <summary>
                /// 冷床
                /// </summary>
                public const int COOLING_BED = 30;
                /// <summary>
                /// 保温坑
                /// </summary>
                public const int KEEP_WARM = 34;
                /// <summary>
                /// 废品区
                /// </summary>
                public const int WASTE = 35;
                /// <summary>
                /// 切割区
                /// </summary>
                public const int CUT = 36;
                /// <summary>
                /// 汽车区
                /// </summary>
                public const int BILLET_CAR_AREA = 40;
                /// <summary>
                /// 过跨车起放吊区域
                /// </summary>
                public const int TRO_HANG_AREA = 41;
                /// <summary>
                /// 辊道起放吊区域
                /// </summary>
                public const int ROLLER_HANG_AREA = 42;
                /// <summary>
                /// 移钢机
                /// </summary>
                public const int MOVE_MACHINE = 43;



                //废钢区
                public const int STEEL_SCRAP = 38;



                //废钢斗
                public const int STEEL_DOU_NUM= 16;

                //转炉
                public const int SteelShop_Converter = 6;

                //铁包
                public const int IronNum = 17;

                //钢包
                public const int steel_ladle = 18;

                //精炼跨
                public const int  REFINE_SPA = 40;


                //钢水接受跨
                public const int STEEL_RECEIVE_SPA = 41;


            }

        }



//废钢斗

        public sealed class T_SteelShop_DOUNUM
        {
            /// <summary>
            /// 是否启用
            /// </summary>
            public sealed class IS_DISPLAY
            {
                public const int YES = 1;
                public const int NO = 0;
            }
         
        }


        //转炉

        public sealed class T_SteelShop_Converter
        {
            /// <summary>
            /// 是否启用
            /// </summary>
            public sealed class IS_DISPLAY
            {
                public const int YES = 1;
                public const int NO = 0;
            }
      

        }

        //炼钢天车

        public sealed class SteelMAKING_CRANE
        {
            /// <summary>
            /// 类型
            /// </summary>
            public sealed class TYPE
            {
                //废钢
                public const int steel_scrap= 31;
                //铁水
                public const int ladle = 32;

                //钢包
                public const int refine_crane = 33;
            }

        }



    }
}
