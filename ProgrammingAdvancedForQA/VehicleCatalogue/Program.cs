using System;

namespace VehicleCatalogue
{
    class Trucks
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

        public Trucks(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
    class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HoursePower { get; set; }
    
        public Cars(string brand, string model, string hoursePower)
        {
            Brand = brand;
            Model = model;
            HoursePower = hoursePower;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trucks> trucks = new List<Trucks>();
            List<Cars> cars = new List<Cars>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("/");
                if(input[0] == "end") 
                {
                    break;
                }
                else if (input[0] == "Car")
                {
                    string brand = input[1];
                    string model = input[2];
                    string hoursePower = input[3];
                    cars.Add(new Cars(brand, model, hoursePower));
                }
                else 
                {
                    string brand = input[1];
                    string model = input[2];
                    string weight = input[3];
                    trucks.Add(new Trucks(brand, model, weight));
                }

                
            }
            List<Cars> sortedCars = new List<Cars>();
            if(cars.Count > 0) 
            {
                sortedCars = cars.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Cars:");
            }
            
            foreach (var car in sortedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
            }
            List<Trucks> sortedTrucks = new List<Trucks>();
            if (trucks.Count > 0)
            {
                sortedTrucks = trucks.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Trucks:");
            }
            
            foreach (var truck in sortedTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}