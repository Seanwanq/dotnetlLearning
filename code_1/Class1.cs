using System;

namespace code_1
{
    class Test
    {
        //     // 定义私有的整型字段 id
        //     private int id;

        //     // 定义公有的只读字符串类型字段 name
        //     public readonly string name;

        //     // 定义内部的静态的整型字段 age
        //     internal static int age;

        //     // 定义私有的字符串类型常量 major
        //     private const string major = "计算机";

        //     private void PringMsg()
        //     {
        //         System.Console.WriteLine("编号：" + id);
        //         System.Console.WriteLine("姓名：" + name);
        //         System.Console.WriteLine("年龄：" + age);
        //         System.Console.WriteLine("专业：" + major);
        //     }

    }

    class Book
    {
        //     private int id;
        //     private string name;
        //     private double price;

        //     // 设置图书编号属性
        //     public int Id
        //     {
        //         get
        //         {
        //             return id;
        //         }
        //         set
        //         {
        //             id = value;
        //         }
        //     }

        //     // 设置图书名称属性
        //     public string Name
        //     {
        //         get
        //         {
        //             return name;
        //         }
        //     }

        //     // 设置图书价格属性
        //     public double Price
        //     {
        //         get
        //         {
        //             return price;
        //         }
        //         set
        //         {
        //             if(value >= 0)
        //             {
        //                 price = value;
        //             }
        //             else
        //             {
        //                 price = 0;
        //             }
        //         }

        // public int Id{ get; set; }
        // public string Name{ get; set; }
        // public double Price{ get; set; }

        // public void SetBook(int id, string name, double price)
        // {
        //     Id = id;
        //     Name = name;
        //     Price = price;
        // }

        // public void PrintMsg()
        // {
        //     System.Console.WriteLine("图书编号：" + Id);
        //     System.Console.WriteLine("图书名称：" + Name);
        //     System.Console.WriteLine("图书价格：" + Price);
        // }
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static double Price { get; set; }

        public static void SetBook(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public static void PrintMsg()
        {
            System.Console.WriteLine("图书编号：" + Id);
            System.Console.WriteLine("图书名称：" + Name);
            System.Console.WriteLine("图书价格：" + Price);
        }
    }

    class User
    {
        public User(string name, string password, string tel)
        {
            this.Name = name;
            this.Password = password;
            this.Tel = tel;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Tel { get; set; }

        public void PringMsg()
        {
            System.Console.WriteLine("用户名：" + this.Name);
            System.Console.WriteLine("密  码：" + this.Password);
            System.Console.WriteLine("手机号：" + this.Tel);
        }

        ~User()
        {
            System.Console.WriteLine("调用了析构方法");
        }
    }

    class SumUtils
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public string Sum(string a, string b)
        {
            return a + b;
        }
        public int Sum(int a)
        {
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                sum += i;
            }
            return sum;
        }
    }

    class SayHello
    {
        public SayHello()
        {
            System.Console.WriteLine("Hello");
        }
        public SayHello(string name)
        {
            System.Console.WriteLine("Hello " + name);
        }
        public SayHello(string name, int age)
        {
            System.Console.WriteLine("Hello " + name + ", " + age);
        }

    }

    class RefClass
    {
        public bool Judge(ref int num)
        {
            if (num % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }

    class OutClass
    {
        public void Judge(int num, out bool result)
        {
            if(num % 5 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
    }

    class LambdaClass
    {
        public static int Add(int a, int b) => a + b;
    }

    class FactorialClass
    {
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }

    class OuterClass
    {
        public class InnerClass
        {
            public string CardId{ get; set; }
            public string Password{ get; set; }
            public void PrintMsg()
            {
                System.Console.WriteLine("卡号为：" + CardId);
                System.Console.WriteLine("密码为：" + Password);
            }
        }
    }

    public partial class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Points { get; set; }
        partial void PrintCourse();
        // 调用 PrintCourse 方法
        public void PrintMsg()
        {
            PrintCourses();
        }
    }
    public partial class Course
    {
        public void PrintCourses()
        {
            Console.WriteLine("课程编号：" + Id);
            Console.WriteLine("课程名称：" + Name);
            Console.WriteLine("课程学分：" + Points);
        }
    }
}