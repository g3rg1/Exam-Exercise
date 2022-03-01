using System;

namespace Croocked_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var frstBrick= int.Parse(Console.ReadLine());
            var scndBrick = int.Parse(Console.ReadLine());
            var thrdBrick = int.Parse(Console.ReadLine());
            var L = int.Parse(Console.ReadLine());
            var nextBrick = 0;
            Console.WriteLine($" {frstBrick}");
            Console.WriteLine($" {scndBrick} {thrdBrick}");
            for (int i = 0; i < L-2; i++)
            {
                for (int j = 0; j <= i+2; j++)
                {
                    nextBrick = frstBrick + scndBrick + thrdBrick;
                    frstBrick = scndBrick;
                    scndBrick = thrdBrick;
                    thrdBrick = nextBrick;
                    Console.Write($" {nextBrick}");
                }
                Console.WriteLine();
            }
        }
    }
}
