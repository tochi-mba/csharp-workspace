using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCsharp
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages) { 
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public bool IsNovel()
        {
            if (pages > 200)
            {
                return true;
            }

            return false;
        }

        public string FirstName()
        {
            return author.Split(" ")[0];
        }
    }
}
