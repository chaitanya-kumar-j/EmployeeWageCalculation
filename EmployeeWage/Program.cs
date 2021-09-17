using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate Employee Daily Wage
            int dailyWage = new Employee().DailyWage();
            Console.WriteLine($"Daily Wage of Employee is: {dailyWage}");
        }
    }
}
