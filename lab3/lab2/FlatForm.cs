using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab2
{
    public partial class FlatForm : Form
    {
        public double cost;
        public int countModifiedFlats = 0;
        public int countSortedFlats = 0;
        public IEnumerable<Flat> sortedPrice;
        public IEnumerable<Flat> sortedYear;
        public IEnumerable<Flat> sortedFootage;
        public IEnumerable<Flat> searchedYear;
        public IEnumerable<Flat> searchedDistrict;
        public IEnumerable<Flat> searchedRooms;
        int sortType;
        int searchType;
        int amountObjects = 0;
        List<Flat> flats = new List<Flat>();
        public FlatForm()
        {
            InitializeComponent();
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
            Timer timer;
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
            toolStripStatusLabelAmount.Text = amountObjects.ToString();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonOutputInfo_Click(object sender, EventArgs e)
        {
            List<Flat> flatsCollection = XmlSerializeWrapper.Deserialize<List<Flat>>("flat.xml");
            int counterFlats = 0;
            textBoxFlatInfo.Text = string.Empty;
            foreach (var flat in flatsCollection)
            {
                counterFlats++;
                StringBuilder outputLine = new StringBuilder();
                outputLine.AppendLine($"Квартира [ {counterFlats} ]");
                outputLine.AppendLine("Метраж квартиры :" + flat.Footage.ToString() + ";");
                outputLine.AppendLine(labelRooms.Text + ":" + flat.AmountOfRooms.ToString() + ";");
                outputLine.AppendLine("Комнаты: ");
                if (flat.Balcony)
                    outputLine.AppendLine(" - Балкон;");
                if (flat.Basement)
                    outputLine.AppendLine(" - Подвал;");
                if (flat.Bathroom)
                    outputLine.AppendLine(" - Ванная комната;");
                if (flat.Kitchen)
                    outputLine.AppendLine(" - Кухня");
                if (flat.LivingRoom)
                    outputLine.AppendLine(" - Спальня");
                outputLine.AppendLine(labelYear.Text + " : " + flat.Year + ";");
                outputLine.AppendLine(labelMaterial.Text + " : " + flat.Material + ";");
                outputLine.AppendLine(labelFloor.Text + " : " + flat.Floor + ";");
                outputLine.AppendLine("Адрес:" + flat.address.Country + "\n" + flat.address.District + "," + flat.address.Street + "\n д." +
                    flat.address.HouseNumber + ", кв." + flat.address.FlatNumber + ";");
                outputLine.AppendLine(labelCostFlat.Text + " : " + flat.Cost + "$ ;");
                outputLine.AppendLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                textBoxFlatInfo.Text += outputLine.ToString();
            }
            toolStripStatusLabelAction.Text = "Вывод из файла";
        }

        private void buttonClearInfo_Click(object sender, EventArgs e)
        {
            trackBarFootage.Value = trackBarFootage.Minimum;
            labelFootage.Text = $"Метраж: {trackBarFootage.Value}  М^2";
            numericUpDownRooms.Value = numericUpDownRooms.Minimum;
            dateTimePickerYear.Value = dateTimePickerYear.MinDate;
            comboBoxMaterial.SelectedIndex = -1;
            numericUpDownFloor.Value = numericUpDownFloor.Minimum;
            comboBoxDistrict.SelectedIndex = -1;
            textBoxStreet.Text = string.Empty;
            textBoxNumberHouse.Text = string.Empty;
            textBoxNumberFlat.Text = string.Empty;
            checkBoxBalcony.Checked = false;
            checkBoxBasement.Checked = false;
            checkBoxBathroom.Checked = false;
            checkBoxKitchen.Checked = false;
            checkBoxLivingRoom.Checked = false;
            textBoxCost.Text = string.Empty;
            textBoxFlatInfo.Text = string.Empty;
            treeViewCountry.SelectedNode = null;
            textBoxStreet.ReadOnly = false;
            textBoxNumberFlat.ReadOnly = false;
            textBoxNumberHouse.ReadOnly = false;
            textBoxIndex.Text = string.Empty;
            textBoxSorted.Text = string.Empty;
            textBoxSearched.Text = string.Empty;
            treeViewCountry.CollapseAll();
            toolStripStatusLabelAction.Text = "Все данные были очищены";
        }


        private void buttonAutoFill_Click(object sender, EventArgs e)
        {
            double footage = 58;
            int amountOfRooms = 3;
            int year = 1865;
            string material = "Блоки";
            int floor = 2;
            string country = "Страна";
            string district = "Казимировка";
            string street = "Ленинская";
            string houseNumber = "21а";
            string flatNumber = "59";
            string index = "34ABC56";
            bool balcony = false;
            bool basement = false;
            bool bathroom = true;
            bool kitchen = true;
            bool livingRoom = true;
            Address address = new Address(country, district, street, houseNumber, flatNumber, index);
            Flat flat = new Flat(footage, amountOfRooms, year, material, floor, kitchen, balcony, basement, livingRoom, bathroom, address);
            trackBarFootage.Value = 58;
            labelFootage.Text = $"Метраж: {trackBarFootage.Value}  М^2";
            numericUpDownRooms.Value = 3;
            dateTimePickerYear.Value = DateTime.Parse("1856-02-02");
            comboBoxMaterial.SelectedIndex = 2;
            numericUpDownFloor.Value = 2;
            comboBoxDistrict.SelectedIndex = 3;
            textBoxStreet.Text = "Ленинская";
            textBoxNumberHouse.Text = "21a";
            textBoxNumberFlat.Text = "59";
            textBoxIndex.Text = "34ABC56";
            checkBoxBalcony.Checked = false;
            checkBoxBasement.Checked = false;
            checkBoxBathroom.Checked = true;
            checkBoxKitchen.Checked = true;
            checkBoxLivingRoom.Checked = true;
            textBoxCost.Text = flat.CountCost().ToString();
            textBoxFlatInfo.Text = string.Empty;
            treeViewCountry.ExpandAll();
            treeViewCountry.SelectedNode = treeViewCountry.GetNodeAt(0, 0);
            textBoxStreet.ReadOnly = false;
            textBoxNumberFlat.ReadOnly = false;
            textBoxNumberHouse.ReadOnly = false;
            toolStripStatusLabelAction.Text = "Автозаполнение";
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (textBoxStreet.TextLength > 30)
                textBoxStreet.ReadOnly = true;
        }

        private void textBoxNumberHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (textBoxNumberHouse.Text.Length > 4)
                textBoxNumberHouse.ReadOnly = true;
        }

        private void textBoxNumberFlat_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (textBoxNumberFlat.Text.Length > 4)
                textBoxNumberFlat.ReadOnly = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            double footage;
            int amountOfRooms;
            int year;
            string material;
            int floor;
            string country;
            string district;
            string street;
            string houseNumber;
            string flatNumber;
            string index;
            bool balcony = false;
            bool basement = false;
            bool bathroom = false;
            bool kitchen = false;
            bool livingRoom = false;
            try
            {
                street = textBoxStreet.Text;
                footage = trackBarFootage.Value;
                amountOfRooms = (int)numericUpDownRooms.Value;
                year = dateTimePickerYear.Value.Year;
                material = comboBoxMaterial.Text;
                floor = (int)numericUpDownFloor.Value;
                if (treeViewCountry.SelectedNode == null)
                    throw new Exception("Выберите страну или город квартиры!");
                else
                    country = treeViewCountry.SelectedNode.Text;
                district = comboBoxDistrict.Text;
                street = textBoxStreet.Text;
                houseNumber = textBoxNumberHouse.Text;
                flatNumber = textBoxNumberFlat.Text;
                index = textBoxIndex.Text;
                if (checkBoxBalcony.Checked)
                    balcony = true;
                if (checkBoxBasement.Checked)
                    basement = true;
                if (checkBoxBathroom.Checked)
                    bathroom = true;
                if (checkBoxKitchen.Checked)
                    kitchen = true;
                if (checkBoxLivingRoom.Checked)
                    livingRoom = true;
                Address address = new Address(country, district, street, houseNumber, flatNumber, index);
                Flat flat = new Flat(footage, amountOfRooms, year, material, floor, kitchen, balcony, basement, livingRoom, bathroom, address);
                flat.Cost = flat.CountCost();
                textBoxCost.Text = flat.Cost.ToString();
                flats.Add(flat);
                XmlSerializeWrapper.Serialize(flats, "flat.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                MessageBox.Show($"Данные успешно записаны в файл \"flat.xml\"");
            }
            amountObjects++;
            toolStripStatusLabelAmount.Text = amountObjects.ToString();
            toolStripStatusLabelAction.Text = "Данные были записаны в файл";
        }

        private void buttonAutoFill_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LimeGreen;
        }

        private void buttonAutoFill_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }

        private void trackBarFootage_Scroll(object sender, EventArgs e)
        {
            labelFootage.Text = $"Метраж: {trackBarFootage.Value}  М^2";
        }


        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDistrict.SelectedItem != null && comboBoxDistrict.SelectedItem.ToString() == "-Добавить-")
            {
                District district = new District(this, true);
                district.Show();
            }
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Версия : 1.0\nРазработал: Другов Антон");
            toolStripStatusLabelAction.Text = "Просмотрена информация о программе";
        }

        private void toolStripMenuItemSearchYear_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(flats, SearchType.searchYear, this);
            searchType = 0;
            sf.Show();
        }

        private void toolStripMenuItemSearchDistrict_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(flats, SearchType.searchDistrict, this);
            sf.Show();
            searchType = 1;
        }

        private void toolStripMenuItemSearchAmountRooms_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(flats, SearchType.searchRooms, this);
            sf.Show();
            searchType = 2;
        }


        public void printSortedInfo(Flat item)
        {
            countSortedFlats++;
            StringBuilder outputLine = new StringBuilder();
            outputLine.AppendLine($"Квартира [ {countSortedFlats} ]");
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
            outputLine.AppendLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            textBoxSorted.Text += outputLine.ToString();
        }

        private void toolStripMenuItemSortFootage_Click(object sender, EventArgs e)
        {
            sortType = 1;
            if (flats.Count < 1)
                MessageBox.Show($"Вы не сохранили ни одну квартиру!");
            else
            {
                sortedFootage = from item in flats
                                orderby item.Footage
                                select item;
                textBoxSorted.Text = string.Empty;
                countSortedFlats = 0;
                foreach (var item in sortedFootage)
                    printSortedInfo(item);
                toolStripStatusLabelAction.Text = "Произведена сортировка по метражу";
            }
        }

        private void toolStripMenuItemSortYear_Click(object sender, EventArgs e)
        {
            sortType = 0;
            if (flats.Count < 1)
                MessageBox.Show($"Вы не сохранили ни одну квартиру!");
            else
            {
                sortedYear = from item in flats
                             orderby item.Year
                             select item;
                textBoxSorted.Text = string.Empty;
                countSortedFlats = 0;
                foreach (var item in sortedYear)
                    printSortedInfo(item);
                toolStripStatusLabelAction.Text = "Произведена сортировка по году";
                
            }
        }

        private void toolStripMenuItemSortPrice_Click(object sender, EventArgs e)
        {
            sortType = 2;
            if (flats.Count < 1)
                MessageBox.Show($"Вы не сохранили ни одну квартиру!");
            else
            {
                sortedPrice = from item in flats
                              orderby item.Cost
                              select item;
                textBoxSorted.Text = string.Empty;
                countSortedFlats = 0;
                foreach (var item in sortedPrice)
                    printSortedInfo(item);
                toolStripStatusLabelAction.Text = "Произведена сортировка по цене";
            }
        }

        private void buttonSearchSave_Click(object sender, EventArgs e)
        {
            List<Flat> list = new List<Flat>();
            switch (searchType)
            {
                case 1:
                    if (searchedDistrict.Count() > 0)
                        foreach (var item in searchedDistrict)
                            list.Add(item);
                    break;
                case 2:
                    if (searchedRooms.Count() > 0)
                        foreach (var item in searchedRooms)
                            list.Add(item);
                    break;
                case 0:
                    if (searchedYear.Count() > 0)
                        foreach (var item in searchedYear)
                            list.Add(item);
                    break;
            }
            XmlSerializeWrapper.Serialize(list, "search_result.xml");
            toolStripStatusLabelAction.Text = "Сохранены результаты поиска";
        }

        private void buttonSortSave_Click(object sender, EventArgs e)
        {
            List<Flat> list = new List<Flat>();
            switch (sortType)
            {
                case 0:
                    if (sortedYear.Count() > 0)
                        foreach (var item in sortedYear)
                            list.Add(item);
                    break;
                case 1:
                    if (sortedFootage.Count() > 0)
                        foreach (var item in sortedFootage)
                            list.Add(item);
                    break;
                case 2:
                    if (sortedPrice.Count() > 0)
                        foreach (var item in sortedPrice)
                            list.Add(item);
                    break;
            }
            XmlSerializeWrapper.Serialize(list, "sort_result.xml");
            toolStripStatusLabelAction.Text = "Сохранены результаты сортировки";
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSort_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemSortResult_Click(object sender, EventArgs e)
        {
            buttonSortSave_Click(this, e);
        }

        private void ToolStripMenuItemSearchResult_Click(object sender, EventArgs e)
        {
            buttonSearchSave_Click(this, e);
        }

        private void toolStripMenuItemYearSear_Click(object sender, EventArgs e)
        {
            toolStripMenuItemSearchYear_Click(this, e);
        }

        private void toolStripMenuItemDistrictSear_Click(object sender, EventArgs e)
        {
            toolStripMenuItemSearchDistrict_Click(this, e);
        }

        private void toolStripMenuItemRoomsSear_Click(object sender, EventArgs e)
        {
            toolStripMenuItemSearchAmountRooms_Click(this, e);
        }

        private void toolStripMenuItemYear_Click(object sender, EventArgs e)
        {
            toolStripMenuItemSortYear_Click(this, e);
        }

        private void toolStripMenuItemFootage_Click(object sender, EventArgs e)
        {
            toolStripMenuItemSortFootage_Click(this, e);
        }

        private void toolStripMenuItemRooms_Click(object sender, EventArgs e)
        {
            toolStripMenuItemSortPrice_Click(this, e);
        }

        private void toolStripMenuItemSortRes_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemSortResult_Click(this, e);
        }

        private void toolStripMenuItemSearchRes_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemSearchResult_Click(this, e);
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            toolStripMenuItemSave_Click(this, e);
        }

        private void toolStripButtonClearInfo_Click(object sender, EventArgs e)
        {
            buttonClearInfo_Click(this, e);
        }

        private void ToolStripMenuItemHideTool_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible)
            {
                toolStrip1.Hide();
                ToolStripMenuItemHideTool.Text = "Показать панель инструментов";
            }
            else
            {
                toolStrip1.Show();
                ToolStripMenuItemHideTool.Text = "Скрыть панель инструментов";
            }
        }   
    }
}
