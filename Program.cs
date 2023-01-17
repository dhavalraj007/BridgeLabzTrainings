using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WageComputation.DailyWage();
            WageComputation.MonthlyWage();
            WageComputation.conditionalMonthlyWage();

            System.Console.WriteLine(LineCompare.LineLength(1,2,3,4));
            System.Console.WriteLine(LineCompare.AreLinesEqual(1,2,3,4,1,2,3,4));
            LineCompare.WhichIsGreater(1,2,3,4,2,3,4,5); 

            
        }
    }
}

