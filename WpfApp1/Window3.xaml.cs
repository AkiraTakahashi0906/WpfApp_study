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

namespace WpfApp1
{
    /// <summary>
    /// Window3.xaml の相互作用ロジック
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void NormalButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Normal button click!");
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"RepeatButton");
        }

        private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("toggle button click:" + MyToggleButton.IsChecked);
        }

        private void MyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("MyCheckBox_Checked:" + MyCheckBox.IsChecked);
        }

        private void MyCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("MyCheckBox_Unchecked:" + MyCheckBox.IsChecked);
        }

        private void MyCheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("MyCheckBox_Indeterminate:" + MyCheckBox.IsChecked);
        }

        private void CRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == CRadioButton)
            {
                Console.WriteLine("CRadioButton_Checked:" + radioButton.IsChecked);
            }
            else
            {

            }
        }
    }
}
