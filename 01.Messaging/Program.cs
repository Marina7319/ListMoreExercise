using System;
using System.Linq;
using System.Collections.Generic;
namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string input = Console.ReadLine();
            List<string> inputString = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                inputString.Add(input[i].ToString());
            }
            string inputToString = input.ToString();
            string letters = "";
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int digit = numbers[i];
                while (digit > 0)
                {
                    int currNum = digit % 10;
                    sum += currNum;
                    digit = digit / 10;
                }
                int sumLetterInText = sum % (input.Length);
                letters += inputString[sumLetterInText];
                inputString.Remove(inputString[sumLetterInText]);
                sum = 0;
            }
            Console.Write(string.Join("", letters));
        }
    }
}
