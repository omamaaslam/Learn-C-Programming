using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
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


        //static float calculateAvg(int a, int b, int c)
        //{
        //    float Sum = a + b + c;
        //    return Sum / 3;
        //}

        /* ===========================================================================
                                    Object Oriented Programming in C# 
         ============================================================================== */


        //public class Calculator
        //{
        //    public int  num1;
        //    public int num2;
        //    private int result;

        //    public void Add()
        //    {
        //        result = num1 + num2;
        //        Result();
        //    }


        //    public void Sub()
        //    {
        //        result = num1 - num2;
        //        Result();
        //    }


        //    public void Mul()
        //    {
        //        result = num1 * num2;
        //        Result();
        //    }

        //    void Result()
        //    {
        //        Console.WriteLine($"Result is : {result}");
        //        Console.ReadLine();
        //    }

        //}


        //public class Example2
        //{
        //    public string[] myArray = {"Omama", "Ali", "Ahmed", "Usama", "Umer", "Muneeb"};
        //    public int findMax(int num1, int num2)
        //    {
        //        int result;
        //        if (num1 > num2)
        //        {
        //            result = num1;
        //        }
        //        else
        //        {
        //            result = num2;
        //        }
        //        return result;
        //    }

        //    public void printArray()
        //    {
        //        for (int i = 0; i < myArray.Length; i++)
        //        {
        //            Console.WriteLine(myArray[i]);
        //        }
        //    }
        //}


        public class Example3
        {
            int num = 1;
            public void Counting()
            {
                if(num == 11)
                {
                    return;  // exit from recurion
                }
                Console.WriteLine(num);
                num++;
                Counting();
            }
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
            //Console.WriteLine(calculateAvg(10, 20, 30));


            /* ===================================
                Arrays in C# 
             =================================== */

            //int[] myNum = { 50, 28, 25, 40 };
            //for(int i = 0; i < myNum.Length; i++)
            //{
            //    Console.WriteLine(myNum[i]);
            //}

            // Add each number of an array and print the result in console.
            //int sum = 0;
            //for (int i = 0; i < myNum.Length; i++)
            //{
            //    sum = sum + myNum[i];
            //    Console.WriteLine($"Total is : {sum}");
            //}


            // sorting an array in C# :
            //There are many array methods available, for example Sort(),
            //which sorts an array alphabetically or in an ascending order:
            //Array.Sort(myNum);
            //foreach (int i in myNum)
            //{
            //    Console.WriteLine(i);
            //}



            /* ===================================
                           List in C# 
               =================================== */

            //List<string> Cars = new List<string>();
            //Cars.Add("Suzuki");
            //Cars.Add("Maruti");
            //Cars.Add("Toyota");
            //Cars.Add("BMW");
            //Cars.Add("Ferarri");

            //for(int i = 0; i < Cars.Count; i++)
            //{
            //    Console.WriteLine(Cars[i]);
            //}

            //foreach (string Car in Cars)
            // {
            //     Console.WriteLine(Car.ToUpper());
            // }


            /* ===========================================================================
                                           Object Oriented Programming in C# 
            ============================================================================== */

            //Here we are creating an object of a class.
            //Calculator obj = new Calculator(); // using new keyword object gets initialized.
            //obj.num1 = 50;
            //obj.num2 = 20;

            //obj.Add();
            //obj.Sub();
            //obj.Mul();

            //Example2 example2 = new Example2();
            //int maxNumber = example2.findMax(10,1);
            //Console.WriteLine(maxNumber);
            //example2.printArray();



            Example3 obj3 = new Example3();
            obj3.Counting();
            Console.ReadLine();
        }
    }
}
