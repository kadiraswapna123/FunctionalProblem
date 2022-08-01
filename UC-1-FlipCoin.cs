using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblem
{
    public class FlipCoin
    {
        public void Flip_Percentage()
        {
            int Head = 0;
            int Tail = 0;

            Console.WriteLine("Enter the number of time to flip the coin");
            int NumOfFlips = Convert.ToInt32(Console.ReadLine());

            while (NumOfFlips <= 0)
            {
                Console.WriteLine("Enter the valid number greater than Zero");
                NumOfFlips = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < NumOfFlips; i++)
            {
                Random random = new Random();
                int value = random.Next(0, 2);
                if (value < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
            }
            float headPercent = (float)Head * 100 / NumOfFlips;
            float tailPercent = (float)Tail * 100 / NumOfFlips;

            Console.WriteLine("Head percentage is: " + headPercent);
            Console.WriteLine("Tail percentage is: " + tailPercent);
        }
    }
}
