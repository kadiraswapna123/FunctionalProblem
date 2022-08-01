using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    internal class UC_2_HarmonicNumber
    {
       public void HarmonicNumber()
        {
            double harmonicSum = 0;
            Console.Write("Enter the number to find harmonic number : ");
            double num = Convert.ToDouble(Console.ReadLine());

            for (double i = 0; i < num; i++)
            {
                Console.Write("1/{0} +", i);
                harmonicSum += (1 / i);
            }
            Console.WriteLine("\n The Sum of Harmonic number is : " + harmonicSum);
        }
    }
}
