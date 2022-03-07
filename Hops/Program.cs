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
                var stringCoords = Console.ReadLine();
                var coordsElem = stringCoords.Split(", ");
                int[] coords = new int[coordsElem.Length];
                for (int j = 0; j < coords.Length; j++)
                {
                    coords[j] = int.Parse(coordsElem[j]);
                }

                int currentIndex = 0;
                int currentSum = nums[0];
                for (int j = 0; j < m; j++)
                {
                    currentIndex += coords[j];
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
