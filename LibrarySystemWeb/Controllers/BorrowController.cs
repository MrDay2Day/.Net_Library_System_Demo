using LibrarySystemWeb.Data;
using LibrarySystemWeb.Models;
using LibrarySystemWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing.Printing;
using System.Threading.Tasks;

namespace LibrarySystemWeb.Controllers
{
    public class BorrowController : Controller
    {
        private readonly LibrarySystemContext _context;
        private readonly BooksService _booksService;

        public BorrowController(LibrarySystemContext context, BooksService booksService)
        {
            _context = context;
            _booksService = booksService;
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> BorrowAsync(int bookId, int pageNumber = 1, int pageSize = 10)
        {
            // Fetch paginated books and total count
            var (books, totalCount) = await _booksService.GetBooksPaginatedAsync(pageNumber, pageSize);

            // Calculate the total number of pages
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);


            Console.WriteLine($"BookId: {bookId}");
            Book book = _context.Books.Find(bookId);
            BorrowPageModel model = new BorrowPageModel() {
                book = book,
                Books = books,
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Borrow(BorrowViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "Invalid form data." });
            }

            try
            {
                // Check if book is still available
                var book = await _context.Books.FindAsync(model.BookId);

                if (book == null)
                {
                    return Json(new { success = false, message = "Book not found." });
                }

                if (!book.Available)
                {
                    return Json(new { success = false, message = "This book is no longer available." });
                }

                // Calculate return date
                var borrowDate = DateTime.Now;
                var returnDate = borrowDate.AddDays(model.BorrowDays);

                //// Create borrowing record
                //var borrowing = new Borrowing
                //{
                //    BookId = model.BookId,
                //    UserId = GetCurrentUserId(), // Implement this method based on your authentication system
                //    BorrowDate = borrowDate,
                //    ScheduleReturnDate = returnDate,
                //    IsReturned = false
                //};

                //_context.Borrowings.Add(borrowing);

                //// Update book availability
                //book.IsAvailable = false;
                //_context.Books.Update(book);

                await _context.SaveChangesAsync();

                return Json(new
                {
                    success = true,
                    message = $"Book borrowed successfully. Return date: {returnDate.ToString("yyyy-MM-dd")}"
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Error: {ex.Message}" });
            }
        }

        private int GetCurrentUserId()
        {
            // TODO: Replace with actual user ID retrieval from your authentication system
            // For example, using ASP.NET Core Identity:
            // return int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            // Temporary placeholder:
            return 1;
        }
    }
}