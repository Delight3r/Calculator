using System;

class FlatGeometry
{
    static public void Square()
        {
            string repeat;
            while (true)
            {
                Console.Clear();
                double a;

                Console.WriteLine("Okay, so give me side edge");
                a = Convert.ToDouble (Console.ReadLine() );

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Square: " + "Side edge 1 - " + a + "\n");

                //Calculate square area
                double area = a * a;
                Console.WriteLine("Square area = " + area);

                //Calculate diagonal of the square
                double diagonal = Math.Sqrt(a);
                Console.WriteLine("Diagonal of the square = " + diagonal);

                //Calculate the perimeter of the square
                double perimeter = a * 4;
                Console.WriteLine("The perimeter of the square = " + perimeter);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIf You want to calculate next Square, write 'repeat', if not, press enter");
                 
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

        static public void Triangle()
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
                Console.WriteLine("Okay, so give me these parametres: \nBasis \nHeight");
                a = Convert.ToDouble( Console.ReadLine() );
                h = Convert.ToDouble( Console.ReadLine() );

                Console.WriteLine("Is this equilateral triangle? Yes/No");

                answer = Console.ReadLine();

                if(answer == "Yes" || answer == "yes")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Triangle: " + "Basis - " + a + " / Height " + h + "\n");

                    //Calculate perimeter of the traingle
                    double perimeter = a * 3;
                    Console.WriteLine("Perimeter of the triangle = " + perimeter);
                } else {
                    Console.WriteLine("Okay, so I'm gonna need two more side edges");
                    b = Convert.ToDouble( Console.ReadLine() );
                    c = Convert.ToDouble( Console.ReadLine() );
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Triangle: " + " Side edge 1 - " + a + " / Side edge 2 - " + b + " / Side edge 3 - " + c + " / Height - " + h + "\n");

                    //Calculate perimeter of the triangle
                    double perimeter = a + b + c;
                    Console.WriteLine("Perimeter of the triangle = " + perimeter);
                }

                //Calculate triangle area
                double area = a * h / 2;
                Console.WriteLine("Triangle area = " + area);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIf You want to calculate next Triangle, write 'repeat', if not, press enter");
                 
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

        static public void Rectangle()
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

                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Rectangle: " + "Side edge 1 - " + a + " / Side edge 2 - " + b + "\n");
                //Calculate area of the rectangle
                double area = a * b;
                Console.WriteLine("Rectangle area = " + area);

                //Calculate diagonal of the rectangle
                double diagonal = Math.Sqrt(a * a + b * b);
                Console.WriteLine("Diagonal of the rectangle = " + diagonal);

                //Calculate perimeter of the rectangle
                double perimeter = a * 2 + b * 2;
                Console.WriteLine("perimeter of the rectangle = " + perimeter);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIf You want to calculate next Rectangle, write 'repeat', if not, press enter");
                 
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

        static public void Parallelogram()
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

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Parallelogram: " + "Side edge 1 - " + a + " / Side edge 2 - " + " / Height " + h + "\n");
                //Calculate parallelogram area
                double area = a * h;
                Console.WriteLine("Parallelogram area = " + area);

                //Calculate parallelogram perimeter
                double perimeter = a * 2 + b * 2;
                Console.WriteLine("Parallelogram perimeter = " + perimeter);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIf You want to calculate next Parallelogram, write 'repeat', if not, press enter");
                 
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

        static public void Diamond()
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

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Diamond: " + " Side edge 1 - " + a + " / Height " + h + "\n");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                //Calculate diamond area
                double area = a * h;
                Console.WriteLine("Diamond area = " + area);

                //Calculate diamond perimeter
                double perimeter = a * 4;
                Console.WriteLine("Diamond perimeter = " + perimeter);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIf You want to calculate next Diamond, write 'repeat', if not, press enter");
                 
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

        static public void Trapeze()
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

                while (true)
                {
                    if(answer == "Yes" || answer == "yes")
                    {
                        Console.WriteLine("Okay, so give me side edge");
                        c = Convert.ToDouble( Console.ReadLine() );

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.WriteLine("Trapeze: " + "Basis 1 - " + a + " / Basis 2 - " + b + " / Height " + h + "\n");

                        //Calculate perimeter of the trapeze
                        double perimeter = a + b + c * 2;
                        Console.WriteLine("Trapeze perimeter = " + perimeter);
                    } else if(answer == "No" || answer == "no") {
                        Console.WriteLine("Okay, so I'm gonna need two more side edges");
                        c = Convert.ToDouble( Console.ReadLine() );
                        d = Convert.ToDouble( Console.ReadLine() );

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.WriteLine("Trapeze: " + "Basis 1 - " + a + " / Basis 2 - " + b + " / Height " + h + "\n");

                        //Calculate perimeter of the trapeze
                        double perimeter = a + b + c + d;
                        Console.WriteLine("Trapeze perimeter = " + perimeter);
                    } else {
                        while(answer != "Yes" || answer != "yes" || answer != "No" || answer != "no")
                        {
                            Console.Clear();
                            Console.WriteLine("Is this isosceles trapezoid? Yes/No");
                            Console.WriteLine("I'm sorry, can You repeat?");
                            answer = Console.ReadLine();
                        }
                        break;
                    }
                }

                //Calculate area of the trapeze
                double area = ((a + b) / 2) * h;
                Console.WriteLine("Trapeze area = " + area);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIf You want to calculate next Trapeze, write 'repeat', if not, press enter");
                 
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

        static public void Circle()
        {
            string repeat;
            while(true)
            {
                Console.Clear();

                double r;

                Console.WriteLine("Okay, so I'm gonna need radius");
                r = Convert.ToDouble( Console.ReadLine() );

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Circle: " + "Radius - " + r + "\n");

                //Calculate circle area
                double area = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("Circle area = " + area);

                //Calculate circle perimeter
                double perimeter = 2 * Math.PI * r;
                Console.WriteLine("Circle perimeter = " + perimeter);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIf You want to calculate next Circle, write 'repeat', if not, press enter");
                 
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

        static public void Deltoid()
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
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Deltoid: " + "Side edge 1 - " + a + " / Side edge 2 - " + b + " / Diagonal 1 " + p + " / Diagonal 2 \n");
                //Calculate delotid area
                double area = (p * d) / 2;
                Console.WriteLine("delotid area = " + area);

                //Calculate the perimeter of the delotid
                double perimeter = a * 2 + b * 2;
                Console.WriteLine("Delotid perimeter = " + perimeter);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nIf You want to calculate next Deltoid, write 'repeat', if not, press enter");
                 
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
}