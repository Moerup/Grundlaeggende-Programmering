using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner_avanceret
{
    class Program
    {
        static void Main(string[] args)
        {
            char Givenoperator = '+';
            double num1 = 0;
            double num2 = 0;
            double sum = 0;
            bool exit = false;



            while (exit == false)
            {
                if (sum == 0)
                {
                    Console.WriteLine("Insert number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    num1 = sum;
                }
                //Løkke for at kunne regne videre på resultatet hvis summen ikke = 0
                Console.WriteLine("Choose operator: ");
                Givenoperator = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine("Insert number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                switch (Givenoperator)
                {
                    case '+':
                        sum = Add(num1, num2);
                        break;
                    case '-':
                        sum = Minus(num1, num2);
                        break;
                    case '/':
                        sum = Divide(num1, num2);
                        break;
                    case '*':
                        sum = Multiply(num1, num2);
                        break;
                    case '.':
                        exit = true;
                        break;

                }
                Console.Clear();
                Console.WriteLine("Result: {0} {1} {2} = {3}", num1, Givenoperator, num2, sum);
            }

        }
        static double Add(double num1, double num2)
        {
            double Result = num1 + num2;
            return Result;
        }
        static double Minus(double num1, double num2)
        {
            double Result = num1 - num2;
            return Result;
        }
        static double Divide(double num1, double num2)
        {
            double Result = num1 / num2;
            return Result;
        }
        static double Multiply(double num1, double num2)
        {
            double Result = num1 * num2;
            return Result;
        }
    }
}
