using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6_7
{
    /// <summary>
    /// Логика взаимодействия для UserTBox_clear.xaml
    /// </summary>
    public partial class UserTBox_clear : UserControl
    {
        public UserTBox_clear()
        {
        //    SetText = "none";
            InitializeComponent();
        }
/*
        public static readonly DependencyProperty SetTextProperty;

        static UserTBox_clear()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            SetTextProperty = DependencyProperty.Register("SetText", typeof(string), typeof(UserTBox_clear), metadata, new ValidateValueCallback(ValidateValue));
        }

        public static bool ValidateValue(object value)
        {
            string currentValue = (string)value;
            if (currentValue.Length <= 30)
                return true; 
            return false;
        }

        public string SetText
        {
            get { return (string)GetValue(SetTextProperty); }
            set { SetValue(SetTextProperty, value); }
        } 

        private static void OnSetTextChanged(DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            UserTBox_clear userTBox_Clear = d as UserTBox_clear;
            userTBox_Clear.OnSetTextChanged(e);
        }

        private void OnSetTextChanged(DependencyPropertyChangedEventArgs e)
        {
            userTBox.Text = e.NewValue.ToString();
        }
        */

        private void buttonTBox_Click(object sender, RoutedEventArgs e)
        {
            userTBox.Text = string.Empty;
            userTBox.Focus();
        }
    }
}
