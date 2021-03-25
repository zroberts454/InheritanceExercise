using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            var b = new Bird();
            b.Color = "Blue";
            b.hasBeak = true;
            b.hasFeathers = true;
            b.laysEggs = true;
            b.Age = 10;
            b.Breed = "Hawk";
            b.Name = "Bob";
            b.Noise = "KAWWW";



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var r = new Reptile();
            r.hasLegs = true;
            r.canRun = true;
            r.Length = 40;
            r.underWater = true;
            r.Age = 2;
            r.Breed = "Frog";
            r.Name = "Jeffrey";
            r.Noise = "REE BITT";

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
