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
            string newDelimiter = "";
            string newNumbers = numbers.Trim('/');

            if (!char.IsDigit(newNumbers[0]))
                delimiter = newNumbers[0];

            while (delimiter == '[')
            {
                int indexStart = newNumbers.IndexOf('[') + 1,
                    indexEnd = newNumbers.IndexOf(']') - indexStart;
                newDelimiter = newNumbers.Substring(indexStart, indexEnd);
                
                StringBuilder sb = new(newNumbers);

                sb.Replace(newDelimiter, ",");
                sb.Remove(0, 3); // Removes Bracketed delimiter
                newNumbers = sb.ToString();

                newNumbers = sb.ToString();

                if (!newNumbers.Contains(delimiter)) //Multiple Delimiter Check
                    delimiter = ',';
            }

            string[] nums = newNumbers.Split('\n', delimiter);

            int sum = 0;
            StringBuilder negatives = new();
            foreach (string num in nums)
            {
                bool isDigit = int.TryParse(num, out int digit);
                if (isDigit)
                {
                    if(digit < 0)
                    {
                        negatives.Append($"{digit} ");
                    }
                    if (digit <= 1000)
                        sum += digit;
                }
                else if (num.Contains("--"))
                {
                    string newNum = num.Trim('-');
                    bool success = int.TryParse(newNum, out int negativNum);
                    if (success)
                    {
                        if (negativNum < 1000)
                            sum += negativNum;
                    }
                }
            }
            if(negatives.Length > 0)
            {
                throw new ArgumentOutOfRangeException(($"negatives not allowed : {negatives}").Trim());
            }
            return sum;
            
        }
    }
}
