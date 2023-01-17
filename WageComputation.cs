namespace MyApp
{
    class WageComputation
    {
        String companyName;
        int wagePerHour;
        int workingDaysAMonth;
        int maxHoursAMonth;
        public WageComputation(String _name,int _wagePerHour,int _workingDaysAMonth,int _maxHoursAMonth)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            companyName = _name;
            wagePerHour = _wagePerHour;
            workingDaysAMonth = _workingDaysAMonth;
            maxHoursAMonth = _maxHoursAMonth;
        }

        public void DailyWage()
        {    
            Console.WriteLine(companyName +": Daily wage is " + _DailyWage());
        }
        public void MonthlyWage()
        {
            int wageSum = 0;
            for(int i=0;i<20;i++)
            {
                wageSum+= _DailyWage();
            }
            Console.WriteLine(companyName +": Monthly wage is " + wageSum);
        }

        public void conditionalMonthlyWage()
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
            Console.WriteLine(companyName +": Conditional Monthly wage is " + wageSum);
        }

        private int _DailyWage()
        {
            return _DailyWage(out int workHours);
        }
        private int _DailyWage(out int workHours)
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