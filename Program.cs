using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some parametres for window
            Console.WindowHeight = 50;
            Console.WindowWidth = 120;
            Console.Title = "Awesome Calculator";
            //###
            string answer = "";

            Console.WriteLine("What do You want to calculate?\n");
            Lists("Main menu");

            answer = Console.ReadLine();

            while(answer != "Exit" || answer != "exit") // Main loop for main menu
            {
                if(answer == "Solids" || answer == "solids" || answer == "1") // Checking if answer is for solids...
                {
                    while(answer != "Back")
                    {  
                        Console.Clear();
                        Solids.SolidsFunc();
                        Solids.Exit(ref answer);
                    }
                } else if (answer == "Flat geometry" || answer == "Flat Geometry" || answer == "flat Geometry" || answer == "2") // ... or flat geometry
                {
                    while(answer != "Back") // Loop for flat geometry with switch. Breaking if You'll type "back".
                    {
                        Console.Clear();

                        Console.WriteLine("What do You want to calculate? (Flat geometry)\n");
                        Lists("Flat geometry");
                        answer = Console.ReadLine();

                        //Switch that checks which shape you want to calculate
                        switch(answer)
                        {
                            case "Square":
                            case "1":
                            {
                                FlatGeometry.Square();
                                break;
                            }
                            case "Triangle":
                            case "2":
                            {
                                FlatGeometry.Triangle();
                                break;
                            }
                            case "Rectangle":
                            case "3":
                            {
                                FlatGeometry.Rectangle();
                                break;
                            }
                            case "Parallelogram":
                            case "4":
                            {
                                FlatGeometry.Parallelogram();
                                break;
                            }
                            case "Diamond":
                            case "5":
                            {
                                FlatGeometry.Diamond();
                                break;
                            }
                            case "Trapeze":
                            case "6":
                            {
                                FlatGeometry.Trapeze();
                                break;
                            }
                            case "Circle":
                            case "7":
                            {
                                FlatGeometry.Circle();
                                break;
                            }
                            case "Deltoid":
                            case "8":
                            {
                                FlatGeometry.Deltoid();
                                break;
                            }
                            default:
                                break;
                        }
                    }
                } else if(answer == "Back" || answer == "back") //If statement that makes you can go back
                {
                    Console.Clear();

                    Console.WriteLine("You are now here: Main menu\n");
                    Lists("Main menu");
                    answer = Console.ReadLine();
                } else {
                        Console.Clear();

                        Console.WriteLine("I'm sorry, can You repeat? You are here: Main menu\n");
                        Lists("Main menu");
                        answer = Console.ReadLine();
                }
            }
        }
        
        public static void Lists(string whichList)
        {
            // Function that let me to show different arrays...
            // ...in code without repeating code
            int counter = 1;
            string[] MmList = {"Solids", "Flat geometry"};
            string[] FgList = {"Square", "Triangle", "Rectangle", "Parallelogram", "Diamond", "Trapeze", "Circle", "Deltoid"};
            string[] PList = {"Cuboid"};
            switch (whichList)
            {
                case "Main menu":
                    foreach(var item in MmList)
                    {
                        Console.WriteLine(counter + ". " + item);
                        counter++;
                    }
                    break;
                case "Flat geometry":
                    foreach(var item in FgList)
                    {
                        Console.WriteLine(counter + ". " + item);
                        counter++;
                    }
                    break;
                case "Solids":
                    foreach(var item in PList)
                    {
                        Console.WriteLine(counter + ". " + item);
                        counter++;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
