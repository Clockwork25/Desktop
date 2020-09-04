using Microsoft.Win32.SafeHandles;
using System;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primitīvs Kalkulators ar diviem skaitļiem");

            Console.WriteLine("Ievadi a");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ievadi b");
            double input2 = Convert.ToDouble(Console.ReadLine());
            double answer = 0;

            Console.WriteLine("+ ir saskaitīšanai, - ir atņemšanai \n * rezināšanai, / dalīšanai");
            String choice = Console.ReadLine();

            if (choice == "+")
            {
               answer = Plus(input1,input2);
            }
            else if (choice == "-")
            {
                answer = Min(input1, input2);
            }
            else if (choice == "*")
            {
                answer = Mult(input1, input2);
            }
            else if (choice == "/")
            {
                answer = Div(input1, input2);
            }
            else
            {
                Console.WriteLine("error, atkārto ievadi vēlreiz");
            }

            Console.WriteLine("a+b= "+ answer);
            
        }
        static Double Plus(double a, double b)
        {
            return (a + b);
        }
        static Double Min(double a, double b)
        {
            return (a - b);
        }
        static Double Mult(double a, double b)
        {
            return (a * b);
        }
        static Double Div(double a, double b)
        {
            return (a / b);
        }
    }
}
