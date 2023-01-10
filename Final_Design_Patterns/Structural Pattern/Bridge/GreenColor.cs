using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Bridge
{
    class GreenColor : Color
    {
        public void applyColor()
        {
            Console.WriteLine("green.");
        }
    }
}
