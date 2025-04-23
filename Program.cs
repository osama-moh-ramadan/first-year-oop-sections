using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section
{
    class Human
    {
        public int age;
        public string name;
        public Human()
        {
            Console.WriteLine("....human created.....");
        }
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printhuman()
        {

            Console.Write($"Name is {name}, and age is {age}",name,age);
        }
    }
    class Student :Human 
    {
        public double grades;
        public Student(string name, int age,double grades):base(name,age) 
        {
            this.grades = grades;
        }
        public Student()
        {
            Console.WriteLine(".....student created.....");
        }
        public void printstudent()
        {
            printhuman();
            Console.WriteLine($",grades is {grades}",grades);
        }
    }
    class Teatcher : Human
    {
        public string course;
        public double salary;
        public Teatcher(string name,int age,string course, double salary):base(name,age)
        {
            this.course = course;
            this.salary = salary;
        }

        public Teatcher()
        {
            Console.WriteLine("....Teacher created.....");
        }
        public void printteatcher()
        {
            printhuman();
            Console.WriteLine($" and salary is {salary} and course is {course}",salary,course);

        }
    } 
   
    internal class Program
    { 
     
        static void Main(string[] args)
        {
            Human h1 = new Human("osama ramdan", 23);
            h1.printhuman();
            Teatcher t1 = new Teatcher("ahmed mahmoud", 55,"oop",10000);
            t1.printteatcher();
            Student s1 = new Student("ahmed",15,89);
            s1.printstudent();
        }
    }
}
