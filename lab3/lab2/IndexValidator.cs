using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace lab2
{
    public class IndexAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex regex = new Regex(@"\w+");
            if (regex.IsMatch(value.ToString()))
            {
                return true;
            }
            else return false;
        }
    }
}