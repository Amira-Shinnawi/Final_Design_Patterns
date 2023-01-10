using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Facade
{
    class IPhone : IMobileShop
    {
        public void getMobileModelNumber()
        {
            Console.WriteLine("The model is: IPhone 13");
        }

        public void getMobilePrice()
        {
            Console.WriteLine("The price is: 75000INR ");
        }
    }
}
