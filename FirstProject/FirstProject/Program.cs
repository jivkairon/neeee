using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("ИТ Кариера"); 
              Console.Write((3522 + 52353) * 23 - (2336 * 501 + 23432 - 6743) * 3);
             */
            var cnt = double.Parse(Console.ReadLine());
            var br = 15;
            cnt = cnt + 5.0;//кратка форма cnt +=5;
            cnt++; //cnt=cnt+1; cnt+=1;
            var s = br + " продукта са на цена " + cnt + " лева.";
            Console.WriteLine(s);
          

        }
    }
}
