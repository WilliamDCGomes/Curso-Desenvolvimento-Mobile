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
        public Boolean ContinuaAtualizando = true;
        public Media()
        {
            InitializeComponent();
        }

        private void ButtonPlay(object sender, EventArgs e)
        {
            VideoControle.Play();
            ContinuaAtualizando = true;
            AtualizarVideoPosicao();
        }

        private void AtualizarVideoPosicao()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                lblPosicao.Text = VideoControle.Position.ToString(@"mm\:ss");
                return ContinuaAtualizando;
            });
        }

        private void ButtonPause(object sender, EventArgs e)
        {
            VideoControle.Pause();
            ContinuaAtualizando = false;
            AtualizarVideoPosicao();
        }

        private void ButtonStop(object sender, EventArgs e)
        {
            VideoControle.Stop();
            ContinuaAtualizando = false;
            AtualizarVideoPosicao();
        }

        private void SliderVolume(object sender, ValueChangedEventArgs e)
        {
            VideoControle.Volume = e.NewValue;
            lblVolume.Text = $"Volume({e.NewValue})";
        }

        private void VideoControle_MediaOpened(object sender, EventArgs e)
        {
            lblDuracao.Text = VideoControle.Duration.Value.ToString(@"mm\:ss");
        }
    }
}