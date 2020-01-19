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
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

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
