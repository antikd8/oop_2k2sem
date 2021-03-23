using System;
using System.Collections.Generic;
using System.Globalization;
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
        Item item = new Item();
        public AddGood()
        {
            InitializeComponent();
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
            public string Description { get; set; }
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
            item.NameItem = TextBlockNameGood.Text;
            item.Category = ComboBoxCategory.Text;
            if (Double.TryParse(TextBoxPrice.Text, out double price))
                item.Price = price;
            else
                MessageBox.Show("Неверные данные в поле с ценой");
            item.Country = TextBlockCountry.Text;
            if (RadioButtonAvailable.IsChecked == true)
                item.IsAvailable = "В наличии";
            if (RadioButtonNotAvailable.IsChecked == true)
                item.IsAvailable = "Отсутствует";
            item.Description = TextBlockDescription.Text;
            MessageBox.Show("Информация о товаре записана в файл!");
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
            dlg.Filter = "Pictures (.png,jpg)|*.png,*.jpg"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
              //  ItemPicture.Source = new Uri(dlg.FileName);
            }
        }
    }
}
