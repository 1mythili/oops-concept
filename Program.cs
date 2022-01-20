using oopsconcept.classAndObject;
using oopsconcept.Polymorphism;
using oopsconcept.Polymorphism.Abstract;
using System;
using Pig = oopsconcept.Polymorphism.Abstract.Pig;

namespace MyApplication
{
    class Program
    {
        private static object mycow;

        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            //Animal myAnimal = new Animal();  // Create a Animal object
            //Animal myPig = new Pig();  // Create a Pig object
           
            //myAnimal.animalSound();
            //myPig.animalSound();

            Pig mypig = new Pig(); // Create a Pig object
            mypig.animalSound();  // Call the abstract method
            mypig.sleep();  // Call the regular method


            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
        }
    }
}













