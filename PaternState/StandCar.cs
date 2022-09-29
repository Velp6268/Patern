using System;
using System.Diagnostics.Metrics;

namespace PaternState
{
    class StandCar : CarStaneState
    {
        
            public void Engnine(Car car)
            {
                Console.WriteLine("Заводим машину");
                car.State = new EngnineCarState();
            }

            public void Rolling(Car car)
            {
                Console.WriteLine("Продолжаем );
            }
        
    }
}

