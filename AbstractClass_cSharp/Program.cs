using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //abstract class : modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            
            //Vehicle v = new Vehicle();            // not possible to create this objects


            Console.WriteLine(car.wheels);
            Console.WriteLine(car.speed);
            car.go();

            Console.ReadKey();
        }
    }
    abstract class Vehicle                          //when we modify the abstract in a class its not possible to create a Vehicle objects. Its one of the security for your applications
    {
        public int speed = 0; 

        public void go() 
        {
            Console.WriteLine("The vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat
    {
        public int wheels = 0;
        int maxSpeed = 0;
    }
}
