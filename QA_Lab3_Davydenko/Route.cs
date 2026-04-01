using System;

namespace InheritanceApp
{
    public class Route
    {
        private string name;
        private Flight flight1;
        private FlightWithBedding flight2;

        public void Read()
        {
            Console.Write("Название маршрута: ");
            name = Console.ReadLine();

            Console.WriteLine("\n--- Рейс 1 (обычный) ---");
            flight1 = new Flight();
            flight1.Read();

            Console.WriteLine("\n--- Рейс 2 (с постелью) ---");
            flight2 = new FlightWithBedding();
            flight2.Read();
        }

        public void Display()
        {
            Console.WriteLine("Маршрут: " + name);
            Console.WriteLine("Рейс 1:");
            flight1.Display();
            Console.WriteLine("Рейс 2:");
            flight2.Display();
        }

        public double TotalRevenue()
        {
            return flight1.ExpectedRevenue() + flight2.ExpectedRevenue();
        }
    }
}