using System;
using System.Diagnostics.Metrics;

namespace PaternState
{

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new EngnineCarState());
            car.Engnine();
            car.Rolling();
            water.Frost();

            Console.Read();
        }

    }
}
