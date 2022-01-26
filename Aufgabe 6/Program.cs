using System;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();
                string hauptausw;
                Console.WriteLine("\te-elektro");
                Console.WriteLine("\tm-mathe");
                Console.WriteLine("\toder schreiben sie 0 um die konsole zu beenden");
                hauptausw = Console.ReadLine().ToLower();
                switch (hauptausw)
                {
                    case "e":
                        Console.WriteLine("Sie haben elektro gewählt");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "m":
                        Console.WriteLine("sie haben mathe gewählt");
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case "0":
                        Environment.Exit(0);
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();
                        Console.Clear();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        break;
                }
            } while (true);


        }
    }
}
        
    

