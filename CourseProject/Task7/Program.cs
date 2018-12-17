using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("358 зад. Съставете програма, в която да се въвеждат произволен брой имена\nразделени с точно 1 интервал, а се извеждат инициалите на първите 2 имена и последното име.\nНапример, въвежда се Абу Джафар Мохамед ибн Муса ал-Хорезми,\nа се извежда А.Д. ал-Хорезми.\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Въведете вашите имена: ");
            string name = Console.ReadLine();
            Console.ResetColor();


            string first = name.Substring(0, 1);


            string second = name.Substring(name.IndexOf(" ") + 1, 1);
            
            string[] words = name.Split(' ');
            string last = words[words.Length - 1];
        
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nИзвеждат се инициалите на първите 2 имена и последното име:\n{0}. {1}. {2}", first, second, last);
            Console.ResetColor();
        }
    }
}
