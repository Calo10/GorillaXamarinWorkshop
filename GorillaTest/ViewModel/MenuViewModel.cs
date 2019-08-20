using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using GorillaTest.Model;
using GorillaTest.View;
using Xamarin.Forms;

namespace GorillaTest.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<MenuModel> _lstMenu { get; set; }

        public ObservableCollection<MenuModel> lstMenu
        {
            get
            {
                return _lstMenu;
            }
            set
            {
                _lstMenu = value;
            }
        }
        public ICommand SelectedMenuCommand { get; set; }

        public void SelectedMenu(int id)
        {
            switch (id)
            {
                //Form
                case 1:

                    ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new ContactFormView());

                    break;

                //Student
                case 2:

                    ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new StudentHomeView());

                    break;
                default:
                    break;
            }
        }

        public MenuViewModel()
        {
            lstMenu = MenuModel.GetMenu();
            SelectedMenuCommand = new Command<int>(SelectedMenu);

        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (propertyName != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
