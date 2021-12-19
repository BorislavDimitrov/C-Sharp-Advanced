using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    class Stack<T> : IEnumerable<T>
    {
        private List<T> list;

        public Stack()
        {
            list = new List<T>();
        }

        public void Push(params T[] paramElements)
        {
            List<T> newElements = paramElements.ToList();
            list.AddRange(newElements);
        }

        public void Pop()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No elements"); ;
            }
            else
            {
                //T removedElement = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                //return removedElement;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
