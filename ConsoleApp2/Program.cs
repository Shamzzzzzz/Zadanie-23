using ClassLibrary1.GarageLibrary;
using ClassLibrary1.GarageLibrary;
using System;

class Program
{
    static void Main(string[] args)
    {
        Garage myGarage = new Garage { Name = "Мой гараж", Address = "ул. Юбилейная, 123" };

        myGarage.Cars.Add(new Car { Owner = "Алексей Никонов", Number = "В644ТК" });
        myGarage.Cars.Add(new Car { Owner = "Артем Бузовкин", Number = "В777ОР" });
        myGarage.Cars.Add(new Car { Owner = "Иван Хилков", Number = "А111АА" });

        myGarage.ShowAll();
        Console.ReadKey(); // Делал Никонов Алексей
    }
}
