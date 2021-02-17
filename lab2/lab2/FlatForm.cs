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
        public FlatForm()
        {
            InitializeComponent();
        }

        private void buttonOutputInfo_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder outputLine = new StringBuilder();
                outputLine.AppendLine("Метраж квартиры :" + trackBarFootage.Value.ToString() + ";");
                outputLine.AppendLine(labelRooms.Text + ":" + numericUpDownRooms.Value + ";");
                outputLine.AppendLine(labelYear.Text + " : " + dateTimePickerYear.Value.Year + ";");
                outputLine.AppendLine(labelMaterial.Text + " : " + comboBoxMaterial.Text + ";");
                if (treeViewCountry.SelectedNode == null)
                    throw new Exception("Выберите страну или город квартиры!");
                else
                    outputLine.AppendLine(groupBoxAddress.Text + " : " + treeViewCountry.SelectedNode.Text + ",");
                outputLine.AppendLine(labelFloor.Text + " : " + numericUpDownFloor.Value + ";");
                outputLine.AppendLine(textBoxStreet.Text + ", д." + textBoxNumberHouse.Text + ", кв." + textBoxNumberFlat.Text + ";");
                outputLine.AppendLine(labelCostFlat.Text + " : " + cost.ToString() + ";");
                textBoxFlatInfo.Text = outputLine.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
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
            textBoxDistrict.Text = string.Empty;
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
            textBoxDistrict.ReadOnly = false;
            textBoxNumberFlat.ReadOnly = false;
            textBoxNumberHouse.ReadOnly = false;
            treeViewCountry.CollapseAll();
        }


        private void buttonGetCost_Click(object sender, EventArgs e)
        {
            double footage;
            int amountOfRooms;
            int year;
            string material;
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
            int floor;
            try
            {
                street = textBoxStreet.Text;
                footage = trackBarFootage.Value;
                amountOfRooms = (int)numericUpDownRooms.Value;
                year = dateTimePickerYear.Value.Year;
                floor = (int)numericUpDownFloor.Value;
                material = comboBoxMaterial.Text;
                if (treeViewCountry.SelectedNode == null)
                    throw new Exception("Выберите страну или город квартиры!");
                else
                    country = treeViewCountry.SelectedNode.Text;
                district = textBoxDistrict.Text;
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
                Flat flat = new Flat(footage, year, material, floor, kitchen, balcony, basement, livingRoom, bathroom, address);
                cost = flat.CountCost();
                textBoxCost.Text = cost.ToString();
                flat.Cost = cost;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void textBoxDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (textBoxDistrict.TextLength > 30)
                textBoxDistrict.ReadOnly = true;    
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
                district = textBoxDistrict.Text;
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
                Flat flat = new Flat(footage, year, material, floor, kitchen, balcony, basement, livingRoom, bathroom, address);
                flat.Cost = cost;
                XmlSerializeWrapper.Serialize(flat, "flat.xml");
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

        private void buttonGetCost_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LimeGreen;
        }

        private void buttonGetCost_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.LightGreen;
        }

        private void trackBarFootage_Scroll(object sender, EventArgs e)
        {
            labelFootage.Text = $"Метраж: {trackBarFootage.Value}  М^2";
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
        }

        private void buttonOutputRoomInfo_Click(object sender, EventArgs e)
        {
            try
            {
                var deserializeRoom = XmlSerializeWrapper.Deserialize<Room>("room.xml");
                StringBuilder roomInfo = new StringBuilder();
                roomInfo.AppendLine($"Название комнаты: {deserializeRoom.Name}");
                roomInfo.AppendLine($"Метраж комнаты: {deserializeRoom.Footage}");
                roomInfo.AppendLine($"Количество окон: {deserializeRoom.AmountWindows}");
                roomInfo.AppendLine($"Сторона окон: {deserializeRoom.SideWindows}");
                textBoxRoomInfo.Text = roomInfo.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
