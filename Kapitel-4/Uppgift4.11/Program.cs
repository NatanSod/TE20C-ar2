using System;

namespace Uppgift4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till en nytt avsnitt av \"Uppgiften är skitlätt så jag gör den mer intressant genom att skriva en massa text\"!");
            Console.ReadKey();
            Console.WriteLine("I det här avsnittet ska... Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("Ja, personen vars namn jag definitivt inte redan har glömt ska svara på en fråga!");
            Console.ReadKey();
            Console.WriteLine("Dom kommer få fem försök på sig!");
            Console.ReadKey();
            Console.WriteLine("Om dom lyckas så får dom absolut ingenting!");
            Console.ReadKey();
            Console.WriteLine("Men om dom misslyckas så får dom känna skam över att dom svarade fel inför hur-många-det-nu-är-som-tittar-på-det-här-programmet!");
            Console.ReadKey();
            
            Console.WriteLine("");
            Console.WriteLine("Så låt introduktionerna upphöra, för det är dags att svara på frågan!");
            Console.ReadKey();
            Console.WriteLine("Frågan är:");
            Console.ReadKey();

            int försök = 0;
            while (försök < 5) {
                Console.Write("Hur många bönor finns det i den här genomskinliga glas burken som kan som mest hålla 4 bönor?:");
                string svar = Console.ReadLine();
                if (svar == "0") {
                    Console.WriteLine($"Det är korrekt {namn}! I den här genomskinliga glas burken finns inga bönor alls!");
                    if (försök == 0) {
                        Console.WriteLine("Och du vet vad det betyder!");
                        Console.ReadKey();
                        Console.WriteLine("Det betyder att du... person vars namn jag glömde igen!");
                        Console.ReadKey();
                    } else {
                        Console.ReadKey();
                        Console.WriteLine($"Men om jag ska vara ärlig så är jag förvånad att du misslyckades {försök} gånger!");
                        Console.ReadKey();
                        Console.WriteLine("Dina ögon fungerar, eller hur? Du kan väll se att det inte finns några bönor i den?");
                        Console.ReadKey();
                        Console.WriteLine("Men nog om det!");
                        Console.ReadKey();
                        Console.WriteLine("Du... person vars namn jag glömde igen!");
                        Console.ReadKey();
                    }
                    Console.WriteLine("Du har precis vunnit ingenting!");
                    Console.ReadKey();
                    Console.WriteLine("Grattis!");
                    Console.ReadKey();
                    break;
                } else {
                    switch (försök) {
                        case 0:
                        Console.WriteLine("Oh! Så nära!");
                        break;
                        case 1:
                        Console.WriteLine("Kom igen! Du har fortfarande 3 försök kvar!");
                        break;
                        case 2:
                        Console.WriteLine("Går det bra?");
                        break;
                        case 3:
                        Console.WriteLine("Jag börjar bli lite orolig om jag ska vara ärlig.");
                        break;
                        case 4:
                        Console.WriteLine("Och det va ditt sista försök!");
                        Console.ReadKey();
                        Console.WriteLine("Jag är ledsen att säga, men du har har på något sätt förlorat!");
                        Console.ReadKey();
                        Console.WriteLine("Känn skam!");
                        Console.ReadKey();
                        Console.WriteLine("Eller inte, det ät ditt val!");
                        Console.ReadKey();
                        Console.WriteLine("Men i alla fall");
                        break;
                    }
                }
                försök ++;
            }
            Console.WriteLine("Låt oss hoppas att vi ses igen näst gång som \"Uppgiften är skitlätt så jag gör den mer intressant genom att skriva en massa text\"!");
            Console.ReadKey();
            Console.WriteLine("Jag tackar för mig och önskar er alla en god kväll!");

        }
    }
}
