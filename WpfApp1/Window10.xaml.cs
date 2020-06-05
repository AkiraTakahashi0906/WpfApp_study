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
    /// Window10.xaml の相互作用ロジック
    /// </summary>
    public partial class Window10 : Window
    {
        private ObservableCollection<Dto1> _dtos = new ObservableCollection<Dto1>();
        public Window10()
        {
            InitializeComponent();
            var dto1 = new Dto1("Name");
            dto1.Dtos.Add(new Dto1("Name1-1"));
            dto1.Dtos.Add(new Dto1("Name1-2"));
            dto1.Dtos.Add(new Dto1("Name1-3"));
            _dtos.Add(dto1);
            CTreeView.ItemsSource = _dtos;
        }
    }

    public sealed class Dto1
    {
        public Dto1(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<Dto1> Dtos { get; set; } = new List<Dto1>();
    }
}
