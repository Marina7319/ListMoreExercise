using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.MixedupLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> elementsOne = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> elementsTwo = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            int shorterList = Math.Min(elementsOne.Count, elementsTwo.Count);
            int longerList = Math.Max(elementsOne.Count, elementsTwo.Count);
            double sum = 0;
            List<double> numsList = new List<double>();
            List<double> list = new List<double>();
            if (elementsOne.Count > elementsTwo.Count)
            {
                list.Add(elementsOne[elementsOne.Count - 1]);
                list.Add(elementsOne[elementsOne.Count - 2]);
            }
            else
            {
                list.Add(elementsTwo[0]);
                list.Add(elementsTwo[1]);
            }

            if (list[0] > list[1])
            {
                numsList.Insert(0, list[1]);
                numsList.Insert(1, list[0]);
            }
            else
            {
                numsList.Insert(0, list[0]);
                numsList.Insert(1, list[1]);
            }
            List<double> numList = new List<double>();
            List<double> listFirst = new List<double>();
            List<double> listSecond = new List<double>();
            for (int i = 0; i < elementsOne.Count; i++)
            {
                listFirst.Add(elementsOne[i]);
            }
            for (int j = elementsTwo.Count - 1; j > 0; j--)
            {
                listSecond.Add(elementsTwo[j]);
            }
            int firstCount = 0;
            int secondCount = 0;
            for (int evenNums = 1; evenNums <= listFirst.Count; evenNums++)
            {
                if (evenNums % 2 == 0)
                {
                    firstCount++;
                    numList.Add(listFirst[firstCount]);
                }
            }
            for (int oddNums = 1; oddNums <= listSecond.Count; oddNums++)
            {
                if (oddNums % 2 != 0)
                {
                    secondCount++;
                    numList.Add(listSecond[secondCount]);
                }

            }
            List<double> orderedAsc = new List<double>();
            foreach (int numsInList in numList)
            {
                if (numsInList > numsList[0] && numsInList < numsList[1])
                {
                    orderedAsc.Add(numsInList);
                }
            }
            for (int h = 0; h < orderedAsc.Count; h++)
            {
                for (int x = h + 1; x < orderedAsc.Count; x++)
                {
                    if (orderedAsc[x] < orderedAsc[h])
                    {
                        sum = orderedAsc[x];
                        orderedAsc[x] = orderedAsc[h];
                        orderedAsc[h] = sum;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", orderedAsc));
        }
    }
}
