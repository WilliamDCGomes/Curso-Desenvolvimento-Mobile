using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Instagram.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : TabbedPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void refresh(object sender, EventArgs e)
        {
            //Código para atualizar a pagina
            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}