﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        public int DailyWage()
        {
            // Define constants
            const int IS_FULL_TIME = 1, IS_PART_TIME = 2, FULL_DAY_HRS = 8, PART_TIME_HRS = 4, WAGE_PER_HR = 20;
            // Define variables
            int empHours = 0;
            // Create random number generator
            Random random = new Random();
            int empCheck = random.Next(3);
            // Check employee attendance and calculate total working hours of employee
            if (empCheck == IS_FULL_TIME)
                empHours += FULL_DAY_HRS;
            if (empCheck == IS_PART_TIME)
                empHours += PART_TIME_HRS;
            // Calculate the wages
            int dailyWage = empHours * WAGE_PER_HR;
            return dailyWage;
        }
    }
}
