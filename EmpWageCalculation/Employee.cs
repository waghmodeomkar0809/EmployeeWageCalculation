﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    internal class Employee
    {
        int isPrasent = 1;
        Random random = new Random();

        public void Attendence()
        {
           
            int result = random.Next(0, 2);
            if (result == isPrasent)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
           
          
            }
        }
    }
}
