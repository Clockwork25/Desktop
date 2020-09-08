using System;

namespace Day6_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Klase klasesbiedrs = new Klase();

            Console.WriteLine("Ievadiet vardu!");
            klasesbiedrs.vards = Console.ReadLine();

            Console.WriteLine("Ievadiet uzvardu!");
            klasesbiedrs.uzvards = Console.ReadLine();

            Console.WriteLine("Ievadiet kursu!");
            klasesbiedrs.kurss = Convert.ToInt32(Console.ReadLine());

            klasesbiedrs.PrintInfo();

        }

        static void Sample1()
        {
            Car car1 = new Car();
            car1.SetColor("Red");
            car1.brand = "Volkswagen";
            car1.model = "Jetta";

            Car car2 = new Car();
            car2.SetColor("White");
            car2.brand = "BMW";
            car2.model = "M3";

            Console.WriteLine(car2.GetColor() + " " + car2.brand);

            car1.PrintInfo();

            car2.PrintInfo();
        }
    }
}