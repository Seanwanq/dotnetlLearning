using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CompileEventApp1
{
    class DelegateCompilerEvent{
        public delegate void CompilerLogHandler(string status);
        public event CompilerLogHandler CompilerEventLog;
        public void LogProcess(){
            string date = DateTime.Now.ToString();
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
