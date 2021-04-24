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

namespace lab11
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


        private void MoveToPrev(object sender, RoutedEventArgs e)
        {
            if (flatGrid.SelectedItem != null)
            {
                if (flatGrid.SelectedIndex == 0)
                    return;
                flatGrid.SelectedIndex = flatGrid.SelectedIndex - 1;
            }
        }

        private void MoveToNext(object sender, RoutedEventArgs e)
        {
            if (flatGrid.SelectedItem != null)
            {
                if (flatGrid.SelectedIndex == flatGrid.Items.Count)
                    return;
                flatGrid.SelectedIndex = flatGrid.SelectedIndex + 1;
            }
        }

    }
}
