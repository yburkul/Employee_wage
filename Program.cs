Console.WriteLine("Welcome to Employee Wage Computation Program");

//UC2
int Present = 1; //Constant
int Emp_per_rate = 20;
int EmpHr = 0;
int Emp_wage = 0;
Random random = new Random(); //Computation
int EmpStatus = random.Next(0, 2);
if (EmpStatus == Present)
{
    Console.WriteLine("Employee is Present");
    EmpHr = 8;
}
else
{
    Console.WriteLine("Employee is Absent");
    EmpHr = 0;
}
Emp_wage = (Emp_per_rate * EmpHr);
Console.WriteLine("Daily wage " + Emp_wage);