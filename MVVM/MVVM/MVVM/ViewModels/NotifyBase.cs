using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MVVM.ViewModels {
    public abstract class NotifyBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Notificar([CallerMemberName] string prop = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
