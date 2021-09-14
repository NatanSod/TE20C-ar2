using System;

namespace Eget_arbete
{
    public class Player
    {
        public static int x = 0, y = 0;
        public static void Draw () {
            if (Console.KeyAvailable) {
                    if (Console.ReadKey().Key == ConsoleKey.RightArrow && x < Program.imgWidth - 1) {
                        x++;
                    }
                    if (Console.ReadKey().Key == ConsoleKey.LeftArrow && x > 0) {
                        x--;
                    }
                    if (Console.ReadKey().Key == ConsoleKey.UpArrow && y > 0) {
                        y--;
                    }
                    if (Console.ReadKey().Key == ConsoleKey.DownArrow && y < Program.imgHeight - 1) {
                        y++;
                    }
                }
            Program.image[x,y] = 'ÿ';
        }
    }
}
