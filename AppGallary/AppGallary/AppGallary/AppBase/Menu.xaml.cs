using AppGallary.AppBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirPagina(object sender, EventArgs e)
        {
            TappedEventArgs eventArgs = (TappedEventArgs)e;
            Pagina parametro = (Pagina)eventArgs.Parameter;
            Page pagina = null;
            if (parametro.TemNavegacao)
            {
                pagina = new NavigationPage(
                    (Page)Activator.CreateInstance(parametro.ArquivoPagina)
                );
            }
            else
            {
                pagina = (Page)Activator.CreateInstance(parametro.ArquivoPagina);
            }
            Detail = pagina;
            IsPresented = false;
        }
    }
}