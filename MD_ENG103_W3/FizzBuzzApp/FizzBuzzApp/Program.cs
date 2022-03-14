using System;
using System.Text;

namespace FizzBuzzApp;

public class Program
{

    public static void Main(string[] args)
    {
        //string numbers = "//[***][%%%][$$$]\n1***2%%%3$$$4";
        //char delimiter = ',';
        //string newNumbers = numbers.Trim('/');
        //string newDelimiter = "";
        //if (!char.IsDigit(newNumbers[0]))
        //    delimiter = newNumbers[0];
        //while (delimiter == '[')
        //{
        //    int indexStart = newNumbers.IndexOf('[') + 1,
        //        indexEnd = newNumbers.IndexOf(']') - indexStart;
        //    newDelimiter = newNumbers.Substring(indexStart, indexEnd);
        //    StringBuilder sb = new();
        //    sb.Append(newNumbers);
        //    sb.Remove(indexEnd + 1, 1); // ]
        //    sb.Remove(indexStart - 1, 1); // [
        //    sb.Replace(newDelimiter, ",");
        //    sb.Remove(indexStart - 1,1);
        //    newNumbers = sb.ToString();
        //    if (!newNumbers.Contains(delimiter)) //[
        //        delimiter = ',';
        //}
        //Console.WriteLine("\nexit!" + newNumbers);

        Dictionary<char, int> romanNumeral = new Dictionary<char, int>() {
                { 'M', 1000 }, { 'D', 500 }, { 'C', 100 },
                { 'L', 50 }, { 'X', 10 }, {'V', 5}, {'I', 1}
        };
        Dictionary<string, string> romanNumeralCases = new Dictionary<string, string>() {
                {"IIII", "IV"}, {"VIV", "IX"}, {"XXXX", "XL"},
                {"LXL", "XC"}, {"CCCC", "CD"}, {"DCD", "CM"},
        };

        string def = "";
        bool isOnce = true;
        int num = 0;
        bool success = true;
        while (success)
        {
            Console.WriteLine("Enter a number:");
            string rl = Console.ReadLine();
            success = int.TryParse(rl, out num);
            if (success)
            {
                StringBuilder romanSumLoose = new();
                foreach (KeyValuePair<char, int> rn in romanNumeral)
                {
                    int rnInNum = num / rn.Value;
                    if (rnInNum >= 0)
                    {
                        romanSumLoose.Append(new string(rn.Key, rnInNum));
                        num -= rn.Value * rnInNum;
                    }
                }
                string romanSum = romanSumLoose.ToString();
                def = romanSum;

                foreach (var rnc in romanNumeralCases)
                {
                    romanSum = RomanNumeralCorrection(rnc.Key, rnc.Value, romanSumLoose, romanSum);
                }
                if (!isOnce)
                {
                    Console.WriteLine(def);
                    Console.WriteLine(romanSumLoose.ToString());
                }
                else if (isOnce)
                {
                    Console.WriteLine($"{def}  <= Loose");
                    Console.WriteLine($"{romanSumLoose.ToString()}  <= Compresed");
                    isOnce = !isOnce;
                }
                romanSumLoose.Clear();
                romanSum = "";
            }
        }

        //double sum = 99.99;
        //sum = Math.Round(sum, 2) * 100;
        //long lSum = (long)sum;
        //int[] bills = new int[]{ 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };


        //StringBuilder billsInSum = new();
        //foreach (int bill in bills)
        //{
        //    int valueInSum = (int)(lSum / bill);
        //    if (valueInSum > 0)
        //    {
        //        lSum -= bill * valueInSum;
        //        billsInSum.Append($"- {valueInSum} `£{(decimal)bill / 100}`\n");
        //        if (lSum == 0)
        //            break;
        //    }
        //}

        //Console.WriteLine(billsInSum.ToString().Trim('\n'));

    }


    public static string RomanNumeralCorrection(string check,string replace, StringBuilder generatedString, string generateTo)
    {
        if (generateTo.Contains(check))
        {
            generatedString.Replace(check, replace);
        }
        return generatedString.ToString();
    }

    //public static string FizzBuzzLogic(int n1, int n2, int range)
    //{
    //    StringBuilder fizzBuzzBuild = new();
    //    for (int i = 0; i < range; i++)
    //    {
    //        if (range % n1 == 0 && range % n2 == 0)
    //        {
    //            fizzBuzzBuild.Append("FizzBuzz");
    //        }
    //        else if (range % n1 == 0)
    //        {
    //            fizzBuzzBuild.Append("Buzz");
    //        }
    //        else if (range % n2 == 0)
    //        {
    //            fizzBuzzBuild.Append("Fizz");
    //        }
    //        else
    //        {
    //            fizzBuzzBuild.Append(i);
    //        }
    //    }
    //    return fizzBuzzBuild.ToString();
    //}

    public static string FizzBuzz(int input)
    {
        StringBuilder output = new StringBuilder();

        //if (input % 3 == 0) { output.Append("Fizz"); }
        //if (input % 5 == 0) { output.Append("Buzz"); }
        //if (input % 3 != 0 && input % 5 != 0) { output.Append(input); }
        //return output.ToString();
        //on liner using string builder
        return new StringBuilder(input % 15 == 0 ? "FizzBuzz" : input % 5 == 0 ? "Buzz" :
            input % 3 == 0? "Fizz" : input.ToString()).ToString();
    }
}