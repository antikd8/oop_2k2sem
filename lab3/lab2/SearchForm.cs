using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class SearchForm : Form
    {
        List<Flat> flats = new List<Flat>();
        FlatForm ogForm = new FlatForm();
        public SearchForm(List<Flat> flats, SearchType searchType, FlatForm ogForm)
        {
            InitializeComponent();
            panelRooms.Enabled = false;
            panelDistrict.Enabled = false;
            panelYear.Enabled = false;
            this.flats = flats;
            if (searchType == SearchType.searchYear)
                panelYear.Enabled = true;
            if (searchType == SearchType.searchDistrict)
                panelDistrict.Enabled = true;
            if (searchType == SearchType.searchRooms)
                panelRooms.Enabled = true;
            this.ogForm = ogForm;
        }

        private void comboBoxDistrict_TextChanged(object sender, EventArgs e)
        {
            treeViewResult.Nodes.Clear();
            string district = comboBoxDistrict.Text;
            ogForm.searchedDistrict = from Item in flats
                                where Item.address.District.ToString() == district
                                select Item;
            if (ogForm.searchedDistrict.Count() > 0)
                foreach (var item in ogForm.searchedDistrict)
                {
                    treeViewResult.Nodes.Add(item.TakeElementTree());
                    printInfoToOriginal(item);
                    ogForm.toolStripStatusLabelAction.Text = "Поиск по району";
                }
            else
                treeViewResult.Nodes.Add("Ничего не найдено!");
        }

        private void dateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {
            treeViewResult.Nodes.Clear();
            string year = dateTimePickerYear.Value.Year.ToString();
            ogForm.searchedYear = from Item in flats
                                where Item.Year.ToString() == year
                                select Item;
            if (ogForm.searchedYear.Count() > 0)
                foreach (var item in ogForm.searchedYear)
                {
                    treeViewResult.Nodes.Add(item.TakeElementTree());
                    printInfoToOriginal(item);
                    ogForm.toolStripStatusLabelAction.Text = "Поиск по году";
                }
            else
                treeViewResult.Nodes.Add("Ничего не найдено!");
        }

        public void printInfoToOriginal(Flat item)
        {
            ogForm.countModifiedFlats++;
            StringBuilder outputLine = new StringBuilder();
            outputLine.AppendLine($"Квартира [ {ogForm.countModifiedFlats} ]");
            outputLine.AppendLine("Метраж квартиры :" + item.Footage.ToString() + ";");
            outputLine.AppendLine($"Количество комнат: {item.AmountOfRooms};");
            outputLine.AppendLine("Комнаты: ");
            if (item.Balcony)
                outputLine.AppendLine(" - Балкон;");
            if (item.Basement)
                outputLine.AppendLine(" - Подвал;");
            if (item.Bathroom)
                outputLine.AppendLine(" - Ванная комната;");
            if (item.Kitchen)
                outputLine.AppendLine(" - Кухня");
            if (item.LivingRoom)
                outputLine.AppendLine(" - Спальня");
            outputLine.AppendLine($"Год постройки: {item.Year};");
            outputLine.AppendLine($"Материал постройки: {item.Material};");
            outputLine.AppendLine($"Этаж: {item.Floor};");
            outputLine.AppendLine("Адрес:" + item.address.Country + "\n" + item.address.District + "," + item.address.Street + "\n д." +
                item.address.HouseNumber + ", кв." + item.address.FlatNumber + ";");
            outputLine.AppendLine($"Цена квартиры: {item.Cost}");
            outputLine.AppendLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            ogForm.textBoxSearched.Text += outputLine.ToString();
            MessageBox.Show($"Результат поиска добавлен на \nглавную форму под номером {ogForm.countModifiedFlats}");
        }

        private void textBoxSearchRooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void textBoxSearchRooms_TextChanged(object sender, EventArgs e)
        {
            treeViewResult.Nodes.Clear();
            string amountRooms = textBoxSearchRooms.Text;
            ogForm.searchedRooms = from Item in flats
                                where Item.AmountOfRooms.ToString() == amountRooms
                                select Item;
            if (ogForm.searchedRooms.Count() > 0)
                foreach (var item in ogForm.searchedRooms)
                {
                    treeViewResult.Nodes.Add(item.TakeElementTree());
                    printInfoToOriginal(item);
                    ogForm.toolStripStatusLabelAction.Text = "Поиск по кол-ву комнат";
                }
            else
                treeViewResult.Nodes.Add("Ничего не найдено!");
        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistrict.SelectedItem != null && comboBoxDistrict.SelectedItem.ToString() == "-Добавить-")
            {
                District district = new District(this, false);
                district.Show();
            }
        }
    }
}
