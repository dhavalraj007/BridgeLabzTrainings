using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            EmpWageBuilder builder = new EmpWageBuilder();
            builder.addCompany("GE", 40, 20, 100);
            builder.addCompany("Reliance", 20, 30, 140);
            builder.ComputeConditionalMonthlyWage();
            
            //Total  wages by company name
            System.Console.WriteLine("Total Wage for GE: "+builder.GetTotalWage("GE"));
            System.Console.WriteLine("Total Wage for Reliace: "+builder.GetTotalWage("Reliance"));
            //daily wages by company name
            var compDailywage = builder.GetDailyWages("GE");
            for(int day=0;day<compDailywage.Count();day++)
            {
                System.Console.WriteLine("Wage for Day #"+day+" is "+compDailywage[day]);
            }


            System.Console.WriteLine("\n\n");

            //Line comparison OOP approach
            Line line1 = new Line(1,2,4,5);
            Line line2 = new Line(1,2,3,4);
            if(line1>line2)
                Console.WriteLine("Line 1 is greater");
            else if(line1<line2)
                Console.WriteLine("Line 2 is Greater");
            else
                Console.WriteLine("Lines are Same");
            
            
            //Sorting Lines
            Line line3 = new Line(1,2,5,6);
            Line line4 = new Line(1,1,10,10);
            List<Line> list = new List<Line>{line1,line2,line3,line4};
            list.Sort();    //uses CompareTo
            System.Console.WriteLine("\n\nSorted List of Lines according to Length");
            foreach(var line in list)
                System.Console.WriteLine(line.ToString());
        }
    }
}

