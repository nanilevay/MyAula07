using System;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookNumber;
            Book[] bookList;

            Console.WriteLine("How many books do u have?");
            bookNumber = Convert.ToInt32(Console.ReadLine());

            bookList = new Book[bookNumber];

            for (int i = 0; i < bookNumber; i++)
            {
                Console.WriteLine("what's the title?");
                string title = Console.ReadLine();
                Console.WriteLine("what's the author?");
                string author = Console.ReadLine();

                Book book = new Book(title, author);

                bookList[i] = book;
            }
            
            for (int j = 0; j < bookNumber; j++)
            {
                Console.WriteLine("title:" + bookList[j].GetTitle());
                Console.WriteLine("length:" + bookList[j].GetTitleLength());
                Console.WriteLine("author:" + bookList[j].GetAuthor());
            }

            Console.WriteLine(Book.Inc());

        }
    }
}