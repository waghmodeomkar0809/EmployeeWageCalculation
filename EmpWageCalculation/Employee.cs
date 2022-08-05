using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    internal class Employee
    {
      const int isfulltime = 1;
      const int isparttime = 2;

        Random random = new Random();
        int emphrs = 0, Wageperhts = 20;
        public void Attendence()
        {

            int result = random.Next(0, 3);
            if (result == 1)
            {
                Console.WriteLine("employee is present");
                emphrs += 8;
            }

            else if (result == 2)
            {
                Console.WriteLine("employe is part time");
                emphrs += 4;
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
        public int DailyWage()
        {
            return emphrs * Wageperhts;
        }
    }
}
