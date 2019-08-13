using System;
using System.ComponentModel;

namespace GorillaTest.ViewModel
{
    public class AuthViewModel : INotifyPropertyChanged
    {
        public AuthViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
