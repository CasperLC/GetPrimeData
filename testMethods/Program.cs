using PrimeDataHelper;
using PrimeDataHelper.Models;
using System;
using System.Collections.Generic;

namespace testMethods
{
    class Program
    {
        private static GetPrimeData primeGetter = new GetPrimeData(new PrimeDBContext());
        static void Main(string[] args)
        {
            Console.WriteLine("GetAllRanges");
            var primeRanges = primeGetter.GetAllRanges();
            primeRanges.ForEach(range =>
            {
                Console.WriteLine("Interval: " + range.Input1 + " - " + range.Input2 + ": " + range.NumOfPrimes);
            });

            Console.WriteLine("\nGetBySingleRange");
            var range = primeGetter.GetBySingleRange(1, 25);
            Console.WriteLine("Interval: " + range.Input1 + " - " + range.Input2 + ": " + range.NumOfPrimes);

            Console.WriteLine("\nGetAllSingleInput");
            var primes = primeGetter.GetAllSingleInput();
            primes.ForEach(prime =>
            {
                Console.WriteLine("Input: " + prime.Input + " is a Prime: " + prime.IsPrime);
            });

            Console.WriteLine("\nGetByInput");
            var prime = primeGetter.GetByInput(2);
            Console.WriteLine("Input: " + prime.Input + " is a Prime: " + prime.IsPrime);

            Console.ReadLine();
        }
    }

    
}
