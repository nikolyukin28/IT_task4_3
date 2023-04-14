
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса WarehouseItem
            WarehouseItem item1 = new WarehouseItem("Product A", 10.0, 5);
            item1.PrintInfo();

            // Создание объекта класса WarehouseItemWithYear
            WarehouseItemWithYear item2 = new WarehouseItemWithYear("Product B", 20.0, 3, 2020);
            item2.PrintInfo();
        }
    }
}
