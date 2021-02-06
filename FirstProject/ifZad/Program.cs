using System;

namespace ifZad
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  double a = double.Parse(Console.ReadLine());
              var start = Console.ReadLine();
              var end = Console.ReadLine();
              if (start == "mm") a = a / 1000;
              if (start == "cm") a = a / 100;
              if (start == "mi") a = a / 0.000621371192;
              if (start == "in") a = a / 39.3700787;
              if (start == "km") a = a / 0.001;
              if (start == "ft") a = a / 3.280839;
              if (start == "yd") a = a / 1.0936133;
              if (end == "mm") a = a * 1000;
              if (end == "cm") a = a * 100;
              if (end == "mi") a = a * 0.000621371192;
              if (end == "in") a = a * 39.3700787;
              if (end == "km") a = a * 0.001;
              if (end == "ft") a = a * 3.2808399;
              if (end == "yd") a = a * 1.0936133;
              Console.WriteLine(a + " " + end);
              */
            var n = int.Parse(Console.ReadLine());
            var dayType = Console.ReadLine();
            var taxiRate = 0.90;
            if (dayType == "day") taxiRate = 0.79;
            if (n < 20)
                Console.WriteLine("{0:f2}", 0.70 + n * taxiRate);
            else if (n < 100)
                Console.WriteLine("{0:f2}", n * 0.09);
            else Console.WriteLine("{0:f2}", n * 0.06);
        }
    }
}
