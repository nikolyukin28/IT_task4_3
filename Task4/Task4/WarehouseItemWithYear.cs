using System;

namespace Task4
{
    class WarehouseItemWithYear : WarehouseItem
    {
        public int Year { get; set; }

        public WarehouseItemWithYear(string name, double price, int quantity, int year) : base(name, price, quantity)
        {
            Year = year;
        }

        public new double CalculateQuality()
        {
            int currentYear = DateTime.Now.Year;
            double quality = base.CalculateQuality();
            return quality + 0.5 * (currentYear - Year);
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Quality (with year): {CalculateQuality()}");
        }
    }
}
