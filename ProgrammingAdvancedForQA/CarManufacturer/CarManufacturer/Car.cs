using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumation { get; set; }

        public Car()
        {
        }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumation)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumation = fuelConsumation;
        }

        public void Drive(double distance)
        {
            if (FuelConsumation - distance * FuelConsumation >= 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public void WhoAmI()
        {
            Console.WriteLine($"Make: {Make}\r\nModel: {Model}\r\nYear: {Year}\r\nFuel: {FuelQuantity:F2}");
        }


    }
}

