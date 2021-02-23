using System;

namespace cs_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // ComputerMajor computerMajor = new ComputerMajor();
            // computerMajor.Id = 1;
            // computerMajor.Name = "李明";
            // computerMajor.English = 80;
            // computerMajor.Programming = 90;
            // computerMajor.Database = 85;
            // Console.WriteLine("学号：" + computerMajor.Id);
            // Console.WriteLine("姓名：" + computerMajor.Name);
            // Console.WriteLine("成绩信息如下：");
            // computerMajor.Total();
            // computerMajor.Avg();

            ComputerMajor computerMajor = new ComputerMajor();
            ICompute compute = computerMajor;       //创建接口的实例
            compute.Id = 1;
            compute.Name = "李明";
            computerMajor.English = 80;
            computerMajor.Programming = 90;
            computerMajor.Database = 85;
            Console.WriteLine("学号：" + compute.Id);
            Console.WriteLine("姓名：" + compute.Name);
            Console.WriteLine("成绩信息如下：");
            compute.Total();
            compute.Avg();
        }
    }
    interface ICompute
    {
        int Id{ get; set; }
        string Name{ get; set; }
        void Total();
        void Avg();
    }
    // class ComputerMajor:ICompute
    // {
    //     public int Id{ get; set; }
    //     public string Name{ get; set; }
    //     public double English{ get; set; }
    //     public double Programming{ get; set; }
    //     public double Database{ get; set; }
    //     public void Avg()
    //     {
    //         double avg = (English + Programming + Database) / 3;
    //         System.Console.WriteLine("平均分：" + avg);
    //     }
    //     public void Total()
    //     {
    //         double sum = English + Programming + Database;
    //         Console.WriteLine("总分为：" + sum);
    //     }
    // }

    class ComputerMajor:ICompute
    {
        public double English{ get; set; }
        public double Programming{ get; set; }
        public double Database{ get; set; }
        int ICompute.Id{ get; set; }
        string ICompute.Name{ get; set; }
        void ICompute.Total()
        {
            double sum = English + Programming + Database;
            Console.WriteLine("总分数：" + sum);
        }
        void ICompute.Avg()
        {
            double avg = (English + Programming + Database) / 3;
            Console.WriteLine("平均分为：" + avg);
        }
    }


    interface ITest
    {
        string name{ get; set; }
        void Print();
    }
    abstract class Test:ITest
    {
        public abstract string name { get; set; }
        public abstract void Print();
    }
}
