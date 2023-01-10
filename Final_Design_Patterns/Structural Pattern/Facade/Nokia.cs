using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Facade
{
    class Nokia : IMobileShop
    {
        public void getMobileModelNumber()
        {
            Console.WriteLine("The model is: Nokia 1100");
        }

        public void getMobilePrice()
        {
            Console.WriteLine("The price is: 1500INR ");
        }
    }
}
