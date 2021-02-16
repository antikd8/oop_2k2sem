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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void buttonSaveInfo_MouseEnter(object sender, EventArgs e)
        {
            buttonSaveInfo.BackColor = Color.LimeGreen;
        }

        private void buttonSaveInfo_MouseLeave(object sender, EventArgs e)
        {
            buttonSaveInfo.BackColor = Color.LightGreen;
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.OrangeRed;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Tomato;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Яa-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar!=32)
            {
                e.Handled = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBarRoomFootage_Scroll(object sender, EventArgs e)
        {
            labelRoomFootageValue.Text = trackBarRoomFootage.Value.ToString();
        }

        private void buttonSaveInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room();
                room.Footage = trackBarRoomFootage.Value;
                room.Name = textBoxRoomName.Text;
                room.AmountWindows = (int)numericUpDownAmountWindows.Value;
                if (radioButtonNorth.Checked)
                    room.SideWindows = radioButtonNorth.Text;
                if (radioButtonEast.Checked)
                    room.SideWindows = radioButtonEast.Text;
                if (radioButtonSouth.Checked)
                    room.SideWindows = radioButtonSouth.Text;
                if (radioButtonWest.Checked)
                    room.SideWindows = radioButtonWest.Text;
                XmlSerializeWrapper.Serialize(room, "room.xml");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                MessageBox.Show($"Данные успешно записаны в файл \"room.xml\"");
            }
        }
    }
}
