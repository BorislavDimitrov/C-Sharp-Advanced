using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public Book(string title , int year , params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public int CompareTo([AllowNull] Book other)
        {
            if (Year.CompareTo(other.Year) == 0)
            {
                return Title.CompareTo(other.Title);
            }
            else
            {
                return Year.CompareTo(other.Year);
            }
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
