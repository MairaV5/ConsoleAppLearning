using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();
            persons.Add(new Human("Josh", "Brown", 17, "Blue"));
            persons.Add(new Human("Karl", "James", 69, "Green"));
            persons.Add(new Human("Anne", "Marie", 5, "Brown"));
            persons.Add(new Human("Talia", "Williams", 21, "Gray"));

            //persons[1].SetAge(58);

            foreach(var person in persons)
            {
                person.Introduce();
            }

            //create some bank accounts here
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Josh", 200, "EUR"));
            accounts[0].PrintInfo();
            accounts.Add(new BankAccount("Karl", 5000, "EUR"));
            accounts[1].PrintInfo();
            accounts.Add(new BankAccount("Anne", 76, "EUR"));
            accounts[2].PrintInfo();
        }
    }
}
