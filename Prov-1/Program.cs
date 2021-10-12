using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Definerar några variabler som jag kommer behöva senare.
            //klar är för att se när användaren har skrivit in ett giltigt värde så att den kan gå vidare till nästa steg.
            bool klar = false;
            //Dom är exakt vad namnet skulle få dig att tro
            string namn;
            double bruttolön = 0, skattesats = 0, nettolön;

            Console.WriteLine("Nettolön uträknare");
            
            Console.WriteLine("------------------");
            
            Console.Write("Ditt namn: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Jag har inget som kollar ifall namnet är korrekt för det finns inget som är "fel".
            namn = Console.ReadLine();

            //Den första loopen. Den ser till så att datan som matas in är korrekt och försöker igen om den inte är det
            while (! klar) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Din bruttolön i kronor: ");
                
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //Den går igenom allt som skulle kunna gå fel och ger ett meddelande utifrån det som gick fel.
                if (! double.TryParse(Console.ReadLine(), out bruttolön)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det där är inte ens ett numer");
                } else if (bruttolön < 10000) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det kan inte vara lägre än 10000kr");
                } else if (bruttolön > 45000) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det kan inte vara högre än 45000kr");
                } else {
                    //När inget är fel så blir klar sant och loopen bryts.
                    klar = true;
                }
            }

            klar = false;
            //Samma som förra den förra loopen.
            while (! klar) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Din skattesats i %: ");
                
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (! double.TryParse(Console.ReadLine(), out skattesats)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det där är inte ens ett numer");
                } else if (skattesats < 10) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det kan inte vara lägre än 10%");
                } else if (skattesats > 45) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det kan inte vara högre än 45%");
                } else {
                    klar = true;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------");
            
            //Räknar ut nettolönen och skriver ut svaret.
            nettolön = bruttolön * (100 - skattesats) / 100;

            Console.WriteLine($"{namn}, din nettolön blir {nettolön}kr.");
            Console.WriteLine($"Baserat på bruttolön {bruttolön}kr och skattesatsen {skattesats}%.");
        }
    }
}
