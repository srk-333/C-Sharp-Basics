using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogCharAndBehaviour;  //importing DogCharAndBehaviour namespace in Main namespace
using ClassObjectImp.Variables; //importing ClasObjectImp.Variables namespace in Main namespace

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

            Program.VariableCall(); //calling variableCall Method
            Console.ReadLine();
        }
        public static void VariableCall()
        { 
            // stattic variables Initializing using class reference
            UseOfVariables._age = 24;
            UseOfVariables._name = "Saurav";
            UseOfVariables._height = 5.7;

            //creating first object of UseOfVariables Class as uvrOne. 
            UseOfVariables uvrOne = new UseOfVariables();
            // Instance variables Initializing using Object reference
            uvrOne.name = "Gourav";
            uvrOne.age = 23;
            uvrOne.height = 5.6;
            Console.WriteLine("\n Instance Variables for First Object are: "+"  Name: "+ uvrOne.name + "  Age: " + uvrOne.age + "  Height: " + uvrOne.height);
            Console.WriteLine("\n Static Variables are: " + "  Name: " + UseOfVariables._name + "   Age: " + UseOfVariables._age+"  Height: "+UseOfVariables._height);
            Console.WriteLine("\n Constant Variables are: " + "  Age: " + UseOfVariables.ageNumber + "   Percentage: " + UseOfVariables.percentage);

            //creating Second object of UseOfVariables Class as uvrOne. 
            UseOfVariables uvrTwo = new UseOfVariables();
            // Instance variables Initializing using Object reference
            uvrTwo.name = "Ritesh";
            uvrTwo.age = 28;
            uvrTwo.height = 5.6;
            Console.WriteLine("\n\n Instance Variables for Second Object are: " + "  Name: " + uvrTwo.name + "   Age: " + uvrTwo.age + "   Height: " + uvrTwo.height);
            Console.WriteLine("\n Static Variables are: " + "  Name: " + UseOfVariables._name + "  Age: " + UseOfVariables._age + "   Height: " + UseOfVariables._height);
            Console.WriteLine("\n Constant Variables are: " + "  Age: " + UseOfVariables.ageNumber + "   Percentage: " + UseOfVariables.percentage);
            Console.WriteLine("\n\n ReadOnly variable is: " + uvrTwo.k);
        }
    }
}
