using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 炉次执行信息
    /// </summary>
    [Serializable]
    public class HEAT_EXECUTE_INFO: INotifyPropertyChanged
    {
        /// <summary>
        /// 属性变化事件
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 触发属性变化事件
        /// </summary>
        /// <param name="propertyName"></param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 序号，外键，转炉属性表ID
        /// <summary>
        public virtual int? BOF_ID { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 工艺路径
        /// <summary>
        public virtual string HEAT_ROUTE { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 钢种
        /// <summary>
        public virtual string STEEL_GRADE { get; set; }
        private int? _HEAT_STATUS;
        /// <summary>
        /// 对象状态表ID
        /// <summary>
        public virtual int? HEAT_STATUS
        {
            get { return _HEAT_STATUS; }
            set
            {
                _HEAT_STATUS = value;
                OnPropertyChanged("HEAT_STATUS");
            }
        }
        private short? _STATE;
        /// <summary>
        /// 状态：1待用，2生产，3结束
        /// <summary>
        public virtual short? STATE
        {
            get { return _STATE; }
            set
            {
                _STATE = value;
                OnPropertyChanged("STATE");
            }
        }
        /// <summary>
        /// 记录生成时间
        /// <summary>
        public virtual DateTime? TIME_TAMP { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
