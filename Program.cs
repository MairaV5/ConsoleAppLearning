using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human("Josh", "Brown", 17, "Blue");
            person.Introduce();

            person.AddNumbers(32, 968);
        }
    }
}
