using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Создание массива объектов
        Car[] cars = new Car[5];
        cars[0] = new Car("Toyota", 2004, 7000000, false); //тут добавляю false для того чтобы вывело что недоступно авто
        cars[1] = new Car("BMW M5 Competition", 2022, 30000000, true); //тут наоборот true что доступно
        cars[2] = new Car("Audi RS6", 2021, 35000000); //здесь показываю что если авто доступно, можно и не писать true
        cars[3] = new Car(); //пустышка
        cars[4] = new Car("BMW XB7(Alpina)", 2023, 95000000);

        // Вывод информации о каждом автомобиле
        foreach (Car car in cars)
        {
            car.DisplayCarInfo();
            Console.WriteLine();
        }

        // Вызов статических методов и полей
        Console.WriteLine($"Общее количество автомобилей: {Car.GetNumberOfCars()}");
        Console.WriteLine($"Тип автомобиля: {Car.GetCarType()}");
    }
}

