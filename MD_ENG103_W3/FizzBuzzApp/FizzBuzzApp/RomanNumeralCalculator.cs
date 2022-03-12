using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace FizzBuzzApp
{
    public class RomanNumeralCalculator
    {
        public static string NumToRomanNumConverter(int num)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException(num == 0 ? "There is no Roman numberal for 0." :
                    "The Roman numeral system doesn't have a negative number system.");
            }

            Dictionary<char, int> romanNumeral = new() {
                { 'M', 1000 }, { 'D', 500 }, { 'C', 100 },
                { 'L', 50 }, { 'X', 10 }, {'V', 5}, {'I', 1} };
            Dictionary<string, string> romanNumeralCases = new() {
                {"IIII", "IV"}, {"VIV", "IX"}, {"XXXX", "XL"},
                {"LXL", "XC"}, {"CCCC", "CD"}, {"DCD", "CM"},};

            StringBuilder romanSumLoose = new();
            foreach (KeyValuePair<char, int> rn in romanNumeral)
            {
                int rnInNum = num / rn.Value;
                if (rnInNum > 0)
                {
                    romanSumLoose.Append(new string(rn.Key, rnInNum));
                    num -= rn.Value * rnInNum;

                    if (num == 0)
                        break;
                }
            }

            foreach (KeyValuePair<string, string> rnc in romanNumeralCases)
                if (romanSumLoose.ToString().Contains(rnc.Key))
                    romanSumLoose.Replace(rnc.Key, rnc.Value);

            return romanSumLoose.ToString();
        }

    }
}
