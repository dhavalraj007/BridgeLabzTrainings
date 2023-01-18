namespace MyApp
{
    class WageComputation
    {
        public String companyName {get;}
        public int wagePerHour{get;}
        public int workingDaysAMonth {get;}
        public int maxHoursAMonth{get;}
        
        public int totalWage;
        public List<int> dailyWages;
        public WageComputation(String _name,int _wagePerHour,int _workingDaysAMonth,int _maxHoursAMonth)
        {
            companyName = _name;
            wagePerHour = _wagePerHour;
            workingDaysAMonth = _workingDaysAMonth;
            maxHoursAMonth = _maxHoursAMonth;
            totalWage=0;
            dailyWages = new List<int>();
        }
    }

    public interface IComputeEmpWage
    {
        public void addCompany(String _name,int _wagePerHour,int _workingDaysAMonth,int _maxHoursAMonth);
        public void ComputeConditionalMonthlyWage();
        public int GetTotalWage(String company);
    }
    class EmpWageBuilder:IComputeEmpWage
    {

        List<WageComputation> companies;
        Dictionary<String,WageComputation> comp2Obj;

        public EmpWageBuilder()
        {
            companies = new List<WageComputation>();
            comp2Obj = new Dictionary<string, WageComputation>();
            Console.WriteLine("Welcome to Employee Wage Computation");
        }

        public void addCompany(String _name,int _wagePerHour,int _workingDaysAMonth,int _maxHoursAMonth)
        {
            var compobj = new WageComputation(_name,_wagePerHour,_workingDaysAMonth,_maxHoursAMonth);
            companies.Add(compobj);
            comp2Obj[_name] = compobj;
        }
        public void ComputeConditionalMonthlyWage()
        {
            foreach(WageComputation comp in companies)
            {
                int wageSum = 0;
                int hours = 0;
                for(int i=0;i<comp.workingDaysAMonth;i++)
                {
                    var wage = _DailyWage(comp,out int workHours);
                    comp.dailyWages.Add(wage);
                    wageSum+= wage;
                    hours+=workHours;
                    if(hours>comp.maxHoursAMonth)
                        break;
                }
                comp.totalWage = wageSum;
                //Console.WriteLine(comp.companyName +": Conditional Monthly wage is " + comp.totalWage);
            }
        }

        public int GetTotalWage(String company)
        {
            return comp2Obj[company].totalWage;
        }

        public List<int> GetDailyWages(String company)
        {
            return comp2Obj[company].dailyWages;
        }
        private int _DailyWage(WageComputation comp)
        {
            return _DailyWage(comp,out int workHours);
        }
        private int _DailyWage(WageComputation comp,out int workHours)
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
            
            int wage = comp.wagePerHour*workHours;
            return wage;
        }
    }
}