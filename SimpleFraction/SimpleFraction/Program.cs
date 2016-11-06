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
                try
                {
                    var tempSimpleFraction = new SimpleFraction(rnd.Next(), rnd.Next());

                    listOfSimpleFractions.Add(tempSimpleFraction);
                }
                catch (DivideByZeroException exception)
                {
                    Console.WriteLine($"When we try to add {i} random fraction error occurred:\n{exception.Message}");
                }
                finally
                {
                    Console.WriteLine("We try again to create valid random fraction");
                    i--;
                }
                
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
