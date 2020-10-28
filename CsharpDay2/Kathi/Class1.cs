using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CsharpDay2.Kathi
{
    class ClassOne
    {
        public void printName()
        {
            Console.WriteLine("print Name :)");
        }

        public void TaskOne()
        {
            Console.WriteLine("Give me a number :D");
            var theNumber = float.Parse(Console.ReadLine());

            if (theNumber == 0)            
                Console.WriteLine("You coose " + theNumber + ". This is Zero");
            else if(theNumber > 0)
                Console.WriteLine("You coose " + theNumber + ". This is a positive number");
            else
                Console.WriteLine("You coose " + theNumber + ". This is a negative number");
        }

        public void TaskTwo()
        {
            Console.WriteLine("Now it's time to coose 3 numbers, to get the smalles");
            Console.WriteLine("give me the first");
            var one = float.Parse(Console.ReadLine());
            Console.WriteLine("give me the second");
            var two = float.Parse(Console.ReadLine());
            Console.WriteLine("give me the last one");
            var three = float.Parse(Console.ReadLine());

            if (one < two && one < three)            
                Console.WriteLine("the first number is the smalles.");
            else if(two < one && two < three)
                Console.WriteLine("the second number is the smalles.");
            else
                Console.WriteLine("the last number is the smalles.");
        }

        public void TaskThree()
        {
            Console.WriteLine("From year to century");
            Console.WriteLine("which century do you want to know?");
            var century = Convert.ToInt32(Console.ReadLine());

            if(century <= 0)
                Console.WriteLine("you must choose a positive number...");
            else if(century <= 100)
                Console.WriteLine("Is the first century");
            else if(century % 100 == 0)
                Console.WriteLine(century / 100 + " century");
            else
                Console.WriteLine(century / 100 + 1 + " century");
        }

        public void TaskFour()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x 10 is " + (i * 10));
            }
        }

        public void TaskFive()
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int y = 0; y <= i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("now another way around \n");

            for (int x = 6; x >= 0; x--)
            {
                for (int z = 0; z <= x; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public void TaskSix()
        {
            Console.WriteLine("Switch - Calculator");
            Console.WriteLine("Choose two numbers and than an operation");
            Console.WriteLine("Enter first number");
            var one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("now, choose a operation. like : +, -, %, /, x");
            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Result = " + (one + two));
                    break;
                case "-":
                    Console.WriteLine("Result = " + (one - two));
                    break;
                case "%":
                    Console.WriteLine("Result = " + (one % two));
                    break;
                case "/":
                    Console.WriteLine("Result = " + (one / two));
                    break;
                case "x":
                    Console.WriteLine("Result = " + (one * two));
                    break;
                default:
                    Console.WriteLine("you choose the operator " + operation + ". this is not in the function.");
                    break;
            }
        }
    }
}
