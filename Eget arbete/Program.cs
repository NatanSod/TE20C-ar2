using System;

namespace Eget_arbete
{
    class Program
    {
        static bool done = false;

        public static int imgWidth = 20, imgHeight = 5;
        public static char[,] image = new char[imgWidth,imgHeight];
        static string finImg;

        static void Main(string[] args)
        {
            while (! done) {
                ClearCanvas();
                Player.Draw();
                PrintCanvas();

                if (Console.KeyAvailable) {
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        done = true;
                    }
                }
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
            Console.WriteLine(finImg);
        }
    }
}
