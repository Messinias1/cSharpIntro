using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Math;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Carl";
            var lastName = "Kakisis";

            var fullName = firstName + " " + lastName;
            var mtFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Bob", "Bev" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"What is your name?
My name is Carl, yours?
Bob thanks";
            Console.WriteLine(text);

            //var numbers = new int[3];
            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] { "Javk", "John", "Mary" };
            //Console.WriteLine(names[0]);

            //var john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);

            //var a = 1;
            //var b = 2;
            //var c = 3;

            //Console.WriteLine(c > b || c == a);

            //try
            //{
            //    string str = "true";
            //    bool b = Convert.ToBoolean(str);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted to a byte");
            //}


            //const float Pi = 3.14f;
            //Console.WriteLine(Pi);
        }
    }
}
