using System;

namespace Hops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var elem = n.Split(", ");
            int[] nums = new int[elem.Length];
            for (int i = 0; i < elem.Length; i++)
            {
                nums[i] = int.Parse(elem[i]);
            }

            var m = int.Parse(Console.ReadLine());
            int maxResult = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                int[] coords = new int[m];
                var stringCoords = Console.ReadLine();
                var coordsElem = stringCoords.Split(", ");
                for (int j = 0; j < coords.Length; j++)
                {
                    coords[i] = int.Parse(coordsElem[i]);
                }

                int currentIndex = 0;
                int currentSum = 0;
                for (int j = 0; j < m; j++)
                {
                    currentIndex += coords[i];
                    if(currentIndex > nums.Length-1 || currentIndex < 0)
                    {
                        break;
                    }
                    currentSum += nums[currentIndex];
                    if (currentSum > maxResult)
                    {
                        maxResult = currentSum;
                    }
                }
            }
            Console.WriteLine(maxResult);
        }
    }
}
