using LIMS.Common.Themes.Command;
using LIMS.Model.EntityModel;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.Themes
{
    /// <summary>
    /// 操作类型
    /// </summary>
    public enum e_OType
    {
        Add,
        Upate,
        Del,
        Query
    }
    /// <summary>
    /// PC端基类
    /// </summary>
    public class PcBaseEntity<T>: NotificationObject
    {
        public PcBaseEntity()
        {

        }
        /// <summary>
        /// 查询事件
        /// </summary>
        public DelegateCommand QueryCommand { get; set; }

        /// <summary>
        /// 查询事件,带参数
        /// </summary>
        public CustomCommand QueryCommands { get; set; }
        /// <summary>
        /// 数据选中事件,带参数
        /// </summary>
        public CustomCommand SelectMenuItemCommands { get; set; }
        /// <summary>
        /// 数据选中事件
        /// </summary>
        public DelegateCommand SelectMenuItemCommand { get; set; }
        /// <summary>
        /// 添加或修改事件
        /// </summary>
        public DelegateCommand AddOrUpdateOrderCommand { get; set; }
        /// <summary>
        /// 添加或修改事件,带参数
        /// </summary>
        public CustomCommand AddOrUpdateOrderCommands { get; set; }
        /// <summary>
        /// 删除事件,带参数
        /// </summary>
        public CustomCommand DelOrderCommands { get; set; }
        /// <summary>
        /// 删除事件
        /// </summary>
        public DelegateCommand DelOrderCommand { get; set; }
        /// <summary>
        /// 数据选中事件,带参数
        /// </summary>
        public CustomCommand SelectCommands { get; set; }
        /// <summary>
        /// 数据选中事件
        /// </summary>
        public DelegateCommand SelectCommand { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public static e_OType e_OType { get; set; }

        private string name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                this.RaisePropertyChanged("Name");
            }
        }

        private static  REL_USER_ROLE relUserRole;
        /// <summary>
        /// 用户信息
        /// </summary>
        public static REL_USER_ROLE RelUserRole
        {
            get { return relUserRole; }
            set
            {
                relUserRole = value;
            }
        }

        private static SHIFT_INFO _SHIFT_INFO;
        /// <summary>
        /// 班别信息
        /// </summary>
        public static SHIFT_INFO SHIFT_INFO
        {
            get { return _SHIFT_INFO; }
            set
            {
                _SHIFT_INFO = value;
            }
        }

        #region 分页
        /// <summary>
        /// 写入分页信息
        /// </summary>
        /// <param name="iCurrentPage">当前页</param>
        /// <param name="iPageSize">页面数据行</param>
        /// <param name="iTotalPage">数据行</param>
        public void SetPageInfo(int iCurrentPage, int iPageSize,int iTotalPage)
        {
            CurrentPage = iCurrentPage;
            PageSize = iPageSize;
            TotalPage = (int)Math.Ceiling((double)iTotalPage / iPageSize);
            if (Lst.Count > 0)
            {
                List<T> PageResult = Lst.Take(PageSize).ToList();
                FakeSource = new List<T>(PageResult);
            }
            else
            {
                FakeSource = null;
            }                 
        }

        private DelegateCommand _firstPageCommand;

        public DelegateCommand FirstPageCommand
        {
            get
            {
                return _firstPageCommand;
            }

            set
            {
                _firstPageCommand = value;
            }
        }

        private DelegateCommand _previousPageCommand;

        public DelegateCommand PreviousPageCommand
        {
            get
            {
                return _previousPageCommand;
            }

            set
            {
                _previousPageCommand = value;
            }
        }

        private DelegateCommand _nextPageCommand;

        public DelegateCommand NextPageCommand
        {
            get
            {
                return _nextPageCommand;
            }

            set
            {
                _nextPageCommand = value;
            }
        }

        private DelegateCommand _lastPageCommand;

        public DelegateCommand LastPageCommand
        {
            get
            {
                return _lastPageCommand;
            }

            set
            {
                _lastPageCommand = value;
            }
        }

        private int _pageSize;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                if (_pageSize != value)
                {
                    _pageSize = value;
                    RaisePropertyChanged("PageSize");
                }
            }
        }

        private int _currentPage;

        public int CurrentPage
        {
            get
            {
                return _currentPage;
            }

            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    RaisePropertyChanged("CurrentPage");
                }
            }
        }

        private int _totalPage;

        public int TotalPage
        {
            get
            {
                return _totalPage;
            }

            set
            {
                if (_totalPage != value)
                {
                    _totalPage = value;
                    RaisePropertyChanged("TotalPage");
                }
            }
        }

        List<T> _Lst;
        /// <summary>
        /// 源数据
        /// </summary>
        public List<T> Lst
        {
            get
            {
                return _Lst;
            }
            set
            {
                _Lst = value;
            }
        }

        List<T> pageResult;

        /// <summary>
        /// 分页数据
        /// </summary>
        public List<T> PageResult
        {
            get
            {
                return pageResult;
            }
            set
            {
                pageResult = value;
            }
        }

        private List<T> _fakeSoruce;

        /// <summary>
        /// 界面数据源
        /// </summary>
        public List<T> FakeSource
        {
            get
            {
                return _fakeSoruce;
            }
            set
            {
                if (_fakeSoruce != value)
                {
                    _fakeSoruce = value;
                    RaisePropertyChanged("FakeSource");
                }
            }
        }
        /// <summary>
        /// 首页
        /// </summary>
        public void FirstPageAction()
        {
            try
            {
                CurrentPage = 1;
                PageResult = Lst.Take(PageSize).ToList();
                FakeSource = new List<T>(PageResult);
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        /// <summary>
        /// 上页
        /// </summary>
        public void PreviousPageAction()
        {
            try
            {
                if (CurrentPage == 1)
                {
                    return;
                }
                if (CurrentPage == 2)
                {
                    PageResult = Lst.Take(PageSize).ToList();
                    FakeSource = new List<T>(PageResult);
                }
                else
                {
                    PageResult = Lst.Skip((CurrentPage - 2) * PageSize).Take(PageSize).ToList();
                    FakeSource = new List<T>(PageResult);
                }
                CurrentPage--;
            }
            catch (Exception)
            {
                throw;
            }         
        }
        /// <summary>
        /// 下页
        /// </summary>
        public void NextPageAction()
        {
            try
            {
                if (CurrentPage == TotalPage)
                {
                    return;
                }
                PageResult = Lst.Skip(CurrentPage * PageSize).Take(PageSize).ToList();
                FakeSource = new List<T>(PageResult);
                CurrentPage++;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        /// <summary>
        /// 末页
        /// </summary>
        public void LastPageAction()
        {
            try
            {
                CurrentPage = TotalPage;
                int skipCount = (TotalPage-1) * PageSize;
                int takeCount = Lst.Count - skipCount;
                PageResult = Lst.Skip(skipCount).Take(takeCount).ToList();
                FakeSource = new List<T>(PageResult);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }


}
