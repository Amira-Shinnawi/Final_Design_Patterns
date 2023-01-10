using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.FactoryMethod
{
    class Sandwich
    {
        private string name;
        private int calories;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getCalories()
        {
            return calories;
        }
        public void setCalories(int Calories)
        {
            this.calories = Calories;
        }

        public void prepare()
        {
            Console.WriteLine(this.name+" is prepared with "+this.calories+" Calories");
        }
    }
}
