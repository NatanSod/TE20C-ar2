using System;

namespace Eget_arbete 
{
    public class Write 
    {
        /*
            TextBox(
                //-----------------------------------
                  "",
                  "",
                  ""
            );
        */
        public static void Intro () {
            TextBox(
                //-----------------------------------
                  "As you return to consciousness   ",
                  "you notice a few things.         ",
                  "                                 "
            );
            TextBox(
                //-----------------------------------
                  "The first thing is the pain.     ",
                  "                                 ",
                  "                                 "
            );
            TextBox(
                //-----------------------------------
                  "There is an excruciating pain in ",
                  "your forehead.                   ",
                  "                                 "
            );
            TextBox(
                //-----------------------------------
                  "After a few minutes of cradling  ",
                  "your head, the pain finally      ",
                  "becomes bearable.                "
            );
            TextBox(
                //-----------------------------------
                  "Then you notice something else.  ",
                  "                                 ",
                  "                                 "
            );
            TextBox(
                //-----------------------------------
                  "You have no idea where you are.  ",
                  "                                 ",
                  "                                 "
            );
            TextBox(
                //-----------------------------------
                  "Or, well, you know where you are.",
                  "You are here, in this damp cave. ",
                  "                                 "
            );
            TextBox(
                //-----------------------------------
                  "The problem is that you don't    ",
                  "know how to get from here to     ",
                  "a place that you do know.        "
            );
            TextBox(
                //-----------------------------------
                  "You sit there for a few minutes, ",
                  "thinking about what to do next.  ",
                  "                                 "
            );
            TextBox(
                //-----------------------------------
                  "It doesn't take long to decide.  ",
                  "                                 ",
                  "                                 "
            );
            TextBox(
                //-----------------------------------
                  "If there is a way in here, there ",
                  "is a way out of here.            ",
                  "And sitting there isn't helping  "
            );
            TextBox(
                //-----------------------------------
                  "So you gather your strength and  ",
                  "curage, you stand up, take a deep",
                  "breath and get going             "
            );
        }

        public static void LookPool () {
            TextBox(
                //-----------------------------------
                  "You come across a small pool of  ",
                  "water, illuminated by two glowing",
                  "blue crystals.                   "
            );
            TextBox(
                //-----------------------------------
                  "It's calming aura draws you in.  ",
                  "Begging you to take a dip in it. ",
                  "                                 "
            );
        }

        static void TextBox (string text1, string text2, string text3) {
            Console.WriteLine(
                "\n" +
                $"+-----------------------------------+\n" +
                $"| {text1} |\n" +
                $"| {text2} |\n" +
                $"| {text3} |\n" +
                $"+-----------------------------------+\n");
            Console.Write("Press Enter to continue");
            Console.ReadLine();
        }
    }
}