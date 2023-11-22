using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumation { get; set; }

        public void Drive(double distance)
        {
            if (FuelConsumation - distance * FuelConsumation < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public void WhoAmI()
        {
            Console.WriteLine($"Make: {this.Make}\r\nModel: {this.Model}\r\nYear: {this.Year}\r\nFuel: {this.FuelQuantity:F2}");
        }


    }
}
