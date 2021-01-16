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
                    var colorTo = Color.FromHex("#FF0000");
                    everthing.BackgroundColor = colorTo;
                }
                else
                {
                    everthing.Text = "Começar todas";
                    var colorTo = Color.FromHex("#00FF00");
                    everthing.BackgroundColor = colorTo;
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
                    var colorTo = Color.FromHex("#FF0000");
                    combination.BackgroundColor = colorTo;
                }
                else
                {
                    combination.Text = "Começar combinação";
                    var colorTo = Color.FromHex("#00FF00");
                    combination.BackgroundColor = colorTo;
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

        private async void AnimacaoPersonalizada(object sender, EventArgs e)
        {
            var animacao = new Animation(v=>Box.CornerRadius = v, 5, 100, Easing.Linear);
            animacao.Commit(Box, "CornerAnimation", 500, 1000, Easing.Linear, null, () => true);
            await Task.Delay(3000);
            animacao = new Animation(v=>Box.CornerRadius = v, 100, 5, Easing.Linear);
            animacao.Commit(Box, "CornerAnimation", 500, 1000, Easing.Linear, null, () => true);
            await Task.Delay(3000);
        }

        private async void BtnColor(object sender, EventArgs e)
        {
            var colorTo = Color.FromHex(TextColor.Text);
            await Box.ColorTo(Box.BackgroundColor, colorTo, p=> Box.BackgroundColor = p, 5000, Easing.Linear);
        }

        private void BtnCancel(object sender, EventArgs e)
        {
            Box.AbortAnimation("ColorTo");
            //ViewExtensions.CancelAnimation(Box);
        }
    }
    public static class ViewExtensions
    {
        public static Task<bool> ColorTo(this VisualElement self, Color fromColor, Color toColor, Action<Color> callback, uint length = 250, Easing easing = null)
        {
            Func<double, Color> transform = (t) =>
              Color.FromRgba(fromColor.R + t * (toColor.R - fromColor.R),
                             fromColor.G + t * (toColor.G - fromColor.G),
                             fromColor.B + t * (toColor.B - fromColor.B),
                             fromColor.A + t * (toColor.A - fromColor.A));
            return ColorAnimation(self, "ColorTo", transform, callback, length, easing);
        }

        public static void CancelAnimation(this VisualElement self)
        {
            self.AbortAnimation("ColorTo");
        }

        static Task<bool> ColorAnimation(VisualElement element, string name, Func<double, Color> transform, Action<Color> callback, uint length, Easing easing)
        {
            easing = easing ?? Easing.Linear;
            var taskCompletionSource = new TaskCompletionSource<bool>();

            element.Animate<Color>(name, transform, callback, 16, length, easing, (v, c) => taskCompletionSource.SetResult(c));
            return taskCompletionSource.Task;
        }
    }
}