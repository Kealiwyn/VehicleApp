using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    abstract class Vehicle : ISellable
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Store { get; set; }
        public int Warranty { get; set; }

        public Vehicle(string name, string brand, double price, int warranty, string store)
        {
            Brand = brand;
            Name = name;
            Price = price;
            Store = store;
            Warranty = warranty;
        }

        public abstract string Operate();

        public override string ToString()
        {
            return $"Name: {Name}; Brand: {Brand}; Price: {Price}; Warranty: {Warranty}; Store: {Store}";
        }

        public string MakeSale()
        {
            return $"This is how we make a sale!";
        }

        public abstract double CalculateInterest();
    }
}
