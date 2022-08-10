using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        
        struct Car
        {
            string name;
            string brand;
            string fuelType;
            float fuelTankCapacity;

            public Car(string name,string brand, string fuelType, float fuelTankCapacity)
            {
                this.name = name;
                this.brand = brand;
                this.fuelType = fuelType;
                this.fuelTankCapacity = fuelTankCapacity;
            }

            public string getName()
            {
                return this.name;
            }
        }

        static void Main(string[] args)
        {
            Car firstCar = new Car("Gol Qaudrado","Volkswagen","Gasolina",50.10f);
            Console.WriteLine($"O nome do Automóvel é: {firstCar.getName()}");
            Console.ReadLine();
        }
    }
}
