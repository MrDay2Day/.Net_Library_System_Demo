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
    using System.Collections.Generic;
    
    public partial class LateFeePayment
    {
        public int Payment_id { get; set; }
        public int Borrow_id { get; set; }
        public decimal Amount { get; set; }
        public bool Paid { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    
        public virtual Borrow Borrow { get; set; }
    }
}
