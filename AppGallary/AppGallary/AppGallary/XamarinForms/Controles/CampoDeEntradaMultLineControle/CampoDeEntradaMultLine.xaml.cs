using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Controles.CampoDeEntradaMultLineControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoDeEntradaMultLine : ContentPage
    {
        public CampoDeEntradaMultLine()
        {
            InitializeComponent();
        }
        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            lblFocus.Text = "Campo Focado!";
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            lblUnFocus.Text = "Foco removido do campo!";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextChange.Text = e.NewTextValue + " - " + e.NewTextValue.Length;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            lblComplete.Text = "Preenchimento finalizado!";
        }
    }
}