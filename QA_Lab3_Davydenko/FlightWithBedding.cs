using System;

namespace InheritanceApp
{
    /**
     * @brief Класс рейса с дополнительной услугой - постельным бельем
     * @details Наследует класс Flight. Добавляет возможность указать процент пассажиров,
     * заказывающих постельное белье, что увеличивает доход на 50 руб. за каждого.
     */
    public class FlightWithBedding : Flight
    {
        /**
         * @brief Процент пассажиров, заказывающих постельное белье (0-100%)
         */
        private int bedding_percent;

        /**
         * @brief Конструктор класса FlightWithBedding
         * @param price Цена билета (передается в базовый класс)
         * @param cap Вместимость (передается в базовый класс)
         * @param percent Процент пассажиров с постелью (0-100)
         */
        public FlightWithBedding(double price = 0, int cap = 0, int percent = 0)
            : base(price, cap)
        {
            bedding_percent = (percent >= 0 && percent <= 100) ? percent : 0;
        }

        /**
         * @brief Ввод данных о рейсе с постелью
         * @details Переопределяет метод Read() базового класса
         * Сначала вызывает базовый метод, затем запрашивает процент с постелью
         */
        public new void Read()
        {
            base.Read();
            do
            {
                Console.Write("Процент с постелью (0-100): ");
                bedding_percent = int.Parse(Console.ReadLine());
            } while (bedding_percent < 0 || bedding_percent > 100);
        }

        /**
         * @brief Вывод информации о рейсе с постелью
         * @details Переопределяет виртуальный метод Display() базового класса
         * Вызывает базовый метод и добавляет информацию о постельном белье
         */
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Постель: {bedding_percent}% (+50 руб)");
        }

        /**
         * @brief Расчет ожидаемого дохода с учетом дополнительной услуги
         * @return Общий доход = базовый доход + (количество пассажиров с постелью × 50 руб.)
         * @details Количество пассажиров с постелью вычисляется с округлением:
         * @code
         * count = capacity × bedding_percent / 100 + 0.5
         * @endcode
         * @code
         * FlightWithBedding flight = new FlightWithBedding(1000, 150, 30);
         * // Базовый доход: 150000
         * // Пассажиров с постелью: 45
         * // Дополнительный доход: 2250
         * // Итого: 152250 руб.
         * double revenue = flight.ExpectedRevenue();
         * @endcode
         */
        public override double ExpectedRevenue()
        {
            double baseRev = base.ExpectedRevenue();
            int count = (int)(capacity * bedding_percent / 100.0 + 0.5);
            return baseRev + count * 50.0;
        }
    }
}