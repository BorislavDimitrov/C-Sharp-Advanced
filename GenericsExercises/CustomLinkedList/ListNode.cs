using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Previous { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T value)
        {
            Value = value;
        }
    }
}
