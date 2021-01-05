using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            /*
            var pagina = new NavigationPage(
                new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01()
                );
            
            var pagina = new CarouselPage();
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo02());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo03());
            pagina.CurrentPage = pagina.Children[1];
            */
            MainPage = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
