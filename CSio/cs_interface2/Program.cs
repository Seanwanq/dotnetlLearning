using System;

namespace cs_interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ITest test1 = new Test1();
            // test1.methodA();
            // ITest test2 = new Test2();
            // test2.methodA();
            IShape shape1 = new Rectangle(10, 20);
            shape1.X = 100;
            shape1.Y = 200;
            shape1.Color = "红色";
            shape1.Draw();
            IShape shape2 = new Circle(10);
            shape2.X = 300;
            shape2.Y = 500;
            shape2.Color = "蓝色";
            shape2.Draw();
        }
    }
    interface ITest
    {
        void methodA();
    }
    class Test1:ITest
    {
        public void methodA()
        {
            System.Console.WriteLine("Test1 类中的 methodA 方法");
        }
    }
    class Test2:ITest
    {
        public void methodA()
        {
            System.Console.WriteLine("Test2 类中的 methodA 方法");
        }
    }
    interface IShape
    {
        double Area{ get;}
        double X{ get; set; }
        double Y{ get; set; }
        string Color{ get; set; }
        void Draw();
    }
    class Rectangle:IShape
    {
        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public double Length{ get; set; }
        public double Width{ get; set; }
        public double Area
        {
            get
            {
                return Length * Width;
            }
        }
        public string Color{ get; set; }
        public double X{ get; set; }
        public double Y{ get; set; }
        public void Draw()
        {
            System.Console.WriteLine("绘制图形如下：");
            System.Console.WriteLine("在坐标 {0},{1} 的位置绘制面积为 {2} 颜色为 {3} 的矩形", X, Y, Area, Color);
        }
    }
    class Circle:IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius{ get; set; }
        public double Area
        {
            get
            {
                return Radius * Radius * 3.14;
            }
        }
        public string Color{ get; set; }
        public double X{ get; set; }
        public double Y{ get; set; }
        public void Draw()
        {
            System.Console.WriteLine("绘制图形如下：");
            System.Console.WriteLine("在坐标为 {0},{1} 的位置绘制面积为 {2} 颜色为 {3} 的圆形", X, Y, Area, Color);
        }
    }
}
