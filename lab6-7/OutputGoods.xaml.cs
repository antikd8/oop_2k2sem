using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using static lab6_7.AddGood;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для OutputGoods.xaml
    /// </summary>
    public partial class OutputGoods : Window
    {
        ObservableCollection<Item> items = new ObservableCollection<Item>();
        public OutputGoods()
        {
            InitializeComponent();
            items = XmlSerializeWrapper.Deserialize<ObservableCollection<Item>>("basket.xml");
            ListViewTable.ItemsSource = items;
        }

        private void ButtonEN_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;
        }

        private void ButtonRU_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            App.Language = lang;
        }

        private void ButtonEditBasket_Click(object sender, RoutedEventArgs e)
        {
            EditBasket window = new EditBasket();
            window.Show();
            this.Hide();
        }

        private void ButtonAddGood_Click(object sender, RoutedEventArgs e)
        {
            AddGood window = new AddGood();
            window.Show();
            this.Hide();
        }
    }
}
