using System;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("seven");
            Console.WriteLine("Введите своё трёхзначное число");
            int x = int.Parse(Console.ReadLine());
            if (x>=100 || x<=999)
            {
                int d1 = x / 100;
                int d2 = x / 10 % 10;
                int d3 = x % 10;
                int reversed = d3 * 100 + d2 * 10 + d1;
                Console.WriteLine("reversed: " + reversed);
            }
            else
            {
                Console.WriteLine("Error, try again");
            }
        }
    }
}
