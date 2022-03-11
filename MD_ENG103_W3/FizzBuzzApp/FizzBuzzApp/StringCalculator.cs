using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            char delimiter = ',';
            string newNumbers = numbers.Trim('/');
            string newDelimiter = "";
            if (!char.IsDigit(newNumbers[0]))
                delimiter = newNumbers[0];
            while (delimiter == '[')
            {
                int indexStart = newNumbers.IndexOf('[') + 1,
                    indexEnd = newNumbers.IndexOf(']') - indexStart;
                newDelimiter = newNumbers.Substring(indexStart, indexEnd);
                StringBuilder sb = new();
                sb.Append(newNumbers);
                sb.Remove(indexEnd + 1, 1); // ]
                sb.Remove(indexStart - 1, 1); // [
                sb.Replace(newDelimiter, ",");
                sb.Remove(indexStart - 1, 1); // ,
                newNumbers = sb.ToString();
                if (!newNumbers.Contains(delimiter)) //[
                    delimiter = ',';
            }

            string[] nums = newNumbers.Split('\n', delimiter);

            int sum = 0;
            StringBuilder negatives = new StringBuilder();
            foreach (string num in nums)
            {
                bool success = int.TryParse(num, out int a);
                if (success)
                {
                    if(a<0)
                    {
                        negatives.Append($"{a} ");
                    }
                    if (a<=1000)
                        sum += a;
                }
                else if (num.Contains("--"))
                {
                    string newNum = num.Trim('-');
                    bool doubleSuccess = int.TryParse(newNum, out int doubleNegative);
                    if (doubleSuccess)
                    {
                        if (doubleNegative < 1000)
                            sum += doubleNegative;
                    }
                }
            }
            if(negatives.Length > 0)
            {
                throw new ArgumentOutOfRangeException(($"negatives not allowed : {negatives}").Trim());
            }
            return sum;
            // think about "-3" and "--3"
        }
    }
}
