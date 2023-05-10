using GalaSoft.MvvmLight.CommandWpf;
using Phonebook.Model;
using Phonebook.View;
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
    public class AddContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Свойства для полей ввода данных
        private string _Name;
        public string AnyName
        {
            get { return _Name; }
            set
            {
                if (Name_name(_Name))
                {
                    _Name = value;
                }
                else
                {
                    MessageBox.Show("Вы ввели не имя");
                }
                OnPropertyChanged("Name");
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (PhoneNumber_phone(_phoneNumber))
                {
                    _phoneNumber = value;
                }
                else
                {
                    MessageBox.Show("Вы ввели не телефон");
                }
                OnPropertyChanged("PhoneNumber");
            }
        }

        // Коллекция контактов
        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = value;
                OnPropertyChanged("Contacts");
            }
        }

        // Команда добавления контакта
        public ICommand AddContactCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public AddContactViewModel(ObservableCollection<Contact> contacts)
        {
            Contacts = contacts;
            AddContactCommand = new RelayCommand<object>(o =>AddContact(Contacts));
            CancelCommand = new RelayCommand<object>(o => Cansel());
        }

      private void Cansel()
        {
            (Application.Current.MainWindow as MainWindow).Page.Content = new ContactsView(Contacts);

        }

        // Метод добавления контакта
        private void AddContact(object parameter)
        {
            // Создание нового контакта
            Contact newContact = new Contact()
            {
                Name = AnyName,
                PhoneNumber = PhoneNumber
            };

            // Добавление нового контакта в коллекцию контактов
            Contacts.Add(newContact);

            // Очистка полей ввода данных
            AnyName = "";
            PhoneNumber = "";
            (Application.Current.MainWindow as MainWindow).Page.Content = new ContactsView(_contacts);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
