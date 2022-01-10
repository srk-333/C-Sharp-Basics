using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogCharAndBehaviour;  //importing DogCharAndBehaviour namespace in Main namespace

namespace ClassObjectImp
{
    internal class Program
    {   
        //main Method Entry Point of Program.
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to implementation of class and object \n "); // \n is used to move output/Cursor to next line

            //Creating Object of Dog class with variable Name firstDog.
            Dog firstDog = new Dog();
            //Initializing Values to public Instance variables of Dog Class using class Obj reference.
            firstDog.breed = "BullDog";
            firstDog.age = 7;
            firstDog.color = "Brown";
            firstDog.size = 4;
            Console.WriteLine("First Dog Details: " + "\n breed: " + firstDog.breed + "\n Age: "+firstDog.age+"\n Color: "+firstDog.color+"\n Size: "+firstDog.size);
           
            //Creating Object of Dog class with variable Name secondDog.
            Dog secondDog = new Dog();
            //Initializing Values to public Instance variables of Dog Class using class Obj reference.
            secondDog.breed = "German Shepard";
            secondDog.age = 8;
            secondDog.color = "White and Black";
            secondDog.size=5;
            Console.WriteLine("\n Second Dog Details: " + "\n breed: " + secondDog.breed + "\n Age: " + secondDog.age + "\n Color: " + secondDog.color + "\n Size: " + secondDog.size+"\n");
           
            //calling Static Methods of Dog Class using Class reference. 
            Dog.Eat();
            Dog.Sleep();
           
            //calling Non-static Methods of Dog class using firstDog obj of class Dog
            firstDog.Run();
            firstDog.Sit();
            Console.ReadLine();
        }
    }
}
