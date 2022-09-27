using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {     
        public bool Is4WD { get; set; }
        public double BedSize { get; set; }
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
            Console.WriteLine($"Is 4WD: {Is4WD}");
            Console.WriteLine($"Truck Bed Size: {BedSize} inches");
            Console.WriteLine($"Company Name: {CompanyName}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
