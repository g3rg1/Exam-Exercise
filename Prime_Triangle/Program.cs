using System;
using System.Collections.Generic;

namespace Prime_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            var primes = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {
                    if(i != j && i % j==0)
                    {
                        isPrime = false;
                    }
                }
                if(isPrime)
                {
                    primes.Add(i);
                }
                isPrime = true;
            }
            for (int i = 1; i <= primes.Count; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    isPrime = false;
                    foreach (var prime in primes)
                    {
                        if(j == prime)
                        {
                            isPrime = true;
                        }
                    }
                    if(isPrime)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
