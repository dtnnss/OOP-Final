using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace QLSP
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private double state;

        public double getState()
        {
            return this.state;
        }

        public void setState(double state)
        {
            this.state = state;
            notifyAllObservers();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}