//------------------------------------------------------------------------------
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
    
    public partial class sp_BorrowBook_Result
    {
        public int Borrow_id { get; set; }
        public string Title { get; set; }
        public string Borrower_Name { get; set; }
        public System.DateTime Borrow_date { get; set; }
        public System.DateTime Schedule_return_date { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
