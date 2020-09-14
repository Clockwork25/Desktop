using System;
using System.Collections.Generic;

namespace Day9_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4();
        }

        static void Task4()
        {
            List<int> lst = FileOperations.Read();

            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("1- Izvadit");
                Console.WriteLine("2- Pievienot");
                Console.WriteLine("3- Dzest");
                Console.WriteLine("4- Vidējais");
                Console.WriteLine("5- Summa");
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
                        RemoveElement(lst);
                        break;
                    case "4":
                        AvgElements(lst);
                        break;
                    case "5":
                        SumElements(lst);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }

        private static void SumElements(List<int> lst)
        {
            int total = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                total += lst[i];

            }
            Console.WriteLine("Summa ir:" + total); ;

        }

        private static void AvgElements(List<int> lst)
        {
            int total = 0;
            for (int i = 0; i<lst.Count; i++)
            {
                total += lst[i];

            }
            double avgTotal = (double) (total/lst.Count);

            Console.WriteLine("Vidējais ir: " + avgTotal);

        }

        private static void PrintLst(List<int> lst)
        {
            Console.WriteLine();

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            for (int i = 0; i < lst.Count; i++)
            {

                    try
                    {
                        Convert.ToInt32(lst[i]);
                        Console.WriteLine(i + ": " + lst[i]);

                    }
                    catch
                    {
                        Console.WriteLine(i + " nav skaitlis");
                    }
            }
            Console.WriteLine();
        }
        private static void RemoveElement(List<int> lst)
        {
            Console.WriteLine();

            PrintLst(lst);

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            try
            {
                Console.WriteLine("Kuru elementu velaties dzest?");
                int toDelete = Convert.ToInt32(Console.ReadLine());
                lst.RemoveAt(toDelete);
                FileOperations.Write(lst);
            }
            catch
            {
                Console.WriteLine("Kludaina ievade!");
            }


            Console.WriteLine();
        }

        private static void AddElement(List<int> lst)
        {
            Console.WriteLine();
            Console.WriteLine("Ievadiet elementu!");
            try
            {
                lst.Add(Convert.ToInt32(Console.ReadLine()));
                FileOperations.Write(lst);
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Ievadīto elemntu nevar pārkonvertēt uz Int");
                AddElement(lst);
            }

        }
    }
}
