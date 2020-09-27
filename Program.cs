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

            Console.WriteLine("What do You want to calculate?");
            Lists("Main menu");

            answer = Console.ReadLine();

            while(answer != "Exit" || answer != "exit")
            {
                if(answer == "Solids" || answer == "1")
                {
                    while(answer != "Back")
                    {  
                        Console.WriteLine("What do You want to calculate? (Solids)");
                        Lists("Solids");
                        answer = Console.ReadLine();
                        switch(answer)
                        {
                            case "Cuboid":
                            case "1":
                                Cuboid();
                                break;
                            default: 
                                Console.Clear();
                                Console.WriteLine("I'm sorry, can You repeat?");
                                break;
                        }
                    }
                }
                else if (answer == "Flat geometry" || answer == "Flat Geometry" || answer == "flat Geometry" || answer == "2")
                {
                    while(answer != "Back")
                    {
                        Console.Clear();
                        Console.WriteLine("What do You want to calculate? (Flat geometry)");
                        Lists("Flat geometry");
                        answer = Console.ReadLine();
                        switch(answer)
                        {
                            case "Square":
                            case "1":
                                Square();
                                break;
                            case "Triangle":
                            case "2":
                                Triangle();
                                break;
                            case "Rectangle":
                            case "3":
                                Rectangle();
                                break;
                            case "Parallelogram":
                            case "4":
                                Parallelogram();
                                break;
                            case "Diamond":
                            case "5":
                                Diamond();
                                break;
                            case "Trapeze":
                            case "6":
                                Trapeze();
                                break;
                            case "Circle":
                            case "7":
                                Circle();
                                break;
                            case "Deltoid":
                            case "8":
                                Deltoid();
                                break;
                            default: 
                                Console.Clear();
                                Console.WriteLine("\nI'm sorry, can You repeat?");
                                break;
                        }
                    }
                }
                else if(answer == "Back" || answer == "back")
                {
                    Console.Clear();
                    Console.WriteLine("You are now here: Main menu");
                    Lists("Main menu");
                    answer = Console.ReadLine();
                }
                else {
                        Console.Clear();
                        Console.WriteLine("I'm sorry, can You repeat? You are here: Main menu");
                        answer = Console.ReadLine();
                }
            }
        }

        static void Square()
        {
            string repeat;
            while (true)
            {
                Console.Clear();
                double a;

                Console.WriteLine("Okay, so give me side edge");
                a = Convert.ToDouble (Console.ReadLine() );

                //Calculate square area
                double area = a * a;
                Console.WriteLine("Square area = " + area);

                //Calculate diagonal of the square
                double diagonal = Math.Sqrt(a);
                Console.WriteLine("Diagonal of the square = " + diagonal);

                //Calculate the perimeter of the square
                double perimeter = a * 4;
                Console.WriteLine("The perimeter of the square = " + perimeter);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = Console.ReadLine();
                if(repeat == "repeat")
                {
                    continue;
                }
                else {
                    break;
                }
            }
        }

        static void Triangle()
        {
            string repeat;
            while(true)
            {
                Console.Clear();

                double a;
                double b;
                double c;
                double h;

                string answer;
                Console.WriteLine("Okay, so give me these parametres: \nBasic \nHeight");
                a = Convert.ToDouble( Console.ReadLine() );
                h = Convert.ToDouble( Console.ReadLine() );

                Console.WriteLine("Is this equilateral triangle? Yes/No");

                answer = Console.ReadLine();

                if(answer == "Yes" || answer == "yes")
                {
                    //Calculate perimeter of the traingle
                    double perimeter = a * 3;
                    Console.WriteLine("Perimeter of the triangle = " + perimeter);
                } else {
                    Console.WriteLine("Okay, so I'm gonna need two more side edges");
                    b = Convert.ToDouble( Console.ReadLine() );
                    c = Convert.ToDouble( Console.ReadLine() );

                    //Calculate perimeter of the triangle
                    double perimeter = a + b + c;
                    Console.WriteLine("Perimeter of the triangle = " + perimeter);
                }

                //Calculate triangle area
                double area = a * h / 2;
                Console.WriteLine("Triangle area = " + area);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = Console.ReadLine();
                if(repeat == "repeat")
                {
                    continue;
                }
                else {
                    break;
                }
            }
        }

        static void Rectangle()
        {
            string repeat;
            while (true)
            {
                Console.Clear();

                double a;
                double b;

                Console.WriteLine("Okay, so give me his side edges");
                a = Convert.ToDouble( Console.ReadLine() );
                b = Convert.ToDouble( Console.ReadLine() );

                //Calculate area of the rectangle
                double area = a * b;
                Console.WriteLine("Rectangle area = " + area);

                //Calculate diagonal of the rectangle
                double diagonal = Math.Sqrt(a * a + b * b);
                Console.WriteLine("Diagonal of the rectangle = " + diagonal);

                //Calculate perimeter of the rectangle
                double perimeter = a * 2 + b * 2;
                Console.WriteLine("perimeter of the rectangle = " + perimeter);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = Console.ReadLine();
                if(repeat == "repeat")
                {
                    continue;
                }
                else {
                    break;
                }
            }
        }

        static void Parallelogram()
        {
            string repeat;
            while(true)
            {
                Console.Clear();

                double a;
                double b;
                double h;

                Console.WriteLine("Okay, so give me side edges, and the height");
                a = Convert.ToDouble( Console.ReadLine() );
                b = Convert.ToDouble( Console.ReadLine() );
                h = Convert.ToDouble( Console.ReadLine() );

                //Calculate parallelogram area
                double area = a * h;
                Console.WriteLine("Parallelogram area = " + area);

                //Calculate parallelogram perimeter
                double perimeter = a * 2 + b * 2;
                Console.WriteLine("Parallelogram perimeter = " + perimeter);

                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = Console.ReadLine();
                if(repeat == "repeat")
                {
                    continue;
                }
                else {
                    break;
                }
            }
        }

        static void Diamond()
        {
            string repeat;
            while(true)
            {
                Console.Clear();

                double a;
                double h;

                Console.WriteLine("Okay, give me side edge and height");
                a = Convert.ToDouble( Console.ReadLine() );
                h = Convert.ToDouble( Console.ReadLine() );

                //Calculate diamond area
                double area = a * h;
                Console.WriteLine("Diamond area = " + area);

                //Calculate diamond perimeter
                double perimeter = a * 4;
                Console.WriteLine("Diamond perimeter = " + perimeter);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = Console.ReadLine();
                if(repeat == "repeat")
                {
                    continue;
                }
                else {
                    break;
                }
            }
        }

        static void Trapeze()
        {
            string repeat;
            while (true)
            {
                Console.Clear();

                double a;
                double b;
                double c;
                double d;
                double h;
                string answer;

                Console.WriteLine("Okay, give me both basis, height");
                a = Convert.ToDouble( Console.ReadLine() );
                b = Convert.ToDouble( Console.ReadLine() );
                h = Convert.ToDouble( Console.ReadLine() );

                Console.WriteLine("Is this isosceles trapezoid? Yes/No");
                answer = Console.ReadLine();

                if(answer == "Yes" || answer == "yes")
                {
                    Console.WriteLine("Okay, so give me side edge");
                    c = Convert.ToDouble( Console.ReadLine() );

                    //Calculate perimeter of the trapeze
                    double perimeter = a + b + c * 2;
                    Console.WriteLine("Trapeze perimeter = " + perimeter);
                } else {
                    Console.WriteLine("Okay, so I'm gonna need two more side edges");
                    c = Convert.ToDouble( Console.ReadLine() );
                    d = Convert.ToDouble( Console.ReadLine() );

                    //Calculate perimeter of the trapeze
                    double perimeter = a + b + c + d;
                    Console.WriteLine("Trapeze perimeter = " + perimeter);
                }

                //Calculate area of the trapeze
                double area = ((a + b) / 2) * h;
                Console.WriteLine("Trapeze area = " + area);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = Console.ReadLine();
                if(repeat == "repeat")
                {
                    continue;
                }
                else {
                    break;
                }
            }
        }

        static void Circle()
        {
            string repeat;
            while(true)
            {
                Console.Clear();

                double r;

                Console.WriteLine("Okay, so I'm gonna need radius");
                r = Convert.ToDouble( Console.ReadLine() );

                //Calculate circle area
                double area = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("Circle area = " + area);

                //Calculate circle perimeter
                double perimeter = 2 * Math.PI * r;
                Console.WriteLine("Circle perimeter = " + perimeter);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = Console.ReadLine();
                if(repeat == "repeat")
                {
                    continue;
                }
                else {
                    break;
                }
            }
        }

        static void Deltoid()
        {
            string repeat;
            while(true)
            {
                Console.Clear();

                double a;
                double b;
                double p;
                double d;

                Console.WriteLine("Okay, so I'm gonna need both side edges, and both diagonals");
                
                a = Convert.ToDouble( Console.ReadLine() );
                b = Convert.ToDouble( Console.ReadLine() );
                p = Convert.ToDouble( Console.ReadLine() );
                d = Convert.ToDouble( Console.ReadLine() );
                

                //Calculate delotid area
                double area = (p * d) / 2;
                Console.WriteLine("delotid area = " + area);

                //Calculate the perimeter of the delotid
                double perimeter = a * 2 + b * 2;
                Console.WriteLine("Delotid perimeter = " + perimeter);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = Console.ReadLine();
                if(repeat == "repeat")
                {
                    continue;
                }
                else {
                    break;
                }
            }
        }

        //Solids

        static void Cuboid()
        {
            string[] basis = {"Square", "Triangle", "Rectangle", "Parallelogram", "Diamond", "Trapeze", "Circle", "Deltoid"};
             Console.Clear();
             Console.WriteLine("What is Your basis?\n");
             foreach(var item in basis)
             {
                 Console.WriteLine(item);
             }
        }

        static void Lists(string whichList)
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
