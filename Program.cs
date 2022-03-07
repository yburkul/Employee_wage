Console.WriteLine("Welcome to Employee Wage Computation Program");

//UC1
int Present = 1; //Constant
Random random = new Random(); //Computation
int EmpStatus = random.Next(0, 2);
if (EmpStatus == Present)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}
