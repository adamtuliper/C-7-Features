using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp7
{
    public static class OutVars
    {
        public static void Process()
        {
            Console.WriteLine("What's the answer to life the universe and everything");
            var input = Console.ReadLine();

            //locally (in the function) scoped
            if (int.TryParse(input, out var answer))
            {
                if (answer == 42)
                {
                    Draw();
                }
                
            }

            //available outside of if()
            answer++;

            //Using int works too
            if (int.TryParse(input, out int secondAnswer))
            {
                if (secondAnswer == 42)
                {
                    Draw();
                }

            }

        }




        //http://stackoverflow.com/questions/2725529/how-to-create-ascii-animation-in-windows-console-application-using-c
        static void ConsoleDraw(IEnumerable<string> lines, int x, int y)
        {
            if (x > Console.WindowWidth) return;
            if (y > Console.WindowHeight) return;

            var trimLeft = x < 0 ? -x : 0;
            int index = y;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            var linesToPrint =
                from line in lines
                let currentIndex = index++
                where currentIndex > 0 && currentIndex < Console.WindowHeight
                select new
                {
                    Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                    X = x,
                    Y = y++
                };

            Console.Clear();
            foreach (var line in linesToPrint)
            {
                Console.SetCursorPosition(line.X, line.Y);
                Console.Write(line.Text);
            }
        }

        static void Draw()
        {
            Console.CursorVisible = false;

            var arr = new[]
            {
            @"        ________________.  ___     .______  ",
            @"       /                | /   \    |   _  \",
            @"      |   (-----|  |----`/  ^  \   |  |_)  |",
            @"       \   \    |  |    /  /_\  \  |      /",
            @"  .-----)   |   |  |   /  _____  \ |  |\  \-------.",
            @"  |________/    |__|  /__/     \__\| _| `.________|",
            @"   ____    __    ____  ___     .______    ________.",
            @"   \   \  /  \  /   / /   \    |   _  \  /        |",
            @"    \   \/    \/   / /  ^  \   |  |_)  ||   (-----`",
            @"     \            / /  /_\  \  |      /  \   \",
            @"      \    /\    / /  _____  \ |  |\  \---)   |",
            @"       \__/  \__/ /__/     \__\|__| `._______/",
           @"",
           @"",
           @"",
           @"",
           @"#####",
           @"###########",
           @"###############",
           @"###################",
           @"#####################",
           @"#############################                                                                                               ",
           @"######################################                                                                        ##              ",
           @"#######################################                                                                     ##                  ",
           @"######################################                                                                 ###                   ",
           @"#####################################                                   ## #  #  #########         ###                         ",
           @"#####################################                                  ####################    ####                              ",
           @"#####################################                            ########################## ###  ",
           @"##############################      ##                ###    ######   #######################      ",
           @"########################            #           ### ##########   ############################        ",
           @"#####################            #####     ###    ###########################################          ",
           @"#################               #########     ##  ##########    #############################            ",
           @"#############                    ####  ######    ######### ##################################              ",
           @"##         #############     ##############################                   ",
           @"##       ###############   #################### ###########                     ",
           @"##     #########################################    #######                       ",
           @"#   ##### #####################################     ###  ##                         ",
           @"#######  ############# #########################          ###                        ",
           @"#####    #########################################         ######                    ",
           @"######      #########################################       ########                   ",
           @"#####      ##########################################        ########   ",
           @"##     ############################################       #########       ",
           @"############################################       ###########             ",
           @"############ ################################          #########            ",
           @"######           ##########   #################################         ###########",
           @"##    #####      #########    ############################################  ########## #",
           @"###############  ###############################################  #############     " };

            var maxLength = arr.Aggregate(0, (max, line) => Math.Max(max, line.Length));
            var x = Console.BufferWidth / 2 - maxLength / 2;
            for (int y = -arr.Length; y < Console.WindowHeight + arr.Length; y++)
            {
                ConsoleDraw(arr, x, y);
                Thread.Sleep(100);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}

