using System.Collections.Generic;
using System.Collections;
using System;

namespace ex_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList list = new ArrayList() { "aaa", "bbb", "abc", 123, 456 };

            // int index = list.IndexOf("abc");
            // if(index != -1)
            // {
            //     System.Console.WriteLine("集合中存在 abc 元素！");
            // }
            // else
            // {
            //     System.Console.WriteLine("集合中不存在 abc 元素！");
            // }

            // --------------

            // ArrayList newList = new ArrayList();
            // for (int i = 0; i < list.Count; i += 2)
            // {
            //     newList.Add(list[i]);
            // }
            // foreach(var v in newList)
            // {
            //     System.Console.WriteLine(v);
            // }

            // --------------

            // ArrayList insertList = new ArrayList() { "A", "B", "C" };
            // list.InsertRange(1, insertList);
            // foreach(var v in list)
            // {
            //     System.Console.WriteLine(v);
            // }

            // --------------

            // ArrayList list = new ArrayList() { "aaa", "bbb", "abc" };
            // list.Sort();
            // foreach(var v in list)
            // {
            //     System.Console.WriteLine(v);
            // }

            // --------------

            ArrayList list = new ArrayList() { "a", "b", "c", 1, 2 };
            MyCompare myCompare = new MyCompare();
            list.Sort(myCompare);
            foreach(var v in list)
            {
                System.Console.WriteLine(v);
            }
        }
    }
    class MyCompare:IComparer
    {
        public int Compare(object x, object y)
        {
            string str1 = x.ToString();
            string str2 = y.ToString();
            return str1.CompareTo(str2);
        }
    }
}
