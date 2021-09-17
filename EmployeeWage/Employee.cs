using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        public int DailyWage()
        {
            // Define constants
            const int IS_PRESENT = 1, FULL_DAY_HRS = 8, WAGE_PER_HR = 20;
            // Define variables
            int empHours = 0;
            // Create random number generator
            Random random = new Random();
            int empCheck = random.Next(2);
            // Check attendance of employee
            if (empCheck == IS_PRESENT)
                empHours += FULL_DAY_HRS;
            // Calculate the wages
            int dailyWage = empHours * WAGE_PER_HR;
            return dailyWage;
        }
    }
}
