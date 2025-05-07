using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nested_classes
{
    internal class Program
    {
        // abstract classes : we cannot create an object from it
        // we use it for inheritance only 
        // we have to create a child class and create an abject form it 
        //sealed classes 
        // we cannot make inheritance in sealed classes 
        // sealed is opposite to abstract
        // c# donnot allow us to inheritance from many classes 
        abstract class Person
         { 
            public string name;
            public int age;
            public void Hi()
            {
                Console.WriteLine("Hi and welcome");
            }
            public abstract void PrinInfo();
        }
        class Student : Person , Iprint , Ihello
        {
           public double grades;
            public hi()
            {
                Console.WriteLine("say hi from strdent");
            }
            public void print()
            {
                Console.WriteLine("print infob");
            }

            public override void PrinInfo()
            {
                Console.WriteLine($"name is {name}, and age = {age} , and grades = {grades}");
            }
        }
        public interface Iprint
        {
            void print();
        }
        public interface Ihello
        {
            void hi();
        }

        static void Main(string[] args)
        {
           
            //Student s1 = new Student();
            //s1.name = "osama";
            //s1.grades = 99;
            //s1.age = 19;
            //s1.PrinInfo();

        }
    }
}
