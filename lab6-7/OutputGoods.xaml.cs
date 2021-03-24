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
            Image[]  images= { image1, image2,image3};
            TextBlock[] names = { name1, name2, name3};
            TextBlock[] categorys = { category1, category2, category3 };
            TextBlock[] prices = { price1, price2, price3 };
            TextBlock[] countrys = { country1, country2, country3 };
            foreach (var item in items)
            {
                if (counter >= 3)
                    break;
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(item.PicturePath);
                image.EndInit();
                images[counter].Source = image;
                names[counter].Text = item.NameItem;
                categorys[counter].Text = item.Category;
                prices[counter].Text = item.Price.ToString() + " у.е.";
                countrys[counter].Text = item.Country;
                counter++;
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
