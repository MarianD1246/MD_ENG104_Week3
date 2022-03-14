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
            //int[] bills = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };    If the requirement was for coins only uncomment this and comment out above value

            StringBuilder billsInSum = new();
            int valueInSum = 0;
            foreach (int bill in bills)
            {
                valueInSum = (int)(lSum / bill); //nr of bills bill in sum
                if (valueInSum > 0)
                {
                    lSum -= bill * valueInSum;
                    if (bill > 50)
                        billsInSum.Append($"- {valueInSum} `£{(decimal)bill / 100}`\n");
                    else
                        billsInSum.Append($"- {valueInSum} `{(decimal)bill}p`\n");
                    if (lSum == 0)
                        break;
                }
            }

            return billsInSum.ToString().Trim('\n');
        }

    }
}
