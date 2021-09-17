using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        public void Attendance()
        {
            // Define constants
            const int IS_PRESENT = 1;
            // Create random number generator
            Random random = new Random();
            int empCheck = random.Next(2);
            // Check attendance of employee
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
