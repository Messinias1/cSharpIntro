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
            for (var i = 0; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // VIDEO 42 EXERCISES
            // X 42 1
            //Console.WriteLine("Type a number between 1 and 10:  ");
            //int input = Int32.Parse(Console.ReadLine());
            //if(input > 0 && input <= 10)
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //    Console.WriteLine("Invalid");

            // X 42 2
            //Console.WriteLine("Enter a number: ");
            //int iZero = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a second number: ");
            //int iOne = Int32.Parse(Console.ReadLine());

            //if(iZero > iOne)
            //{
            //    Console.WriteLine(iZero);
            //}
            //else
            //    Console.WriteLine(iOne);

            // X 42 3
            //Console.WriteLine("Enter an image height: ");
            //int height = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an image width: ");
            //int width = Int32.Parse(Console.ReadLine());

            //if (height > width)
            //{
            //    Console.WriteLine("Image is a portrait");
            //}
            //else
            //    Console.WriteLine("Image is a landscape");

            // X 42 4
            //Console.WriteLine("Enter the speed limit: ");
            //int speedLimit = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Enter car speed: ");
            //int carSpeed = Int32.Parse(Console.ReadLine());

            //if(carSpeed <= speedLimit)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else if(carSpeed > speedLimit)
            //{
            //    int difference = carSpeed - speedLimit;
            //    difference = difference / 5;
            //    Console.WriteLine(difference);
            //    if (difference > 12)
            //    {
            //        Console.WriteLine("License Suspended");
            //    }
            //}

            // If Else and switch
            //var season = Season.Autumn;

            //switch (season)
            //{
            //    case Season.Autumn:
            //        Console.WriteLine("It's Autumn");
            //        break;

            //    case Season.Summer:
            //        Console.WriteLine("It's Summer");
            //        break;

            //    case Season.Winter:
            //        Console.WriteLine("It's Winter");
            //        break;

            //    case Season.Spring:
            //        Console.WriteLine("It's Spring");
            //        break;

            //    default:
            //        Console.WriteLine("Not a season");
            //        break;
            //}

            //bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.99f;
            //}
            //else
            //    price = 29.99f;

            //float price = (isGoldCustomer) ? 19.99f : 29.99f;

            //Console.WriteLine(price);



            // Different calls
            //var a = 10;
            //var b = a;
            //b++;
            //Console.WriteLine(string.Format("a: {0} b: {1}", a, b));

            //var array1 = new int[3] { 1, 2, 3 };
            //var array2 = array1;
            //array2[0] = 0;
            //Console.WriteLine(string.Format("array1[0]: {0} array2[0]: {1}", array1[0], array2[0]));

            // Enums
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            //Console.WriteLine(method.ToString());

            //var methodName = "Express";
            //var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            //Console.WriteLine(shippingMethod);

            // Strings
            //            var firstName = "Carl";
            //            var lastName = "Kakisis";

            //            var fullName = firstName + " " + lastName;
            //            var mtFullName = string.Format("My name is {0} {1}", firstName, lastName);

            //            var names = new string[3] { "John", "Bob", "Bev" };
            //            var formattedNames = string.Join(",", names);
            //            Console.WriteLine(formattedNames);

            //            var text = @"What is your name?
            //My name is Carl, yours?
            //Bob thanks";
            //            Console.WriteLine(text);

            // Arrays
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


            // Classes
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

            // implcit and explicit conversion
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
        public static void Increment(int number)
        {
            number += 10;
        }
    }
}
