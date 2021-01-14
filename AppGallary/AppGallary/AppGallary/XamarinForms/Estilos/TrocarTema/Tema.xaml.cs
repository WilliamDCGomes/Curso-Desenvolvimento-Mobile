using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Estilos.TrocarTema
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tema : ContentPage
    {
        private bool ThemeLight = false;
        public Tema()
        {
            InitializeComponent();
        }

        private void BtnAlterarTema(object sender, EventArgs e)
        {
            if (!ThemeLight)
            {
                App.Current.Resources = new LightTheme();
                //Resources = new LightTheme();
            }
            else
            {
                App.Current.Resources = new DarkTheme();
                //Resources = new DarkTheme();
            }
            ThemeLight = !ThemeLight;
        }
    }
}