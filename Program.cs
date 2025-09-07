using System;
using System.Diagnostics.Contracts;
using System.IO.Pipelines;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Mr.Wizzeman's pro calculator";

            char choice;
            do
            {
                Console.WriteLine("First number ");
                double a = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("operator (+,-,/,*,%,p)");
                Char ope = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("second number ");
                double b = Convert.ToDouble(Console.ReadLine());
                double result = 0;

                switch (ope)
                {
                    case '+':
                        result = Sum(a, b);
                        break;

                    case '-':
                        result = Sub(a, b);
                        break;

                    case '/':

                        result = divide(a, b);
                        break;

                    case '*':

                        result = mult(a, b);
                        break;

                    case '%':
                        result = remain(a, b);
                        break;

                    case 'p':
                        result = power(a, b);
                        break;
                }

                if (ope == '+' || ope == '-' || ope == '*' || (ope == '/' && b != 0) || ope=='p' || ope=='%' )
                {
                    Console.WriteLine($"{a} {ope} {b} = {result}");
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice=='y'||choice=='Y');

        
        }

        static double Sum(double a, double b)
        {
            double result = a + b;
            return result;

        }

        static double Sub(double a, double b)
        {
            double result = a - b;
            return result;
        }

        static double mult(double a, double b)
        {
            double result = a * b;
            return result;
        }

        static double divide(double a, double b)
        {
            while (b == 0)
            {
                System.Console.WriteLine("Please dont insert fucking 0!!!!!");
                System.Console.WriteLine("So, please dont insert 0 again");
                b = Convert.ToDouble(Console.ReadLine());
            }

            double result = a / b;
            return result;
        }

        static double remain(double a, double b)
        {
            while (b == 0)
            {
                System.Console.WriteLine("Please dont insert fucking 0!!!!!");
                System.Console.WriteLine("So, please dont insert 0 again");
                b = Convert.ToDouble(Console.ReadLine());
            }

            double remain = a % b;
            return remain;
        }

        static double power(double a, double b)
        {
            
           
            return Math.Pow(a,b);
        }
    }
}