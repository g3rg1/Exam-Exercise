using System;

namespace Yesterday
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            string[] months = {
                "Jan", "Feb", "Mar","Apr",
                "May","Jun", "Jul", "Aug",
                "Sep","Oct", "Nov", "Dec" };
            
            DateTime currentDate = new DateTime(year, month, day);
            currentDate = currentDate.AddDays(-1);
            int monthIndex = currentDate.Month;
            string currentMonth = months[monthIndex - 1];

            Console.WriteLine($"{currentDate.Day}-{currentMonth}-{currentDate.Year}");
        }
    }
}
