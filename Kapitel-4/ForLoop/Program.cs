using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Console.WriteLine("Räkna 1 till 10!");
            
            for (int i = 0; i < 11; i++){
                Console.WriteLine($"Loop nr {i}");
            } 
            */

            //Läs meddelande
            Console.WriteLine("Skriv ett meddelande");
            string meddelande = Console.ReadLine();
            
            //Skriv en bokstav per rad.
            for (int i = 0; i < meddelande.Length; i++){
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
