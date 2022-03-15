using System;

namespace Merging_and_Squashing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nums = new string[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = Console.ReadLine();
            }
            var mergedNums = new string[n-1];
            var squashedNums = new string[n-1];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                mergedNums[i] = Convert.ToString(nums[i][1].ToString() + nums[i + 1][0].ToString());

                int firstNum = int.Parse(nums[i][1].ToString());
                int secNum = int.Parse(nums[i + 1][0].ToString());
                int squashedNum = firstNum + secNum;
                string squashedString = Convert.ToString(squashedNum);
                if(squashedString.Length > 1)
                {
                    squashedString = squashedString[1].ToString();
                }
                squashedNums[i] = Convert.ToString(nums[i][0] + squashedString + nums[i + 1][1]);
            }
            Console.WriteLine(string.Join(' ', mergedNums));
            Console.WriteLine(string.Join(' ', squashedNums));
        }
    }
}
