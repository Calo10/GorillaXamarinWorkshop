using System;
using System.Collections.Generic;
using GorillaTest.ViewModel;
using Xamarin.Forms;

namespace GorillaTest.View
{
    public partial class StudentAddView : ContentPage
    {
        public StudentAddView()
        {
            InitializeComponent();

            BindingContext = StudentViewModel.GetInstance();
        }
    }
}
