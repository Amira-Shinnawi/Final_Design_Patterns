using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Adapter
{
    class Car : Vehicle
    {
        public void acceleration()
        {
            Console.WriteLine("Car start moving");
        }

        public void Break()
        {
            Console.WriteLine("Car Stopped");
        }

        public void soundHorn()
        {
            Console.WriteLine("Beeb...Beeb");
        }
    }
}
