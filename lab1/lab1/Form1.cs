using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public bool shoeSize = false;
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxOriginal.Text))
                {
                    throw new Exception("Поле \"Длина стопы\" должно быть заполнено!");
                }
                if (textBoxConverted.Text != String.Empty && !(shoeSize))
                {
                    throw new Exception("Поле \"Размер обуви\" должно быть пустым!");
                }
                if (String.IsNullOrEmpty(comboBoxOriginal.Text))
                {
                    throw new Exception("Выберите единицы измерения под полем \"Длина стопы\"!");
                }
                if (String.IsNullOrEmpty(comboBoxConverted.Text))
                {
                    throw new Exception("Выберите какой размер обуви вы хотите получить!");
                }
                shoeSize = true;
                double originalValue = Convert.ToDouble(textBoxOriginal.Text);
                double convertedValue = 0;
                switch (comboBoxOriginal.Text)
                {
                    case "Миллиметр (мм)":
                        switch (comboBoxConverted.Text)
                        {
                            case "США (US)":
                                textBoxConverted.Text = calculator.ConvertToUS(originalValue).ToString();
                                break;
                            case "Европа (EUR)":
                                textBoxConverted.Text = calculator.ConvertToEUR(originalValue).ToString();
                                break;
                            case "Великобритания (UK)":
                                textBoxConverted.Text = calculator.ConvertToUK(originalValue).ToString();
                                break;
                            case "Россия (RUS)":
                                textBoxConverted.Text = calculator.ConvertToRUS(originalValue).ToString();
                                break;
                        }
                        break;
                    case "Сантиметр (см)":
                        originalValue *= 10;
                        switch (comboBoxConverted.Text)
                        {
                            case "США (US)":
                                textBoxConverted.Text = calculator.ConvertToUS(originalValue).ToString();
                                break;
                            case "Европа (EUR)":
                                textBoxConverted.Text = calculator.ConvertToEUR(originalValue).ToString();
                                break;
                            case "Россия (RUS)":
                                textBoxConverted.Text = calculator.ConvertToRUS(originalValue).ToString();
                                break;
                            case "Великобритания (UK)":
                                textBoxConverted.Text = calculator.ConvertToUK(originalValue).ToString();
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBoxOriginal_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string text = tb.Text;
            double number;
            bool flag;
            if (Double.TryParse(text, out number))
                flag = true;
            else
                flag = false;
            if (tb.Text == String.Empty || !flag)
            {
                tb.BackColor = Color.Tomato;
                buttonConvert.Enabled = false;
            }
            else
            {
                tb.BackColor = Color.OldLace;
                buttonConvert.Enabled = true;
            }
        }

        private void textBoxOriginal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void buttonConvert_MouseHover(object sender, EventArgs e)
        {
            buttonConvert.BackColor = Color.LightGreen;
        }

        private void buttonConvert_MouseLeave(object sender, EventArgs e)
        {
            buttonConvert.BackColor = Color.White;
        }
    }
}
