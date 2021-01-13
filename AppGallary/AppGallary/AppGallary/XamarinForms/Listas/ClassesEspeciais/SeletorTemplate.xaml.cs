using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Listas.ClassesEspeciais
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeletorTemplate : ContentPage
    {
        public SeletorTemplate()
        {
            InitializeComponent();
            Lista01.ItemsSource = GetProdutos();
        }
        private List<Produto> GetProdutos(){
            
            return new List<Produto> {
                new Produto {Nome = "Arroz", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Feijão", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Óleo", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Azeite de oliva", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Vinagre", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Açúcar", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Milho para pipoca", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Farinha de trigo", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Fermento em pó", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Aveia", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Cereais", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Amido de milho", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Farinha de mandioca", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Extrato de tomate", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Macarrão", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Queijo ralado", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Enlatados", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Conservas", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Bolachas", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Petiscos", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Pães", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Maionese", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Ketchup", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Mostarda", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Frios", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Manteiga", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Requeijão", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Geleias ou doces pastosos", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Mel", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Sal", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Temperos secos", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Especiarias", Valor = 1.0, Setor = "Mercearia"},

                new Produto {Nome = "Ovos", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Verduras", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Legumes", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Vegetais variados", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Frutas da estação", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Cebola", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Alho", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Ervas e temperos frescos", Valor = 1.0, Setor = "Feira"},

                new Produto {Nome = "Bifes", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Carne moída", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Carne de frango", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Filés de peixes", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Bacon", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Hambúrgueres", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Linguiças", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Salsichas", Valor = 1.0, Setor = "Açougue"},
            };
        }
    }
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Setor { get; set; }
    }
}