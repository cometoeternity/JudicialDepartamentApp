using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using JudicialDepartamentApp.Infrastructure.Commands;
using JudicialDepartamentApp.ViewModels.Base;

namespace JudicialDepartamentApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Главное меню";
        /// <summary>
        /// Заголовок окна.
        /// </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecuted(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown(); 
        }

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);
        }
    }
}
