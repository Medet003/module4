using System;

public partial class Car
{
    // Поля
    private string make;          // Марка автомобиля
    private int year;             // Год выпуска
    private double price;         // Цена
    private bool isAvailable;     // Доступность
    private static int numberOfCars;  // Наличие
    private static string carType;    // Тип автомобиля

    // Конструкторы
    public Car(string make, int year, double price)
    {
        this.make = make;
        this.year = year;
        this.price = price;
        this.isAvailable = true;
        numberOfCars++;
    }

    public Car(string make, int year, double price, bool isAvailable)
    {
        this.make = make;
        this.year = year;
        this.price = price;
        this.isAvailable = isAvailable;
        numberOfCars++;
    }

    // Конструктор по умолчанию
    public Car()
    {
        this.make = "Unknown";
        this.year = DateTime.Now.Year;
        this.price = 0.0;
        this.isAvailable = false;
        numberOfCars++;
    }

    // Статический конструктор
    static Car()
    {
        carType = "Sedan";
        carType= "SUV";
        carType = "Jeep";
        carType = "Avant";
    }


    // Методы доступа
    public string GetMake()
    {
        return make;
    }

    public void SetMake(string make)
    {
        this.make = make;
    }

    public int GetYear()
    {
        return year;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public bool IsAvailable()
    {
        return isAvailable;
    }

    public void SetAvailability(bool isAvailable)
    {
        this.isAvailable = isAvailable;
    }

    // Методы управления классом
    public void Start()
    {
        Console.WriteLine("Автомобиль начал движение.");
    }

    public void Stop()
    {
        Console.WriteLine("Автомобиль остановился.");
    }

    public void Accelerate(int speed)
    {
        Console.WriteLine($"Автомобиль ускоряется до {speed} км/ч.");
    }

    public void Brake()
    {
        Console.WriteLine("Автомобиль начал тормозить.");
    }

    // Статические поля
    public static int GetNumberOfCars()
    {
        return numberOfCars;
    }

    public static string GetCarType()
    {
        return carType;
    }
}