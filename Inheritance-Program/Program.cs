using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_Program
{
    //====single=====
    class Vechical
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("\t       \t          \t        \tTuut,Tuut");
        }
    }
    class Car:Vechical
    {
        public string modelName = "good";
    }
    //========Multi Level
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("\t       \t          \t           \tEating.......");
        }
    }
    public class Dog:Animal
    {
        public void bark()
        {
            Console.WriteLine("\t       \t          \t              \tbarking");
        }
    }
    public class BadyDog : Dog
    {
        public void weep()
        {
            Console.WriteLine("\t       \t          \t               \tWeeping");
        }
    }
    //==========Hierarchical Inheritance
    class Principal
    {
        public void Monitor()
        {
            Console.WriteLine("\t       \t          \t                \tMonitor");
        }

    }
    class Teacher:Principal
    {
        public void Tech()
        {
            Console.WriteLine("\t       \t          \t                  \tTech");
        }
    } 
    class Student:Principal
    {
        public void learn()
        {
            Console.WriteLine("\t       \t          \t                  \tLearning");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t      \t                ===================* Types Of Inheritance *=====================");
            Console.WriteLine("\n");
            Console.WriteLine("\t      \t                ======================* Single Inheritance *====================");
            Car c1 = new Car();
            c1.honk();
            Console.WriteLine("\t      \t                ====================*============*===========*===================");
            Console.WriteLine("\n");
            Console.WriteLine("\t      \t                ====================* MultiLevel Inheritance *===================");
            BadyDog b1 = new BadyDog();
            b1.eat();
            b1.bark();
            b1.weep();
            Console.WriteLine("\t      \t                ====================*============*===========*===================");
            Console.WriteLine("\n");
            Console.WriteLine("\t      \t                ====================*Hierarchical Inheritance *===================");
            Principal p = new Principal();
            p.Monitor();
            Teacher T = new Teacher();
            T.Monitor();
            T.Tech();
            Student S = new Student();
            S.Monitor();
            S.learn();
            Console.WriteLine("\t      \t                 ====================*============*===========*====================");
        }

    }
}
