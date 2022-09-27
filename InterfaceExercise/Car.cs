using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {        
        public bool HasTrunk { get; set; }
        public bool IsAutomatic { get; set; }
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
            Console.WriteLine($"Has Trunk: {HasTrunk}");
            Console.WriteLine($"Is Automatic: {IsAutomatic}");
            Console.WriteLine($"Company Name: {CompanyName}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
