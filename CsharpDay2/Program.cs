﻿using CsharpDay2.Cornel;
using CsharpDay2.Kathi;
using CsharpDay2.Samira;
using System;

namespace CsharpDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SamiraTask();
           // KathiTask();
            CornelTask();

            
           // Console.WriteLine("Hello World!");
        }
        static void SamiraTask()
        {
           
            Tasks newtask = new Samira.Tasks();
            newtask.TaskOne();
        }
        static void KathiTask()
        {
            ClassOne one = new Kathi.ClassOne();
            //one.printName();
            //one.TaskOne();
            //one.TaskTwo();
            //one.TaskThree();
            //one.TaskFour();
            //one.TaskFive();
            //one.TaskSix();

        }
        static void CornelTask()
        {
            Class01 Tasks = new Cornel.Class01();
            //Tasks.Task_01();
            //Tasks.Task_02();
            Tasks.Task_03();
            
            
        }
    }
}
