using System;
using Models;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to L and M tire shop!");
            StoreFront myStore = new StoreFront () {
                Name = "My Store",
                Address = "916 N MLK Blvd, Americus, GA"
            };
            Console.WriteLine(myStore.ToString());
            Console.WriteLine("Give a different store name");
            myStore.Name = Console.ReadLine(); //taking whatever store you have created and assigning the name of the store to a different one
            Console.WriteLine(myStore.ToString());
        }

        
    }
}
