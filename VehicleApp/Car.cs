﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Car : Vehicle
    {
        public string Fuel { get; set; }
        public int NumberOfPassengers { get; set; }

        public Car(string name,
            string brand,
            double price,
            int warranty,
            string store,
            int numberOfPassengers,
            string fuel) : base(name, brand, price, warranty, store)
        {
            Fuel = fuel;
            NumberOfPassengers = numberOfPassengers;
        }

        public override string Operate()
        {
            return $"You turn on the ignition!";
        }

        public override string ToString()
        {
            return $"\r\nCar: {base.ToString()}; Passengers: {NumberOfPassengers}; Fuel: {Fuel}";
        }

        public override double CalculateInterest()
        {
            return (Price / 100) * 15;
        }
    }
}
