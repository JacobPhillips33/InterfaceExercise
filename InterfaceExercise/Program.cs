using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE - TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //DONE - Create 3 classes called Car , Truck , & SUV

            //DONE - In your IVehicle

            /*DONE -  Create 4 members that Car, Truck, & SUV all have in common.
             *DONE -  Example: All vehicles have a number of wheels... for now..
             */


            //DONE - In ICompany

            /*DONE - Create 2 members that are specific to each every company regardless of vehicle type.
             *DONE - Example: public string Logo { get; set; }
             */

            //DONE - In each of your car, truck, and suv classes

            /*DONE - Create 2 members that are specific to each class
             *DONE - Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //DONE - Now, create objects of your 3 classes and give their members values;
            //DONE - Creatively display and organize their values

            var car = new Car()
            {
                Year = 2022,
                Make = "Aston Martin",
                Model = "Vanquish",
                Color = "Silver Grey",
                CompanyName = "Aston Martin Lagonda Global Holdings PLC",
                Logo = "Wings",
                HasTrunk = true,
                IsAutomatic = false
            };

            var truck = new Truck()
            {
                Year = 2016,
                Make = "Ford",
                Model = "F-150",
                Color = "Black",
                CompanyName = "Ford Motor Company",
                Logo = "Ford circled in blue",
                Is4WD = true,
                BedSize = 96
            };

            var suv = new SUV()
            {
                Year = 2018,
                Make = "Jeep",
                Model = "Grand Cherokee",
                Color = "White",
                CompanyName = "Fiat Chrysler",
                Logo = "Jeep",
                HasSkiRack = true,
                CargoHoldSize = 37.7
            };

            car.PrintProperties();
            truck.PrintProperties();
            suv.PrintProperties();
        }
    }
}
