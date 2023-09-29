using System;

public partial class Car
{
    // Дополнительный метод в другом файле с использованием partial
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Марка: {make}");
        Console.WriteLine($"Год выпуска: {year}");
        Console.WriteLine($"Цена: {price:C}KZT");
        Console.WriteLine($"Доступность: {(isAvailable ? "Доступен" : "Недоступен")}");
    }
}
