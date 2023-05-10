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
    /// Логика взаимодействия для AddContactView.xaml
    /// </summary>
    public partial class AddContactView : Page
    {
        public AddContactView(ObservableCollection<Contact> contacts)
        {
            InitializeComponent();
            DataContext = new AddContactViewModel(contacts);
        }

      
    }
}
