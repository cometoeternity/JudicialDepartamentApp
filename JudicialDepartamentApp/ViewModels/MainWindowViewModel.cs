﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
