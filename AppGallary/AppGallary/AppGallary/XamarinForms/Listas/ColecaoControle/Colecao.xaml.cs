using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Listas.ColecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Colecao : ContentPage
    {
        public Colecao()
        {
            InitializeComponent();
            //Colecao01.ItemsSource = new List<FastFood>();
            Colecao01.ItemsSource = GetCategorias();
        }
        private List<Categorias> GetCategorias()
        {
            var categorias = new List<Categorias>();
            var sanduiches = new Categorias()
            {
                 new FastFood {Nome = "SubWay", QuantidadeDeFranquias = 44834},
                 new FastFood {Nome = "McDonald's", QuantidadeDeFranquias = 37000},
                 new FastFood {Nome = "Burger King", QuantidadeDeFranquias = 15000},
                 new FastFood {Nome = "Girafas", QuantidadeDeFranquias = 5000},
            };
            sanduiches.Nome = "Sanduíches";

            var pizzarias = new Categorias()
            {
                 new FastFood {Nome = "Pizza Hut", QuantidadeDeFranquias = 15000},
                 new FastFood {Nome = "Domino's", QuantidadeDeFranquias = 15000},
            };
            pizzarias.Nome = "Pizzarias";

            var variedades = new Categorias()
            {
                 new FastFood {Nome = "Starbucks", QuantidadeDeFranquias = 27000},
                 new FastFood {Nome = "KFC", QuantidadeDeFranquias = 19000},
                 new FastFood {Nome = "Basking-Robbins", QuantidadeDeFranquias = 7500},
                 new FastFood {Nome = "Taco Bell", QuantidadeDeFranquias = 7000},
            };
            variedades.Nome = "Variedades";

            categorias.Add(sanduiches);
            categorias.Add(pizzarias);
            categorias.Add(variedades);
            return categorias;
        }
    }
    public class FastFood
    {
        public string Nome { get; set; }
        public int QuantidadeDeFranquias { get; set; }
    }
    public class Categorias : List<FastFood>
    {
        public string Nome { get; set; }
    }
}