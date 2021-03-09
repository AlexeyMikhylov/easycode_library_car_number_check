using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class CarNumberCheck
    {
        public bool CarNumber(string number)
        {
            string CommonLetters = "ABEKMHOPCTYX";
            string digits = number.Substring(1, number.Length - 3);
            string letters = number.Remove(1, 3);
            bool IsNumeric = int.TryParse(digits, out _);

            if (number.Length == 6 && IsNumeric == true &&
                CommonLetters.Contains(letters[0]) && 
                CommonLetters.Contains(letters[1]) &&
                CommonLetters.Contains(letters[2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
