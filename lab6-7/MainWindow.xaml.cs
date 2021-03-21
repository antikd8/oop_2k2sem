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

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOutputGood_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEditBasket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAddGood_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonOutputBacket_MouseEnter(object sender, MouseEventArgs e)
        {
            ButtonOutputBasket.FontSize = 16;
        }

        private void ButtonOutputBasket_MouseLeave(object sender, MouseEventArgs e)
        {
            ButtonOutputBasket.FontSize = 12;
        }
    }
}
