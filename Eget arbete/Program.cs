using System;

namespace Eget_arbete
{
    class Program
    {
        static public bool done = false;

        public static int imgWidth = 40, imgHeight = 20;
        public static char[,] image = new char[imgWidth,imgHeight];
        static string finImg;
        static int wait = 0;


        static void Main(string[] args)
        {
            //Denna kod kommer fortsätta att köras tills att "done" är sant.
            while (! done) {
                    if (wait == 0) {
                    ClearCanvas();
                    Draw.Dungeon();
                    Player.Exist();
                    PrintCanvas();

                    //"wait" är till för att begränsa hur ofta en ny bild kan visas, om den visas för ofta så ser saker konstiga ut
                    //Om du vill se, tillfälligt ändra "wait = 10" till "wait = 1"
                    wait = 10;
                } else {
                    //Om man håller in en rikting under väntetiden så sparas signalen den tills nästa "ReadKey()"
                    //Det här "äter" dessa signaler.
                    if (Console.KeyAvailable) {
                        Console.ReadKey();
                    } else {
                        wait = 1;
                    }
                }
                System.Threading.Thread.Sleep(10);
                wait --;

                //System.Threading.Thread.Sleep(100);
                /*if (Console.KeyAvailable) {
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        done = true;
                    }
                }*/
            }


        }

        static void ClearCanvas () {
            for (int j = 0; j < imgHeight; j ++) {
                for (int i = 0; i < imgWidth; i ++) {
                    image[i,j] = '#';
                }
            }
            finImg = "";
        }

        static void PrintCanvas () {
            for (int j = 0; j < imgHeight; j ++) {
                for (int i = 0; i < imgWidth; i ++) {
                    finImg = finImg + Convert.ToString(image[i,j]);
                }
                finImg = finImg + "\n";
            }
            Console.WriteLine("");
            Console.WriteLine(finImg);
        }
    }
}
