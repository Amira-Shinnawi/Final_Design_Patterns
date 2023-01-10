using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Behavioural_Pattern
{
    class Student : Observer
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine(this.name + " has new notification: " + message);
        }
    }
}
