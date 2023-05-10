using Phonebook.Model;
using Phonebook.View;
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

namespace Phonebook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>
            {
                new Contact {Name = "John Doe", PhoneNumber = "555-1234"},
                new Contact {Name = "Jane Smith", PhoneNumber = "555-5678"}
            };
            Page.Content = new ContactsView(_contacts);
        }
    }
}
