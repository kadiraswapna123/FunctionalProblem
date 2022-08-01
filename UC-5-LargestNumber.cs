using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    internal class UC_5_LargestNumber
    {
        public void LargestNumbers()
        {
            Console.Write("Enter the First number: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enetr the Second number: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int ThirdNumber = Convert.ToInt32(Console.ReadLine());
            if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
            {
                Console.WriteLine("Largest number is : " + FirstNumber);
            }
            else if (FirstNumber > SecondNumber && FirstNumber < ThirdNumber)
            {
                Console.WriteLine("Largest number is : " + SecondNumber);
            }
            else if (FirstNumber > ThirdNumber && FirstNumber < ThirdNumber)
            {
                Console.WriteLine("Largest number is : " + ThirdNumber);
            }
            else
            {
                Console.WriteLine("All three numbers are equal");
            }
        }
    }
}
