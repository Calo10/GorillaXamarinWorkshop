using System;
using System.Collections.Generic;
using GorillaTest.ViewModel;
using Xamarin.Forms;

namespace GorillaTest.View
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

            BindingContext = new AuthViewModel();
        }

    }
}
