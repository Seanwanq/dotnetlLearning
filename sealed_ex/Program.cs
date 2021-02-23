using System;

// sealed 类不能被继承与重写

namespace sealed_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // B b = new B();
            B b = new B("ok");
        }
    }

    abstract class AreaAbstract
    {
        public abstract void Area();
    }
    class Rectangle:AreaAbstract
    {
        public double Width{ get; set; }
        public double Length{ get; set; }
        public sealed override void Area()
        {
            System.Console.WriteLine("矩形的面积是：" + Width * Length);
        }
    }
    sealed class Circle:AreaAbstract
    {
        public double r{ get; set; }
        public override void Area()
        {
            System.Console.WriteLine("圆的面积是：" + r * 3.14 * 3.14);
        }
    }
    // class A
    // {
    //     public A()
    //     {
    //         System.Console.WriteLine("A类的构造器");
    //     }
    // }
    // class B:A
    // {
    //     public B()
    //     {
    //         System.Console.WriteLine("B类的构造器");
    //     }
    // }
    // class A
    // {
    //     public A()
    //     {
    //         System.Console.WriteLine("A类的构造器");
    //     }
    // }
    // class B:A
    // {
    //     public B()
    //     {
    //         System.Console.WriteLine("B类的构造器");
    //     }
    //     public B(string name)
    //     {
    //         System.Console.WriteLine("B类中带参数的构造器，传入的值为：" + name);
    //     }
    // }
    class A
    {
        public A()
        {
            System.Console.WriteLine("A类的构造器");
        }
        public A(string name)
        {
            System.Console.WriteLine("A类的构造器，传入的值为：" + name);
        }
    }
    class B:A
    {
        public B()
        {
            System.Console.WriteLine("B类的构造器");
        }
        public B(string name):base(name)
        {
            System.Console.WriteLine("B类中带参数的构造器，传入的值为：" + name);
        }
    }

}
