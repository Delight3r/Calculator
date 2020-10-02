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

            while(answer != "Exit" || answer != "exit")
            {
                if(answer == "Solids" || answer == "solids" || answer == "1")
                {
                    while(answer != "Back")
                    {  
                        Console.Clear();

                        Console.WriteLine("What do You want to calculate? (Solids)\n");
                        Lists("Solids");
                        answer = Console.ReadLine();

                        switch(answer)
                        {
                            case "Solids":
                            case "1":
                                Solids.SolidsFunc();
                                break;
                            default: 
                                Console.Clear();
                                Console.WriteLine("I'm sorry, can You repeat?");
                                break;
                        }
                    }
                } else if (answer == "Flat geometry" || answer == "Flat Geometry" || answer == "flat Geometry" || answer == "2")
                {
                    while(answer != "Back")
                    {
                        Console.Clear();

                        Console.WriteLine("What do You want to calculate? (Flat geometry)\n");
                        Lists("Flat geometry");
                        answer = Console.ReadLine();

                        switch(answer)
                        {
                            case "Square":
                            case "1":
                                FlatGeometry.Square();
                                break;
                            case "Triangle":
                            case "2":
                                FlatGeometry.Triangle();
                                break;
                            case "Rectangle":
                            case "3":
                                FlatGeometry.Rectangle();
                                break;
                            case "Parallelogram":
                            case "4":
                                FlatGeometry.Parallelogram();
                                break;
                            case "Diamond":
                            case "5":
                                FlatGeometry.Diamond();
                                break;
                            case "Trapeze":
                            case "6":
                                FlatGeometry.Trapeze();
                                break;
                            case "Circle":
                            case "7":
                                FlatGeometry.Circle();
                                break;
                            case "Deltoid":
                            case "8":
                                FlatGeometry.Deltoid();
                                break;
                            default: 
                                Console.Clear();
                                Console.WriteLine("\nI'm sorry, can You repeat?");
                                break;
                        }
                    }
                } else if(answer == "Back" || answer == "back")
                {
                    Console.Clear();

                    Console.WriteLine("You are now here: Main menu\n");
                    Lists("Main menu");
                    answer = Console.ReadLine();
                } else {
                        Console.Clear();

                        Console.WriteLine("I'm sorry, can You repeat? You are here: Main menu");
                        answer = Console.ReadLine();
                }
            }
        }
        
        static public void Lists(string whichList)
        {
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
