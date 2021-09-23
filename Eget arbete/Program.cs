using System;

namespace Eget_arbete
{
    class Program
    {
        static public bool done = false;
        static public string place = "Dungeon";

        public static int imgWidth = 40, imgHeight = 20;
        public static char[,] image = new char[imgWidth,imgHeight];
        static string finImg;
        static int wait = 0;
        public static bool[] flag = new bool[1];

        static void Start() {
            Console.WindowHeight = 40;

            for (int i = 0; i < flag.Length; i ++) {
                flag[i] = false;
            }
            for (int i = 0; i < 30; i ++) {
                Console.WriteLine();
            }
            Draw.Dungeon();
            Player.Show();
            PrintCanvas();

        }

        static void Main(string[] args)
        {
            Write.Intro();
            Start();
            //Denna kod kommer fortsätta att köras tills att "done" är sant.
            while (! done) {
                switch (place) {
                    case "Dungeon":
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
                    break;
                    case "slime":
                    Draw.Slime();
                    if (Console.ReadLine().ToLower() == "back") {
                        place = "Dungeon";
                    }
                    break;
                    case "lookPool":
                    Draw.LookPool();
                    Write.LookPool();

                    ClearCanvas();
                    Draw.Dungeon();
                    Player.Show();
                    PrintCanvas();

                    flag[0] = true;
                    place = "Dungeon";
                    break;
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
            for (int j = Player.y - 6; j <= Player.y + 6; j ++) {
                for (int i = Player.x - 6; i <= Player.x + 6; i ++) {
                    if (j < 0 || j > imgHeight - 1 || i < 0 || i > imgWidth - 1) {
                        finImg = finImg + "#";
                    } else {
                    finImg = finImg + Convert.ToString(image[i,j]);
                    }
                }
                finImg = finImg + "\n";
            }
            Console.WriteLine("");
            Console.WriteLine(finImg);
        }
    }
}
