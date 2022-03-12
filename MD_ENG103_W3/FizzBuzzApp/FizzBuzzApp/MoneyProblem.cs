using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    public class MoneyProblem
    {

        public static string BillConverter(double sum)
        {
            sum = Math.Round(sum, 2) * 100;
            long lSum = (long)sum;
            int[] bills = new int[] { 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            StringBuilder billsInSum = new();
            foreach (int bill in bills)
            {
                int valueInSum = (int)(lSum / bill);
                if (valueInSum > 0)
                {
                    lSum -= bill * valueInSum;
                    billsInSum.Append($"- {valueInSum} `£{(decimal)bill / 100}`\n");
                    if (lSum == 0)
                        break;
                }
            }

            return billsInSum.ToString().Trim('\n');
        }

    }
}
