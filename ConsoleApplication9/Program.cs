using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ╔╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤╤͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟╤╗
●════════════╣J E R K text adventures╠════════════●
●════════════╣   By  joelastley555  ͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟͟ ╠════════════●
             ╚╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╧╝

             Version 0.0-initial
            */

            //Start-up text
            Console.Title = "J E R K // Text Adventures by joelastley555";
            Console.WriteLine("==============================");
            Console.WriteLine("J E R K");
            Console.WriteLine();
            Console.WriteLine("A text adventures game created by joelastley555.");
            Console.WriteLine("Inspired by the old classic game, Zork");
            Console.WriteLine();
            Console.WriteLine("GitHub: https://github.com/joelastley555/J-E-R-K");
            Console.WriteLine("Protected by MIT License. To find it, goto the GitHub above");
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(">>>>>>>>Press any key to play...<<<<<<<<");
            //Wait for user to press a keyboard key
            Console.ReadKey();



            //Clear console screen
            Console.Clear();

            //Create important variables
            var heldItem = "null";

            //DEBUG let the user select a debug scene instead of a normal scene
            //if they want.
            Console.WriteLine("Enter the name of a debug scene to enter it.");
            Console.WriteLine("If you just want to enter the starting scene then (without quotes) type: \"story1\"");
            var selectScene = Console.ReadLine();


            //DEBUG scene
            
        }
    }
}
