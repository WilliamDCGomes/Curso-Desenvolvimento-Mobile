using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Controles.NavegadorControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navegador : ContentPage
    {
        public Navegador()
        {
            InitializeComponent();
            var webViewHtmlSource = new HtmlWebViewSource();
            webViewHtmlSource.Html =
                @"<html>
                    <body>
                        <h1>Sou uma página</h1>
                        <h2>dentro do WebView</h2>
                        <p>
                            Este é um teste do nosso WebView renderizando HTML e <span style='color: red; text-decoration: underline; font-weight: bold;'>CSS</span>.
                        </p>
                    </body>
                </html>";
            WebView2.Source = webViewHtmlSource;
        }
    }
}