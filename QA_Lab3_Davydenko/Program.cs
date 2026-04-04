using System;

namespace InheritanceApp
{
    /**
     * @brief Главный класс программы
     * @details Демонстрирует работу классов Flight, FlightWithBedding и Route.
     * Показывает ввод данных, вывод информации и расчет доходов.
     */
    class Program
    {
        /**
         * @brief Точка входа в программу
         * @details Создает объекты рейсов и маршрута,
         * запрашивает ввод данных, выводит результаты расчетов.
         */
        static void Main()
        {
            Route route = new Route();
            route.Read();
            route.Display();
            Console.WriteLine($"Суммарный доход: {route.TotalRevenue()} руб");

            Console.WriteLine("\n--- Динамический ---");
            Route dynamic = new Route();
            dynamic.Read();
            dynamic.Display();
            Console.WriteLine($"Суммарный доход: {dynamic.TotalRevenue()} руб");

            Console.ReadKey();
        }
    }
}