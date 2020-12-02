using System;

namespace _15.OopTutorialPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating an Object of a Parent class

            Animal myAnimal = new Animal(); // create an object of class Animal !!!! Important ! 
            myAnimal.AnimalSound(); // call the method on the myAnimal obj

            Animal myDog = new Animal(); // create an object myDog of Animal
            myDog.AnimalSound();// call the method Animalsound onto myDog  

            Animal myPig = new Animal(); // create an myPig  object
            myPig.AnimalSound(); //invoke the method Animalsound() onto the myPig objest
                                 // in a child class this is a way in OOP to provide specific implementation of a method already defined :
                                 // in Bas-Parent-Superior class   // specific implemntation of a parent method into  a child class ! , 
                                 // method overriding,
                                 // in a child class this is an special implementation  of a parent method! 
                                 //the implementation into a child class replaces the 
                                 // MyPig, Mydog, MyAnimal is the object on a parent class, and the method Animalsound is 
                                 //called on them! So method does what is defined into  the SuperiorParent class
                                 // special implementation of a parent method into the child class to provide :
                                 // a specific action, its like a method has another version of action into the child class ! 
                                 // here the base class method AnimalSound() overrides, replaces the method AnimalSound of a child class! , 
                                 // when they share the same name! 
                                 // method in the child class has the same signature and return type as the method in the parent class !!
                                 //only in the derived class- child class the overriding is possible ! Becasue the method is overriden int he 
                                 // int the child class of a base class
                                 //derived child class method replaces -overrides the base class method! 
                                 // Polymorhism is the ability the classes to provide different methods implementaion 
                                 //called with the same name  .
                                 // CompileTime polymorhism
                                 // RuntimePolymorphism


            // now creating an object of a child class ! and calling the method onto child object;

            //Animal myAnimal = new Animal(); // we create an object with name-newAnimal of a class Animal
            //myAnimal.AnimalSound(); //we call  the method AnimalSound() on the Object newAnimal

            //Pig myPig = new Pig();// create a new object myPig of a class Pig
            //myPig.AnimalSound(); //call a method on object myPig 

            //Dog myDog = new Dog();  // create Dog  object of the Class DOG
            //myDog.AnimalSound(); // call a method on object myDog 

        }


    }

    class Animal //base class
    {
        public void AnimalSound()  // this is a m ethod of a class // overriden Method
        {

            Console.WriteLine("animal makes a sound");

        }
        // still no constructor defined! 

    }
    class Pig : Animal // Derived class child -> child class 
    {
        public void AnimalSound() // overriding method !!!
        {
            Console.WriteLine("The pig says wee");
        }
    }

    class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("the dog says bow-woe! ");
        }
    }


}
