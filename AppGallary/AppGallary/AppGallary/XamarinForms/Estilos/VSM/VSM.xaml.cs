using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Estilos.VSM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VSM : ContentPage
    {
        public VSM()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var view = (View)sender;
            if (e.NewTextValue.StartsWith("#"))
            {
                VisualStateManager.GoToState(view, "Valid");
            }
            else
            {
                VisualStateManager.GoToState(view, "Invalid");

            }
        }

        private void BtnAtivarDesativar(object sender, EventArgs e)
        {
            TxtHex.IsEnabled = !TxtHex.IsEnabled;
        }
    }
}