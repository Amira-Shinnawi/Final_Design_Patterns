using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.FactoryMethod
{
    class ChickenBurger:Sandwich
    {
        public ChickenBurger()
        {
            setName("ChickenBurger");
            setCalories(150);
        }
    }
}
