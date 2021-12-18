using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack = new Stack<T>();
        public int Count { get => stack.Count;  }

        
        public void Add(T elemnt)
        {
            stack.Push(elemnt);
        }

        public T Remove()
        {
            return stack.Pop();
        }
    }
}
