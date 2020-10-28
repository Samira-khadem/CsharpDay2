using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDay2.Cornel
{
    class Class01
    {
        public void Task_01()
        {
            Console.WriteLine("Enter a number");
            double weight = Convert.ToDouble(Console.ReadLine());


            if (weight < 0)
            {

               Console.WriteLine("Your number is negative");
              
            }
            if (weight > 0)

                
            {
                Console.WriteLine("Yourn number is positive");
              
            }
                
            else if (weight == 0){
                Console.WriteLine("Your number is 0");
                
            }


        }

        public void Task_02()
        {

            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            double num3 = Convert.ToDouble(Console.ReadLine());


            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("The smallest number is " + num1);
            }
            else if(num2 < num1 && num2 < num3)
            {
                Console.WriteLine("The smallest number is " + num2);
            }
            else if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine("The smallest number is " + num3);
            }
        }


        public void Task_03()
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt16(Console.ReadLine());
            
            switch (year)
            {
                case int i when i > 0 && i < 100:
                    Console.WriteLine("1 Century");
                    break;

                case int i when i > 100 && i < 200:
                    Console.WriteLine("2 Century");
                    break;

                case int i when i > 200 && i < 300:
                    Console.WriteLine("3 Century");
                    break;

                case int i when i > 300 && i < 400:
                    Console.WriteLine("4 Century");
                    break;

                case int i when i > 400 && i < 500:
                    Console.WriteLine("5 Century");
                    break;

                case int i when i > 500 && i < 600:
                    Console.WriteLine("6 Century");
                    break;

                case int i when i > 600 && i < 700:
                    Console.WriteLine("7 Century");
                    break;

                case int i when i > 700 && i < 800:
                    Console.WriteLine("8 Century");
                    break;

                case int i when i > 800 && i < 900:
                    Console.WriteLine("9 Century");
                    break;

                case int i when i > 900 && i < 1000:
                    Console.WriteLine("10 Century");
                    break;

                case int i when i > 1000 && i < 1100:
                    Console.WriteLine("11 Century");
                    break;

                case int i when i > 1100 && i < 1200:
                    Console.WriteLine("12 Century");
                    break;

                case int i when i > 1200 && i < 1300:
                    Console.WriteLine("13 Century");
                    break;

                case int i when i > 1300 && i < 1400:
                    Console.WriteLine("14 Century");
                    break;

                case int i when i > 1400 && i < 1500:
                    Console.WriteLine("15 Century");
                    break;

                case int i when i > 1500 && i < 1600:
                    Console.WriteLine("16 Century");
                    break;

                case int i when i > 1600 && i < 1700:
                    Console.WriteLine("17 Century");
                    break;

                case int i when i > 1700 && i < 1800:
                    Console.WriteLine("18 Century");
                    break;

                case int i when i > 1800 && i < 1900:
                    Console.WriteLine("19 Century");
                    break;

                case int i when i > 1900 && i < 2000:
                    Console.WriteLine("20 Century");
                    break;

                case int i when i > 2000 && i < 2100:
                    Console.WriteLine("21Century");
                    break;
            }

        }

        public void Task_04()
        {
            float number = 1;
            float[] array_01 = { 1, 2,3,4,5,6,7,8,9 };

            for(int i = 0; i < array_01.Length; i++)
            {
                number = number * array_01[i];
            }

            Console.WriteLine(number);
        }

        public void Task_05_01()
        {
            for(int i = 0; i < 7; i++)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public void Task_05_02()
        {
            for (int i = 7; i > 0; i--)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public void Task_06()
        {
            Console.WriteLine("Enter the firs number");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the operation");
            string operation = Convert.ToString(Console.ReadLine());

            




        }
    }
       
        
    
}
