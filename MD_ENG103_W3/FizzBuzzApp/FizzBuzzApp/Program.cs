using System;
using System.Text;

namespace FizzBuzzApp;

public class Program
{ 

    public static void Main(string[] args)
    {
        string numbers = "//[***][%%%][$$$]\n1***2%%%3$$$4";
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
            sb.Remove(indexStart - 1,1);
            newNumbers = sb.ToString();
            if (!newNumbers.Contains(delimiter)) //[
                delimiter = ',';
        }
        Console.WriteLine("\nexit!" + newNumbers);


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