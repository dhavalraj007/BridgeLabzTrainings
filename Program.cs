using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // WageComputation GEwageComputation = new WageComputation("GE", 40, 20, 100);
            // GEwageComputation.DailyWage();
            // GEwageComputation.MonthlyWage();
            // GEwageComputation.conditionalMonthlyWage();

            // System.Console.WriteLine("");

            // WageComputation RelianceWageComputation = new WageComputation("Reliance", 20, 30, 140);
            // RelianceWageComputation.DailyWage();
            // RelianceWageComputation.MonthlyWage();
            // RelianceWageComputation.conditionalMonthlyWage();


            //uncomment this to play Snake and Ladder.
            SnakeLadder sl = new SnakeLadder();
            while (!sl.finished)
            {
                System.Console.WriteLine("\nPlayer 1's turn. Press Enter to Roll and Move.");
                Console.ReadLine();
                sl.Player1RollMove();
                if (sl.finished) break;
                System.Console.WriteLine("\nPlayer 2's turn. Press Enter to Roll and Move.");
                Console.ReadLine();
                sl.Player2RollMove();
            }
        }
    }
}

