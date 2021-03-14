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
    public partial class District : Form
    {

        FlatForm flatForm;
        SearchForm searchForm;
        bool flag;
        public District(Form form, bool flag)
        {
            InitializeComponent();
            this.flag = flag;
            if (flag)
                flatForm = (FlatForm)form;
            else if (!flag)
            {
                searchForm = (SearchForm)form;
            }
        }

        private void textBoxAddDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Яa-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.LimeGreen;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.LightGreen;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddDistrict.Text == string.Empty)
                MessageBox.Show($"Введите название района!");
            else
            {
                if (flag)
                {
                    flatForm.comboBoxDistrict.Items.Insert(0, textBoxAddDistrict.Text);
                    flatForm.comboBoxDistrict.Text = textBoxAddDistrict.Text;
                    Hide();
                    MessageBox.Show("Район добавлен в форму!");
                }
                else
                {
                    searchForm.comboBoxDistrict.Items.Insert(0, textBoxAddDistrict.Text);
                    searchForm.comboBoxDistrict.Text = textBoxAddDistrict.Text;
                    searchForm.comboBoxDistrict.SelectedItem = 2;
                    Hide();
                    MessageBox.Show("Район добавлен в форму!"); 
                }
            }

        }
    }
}
