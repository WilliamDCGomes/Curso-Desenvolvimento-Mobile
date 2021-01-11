using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Controles.MediaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Media : ContentPage
    {
        public Media()
        {
            InitializeComponent();
        }

        private void ButtonPlay(object sender, EventArgs e)
        {
            VideoControle.Play();
        }

        private void ButtonPause(object sender, EventArgs e)
        {
            VideoControle.Pause();
        }

        private void ButtonStop(object sender, EventArgs e)
        {
            VideoControle.Stop();
        }

        private void SliderVolume(object sender, ValueChangedEventArgs e)
        {
            VideoControle.Volume = e.NewValue;
            lblVolume.Text = $"Volume({e.NewValue})";
        }
    }
}