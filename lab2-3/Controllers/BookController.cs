using lab2_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2_3.Controllers
{
    public class BookController : Controller
    {
        private List<Book> listBooks;
        public BookController()
        {
            listBooks = new List<Book>();
            listBooks.Add(new Book()
            {
                ID = 1,
                Title = "luc van tien 1",
                Author = "author1",
                Image = "Content/image/lvt.png"
            });
            listBooks.Add(new Book()
            {
                ID = 2,
                Title = "luc van tien 2",
                Author = "author1",
                Image = "Content/image/lvt.png"
            });
            listBooks.Add(new Book()
            {
                ID = 3,
                Title = "luc van tien 3",
                Author = "author1",
                Image = "Content/image/lvt.png"
            });

        }
        // GET: Books
        public ActionResult ListBooks()
        {
            ViewBag.TitlePageName = "Book view page";
            return View(listBooks);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBooks.Find(s => s.ID == id);
            if (book == null)
                return HttpNotFound();
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var editBook = listBooks.Find(b => b.ID == book.ID);
                    editBook.Title = book.Title;
                    editBook.Author = book.Author;
                    editBook.Image = book.Image;
                    return View("ListBooks", listBooks);
                }
                catch (Exception ex)
                {
                    return HttpNotFound();
                }
            }
            else
            {
                ModelState.AddModelError("", "Input Model Not Valid!");
                return View(book);
            }
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Book book = listBooks.Find(s => s.ID == id);
            if (book == null)
                return HttpNotFound();
            return View(book);
        }

        public ActionResult CreateBook()
        {
            return View();
        }

    }
}