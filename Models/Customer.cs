using System;

namespace Models
{
    public class Customer
    {
        public Customer() {
            Console.WriteLine("Empty Constructor");
        }

        public Customer(string name) {

           Console.WriteLine("Name constructor");
           this.Name = name;
        }
        public Customer(string name, int age) : this(name){

            Console.WriteLine("Name and Age Constructor");
            this.Age = age;
        }
        public string Name {get;set;}

        public int Age {get;set;}
    }
}
