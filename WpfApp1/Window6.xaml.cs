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
    /// Window6.xaml の相互作用ロジック
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            ATextBlock.Text = AprogressBar.Value.ToString()+"%";
            BTextBlock.Text = BprogressBar.Value.ToString() + "%";
        }

        private void AprogressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ATextBlock.Text = AprogressBar.Value.ToString() + "%";
        }

        private void Abutton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(500);
                    Application.Current.Dispatcher.Invoke(() =>//UIスレッドにもどす。
                    {
                        AprogressBar.Value += 10;
                    });
                }
            });
        }

        private void BprogressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BTextBlock.Text = BprogressBar.Value.ToString() + "%";
        }

        private void Bbutton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(500);
                    Application.Current.Dispatcher.Invoke(() =>//UIスレッドにもどす。
                    {
                        BprogressBar.Value += 10;
                    });
                }
            });
        }

        private void Cbutton_Click(object sender, RoutedEventArgs e)
        {
            CprogressBar.IsIndeterminate = true;
            CTextBlock.Text = "検索しています";
        }

    }
}
