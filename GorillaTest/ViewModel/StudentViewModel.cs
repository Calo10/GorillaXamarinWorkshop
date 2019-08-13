using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GorillaTest.Model;

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

        #endregion

        #region Singleton
        private static StudentViewModel instance = null;

        private StudentViewModel()
        {
            //InitCommands();
            //InitClass();
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
