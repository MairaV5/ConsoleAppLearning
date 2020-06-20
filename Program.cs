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

            persons[1].SetAge(58);

            //persons[0].Introduce();
            //persons[1].Introduce();
            //persons[2].Introduce();

            //for(int i = 0; i < persons.Count; i++) //Loop
            //{
            //    persons[i].Introduce();
            //}

            foreach(var person in persons)
            {
                person.Introduce();
            }
        }
    }
}
