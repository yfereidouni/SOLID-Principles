using System;

namespace InterfaceSegregation
{
    //Once we have our higher level interface, we can implement it in different ways.
    //The first one is to implement the required methods:

    public class MultiFunctionalCar02 : IMultiFunctionalVehicle
    {
        public void Drive()
        {
            //actions to start driving car
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            //actions to start flying
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}
