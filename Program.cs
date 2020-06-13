using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            //person.Name = "Josh";
            //person.Surname = "Lopez";
            person.Age = 17;
            person.EyeColor = "Blue";
            person.Introduce();

            //person.Name = "James";
            person.Introduce();

            person.AddNumbers(32, 968);
        }
    }
}
