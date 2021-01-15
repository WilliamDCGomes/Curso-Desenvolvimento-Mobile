using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallary.XamarinForms.Animacoes.Simples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Simples : ContentPage
    {
        public bool animationEverthing = false;
        public bool animationCombination = false;
        public Simples()
        {
            InitializeComponent();
        }

        private async void BtnTranslate(object sender, EventArgs e)
        {
            await Box.TranslateTo(100, 50, 500, Easing.Linear);
            await Task.Delay(1000);
            await Box.TranslateTo(0, 0, 1000, Easing.BounceOut);
        }

        private async void BtnRotate(object sender, EventArgs e)
        {
            await Box.RotateTo(90, 1000, Easing.SpringOut);
            await Task.Delay(1000);
            await Box.RotateTo(0, 1000, Easing.CubicOut);
        }

        private async void BtnScale(object sender, EventArgs e)
        {
            await Box.ScaleTo(2, 500, Easing.CubicInOut);
            await Task.Delay(1000);
            await Box.ScaleTo(1, 1000, Easing.Linear);
        }

        private async void BtnOpacity(object sender, EventArgs e)
        {
            await Box.FadeTo(0.5, 500, Easing.Linear);
            await Task.Delay(1000);
            await Box.FadeTo(1, 1000, Easing.BounceOut);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            animationEverthing = !animationEverthing;
            while (true)
            {
                if (animationEverthing)
                {
                    everthing.Text = "Cancelar";
                }
                else
                {
                    everthing.Text = "Começar todas";
                    break;
                }
                await Box.TranslateTo(100, 50, 500, Easing.Linear);
                await Box.RotateTo(90, 1000, Easing.SpringOut);
                await Box.ScaleTo(2, 500, Easing.CubicInOut);
                await Box.FadeTo(0.5, 500, Easing.Linear);
                await Task.Delay(1000);
                await Box.FadeTo(1, 1000, Easing.BounceOut);
                await Box.ScaleTo(1, 1000, Easing.Linear);
                await Box.RotateTo(0, 1000, Easing.CubicOut);
                await Box.TranslateTo(0, 0, 1000, Easing.BounceOut);
                await Task.Delay(1000);
            }
        }

        private async void BtnAnimacaoCombinada(object sender, EventArgs e)
        {
            animationCombination = !animationCombination;
            while (true)
            {
                if (animationCombination)
                {
                    combination.Text = "Cancelar";
                }
                else
                {
                    combination.Text = "Começar combinação";
                    break;
                }
                await Task.WhenAll(
                    Box.TranslateTo(0, 150, 1500, Easing.SpringOut),
                    Box.ScaleTo(1.5, 1500, Easing.Linear),
                    Box.RotateTo(45, 1500, Easing.BounceOut)
                );
                await Task.Delay(500);
                await Task.WhenAll(
                    Box.TranslateTo(0, 0, 1500, Easing.SpringOut),
                    Box.ScaleTo(1, 1500, Easing.Linear),
                    Box.RotateTo(0, 1500, Easing.BounceOut)
                );
            }
        }
    }
}