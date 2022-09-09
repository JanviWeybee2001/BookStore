using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller   // when you write url then , you have to write only book/getallbooks .. because the class name is only book ,.. Controller is a postfix.!!
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository(); 
        }

        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();

            return View();
        }

        public BookModel GetBook(int id)
        {

            return _bookRepository.GetBookById(id);

            //return "book-" + id.ToString();
            //// also you can write ... return $"book-{id}";
            ////http://localhost:63122/book/getbook/2
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {

            return _bookRepository.SearchBook(bookName, authorName);

            //return $"Book with name = {bookName} & Author = {authorName}";
            ////http://localhost:63122/book/searchbooks?bookname=theDream&authorname=janvi
        }
    }
}
