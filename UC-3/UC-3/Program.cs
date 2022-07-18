int IsFullTime = 1;
int IsPartTime = 2;
int empHrs = 0;
int EmpWage = 0;
Random random = new Random();
int EmpWagePerHrs = 20;
int EmpCheck = random.Next(0, 3);
if (EmpCheck == IsFullTime)
{
    empHrs = 8;
}
else if (EmpCheck == IsPartTime)
{

    empHrs = 4;
}
else
{
    empHrs = 0;
}
EmpWage = empHrs * EmpWagePerHrs;
Console.WriteLine("Employees wage is: " + EmpWage);