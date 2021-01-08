using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Controles.CaixaDeMarcacaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaixaDeMarcacao : ContentPage
    {
        public CaixaDeMarcacao()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            LblInformativo.Text = (e.Value ? "Marcado" : "Desmarcado");
        }
    }
}