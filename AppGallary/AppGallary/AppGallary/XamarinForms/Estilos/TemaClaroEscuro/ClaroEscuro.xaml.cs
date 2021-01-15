using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Estilos.TemaClaroEscuro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClaroEscuro : ContentPage
    {
        public ClaroEscuro()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {/*
            if (Application.Current.RequestedTheme == OSAppTheme.Light)
            {*/
                StackLayoutProperty.BackgroundColor = corFundo;
                label1.TextColor = corTexto;
                label2.TextColor = corTexto;
                label3.TextColor = corTexto;
                label4.TextColor = corTexto;
                label2.Text = lblTituloEn;
                label3.Text = lblTituloPt;
                frameSetting.BackgroundColor = frameFundo;
                frameSetting.BorderColor = frameBorda;
           /* }
            else
            {

            }*/
        }
    }
}