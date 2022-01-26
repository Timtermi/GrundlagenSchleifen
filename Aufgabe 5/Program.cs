using System;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = Convert.ToInt32(Console.ReadLine());

            for (int i = -a; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

