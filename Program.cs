using System;

namespace EmpWage
{
    class Program
    {
        //UC6
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int emp_hr_per_rate = 20;
        public const int num_of_working_days = 20;
        public const int max_hr_month = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int Emp_wage = 0;
            int empHr = 0;
            int totalEmpHr = 0;
            int totalworkingDays = 0;
            while (totalEmpHr <= max_hr_month && totalworkingDays < num_of_working_days)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case is_part_time:
                        empHr = 4;
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Part time");
                        break;
                    case is_full_time:
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Full time");
                        empHr = 8;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHr = 0;
                        break;
                }

                totalEmpHr += empHr;
                Console.WriteLine("Days = " + totalworkingDays + " EmpHRS " + empHr);

                Emp_wage = (emp_hr_per_rate * empHr);
                Console.WriteLine("Daily wage " + Emp_wage);
            }
            int totalEmpwage = (emp_hr_per_rate * totalEmpHr);
            Console.WriteLine("Total Emp Wage: " + totalEmpwage);
        }

    }
}
