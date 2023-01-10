using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Adapter
{
    class Bicycle
    {
        public void pedal()
        {
            Console.WriteLine("Bike start moving");
        }
        public void stop()
        {
            Console.WriteLine("Bike Stopped");
        }
        public void ringBill()
        {
            Console.WriteLine("Ring...Ring");
        }
    }
}
