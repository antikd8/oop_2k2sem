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
using System.Xml.Serialization;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для AddGood.xaml
    /// </summary>
    public partial class AddGood : Window
    {
        public AddGood()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Good
        {
            [XmlElement(ElementName ="name_of_good")]
            public string NameGood { get; set; }
            [XmlElement(ElementName ="category_of_good")]
            public string Category { get; set; }
            [XmlElement(ElementName ="price_for_one_kg")]
            public double Price { get; set; }
            [XmlElement(ElementName ="origin_country")]
            public string Country { get; set; }
            [XmlElement(ElementName ="is_alailable")]
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
    }
}
