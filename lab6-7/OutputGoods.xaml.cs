using System;
using System.Collections.Generic;
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
        List<Item> items = new List<Item>();
        public OutputGoods()
        {
            InitializeComponent();
            items = XmlSerializeWrapper.Deserialize<List<Item>>("basket.xml");
            int counter = 0;
            foreach(var item in items)
            {
                if (counter != 1)
                {
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.UriSource = new Uri(item.PicturePath);
                    image.EndInit();
                    image1.Source = image;
                    counter++;
                }
                else
                {
                    break;
                }
            }
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
        }

        private void ButtonAddGood_Click(object sender, RoutedEventArgs e)
        {
            AddGood window = new AddGood();
            window.Show();
        }
    }
}
