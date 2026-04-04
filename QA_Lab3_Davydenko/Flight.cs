using System;

namespace InheritanceApp
{
    /**
     * @brief Базовый класс, представляющий авиарейс
     * @details Содержит основную информацию о рейсе: цену билета и вместимость.
     * Предоставляет методы для ввода/вывода данных и расчета ожидаемого дохода.
     */
    public class Flight
    {
        /**
         * @brief Цена билета на рейс (в рублях)
         */
        protected double ticket_price;

        /**
         * @brief Вместимость рейса (количество пассажиров)
         */
        protected int capacity;

        /**
         * @brief Конструктор класса Flight
         * @param price Цена билета (неотрицательное значение)
         * @param cap Вместимость (неотрицательное значение)
         */
        public Flight(double price = 0, int cap = 0) => Init(price, cap);

        /**
         * @brief Инициализация полей класса
         * @param price Цена билета
         * @param cap Вместимость
         */
        public void Init(double price, int cap)
        {
            ticket_price = (price >= 0) ? price : 0;
            capacity = (cap >= 0) ? cap : 0;
        }

        /**
         * @brief Ввод данных о рейсе с консоли
         * @details Выполняет валидацию вводимых данных 
         * (цена и вместимость не могут быть отрицательными)
         */
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

        /**
         * @brief Вывод информации о рейсе
         * @details Виртуальный метод, может быть переопределен в производных классах
         */
        public virtual void Display()
        {
            Console.WriteLine($"Рейс: Цена = {ticket_price}, Вместимость = {capacity}");
        }

        /**
         * @brief Расчет ожидаемого дохода от рейса
         * @return Ожидаемый доход = цена билета × вместимость
         * @code
         * Flight flight = new Flight(1000, 150);
         * double revenue = flight.ExpectedRevenue(); // возвращает 150000
         * @endcode
         */
        public virtual double ExpectedRevenue() => ticket_price * capacity;
    }
}