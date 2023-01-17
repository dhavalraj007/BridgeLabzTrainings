namespace MyApp
{
    class WageComputation
    {
        static int wagePerHour = 20;
        static WageComputation()
        {
             Console.WriteLine("Welcome to Employee Wage Computation");
        }

        public static void DailyWage()
        {    
            Console.WriteLine("Daily wage is " + _DailyWage());
        }
        public static void MonthlyWage()
        {
            int wageSum = 0;
            for(int i=0;i<20;i++)
            {
                wageSum+= _DailyWage();
            }
            Console.WriteLine("Monthly wage is " + wageSum);
        }

        public static void conditionalMonthlyWage()
        {
            int wageSum = 0;
            int hours = 0;
            for(int i=0;i<20;i++)
            {
                wageSum+= _DailyWage(out int workHours);
                hours+=workHours;
                if(hours>100)
                    break;
            }
            Console.WriteLine("Conditional Monthly wage is " + wageSum);
        }

        private static int _DailyWage()
        {
            return _DailyWage(out int workHours);
        }
        private static int _DailyWage(out int workHours)
        {
            Random random = new Random();
            int rand = random.Next(0,3);
            switch (rand)
            {
                case 0:
                    //Console.WriteLine("Absent");
                    workHours = 0;
                    break;
                case 1:
                    //Console.WriteLine("Present");
                    workHours = 8;
                    break;
                case 2:
                    //Console.WriteLine("Present (Part time)");
                    workHours = 4;
                    break;
                default:
                    workHours=0;
                    break;
            }
            
            int wage = wagePerHour*workHours;
            return wage;
        }



    }
}