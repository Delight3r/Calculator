using System;

public class Solids
{
    //Solids
        static public void SolidsFunc()
        {
            string answer;
            string[] basic = {"Square", "Triangle", "Rectangle", "Parallelogram", "Diamond", "Trapeze", "Deltoid", "Circle"};

                Console.Clear();

                bool repeat = true;
                double a;
                double b;
                double c;
                double d;
                double h;
                double solidHeight;

                double area;
                double volume;
                double basicArea;
                double wallArea;
                double totalArea;
                double basicDiagonal;
                double wallDiagonal;
                double solidDiagonal;
                double perimeter;
                double totalLengthOfSideEdges;

                // string answer;

                Console.WriteLine("What is Your basic?\n");

                int counter = 1;
                foreach(string item in basic)
                {
                    Console.WriteLine(counter + ". " + item);
                    counter++;
                }

                answer = Console.ReadLine();
                
                switch(answer)
                {
                    case "Square":
                    case "1":

                    while (repeat == true)
                    {
                        Console.Clear();

                        Console.WriteLine("What length is Your side edge?");
                        a = Convert.ToInt32( Console.ReadLine() );
                        Console.WriteLine("Okay, now give me the height of the solid");
                        solidHeight = Convert.ToInt32( Console.ReadLine() );

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        volume = a * a * solidHeight;
                        Console.WriteLine("Volume: " + volume);

                        basicArea = a * a;
                        Console.WriteLine("basic area: " + basicArea);

                        wallArea = a * solidHeight;
                        Console.WriteLine("Single wall area: " + wallArea + " /and You have 4 walls");

                        totalArea = (a * a) * 2 + (a * solidHeight) * 4;
                        Console.WriteLine("Total area: " + totalArea);

                        basicDiagonal = Math.Sqrt(a);
                        Console.WriteLine("basic diagonal: " + basicDiagonal);

                        wallDiagonal = Math.Sqrt(a * a + solidHeight * solidHeight);
                        Console.WriteLine("Wall diagonal: " + wallDiagonal);

                        solidDiagonal = Math.Sqrt(a * a + a * a + solidHeight * solidHeight);
                        Console.WriteLine("Solid diagonal: " + solidDiagonal);

                            if(a == solidHeight)
                            {
                                Console.WriteLine("Also this is a cube");
                            }

                        Console.ForegroundColor = ConsoleColor.White;
                        
                        Repeat(ref repeat, "solid");
                    }
                        break;
                    
                    case "Triangle":
                    case "2":

                    while (repeat == true)
                    {
                        bool done = false;
                        while(done == false)
                        {
                            Console.Clear();

                            double _basicArea;
                            Console.WriteLine("Is this equilateral triangle?");
                            answer = Console.ReadLine();
                            if(answer == "Yes" || answer == "yes")
                            {
                                Console.WriteLine("Okay, give me side edge");
                                a = Convert.ToInt32( Console.ReadLine() );

                                Console.WriteLine("Now give me height of the solid");
                                solidHeight = Convert.ToDouble( Console.ReadLine() );

                                _basicArea = a * (a * Math.Sqrt(3) / 2) * 0.5;
                                Console.WriteLine("basic area: " + _basicArea);
                                
                                volume = _basicArea * solidHeight;
                                Console.WriteLine("Volume: " + volume);

                                wallArea = a * solidHeight;
                                Console.WriteLine("Solid height: " + wallArea + " /Also, You have 3 same walls");

                                totalArea = wallArea * 3 + _basicArea * 2;
                                Console.WriteLine("Total area: " + totalArea);

                                wallDiagonal = Math.Sqrt(a * a + solidHeight * solidHeight);
                                Console.WriteLine("Wall diagonal: " + wallDiagonal);

                                done = true;

                            } else if (answer == "No" || answer == "no")
                            {
                                Console.WriteLine("Okay, give me all three side edges");
                                a = Convert.ToDouble( Console.ReadLine() );
                                b = Convert.ToDouble( Console.ReadLine() );
                                c = Convert.ToDouble( Console.ReadLine() );
                                Console.WriteLine("Now give me the height of the triangle");
                                h = Convert.ToDouble( Console.ReadLine() );

                                Console.WriteLine("Now, give me height of the solid");
                                solidHeight = Convert.ToDouble( Console.ReadLine() );

                                _basicArea = a * h * 0.5;
                                Console.WriteLine("basic area: " + _basicArea);
                                
                                volume = _basicArea * solidHeight;
                                Console.WriteLine("Volume: " + volume);

                                wallArea = a * solidHeight;
                                Console.WriteLine("First wall area: " + wallArea);

                                wallArea = b * solidHeight;
                                Console.WriteLine("Second wall area: " + wallArea);

                                wallArea = c * solidHeight;
                                Console.WriteLine("Third wall area: " + wallArea);

                                totalArea = _basicArea * 2 + a * solidHeight + b * solidHeight + c * solidHeight;
                                Console.WriteLine("Total area: " + totalArea);

                                wallDiagonal = Math.Sqrt(a * a + solidHeight * solidHeight);
                                Console.WriteLine("First wall diagonal: " + wallDiagonal);

                                wallDiagonal = Math.Sqrt(b * b + solidHeight * solidHeight);
                                Console.WriteLine("Second wall diagonal: " + wallDiagonal);

                                wallDiagonal = Math.Sqrt(c * c + solidHeight * solidHeight);
                                Console.WriteLine("Third wall diagonal: " + wallDiagonal);

                                done = true;

                            } else {
                                    Console.Clear();
                                    Console.WriteLine("I'm sorry, can You repeat?");
                                    Console.WriteLine("Is this equilateral triangle?");
                                    answer = Console.ReadLine();
                                }
                        }

                        Console.ForegroundColor = ConsoleColor.White;

                        Repeat(ref repeat, "solid");

                        }
                        break;

                    case "Rectangle":
                    case "3":
                    while (repeat == true)
                    {
                        Console.Clear();

                        Console.WriteLine("What length is Your both side edges?");
                        a = Convert.ToInt32( Console.ReadLine() );
                        b = Convert.ToInt32( Console.ReadLine() );

                        Console.WriteLine("Okay, now give me the height of the solid");
                        solidHeight = Convert.ToInt32( Console.ReadLine() );
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Solid (Rectangle): " + " basic side edge 1 - " + a + " / basic side edge 2 - " + b + " / Solid height - " + solidHeight + "\n");

                        volume = a * b * solidHeight;
                        Console.WriteLine("Volume: " + volume);

                        basicArea = a * b;
                        Console.WriteLine("basic area: " + basicArea);

                        wallArea = a * solidHeight;
                        Console.WriteLine("First wall area: " + wallArea + " /and You have 2 that walls");

                        wallArea = b * solidHeight;
                        Console.WriteLine("Second wall area: " + wallArea + " /and You have 2 that walls");

                        totalArea = (a * b) * 2 + (a * solidHeight) * 2 + (b * solidHeight) * 2;
                        Console.WriteLine("Total area: " + totalArea);

                        basicDiagonal = Math.Sqrt(a * a + b * b + solidHeight * solidHeight);
                        Console.WriteLine("basic diagonal: " + basicDiagonal);

                        wallDiagonal = Math.Sqrt(a * a + solidHeight * solidHeight);
                        Console.WriteLine("First wall diagonal: " + wallDiagonal);

                        wallDiagonal = Math.Sqrt(b * b + solidHeight * solidHeight);
                        Console.WriteLine("Second wall diagonal: " + wallDiagonal);

                        solidDiagonal = Math.Sqrt(a * a + b * b + solidHeight * solidHeight);
                        Console.WriteLine("Solid diagonal: " + solidDiagonal);

                            if(a == b && a == solidHeight)
                            {
                                Console.WriteLine("Also this is a cube");
                            }
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        Repeat(ref repeat, "solid");

                        }
                        break;

                    case "Parallelogram":
                    case "4":
                    while (repeat == true)
                    {
                        Console.Clear();
                        //Calculate basic
                        Console.WriteLine("Okay, so give me side edges, and the height of the basic");
                        a = Convert.ToDouble( Console.ReadLine() );
                        b = Convert.ToDouble( Console.ReadLine() );
                        h = Convert.ToDouble( Console.ReadLine() );
                        Console.WriteLine("Okay, so give me height of the solid");
                        solidHeight = Convert.ToDouble( Console.ReadLine() );

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Solid (Parallelogram): " + "basic edge 1 - " + a + " / basic edge 2 - " + b + " / basic height - " + h + " / Solid height - " + solidHeight + "\n");
                        
                        area = a * h;
                        Console.WriteLine("Base area = " + area);

                        perimeter = a * 2 + b * 2;
                        Console.WriteLine("Base perimeter = " + perimeter);

                        wallArea = a * solidHeight;
                        Console.WriteLine("First wall area = " + wallArea + " /Also You have 2 that walls");

                        wallArea = b * solidHeight;
                        Console.WriteLine("Second wall area = " + wallArea + " /Also You have 2 that walls");

                        volume = a * h * solidHeight;
                        Console.WriteLine("Volume = " + volume);

                        totalArea = a * h * 2 + a * solidHeight * 2 + b * solidHeight * 2;
                        Console.WriteLine("Total area = " + totalArea);

                        solidDiagonal = Math.Sqrt(a * a + b * b + solidHeight * solidHeight);
                        Console.WriteLine("Solid diagonal = " + solidDiagonal);

                        totalLengthOfSideEdges = a * 4 + b * 4 + solidHeight * 4;
                        Console.WriteLine("Total area of side edges = " + totalLengthOfSideEdges);
                        
                        Console.ForegroundColor = ConsoleColor.White;

                        Repeat(ref repeat, "solid");

                        }
                        break;
                    
                    case "Diamond":
                    case "5":
                    while (repeat == true)
                    {
                        Console.Clear();

                        Console.WriteLine("Okay, give me one side edge and height of the basic");
                        a = Convert.ToDouble( Console.ReadLine() );
                        h = Convert.ToDouble( Console.ReadLine() );
                        Console.WriteLine("Okay, give me height of the solid");
                        solidHeight = Convert.ToDouble( Console.ReadLine() );

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Solid (Diamond): " + " basic edge - " + a + " / basic height - " + h + " / Solid height - " + solidHeight + "\n");

                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        area = a * h;
                        Console.WriteLine("basic area = " + area);

                        perimeter = a * 4;
                        Console.WriteLine("basic perimeter = " + perimeter);

                        wallArea = a * solidHeight;
                        Console.WriteLine("Wall area = " + wallArea + " /Also You have 4 that walls");

                        volume = a * h * solidHeight;
                        Console.WriteLine("Volume = " + volume);

                        totalArea = a * h * 2 + a * solidHeight * 4;
                        Console.WriteLine("Total area = " + totalArea);

                        solidDiagonal = Math.Sqrt(a * a + a * a + solidHeight * solidHeight);
                        Console.WriteLine("Solid diagonal = " + solidDiagonal);

                        totalLengthOfSideEdges = a * 8 + solidHeight * 4;
                        Console.WriteLine("Total area of side edges = " + totalLengthOfSideEdges);
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        Repeat(ref repeat, "solid");

                        }
                        break;

                    case "Trapeze":
                    case "6":
                    while (repeat == true)
                    {
                        Console.Clear();

                        Console.WriteLine("Okay, give me both basics and height of the trapeze");
                        a = Convert.ToDouble( Console.ReadLine() );
                        b = Convert.ToDouble( Console.ReadLine() );
                        h = Convert.ToDouble( Console.ReadLine() );
                        Console.WriteLine("Okay, now give me height of the solid");
                        solidHeight = Convert.ToDouble( Console.ReadLine() );

                        bool done = false;

                        Console.WriteLine("Is this isosceles trapezoid? Yes/No");
                        answer = Console.ReadLine();

                        while (done == false)
                        {
                            if(answer == "Yes" || answer == "yes")
                            {
                                Console.WriteLine("Okay, so give me leg (side edge)");
                                c = Convert.ToDouble( Console.ReadLine() );

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Clear();
                                Console.WriteLine("Solid (Trapeze): " + "basic edge 1 - " + a + " / basic edge 2 - " + b + " / basic height - " + h + " / Solid height - " + solidHeight + "\n");

                                //Calculate perimeter of the trapeze
                                perimeter = a + b + c * 2;
                                Console.WriteLine("basic perimeter = " + perimeter);

                                basicArea = (a + b) * h / 2;
                                Console.WriteLine("basic area = " + basicArea);

                                wallArea = (a * solidHeight);
                                Console.WriteLine("First wall area = " + wallArea);

                                wallArea = (b * solidHeight);
                                Console.WriteLine("Second wall area = " + wallArea);

                                wallArea = (c * solidHeight);
                                Console.WriteLine("Third wall area = " + wallArea);

                                totalArea = basicArea * 2 + a * solidHeight * 2 + b * solidHeight * 2 + c * solidHeight * 2;
                                Console.WriteLine("Total area = " + totalArea);

                                totalLengthOfSideEdges = a * 4 + b * 4 + c * 4 + solidHeight * 4;
                                Console.WriteLine("Total area of side edges = " + totalLengthOfSideEdges);

                                volume = basicArea * solidHeight;
                                Console.WriteLine("Volume = " + volume);

                                done = true;

                            } else if(answer == "No" || answer == "no") {
                                Console.WriteLine("Okay, so I'm gonna need two more side edges");
                                c = Convert.ToDouble( Console.ReadLine() );
                                d = Convert.ToDouble( Console.ReadLine() );

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Clear();
                                Console.WriteLine("Trapeze: " + "basic 1 - " + a + " / basic 2 - " + b + " / Height " + h + "\n");

                                //Calculate perimeter of the trapeze
                                perimeter = a + b + c + d;
                                Console.WriteLine("basic perimeter = " + perimeter);

                                basicArea = (a + b) * h / 2;
                                Console.WriteLine("basic area = " + basicArea);

                                wallArea = (a * solidHeight);
                                Console.WriteLine("First wall area = " + wallArea);

                                wallArea = (b * solidHeight);
                                Console.WriteLine("Second wall area = " + wallArea);

                                wallArea = (c * solidHeight);
                                Console.WriteLine("Third wall area = " + wallArea);

                                wallArea = (d * solidHeight);
                                Console.WriteLine("Fourth wall area = " + wallArea);

                                totalArea = basicArea * 2 + a * solidHeight * 2 + b * solidHeight * 2 + c * solidHeight + d * solidHeight;
                                Console.WriteLine("Total area = " + totalArea);

                                totalLengthOfSideEdges = a * 4 + b * 4 + c * 2 + d * 2 + solidHeight * 4;
                                Console.WriteLine("Total area of side edges = " + totalLengthOfSideEdges);
                                
                                volume = basicArea * solidHeight;
                                Console.WriteLine("Volume = " + volume);

                                done = true;

                            } else {
                                while(answer != "Yes" || answer != "yes" || answer != "No" || answer != "no")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Is this isosceles trapezoid? Yes/No");
                                    Console.WriteLine("I'm sorry, can You repeat?");
                                    answer = Console.ReadLine();
                                }
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        Repeat(ref repeat, "solid");

                        }
                        break;

                    case "Deltoid":
                    case "7":
                    while (repeat == true)
                    {
                        Console.Clear();

                        Console.WriteLine("Okay, so I'm gonna need both side edges, and both diagonals of the basic");
                
                        a = Convert.ToDouble( Console.ReadLine() );
                        b = Convert.ToDouble( Console.ReadLine() );
                        double p = Convert.ToDouble( Console.ReadLine() );
                        d = Convert.ToDouble( Console.ReadLine() );

                        Console.WriteLine("Okay, now give me height of the solid");
                        solidHeight = Convert.ToDouble( Console.ReadLine() );
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Deltoid: " + "Basic edge 1 - " + a + " / Basic edge 2 - " + b + " / Basic diagonal 1 - " + p + " / Basic diagonal 2 - " + d + " / Solid height - " + solidHeight + "\n");
                        
                        basicArea = (p * d) / 2;
                        Console.WriteLine("Basic area = " + basicArea);

                        perimeter = a * 2 + b * 2;
                        Console.WriteLine("Baic perimeter = " + perimeter);

                        wallArea = (a * solidHeight);
                        Console.WriteLine("First wall area = " + wallArea + " /Also You have 2 that walls");

                        wallArea = (b * solidHeight);
                        Console.WriteLine("Second wall area = " + wallArea + " /Also You have 2 that walls");

                        totalArea = basicArea * 2 + a * solidHeight * 2 + b * solidHeight * 2;
                        Console.WriteLine("Total area = " + totalArea);

                        totalLengthOfSideEdges = a * 4 + b * 4 + solidHeight * 4;
                        Console.WriteLine("Total area of side edges = " + totalLengthOfSideEdges);
                        
                        volume = basicArea * solidHeight;
                        Console.WriteLine("Volume = " + volume);

                        Console.ForegroundColor = ConsoleColor.White;
                        
                        Repeat(ref repeat, "solid");

                        }
                        break;
                    
                    case "Circle":
                    case "8":
                    while (repeat == true)
                    {
                        Console.Clear();

                        Console.WriteLine("Okay, so give me radius, and the solid height");
                        double r = Convert.ToDouble( Console.ReadLine() );
                        solidHeight = Convert.ToDouble( Console.ReadLine() );

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Solid (Circle): " + "Basic radius - " + r + " / Solid height - " + solidHeight + "\n");

                        basicArea = r * Math.PI * Math.Pow(r, 2);
                        Console.WriteLine("Basic area = " + basicArea);

                        perimeter = 2 * Math.PI * r;
                        Console.WriteLine("Basic perimeter = " + perimeter);

                        volume = basicArea * solidHeight;
                        Console.WriteLine("Volume = " + volume);

                        wallArea = perimeter * solidHeight;
                        Console.WriteLine("Wall area = " + wallArea);

                        totalArea = basicArea * 2 + wallArea;
                        Console.WriteLine("Total area = " + totalArea);

                        Console.ForegroundColor = ConsoleColor.White;
                        
                        Repeat(ref repeat, "solid");

                        }
                        break;
                    default:
                    break;
                }

                Console.Clear();
    }

    public static void Repeat(ref bool repeat, string whichType)
    {
        Console.WriteLine("\nIf You want to calculate next " + whichType + ", write 'Yes', otherwise, press enter");
        string answer = Console.ReadLine();

            if(answer == "Yes" || answer == "yes") {
                repeat = true;
            } else {
                repeat = false;
            }
        }
    }