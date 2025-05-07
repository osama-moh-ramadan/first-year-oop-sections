using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxing
{
    class Human
    {
        public string Name;
        public int age;
        protected string nationality;

        public Human(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }
        public virtual void printinfo()
        {
            Console.WriteLine("Hman");
            Console.WriteLine($"name : {Name} and age = {age}");
        }
        class student : Human
        {
            public double grades;
            public student(string name, int age, double grades) : base(name, age)
            {
                this.grades = grades;
            }
            public override void printinfo()
            {
                Console.WriteLine("student");
                base.printinfo();
                Console.WriteLine($"grades ={grades}");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Human h1 = new Human("osama", 19);
                h1.printinfo();
                student s1 = new student("os", 23, 98);
                s1.printinfo();

            }
        }

    }
}