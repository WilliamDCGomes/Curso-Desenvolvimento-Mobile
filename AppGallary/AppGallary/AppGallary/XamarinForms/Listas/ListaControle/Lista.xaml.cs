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
            Lista01.ItemsSource = GetListaCarros();
        }

        private IEnumerable GetListaCarros()
        {
            return new List<Carro>()
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
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Argo",
                    Motorizacao = "1.0 - 1.4",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Cronos",
                    Motorizacao = "1.0 - 1.4",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Hidráulica"
                },
                new Carro
                {
                    Nome = "Toro",
                    Motorizacao = "1.8, 2.0, 2.4 e 2.0TD",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
                new Carro
                {
                    Nome = "Grand Siena",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
                new Carro
                {
                    Nome = "Strada",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                },
                new Carro
                {
                    Nome = "Dublò",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma o seu Mobi em um autêntico debravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para o seu design único.",
                    ItemsDeSerie = "Airbags, Direção Elétrica, ArCon"
                }
            };
        }
    }
    public class Carro
    {
        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public string Descricao { get; set; }
        public string ItemsDeSerie { get; set; }
    }
}