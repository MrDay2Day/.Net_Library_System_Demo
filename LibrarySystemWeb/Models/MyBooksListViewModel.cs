namespace LibrarySystemWeb.Models
{
    public class MyBooksListViewModel
    {
        public int pageNum { get; set; } = 1;
        public int currentPage { get; set; } = 0;
        public int maxPages{ get; set; } = 0;
    }
}
