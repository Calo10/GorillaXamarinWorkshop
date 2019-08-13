using System;
using System.Collections.Generic;
using GorillaTest.ViewModel;
using Xamarin.Forms;

namespace GorillaTest.View
{
    public partial class StudentHomeView : ContentPage
    {
        public StudentHomeView()
        {
            InitializeComponent();

            BindingContext = StudentViewModel.GetInstance();
        }
    }
}
