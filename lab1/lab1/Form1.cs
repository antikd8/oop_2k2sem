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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                if (Convert.ToDouble(textBoxOriginal.Text) < 0)
                {
                    throw new Exception("Длина стопы должна быть больше 0!");
                }
                if (textBoxConverted.Text != String.Empty && !(shoeSize))
                {
                    throw new Exception("Поле \"Размер обуви\" должно быть пустым!");
                } 
                if (textBoxOriginal.Text == String.Empty)
                {
                    throw new Exception("Заполните поле \"Длина стопы\"!");
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
                catch(Exception ex)
                {
                MessageBox.Show($"{ex.Message}");
                }
        }

        private void labelCalculator_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxOriginal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

    }
}
