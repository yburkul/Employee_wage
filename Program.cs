Console.WriteLine("Welcome to Employee Wage Computation Program");

//UC3
int Present = 1; //Constant
int Fulltime = 1;
int Emp_per_rate = 20;
int EmpHr = 0;
int Emp_wage = 0;
Random random = new Random(); //Computation // to create object
Random random1 = new Random(); // creating second object
int EmpStatus = random.Next(0, 2);
int Emp_Time = random1.Next(0, 2);
if (EmpStatus == Present)
{
    if (Emp_Time == Fulltime)
    {
        Console.WriteLine("Employee is Present");
        EmpHr = 8;
    }
    else
    {
        Console.WriteLine("Employee is Present");
        EmpHr = 4;
    }
}
else
{
    Console.WriteLine("Employee is Absent");
    EmpHr = 0;
}
Emp_wage = (Emp_per_rate * EmpHr);
Console.WriteLine("Daily wage " + Emp_wage);