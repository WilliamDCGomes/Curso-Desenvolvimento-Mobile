using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Listas.CarrosselControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrossel : ContentPage
    {
        public Carrossel()
        {
            InitializeComponent();
            Carrossel01.ItemsSource = GetColaboradores();
        }
        private List<Colaborador> GetColaboradores()
        {
            return new List<Colaborador>()
            {
                new Colaborador() { Nome = "João Ribeiro", Cargo = "Web Designer", Descricao = "Sou WebDesigner desde 2010. Conheço CSS, HTML, Photoshop, AfterAffex, Illustrator e 3D MAX"},
                new Colaborador() { Nome = "Felipe Rodrigues", Cargo = "Programador", Descricao = "Sou Programador Java desde 2010. Trasbalhei com JSF, JSP, Java EF, HTML e CSS"},
                new Colaborador() { Nome = "Felipe Ribeiro", Cargo = "Programador Web", Descricao = "Sou Programador PHP desde 2000. Conheço PHP, FrameWorks como Laravel, Codeignite, Zend Framework"},
            };
        }
    }
    public class Colaborador
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
    }
}