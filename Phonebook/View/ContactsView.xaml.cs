using GalaSoft.MvvmLight.CommandWpf;
using Phonebook.Model;
using Phonebook.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Phonebook.View
{
    /// <summary>
    /// Логика взаимодействия для ContactsView.xaml
    /// </summary>
    public partial class ContactsView : Page
    {
        public ContactsView(ObservableCollection<Contact> _contacts)
        {
            InitializeComponent();
           
            DataContext = new ContactsViewModel(_contacts);
        }
        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Получаем выделенный элемент списка
            var selectedContact = (sender as ListView).SelectedItem as Contact;

            // Переходим к окну редактирования контакта, передавая в качестве параметров выделенный контакт и коллекцию контактов
            EditContactView contactsEditWindow = new EditContactView(new ContactsEditViewModel(selectedContact, (DataContext as ContactsViewModel).Contacts, (sender as ListView).SelectedIndex));
            (Application.Current.MainWindow as MainWindow).Page.Content = contactsEditWindow;
        }

       

    }
}
