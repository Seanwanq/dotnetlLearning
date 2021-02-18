using System;

namespace code_2 {
    class Program {
        static void Main (string[] args) {
            // int[] a = { 1, 2, 3 };
            // System.Console.WriteLine(a[0]);
            // System.Console.WriteLine(a[a.Length-1]);

            // string[] strs = { "aaa", "bbb", "ccc", "ddd", "eee" };
            // for (var i = 0; i < strs.Length; i+=2)
            // {
            //     System.Console.WriteLine(strs[i]);
            // }

            // int[] a = new int[5];
            // System.Console.WriteLine ("请输入5个整数：");
            // for (int i = 0; i < a.Length; i++) {
            //     a[i] = int.Parse (Console.ReadLine ()); // 讲字符串类型转换成整型
            // }
            // int max = a[0]; // 这里假设a[0]是最大的
            // for (int i = 1; i < a.Length; i++) {
            //     if (a[i] > max) {
            //         max = a[i];
            //     }
            // }
            // System.Console.WriteLine("数组中最大值为：" + max);

            // double[,] points = { { 90, 80 }, { 100, 89 }, { 88.5, 86 } };
            // for(int i = 0; i < points.GetLength(0); i++)
            // {
            //     Console.WriteLine("第" + (i + 1) + "个学生成绩：");
            //     for(int j = 0; j < points.GetLength(1); j++)
            //     {
            //         Console.Write(points[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }

            // int[, ] da = { { 1, 2 }, { 2, 3 } };
            // int[, , ] ta = { { { 1, 2 }, { 1, 2 } },
            //     { { 1, 2 }, { 2, 3 } }
            // };

            // int[][] arrays = new int[3][];
            // arrays[0] = new int[] { 1, 2 };
            // arrays[1] = new int[] { 3, 4, 5 };
            // arrays[2] = new int[] { 6, 7, 8, 9 };
            // for (int i = 0; i < arrays.Length; i++)
            // {
            //      Console.WriteLine("输出数组中第" + (i + 1) + "行的元素：");
            //     for(int j=0;j<arrays[i].Length; j++)
            //     {
            //         Console.Write(arrays[i][j] + " ");
            //     }
            //     Console.WriteLine();
            // }

            // double[] points = { 80, 88, 86, 90, 75.5 };
            // double sum = 0;
            // double avg = 0;
            // foreach (double point in points) {
            //     sum += point;
            // }
            // avg = sum / points.Length;
            // System.Console.WriteLine("总成绩为：" + sum);
            // System.Console.WriteLine("平均成绩为：" + avg);

            // System.Console.WriteLine ("请输入一个字符串：");
            // string str = Console.ReadLine ();
            // string[] condition = { "," };
            // string[] result = str.Split (condition, StringSplitOptions.None);
            // System.Console.WriteLine(result[1]);
            // System.Console.WriteLine("字符串中含有逗号的个数为：" + (result.Length - 1));

            // int[] a = { 5, 1, 7, 2, 3 };
            // for(int i = 0; i < a.Length; i++)
            // {
            //     for(int j = 0; j < a.Length - i - 1; j++)
            //    {
            //         if (a[j] > a[j + 1])
            //        {
            //             int temp = a[j];
            //             a[j] = a[j + 1];
            //            a[j + 1] = temp;
            //         }
            //     }
            // }
            // Console.WriteLine("升序排序后的结果为：");
            // foreach(int b in a)
            // {
            //     Console.Write(b + "");
            // }
            // Console.WriteLine();

            /***
            1	Clear()	清空数组中的元素
            2  	Sort()	冒泡排序，从小到大排序数组中的元素
            3	Reverse()	将数组中的元素逆序排列
            4	IndexOf()	查找数组中是否含有某个元素，返回该元素第一次出现的位置，如果没有与之匹配的元素，则返回 -1
            5	LastIndexOf()	查找数组中是否含有某个元素，返回该元素最后一次出现的位置
            */

            // int[] a = { 5, 3, 2, 4, 1 };
            // Array.Sort(a);
            // Console.WriteLine("排序后的结果为：");
            // foreach(int b in a)
            // {
            //     Console.Write(b + " ");
            // }
            // Console.WriteLine();

            // System.Console.WriteLine(EnumTest.Title.助教 + ": " + (int)EnumTest.Title.助教);
            // System.Console.WriteLine(EnumTest.Title.讲师 + ": " + (int)EnumTest.Title.讲师);
            // System.Console.WriteLine(EnumTest.Title.副教授 + ": " + (int)EnumTest.Title.副教授);
            // System.Console.WriteLine(EnumTest.Title.教授 + ": " + (int)EnumTest.Title.教授);

            // student stu = new student ();
            // stu.Name = "张三";
            // stu.Age = -100;
            // System.Console.WriteLine("学生的信息为：");
            // System.Console.WriteLine(stu.Name + ": " + stu.Age);

            student stu = new student ("李四", 25);
            stu.PrintStudent ();

        }

        // struct student {
        //     private string name;
        //     private int age;
        //     public string Name {
        //         get {
        //             return name;
        //         }
        //         set {
        //             name = value;
        //         }
        //     }
        //     public int Age {
        //         get {
        //             return age;
        //         }
        //         set {
        //             if (value < 0) {
        //                 value = 0;
        //             } else {
        //                 age = value;
        //             }
        //         }
        //     }
        // }

        public struct student {
            public student (string name, int age) {
                this.name = name;
                this.age = age;
            }
            private string name;
            private int age;
            public void PrintStudent () {
                System.Console.WriteLine ("姓名：" + name);
                System.Console.WriteLine ("年龄：" + age);
            }

        }
    }
}