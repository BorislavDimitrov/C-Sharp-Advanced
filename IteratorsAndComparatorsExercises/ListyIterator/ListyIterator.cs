using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int index;

        public List<T> List { get => list; set => list = value; }
        public ListyIterator(params T[] paramCollection)
        {
            this.list = paramCollection.ToList();
            index = 0;
        }

        public bool Move()
        {
            if (index + 1 <= list.Count - 1)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext ()
        {
            if (index == list.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Print ()
        {
            if (list.Count == 0)
            {
                throw new IndexOutOfRangeException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
        }

        

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
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
