using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    namespace GarageLibrary
    {
        public class Garage
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public List<Car> Cars { get; set; } = new List<Car>();

            public void ShowAll()
            {
                Cars.Sort((x, y) => x.Number.CompareTo(y.Number)); // Сортировка по номеру
                Console.WriteLine($"Название гаража: {Name}");
                Console.WriteLine($"Адрес гаража: {Address}");
                Console.WriteLine("Машины в гараже:");
                foreach (Car car in Cars)
                {
                    car.Show();
                }
            }
        }

        public class Car
        {
            public string Owner { get; set; }
            public string Number { get; set; }

            public void Show()
            {
                Console.WriteLine($"  Владелец: {Owner}, Номер: {Number}");// выполнил Никонов Алексей Владиславович
            }
        }
    }
}