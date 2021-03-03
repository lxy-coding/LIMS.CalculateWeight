using Microsoft.Practices.Prism.ViewModel;
using Remotion.Linq.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 树结构
    /// </summary>
    public class Node : NotificationObject
    {
        /// <summary>
        /// 实例化
        /// </summary>
        public Node()
        {
            this.Nodes = new List<Node>();
            this.ParentID = -1;
        }
        /// <summary>
        /// 资源ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 资源名称
        /// </summary>
        public string Name { get; set; }

        private string _Url;
        /// <summary>
        /// 资源地址
        /// </summary>
        public string Url
        {
            get {
                return _Url;
            }
            set {
                _Url = value;
            }
        }
        /// <summary>
        /// 显示顺序
        /// </summary>
        public int DispIndex { get; set; }
        /// <summary>
        /// 父资源ID
        /// </summary>
        public int ParentID { get; set; }

        /// <summary>
        /// 传入参数
        /// </summary>
        public string AFFERENTPARAMETER { get; set; }
        /// <summary>
        /// 父资源
        /// </summary>
        public Node Parent { get; set; }

        private bool isSelected;
        /// <summary>
        /// 选中
        /// </summary>
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.RaisePropertyChanged("IsSelected");
            }
        }

        /// <summary>
        /// 子资源列表
        /// </summary>
        public List<Node> Nodes { get; set; }
    }
}
