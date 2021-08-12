using System;
using System.IO;

namespace FileRW
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Mode = {"read", "write", "quit"};
            System.Console.WriteLine("Open or create a file");
            System.Console.WriteLine("Please input the file name:");
            string filename = Console.ReadLine();

            System.Console.WriteLine("You can choose three modes.");
            System.Console.WriteLine("1. read the file");
            System.Console.WriteLine("2. write the file");
            System.Console.WriteLine("3. exit the app");
            System.Console.WriteLine("please input the number");
            int num = int.Parse(Console.ReadLine());

            System.Console.WriteLine("You have chosen {0} mode", Mode[num - 1]);

            while ((num != 1) && (num != 2) && (num != 3))
            {
                System.Console.WriteLine("You have inputted a wrong number, please input it again!");
                num = int.Parse(Console.ReadLine());
            }


            switch (num)
            {
                case 1:
                    try
                    {
                        // 创建一个 StreamReader 的实例来读取文件 
                        // using 语句也能关闭 StreamReader
                        using (StreamReader sr = new StreamReader($"{filename}"))
                        {
                            string readline;
                   
                            // 从文件读取并显示行，直到文件的末尾 
                            while ((readline = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(readline);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // 向用户显示出错消息
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }
                    break;

                case 2:
                    System.Console.WriteLine("Input \"EOF\" to save and close the file.");
                    try{
                        using(StreamWriter sw = new StreamWriter($"{filename}")){
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
                        Console.WriteLine("The file could not be written:");
                        Console.WriteLine(e.Message);
                    }

                    break;

                case 3:

                    break;

                default:
                    System.Console.WriteLine("If you can see this line, that means there's some logical mistakes.");
                    break;
            }


            System.Console.WriteLine("The app exit.");
        }
    }
}
