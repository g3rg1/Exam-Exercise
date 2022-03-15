using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            int maxSum = 0;
            int curentSum = 0;
            var nums = new int[3];
            for (int i = 0; i < n.Length; i++)
            {
                nums[i] = int.Parse(n[i].ToString());
            }
            curentSum = nums[0] + nums[1] + nums[2];
            if (curentSum > maxSum)
            {
                maxSum = curentSum;
            }
            curentSum = nums[0] * nums[1] * nums[2];
            if (curentSum > maxSum)
            {
                maxSum = curentSum;
            }
            curentSum = nums[0] * nums[1] + nums[2];
            if (curentSum > maxSum)
            {
                maxSum = curentSum;
            }
            curentSum = nums[0] + nums[1] * nums[2];
            if (curentSum > maxSum)
            {
                maxSum = curentSum;
            }
            Console.WriteLine(maxSum);
        }
    }
}
