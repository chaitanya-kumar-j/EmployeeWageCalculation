using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        public int MonthlyWage()
        {
            // Define constants
            const int IS_FULL_TIME = 1, IS_PART_TIME = 2, FULL_DAY_HRS = 8, PART_TIME_HRS = 4, WAGE_PER_HR = 20, MAX_WORKING_DAYS = 20, MAX_WORKING_HRS = 100;
            // Define variables
            int empHours = 0, workingDays = 1;
            // Create random number generator
            Random random = new Random();
            // Calculate Total hours worked in a month
            while ( workingDays <= MAX_WORKING_DAYS &  empHours<100)
            {
                workingDays++;
                int empCheck = random.Next(3);
                // Check employee attendance and calculate total working hours of employee
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours += FULL_DAY_HRS;
                        if (empHours>MAX_WORKING_HRS)
                            empHours -= FULL_DAY_HRS;
                        break;
                    case IS_PART_TIME:
                        empHours += PART_TIME_HRS;
                        if (empHours>MAX_WORKING_HRS)
                            empHours -= PART_TIME_HRS;
                        break;
                    default:
                        break;
                }
            }
            // Calculate the wages
            int monthlyWage = empHours * WAGE_PER_HR;
            return monthlyWage;
        }
    }
}
