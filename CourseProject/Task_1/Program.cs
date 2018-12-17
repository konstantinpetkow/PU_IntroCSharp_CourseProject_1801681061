using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
            // Превърнете в 2, 8 и 16 инча.
        {
            int value = 2061;
            string binary = Convert.ToString(value, 2);
            string binary1 = Convert.ToString(value, 8);
            string binary2 = Convert.ToString(value, 16);
            Console.WriteLine(binary);
            Console.WriteLine(binary1);
            Console.WriteLine(binary2);

        }
    }
}
