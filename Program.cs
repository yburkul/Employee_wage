using System;

namespace EmpWage
{
    class Program
    {
        //UC5
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int emp_hr_per_rate = 20;
        public const int num_of_working_days = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int empHr = 0;
            int empwage = 0;
            int totalEmpwage = 0;
            for (int day = 0; day < num_of_working_days; day++)
            {
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
                        empHr = 8;
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee is Full time");
                        break;
                    default:
                        empHr = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                empwage = (emp_hr_per_rate * empHr);
                totalEmpwage += empwage;
                Console.WriteLine("Daily emp wage: " + empwage);
            }
            Console.WriteLine("Total Emp Wage: " + totalEmpwage);
        }
    }
}