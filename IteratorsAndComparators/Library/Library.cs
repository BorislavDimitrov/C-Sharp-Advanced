using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator() => new LibraryIterator(books);
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();


        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.books = new List<Book>(books);
                this.books.Sort(new BookComparator());
                Reset();
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose() { }


            public bool MoveNext() => ++currentIndex < books.Count;


            public void Reset() => currentIndex = -1;
        }
    }
}
