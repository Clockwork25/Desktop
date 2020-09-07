using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day06_Task1
{
    class Program
    {



        static void Main(string[] args)
        {
            Task2();
        }


/*
        private static void TrySample()
        {
            try
            {
                Console.WriteLine("");
                int number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade");
            }
        }
*/

        static void Task2()
        {
            List<String> lst = new List<String>();
            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("1- Izvadit");
                Console.WriteLine("2- Pievienot");
                Console.WriteLine("3- Noņemt elementu");
                Console.WriteLine("0- Iziet");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintLst(lst);
                        break;
                    case "2":
                        AddElement(lst);
                        break;
                    case "3":

                        Console.WriteLine("Ievadi, kuru gribi noņemt");

                        PrintLst(lst);

                        try
                        {
                            int rem = Convert.ToInt32(Console.ReadLine());
                            RemoveElement(lst, rem);
                        }
                        catch
                        {
                            Console.WriteLine("Kļūda ievadē! Ievadi skaitli.");
                        }


                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }

        private static void RemoveElement(List<string> lst, int rem)
        {
            try
            {
                lst.RemoveAt(rem);
            }
            catch
            {
                Console.WriteLine("kļūda ievadē");
            }
        }

        private static void AddElement(List<string> lst)
        {

            try
            {

                Console.WriteLine();
                Console.WriteLine("Ievadiet elementu!");
                lst.Add(Console.ReadLine());
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine("Kļūda ievadē");
            }

        }

        private static void PrintLst(List<string> lst)
        {
            Console.WriteLine();

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(i + ": " + lst[i]);
            }
            Console.WriteLine();
        }

        /* static void ListSample()
         {
             List<String> lst = new List<String>();

             lst.Add("aa");
             lst.Add("bb");

             for (int i = 0; i < lst.Count; i++)
             {
                 Console.WriteLine(lst[i]);
             }

             foreach (String value in lst)
             {
                 Console.WriteLine(value);
             }
         }

         static void Task1()
         {
             String choice = "";

             while (choice != "exit")
             {
                 Console.WriteLine("Ievadiet darbibu! : +,-,*,/ vai exit");
                 choice = Console.ReadLine();

                 double number1 = InputDouble(1);

                 double number2 = InputDouble(2);

                 switch (choice)
                 {
                     case "+":
                         Console.WriteLine(Darbibas.Sum(number1, number2));
                         break;
                     case "-":
                         Console.WriteLine(Darbibas.Sub(number1, number2));
                         break;

                     case "*":
                         Console.WriteLine(Darbibas.Mul(number1, number2));
                         break;

                     case "/":
                         Console.WriteLine(Darbibas.Div(number1, number2));
                         break;
                     case "exit":
                         break;
                     default:
                         Console.WriteLine("nepareiza ievade!");
                         break;
                 }


             }

             static double InputDouble(int number)
             {
                 double result = 0;
                 try
                 {
                     Console.WriteLine("Ievadiet " + number + ". skaitli!");
                     result = Convert.ToDouble(Console.ReadLine());
                 }
                 catch
                 {
                     result = InputDouble(number);
                 }

                 return result;
             }

         }*/
    }
}