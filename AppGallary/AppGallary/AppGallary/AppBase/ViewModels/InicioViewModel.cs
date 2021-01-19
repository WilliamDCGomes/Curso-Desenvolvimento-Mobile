using AppGallary.AppBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGallary.AppBase.ViewModels
{
    public class InicioViewModel
    {
        public List<PaginaColecao> PageList { get; set; }

        public InicioViewModel()
        {
            PageList = App.MenuItensColecao;
        }
    }
}
