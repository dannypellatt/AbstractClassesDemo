using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public virtual int DoorNumber { get; set; } = 4;

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"My vehicle is a {Make} {Model}, made in the year {Year}.");
        }

        
        
       

    }
}

