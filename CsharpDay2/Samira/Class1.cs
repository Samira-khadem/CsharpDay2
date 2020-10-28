using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CsharpDay2.Samira
{
    class Tasks
    {
        public void TaskOne()
        {
            //Console.WriteLine("task one");
            Console.WriteLine("Enter a number:");
            double aNumber = Convert.ToDouble(Console.ReadLine());
            if (aNumber > 0)
            
                Console.WriteLine("the number is positive!"); 
            else if (aNumber<0)
                Console.WriteLine("the number is Negative!");
            else
                Console.WriteLine("the number is zero!");

        }

        public void TaskTwo()
        {
            Console.WriteLine("Enter the first number:");
            double xNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double yNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            double zNumber = Convert.ToDouble(Console.ReadLine());

            if (xNumber < yNumber && xNumber < zNumber)
            Console.WriteLine("the smallest number is: " + xNumber);

            else if (yNumber < zNumber && yNumber < xNumber) 
            Console.WriteLine("the smallest number is: " + yNumber);

            else
                Console.WriteLine("the smallest number is: " + zNumber);

        }


        public void TaskThree()
        {
            Console.WriteLine("Enter the year I give you the century:");
            double year = Convert.ToDouble(Console.ReadLine());
            if (year<= 100)
            Console.WriteLine("this is the first century. ");
            else if (year % 100 == 0)
            Console.WriteLine("this is the "+ year/100 + "century");
            else
            Console.WriteLine("this is the " + (Math.Floor(year/100)+1) + " century");
        }

        public void TaskFour()
        {
            // showTables += numbers + " x " + i + " = " + numbers * i + "<br>"

            double num = 1;
            for (int i = 1; i < 11; i++)
                Console.WriteLine(num + "X" + i + "=" + num * i);

        }

        public void TaskFive()
        {
            string[] stars = { "*", "**", "***", "****","*****","******" };
            string[] stars2 = { "******", "*****", "****", "***","**","*" };

            foreach (string star in stars) { 
                Console.WriteLine(star);
            }
            foreach (string star in stars2)
            {
                Console.WriteLine(star);
            }

        }

        public void TaskSeven()
        {
            Console.WriteLine("Enter your weight : ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in meters : ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            if (bmi < 19)
                Console.WriteLine("You are underwight try eating more proteins");
            else if (bmi>19 && bmi<25)
                Console.WriteLine("You have normal wight keep up the good work");
            else if (bmi>25)
                Console.WriteLine("You are overweight try doing some sports");


        }

       
        


    }
}
