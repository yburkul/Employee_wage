using System;

namespace Employeewage
{
    class Company
    {
        //UC8
        public float EmpWagePerHour = 20;
        public int FullTime_WorkingHrs_PerDay = 8;
        public int PartTime_WorkingHrs_PerDay = 4;
        public int MAX_WORKING_HRS = 100;
        public int MAX_WORKING_DAYS = 20;
        public String CompanyName;

        public Company(String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHour = EmpWagePerHour;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHrs_PerDay;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;

        }
    }

    class EmpoyeeWageComputation
    {
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        private float TotalWage = 0;
        private Dictionary<String, Company> Companies = new Dictionary<string, Company>();

        private void AddCompany(String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerHour, FullTime_WorkingHrs_PerDay, PartTime_WorkingHrs_PerDay, MAX_WORKING_HRS, MAX_WORKING_DAYS);
            Companies.Add(CompanyName.ToLower(), company);
        }

        private int IsEmployeePresent()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            return empcheck;
        }

        public void CalculateWage(string CompanyName)
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;
            //int WorkingDay = 0;
            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentException("company don't exist");
            Companies.TryGetValue(CompanyName.ToLower(), out Company company);
            while (DayNumber <= company.MAX_WORKING_DAYS && TotalWorkingHrs <= company.MAX_WORKING_HRS)
            {
                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpWorkingHrs = 0;
                        break;
                    case IS_PART_TIME:
                        EmpWorkingHrs = company.PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkingHrs = company.FullTime_WorkingHrs_PerDay;
                        break;
                }

                EmpDailyWage = EmpWorkingHrs * company.EmpWagePerHour;
                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;
            }
            Console.WriteLine("\nCompany name: " + CompanyName);
            Console.WriteLine("Total working days :" + (DayNumber) + "\nTotal working hours : " + TotalWorkingHrs + "\nTotal employee wage : " + TotalWage);
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            EmpoyeeWageComputation employeeWageComputation = new EmpoyeeWageComputation();
            employeeWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeWageComputation.AddCompany("Mahindra", 30, 8, 4, 100, 20);
            employeeWageComputation.CalculateWage("TATA");
            employeeWageComputation.CalculateWage("Mahindra");
        }
    }
}

