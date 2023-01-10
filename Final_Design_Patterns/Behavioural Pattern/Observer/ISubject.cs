using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Behavioural_Pattern
{
    interface ISubject
    {
        void Subscribe(Observer observer);
        void unSubscribe(Observer observer);
        void NotifyAllSubscriber();



    }
}
