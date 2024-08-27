using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

         List<Vehicle> vehicleLists = new List<Vehicle>();

         var car = new Car();
         car.Year = 1998;
         car.Make = "Viper";
         car.Model = "Dodge";


         var motorcycle = new Motorcycle();
         motorcycle.Year = 1998;
         motorcycle.Make = "Suzuki";
         motorcycle.Model = "GXR";
         
         vehicleLists.Add(motorcycle);
         vehicleLists.Add(car);
         foreach (var vehical in vehicleLists)
         {
          Console.WriteLine($"This is my {vehical.Year} {vehical.Make} it's pretty fast."); 
          Console.WriteLine($"It's my favorite {vehical.Model} that's made.");
          Console.WriteLine();
          
         }





         /*
          * Todo: Follow all comments!!
          * Double click on the region (gray box) to view all comments
          */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveAbstract with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            
            
             
            
            
            

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
