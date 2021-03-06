﻿using SQLite;
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
    /// Save.xaml の相互作用ロジック
    /// </summary>
    public partial class Save : Window
    {
        private Customer _customer;

        public Save(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            if (customer != null)
            {
                this.NameTextBox.Text = customer.Name;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text.Trim().Length < 1)//参考にする！！
            {
                MessageBox.Show("名前を入力してください");
                return;
            }

            using(var connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Customer>();
                if (_customer == null)
                {
                    connection.Insert(new Customer(NameTextBox.Text));
                }
                else
                {
                    connection.Update(new Customer(_customer.Id, NameTextBox.Text));
                }
                Close();
            }
        }
    }
}
