using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.FactoryMethod
{
    class sandwichFactory
    {
        public static int Cheese_Burger = 1;
        public static int Chicken_Burger = 2;

        public static Sandwich createSandwich(int sandwichId)
        {
            switch (sandwichId)
            {
                case 1:
                    return new CheeseBurger();
                    break;
                case 2:
                    return new ChickenBurger();
                    break;
                default:
                    return null;
                    break;
            }
                
        }
    }
}
