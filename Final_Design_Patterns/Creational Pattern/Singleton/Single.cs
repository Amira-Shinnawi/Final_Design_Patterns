using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Singleton
{
    public class Single
    {
        public int count=0;
        private static Single instance;

        private Single()
        {
            Console.WriteLine("The obiect created");
        }
        public static Single GetInstance()
        {
            if (instance==null)
            {
                instance = new Single();
            }
            return instance;
        }
        public void showMessage()
        {
            Console.WriteLine("The obiect created Successfully ");
        }
        public void Addone() 
        {
            count++;
        }
    }
}
