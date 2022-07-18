Console.WriteLine("welcome to Employee Management app");
int IsFullTime = 1;
Random random = new Random();
int EmpCheck = random.Next(0, 2);
if (EmpCheck == IsFullTime)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}