using System;

namespace code_1 {
    class Program {
        static void Main (string[] args) {
            // Console.WriteLine("Hello World!");
            // Book book = new Book();
            // book.Id = 1;
            // book.Name = "计算机基础";
            // book.Price = 34.5;
            // book.SetBook(1, "计算机基础", 34.5);
            // book.PrintMsg();

            // Book.SetBook (1, "计算机基础", 34.5);
            // Book.PrintMsg ();

            // User user = new User ("小明", "123456", "13131351111");
            // user.PringMsg ();

            // SumUtils s = new SumUtils();
            // // 调用两个整数求和的方法
            // System.Console.WriteLine("两个整数的和为：" + s.Sum(3, 5));
            // // 调用两个小数求和的方法
            // System.Console.WriteLine("两个小数的和为：" + s.Sum(3.2, 5.6));
            // // 调用连个字符串连接的方法
            // System.Console.WriteLine("两个字符串的连接结果为：" + s.Sum("C#", "方法重载"));
            // // 输出 1 到 10 的和
            // System.Console.WriteLine("1 到 10 和为：" + s.Sum(10));

            // SayHello say1 = new SayHello();
            // SayHello say2 = new SayHello("小明");
            // SayHello say3 = new SayHello("张三", 20);

            // RefClass refClass = new RefClass();
            // int a = 20;
            // bool result = refClass.Judge(ref a);
            // System.Console.WriteLine("验证结果是：" + result);

            // OutClass outClass = new OutClass();
            // bool rs;
            // outClass.Judge(20, out rs);
            // System.Console.WriteLine(rs);

            // System.Console.WriteLine(LambdaClass.Add(100, 200));

            // int rs = FactorialClass.Factorial(5);
            // System.Console.WriteLine("递归结果是：" + rs);

            // OuterClass.InnerClass outInner = new OuterClass.InnerClass();
            // outInner.CardId = "622211100";
            // outInner.Password = "123456";
            // outInner.PrintMsg();

            // Course course = new Course();
            // course.Id = 1001;
            // course.Name = "C#部分类";
            // course.Points = 3;
            // course.PrintCourse();

            // Course course = new Course();
            // course.Id = 1001;
            // course.Name = "C#部分类";
            // course.Points = 3;
            // course.PrintMsg();

            // Console.WriteLine("请输入学生姓名：");
            // string name = Console.ReadLine();
            // Console.WriteLine("请输入所在学校：");
            // string school = Console.ReadLine();
            // Console.WriteLine("{0}同学在{1}学习", name, school);

            // Console.WriteLine("请输入第一个数：");
            // double num1 = Double.Parse(Console.ReadLine());
            // Console.WriteLine("请输入第二个数：");
            // double num2 = Double.Parse(Console.ReadLine());
            // Console.WriteLine("两个数中较大的数为{0}", Math.Max(num1, num2));
            // Console.WriteLine("两个数中较小的数为{0}", Math.Min(num1, num2));

            // Random rd = new Random();
            // System.Console.WriteLine("产生一个10以内的数：{0}", rd.Next(0, 10));
            // System.Console.WriteLine("产生一个0到1之间的浮点数：{0}", rd.NextDouble());
            // byte[] b = new byte[5];
            // rd.NextBytes(b);
            // System.Console.WriteLine("产生的byte类型的值为：");
            // foreach(byte i in b)
            // {
            //     System.Console.Write(i + " ");
            // }
            // System.Console.WriteLine();

            DateTime dt = DateTime.Now;
            System.Console.WriteLine("当前时间为：{0}", dt);
            System.Console.WriteLine("当前是本月的第{0}天", dt.Day);
            System.Console.WriteLine("当前是：{0}", dt.DayOfWeek);
            System.Console.WriteLine("当前是本年的第{0}天", dt.DayOfYear);
            System.Console.WriteLine("30天后的日期是{0}", dt.AddDays(30));

            DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(2029, 6, 1);
            TimeSpan ts = dt2 - dt1;
            System.Console.WriteLine("间隔的天数为{0}天", ts.Days);
        }
    }
}