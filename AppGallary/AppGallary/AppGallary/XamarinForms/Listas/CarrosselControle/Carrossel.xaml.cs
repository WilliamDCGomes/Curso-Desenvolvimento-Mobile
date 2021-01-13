using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Colaborador> colaboradores { get; set; }
        public Carrossel()
        {
            InitializeComponent();
            colaboradores = GetColaboradores();
            Carrossel01.ItemsSource = colaboradores;
        }
        private ObservableCollection<Colaborador> GetColaboradores()
        {
            return new ObservableCollection<Colaborador>()
            {
                new Colaborador() { Nome = "João Ribeiro", Cargo = "Web Designer", Descricao = "Sou WebDesigner desde 2010. Conheço CSS, HTML, Photoshop, AfterAffex, Illustrator e 3D MAX"},
                new Colaborador() { Nome = "Felipe Rodrigues", Cargo = "Programador", Descricao = "Sou Programador Java desde 2010. Trasbalhei com JSF, JSP, Java EF, HTML e CSS"},
                new Colaborador() { Nome = "José Ribeiro", Cargo = "Programador Web", Descricao = "Sou Programador PHP desde 2000. Conheço PHP, FrameWorks como Laravel, Codeignite, Zend Framework"},
                new Colaborador() { Nome = "Maria Ribeiro", Cargo = "Programador PHP", Descricao = "Sou Programador PHP desde 2000. Conheço PHP, FrameWorks como Laravel, Codeignite, Zend Framework"},
            };
        }

        private void Carrossel01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            colaboradores.Add(new Colaborador() { Nome = "Emanoel Rodrigues", Cargo = "Web Designer", Descricao = "Sou WebDesigner desde 2010. Conheço CSS, HTML, Photoshop, AfterAffex, Illustrator e 3D MAX" });
            colaboradores.Add(new Colaborador() { Nome = "Madalena Rodrigues", Cargo = "Web Designer", Descricao = "Sou WebDesigner desde 2010. Conheço CSS, HTML, Photoshop, AfterAffex, Illustrator e 3D MAX" });
            colaboradores.Add(new Colaborador() { Nome = "Jéssica Rodrigues", Cargo = "Web Designer", Descricao = "Sou WebDesigner desde 2010. Conheço CSS, HTML, Photoshop, AfterAffex, Illustrator e 3D MAX" });
            Carrossel01.RemainingItemsThreshold = -1;
        }

        private void Carrossel01_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            lblPosition.Text = $"Posição atual: {e.CurrentPosition}\nPosição anterior: {e.PreviousPosition}";
        }

        private void Carrossel01_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            var colaborador = (Colaborador)e.CurrentItem;
            lblItem.Text = $"Nome: {colaborador.Nome}";
        }

        private void Carrossel01_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            lblScroll.Text = $"ScrollX: {e.HorizontalOffset}";
        }
    }
    public class Colaborador
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
    }
}