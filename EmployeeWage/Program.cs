using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate Employee Monthly Wage
            int monthlyWage = new Employee().MonthlyWage();
            Console.WriteLine($"Monthly Wage of Employee is: {monthlyWage}");
        }
    }
}
