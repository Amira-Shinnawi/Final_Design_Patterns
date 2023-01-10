using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Adapter
{
    class BicycleAdapter:Vehicle
    {
         Bicycle bike=new Bicycle();
        public BicycleAdapter(Bicycle bike)
        {
            this.bike = bike;
        }

        public void acceleration()
        {
            this.bike.pedal();
        }

        public void Break()
        {
            this.bike.stop();
        }

        public void soundHorn()
        {
            this.bike.ringBill();
        }
    }
}
