using System;
using System.Collections.Generic;
namespace SimpleFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfSimpleFractions = new List<SimpleFraction>();

            var rnd = new Random(Guid.NewGuid().GetHashCode());

            for (var i = 0; i < 10; i++)
            {
                listOfSimpleFractions.Add(new SimpleFraction(rnd.Next(), rnd.Next()));
            }

            listOfSimpleFractions.Sort();
            
            Console.WriteLine(SumOfAllFractions(listOfSimpleFractions));
            Console.ReadKey();
        }

        private static SimpleFraction SumOfAllFractions(IReadOnlyList<SimpleFraction> listOfSimpleFractions)
        {
            var sumOfAllFractions = listOfSimpleFractions[0];

            for (var i = 1; i < listOfSimpleFractions.Count; i++)
            {
                sumOfAllFractions += listOfSimpleFractions[i];
            }

            return sumOfAllFractions;
        }
    }
}
