using System;

namespace InheritanceApp
{
    public class Flight
    {
        protected double ticket_price;
        protected int capacity;

        public Flight(double price = 0, int cap = 0) => Init(price, cap);
        public void Init(double price, int cap)
        {
            ticket_price = (price >= 0) ? price : 0;
            capacity = (cap >= 0) ? cap : 0;
        }
        public void Read()
        {
            do
            {
                Console.Write("Цена билета (>=0): ");
                ticket_price = double.Parse(Console.ReadLine());
            } while (ticket_price < 0);
            do
            {
                Console.Write("Вместимость (>=0): ");
                capacity = int.Parse(Console.ReadLine());
            } while (capacity < 0);
        }
        public virtual void Display()
        {
            Console.WriteLine($"Рейс: Цена = {ticket_price}, Вместимость = {capacity}");
        }
        public virtual double ExpectedRevenue() => ticket_price * capacity;
    }
}