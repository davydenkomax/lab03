using System;

namespace InheritanceApp
{
    public class FlightWithBedding : Flight
    {
        private int bedding_percent;

        public FlightWithBedding(double price = 0, int cap = 0, int percent = 0)
            : base(price, cap)
        {
            bedding_percent = (percent >= 0 && percent <= 100) ? percent : 0;
        }

        public new void Read()
        {
            base.Read();
            do
            {
                Console.Write("Процент с постелью (0-100): ");
                bedding_percent = int.Parse(Console.ReadLine());
            } while (bedding_percent < 0 || bedding_percent > 100);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Постель: {bedding_percent}% (+50 руб)");
        }

        public override double ExpectedRevenue()
        {
            double baseRev = base.ExpectedRevenue();
            int count = (int)(capacity * bedding_percent / 100.0 + 0.5);
            return baseRev + count * 50.0;
        }
    }
}