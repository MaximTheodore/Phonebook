using GalaSoft.MvvmLight.CommandWpf;
using System;
using Phonebook.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Phonebook.Model;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Phonebook.ViewModel
{
    public class ContactsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Contact> _contacts;
        private Contact selected;
        public ICommand AddpageCommand;

        public ContactsViewModel(ObservableCollection<Contact> contacts)
        {
            _contacts = contacts;
            this.AddpageCommand = new RelayCommand<object>(o => Add_page());

        }
        public Contact Selected
        {
            get { return selected; }
            set {
                selected = value;
                OnPropertyChanged();
            
            }
        }
        public ICommand PagenewCommand
        {
            get { return AddpageCommand; }
        }
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                if (value != _contacts)
                {
                    _contacts = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       public ICommand command { get; set; }
       public void Add_page()
        {
            (Application.Current.MainWindow as MainWindow).Page.Content = new AddContactView(_contacts);
        }


    }
}
