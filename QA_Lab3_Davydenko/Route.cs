using System;

namespace InheritanceApp
{
    /**
     * @brief Класс, представляющий маршрут, состоящий из двух рейсов
     * @details Содержит обычный рейс и рейс с постельным бельем.
     * Демонстрирует полиморфизм и композицию.
     */
    public class Route
    {
        /**
         * @brief Название маршрута
         */
        private string name;

        /**
         * @brief Первый рейс (обычный)
         */
        private Flight flight1;

        /**
         * @brief Второй рейс (с постельным бельем)
         */
        private FlightWithBedding flight2;

        /**
         * @brief Ввод данных о маршруте с консоли
         * @details Запрашивает название маршрута и данные для обоих рейсов
         */
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

        /**
         * @brief Вывод информации о маршруте
         * @details Отображает название маршрута и информацию о каждом рейсе
         */
        public void Display()
        {
            Console.WriteLine("Маршрут: " + name);
            Console.WriteLine("Рейс 1:");
            flight1.Display();
            Console.WriteLine("Рейс 2:");
            flight2.Display();
        }

        /**
         * @brief Расчет суммарного дохода от маршрута
         * @return Сумма ожидаемых доходов всех рейсов маршрута
         * @details Демонстрирует полиморфизм: для каждого рейса 
         * вызывается свой метод ExpectedRevenue()
         */
        public double TotalRevenue()
        {
            return flight1.ExpectedRevenue() + flight2.ExpectedRevenue();
        }
    }
}