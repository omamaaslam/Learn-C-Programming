using System;
using System.Threading;
//using System.CodeDom;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //static void Greet()
        //{
        //    Console.WriteLine("This is my C# function.");
        //}


        static float calculateAvg(int a, int b, int c)
        {
            float Sum = a + b + c;
            return Sum / 3;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello my name is " + name);
            //Console.WriteLine("How many Candies do you want?");
            //string Candies = Console.ReadLine();
            //Console.WriteLine("Congradulation You will extra 4 Candies: " + (Convert.ToInt32(Candies) + 4));
            //Console.ReadLine();


            /* Operators in C#
               1- Arithematic Operator
               2- Logical Operator
               3- Comparison Opeator
               4- Assignment Operator
            */

            /* ===================================
                Arithematic Operator Example
               =================================== */
            //int a = 3;
            //int b = 2;
            //Console.WriteLine("Addition of 'a' And 'b' is : " + (a + b));
            //Console.WriteLine("Subtraction of 'a' And 'b' is : " + (a - b));
            //Console.WriteLine("Multiplication of 'a' And 'b' is : " + (a * b));
            //Console.WriteLine("Divisionof 'a' And 'b' is : " + (a / b));
            //Console.ReadLine();

            /* ===================================
                Assignment Operator Example
               =================================== */
            // int a = 3;
            // int b = a;
            // b += 3;
            // b -= 3;
            // b *= 3;
            // b /= 3;
            // Console.WriteLine(b);
            // Console.ReadLine();

            /* ===================================
                  Logical Operator Example
               =================================== */

            //Console.WriteLine(true && false);
            //Console.WriteLine(false && true);
            //Console.WriteLine(true && true);

            //Console.WriteLine(true || false);
            //Console.WriteLine(false || true);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Console.WriteLine(!true);
            //Console.WriteLine(!false);


            /* ===================================
                 Comparison Operator Example
              =================================== */

            //Console.WriteLine(145 > 250);
            //Console.WriteLine(145 < 250);
            //Console.WriteLine(145 >= 250);
            //Console.WriteLine(145 < 250);
            //Console.WriteLine(145 <= 250);
            //Console.WriteLine(145 != 250);


            //int a = Math.Max(34, 145);
            //int a = Math.Min(34, 145);
            //double sqrt = Math.Sqrt(64);



            /*
             =================================
                    String Methods in C#
             =================================
             */

            //string myString = "Hello my name is Omama Aslam";
            //Console.WriteLine(myString.Length);
            //Console.WriteLine(myString.ToUpper());
            //Console.WriteLine(myString.ToLower());
            //string Name = Console.ReadLine();
            //string Age = Console.ReadLine();
            //string City = Console.ReadLine();
            // This is method of String Interpolation in C#
            //Console.WriteLine($"My name is {Name}. I am {Age} years old. I live in {City}.");

            //string myString = "Hello I am learning C#";
            //Console.WriteLine(myString[0]); // print the string index (index must be start with 0 in C#)
            //Console.WriteLine(myString.IndexOf("m"));


            /* ===================================
                 if-Else Condition in C# 
              =================================== */

            //Console.WriteLine("Enter Your Age:");
            //string age = Console.ReadLine();
            //if(Convert.ToInt32(age) > 18)
            //{
            //    Console.WriteLine($"Your age is {age} years. Yes you can drive a car.");
            //} else
            //{
            //    Console.WriteLine($"Your age is {age} years. Not eligible to a drive.");
            //}


            /* ===================================
                 Switch Statements in C# 
               =================================== */
            /*
            int age = 20;
            switch (age)
            {
                case 18:
                    Console.WriteLine("Your age is 18.");
                    break;
                case 19:
                    Console.WriteLine("Your age is 19.");
                    break;
                case 20:
                    Console.WriteLine("Your age is 20.");
                    break;
                default:
                    Console.WriteLine("default case is running.");
                    break;
            }
            */


            /* ===================================
                            Loops in C# 
               =================================== */

            //int num = 0;
            //while (num < 10) {
            // Console.WriteLine($"num is {num}");
            // num++;
            //}

            //do
            //{
            //    Console.WriteLine($"num is {num}");
            //    num++;
            //}
            //while (num < 50);

            //for (int count = 0; count <= 10; count++)
            //{
            //    Console.WriteLine($"count = {count}");
            //}            


            //for (int count = 0; count <= 50; count++)
            //{
            //    if(count % 2 != 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine($"count = {count}");
            //}

            //Greet();
            Console.WriteLine(calculateAvg(10, 20, 30));
            Console.ReadLine();
        }
    }
}
