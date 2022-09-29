using System;
using System.Diagnostics.Metrics;

namespace PaternState 
{
    class Car 
    {
        public CarStaneState State{ get; set; }

        public Car(CarStaneState cs)
        {
            State = cs;
        }

        public void Engnine()
        {
            State.Engnine(this);
        }

        public void Rolling()
        {
            State.Rolling(this);
        }
    }

   
}
    


