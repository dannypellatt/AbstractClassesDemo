
using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

        bool HasSideCart { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"You ride the {Make}"); ;
        }

        public override int DoorNumber { get; set; } = 0;

    }
}

