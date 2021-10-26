using System;

namespace Skiffer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jag gjorde det på ett eget sätt som jag personligen tycker är lättare för utmaningarna.
            //Skapar variablerna som håller koll på dom "riktiga" och skiftade bokstävernra.
            string bokstäver = "abcdefghijklmnopqrstuvwxyzåäö";
            string skiffer = "";

            //Hur många steg ska siffret skifta med
            Console.WriteLine("hur många steg?");
            int steg;
            while (true)
            {    
                if (int.TryParse(Console.ReadLine(), out steg)) {
                    break;
                }
                Console.WriteLine("Det där går inte.");
            }

            //Det hära gör så att man kan kifta med negativa tal.
            if (steg < 0) {
                while (steg < 0) {
                    steg += bokstäver.Length;
                }
            }

            //Här defineras det skiftade bokstäverna.
            for (int i = 0; i < bokstäver.Length; i++) {
                skiffer += bokstäver[(i + steg) % (bokstäver.Length)];
            }

            //Skriv ett meddelande.
            Console.WriteLine("Sriv ett meddelande.");
            string meddelande = Console.ReadLine().ToLower();
            
            //Här krypteras meddelandet.
            string krypteratMeddelande = "";
            for (int i = 0; i < meddelande.Length; i++) {
                int j = 0;

                while (true) {
                    //Det här händer när den har gått igenom alla bokstäver, vilket betyder att det inte är en bokstav, 
                    //så den krypteras inte, för det är antingen en siffra, ett mellanslag eller ett annat konstigt tecken.
                    if (j == bokstäver.Length) {
                        krypteratMeddelande += meddelande[i];
                        break;
                    }
                    //Den kollar var i alphabetet teknek är, och när den har hittat det så byter den ut det mot bokstaven i det skiftade alphabetet.
                    if (meddelande[i] == bokstäver [j]) {
                        krypteratMeddelande += skiffer[j];
                        break;
                    } 
                    j++;
                }
            }
            Console.WriteLine(krypteratMeddelande);
            
            //Försökte göra det på ett sätt som yttnytjade (int), men det blev mer komplicerat och jag blev inte riktigt klar.
            /*
            meddelande = meddelande.ToUpper();
            krypteratMeddelande = "";
            for (int i = 0; i < meddelande.Length; i++) {
                if ((int)meddelande[i] >= 65 && (int)meddelande[i] <= 90) {
                    if ((int)meddelande[i] + steg <= 90) {
                        krypteratMeddelande += (char)(((int)meddelande[i]) + steg);

                    } else if ((int)meddelande[i] + steg <= 93) {
                        krypteratMeddelande += (char)(((int)meddelande[i]) + steg + 106);

                    } else {
                        krypteratMeddelande += (char)(((int)meddelande[i]) + steg - bokstäver.Length);
                    }

                } else if ((int)meddelande[i] >= 197 && (int)meddelande[i] <= 199) {

                    if ((int)meddelande[i] + steg <= 199) {
                        krypteratMeddelande += (char)(((int)meddelande[i]) + steg);

                    } else if ((int)meddelande[i] + steg - bokstäver.Length < 197) {
                        krypteratMeddelande += (char)(((int)meddelande[i]) + steg) - 106;
                    } else {
                        krypteratMeddelande += (char)(((int)meddelande[i]) + steg - bokstäver.Length);
                    }
                } else {
                    krypteratMeddelande += meddelande[i];
                }
            }
            Console.WriteLine(krypteratMeddelande);
            */
        }
    }
}
