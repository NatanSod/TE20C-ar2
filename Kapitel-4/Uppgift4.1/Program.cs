using System;

namespace Uppgift4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kan Natan redan allt som vi går igenom med den här uppgiften samt har visat att han kan det?");
            bool klar = false;
            while (! klar) {
                string answer = Console.ReadLine().ToLower();
                if (answer == "ja" || answer == "j") {
                    Console.WriteLine("Det är rätt! Natan vet redan hur det här fungerar!");
                    klar = true;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel svar.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
