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

        public int Id{ get; set; }
        public string Name{ get; set; }
        public double Price{ get; set; }

        public void SetBook(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public void PrintMsg()
        {
            System.Console.WriteLine("图书编号：" + Id);
            System.Console.WriteLine("图书名称：" + Name);
            System.Console.WriteLine("图书价格：" + Price);
        }
    }
}