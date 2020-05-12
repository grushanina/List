using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class MyDoublyList<T>
    {

        private int count; 
        private MyDoublyNode<T> first;
        private MyDoublyNode<T> last; 


        public int Count()
        {
            return count;
        }

        public void AddFirst(T value)
        {
            MyDoublyNode<T> node = new MyDoublyNode<T>(value);

            if (first == null)
            {
                first = node;
                last = node;
            }

            else
            {
                node.Next = first;
                first = node;
            }
            count++;
        } 
        public void AddLast(T value)
        {
            MyDoublyNode<T> node = new MyDoublyNode<T>(value);

            if (first == null)
            {
                first = node;
                last = node;
            }
   
            else
            {
                last.Next = node;
                node.Prev = last;
                last = node;
            }
            count++;
        }

        public void Insert(T value, int pos)
        {
            MyDoublyNode<T> node = new MyDoublyNode<T>(value);

            if (pos == 0)
            {
                node.Next = first;
                first = node;
                if (last == null)
                {
                    last = node;
                }
            }

            else
            {
                MyDoublyNode<T> tmp = first;
                for (int i = 0; i < pos - 1; i++)
                {
                    tmp = tmp.Next;
                }
                node.Next = tmp.Next;
                node.Prev = tmp.Prev;
                tmp.Next = node;
            }
            count++;
        }

        public MyDoublyNode<T> Last()
        {
            return last;
        }

        public MyDoublyNode<T> First()
        {
            return first;
        }


        public void Clear()
        {
            first = null;
            last = null;
            count = 0;
        }

        public int Size()
        {
            return count;
        }

        public int IndexOf(T value)
        {

            MyDoublyNode<T> tmp = first;
            int i = 0;
            while (!tmp.Value.Equals(value) && tmp != null)
            {
                tmp = tmp.Next;
                i++;
            }
            return i;
        }

        public MyDoublyNode<T> Find(int index)
        {
            if (index > count - 1)
            {
                return null;
            }

            MyDoublyNode<T> tmp = first;
            int i = 0;
            while (index != i)
            {
                tmp = tmp.Next;
                i++;
            }
            return tmp;
        }

        public T this[int index]
        {
            get
            {
                if (index > count - 1)
                {
                    return default;
                }
                return Find(index).Value;
            }

            set
            {
                Insert(value, index);
            }

        }

        public void ForEach(System.Action<T> action)
        {
            for (int i = 0; i != count; ++i)
            {
                action(Find(i).Value);
            }
        }
    }
}
