using CsharpDay2.Cornel;
using CsharpDay2.Samira;
using System;

namespace CsharpDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            SamiraTask();
            KathiTask();
            CornelTask();

            
            Console.WriteLine("Hello World!");
        }
        static void SamiraTask()
        {
           
            Tasks newtask = new Samira.Tasks();
            newtask.TaskOne();
        }
        static void KathiTask()
        {
            Console.WriteLine("Hello World!");
        }
        static void CornelTask()
        {
            Class01 object_01 = new Cornel.Class01();
            object_01.Task_01();
        }
    }
}
