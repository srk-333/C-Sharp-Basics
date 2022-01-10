using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogCharAndBehaviour // creating Different Namespace
{
    internal class Dog
    {
        //instance variables of Public type
        public string breed;
        public int size;
        public int age;
        public string color;

        // creating static  Methods to perform some actions.
        public static void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }

        public static void Sleep()
        { 
            Console.WriteLine("Dog is Sleeping");
        }

        //creating Non-static  Methods to perform some actions.
        public void Run()
        {
            Console.WriteLine("Dog is Running");
        }
        public void Sit()
        {
            Console.WriteLine("Dog is Sitting");
        }
    }
}
