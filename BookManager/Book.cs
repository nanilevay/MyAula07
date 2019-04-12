using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    class Book
    {
        private string title;
        private string author;
        private static int bookCounter;
      //private int pages;
      //private int wordCount;

        public Book (string title, string author)
        {
            this.title = title;
            this.author = author;
            bookCounter++;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            if (this.title != null && this.title.Length > 0)
                this.title = title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public int GetTitleLength() => title.Length;

        static public int GetCounter() => bookCounter;

        static public int Inc() => bookCounter;

        // public void AssignWordCountFromText(string text)
        // {
        //     wordCount = text.Split(' ').Length;
        // }
    }
}