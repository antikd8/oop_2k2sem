using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            CommandBinding commandHome = new CommandBinding();
            commandHome.Command = NavigationCommands.BrowseHome;
            commandHome.Executed += ButtonBrowseHome_Click;
            ButtonBrowseHome.CommandBindings.Add(commandHome);

            CommandBinding commandEdit = new CommandBinding();
            commandEdit.Command = ApplicationCommands.CorrectionList;
            commandEdit.Executed += ButtonEditBasket_Click;
            ButtonEditBasket.CommandBindings.Add(commandEdit);

            CommandBinding commandAdd = new CommandBinding();
            commandAdd.Command = ApplicationCommands.New;
            commandAdd.Executed += ButtonAddGood_Click;
            ButtonAddGood.CommandBindings.Add(commandAdd);
        }

        private void ButtonBrowseHome_Click(object sender, ExecutedRoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
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

        private void RadioButtonAvailable_Checked(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Item> tempItems = new ObservableCollection<Item>();
            foreach (var item in items)
            {
                if (item.IsAvailable == "В наличии" || item.IsAvailable == "AVAILABLE")
                    tempItems.Add(item);
            }
            items = tempItems;
            ListViewTable.ItemsSource = items;
            items = XmlSerializeWrapper.Deserialize<ObservableCollection<Item>>("basket.xml");
        }

        private void RadioButtonNotAvailable_Checked(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Item> tempItems = new ObservableCollection<Item>();
            foreach (var item in items)
            {
                if (item.IsAvailable == "Отсутствует" || item.IsAvailable == "NOT AVAILABLE")
                    tempItems.Add(item);
            }
            items = tempItems;
            ListViewTable.ItemsSource = items;
            items = XmlSerializeWrapper.Deserialize<ObservableCollection<Item>>("basket.xml");
        }

        private void TextBoxMinPrice_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }

        private void TextBoxMaxPrice_KeyDown(object sender, KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }

        private void ButtonSetFilters_Click(object sender, RoutedEventArgs e)
        {
            double minPrice = 0;
            double maxPrice = 0;
            string Category = null;
            if (TextBoxMinPrice.Text != string.Empty && TextBoxMaxPrice.Text != string.Empty)
            {
                if (Double.TryParse(TextBoxMinPrice.Text, out double result))
                    minPrice = result;
                if (Double.TryParse(TextBoxMaxPrice.Text, out double resultt))
                    maxPrice = resultt;
            }
            else
            {
                MessageBox.Show("Заполните минимальную и максимальную цены!");
                return;
            }
            if (ComboBoxCategoryFilter.SelectedIndex != -1)
            {
                Category = ComboBoxCategoryFilter.Text;
            }
            else
            {
                MessageBox.Show("Выберите категорию товара!");
                return;
            }
            if (RadioButtonAvailable.IsChecked == false && RadioButtonNotAvailable.IsChecked == false)
            {
                MessageBox.Show("Выберите наличие товара!");
                return;
            }
            ObservableCollection<Item> tempItems = new ObservableCollection<Item>();
            foreach (var item in items)
            {
                if (item.Price > minPrice && item.Price < maxPrice && item.Category == Category)
                    tempItems.Add(item);
            }
            items = new ObservableCollection<Item>();
            if (tempItems.Count < 1)
            {
                MessageBox.Show("По заданным критериями не найдено ни одного товара!");
                return;
            }
            if (RadioButtonAvailable.IsChecked == true)
                foreach (var item in tempItems)
                {
                    if (item.IsAvailable == "В наличии" || item.IsAvailable == "AVAILABLE")
                        items.Add(item);
                }
            else 
                foreach(var item in tempItems)
                {
                    if (item.IsAvailable == "Отсутствует" || item.IsAvailable == "NOT AVAILABLE")
                        items.Add(item);
                }
            if(items.Count<1)
            {
                MessageBox.Show("По заданным критерями не найдено ни одного товара!");
                return;
            }
            ListViewTable.ItemsSource = items;
            items = XmlSerializeWrapper.Deserialize<ObservableCollection<Item>>("basket.xml");
        }
    }
}


