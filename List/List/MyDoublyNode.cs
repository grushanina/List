using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class MyDoublyNode <T>
    {
        private T val; 
        private MyDoublyNode<T> next; 
        private MyDoublyNode<T> prev; 

        public MyDoublyNode(T value)
        {
            val = value;
        }

        public T Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }

        public MyDoublyNode<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public MyDoublyNode<T> Prev
        {
            get
            {
                return prev;
            }
            set
            {
                prev = value;
            }
        }
    }
}
