using SQLite;
using System;
using System.Collections.Generic;
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
    /// Window2.xaml の相互作用ロジック
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            ReadDatabase();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var f = new Save(null);
            f.ShowDialog();
            ReadDatabase();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null)
            {
                MessageBox.Show("選択してください");
                return;
            }
            var f = new Save(item);
            f.ShowDialog();
            ReadDatabase();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null)
            {
                MessageBox.Show("選択してください");
                return;
            }
            using (var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Customer>();
                connection.Delete(item);
                ReadDatabase();
            }
        }

        private void ReadDatabase()
        {
            using (var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Customer>();
                CustomerListView.ItemsSource = connection.Table<Customer>().ToList();
            }
        }

    }
}
