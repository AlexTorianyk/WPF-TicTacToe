using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SManager.Commands
{
    public class RelayCommand : ICommand
    {
        public Action<object> ExecuteMethod { get; set; }
        public Func<object, bool> CanExecuteMethod { get; set; }

        public RelayCommand(Action<Object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            //if the executeMethod is null, throw new exception
            ExecuteMethod = executeMethod ?? throw new ArgumentNullException("execute");
            CanExecuteMethod = canExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteMethod(parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteMethod(parameter ?? "N/A");
        }
    }
}