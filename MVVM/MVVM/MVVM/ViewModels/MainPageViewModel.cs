using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVM.ViewModels {
    public class MainPageViewModel : NotifyBase {
        public string Nome { get; set; }
        private string _mensagem;
        public string Mensagem {
            get { return _mensagem; }
            set { 
                _mensagem = value;
                Notificar();
            }
        }

        public Command BoasVindasCommand {
            get {
                return new Command(() => {
                    Mensagem = "Bem-vindo " + Nome;

                });
            }
        }
    }
}
