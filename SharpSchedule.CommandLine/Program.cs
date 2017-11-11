using System;

namespace SharpSchedule.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            DayInMonthTemporalExpression dim = 
                new DayInMonthTemporalExpression(DayOfWeek.Monday, 3);

            Console.WriteLine("11/20/17: {0}", dim.DoesOccurOnDate(new DateTime(2017, 11, 20)));

            Console.ReadLine();
        }
    }
}
