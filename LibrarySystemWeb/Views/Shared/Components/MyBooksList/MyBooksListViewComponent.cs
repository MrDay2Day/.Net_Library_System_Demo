using LibrarySystemWeb.Data;
using LibrarySystemWeb.Models;
using LibrarySystemWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystemWeb.Views.Shared.Components.MyBooksList
{
    [Authorize]
    public class MyBooksListViewComponent : ViewComponent
    {
        private readonly BooksService _booksService;
        private readonly LibrarySystemContext _db;

        public MyBooksListViewComponent(BooksService booksService, LibrarySystemContext db)
        {
            _booksService = booksService;
            _db = db;
        }

        [Authorize]
        public IViewComponentResult Invoke(int pageNum = 1)
        {
            if (HttpContext.Request.Query.ContainsKey("pageNum"))
            {
                if (int.TryParse(HttpContext.Request.Query["pageNum"], out int parsedPageNum))
                {
                    pageNum = parsedPageNum;
                }
            }

            var userIdClaim = HttpContext.User.FindFirst("UserId");

            Console.WriteLine($"Page Number: {pageNum}, UserId: {userIdClaim}");


            MyBooksListViewModel model = new MyBooksListViewModel()
            {
                pageNum = pageNum,
                currentPage = pageNum,
                maxPages = 200
            };

            return View(model);
        }
    }
}