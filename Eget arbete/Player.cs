using System;

namespace Eget_arbete
{
    public class Player
    {        
        public static int x = 7, y = 2;
        public static void Exist () {
            switch (Console.ReadKey().Key) {
                case ConsoleKey.RightArrow:
                    if (x < Program.imgWidth - 1) {
                        if (Draw.DungeonAt(x + 1, y)){
                            x++;
                        }
                    }
                    break;
                    
                case ConsoleKey.LeftArrow:
                    if (x > 0) {
                        if (Draw.DungeonAt(x - 1, y)){
                            x--;
                        }
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (y > 0) {
                        if (Draw.DungeonAt(x, y - 1)) {
                            y--;
                        }
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (y < Program.imgHeight - 1) {
                        if (Draw.DungeonAt(x, y + 1)) {
                            y++;
                        }
                    }
                    break;

                case ConsoleKey.Escape:
                    Program.done = true;
                    break;
            }
            Program.image[x,y] = 'ÿ';
            Console.WriteLine(x + " " + y);
            if (x == 10 && y == 17) {
                Program.place = "slime";
            }
        }
    }
}
