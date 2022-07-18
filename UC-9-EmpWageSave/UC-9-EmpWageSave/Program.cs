public class EmpBuildeObject
    {
        public const int Is_Full_Time = 2;
        public const int Is_Half_Time = 1;
    private string company;
    private int Num_Of_Working_Days;
    private int Emp_Rate_Per_Hrs;
    private int totalempwage;
    private int Num_Of_Working_Hours;

    public EmpBuildeObject(string CompanyName, int NumOfWorkingHours, int NumOfWorkingDays, int EmpRatePerHrs)
    {
        this.company = CompanyName;
        this.Num_Of_Working_Days = NumOfWorkingDays;
        this.Emp_Rate_Per_Hrs = EmpRatePerHrs;
        this.Num_Of_Working_Hours = NumOfWorkingHours;

    }

    public void EmpWage()
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
        int totalempwage = totalemphrs * this.Emp_Rate_Per_Hrs;
        Console.WriteLine($"total emp wage for company {company} for working {totalemphrs} hrs is {totalempwage}");
    }
        
    }
class program
{
    static void Main(string[] args)
    {
        EmpBuildeObject dmart = new EmpBuildeObject("Dmart", 100, 20, 30);
        EmpBuildeObject reliance = new EmpBuildeObject("Reliance", 120, 22, 20);
        dmart.EmpWage();
        reliance.EmpWage();
    }
}


