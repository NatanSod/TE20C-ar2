using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("En siffra: ");
            string år = Console.ReadLine();

            Console.Write("En platts: ");
            string plats = Console.ReadLine();
            
            Console.Write("En person som jobbar med ett yrke: ");
            string yrke = Console.ReadLine();
            
            Console.Write("Ett namn: ");
            string namn = Console.ReadLine();
            
            Console.Write("Ett djur: ");
            string djur = Console.ReadLine();

            Console.Write("En färg: ");
            string färg = Console.ReadLine();

            Console.Write("Ett klädesplagg: ");
            string kläder = Console.ReadLine();

            Console.Write("Ett föremål: ");
            string föremål = Console.ReadLine();
            

            Console.WriteLine($"För {år} år sedan, i en stad som hette {plats}, så va en {yrke}, vid namn {namn} på väg hem. Denna {namn} gick i rask takt för att komma hem och ta hand om sin {djur}. Plötsligt blev resan avbruten av en mystisk person, klädd i en {färg} {kläder}. Den mystiska personen gav en {föremål} till {namn}, och sedan försvan. {namn} stoppade det i fickan och fortsatte hem, utan någon aning om vad det skulle leda till.");
            Console.WriteLine($"Fortsättning följer i nästa avsnit av \"En {yrke} och sin {djur} besegrar Gud\"!");

            Console.ReadLine();
        }
    }
}
