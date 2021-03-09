using Kickstart.BookShare.Common.Models;
using NUnit.Framework;
using System;

namespace Kickstart.BookShare.Common.UnitTests.Models
{
    class BookTests
    {
        [Test]
        public void SetTitle_ValidValueIsSet()
        {
            var book = new Book();
            book.SetTitle("Book Title");

            Assert.AreEqual("Book Title", book.Title);
        }

        [Test]
        public void SetTitle_ValidValueTrimmed()
        {
            var book = new Book();
            book.SetTitle("  Book Title    ");

            Assert.AreEqual("Book Title", book.Title);
        }

        [Test]
        public void SetTitle_InvalidValueThrows()
        {
            var book = new Book();
            Assert.Throws<ArgumentException>(()=>book.SetTitle(null));
            Assert.Throws<ArgumentException>(() => book.SetTitle(""));
            Assert.Throws<ArgumentException>(() => book.SetTitle(" "));
        }

        [Test]
        public void SetDescription_ValidValueIsSet()
        {
            var book = new Book();
            book.SetDescription("Book Description");

            Assert.AreEqual("Book Description", book.Description);
        }

        [Test]
        public void SetDescription_ValidValueTrimmed()
        {
            var book = new Book();
            book.SetDescription("  Book Description    ");

            Assert.AreEqual("Book Description", book.Description);
        }

        [Test]
        public void SetDescription_InvalidValueThrows()
        {
            var book = new Book();
            Assert.Throws<ArgumentException>(() => book.SetDescription(null));
            Assert.Throws<ArgumentException>(() => book.SetDescription(""));
            Assert.Throws<ArgumentException>(() => book.SetDescription(" "));
        }
    }
}
