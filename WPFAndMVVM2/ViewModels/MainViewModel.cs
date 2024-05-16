using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        private ObservableCollection<PersonViewModel> _personsVM;
        public ObservableCollection<PersonViewModel> PersonsVM
        {
            get { return _personsVM; }
            set
            {
                _personsVM = value;
                OnPropertyChanged(nameof(PersonsVM));
            }
        }

        private PersonViewModel _selectedPerson;
        public PersonViewModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                OnPropertyChanged(nameof(SelectedPerson));
            }
        }

        public MainViewModel()
        {
            SelectedPerson = null;
            PersonsVM = new ObservableCollection<PersonViewModel>();

            foreach (Person person in personRepo.GetAll())
            {
                PersonsVM.Add(new PersonViewModel(person));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

