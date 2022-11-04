using System;

namespace Steps
{
    public struct Book
    {
        private readonly short pages;
        private readonly string author, name;
        private readonly short date;

        public Book(short pages, string author, string name, short date)
        {
            this.pages = pages;
            this.author = author;
            this.name = name;
            this.date = date;
        }

        public void printBook()
        {
            Console.WriteLine($"Книга: {name}, автор: {author}, дата публикации: {date}, количество страниц: {pages}");
        }

    }
}
