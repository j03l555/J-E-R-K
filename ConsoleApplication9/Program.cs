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
            var heldItem = "";
            var userAction = "";

            //DEBUG let the user select a debug scene instead of a normal scene
            //if they want.
            Console.WriteLine("Enter the name of a debug scene to enter it.");
            Console.WriteLine("If you just want to enter the starting scene then dont type in anything");
            var selectScene = Console.ReadLine().ToLower();
            if (selectScene == "debug_test1")
            {
                //DEBUG scene
                Console.Clear();
                heldItem = "";
                userAction = "";
                var notebookWritten = false;
                var quillInInk = false;
                var inkInMug = false;
                while (true)
                {
                Console.WriteLine("You are in a room known as the Debug Room.");
                Console.WriteLine("There is a table infront of you.");
                Console.WriteLine("There is a mug on the table.");
                Console.WriteLine("There is a notebook on the table.");
                    if (quillInInk == false)
                    {
                        Console.WriteLine("There is a quill on the table.");
                        Console.WriteLine("There is a bottle of ink on the table.");
                    }
                    else
                    {
                        Console.WriteLine("There is a bottle of ink on the table.");
                        Console.WriteLine("There is a quill in the bottle of ink.");
                    }
                    Console.WriteLine("What will you do?");
                    userAction = Console.ReadLine().ToLower();
                    if (userAction == "get notebook from table")
                    {
                        if (notebookWritten == true)
                        {
                            Console.WriteLine("\"What's the point? You already wrote in it and it's not like you have anything else to write.\" you think to yourself.");
                            Console.WriteLine("You are unable to think of a point to this.");
                            Console.WriteLine("So you leave the notebook alone");
                        }
                        else
                        {
                            heldItem = "notebook";
                            Console.WriteLine("You picked up the notebook.");
                            while (true)
                            {
                                Console.WriteLine("What will you do next?");
                                userAction = Console.ReadLine().ToLower();
                                if (userAction == "put notebook on table")
                                {
                                    heldItem = "";
                                    Console.WriteLine("You returned the notebook to the table.");
                                    break;
                                }
                                if (userAction == "open notebook")
                                {
                                    Console.WriteLine("You opened the notebook to the first page.");
                                    Console.WriteLine("The page is blank.");
                                    while (true)
                                    {
                                        Console.WriteLine("What will you do?");
                                        userAction = Console.ReadLine().ToLower();
                                        if (userAction == "use quill from table with notebook")
                                        {
                                            if (inkInMug == true)
                                            {
                                                notebookWritten = true;
                                                heldItem = "";
                                                quillInInk = true;
                                                Console.WriteLine("You took the quill that was on the table.");
                                                Console.WriteLine("You dipped the quill in the ink-filled mug.");
                                                Console.WriteLine("You drew some stickmen fighting eachother in the notebook.");
                                                Console.WriteLine("You returned the notebook to the table, and put the quill into the bottle of ink.");
                                                break;
                                            }
                                            else
                                            {
                                                notebookWritten = true;
                                                heldItem = "";
                                                quillInInk = true;
                                                Console.WriteLine("You took the quill that was on the table.");
                                                Console.WriteLine("You dipped the quill in the bottle of ink.");
                                                Console.WriteLine("You drew some stickmen fighting eachother in the notebook.");
                                                Console.WriteLine("You returned the notebook to the table, and put the quill into the bottle of ink.");
                                                break;
                                            }
                                        }
                                        
                                    } 
                                    if (userAction == "use quill from table with notebook")
                                    {
                                        break;
                                    }
                                }
                            }
                        }


                    }
                    if (userAction == "get bottle of ink from table")
                    {
                        if (inkInMug == false)
                        {
                            if (quillInInk == false)
                            {
                                Console.WriteLine("You got the bottle of ink.");
                            }
                            else
                            {
                                Console.WriteLine("You got the bottle of ink, with the quill still inside.");
                            }
                            while (true)
                            {
                                heldItem = "bottle of ink";
                                Console.WriteLine("What will you do next?");
                                userAction = Console.ReadLine().ToLower();
                                if (userAction == "put bottle of ink on table")
                                {
                                    heldItem = "";
                                    Console.WriteLine("You returned the bottle of ink back to the table");
                                    break;
                                }
                                if (userAction == "pour bottle of ink into mug from table")
                                {
                                    if (quillInInk == false)
                                    {
                                        inkInMug = true;
                                        Console.WriteLine("You poured the ink into the mug on the table.");
                                        break;
                                    }
                                    else
                                    {
                                        inkInMug = true;
                                        Console.WriteLine("You carefully poured the ink into the mug on the table.");
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (quillInInk == false)
                            {
                                Console.WriteLine("The bottle of ink is empty.");
                            }
                            else
                            {
                                Console.WriteLine("The bottle of ink is empty, bar the now useless quill");
                            }
                        }
                    }


                }
            }
            else //if (selectScene == "")
            {
                Console.Clear();
                Console.WriteLine("Invalid scene name, ", selectScene);
                Console.WriteLine("Press any key to exit program");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }
}
