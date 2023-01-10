using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Bridge
{
    class Triangle : Shape
    {
        public Triangle(Color color) : base(color) { }
        public override void applyColor()
        {
            Console.WriteLine("Triangle filled with color ");

             color.applyColor();
        }
    }
}
