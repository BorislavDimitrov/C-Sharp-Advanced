using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class DoublyLinkedList<T>
    {
        private ListNode<T> first;
        private ListNode<T> last;

        public int Count { get;private set; }

        public void AddFirst(T element)
        {
            ListNode<T> newElement = new ListNode<T>(element);
            if (first == null)
            {
                first = newElement;
                last = newElement;
            }
            else
            {
                first.Previous = newElement;
                newElement.Next = first;
                first = newElement;
            }
            Count++;
        }

        public void AddLast(T element)
        {
            ListNode<T> newElement = new ListNode<T>(element);
            if (last == null)
            {
                last = newElement;
                first = newElement;
            }
            else
            {
                last.Next = newElement;
                newElement.Previous = last;
                last = newElement;
            }
            Count++;
        }

        public T RemoveFirst()
        {
            
            if (first == null)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T result = first.Value;
            if (first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                
                first = first.Next;
                first.Previous = null;
            }
            Count--;
            return result;
        }

        public T RemoveLast()
        {
            
            if (last == null)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T result = first.Value;
            if (last == first)
            {
                last = null;
                first = null;
            }
            else
            {
                result = last.Value;
                last = last.Previous;
                last.Next = null;
            }
            Count--;
            return result;
        }

        public void ForEach(Action<T> expression)
        {
            ListNode<T> currItem = first;

            while (currItem != null)
            {
                expression(currItem.Value);
                currItem = currItem.Next;
            }
        }

        public T[] ToArray()
        {
            List<T> result = new List<T>();
            ListNode<T> currElement = first;

            while (currElement != null)
            {
                result.Add(currElement.Value);
                currElement = currElement.Next;
            }
            return result.ToArray();
        }
    }
}
