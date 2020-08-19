using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFMVVMApp.ViewModels
{
    public class RelayCommand<T> : ICommand // ICommand 인터페이스 구현
    {
        readonly Action<T> execute;
        readonly Predicate<T> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute = null) // 생성자
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute)); // 기본 생성자
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<T> execute) : this(execute, null) { } // 생성자

        public bool CanExecute(object parameter) => canExecute?.Invoke((T)parameter) ?? true;

        public void Execute(object parameter) => execute((T)parameter); // ()는 형변환 <>는 선언
    }
}
