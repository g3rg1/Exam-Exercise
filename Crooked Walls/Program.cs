using System;

namespace Crooked_Walls
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringSequence = Console.ReadLine();
            char separator = ' ';
            
            string[] stringNums = stringSequence.Split(separator);
            int[] nums = new int[stringNums.Length];
            int[] distanceValues = new int[nums.Length - 1];
            int[] finalValues = distanceValues;

            for (int i = 0; i <= stringNums.Length-1; i++)
            {
                nums[i] = int.Parse(stringNums[i]);
            }
            
            for (int i = 0; i < nums.Length-2; i++)
            {
                int a = nums[i];
                int b = nums[i + 1];

                distanceValues[i] = Math.Abs(Math.Max(a, b) - Math.Min(a, b));
            }

            for (int i = 0; i < finalValues.Length-2; i++)
            {
                if(distanceValues[i] == 0)
                {
                    continue;
                }

                if(distanceValues[i]%2==0)
                {
                    finalValues[i + 1] = 0;
                    i++;
                }
            }

            int result = 0;
            for (int i = 0; i < finalValues.Length-1; i++)
            {
                if(finalValues[i]%2==0)
                {
                    result += finalValues[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
