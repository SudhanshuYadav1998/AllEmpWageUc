﻿class program
{
    public const int Is_Full_Time = 2;
    public const int Is_Half_Time = 1;
    public static int EmpWage(string CompanyName,int Num_Of_Working_Hours,int Num_Of_Working_Days,int Emp_Rate_Per_Hrs)
    {
        int emphrs = 0, totalemphrs = 0, totalworkingdays = 0;
        while (totalemphrs < Num_Of_Working_Hours &&
            totalworkingdays < Num_Of_Working_Days)
        {
            totalworkingdays++;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case 1:
                    emphrs = 4;
                    break;
                case 2:
                    emphrs = 8;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            totalemphrs += emphrs;
            Console.WriteLine($"Days {totalworkingdays} Hours {emphrs} ");
        }
        int totalempwage = totalemphrs * Emp_Rate_Per_Hrs;
        Console.WriteLine($"total emp wage is {totalempwage}");
        return totalempwage;
    }
    static void Main(string[] args)
    {
        EmpWage("Dmart",50,15,12);
        EmpWage("Reliance", 70, 16, 15);
    }
}

