using System;
using System.Linq;
using System.Collections.Generic;
namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> timeOfTwoRacers = Console.ReadLine().Split(separator: " ").Select(int.Parse).ToList();
            double left = 0;
            double right = 0;
            for (int i = 0; i < timeOfTwoRacers.Count / 2; i++)
            {
                if (timeOfTwoRacers[i] != 0)
                {
                    left += timeOfTwoRacers[i];
                }
                else
                {
                    left *= 0.8;
                }
            }
            for (int j = timeOfTwoRacers.Count - 1; j > timeOfTwoRacers.Count / 2; j--)
            {
                if (timeOfTwoRacers[j] != 0)
                {
                    right += timeOfTwoRacers[j];
                }
                else
                {
                    right *= 0.8;
                }
            }
            if (left < right)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(left, 2)}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(right, 2)}");
            }
        }
    }
}
