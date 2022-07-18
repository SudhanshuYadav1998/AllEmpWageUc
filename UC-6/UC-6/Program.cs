Console.WriteLine("welcome to Employee Management app");
int IsFullTime = 1;
int IsPartTime = 2;
int TotalEmpWage = 0;
int NumOfWorkingDays = 20;
int empHrs = 0;
int EmpWage = 0;
int EmpRatePerHrs = 20;
int MaxWorkingHrs = 100;
int TotalDays = 0;
int TotalWorkingHrs = 0;
while (TotalDays < NumOfWorkingDays && TotalWorkingHrs < MaxWorkingHrs)
{
    TotalDays++;
    Random random = new Random();
    int EmpCheck = random.Next(0, 3);
    switch (EmpCheck)
    {
        case 2: //IsPartTime=2//
            empHrs = 4;
            break;
        case 1: //IsFullTime=1//
            empHrs = 8;
            break;
        default:
            empHrs = 0;
            break;
    }
    TotalWorkingHrs += empHrs;
    Console.WriteLine("day: " + TotalDays + " emp hrs: " + empHrs);
}
Console.WriteLine("Total emp working hrs: " + TotalWorkingHrs);
TotalEmpWage = TotalWorkingHrs * EmpRatePerHrs;
Console.WriteLine("Total Empwage wage is: " + TotalEmpWage);