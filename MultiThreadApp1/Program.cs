using System;
using System.Threading;

namespace MultiThreadApp1
{
    class MainThreadProgram
    {
        public static void CallToChildThread(){
            System.Console.WriteLine("Child thread starts");
        }
        static void Main(string[] args)
        {
            // Thread th = Thread.CurrentThread;
            // th.Name = "MainThread";
            // System.Console.WriteLine("This is {0}", th.Name);

            ThreadStart childref = new ThreadStart(CallToChildThread);
            System.Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            
        }
    }
}
