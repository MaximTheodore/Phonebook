using GalaSoft.MvvmLight.CommandWpf;
using Phonebook.Model;
using Phonebook.View;
using Phonebook.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static Phonebook.ViewModel.Helpers.HelperNamePhone;
namespace Phonebook.ViewModel
{
    public class ContactsEditViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Contact selectedContact;
        private ObservableCollection<Contact> contacts;
        public ICommand saveCommand;
        private int Select;


        public ContactsEditViewModel(Contact selectedContact, ObservableCollection<Contact> contacts, int selectedind)
        {
            this.selectedContact = selectedContact;
            this.contacts = contacts;
            this.Select = selectedind;
            this.saveCommand = new RelayCommand<object>(o => SaveContact(), o => CanSaveContact());
        }

        public string Name
        {
            get { return selectedContact.Name; }
            set
            {
                if (Name_name(selectedContact.Name))
                {
                    selectedContact.Name = value;
                }
                else
                {
                    MessageBox.Show("Вы ввели не имя");
                }
                OnPropertyChanged("Name");
            }
        }

        public string PhoneNumber
        {
            get { return selectedContact.PhoneNumber; }
            set
            {
                if (PhoneNumber_phone(selectedContact.PhoneNumber))
                {
                    selectedContact.PhoneNumber = value;
                }
                else
                {
                    MessageBox.Show("Вы неправильно ввели телефон");
                }
                OnPropertyChanged("PhoneNumber");
            }
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        private bool CanSaveContact()
        {
            return !string.IsNullOrEmpty(selectedContact.Name) && !string.IsNullOrEmpty(selectedContact.PhoneNumber);
        }

        public void SaveContact()
        {
            contacts.RemoveAt(Select);
            contacts.Insert(Select, selectedContact);
            (Application.Current.MainWindow as MainWindow).Page.Content = new ContactsView(contacts);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}


