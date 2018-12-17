using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        //(Тест 1-7I)
        {

            Console.WriteLine("Задавайки H,R,r, програмата изчислява и извежда обема V на пресечен конус.");
            Console.Write("Въведете H:");
            int H = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете R:");
            int R = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете r:");
            int r = Int32.Parse(Console.ReadLine());
            Console.Write("Обема на пресечения конус е V= {0}.\n", Math.PI * H * (R * R + R * r + r * r) / 3);


        }
    }
}
