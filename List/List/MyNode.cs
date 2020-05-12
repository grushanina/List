using System;
using System.Collections.Generic;
using System.Text;


namespace List
{
    
    public class MyNode<T> 
    {
        
        private T val; 
        private MyNode<T> next; 

         
        public MyNode(T value)
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

        
        public MyNode<T> Next
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
    }
}
