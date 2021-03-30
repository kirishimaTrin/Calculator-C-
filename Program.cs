using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# # # # # # #");
            Console.WriteLine("# #   # #   #");
            Console.WriteLine("# #   #   # #");
            Console.WriteLine("# #     # # #");
            Console.WriteLine("# #     # # #");
            Console.WriteLine("# #   #   # #");
            Console.WriteLine("# #   # #   #");
            Console.WriteLine("# # # # # # #");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Hello! It is Calculator, created by kirishima Trin...");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Choose a type of calculator");
            Console.WriteLine("");
            Console.WriteLine("Special or typical: ");
            string type = Console.ReadLine();
            switch (type)
            {
                case "typical":
                    tipicalCalc();
                    break;
                case "special":
                    specialCalc();
                    break;
                default:
                    Console.WriteLine("Error1");
                    break;
            }
        }
        static void tipicalCalc()
        {
            Console.WriteLine("");
            for (int i = 9; i > 1; i++)
            {

                Console.Write("Input first number: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Input second number: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Input action: ");
                string act = Console.ReadLine();
                switch (act)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("error3. Inputed wrong data.");
                        break;
                }
                Console.WriteLine("press 'Enter'...");
                Console.ReadKey();
            }
        }
        static void specialCalc()
        {
            Console.WriteLine("");
            for (int i = 9; i > 1; i++)
            {
                Console.WriteLine("input action");
                Console.WriteLine("x^a - sqr");
                Console.WriteLine("√x - sqrt");
                Console.WriteLine("Sin a - sinus");
                Console.Write("Cos a - cosinus:");
                string act = Console.ReadLine();
                switch (act)
                {
                    case "sqr":
                        Console.Write("Input nuber: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input stage: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"answer:{Math.Pow((double)a, (double)b)}");
                        break;
                    case "sqrt":
                        Console.Write("Input number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        double s = Math.Sqrt(num);
                        Console.Write($"Result = {s}");
                        break;
                    case "sinus":
                        Console.Write("Input corner: ");
                        double corn = Convert.ToDouble(Console.ReadLine());
                        double res = Math.Sin(corn * Math.PI / 180);
                        Console.Write($"Sinus a ={res}");
                        break;
                    case "cosinus":
                        Console.Write("Input corner: ");
                        double corner = Convert.ToDouble(Console.ReadLine());
                        double result = Math.Cos(corner * Math.PI / 180);
                        Console.Write($"Cosinus A ={result}");
                        break;
                    default:
                        Console.WriteLine("Error2");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}