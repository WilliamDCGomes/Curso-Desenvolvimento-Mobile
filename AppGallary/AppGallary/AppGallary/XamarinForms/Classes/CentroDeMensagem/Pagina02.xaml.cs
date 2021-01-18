using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Classes.CentroDeMensagem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina02 : ContentPage
    {
        public Pagina02()
        {
            InitializeComponent();
        }

        private void BtnSalvar(object sender, EventArgs e)
        {
            var nome = txtName.Text;
            var pessoa = new Pessoa() { Nome = nome };
            MessagingCenter.Send<Pagina02, Pessoa>(this, "CadastroPessoa", pessoa);
        }
    }
}