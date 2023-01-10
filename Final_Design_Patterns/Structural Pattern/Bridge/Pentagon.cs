using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Bridge
{
    class Pentagon : Shape
    {
        public Pentagon(Color color) : base(color) { }
        public override void applyColor()
        {
            Console.WriteLine("Pentagon filled with color ");
            color.applyColor();
        }
    }
}
