using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    internal class Employee
    {
       public const int isfulltime = 1;
       public const int isparttime =2;
       public const int emprateperhour = 20;
        static void main(string[] args)
        {
            int emphrs = 0;
            int empWage = 0;
            Random rand = new Random();
            int empcheck = rand.Next(0, 3);
            switch (empcheck)
            {
                case isfulltime:
                    emphrs = 8;
                    break;
                    case isparttime:
                    emphrs = 4;
                    break;
                    default:
                    emphrs = 0;
                        break;
            }
            empWage = emphrs * emprateperhour;
            Console.WriteLine("emp wage : " + empWage);
        }
         
    }
}
