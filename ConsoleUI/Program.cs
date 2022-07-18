using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle   DONE
             * The vehicle class shall have three string properties Year, Make, and Model   DONE
             * Set the defaults to something generic in the Vehicle class   DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation   DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.   DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle  DONE
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle   DONE
             * Provide the implementations for the abstract methodsAbs
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles    DONE

            List<Vehicle> vehicleList = new();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax    DONE
             */

            Car car1 = new Car();
            Motorcycle bike1 = new Motorcycle();
            Vehicle car2 = new Car();
            Vehicle car3 = new Car();

            car1.Make = "Mercedes";
            car1.Model = "GL450";
            car1.Year = 2015;
            car1.DoorNumber = 4;
            vehicleList.Add(car1);

            bike1.Make = "Harley Davidson";
            bike1.Model = "Sportster";
            bike1.Year = 1997;
            vehicleList.Add(bike1);

            car2.Make = "Mini";
            car2.Model = "Cooper";
            car2.Year = 1967;
            car2.DoorNumber = 2;
            vehicleList.Add(car2);

            car3.Make = "Ford";
            car3.Model = "Focus Estate";
            car3.Year = 2008;
            vehicleList.Add(car3);

            /*
             * Add the 4 vehicles to the list   ???DONE???   .Add
             * Using a foreach loop iterate over each of the properties
             */

            foreach (var item in vehicleList)
            {
                Console.WriteLine(item);
            }

            // Call each of the drive methods for one car and one motorcycle

            car1.DriveVirtual(car1);
            bike1.DriveVirtual(bike1);

            #endregion            
            Console.ReadLine();
        }
    }
}
