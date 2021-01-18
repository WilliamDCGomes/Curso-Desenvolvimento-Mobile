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
            MenuColecao.ItemsSource = App.PaginaColecao;
        }

        private void Recarregar(object sender, EventArgs e)
        {
            MenuColecao.ItemsSource = App.PaginaColecao;
        }
    }
}