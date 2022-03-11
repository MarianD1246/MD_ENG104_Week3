using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string itemsInQueue = "";

            if (queue.Count < num) 
                num = queue.Count;

            for (int i = 0; i < num ; i++)
            {
                itemsInQueue += queue.Dequeue() + ", "; ;
            }

            return itemsInQueue.Trim(' ', ',');
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            if (original == null || original.Length == 0 || original.Length == 1) 
                return original; 

            Stack<int> arrayStack = new Stack<int>(original);
            int[] reversedArray = new int[original.Length];

            for (int i =0; i < original.Length; i++)
            {
                reversedArray[i] = arrayStack.Pop();
            }
            return reversedArray;
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> digits = new Dictionary<char, int>();

            foreach (char c in input){
                if (char.IsDigit(c) && digits.ContainsKey(c))
                {
                    digits[c]++;
                }
                else if (char.IsDigit(c) && !digits.ContainsKey(c))
                {
                    digits.Add(c, 1);   
                }
            }
            StringBuilder dictFlat = new();
            foreach(var b in digits)
            {
                dictFlat.Append(b);
            }
            return dictFlat.ToString();        }
    }
}
