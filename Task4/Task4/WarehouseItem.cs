using System;

namespace Task4
{
    class WarehouseItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public WarehouseItem(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double CalculateQuality()
        {
            return Price / Quantity;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Quality: {CalculateQuality()}");
        }
    }
}
