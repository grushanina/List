using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> list1 = new MyList<int>();
            //list1.AddFirst(3);
            //list1.AddFirst(2);
            //list1.AddFirst(1);
            //Console.WriteLine(list1[0]);
            //list1.ForEach(n => Console.WriteLine(n));


            MyDoublyList<int> list2 = new MyDoublyList<int>();
            list2.AddFirst(12);
            list2.AddFirst(11);
            //Console.WriteLine(list2[0]);
            list2.ForEach(n => Console.WriteLine(n));
        }
    }
}
