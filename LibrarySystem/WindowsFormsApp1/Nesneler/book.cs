using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Nesneler
{
    public class book
    {
        public int bookId { get; set; }
        public string bookName { get; set; }
        public string bookAuthor { get; set; }
        public string bookLanguage { get; set; }
        public string bookPublisher { get; set; }
        public string bookType { get; set; }
        public int bookCount { get; set; }
        public int bookPageCount { get; set; }
        public int bookYear { get; set; }

        public book()
        {
            
        }
        public book(int bookId, string bookName, string bookAuthor, string bookLanguage, string bookPublisher, string bookType, int bookCount, int bookPageCount, int bookYear)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookLanguage = bookLanguage;
            this.bookPublisher = bookPublisher;
            this.bookType = bookType;
            this.bookCount = bookCount;
            this.bookPageCount = bookPageCount;
            this.bookYear = bookYear;
        }

        public void setBookId(int bookId)
        {
            this.bookId = bookId;
        }
        public int getBookId()
        {
             return this.bookId;
        }

        public void setBookName(string bookName)
        {
            this.bookName = bookName;
        }
        public string getBookName()
        {
            return this.bookName;
        }

        public void setBookAuthor(string bookAuthor)
        {
            this.bookAuthor = bookAuthor;
        }
        public string getBookAuthor()
        {
            return this.bookAuthor;
        }

        public void setBookLanguage(string bookLanguage)
        {
            this.bookLanguage = bookLanguage;
        }
        public string getBookLanguage()
        {
            return this.bookLanguage;
        }

        public void setBookPublisher(string bookPublisher)
        {
            this.bookPublisher = bookPublisher;
        }
        public string getBookPublisher()
        {
            return this.bookPublisher;
        }

        public void setBookType(string bookType)
        {
            this.bookType = bookType;
        }
        public string getBookType()
        {
            return this.bookType;
        }

        public void setBookCount(int bookCount)
        {
            this.bookCount = bookCount;
        }
        public int getBookCount()
        {
            return this.bookCount;
        }

        public void setBookPageCount(int bookPageCount)
        {
            this.bookPageCount = bookPageCount;
        }
        public int getBookPageCount()
        {
            return this.bookPageCount;
        }

        public void setBookYear(int bookYear)
        {
            this.bookYear = bookYear;
        }
        public int getBookYear()
        {
            return this.bookYear;
        }
    }
}
