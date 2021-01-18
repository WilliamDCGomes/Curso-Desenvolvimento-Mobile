using System;
using System.Collections.Generic;
using System.Text;

namespace AppGallary.AppBase.Models
{
    public class PaginaColecao : List<Pagina>
    {
        public string Nome { get; set; }
    }
}
