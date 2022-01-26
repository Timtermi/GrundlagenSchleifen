using System;
using System.Threading;
namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            for (int a = 50; a >= 0; a--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(a);

            }


        }
    }
}
