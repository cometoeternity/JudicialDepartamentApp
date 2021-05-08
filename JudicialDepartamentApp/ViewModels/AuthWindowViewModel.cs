using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JudicialDepartamentApp.ViewModels.Base;

namespace JudicialDepartamentApp.ViewModels
{
    internal class AuthWindowViewModel:ViewModel
    {
        private string _Title = "Авторизация в приложении";
        public string Title { get => _Title; set => Set(ref _Title, value); }
    }
}
