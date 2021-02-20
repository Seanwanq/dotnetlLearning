using System;

namespace code_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student stu1 = new Student();
            // Student stu2 = new Student();
            // bool flag = Equals(stu1, stu2);
            // System.Console.WriteLine("stu1和stu2比较结果为, {0}", flag);

            // Student stu1 = new Student();
            // Student stu2 = new Student();
            // System.Console.WriteLine(stu1.GetHashCode());
            // System.Console.WriteLine(stu2.GetHashCode());

            // int i = 100;
            // string str = "abc";
            // Student stu = new Student();
            // System.Console.WriteLine(i.GetType());
            // System.Console.WriteLine(str.GetType());
            // System.Console.WriteLine(stu.GetType());

            // Int32 a = 1;
            // Object b = new Object();
            // System.Console.WriteLine("值类型(Int32类型)的字符串的表现形式：{0}", a.ToString());
            // System.Console.WriteLine("引用类型字符串的表现形式：{0}", b.ToString());

            // Student stu = new Student();
            // stu.Major = "Ph";
            // stu.Grade = "G2";
            // stu.Id = 123;
            // stu.Name = "小明";
            // stu.Sex = "Male";
            // stu.Cardid = "ok123";
            // stu.Tel = "123456";
            // // stu.pPrint();
            // stu.Print();

            // A a1 = new B();
            // a1.Print();
            // A a2 = new C();
            // a2.Print();

            // // 将父类转换成子类，强制转换
            // C c = (C)a2;
            // c.Print();

            MathMajor mathMajor = new MathMajor();
            mathMajor.Id = 1;
            mathMajor.English = 80;
            mathMajor.Math = 90;
            mathMajor.Total();
            EnglishMojor englishMojor = new EnglishMojor();
            englishMojor.Id = 2;
            englishMojor.English = 80;
            englishMojor.Math = 90;
            englishMojor.Total();

        }
    }

    // class Student {
    //     public int Id { get; set; }
    //     public string Name { get; set; }
    //     public string Sex { get; set; }
    //     public string Cardid { get; set; }
    //     public string Tel { get; set; }
    //     public string Major { get; set; }
    //     public string Grade { get; set; }
    //     public void Print()
    //     {
    //         Console.WriteLine("编号：" + Id);
    //         Console.WriteLine("姓名：" + Name);
    //         Console.WriteLine("性别：" + Sex);
    //         Console.WriteLine("身份证号：" + Cardid);
    //         Console.WriteLine("联系方式：" + Tel);
    //         Console.WriteLine("专业：" + Major);
    //         Console.WriteLine("年级：" + Grade);
    //     }
    // }

    // class Teacher
    // {
    //     public int Id { get; set; }
    //     public string Name { get; set; }
    //     public string Sex { get; set; }
    //     public string Cardid { get; set; }
    //     public string Tel { get; set; }
    //     public string Title { get; set; }
    //     public string WageNo { get; set; }
    //     public void Print()
    //     {
    //         Console.WriteLine("编号：" + Id);
    //         Console.WriteLine("姓名：" + Name);
    //         Console.WriteLine("性别：" + Sex);
    //         Console.WriteLine("身份证号：" + Cardid);
    //         Console.WriteLine("联系方式：" + Tel);
    //         Console.WriteLine("职称：" + Title);
    //         Console.WriteLine("工资号：" + WageNo);
    //     }
    // }

    // class Person
    // {
    //     public int Id { get; set; }
    //     public string Name { get; set; }
    //     public string Sex { get; set; }
    //     public string Cardid { get; set; }
    //     public string Tel { get; set; }
    //     public void Print()
    //     {
    //         Console.WriteLine("编号：" + Id);
    //         Console.WriteLine("姓名：" + Name);
    //         Console.WriteLine("性别：" + Sex);
    //         Console.WriteLine("身份证号：" + Cardid);
    //         Console.WriteLine("联系方式：" + Tel);
    //     }
    // }

    // class Student:Person
    // {
    //     public string Major{ get; set; }
    //     public string Grade{ get; set; }
    //     public void Print()
    //     {
    //         base.Print();
    //         System.Console.WriteLine("专业：" + Major);
    //         System.Console.WriteLine("年纪：" + Grade);
    //     }
    // }

    // class Teacher:Person
    // {
    //     public string Title { get; set; }
    //     public string WageNo { get; set; }
    //     public void Print()
    //     {
    //         base.Print();
    //         System.Console.WriteLine("职称：" + Title);
    //         System.Console.WriteLine("工资号：" + WageNo);
    //     }
    // }

    // class Person
    // {
    //     public int Id { get; set; }
    //     public string Name { get; set; }
    //     public string Sex { get; set; }
    //     public string Cardid { get; set; }
    //     public string Tel { get; set; }
    //     public virtual void Print()
    //     {
    //         System.Console.WriteLine("编号：" + Id);
    //         System.Console.WriteLine("姓名：" + Name);
    //         System.Console.WriteLine("性别：" + Sex);
    //         System.Console.WriteLine("身份证号：" + Cardid);
    //         System.Console.WriteLine("联系方式：" + Tel);
    //     }
    // }

    // class Student:Person
    // {
    //     public string Major{ get; set; }
    //     public string Grade{ get; set; }
    //     public override void Print()
    //     {
    //         Console.WriteLine("编号："+ Id);
    //         Console.WriteLine("姓名："+ Name);
    //         Console.WriteLine("性别："+ Sex);
    //         Console.WriteLine("身份证号："+ Cardid);
    //         Console.WriteLine("联系方式："+ Tel);
    //         Console.WriteLine("专业："+ Major);
    //         Console.WriteLine("年级："+ Grade);
    //     }
    // }

    // class Teacher:Person
    // {
    //     public string Major{ get; set; }
    //     public string Grade{ get; set; }
    //     public override void Print()
    //     {
    //         Console.WriteLine("编号："+ Id);
    //         Console.WriteLine("姓名："+ Name);
    //         Console.WriteLine("性别："+ Sex);
    //         Console.WriteLine("身份证号："+ Cardid);
    //         Console.WriteLine("联系方式："+ Tel);
    //         Console.WriteLine("专业："+ Major);
    //         Console.WriteLine("年级："+ Grade);
    //     }
    // }

    // class Person
    // {
    //     public int Id { get; set; }
    //     public string Name { get; set; }
    //     public string Sex { get; set; }
    //     public string Cardid { get; set; }
    //     public string Tel { get; set; }
    //     public virtual void Print()
    //     {
    //         System.Console.WriteLine("编号：" + Id);
    //         System.Console.WriteLine("姓名：" + Name);
    //         System.Console.WriteLine("性别：" + Sex);
    //         System.Console.WriteLine("身份证号：" + Cardid);
    //         System.Console.WriteLine("联系方式：" + Tel);
    //     }
    // }

    // class Student:Person
    // {
    //     public string Major{ get; set; }
    //     public string Grade{ get; set; }
    //     public override void Print()
    //     {
    //         base.Print();
    //         Console.WriteLine("专业："+ Major);
    //         Console.WriteLine("年级："+ Grade);
    //     }
    // }

    // class Teacher:Person
    // {
    //     public string Major{ get; set; }
    //     public string Grade{ get; set; }
    //     public override void Print()
    //     {
    //         base.Print();
    //         Console.WriteLine("专业："+ Major);
    //         Console.WriteLine("年级："+ Grade);
    //     }
    // }

    // class A
    // {
    //     public virtual void Print()
    //     {
    //         System.Console.WriteLine("A");
    //     }
    // }

    // class B:A
    // {
    //     public new void Print()
    //     {
    //         System.Console.WriteLine("B");
    //     }
    // }

    // class C:A
    // {
    //     public override void Print()
    //     {
    //         System.Console.WriteLine("C");
    //     }
    // }

    // class Student
    // {
    //     public string Major { get; set; }
    //     public string Grade { get; set; }
    //     public void Print()
    //     {
    //         System.Console.WriteLine("专业：" + Major);
    //         System.Console.WriteLine("年纪：" + Grade);
    //     }
    //     public override string ToString()
    //     {
    //         return Major + ", " + Grade;
    //     }
    // }

    abstract class ExamResult
    {
        // 学号
        public int Id { get; set; }
        // 数学成绩
        public double Math { get; set; }
        // 英语成绩
        public double English { get; set; }
        // 计算总成绩
        public abstract void Total();
    }
    class MathMajor:ExamResult
    {
        public override void Total()
        {
            double total = Math * 0.6 + English * 0.4;
            System.Console.WriteLine("学号为：" + Id + "数学专业学生的成绩为：" + total);
        }
    }

    class EnglishMojor:ExamResult
    {
        public override void Total()
        {
            double total = Math * 0.4 + English * 0.6;
            System.Console.WriteLine("学号为：" + Id + "英语专业学生的成绩为：" + total);
        }
    }
}
