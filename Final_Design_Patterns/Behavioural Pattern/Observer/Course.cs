using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Behavioural_Pattern
{
    class Course:ISubject
    {
        private string name;
        private string availability;

        private ArrayList observerslist;
        public Course(string name)
        {
            this.name = name;
            observerslist = new ArrayList();
        }

        public void NotifyAllSubscriber()
        {
            foreach(Observer observer in observerslist)
            {
                observer.Update(availability);
            }
        }

        public void Subscribe(Observer observer)
        {
            observerslist.Add(observer);
        }

        public void unSubscribe(Observer observer)
        {
            observerslist.Remove(observer);
        }
        public void setAvailable(bool available)
        {
            this.availability = this.name+(available? " Available":" Not Available");
            NotifyAllSubscriber();
        }
    }
}
