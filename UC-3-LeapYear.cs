using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    internal class UC_3_LeapYear
    {
        public void LeapYear()
        { 
             int year;
             Console.WriteLine("Enter a year to check for leap year");
             year = Convert.ToInt32(Console.ReadLine());

            while(year < 999)
            {
                Console.WriteLine("Enter a year with 4 digit number");
                year = Convert.ToInt32(Console.ReadLine());
            }
            if (year % 400 == 0)
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }


    }
}
