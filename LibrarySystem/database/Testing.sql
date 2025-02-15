EXEC sp_FetchBooks @page_number = 1, @is_available = 1, @search_text = NULL;
GO

EXEC sp_BorrowBook @book_id = 1, @user_id = 7, @borrow_days = 7;
GO

