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
    /// Window7.xaml の相互作用ロジック
    /// </summary>
    public partial class Window7 : Window
    {
        private ObservableCollection<Customer> _customers
            = new ObservableCollection<Customer>();
        public Window7()
        {
            InitializeComponent();
            MyComboBox.Items.Add("111");
            MyComboBox.Items.Add("222");
            MyComboBox.Items.Add("333");

            _customers.Add(new Customer{ Id=1,Name="name1",Phone="phone1"});
            _customers.Add(new Customer { Id = 2, Name = "name2", Phone = "phone2" });
            _customers.Add(new Customer { Id =3, Name = "name3", Phone = "phone3" });

            AComboBox.ItemsSource = _customers;
            BComboBox.ItemsSource = _customers;
        }

        private void MyButton_click(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("MyComboBox.SelectedIndex:" + MyComboBox.SelectedIndex);
            sb.AppendLine("MyComboBox.SelectedValue:" + MyComboBox.SelectedValue);
            sb.AppendLine("MyComboBox.Text" + MyComboBox.Text);
            MessageBox.Show(sb.ToString());
        }

        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            var item = AComboBox.SelectedItem as Customer;
            if(item != null)
            {
                var sb = new StringBuilder();
                sb.AppendLine("AComboBox.SelectedIndex:" + AComboBox.SelectedIndex);
                sb.AppendLine("AComboBox.SelectedValue:" + AComboBox.SelectedValue);
                sb.AppendLine("AComboBox.Text" + AComboBox.Text);
                sb.AppendLine("---------------");
                sb.AppendLine("SelectedItem.Id : " + item.Id);
                sb.AppendLine("SelectedItem.name : " + item.Name);
                sb.AppendLine("SelectedItem.phone : " + item.Phone);
                MessageBox.Show(sb.ToString());
            }
        }

        private void BButton_Click(object sender, RoutedEventArgs e)
        {
            var item = AComboBox.SelectedItem as Customer;
            if (item != null)
            {
                var sb = new StringBuilder();
                sb.AppendLine("AComboBox.SelectedIndex:" + AComboBox.SelectedIndex);
                sb.AppendLine("AComboBox.SelectedValue:" + AComboBox.SelectedValue);
                sb.AppendLine("AComboBox.Text" + AComboBox.Text);
                sb.AppendLine("---------------");
                sb.AppendLine("SelectedItem.Id : " + item.Id);
                sb.AppendLine("SelectedItem.name : " + item.Name);
                sb.AppendLine("SelectedItem.phone : " + item.Phone);
                MessageBox.Show(sb.ToString());
            }
        }
    }
}
