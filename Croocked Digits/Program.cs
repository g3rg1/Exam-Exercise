using System;

namespace Croocked_Digits
{
    class Program
    {
        public static decimal SumNumbers(decimal N)
        {
            decimal result = 0;
            string stringNum = N.ToString();
            while(true)
            {
                for (int i = 0; i <= stringNum.Length - 1; i++)
                {
                    if (stringNum[i] == '.')
                    {
                        continue;
                    }

                    result += int.Parse(stringNum[i].ToString());
                }
                if(result <= 9)
                {
                    break;
                }
                else
                {
                    stringNum = result.ToString();
                    result = 0;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            var N = Math.Abs(decimal.Parse(Console.ReadLine()));
            decimal tempValue = SumNumbers(N);
            N = tempValue;
            Console.WriteLine(N);
        }
    }
}
