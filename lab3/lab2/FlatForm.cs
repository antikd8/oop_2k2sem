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
    public partial class FlatForm : Form
    {
        public double cost;

        List<Flat> flats = new List<Flat>();
        public FlatForm()
        {
            InitializeComponent();
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
                outputLine.AppendLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                textBoxFlatInfo.Text += outputLine.ToString();
            }
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
            treeViewCountry.CollapseAll();
        }


        private void buttonAutoFill_Click(object sender, EventArgs e)
        {
            double footage = 58;
            int amountOfRooms = 3;
            int year = 2021;
            string material = "Блоки";
            int floor = 2;
            string country = "Страна";
            string district = "Казимировка";
            string street = "Ленинская";
            string houseNumber = "21а";
            string flatNumber = "59";
            bool balcony = false;
            bool basement = false;
            bool bathroom = true;
            bool kitchen = true;
            bool livingRoom = true;
            Address address = new Address(country,district,street,houseNumber,flatNumber);
            Flat flat = new Flat(footage, amountOfRooms, year, material, floor, kitchen, balcony, basement, livingRoom, bathroom,address);
            trackBarFootage.Value = 58;
            labelFootage.Text = $"Метраж: {trackBarFootage.Value}  М^2";
            numericUpDownRooms.Value = 3;
            dateTimePickerYear.Value = DateTime.Now;
            comboBoxMaterial.SelectedIndex = 2;
            numericUpDownFloor.Value = 2;
            comboBoxDistrict.SelectedIndex = 3;
            textBoxStreet.Text = "Ленинская";
            textBoxNumberHouse.Text = "21a";
            textBoxNumberFlat.Text = "59";
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
            treeViewCountry.CollapseAll();
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
                Address address = new Address(country, district, street, houseNumber, flatNumber);
                Flat flat = new Flat(footage, amountOfRooms, year, material, floor, kitchen, balcony, basement, livingRoom, bathroom, address);
                flat.Cost = flat.CountCost();
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
                District district = new District(this);
                district.Show();
            }
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Версия : 1.0\nРазработал: Другов Антон");
        }

        private void toolStripMenuItemSearchYear_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(flats, SearchType.searchYear);
            sf.Show();
        }

        private void toolStripMenuItemSearchDistrict_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(flats, SearchType.searchDistrict);
            sf.Show();
        }

        private void toolStripMenuItemSearchAmountRooms_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(flats, SearchType.searchRooms);
            sf.Show();
        }
    }
}
