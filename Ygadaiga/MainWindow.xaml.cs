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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ygadaiga
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random r = new Random();
            int x = r.Next(1, 100);
        }

        public void Changed(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                int x = int.Parse(TBox.Text);
                
            }
        }

        private void Input(object sender, TextCompositionEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.Text, 0));
        }

        private void AgainBtn(object sender, RoutedEventArgs e)
        {

        }
    }
}
