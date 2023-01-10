using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.FactoryMethod
{
    class CheeseBurger:Sandwich
    {
        public CheeseBurger()
        {
            setName("CheeseBurger");
            setCalories(200);
        }
    }
}
