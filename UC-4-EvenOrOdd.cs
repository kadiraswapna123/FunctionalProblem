using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    internal class UC_4_EvenOrOdd
    {
        public void EvenOrOdd()
        {
            Console.Write("Enter the number to Check even or odd : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number {0} is Even", num);
            }
            else
            {
                Console.WriteLine("The number {0} is Odd", num);
            }
        }
    }
}
