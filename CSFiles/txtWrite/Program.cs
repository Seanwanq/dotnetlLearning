using System;
using System.IO;


namespace txtWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                using(StreamWriter sw = new StreamWriter("test.txt")){
                    string line;
                    line = Console.ReadLine();

                    while(line != "EOF"){
                        
                        sw.WriteLine(line);
                        line = Console.ReadLine();
                    }
                }
            }
            catch(Exception e){
                // 向用户显示出错消息
                Console.WriteLine("The file could not be write:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
