using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    public struct Book
    {
        private short pages;
        private string author, name;
        private short date;

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
