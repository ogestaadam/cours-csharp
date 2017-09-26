using System;

namespace Yours_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("input yours first name:");
            name = Console.ReadLine();
            Console.Write("quelle est votre age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
