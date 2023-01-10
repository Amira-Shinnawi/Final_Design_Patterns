using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Facade
{
    class Samsung : IMobileShop
    {
        public void getMobileModelNumber()
        {
            Console.WriteLine("The model is: Galaxy 11");
        }

        public void getMobilePrice()
        {
            Console.WriteLine("The price is: 85000INR ");
        }
    }
}
