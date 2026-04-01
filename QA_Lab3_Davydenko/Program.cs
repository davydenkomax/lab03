using System;
using System.Collections;

namespace InheritanceApp
{
    class CollectionProgram
    {
        static void Main()
        {
            ArrayList flights = new ArrayList();
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                int type = rnd.Next(2); 

                if (type == 0)
                {
                    double price = rnd.Next(1000, 10000);
                    int cap = rnd.Next(50, 300);

                    flights.Add(new Flight(price, cap));
                }
                else
                {
                    double price = rnd.Next(1000, 10000);
                    int cap = rnd.Next(50, 300);
                    int percent = rnd.Next(0, 101);

                    flights.Add(new FlightWithBedding(price, cap, percent));
                }
            }

            int countFlight = 0;
            int countBedding = 0;

            double sumFlight = 0;
            double sumBedding = 0;

            Console.WriteLine("=== Коллекция объектов ===");

            foreach (object obj in flights)
            {
                Flight f = (Flight)obj;
                f.Display();
                Console.WriteLine();

                string typeName = obj.GetType().Name;
                double revenue = f.ExpectedRevenue(); 

                if (typeName == "Flight")
                {
                    countFlight++;
                    sumFlight += revenue;
                }
                else
                {
                    countBedding++;
                    sumBedding += revenue;
                }
            }

            Console.WriteLine("=== Итоги ===");
            Console.WriteLine($"Обычные рейсы: {countFlight}, сумма доходов = {sumFlight:F2}");
            Console.WriteLine($"Рейсы с постелью: {countBedding}, сумма доходов = {sumBedding:F2}");

            Console.ReadKey();
        }
    }
}
