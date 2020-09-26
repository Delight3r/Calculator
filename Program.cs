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

            Console.WriteLine("If You want to see 'Possibilities', type it, if You want to quit, type 'Exit'");

            while(answer != "Exit")
            {  
                Console.WriteLine("What do You want to calculate?");
                answer = Console.ReadLine();
                switch(answer)
                {
                    case "Help":
                        Help();
                        break;
                    case "Possibilities":
                        Possibilities();
                        break;
                    case "Square":
                        Square();
                        break;
                    case "Triangle":
                        Triangle();
                        break;
                    case "Rectangle":
                        Rectangle();
                        break;
                    case "Parallelogram":
                        Parallelogram();
                        break;
                    case "Diamond":
                        Diamond();
                        break;
                    case "Trapeze":
                        Trapeze();
                        break;
                    case "Circle":
                        Circle();
                        break;
                    case "Deltoid":
                        Deltoid();
                        break;
                    default: 
                        Console.Clear();
                        Console.WriteLine("\nOops, something went wrong, try again!");
                        break;
                }
            }
        }

        static void Square()
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

            Console.WriteLine("");
        }

        static void Triangle()
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

            Console.WriteLine("");
        }

        static void Rectangle()
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

            Console.WriteLine("");
        }

        static void Parallelogram()
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

            Console.WriteLine("");
        }

        static void Diamond()
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

            Console.WriteLine("");
        }

        static void Trapeze()
        {
            Console.Clear();

            double a;
            double b;
            double c;
            double d;
            double h;
            string answer;

            Console.WriteLine("Okay, give me both basics, height");
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

            Console.WriteLine("");
        }

        static void Circle()
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

            Console.WriteLine("");
        }

        static void Deltoid()
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

            Console.WriteLine("");
        }

        //Other functions

        static void Possibilities()
        {
            Console.Clear();

            string[] possibilities = {
                "Square",
                "Triangle",
                "Rectangle",
                "Parallelogram",
                "Diamond",
                "Trapeze",
                "Circle",
                "Deltoid"
            };

            foreach (var option in possibilities)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine("");
        }

        static void Help()
        {
            Console.Clear();

            Console.WriteLine("If You want to see possibilities, type 'Possibilities'\nIf You want to quit, type 'Exit'");
            
            Console.WriteLine("");
        }
    }
}
