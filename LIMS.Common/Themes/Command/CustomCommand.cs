using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LIMS.Common.Themes.Command
{
    public class CustomCommand : ICommand
    {
        public CustomCommand()
        {

        }
        public CustomCommand(Action<object> executeAction)
        {
            ExecuteAction = executeAction;
        }
        public CustomCommand(Action<object> executeAction, Func<object, bool> canExecuteFunc)
        {
            ExecuteAction = executeAction;
            CanExecuteFunc = canExecuteFunc;
        }
        /// <summary>
        /// 触发可执行条件变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCanExecuteChanged(object sender,EventArgs e)
        {
            CanExecuteChanged?.Invoke(sender,e);
        }
        /// <summary>
        /// 可执行状态变化事件
        /// </summary>
        public event EventHandler CanExecuteChanged;
        /// <summary>
        /// 执行动作
        /// </summary>
        public Action<object> ExecuteAction { get; set; }
        /// <summary>
        /// 可执行条件
        /// </summary>
        public Func<object, bool> CanExecuteFunc { get; set; }
        /// <summary>
        /// 判断可执行条件
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return CanExecuteFunc==null?true:CanExecuteFunc.Invoke(parameter);
        }
        /// <summary>
        /// 执行动作
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            ExecuteAction?.Invoke(parameter);
        }
    }
}
