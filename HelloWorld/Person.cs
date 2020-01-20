using System;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My Name Is " + FirstName + " " + LastName);
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
