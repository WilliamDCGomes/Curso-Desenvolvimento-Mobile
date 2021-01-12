using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Listas.ListaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
            Lista01.ItemsSource = GetMarcas();
        }

        private List<Marca> GetMarcas()
        {
            return new List<Marca>()
            {
                GetListaCarrosDaFiat(),
                GetListaCarrosDaFord()
            };
        }

        private Marca GetListaCarrosDaFord()
        {
            var FORD = new Marca()
            {
                new Carro {
                    Nome = "Ka",
                    Motorizacao = "1.0 - 1.3",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Ka Sedan",
                    Motorizacao = "1.0 - 1.3",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Uno.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Fusion",
                    Motorizacao = "2.0 - 2.4",
                    Descricao = "O Kit Cross transforma o seu Argo em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Ecosport",
                    Motorizacao = "1.8 - 2.0",
                    Descricao = "Agora você pode dar um toque de aventura para o  Kit Cross.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Novo Edge",
                    Motorizacao = "2.4 - 3.0",
                    Descricao = "O Kit Cross transforma o seu Toro em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
                new Carro
                {
                    Nome = "Ranger",
                    Motorizacao = "3.2",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Grand Siena. O Kit Cross transforma o seu Grand Siena em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
                new Carro
                {
                    Nome = "Mustang",
                    Motorizacao = "5.0",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Strada, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
            };
            FORD.Nome = "FORD";
            return FORD;
        }

        private Marca GetListaCarrosDaFiat()
        {
            var FIAT = new Marca()
            {
                new Carro {
                    Nome = "Mobi",
                    Motorizacao = "1.0",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica" 
                },
                new Carro
                {
                    Nome = "Uno",
                    Motorizacao = "1.0",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Uno.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Argo",
                    Motorizacao = "1.0 - 1.4",
                    Descricao = "O Kit Cross transforma o seu Argo em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Cronos",
                    Motorizacao = "1.0 - 1.4",
                    Descricao = "Agora você pode dar um toque de aventura para o  Kit Cross.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Toro",
                    Motorizacao = "1.8, 2.0, 2.4 e 2.0TD",
                    Descricao = "O Kit Cross transforma o seu Toro em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
                new Carro
                {
                    Nome = "Grand Siena",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Grand Siena. O Kit Cross transforma o seu Grand Siena em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
                new Carro
                {
                    Nome = "Strada",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Strada, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
                new Carro
                {
                    Nome = "Dublò",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Agora com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
            };
            FIAT.Nome = "FIAT";
            return FIAT;
        }

        private Marca GetListaCarrosRenault()
        {
            var RENAULT = new Marca()
            {
                new Carro {
                    Nome = "Kwid",
                    Motorizacao = "1.0",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro {
                    Nome = "Sandero",
                    Motorizacao = "1.0 - 1.6",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro {
                    Nome = "Logan",
                    Motorizacao = "1.6",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
            };
            RENAULT.Nome = "RENAULT";
            return RENAULT;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var parametro = ((MenuItem)sender).CommandParameter;
            var carro = (Carro) parametro;
            DisplayAlert("Clicou no Visualizar", $"Registro: ({carro.Nome})", "OK");
        }

        private void Lista01_Refreshing(object sender, EventArgs e)
        {
            var marcas = new List<Marca>()
            {
                GetListaCarrosRenault()
            };
            Lista01.ItemsSource = marcas;
            Lista01.IsRefreshing = false;
        }
    }
    public class Carro
    {
        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public string Descricao { get; set; }
        public string ItemsDeSerie { get; set; }
    }
    public class Marca : List<Carro>
    {
        public string Nome { get; set; }
    }
}