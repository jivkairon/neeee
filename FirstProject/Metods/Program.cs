using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("тениска лв");
            double t = Double.Parse(Console.ReadLine());

         //   Console.WriteLine("Нужни лв");
            double mini = Double.Parse(Console.ReadLine());

            double shor = t - t * 75 / 100;
            double chorap = shor - shor * 20 / 100;
            double buton = 2 * (t + shor);

            double sum = (t + shor + chorap + buton) - (t + shor + chorap + buton) * 15 / 100;
            double m = mini - sum;

            if (sum >= mini)
            {

                Console.WriteLine($"Yes, he will earn the world-cup replica ball!\nHis sum is { sum:F2} lv.");
            }

            else
            {

                Console.WriteLine($"No, he will not earn the world-cup replica ball.\nHe needs { m:F2} more.");
            }
        }
    }
        

    
}
