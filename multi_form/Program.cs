using System;

namespace multi_form
{
    class Program
    {
        static void Main(string[] args)
        {
            Major major1 = new Undergraduate();
            major1.Id = 1;
            major1.Name = "张晓";
            Console.WriteLine("本科生信息：");
            Console.WriteLine("学号：" + major1.Id + "姓名：" + major1.Name);
            major1.Requirement();
            Major major2 = new Graduate();
            major2.Id = 2;
            major2.Name = "李明";
            Console.WriteLine("研究生信息：");
            Console.WriteLine("学号：" + major2.Id + "姓名：" + major2.Name);
            major2.Requirement();
        }
    }
    abstract class Major
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Requirement();
    }
    class Undergraduate:Major
    {
        public override void Requirement()
        {
            System.Console.WriteLine("本科生学制4年，必须修满48学分");
        }
    }
    class Graduate:Major
    {
        public override void Requirement()
        {
            System.Console.WriteLine("研究生学制3年，必须修满32学分");
        }
    }
}
