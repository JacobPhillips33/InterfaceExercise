using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public double CargoHoldSize { get; set; }
        public bool HasSkiRack { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }

        public void PrintProperties()
        {
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Has Ski Rack: {HasSkiRack}");
            Console.WriteLine($"Cargo Hold Size: {CargoHoldSize} cubic feet");
            Console.WriteLine($"Company Name: {CompanyName}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
