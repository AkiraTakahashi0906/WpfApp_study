using SQLite;
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
using System.Windows.Shapes;
using WpfApp1.Objects;

namespace WpfApp1
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        private ObservableCollection<Customer> _customers = new ObservableCollection<Customer>();
        private int _index = 0;
        public Window1()
        {
            InitializeComponent();
            _customers.Add(new Customer { Id = ++_index, Name = "name1", Phone = "phone1" });
            _customers.Add(new Customer { Id = ++_index, Name = "name2", Phone = "phone2" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });
            _customers.Add(new Customer { Id = ++_index, Name = "name3", Phone = "phone3" });

            CustomerListView.ItemsSource = _customers;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
            };

            customer.Name = NameTextBox.Text;

            using (var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            using (var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Customer>();
                var customers = connection.Table<Customer>().ToList();
            }

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _customers.Add(new Customer { Id = ++_index, Name = "name4", Phone = "phone4" });//参考にする
            //CustomerListView.ItemsSource = _customers;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;

        }
    }
}
