using System;
using System.Collections.Generic;
using System.Text;

namespace Kickstart.BookShare.Common.Models
{
    public class Book
    {
        public enum BookType { Hardcopy, Downloadable }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public BookType Type { get; private set; } = BookType.Hardcopy;

        public bool Available { get; set; }

        public Book() { }

        public Book(string title, string description)
        {
            SetTitle(title);
            SetDescription(description);
        }

        public void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The title of a book can't be null or empty");

            Title = title.Trim();
        }

        public void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("The description of a book can't be null or empty");

            Description = description.Trim();
        }
    }
}
