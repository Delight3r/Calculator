using System;

public class Solids
{
    //Solids
        static public void SolidsFunc()
        {
            string answer;
            string[] basis = {"Square", "Triangle", "Rectangle", "Parallelogram", "Diamond", "Trapeze", "Circle", "Deltoid"};
            
            Console.Clear();

            Console.WriteLine("Are Your both basis the same?");
            answer = Console.ReadLine();
            while(true)
            {
                if(answer == "Yes" || answer == "yes")
                {
                    TheSame();
                    break;
                } else if(answer == "No" || answer == "no")
                {
                    NotTheSame();
                    break;
                } else {
                    Console.WriteLine("I'm sorry, can You repeat?");
                    answer = Console.ReadLine();
                }
            }

            void TheSame()
            {
                Console.Clear();

                double a;
                double b;
                double c;
                double d;
                double h;
                double solidHeight;

                string answer;

                Console.WriteLine("What is Your basis?\n");

                int counter = 1;
                foreach(string item in basis)
                {
                    Console.WriteLine(counter + ". " + item);
                    counter++;
                }

                answer = Console.ReadLine();
                
                switch(answer)
                {
                    case "Square":
                    case "1":
                        Console.Clear();

                        Console.WriteLine("What length is Your side edge?");
                        a = Convert.ToInt32( Console.ReadLine() );
                        Console.WriteLine("Okay, now give me the height of the solid");
                        solidHeight = Convert.ToInt32( Console.ReadLine() );

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        double volume = a * a * solidHeight;
                        Console.WriteLine("Volume: " + volume);

                        double basisArea = a * a;
                        Console.WriteLine("Basis area: " + basisArea);

                        double wallArea = a * solidHeight;
                        Console.WriteLine("Single wall area: " + wallArea + " /and You have 4 walls");

                        double totalArea = (a * a) * 2 + (a * solidHeight) * 4;
                        Console.WriteLine("Total area: " + totalArea);

                        double basisDiagonal = Math.Sqrt(a);
                        Console.WriteLine("Basis diagonal: " + basisDiagonal);

                        double wallDiagonal = Math.Sqrt(a * a + solidHeight * solidHeight);
                        Console.WriteLine("Wall diagonal: " + wallDiagonal);

                        double solidDiagonal = Math.Sqrt(a * a + a * a + solidHeight * solidHeight);
                        Console.WriteLine("Solid diagonal: " + solidDiagonal);

                        if(a == solidHeight)
                        {
                            Console.WriteLine("Also this is a cube");
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.ReadKey();
                        break;
                    
                    case "Triangle":
                    case "2":
                        bool done = false;
                        while(done == false)
                        {
                            Console.Clear();

                            double _basisArea;
                            Console.WriteLine("Is this equilateral triangle?");
                            answer = Console.ReadLine();
                            if(answer == "Yes" || answer == "yes")
                            {
                                Console.WriteLine("Okay, give me side edge");
                                a = Convert.ToInt32( Console.ReadLine() );

                                Console.WriteLine("Now give me height of the solid");
                                solidHeight = Convert.ToDouble( Console.ReadLine() );

                                _basisArea = a * (a * Math.Sqrt(3) / 2) * 0.5;
                                Console.WriteLine("Basis area: " + _basisArea);
                                
                                volume = _basisArea * solidHeight;
                                Console.WriteLine("Volume: " + volume);

                                wallArea = a * solidHeight;
                                Console.WriteLine("Solid height: " + wallArea + " /Also, You have 3 same walls");

                                totalArea = wallArea * 3 + _basisArea * 2;
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

                                _basisArea = a * h * 0.5;
                                Console.WriteLine("Basis area: " + _basisArea);
                                
                                volume = _basisArea * solidHeight;
                                Console.WriteLine("Volume: " + volume);

                                double wallAreaA = a * solidHeight;
                                Console.WriteLine("Wall A area: " + wallAreaA);

                                double wallAreaB = a * solidHeight;
                                Console.WriteLine("Wall B area: " + wallAreaB);

                                double wallAreaC = a * solidHeight;
                                Console.WriteLine("Wall C area: " + wallAreaC);

                                totalArea = _basisArea * 2 + a * solidHeight + b * solidHeight + c * solidHeight;
                                Console.WriteLine("Total area: " + totalArea);

                                double wallDiagonalA = Math.Sqrt(a * a + solidHeight * solidHeight);
                                Console.WriteLine("Wall A diagonal: " + wallDiagonalA);

                                double wallDiagonalB = Math.Sqrt(b * b + solidHeight * solidHeight);
                                Console.WriteLine("Wall B diagonal: " + wallDiagonalB);

                                double wallDiagonalC = Math.Sqrt(c * c + solidHeight * solidHeight);
                                Console.WriteLine("Wall C diagonal: " + wallDiagonalC);

                                done = true;

                            } else {
                                    Console.Clear();
                                    Console.WriteLine("I'm sorry, can You repeat?");
                                    Console.WriteLine("Is this equilateral triangle?");
                                    answer = Console.ReadLine();
                                }
                            }

                        Console.ReadKey();
                        break;

                    case "Rectangle":
                    case "3":
                        Console.Clear();

                        Console.WriteLine("What length is Your both side edges?");
                        a = Convert.ToInt32( Console.ReadLine() );
                        b = Convert.ToInt32( Console.ReadLine() );

                        Console.WriteLine("Okay, now give me the height of the solid");
                        solidHeight = Convert.ToInt32( Console.ReadLine() );
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Solid (Rectangle): " + " Basis side edge 1 - " + a + " / Basis side edge 2 - " + b + " / Solid height - " + solidHeight + "\n");

                        volume = a * b * solidHeight;
                        Console.WriteLine("Volume: " + volume);

                        basisArea = a * b;
                        Console.WriteLine("Basis area: " + basisArea);

                        wallArea = a * solidHeight;
                        Console.WriteLine("First wall area: " + wallArea + " /and You have 2 that walls");

                        wallArea = b * solidHeight;
                        Console.WriteLine("Second wall area: " + wallArea + " /and You have 2 that walls");

                        totalArea = (a * b) * 2 + (a * solidHeight) * 2 + (b * solidHeight) * 2;
                        Console.WriteLine("Total area: " + totalArea);

                        basisDiagonal = Math.Sqrt(a * a + b * b + solidHeight * solidHeight);
                        Console.WriteLine("Basis diagonal: " + basisDiagonal);

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

                        Console.ReadKey();

                        break;

                    default:
                    break;
                }

                Console.Clear();
            }

            void NotTheSame()
            {
                Console.Clear();

                string basisOne;
                string basisTwo;

                foreach(string item in basis)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("What is Your first basis?\n");
                basisOne = Console.ReadLine();
                Console.WriteLine("What is Your first basis?\n");
                basisTwo = Console.ReadLine();

            }
        }
}