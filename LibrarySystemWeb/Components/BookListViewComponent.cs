using LibrarySystemWeb.Data;
using LibrarySystemWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystemWeb.Components
{
    // In Components folder
    public class BookListViewComponent : ViewComponent
    {
        private readonly BooksService _booksService;
        private readonly LibrarySystemContext _db;

        public BookListViewComponent(BooksService booksService, LibrarySystemContext db)
        {
            _booksService = booksService;
            _db = db;
        }

        //public async Task<IViewComponentResult> InvokeAsync(int count = 5)
        //{
        //    var books = await _booksService.GetBooksAsync(count);
        //    return View(books);
        //}

        public IViewComponentResult Invoke()
        {
            var books = _db.Books
                .OrderBy(x => Guid.NewGuid()) // Equivalent to ORDER BY NEWID()
            .Take(9)
            .ToList();

            return View(books);
        }
    }
}
