//Att den använder "System" betyder att programet kan komma åt metoder och variabler från "System" utan att skriva "System." först
using System;

//Att den har denna det är som "using System", fast saker med samma namespace går åt båda hållen.
namespace Uppgift1._5
//Det här är en öppnande måsvinge, all kod mellan den öppnande och stängande är en del av den övre koden.
{
    //Det här är en klass, tänk på den som en samling av variabler och metoder som hör till en speciel sak.
    class Program
    {
        //Det här är en metod, det är en väldigt speciel metod för det är den här som körs när programet startar, bara kod som har en koppling till den kommer köras.
        static void Main(string[] args)
        {
            //Den skriver texten inanför "", \n skapar en ny rad och \" och \\ skriver det andra tecknet som i canliga fall gör speciella saker.
            Console.WriteLine("Du är nästan klar med kapitel 1. \nDu har lärt dig skriva ut tecken som \" och \\.");
        }
    }
    //Det här är en stängande måsvinge, den visar att "bublan" med kod tar slut här, dom funkerar på ett "Sist in först ut" system.
}
