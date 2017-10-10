using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day2
{
    class Boat
    {
        //FIELDS - define characteristics - info about class, blueprint that won't always produce the same thing
        public int numberOfPassengers;

        private string name;
        private double engineSize;

        //property, expose private fields to other parts of our program - could use property to hide info 
        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public Boat()
        {
        }

        public Boat(int numberOfPassangers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassangers;
            this.name = name;
            this.engineSize = engineSize;
        }

        public void Move()
        {
            Console.WriteLine(name + " moves forward.");
        }

        //only be accessed inside this class of BOAT
        private double CalculateMPG()
        {
            double MPG = engineSize * .9d;
            return MPG;
        }

        public void BoatInfo()
        {
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine size: " + engineSize);
            Console.WriteLine("MPG " + CalculateMPG());
        }

    }

    

}
