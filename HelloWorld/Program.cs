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
            // X 55 1
            //var inputList = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Enter a number or press enter to exit: ");
            //    var input = Console.ReadLine();

            //    if (input == "")
            //    {
            //        break;
            //    }
            //    inputList.Add(input);
            //    Console.WriteLine(inputList.Count());
            //    var likesLeft = inputList.Count() - 2;

            //    if (inputList.Count() == 1)
            //    {
            //        Console.WriteLine(inputList[0] + " likes your post");
            //    }
            //    else if (inputList.Count() == 2)
            //    {
            //        Console.WriteLine(inputList[0] + " and " + inputList[1] + " like your post");
            //    }
            //    else
            //    {
            //        Console.WriteLine(inputList[0] + ", " + inputList[1] + " " + likesLeft + " others like your post");
            //    }
            //}

            // X 55 2
            //Console.WriteLine("Enter your name: ");
            //var input = Console.ReadLine();

            //char[] ch = input.ToCharArray();
            //Array.Reverse(ch);
            //foreach (var letter in ch)
            //{
            //    Console.WriteLine(letter);
            //}
            //string myChar = new string(ch);
            //Console.WriteLine("Converted to string = {0}", myChar);

            // X 55 3
            //Console.WriteLine("Enter some unique numbers: ");
            //var input = Console.ReadLine();

            //var list = new List<char>();
            //foreach (var num in input)
            //{
            //    list.Add(num);
            //}

            //if (list.Count != list.Distinct().Count())
            //{
            //    Console.WriteLine("No Duplicates Please! Try Again");
            //    Environment.Exit(0);
            //}
            //var newList = new List<int>();
            //foreach (var num in input)
            //{
            //    int val = (int)Char.GetNumericValue(num);
            //    newList.Add(val);
            //}
            //newList.Sort();
            //foreach (var num in newList)
            //{
            //    Console.WriteLine(num);
            //}

            // X 55 4
            var numList = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a number or type quit to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numList.Add(input);                
            }
            IEnumerable<string> distinctNums = numList.Distinct();
            Console.WriteLine("Unique nums: ");
            foreach (var i in distinctNums)
            {
                Console.WriteLine(i);
            }



            // DEMO LISTS
            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });

            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));

            //Console.WriteLine("Count: " + numbers.Count());


            //for(var i = 0; i < numbers.Count; i++)
            //{
            //    if(numbers[i] == 1)
            //    {
            //        numbers.Remove(numbers[i]);
            //    }
            //}
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //numbers.Clear();
            //Console.WriteLine("Count: " + numbers.Count());


            // DEMO ARRAYS
            //var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //// Length
            //Console.WriteLine("Length: " + numbers.Length);

            //// IndexOf
            //var index = Array.IndexOf(numbers, 9);
            //Console.WriteLine("Index: " + index);

            //// Clear
            //Array.Clear(numbers, 0, 2);

            //Console.WriteLine("Effect of Clear()");
            //foreach(var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //// Copy
            //var another = new int[4];
            //Array.Copy(numbers, another, 4);

            //Console.WriteLine("Effect of Copy()");
            //foreach(var n in another)
            //{
            //    Console.WriteLine(n);
            //}

            //// Sort
            //Array.Sort(numbers);

            //Console.WriteLine("Effect of Sort()");
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //// Reverse
            //Array.Reverse(numbers);

            //Console.WriteLine("Effect of Reverse()");
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            // X 48 1
            //for(var i = 1; i <= 100; i++)
            //{
            //    if(i %3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // X 48 2
            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number or ok to exit: ");
            //    var input = Console.ReadLine();

            //    if(input.ToLower() == "ok")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        int i = int.Parse(input);
            //        Console.WriteLine(sum += i);
            //    }
            //}

            // X 48 3
            //Console.WriteLine("Enter a number: ");
            //var input = Int32.Parse(Console.ReadLine());

            //for(var i = input - 1; input > 0; i--)
            //{
            //    if(i == 1)
            //    {
            //        break;
            //    }
            //    else
            //    input *= i; 
            //}
            //Console.WriteLine(input);

            // X 48 4
            //int count = 0;
            //while(true)
            //{
            //    Console.WriteLine("Enter a number between 1 and 10: ");
            //    int guess = Int32.Parse(Console.ReadLine());
            //    Random rnd = new Random();
            //    int num = rnd.Next(1, 11);
            //    Console.WriteLine(num);

            //    if (guess != num)
            //    {
            //        Console.WriteLine("Try again");
            //        count++;
            //        if (count == 4)
            //        {
            //            Console.WriteLine("You Lost");
            //            break;
            //        }
            //    }
            //    else if (guess == num)
            //    {
            //        Console.WriteLine("You Won");
            //        break;
            //    }
            //}

            // X 48 5
            //Console.WriteLine("Enter a series of numbers seperated by a comma: ");
            //var num = Console.ReadLine().Split(',');

            //int[] digits = num.Select(d => Convert.ToInt32(d)).ToArray();


            //Console.WriteLine(digits.Max());

            // Genrate random numbers
            //var random = new Random();

            //const int passwordLength = 10;

            //var buffer = new char[passwordLength];
            //for (var i = 0; i < passwordLength; i++)
            //{
            //    buffer[i] = (char)('a' + random.Next(0, 26));

            //    var password = new string(buffer);
            //    Console.WriteLine(password);
            //}

            // LOOPS
            //while (true)
            //{
            //    Console.Write("Type your name");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }
            //    break;
            //}

            //var numbers = new int[] { 1, 2, 3 };

            //foreach(var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var character in name) 
            //{
            //    Console.WriteLine(character);
            //}

            //for (var i = 0; i <= 10; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (var i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

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
