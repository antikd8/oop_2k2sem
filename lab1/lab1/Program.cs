using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public interface IOperations
    {
        double ConvertToUS(double originalValue);
        double ConvertToEUR(double originalValue);
        double ConvertToRUS(double originalValue);
        double ConvertToUK(double originalValue);
    }

    public class Calculator : IOperations
    {
        public double ConvertToEUR(double originalValue)
        {
            double convertedValue = (originalValue + 2 * (600 / 90)) / (600 / 90) - 4;
            if (convertedValue < 0)
                MessageBox.Show("Длина стопы слишком маленькая!");
            else
                return convertedValue;
            return 0;
        }

        public double ConvertToRUS(double originalValue)
        {
            double convertedValue = (originalValue + 2 * (600 / 90)) / (600 / 90) - 5;
            if (convertedValue < 0)
                MessageBox.Show("Длина стопы слишком маленькая!");
            else
                return convertedValue;
            return 0;
        }

        public double ConvertToUK(double originalValue)
        {
            double convertedValue = ((originalValue + 2 * (762 / 90)) / (762 / 90)) - 25.5;
            if (convertedValue < 0)
                MessageBox.Show("Длина стопы слишком маленькая!");
            else
                return convertedValue;
            return 0;
        }

        public double ConvertToUS(double originalValue)
        {
            double convertedValue = ((originalValue + 2 * (762 / 90)) / (762 / 90)) - 25;
            if (convertedValue < 0)
                MessageBox.Show("Длина стопы слишком маленькая!");
            else
                return convertedValue;
            return 0;
        }

    }
}
