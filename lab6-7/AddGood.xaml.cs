using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для AddGood.xaml
    /// </summary>
    public partial class AddGood : Window
    {
        List<Item> itemsCollection = new List<Item>();
        public AddGood()
        {
            InitializeComponent();
            itemsCollection = XmlSerializeWrapper.Deserialize<List<Item>>("basket.xml");
        }
        [Serializable]
        public class Item
        {
            [XmlElement(ElementName = "name_of_item")]
            public string NameItem { get; set; }
            [XmlElement(ElementName = "category_of_item")]
            public string Category { get; set; }
            [XmlElement(ElementName = "price_for_one_kg")]
            public double Price { get; set; }
            [XmlElement(ElementName = "origin_country")]
            public string Country { get; set; }
            [XmlElement(ElementName = "is_alailable")]
            public string IsAvailable { get; set; }
            [XmlIgnore]
            public string Description { get; set; }
            [XmlElement(ElementName ="path_of_picture")]
            public string PicturePath { get; set; }
        }

        public static class XmlSerializeWrapper
        {
            public static void Serialize<T>(T obj, string filename)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, obj);
                }
            }
            public static T Deserialize<T>(string filename)
            {
                T obj;
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    obj = (T)serializer.Deserialize(fs);
                }
                return obj;
            }
        }
        private void ButtonAddGood_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRU_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            App.Language = lang;
        }

        private void ButtonEN_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;
        }

        private void ButtonAddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Item item = new Item();
                item.NameItem = TextBoxNameGood.Text;
                item.Category = ComboBoxCategory.Text;
                if (Double.TryParse(TextBoxPrice.Text, out double price))
                    item.Price = price;
                else
                    throw new Exception("Неверные данные в поле с ценой");
                item.Country = TextBoxCountry.Text;
                if (RadioButtonAvailable.IsChecked == true)
                    item.IsAvailable = "В наличии";
                if (RadioButtonNotAvailable.IsChecked == true)
                    item.IsAvailable = "Отсутствует";
                item.Description = TextBoxDescription.Text;
                item.PicturePath = ItemPicture.Source.ToString();
                itemsCollection.Add(item);
                MessageBox.Show($"колво товаров в корзине: {itemsCollection.Count}");
                XmlSerializeWrapper.Serialize(itemsCollection, "basket.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка записи в файл!");
            }
            MessageBox.Show("Товар добавлен в корзину!");

        }

        private void TextBoxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }

        private void ButtonAddPicture_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = ""; // Default file name
            dlg.DefaultExt = ".png"; // Default file extension
                                     //    dlg.Filter = "Pictures (.png,jpg)|*.png,*.jpg"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(dlg.FileName);
                image.EndInit();
                ItemPicture.Source = image;
                MessageBox.Show(dlg.FileName);
            }
        }

        private void ButtonEditBasket_Click(object sender, RoutedEventArgs e)
        {
            EditBasket window = new EditBasket();
            window.Show();
        }

        private void ButtonClearInfo_Click(object sender, RoutedEventArgs e)
        {
            TextBoxPrice.Text = string.Empty;
            TextBoxNameGood.Text = string.Empty;
            TextBoxDescription.Text = string.Empty;
            TextBoxCountry.Text = string.Empty;
            ComboBoxCategory.SelectedIndex = -1;
            RadioButtonAvailable.IsChecked = false;
            RadioButtonNotAvailable.IsChecked = false;
            ItemPicture.Source = null;
        }

        private void ButtonOutputBacket_Click(object sender, RoutedEventArgs e)
        {
            OutputGoods window = new OutputGoods();
            window.Show();
        }
    }
}
