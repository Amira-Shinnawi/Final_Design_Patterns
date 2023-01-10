using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Bridge
{
    abstract class Shape
    {
       public  Color color;
        public Shape(Color color)
        {
            this.color = color;
        }
        abstract public void applyColor();
    }
}
