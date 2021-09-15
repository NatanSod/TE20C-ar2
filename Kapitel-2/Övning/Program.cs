using System;

namespace Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Hej! Vad heter du? ");

            string namn = Console.ReadLine();
            
            Console.WriteLine($"Trevligt att träffas, {namn}");
        }
    }
}
