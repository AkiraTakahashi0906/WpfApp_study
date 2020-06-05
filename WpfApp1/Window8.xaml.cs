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

namespace WpfApp1
{
    /// <summary>
    /// Window8.xaml の相互作用ロジック
    /// </summary>
    public partial class Window8 : Window
    {
        private ObservableCollection<Dto> _dtos = new ObservableCollection<Dto>();

        public Window8()
        {
            InitializeComponent();//C:\Users\akira\OneDrive\デスクトップ\C#\WPF\WpfApp1\WpfApp1\Images\download1.jpeg.jpg
            _dtos.Add(new Dto(@"C:\Users\akira\OneDrive\デスクトップ\C#\WPF\WpfApp1\WpfApp1\Images\download1.jpg", "A"));
            _dtos.Add(new Dto(@"WpfApp1\Images\download1.jpg", "B"));
            _dtos.Add(new Dto("Images/download3.jpg", "C"));
            myListBox.ItemsSource = _dtos;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (singleRadioButton.IsChecked.Value)
            {
                myListBox.SelectionMode = SelectionMode.Single;
            }
            else if(ExtendedRadioButton.IsChecked.Value)
            {
                myListBox.SelectionMode = SelectionMode.Extended;
            }
            else
            {
                myListBox.SelectionMode = SelectionMode.Multiple;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public sealed class Dto
    {
        public Dto(string fileName,string name)
        {
            FileName = fileName;
            Name = name;
        }
        public string FileName { get; set; }
        public string Name { get; set; }
    }

}
