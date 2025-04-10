﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrarySystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Library_SystemEntities : DbContext
    {
        public Library_SystemEntities()
            : base("name=Library_SystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<LateFeePayment> LateFeePayments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
    
        public virtual ObjectResult<sp_BorrowBook_Result> sp_BorrowBook(Nullable<int> book_id, Nullable<int> user_id, Nullable<int> borrow_days)
        {
            var book_idParameter = book_id.HasValue ?
                new ObjectParameter("book_id", book_id) :
                new ObjectParameter("book_id", typeof(int));
    
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            var borrow_daysParameter = borrow_days.HasValue ?
                new ObjectParameter("borrow_days", borrow_days) :
                new ObjectParameter("borrow_days", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BorrowBook_Result>("sp_BorrowBook", book_idParameter, user_idParameter, borrow_daysParameter);
        }
    
        public virtual int sp_FetchBooks(Nullable<int> page_number, Nullable<int> is_available, string search_text)
        {
            var page_numberParameter = page_number.HasValue ?
                new ObjectParameter("page_number", page_number) :
                new ObjectParameter("page_number", typeof(int));
    
            var is_availableParameter = is_available.HasValue ?
                new ObjectParameter("is_available", is_available) :
                new ObjectParameter("is_available", typeof(int));
    
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_FetchBooks", page_numberParameter, is_availableParameter, search_textParameter);
        }
    
        public virtual ObjectResult<sp_ReturnBook_Result> sp_ReturnBook(Nullable<int> borrow_id, Nullable<decimal> daily_late_fee)
        {
            var borrow_idParameter = borrow_id.HasValue ?
                new ObjectParameter("borrow_id", borrow_id) :
                new ObjectParameter("borrow_id", typeof(int));
    
            var daily_late_feeParameter = daily_late_fee.HasValue ?
                new ObjectParameter("daily_late_fee", daily_late_fee) :
                new ObjectParameter("daily_late_fee", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ReturnBook_Result>("sp_ReturnBook", borrow_idParameter, daily_late_feeParameter);
        }
    
        public virtual ObjectResult<sp_FetchBooks_Simple_Result> sp_FetchBooks_Simple(Nullable<int> is_available, string search_text)
        {
            var is_availableParameter = is_available.HasValue ?
                new ObjectParameter("is_available", is_available) :
                new ObjectParameter("is_available", typeof(int));
    
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_FetchBooks_Simple_Result>("sp_FetchBooks_Simple", is_availableParameter, search_textParameter);
        }
    
        public virtual int sp_FetchBooks_Count_Only(Nullable<int> is_available, string search_text)
        {
            var is_availableParameter = is_available.HasValue ?
                new ObjectParameter("is_available", is_available) :
                new ObjectParameter("is_available", typeof(int));
    
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_FetchBooks_Count_Only", is_availableParameter, search_textParameter);
        }
    
        public virtual ObjectResult<sp_FetchBooks_Search_Only_Result> sp_FetchBooks_Search_Only(Nullable<int> page_number, Nullable<int> is_available, Nullable<int> page_size, string search_text)
        {
            var page_numberParameter = page_number.HasValue ?
                new ObjectParameter("page_number", page_number) :
                new ObjectParameter("page_number", typeof(int));
    
            var is_availableParameter = is_available.HasValue ?
                new ObjectParameter("is_available", is_available) :
                new ObjectParameter("is_available", typeof(int));
    
            var page_sizeParameter = page_size.HasValue ?
                new ObjectParameter("page_size", page_size) :
                new ObjectParameter("page_size", typeof(int));
    
            var search_textParameter = search_text != null ?
                new ObjectParameter("search_text", search_text) :
                new ObjectParameter("search_text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_FetchBooks_Search_Only_Result>("sp_FetchBooks_Search_Only", page_numberParameter, is_availableParameter, page_sizeParameter, search_textParameter);
        }
    }
}
