using System;

namespace Day07_Objects_Continued
{
    class Program
    {
        static void Main(string[] args)
        {
            Students klasesbiedrs = new Students();

            Console.WriteLine("Vards");
            klasesbiedrs.vards = Console.ReadLine();

            Console.WriteLine("Uzvards");
            klasesbiedrs.uzvards = Console.ReadLine();

            Console.WriteLine("Kurss");
            try 
            {
                klasesbiedrs.kurss = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Kļuda, vai ievadiji skaitļus?");
            }

            klasesbiedrs.PrintInfo();
        }
    }
}
