using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    
    public class MyList<T>
    {
        
        private int count; 
        private MyNode<T> first; 
        private MyNode<T> last; 

        


        
        public int Count()
        {
            return count; 
        }

        
        public void AddFirst(T value)
        {
            
            MyNode<T> node = new MyNode<T>(value);

            
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
            MyNode<T> node = new MyNode<T>(value);

            
            if (first == null)
            {
                first = node;
                last = node;
            }
              
            else
            {
                
                last.Next = node;
                
                last = node;
            }
            count++;
        }

        public void Insert(T value, int pos)
        {
            MyNode<T> node = new MyNode<T>(value);

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
                MyNode<T> tmp = first;
                for (int i = 0; i < pos - 1; i++)
                {
                    tmp = tmp.Next;
                }
                node.Next = tmp.Next;
                tmp.Next = node;
            }
            count++;
        }

        
        public MyNode<T> Last()
        {
            return last;
        }

        
        public MyNode<T> First()
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
            
            MyNode<T> tmp = first;
            int i = 0;
            
            while (!tmp.Value.Equals(value) && tmp != null)
            {
                
                tmp = tmp.Next;
                i++;
            }
            return i;
        }

        public MyNode<T> Find(int index)
        {
            if (index > count - 1)
            {
                return null;
            }
            MyNode<T> tmp = first;
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
