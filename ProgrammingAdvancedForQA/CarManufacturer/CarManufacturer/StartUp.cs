﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumation = 200;

            car.Drive(2000);
            car.WhoAmI();
            Car secondCar = new Car("Audi", "A3", 2000);
            Car thirdCar = new Car("BMW", "320", 2004, 25.5, 10.2);


        }
    }
}
