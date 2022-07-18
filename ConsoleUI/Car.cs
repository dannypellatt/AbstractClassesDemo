using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {


        bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            throw new NotImplementedException();
        }
    }
}

