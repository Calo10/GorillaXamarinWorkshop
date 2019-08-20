using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using GorillaTest.Model;
using GorillaTest.View;
using Xamarin.Forms;

namespace GorillaTest.ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        #region Properties
        private StudentModel _CurrentStudent = new StudentModel();
        public StudentModel CurrentStudent
        {
            get
            {
                return _CurrentStudent;
            }
            set
            {
                _CurrentStudent = value;
                OnPropertyChanged("CurrentStudent");
            }
        }

        private ObservableCollection<StudentModel> _lstStudent { get; set; }

        public ObservableCollection<StudentModel> lstStudent
        {
            get
            {
                return _lstStudent;
            }
            set
            {
                _lstStudent = value;
            }
        }

        public ICommand EnterAddStudentCommand { get; set;}
        public ICommand AddStudentCommand { get; set; }
        #endregion

        #region Singleton
        private static StudentViewModel instance = null;

        private StudentViewModel()
        {
            InitCommands();
            InitClass();
        }

        public static StudentViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new StudentViewModel();
            }
            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
            {
                instance = null;
            }
        }
        #endregion


        #region Methods

        public void EnterAddStudent()
        {
            ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new StudentAddView());
        }

        public async void AddStudent()
        {
            await StudentModel.AddStudent(CurrentStudent);


            lstStudent = await StudentModel.GetAllStudents();

            CurrentStudent = new StudentModel();

            await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync();
        }


        private void InitClass()
        {

        }

        private void InitCommands()
        {
            EnterAddStudentCommand = new Command(EnterAddStudent);
            AddStudentCommand = new Command(AddStudent);
        }
        #endregion

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
